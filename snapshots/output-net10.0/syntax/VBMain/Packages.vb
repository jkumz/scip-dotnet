  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ read_access scip-dotnet nuget . . System/
'                enclosing_range 0:8-0:26
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39
'                ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
'                            enclosing_range 0:8-0:26
'                            ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39
  Imports DiffPlex.DiffBuilder
'         ^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffPlex/
'                  enclosing_range 1:8-1:28
'         ^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget DiffPlex 1.7.1.0 DiffBuilder/
'                              enclosing_range 1:8-1:28
'                  ^^^^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffBuilder/
'                              enclosing_range 1:8-1:28
  Imports DiffPlex.DiffBuilder.Model
'         ^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffPlex/
'                  enclosing_range 2:8-2:28
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget DiffPlex 1.7.1.0 Model/
'                                    enclosing_range 2:8-2:34
'                  ^^^^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffBuilder/
'                              enclosing_range 2:8-2:28
'                              ^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 Model/
'                                    enclosing_range 2:8-2:34

  Namespace VBMain
'           ^^^^^^ read_access scip-dotnet nuget . . VBMain/
'                  enclosing_range 4:10-4:16
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
'                      enclosing_range 5:5-5:20
      Public Class Packages
'                  ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Packages#
'                           enclosing_range 5:4-6:25
'                           documentation ```vb\nClass Packages\n```
'                           kind Class
          Private Function Diff() As DiffPaneModel
'                          ^^^^ definition scip-dotnet nuget . . VBMain/Packages#Diff().
'                               enclosing_range 7:8-7:48
'                               documentation ```vb\nPrivate Function Packages.Diff() As DiffPaneModel\n```
'                               kind Method
'                                    ^^^^^^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 Model/DiffPaneModel#
'                                                  enclosing_range 7:35-7:48
              Return InlineDiffBuilder.Diff("a", "b")
'                    ^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffBuilder/InlineDiffBuilder#
'                                      enclosing_range 8:19-8:51
'                                      ^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffBuilder/InlineDiffBuilder#Diff().
'                                           enclosing_range 8:19-8:51
          End Function
      End Class
  End Namespace
