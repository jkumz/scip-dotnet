  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ read_access scip-dotnet nuget . . System/
'                enclosing_range 0:0-0:39
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:0-0:39
'                ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
'                            enclosing_range 0:0-0:39
'                            ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:0-0:39

  Namespace VBMain
'           ^^^^^^ read_access scip-dotnet nuget . . VBMain/
'                  enclosing_range 2:0-2:16
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
'                      enclosing_range 3:4-4:25
      Public Module Modules
'                   ^^^^^^^ definition scip-dotnet nuget . . VBMain/Modules#
'                           enclosing_range 3:4-12:14
'                           documentation ```vb\nModule Modules\n```
'                           kind Module
          Private Function [Function](ByVal b As Integer) As Integer
'                          ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Modules#Function().
'                                     enclosing_range 5:8-7:20
'                                     documentation ```vb\nPrivate Function Modules.Function(b As Integer) As Integer\n```
'                                     kind StaticMethod
'                                           ^ definition scip-dotnet nuget . . VBMain/Modules#Function().(b)
'                                             enclosing_range 5:8-5:66
'                                             documentation ```vb\nb As Integer\n```
'                                             kind Parameter
'                                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return b
'                    ^ read_access scip-dotnet nuget . . VBMain/Modules#Function().(b)
'                      enclosing_range 5:8-7:20
          End Function

          Private Sub [Sub](ByVal Optional a As Integer = 5)
'                     ^^^^^ definition scip-dotnet nuget . . VBMain/Modules#Sub().
'                           enclosing_range 9:8-10:15
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
