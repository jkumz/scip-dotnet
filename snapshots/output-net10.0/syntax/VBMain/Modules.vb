  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ read_access scip-dotnet nuget . . System/
'                enclosing_range 0:8-0:26
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39
'                ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
'                            enclosing_range 0:8-0:26
'                            ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39

  Namespace VBMain
'           ^^^^^^ read_access scip-dotnet nuget . . VBMain/
'                  enclosing_range 2:10-2:16
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
'                      enclosing_range 3:5-3:20
      Public Module Modules
'                   ^^^^^^^ definition scip-dotnet nuget . . VBMain/Modules#
'                           enclosing_range 3:4-4:25
'                           documentation ```vb\nModule Modules\n```
'                           kind Module
          Private Function [Function](ByVal b As Integer) As Integer
'                          ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Modules#Function().
'                                     enclosing_range 5:8-5:66
'                                     documentation ```vb\nPrivate Function Modules.Function(b As Integer) As Integer\n```
'                                     kind StaticMethod
'                                           ^ definition scip-dotnet nuget . . VBMain/Modules#Function().(b)
'                                             enclosing_range 5:8-5:66
'                                             documentation ```vb\nb As Integer\n```
'                                             kind Parameter
'                                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return b
'                    ^ read_access scip-dotnet nuget . . VBMain/Modules#Function().(b)
'                      enclosing_range 6:19-6:20
          End Function

          Private Sub [Sub](ByVal Optional a As Integer = 5)
'                     ^^^^^ definition scip-dotnet nuget . . VBMain/Modules#Sub().
'                           enclosing_range 9:8-9:58
'                           documentation ```vb\nPrivate Sub Modules.Sub([a As Integer = 5])\n```
'                           kind StaticMethod
'                                          ^ definition scip-dotnet nuget . . VBMain/Modules#Sub().(a)
'                                            enclosing_range 9:8-9:58
'                                            documentation ```vb\n[a As Integer = 5]\n```
'                                            kind Parameter
'                                            relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          End Sub

      End Module
  End Namespace
