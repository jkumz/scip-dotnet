  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                enclosing_range 0:8-0:26
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . System/Diagnostics/CodeAnalysis/
'                                         enclosing_range 0:8-0:39
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . System/Diagnostics/
'                            enclosing_range 0:8-0:26
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . System/Diagnostics/CodeAnalysis/
'                                         enclosing_range 0:8-0:39

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/
'                  enclosing_range 2:10-2:16
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Diagnostics/CodeAnalysis/SuppressMessageAttribute#`.ctor`().
'                      enclosing_range 3:5-3:20
      Public Class Preprocessors
'                  ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Preprocessors#
'                                enclosing_range 3:4-4:30
'                                documentation ```vb\nClass Preprocessors\n```
          Private Function OperatingSystem() As String
'                          ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Preprocessors#OperatingSystem().
'                                          enclosing_range 5:8-5:52
'                                          documentation ```vb\nPrivate Function Preprocessors.OperatingSystem() As String\n```
  #If WIN32 Then
              Dim Os As String = "Win32"
  #warning This class is bad.
  #error Okay, just stop.
  #elif MACOS
              Dim Os As String = "MacOS"
  #Else
              Dim Os As String = "Unknown"
'                 ^^ definition local 0
'                    enclosing_range 5:8-16:20
'                    documentation ```vb\nOs As String\n```
'                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
  #End If
              Return Os
'                    ^^ reference local 0
'                       enclosing_range 15:19-15:21
          End Function
      End Class
  End Namespace
