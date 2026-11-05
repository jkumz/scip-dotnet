  Namespace SymbolKinds
'           ^^^^^^^^^^^ reference scip-dotnet nuget . . SymbolKinds/
'                       enclosing_range 0:10-0:21
      Public Class VBClass
'                  ^^^^^^^ definition scip-dotnet nuget . . SymbolKinds/VBClass#
'                          enclosing_range 1:4-1:24
'                          documentation ```vb\nClass VBClass\n```
      End Class

      Public Module VBModule
'                   ^^^^^^^^ definition scip-dotnet nuget . . SymbolKinds/VBModule#
'                            enclosing_range 4:4-4:26
'                            documentation ```vb\nModule VBModule\n```
          Public Sub ModuleMethod()
'                    ^^^^^^^^^^^^ definition scip-dotnet nuget . . SymbolKinds/VBModule#ModuleMethod().
'                                 enclosing_range 5:8-5:33
'                                 documentation ```vb\nPublic Sub VBModule.ModuleMethod()\n```
              Dim marker = "🚀" : ModuleMethod()
'                 ^^^^^^ definition local 0
'                        enclosing_range 5:8-7:15
'                        documentation ```vb\nmarker As String\n```
'                        relationship type_definition scip-dotnet nuget System.Runtime 8.0.0.0 System/String#
'                                 ^^^^^^^^^^^^ reference scip-dotnet nuget . . SymbolKinds/VBModule#ModuleMethod().
'                                              enclosing_range 6:32-6:46
          End Sub
      End Module
  End Namespace
