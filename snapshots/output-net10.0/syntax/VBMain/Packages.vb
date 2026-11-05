  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                enclosing_range 0:8-0:26
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            enclosing_range 0:8-0:26
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39
  Imports DiffPlex.DiffBuilder
'         ^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffPlex/
'                  enclosing_range 1:8-1:28
'         ^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffBuilder/
'                              enclosing_range 1:8-1:28
'                  ^^^^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffBuilder/
'                              enclosing_range 1:8-1:28
  Imports DiffPlex.DiffBuilder.Model
'         ^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffPlex/
'                  enclosing_range 2:8-2:28
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 Model/
'                                    enclosing_range 2:8-2:34
'                  ^^^^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffBuilder/
'                              enclosing_range 2:8-2:28
'                              ^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 Model/
'                                    enclosing_range 2:8-2:34

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
'                  enclosing_range 4:10-4:16
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
'                      enclosing_range 5:5-5:20
      Public Class Packages
'                  ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Packages#
'                           enclosing_range 5:4-6:25
'                           documentation ```vb\nClass Packages\n```
          Private Function Diff() As DiffPaneModel
'                          ^^^^ definition scip-dotnet nuget . . VBMain/Packages#Diff().
'                               enclosing_range 7:8-7:48
'                               documentation ```vb\nPrivate Function Packages.Diff() As DiffPaneModel\n```
'                                    ^^^^^^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 Model/DiffPaneModel#
'                                                  enclosing_range 7:35-7:48
              Return InlineDiffBuilder.Diff("a", "b")
'                    ^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffBuilder/InlineDiffBuilder#
'                                      enclosing_range 8:19-8:51
'                                      ^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffBuilder/InlineDiffBuilder#Diff().
'                                           enclosing_range 8:19-8:51
          End Function
      End Class
  End Namespace
