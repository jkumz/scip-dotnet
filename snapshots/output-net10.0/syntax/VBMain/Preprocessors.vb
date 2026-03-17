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
'                      enclosing_range 3:4-4:30
      Public Class Preprocessors
'                  ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Preprocessors#
'                                enclosing_range 3:4-17:13
'                                documentation ```vb\nClass Preprocessors\n```
'                                kind Class
          Private Function OperatingSystem() As String
'                          ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Preprocessors#OperatingSystem().
'                                          enclosing_range 5:8-16:20
'                                          documentation ```vb\nPrivate Function Preprocessors.OperatingSystem() As String\n```
'                                          kind Method
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
'                    kind Variable
'                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
  #End If
              Return Os
'                    ^^ read_access local 0
'                       enclosing_range 5:8-16:20
          End Function
      End Class
  End Namespace
