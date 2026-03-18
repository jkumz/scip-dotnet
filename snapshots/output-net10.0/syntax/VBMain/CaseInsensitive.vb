  Namespace VBMain
'           ^^^^^^ read_access scip-dotnet nuget . . VBMain/
'                  enclosing_range 0:10-0:16
      Public Class CaseInsensitive
'                  ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/CaseInsensitive#
'                                  enclosing_range 1:4-1:32
'                                  documentation ```vb\nClass CaseInsensitive\n```
'                                  kind Class
          Public Sub DifferentCase(wEiRdCaSiNg As String)
'                    ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/CaseInsensitive#DifferentCase().
'                                  enclosing_range 2:8-2:55
'                                  documentation ```vb\nPublic Sub CaseInsensitive.DifferentCase(wEiRdCaSiNg As String)\n```
'                                  kind Method
'                                  ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/CaseInsensitive#DifferentCase().(wEiRdCaSiNg)
'                                              enclosing_range 2:8-2:55
'                                              documentation ```vb\nwEiRdCaSiNg As String\n```
'                                              kind Parameter
'                                              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
              Console.WriteLine(WeIrDcAsInG)
'             ^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#
'                     enclosing_range 3:12-3:42
'                     ^^^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
'                               enclosing_range 3:12-3:42
'                               ^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/CaseInsensitive#DifferentCase().(wEiRdCaSiNg)
'                                           enclosing_range 3:30-3:41
          End Sub
      End Class
  End Namespace
