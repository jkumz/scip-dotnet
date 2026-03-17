  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ read_access scip-dotnet nuget . . System/
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
//             ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/
  using DiffPlex.DiffBuilder;
//      ^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffPlex/
//      ^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget DiffPlex 1.7.1.0 DiffBuilder/
//               ^^^^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffBuilder/
  using DiffPlex.DiffBuilder.Model;
//      ^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffPlex/
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget DiffPlex 1.7.1.0 Model/
//               ^^^^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffBuilder/
//                           ^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 Model/

  namespace Main;
//          ^^^^ read_access scip-dotnet nuget . . Main/
//               enclosing_range 4:0-13:1

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
//                 enclosing_range 6:0-13:1
  public class Packages
//             ^^^^^^^^ definition scip-dotnet nuget . . Main/Packages#
//                      enclosing_range 4:0-13:1
//                      documentation ```cs\nclass Packages\n```
//                      kind Class
  {
      DiffPaneModel Diff()
//    ^^^^^^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 Model/DiffPaneModel#
//                  enclosing_range 9:4-12:5
//                  ^^^^ definition scip-dotnet nuget . . Main/Packages#Diff().
//                       enclosing_range 6:0-13:1
//                       documentation ```cs\nprivate DiffPaneModel Packages.Diff()\n```
//                       kind Method
      {
          return InlineDiffBuilder.Diff("a", "b");
//               ^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffBuilder/InlineDiffBuilder#
//                                 enclosing_range 9:4-12:5
//                                 ^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffBuilder/InlineDiffBuilder#Diff().
//                                      enclosing_range 9:4-12:5
      }
  }
