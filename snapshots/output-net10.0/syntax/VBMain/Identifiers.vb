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
'                      enclosing_range 3:4-4:28
      Public Class Identifiers
'                  ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Identifiers#
'                              enclosing_range 3:4-16:13
'                              documentation ```vb\nClass Identifiers\n```
'                              kind Class
          Private Sub SpecialNames()
'                     ^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Identifiers#SpecialNames().
'                                  enclosing_range 5:8-15:15
'                                  documentation ```vb\nPrivate Sub Identifiers.SpecialNames()\n```
'                                  kind Method
              Dim [const] = 42
'                 ^^^^^^^ definition local 0
'                         enclosing_range 5:8-15:15
'                         documentation ```vb\n[const] As Integer\n```
'                         kind Variable
'                         relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Dim var As Integer = [const]
'                 ^^^ definition local 1
'                     enclosing_range 5:8-15:15
'                     documentation ```vb\nvar As Integer\n```
'                     kind Variable
'                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                  ^^^^^^^ read_access local 0
'                                          enclosing_range 5:8-15:15
              Dim under_score = 0
'                 ^^^^^^^^^^^ definition local 2
'                             enclosing_range 5:8-15:15
'                             documentation ```vb\nunder_score As Integer\n```
'                             kind Variable
'                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Dim with1number = 0
'                 ^^^^^^^^^^^ definition local 3
'                             enclosing_range 5:8-15:15
'                             documentation ```vb\nwith1number As Integer\n```
'                             kind Variable
'                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Dim varæble = 0
'                 ^^^^^^^ definition local 4
'                         enclosing_range 5:8-15:15
'                         documentation ```vb\nvaræble As Integer\n```
'                         kind Variable
'                         relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Dim Переменная = 0
'                 ^^^^^^^^^^ definition local 5
'                            enclosing_range 5:8-15:15
'                            documentation ```vb\nПеременная As Integer\n```
'                            kind Variable
'                            relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Dim first‿letter = 0
'                 ^^^^^^^^^^^^ definition local 6
'                              enclosing_range 5:8-15:15
'                              documentation ```vb\nfirst‿letter As Integer\n```
'                              kind Variable
'                              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Dim ග්රහලෝකය = 0
'                 ^^^^^^^^ definition local 7
'                          enclosing_range 5:8-15:15
'                          documentation ```vb\nග්රහලෝකය As Integer\n```
'                          kind Variable
'                          relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Dim _كوكبxxx = 0
'                 ^^^^^^^^ definition local 8
'                          enclosing_range 5:8-15:15
'                          documentation ```vb\n_كوكبxxx As Integer\n```
'                          kind Variable
'                          relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          End Sub
      End Class
  End Namespace
