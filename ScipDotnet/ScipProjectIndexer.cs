using System.Collections.Concurrent;
using System.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Scip;
using CodeAnalysisDocument = Microsoft.CodeAnalysis.Document;

namespace ScipDotnet;

/// <summary>
/// Orchestrates Roslyn and MSBuild APIs to SCIP index a given project.
/// Collects both document-level symbols and cross-assembly external symbols
/// when the EmitExternalSymbols option is enabled.
/// </summary>
public class ScipProjectIndexer
{
    public ScipProjectIndexer(ILogger<ScipProjectIndexer> logger) =>
        Logger = logger;

    private ILogger<ScipProjectIndexer> Logger { get; }

    private void Restore(IndexCommandOptions options, FileInfo project)
    {
        var arguments = project.Extension.Equals(".sln") ? $"restore {project.FullName} /p:EnableWindowsTargeting=true" : "restore /p:EnableWindowsTargeting=true";
        if (options.NugetConfigPath != null)
        {
            arguments += $" --configfile \"{options.NugetConfigPath.FullName}\"";
        }
        var process = new Process()
        {
            StartInfo = new ProcessStartInfo()
            {
                WorkingDirectory = options.WorkingDirectory.FullName,
                FileName = "dotnet",
                Arguments = arguments
            }
        };
        options.Logger.LogInformation("$ dotnet {Arguments}", arguments);
        process.Start();
        if (!process.WaitForExit(options.DotnetRestoreTimeout))
        {
            Logger.LogWarning("Dotnet restore did not finish in {Time} milliseconds, the results of the indexing might be incorrect.", options.DotnetRestoreTimeout);
        }
    }

    /// <summary>
    /// Indexes all documents across all projects and returns the collected documents
    /// along with any external symbol information gathered during indexing.
    /// External symbols are deduplicated across all documents via a shared ConcurrentDictionary.
    /// </summary>
    /// <param name="host">The application host providing DI services.</param>
    /// <param name="options">Indexing options including the EmitExternalSymbols flag.</param>
    /// <returns>A tuple of (documents, externalSymbols).</returns>
    public async Task<(List<Scip.Document>, ICollection<SymbolInformation>)> IndexDocuments(IHost host, IndexCommandOptions options)
    {
        var documents = new List<Scip.Document>();
        var externalSymbols = new ConcurrentDictionary<string, SymbolInformation>();
        var indexedProjects = new HashSet<ProjectId>();

        foreach (var project in options.ProjectsFile)
        {
            await IndexProject(host, options, project, indexedProjects, documents, externalSymbols);
        }

        return (documents, externalSymbols.Values);
    }

    private async Task IndexProject(IHost host,
                                     IndexCommandOptions options,
                                     FileInfo rootProject,
                                     HashSet<ProjectId> indexedProjects,
                                     List<Scip.Document> documents,
                                     ConcurrentDictionary<string, SymbolInformation> externalSymbols)
    {
        if (!options.SkipDotnetRestore)
        {
            Restore(options, rootProject);
        }

        var projects = (string.Equals(rootProject.Extension, ".csproj") || string.Equals(rootProject.Extension, ".vbproj")
            ? new[]
            {
                await host.Services.GetRequiredService<MSBuildWorkspace>()
                    .OpenProjectAsync(rootProject.FullName)
            }
            : (await host.Services.GetRequiredService<MSBuildWorkspace>()
                .OpenSolutionAsync(rootProject.FullName)).Projects).ToList();


        options.Logger.LogDebug($"Found {projects.Count()} projects");
        var projectsPerProjFile = projects.GroupBy(x => x.FilePath);
        var framework = $"net{Environment.Version.Major}.0";
        foreach (var projectGroup in projectsPerProjFile)
        {

            // If the project was found by opening the solution, we need to find the project that matches the framework.
            // if we can' fall back to the first one. Without this, we will process the same document multiple times
            // once for each framework version being targeting and it leads to unpredictable results since the scip file
            // will contain the same document multiple times iwth different symbols.
            var project = projectGroup.FirstOrDefault(x => x.Name.Contains($"({framework})", StringComparison.OrdinalIgnoreCase)) ?? projectGroup.First();
            if (project.Language != "C#" && project.Language != "Visual Basic")
            {
                Logger.LogWarning(
                    "Skipping project {ProjectFilePath} because it has language {ProjectLanguage} and scip-dotnet currently only supports C# and Visual Basic.",
                    project.FilePath, project.Language);
                continue;
            }

            if (indexedProjects.Contains(project.Id))
            {
                continue;
            }

            indexedProjects.Add(project.Id);

            var globals = new Dictionary<ISymbol, ScipSymbol>(SymbolEqualityComparer.Default);

            // Obtain Compilation for external symbol assembly comparison.
            var compilation = await project.GetCompilationAsync();

            options.Logger.LogDebug($"Found {project.Documents.Count()} documents in {projectGroup.Key}");
            foreach (var document in project.Documents)
            {
                if (options.Matcher.Match(options.WorkingDirectory.FullName, document.FilePath).HasMatches)
                {
                    documents.Add(await IndexDocument(document, options, globals, project.Language, compilation, externalSymbols));
                }
                else
                {
                    options.Logger.LogDebug(
                        "Excluded file path '{FilePath}' because it did not match the provided --include and --exclude arguments",
                        document.FilePath);
                }
            }
        }
    }

    private async Task<Scip.Document> IndexDocument(CodeAnalysisDocument document,
                                                    IndexCommandOptions options,
                                                    Dictionary<ISymbol, ScipSymbol> globals,
                                                    string language,
                                                    Compilation? compilation,
                                                    ConcurrentDictionary<string, SymbolInformation> externalSymbols)
    {
        Scip.Document doc = new()
        {
            Language = language,
            RelativePath = document.FilePath == null
                ? null
                : Path.GetRelativePath(options.WorkingDirectory.FullName, document.FilePath),
            PositionEncoding = Scip.PositionEncoding.Utf16CodeUnitOffsetFromLineStart
        };
        var semanticModel = await document.GetSemanticModelAsync();
        if (semanticModel == null)
        {
            Logger.LogWarning(
                "Skipping document {DocumentFilePath} because document.GetSemanticModelAsync() returned null",
                document.FilePath);
        }
        else
        {
            var symbolFormatter = new ScipDocumentIndexer(doc, options, globals, compilation, externalSymbols);
            var root = await document.GetSyntaxRootAsync();
            if (language == "C#")
            {
                var walker = new ScipCSharpSyntaxWalker(symbolFormatter, semanticModel);
                walker.Visit(root);
            }
            else if (language == "Visual Basic")
            {
                var walker = new ScipVisualBasicSyntaxWalker(symbolFormatter, semanticModel);
                walker.Visit(root);
            }
        }

        return doc;
    }
}