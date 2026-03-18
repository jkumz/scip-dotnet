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
      Public Class Literals
'                  ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Literals#
'                           enclosing_range 3:4-4:25
'                           documentation ```vb\nClass Literals\n```
'                           kind Class
          Private Function Interpolation() As String
'                          ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Literals#Interpolation().
'                                        enclosing_range 5:8-5:50
'                                        documentation ```vb\nPrivate Function Literals.Interpolation() As String\n```
'                                        kind Method
              Dim a = 1
'                 ^ definition local 0
'                   enclosing_range 5:8-11:20
'                   documentation ```vb\na As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Dim b = 2
'                 ^ definition local 1
'                   enclosing_range 5:8-11:20
'                   documentation ```vb\nb As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Dim c = 3
'                 ^ definition local 2
'                   enclosing_range 5:8-11:20
'                   documentation ```vb\nc As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Dim d = 3
'                 ^ definition local 3
'                   enclosing_range 5:8-11:20
'                   documentation ```vb\nd As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return $"a={a} b={b} c={c} d={d}"
'                         ^ read_access local 0
'                           enclosing_range 10:24-10:25
'                               ^ read_access local 1
'                                 enclosing_range 10:30-10:31
'                                     ^ read_access local 2
'                                       enclosing_range 10:36-10:37
'                                           ^ read_access local 3
'                                             enclosing_range 10:42-10:43
          End Function
      End Class
  End Namespace
