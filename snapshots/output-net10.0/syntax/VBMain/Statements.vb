  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ read_access scip-dotnet nuget . . System/
'                enclosing_range 0:8-0:26
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39
'                ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
'                            enclosing_range 0:8-0:26
'                            ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39
  Imports System.IO
'         ^^^^^^ read_access scip-dotnet nuget . . System/
'                enclosing_range 1:8-1:17
'         ^^^^^^^^^ import scip-dotnet nuget . . IO/
'                   enclosing_range 1:8-1:17
'                ^^ read_access scip-dotnet nuget . . IO/
'                   enclosing_range 1:8-1:17

  Namespace VBMain
'           ^^^^^^ read_access scip-dotnet nuget . . VBMain/
'                  enclosing_range 3:10-3:16
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
'                      enclosing_range 4:5-4:20
      Public Class Statements
'                  ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#
'                             enclosing_range 4:4-5:27
'                             documentation ```vb\nClass Statements\n```
'                             kind Class
          Private Sub [Try]()
'                     ^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Try().
'                           enclosing_range 6:8-6:27
'                           documentation ```vb\nPrivate Sub Statements.Try()\n```
'                           kind Method
              Try
                  File.ReadLines("asd")
'                 ^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
'                      enclosing_range 8:16-8:37
'                      ^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#ReadLines().
'                                enclosing_range 8:16-8:37
              Catch err As Exception
'                   ^^^ definition local 0
'                       enclosing_range 6:8-12:15
'                       documentation ```vb\nerr As Class Exception\n```
'                       kind Variable
'                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Exception#
'                   ^^^ read_access local 0
'                       enclosing_range 9:18-9:21
'                          ^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Exception#
'                                    enclosing_range 9:25-9:34
                  Console.WriteLine(err)
'                 ^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#
'                         enclosing_range 10:16-10:38
'                         ^^^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+9).
'                                   enclosing_range 10:16-10:38
'                                   ^^^ read_access local 0
'                                       enclosing_range 10:34-10:37
              End Try
          End Sub

          Private Function [Default]() As (A As String, B As Boolean)
'                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Default().
'                                    enclosing_range 14:8-14:67
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
'                      enclosing_range 16:19-16:20
          End Function

          Public Class Inferred
'                      ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Inferred#
'                               enclosing_range 19:8-19:29
'                               documentation ```vb\nClass Inferred\n```
'                               kind Class
              Property F1 As Int32
'                      ^^ definition scip-dotnet nuget . . VBMain/Statements#Inferred#F1.
'                         enclosing_range 20:12-20:32
'                         documentation ```vb\nPublic Property Inferred.F1 As Integer\n```
'                         kind Property
'                         relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                            ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                  enclosing_range 20:27-20:32
              Property F2 As Int32
'                      ^^ definition scip-dotnet nuget . . VBMain/Statements#Inferred#F2.
'                         enclosing_range 21:12-21:32
'                         documentation ```vb\nPublic Property Inferred.F2 As Integer\n```
'                         kind Property
'                         relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                            ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                  enclosing_range 21:27-21:32
          End Class

          Private Sub InferredTuples()
'                     ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#InferredTuples().
'                                    enclosing_range 24:8-24:36
'                                    documentation ```vb\nPrivate Sub Statements.InferredTuples()\n```
'                                    kind Method
              Dim List = New List(Of Inferred)()
'                 ^^^^ definition local 3
'                      enclosing_range 24:8-27:15
'                      documentation ```vb\nList As Class List(Of Inferred)\n```
'                      kind Variable
'                      relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#
'                                    ^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Statements#Inferred#
'                                             enclosing_range 25:35-25:43
              Dim Result = List.Select(Function(c) (c.F1, c.F2)).Where(Function(t) t.F2 = 1)
'                 ^^^^^^ definition local 4
'                        enclosing_range 24:8-27:15
'                        documentation ```vb\nResult As Interface IEnumerable(Of (F1 As Integer, F2 As Integer))\n```
'                        kind Variable
'                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
'                          ^^^^ read_access local 3
'                               enclosing_range 26:25-26:62
'                               ^^^^^^ read_access scip-dotnet nuget System.Linq 10.0.0.0 Linq/Enumerable#Select().
'                                      enclosing_range 26:25-26:62
'                                               ^ definition local 6
'                                                 enclosing_range 26:37-26:48
'                                                 documentation ```vb\nc As Inferred\n```
'                                                 kind Parameter
'                                                 relationship type_definition scip-dotnet nuget . . VBMain/Statements#Inferred#
'                                                   ^ read_access local 6
'                                                     enclosing_range 26:50-26:54
'                                                     ^^ read_access scip-dotnet nuget . . VBMain/Statements#Inferred#F1.
'                                                        enclosing_range 26:50-26:54
'                                                         ^ read_access local 6
'                                                           enclosing_range 26:56-26:60
'                                                           ^^ read_access scip-dotnet nuget . . VBMain/Statements#Inferred#F2.
'                                                              enclosing_range 26:56-26:60
'                                                                ^^^^^ read_access scip-dotnet nuget System.Linq 10.0.0.0 Linq/Enumerable#Where().
'                                                                      enclosing_range 26:25-26:90
'                                                                               ^ definition local 8
'                                                                                 enclosing_range 26:69-26:80
'                                                                                 documentation ```vb\nt As (F1 As Integer, F2 As Integer)\n```
'                                                                                 kind Parameter
'                                                                                 relationship type_definition local 9
'                                                                                  ^ read_access local 8
'                                                                                    enclosing_range 26:81-26:85
'                                                                                    ^^ read_access local 10
'                                                                                       enclosing_range 26:81-26:85
          End Sub

          Private Function MultipleInitializers() As Integer
'                          ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MultipleInitializers().
'                                               enclosing_range 29:8-29:58
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
'                      enclosing_range 31:19-31:24
'                        ^ read_access local 12
'                          enclosing_range 31:19-31:24
          End Function

          Class MyDisposable
'               ^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                            enclosing_range 34:8-34:26
'                            documentation ```vb\nClass MyDisposable\n```
'                            kind Class
'                            relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#
              Implements IDisposable
'                        ^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#
'                                    enclosing_range 35:23-35:34

              Private Sub Dispose() Implements IDisposable.Dispose
'                         ^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MyDisposable#Dispose().
'                                 enclosing_range 37:12-37:64
'                                 documentation ```vb\nPrivate Sub MyDisposable.Dispose()\n```
'                                 kind Method
'                                 relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#Dispose().
'                                              ^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#
'                                                          enclosing_range 37:45-37:64
'                                                          ^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#Dispose().
'                                                                  enclosing_range 37:45-37:64
                  Throw New NotImplementedException()
'                           ^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
'                                                   enclosing_range 38:22-38:51
              End Sub
          End Class

          Private Function [Using]() As MyDisposable
'                          ^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Using().
'                                  enclosing_range 42:8-42:50
'                                  documentation ```vb\nPrivate Function Statements.Using() As MyDisposable\n```
'                                  kind Method
'                                       ^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                                                    enclosing_range 42:38-42:50
              Dim b = New MyDisposable()
'                 ^ definition local 13
'                   enclosing_range 42:8-48:20
'                   documentation ```vb\nb As Class MyDisposable\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                         ^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                                      enclosing_range 43:20-43:38

              Using a = b
'                   ^ definition local 14
'                     enclosing_range 42:8-48:20
'                     documentation ```vb\na As Class MyDisposable\n```
'                     kind Variable
'                     relationship type_definition scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                       ^ read_access local 13
'                         enclosing_range 45:22-45:23
                  Return a
'                        ^ read_access local 14
'                          enclosing_range 46:23-46:24
              End Using
          End Function

          Private Function MultipleUsing() As Long
'                          ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MultipleUsing().
'                                        enclosing_range 50:8-50:48
'                                        documentation ```vb\nPrivate Function Statements.MultipleUsing() As Long\n```
'                                        kind Method
              Using a As Stream = File.OpenRead("a"), b As Stream = File.OpenRead("a")
'                   ^ definition local 15
'                     enclosing_range 50:8-54:20
'                     documentation ```vb\na As Class Stream\n```
'                     kind Variable
'                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
'                        ^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
'                               enclosing_range 51:23-51:29
'                                 ^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
'                                      enclosing_range 51:32-51:50
'                                      ^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#OpenRead().
'                                               enclosing_range 51:32-51:50
'                                                     ^ definition local 16
'                                                       enclosing_range 50:8-54:20
'                                                       documentation ```vb\nb As Class Stream\n```
'                                                       kind Variable
'                                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
'                                                          ^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
'                                                                 enclosing_range 51:57-51:63
'                                                                   ^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
'                                                                        enclosing_range 51:66-51:84
'                                                                        ^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#OpenRead().
'                                                                                 enclosing_range 51:66-51:84
                  Return a.Length + b.Length
'                        ^ read_access local 15
'                          enclosing_range 52:23-52:31
'                          ^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#Length.
'                                 enclosing_range 52:23-52:31
'                                   ^ read_access local 16
'                                     enclosing_range 52:34-52:42
'                                     ^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#Length.
'                                            enclosing_range 52:34-52:42
              End Using
          End Function

          Private Function Foreach() As Integer
'                          ^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Foreach().
'                                  enclosing_range 56:8-56:45
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
'                                        enclosing_range 60:37-60:38
                  z += x
'                 ^ write_access local 19
'                   enclosing_range 61:16-61:17
'                      ^ read_access local 20
'                        enclosing_range 61:21-61:22
              Next

              Return z
'                    ^ read_access local 19
'                      enclosing_range 64:19-64:20
          End Function

      End Class
  End Namespace
