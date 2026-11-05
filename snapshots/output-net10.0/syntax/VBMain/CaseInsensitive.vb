  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/
'                  enclosing_range 0:10-0:16
      Public Class CaseInsensitive
'                  ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/CaseInsensitive#
'                                  enclosing_range 1:4-1:32
'                                  documentation ```vb\nClass CaseInsensitive\n```
          Public Sub DifferentCase(wEiRdCaSiNg As String)
'                    ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/CaseInsensitive#DifferentCase().
'                                  enclosing_range 2:8-2:55
'                                  documentation ```vb\nPublic Sub CaseInsensitive.DifferentCase(wEiRdCaSiNg As String)\n```
'                                  ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/CaseInsensitive#DifferentCase().(wEiRdCaSiNg)
'                                              enclosing_range 2:8-2:55
'                                              documentation ```vb\nwEiRdCaSiNg As String\n```
'                                              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
              Console.WriteLine(WeIrDcAsInG)
'             ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
'                     enclosing_range 3:12-3:42
'                     ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
'                               enclosing_range 3:12-3:42
'                               ^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/CaseInsensitive#DifferentCase().(wEiRdCaSiNg)
'                                           enclosing_range 3:30-3:41
          End Sub
      End Class
  End Namespace
