  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ read_access scip-dotnet nuget . . System/
'                enclosing_range 0:0-0:39
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:0-0:39
'                ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
'                            enclosing_range 0:0-0:39
'                            ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:0-0:39
  Imports System.IO
'         ^^^^^^ read_access scip-dotnet nuget . . System/
'                enclosing_range 1:0-1:17
'         ^^^^^^^^^ import scip-dotnet nuget . . IO/
'                   enclosing_range 1:0-1:17
'                ^^ read_access scip-dotnet nuget . . IO/
'                   enclosing_range 1:0-1:17

  Namespace VBMain
'           ^^^^^^ read_access scip-dotnet nuget . . VBMain/
'                  enclosing_range 3:0-3:16
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
'                      enclosing_range 4:4-5:27
      Public Class Statements
'                  ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#
'                             enclosing_range 4:4-67:13
'                             documentation ```vb\nClass Statements\n```
'                             kind Class
          Private Sub [Try]()
'                     ^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Try().
'                           enclosing_range 6:8-12:15
'                           documentation ```vb\nPrivate Sub Statements.Try()\n```
'                           kind Method
              Try
                  File.ReadLines("asd")
'                 ^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
'                      enclosing_range 6:8-12:15
'                      ^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#ReadLines().
'                                enclosing_range 6:8-12:15
              Catch err As Exception
'                   ^^^ definition local 0
'                       enclosing_range 6:8-12:15
'                       documentation ```vb\nerr As Class Exception\n```
'                       kind Variable
'                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Exception#
'                   ^^^ read_access local 0
'                       enclosing_range 6:8-12:15
'                          ^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Exception#
'                                    enclosing_range 6:8-12:15
                  Console.WriteLine(err)
'                 ^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#
'                         enclosing_range 6:8-12:15
'                         ^^^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+9).
'                                   enclosing_range 6:8-12:15
'                                   ^^^ read_access local 0
'                                       enclosing_range 6:8-12:15
              End Try
          End Sub

          Private Function [Default]() As (A As String, B As Boolean)
'                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Default().
'                                    enclosing_range 14:8-17:20
'                                    documentation ```vb\nPrivate Function Statements.Default() As (A As String, B As Boolean)\n```
'                                    kind Method
              Dim C As (A As String, B As Boolean) = ("42", 42)
'                 ^ definition local 1
'                   enclosing_range 14:8-17:20
'                   documentation ```vb\nC As (A As String, B As Boolean)\n```
'                   kind Variable
'                   relationship type_definition local 2
              Return C
'                    ^ read_access local 1
'                      enclosing_range 14:8-17:20
          End Function

          Public Class Inferred
'                      ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Inferred#
'                               enclosing_range 19:8-22:17
'                               documentation ```vb\nClass Inferred\n```
'                               kind Class
              Property F1 As Int32
'                      ^^ definition scip-dotnet nuget . . VBMain/Statements#Inferred#F1.
'                         enclosing_range 19:8-22:17
'                         documentation ```vb\nPublic Property Inferred.F1 As Integer\n```
'                         kind Property
'                         relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                            ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                  enclosing_range 20:12-20:32
              Property F2 As Int32
'                      ^^ definition scip-dotnet nuget . . VBMain/Statements#Inferred#F2.
'                         enclosing_range 19:8-22:17
'                         documentation ```vb\nPublic Property Inferred.F2 As Integer\n```
'                         kind Property
'                         relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                            ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                  enclosing_range 21:12-21:32
          End Class

          Private Sub InferredTuples()
'                     ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#InferredTuples().
'                                    enclosing_range 24:8-27:15
'                                    documentation ```vb\nPrivate Sub Statements.InferredTuples()\n```
'                                    kind Method
              Dim List = New List(Of Inferred)()
'                 ^^^^ definition local 3
'                      enclosing_range 24:8-27:15
'                      documentation ```vb\nList As Class List(Of Inferred)\n```
'                      kind Variable
'                      relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#
'                                    ^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Statements#Inferred#
'                                             enclosing_range 24:8-27:15
              Dim Result = List.Select(Function(c) (c.F1, c.F2)).Where(Function(t) t.F2 = 1)
'                 ^^^^^^ definition local 4
'                        enclosing_range 24:8-27:15
'                        documentation ```vb\nResult As Interface IEnumerable(Of (F1 As Integer, F2 As Integer))\n```
'                        kind Variable
'                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
'                          ^^^^ read_access local 3
'                               enclosing_range 24:8-27:15
'                               ^^^^^^ read_access scip-dotnet nuget System.Linq 10.0.0.0 Linq/Enumerable#Select().
'                                      enclosing_range 24:8-27:15
'                                               ^ definition local 6
'                                                 enclosing_range 26:37-26:48
'                                                 documentation ```vb\nc As Inferred\n```
'                                                 kind Parameter
'                                                 relationship type_definition scip-dotnet nuget . . VBMain/Statements#Inferred#
'                                                   ^ read_access local 6
'                                                     enclosing_range 24:8-27:15
'                                                     ^^ read_access scip-dotnet nuget . . VBMain/Statements#Inferred#F1.
'                                                        enclosing_range 24:8-27:15
'                                                         ^ read_access local 6
'                                                           enclosing_range 24:8-27:15
'                                                           ^^ read_access scip-dotnet nuget . . VBMain/Statements#Inferred#F2.
'                                                              enclosing_range 24:8-27:15
'                                                                ^^^^^ read_access scip-dotnet nuget System.Linq 10.0.0.0 Linq/Enumerable#Where().
'                                                                      enclosing_range 24:8-27:15
'                                                                               ^ definition local 8
'                                                                                 enclosing_range 26:69-26:80
'                                                                                 documentation ```vb\nt As (F1 As Integer, F2 As Integer)\n```
'                                                                                 kind Parameter
'                                                                                 relationship type_definition local 9
'                                                                                  ^ read_access local 8
'                                                                                    enclosing_range 24:8-27:15
'                                                                                    ^^ read_access local 10
'                                                                                       enclosing_range 24:8-27:15
          End Sub

          Private Function MultipleInitializers() As Integer
'                          ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MultipleInitializers().
'                                               enclosing_range 29:8-32:20
'                                               documentation ```vb\nPrivate Function Statements.MultipleInitializers() As Integer\n```
'                                               kind Method
              Dim a As Integer = 1, b As Integer = 2
'                 ^ definition local 11
'                   enclosing_range 29:8-32:20
'                   documentation ```vb\na As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                   ^ definition local 12
'                                     enclosing_range 29:8-32:20
'                                     documentation ```vb\nb As Integer\n```
'                                     kind Variable
'                                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return a + b
'                    ^ read_access local 11
'                      enclosing_range 29:8-32:20
'                        ^ read_access local 12
'                          enclosing_range 29:8-32:20
          End Function

          Class MyDisposable
'               ^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                            enclosing_range 34:8-40:17
'                            documentation ```vb\nClass MyDisposable\n```
'                            kind Class
'                            relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#
              Implements IDisposable
'                        ^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#
'                                    enclosing_range 35:12-35:34

              Private Sub Dispose() Implements IDisposable.Dispose
'                         ^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MyDisposable#Dispose().
'                                 enclosing_range 37:12-39:19
'                                 documentation ```vb\nPrivate Sub MyDisposable.Dispose()\n```
'                                 kind Method
'                                 relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#Dispose().
'                                              ^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#
'                                                          enclosing_range 37:12-37:64
'                                                          ^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#Dispose().
'                                                                  enclosing_range 37:12-37:64
                  Throw New NotImplementedException()
'                           ^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
'                                                   enclosing_range 37:12-39:19
              End Sub
          End Class

          Private Function [Using]() As MyDisposable
'                          ^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Using().
'                                  enclosing_range 42:8-48:20
'                                  documentation ```vb\nPrivate Function Statements.Using() As MyDisposable\n```
'                                  kind Method
'                                       ^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                                                    enclosing_range 42:8-42:50
              Dim b = New MyDisposable()
'                 ^ definition local 13
'                   enclosing_range 42:8-48:20
'                   documentation ```vb\nb As Class MyDisposable\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                         ^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                                      enclosing_range 42:8-48:20

              Using a = b
'                   ^ definition local 14
'                     enclosing_range 42:8-48:20
'                     documentation ```vb\na As Class MyDisposable\n```
'                     kind Variable
'                     relationship type_definition scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                       ^ read_access local 13
'                         enclosing_range 42:8-48:20
                  Return a
'                        ^ read_access local 14
'                          enclosing_range 42:8-48:20
              End Using
          End Function

          Private Function MultipleUsing() As Long
'                          ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MultipleUsing().
'                                        enclosing_range 50:8-54:20
'                                        documentation ```vb\nPrivate Function Statements.MultipleUsing() As Long\n```
'                                        kind Method
              Using a As Stream = File.OpenRead("a"), b As Stream = File.OpenRead("a")
'                   ^ definition local 15
'                     enclosing_range 50:8-54:20
'                     documentation ```vb\na As Class Stream\n```
'                     kind Variable
'                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
'                        ^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
'                               enclosing_range 50:8-54:20
'                                 ^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
'                                      enclosing_range 50:8-54:20
'                                      ^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#OpenRead().
'                                               enclosing_range 50:8-54:20
'                                                     ^ definition local 16
'                                                       enclosing_range 50:8-54:20
'                                                       documentation ```vb\nb As Class Stream\n```
'                                                       kind Variable
'                                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
'                                                          ^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
'                                                                 enclosing_range 50:8-54:20
'                                                                   ^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
'                                                                        enclosing_range 50:8-54:20
'                                                                        ^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#OpenRead().
'                                                                                 enclosing_range 50:8-54:20
                  Return a.Length + b.Length
'                        ^ read_access local 15
'                          enclosing_range 50:8-54:20
'                          ^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#Length.
'                                 enclosing_range 50:8-54:20
'                                   ^ read_access local 16
'                                     enclosing_range 50:8-54:20
'                                     ^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#Length.
'                                            enclosing_range 50:8-54:20
              End Using
          End Function

          Private Function Foreach() As Integer
'                          ^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Foreach().
'                                  enclosing_range 56:8-65:20
'                                  documentation ```vb\nPrivate Function Statements.Foreach() As Integer\n```
'                                  kind Method
              Dim y = New Integer() {1}
'                 ^ definition local 17
'                   enclosing_range 56:8-65:20
'                   documentation ```vb\ny As Integer()\n```
'                   kind Variable
'                   relationship type_definition local 18
              Dim z = 0
'                 ^ definition local 19
'                   enclosing_range 56:8-65:20
'                   documentation ```vb\nz As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#

              For Each x As Integer In y
'                      ^ definition local 20
'                        enclosing_range 56:8-65:20
'                        documentation ```vb\nx As Integer\n```
'                        kind Variable
'                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                      ^ read_access local 17
'                                        enclosing_range 56:8-65:20
                  z += x
'                 ^ write_access local 19
'                   enclosing_range 56:8-65:20
'                      ^ read_access local 20
'                        enclosing_range 56:8-65:20
              Next

              Return z
'                    ^ read_access local 19
'                      enclosing_range 56:8-65:20
          End Function

      End Class
  End Namespace
