  Module Program
'        ^^^^^^^ definition scip-dotnet nuget . . VBMain/Program#
'                enclosing_range 0:0-0:14
'                documentation ```vb\nModule Program\n```
'                kind Module
      Sub Main(args As String())
'         ^^^^ definition scip-dotnet nuget . . VBMain/Program#Main().
'              enclosing_range 1:4-1:30
'              documentation ```vb\nPublic Sub Program.Main(args As String())\n```
'              kind StaticMethod
'              ^^^^ definition scip-dotnet nuget . . VBMain/Program#Main().(args)
'                   enclosing_range 1:4-1:30
'                   documentation ```vb\nargs As String()\n```
'                   kind Parameter
'                   relationship type_definition local 0

          Console.WriteLine("Hello, World!")
'         ^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#
'                 enclosing_range 3:8-3:42
'                 ^^^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
'                           enclosing_range 3:8-3:42
      End Sub
  End Module
