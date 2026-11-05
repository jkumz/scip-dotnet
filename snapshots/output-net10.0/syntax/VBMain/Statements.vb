  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                enclosing_range 0:8-0:26
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            enclosing_range 0:8-0:26
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39
  Imports System.IO
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                enclosing_range 1:8-1:17
'         ^^^^^^^^^ reference scip-dotnet nuget . . IO/
'                   enclosing_range 1:8-1:17
'                ^^ reference scip-dotnet nuget . . IO/
'                   enclosing_range 1:8-1:17

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
'                  enclosing_range 3:10-3:16
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
'                      enclosing_range 4:5-4:20
      Public Class Statements
'                  ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#
'                             enclosing_range 4:4-5:27
'                             documentation ```vb\nClass Statements\n```
          Private Sub [Try]()
'                     ^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Try().
'                           enclosing_range 6:8-6:27
'                           documentation ```vb\nPrivate Sub Statements.Try()\n```
              Try
                  File.ReadLines("asd")
'                 ^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
'                      enclosing_range 8:16-8:37
'                      ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#ReadLines().
'                                enclosing_range 8:16-8:37
              Catch err As Exception
'                   ^^^ definition local 0
'                       enclosing_range 6:8-12:15
'                       documentation ```vb\nerr As Class Exception\n```
'                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Exception#
'                   ^^^ reference local 0
'                       enclosing_range 9:18-9:21
'                          ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Exception#
'                                    enclosing_range 9:25-9:34
                  Console.WriteLine(err)
'                 ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
'                         enclosing_range 10:16-10:38
'                         ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+9).
'                                   enclosing_range 10:16-10:38
'                                   ^^^ reference local 0
'                                       enclosing_range 10:34-10:37
              End Try
          End Sub

          Private Sub TryWithoutExceptionVariable(fileName As String)
'                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#TryWithoutExceptionVariable().
'                                                 enclosing_range 14:8-14:67
'                                                 documentation ```vb\nPrivate Sub Statements.TryWithoutExceptionVariable(fileName As String)\n```
'                                                 ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#TryWithoutExceptionVariable().(fileName)
'                                                          enclosing_range 14:8-14:67
'                                                          documentation ```vb\nfileName As String\n```
'                                                          relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
              Try
                  File.ReadLines(fileName)
'                 ^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
'                      enclosing_range 16:16-16:40
'                      ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#ReadLines().
'                                enclosing_range 16:16-16:40
'                                ^^^^^^^^ reference scip-dotnet nuget . . VBMain/Statements#TryWithoutExceptionVariable().(fileName)
'                                         enclosing_range 16:31-16:39
              Catch When fileName.Length = 0
'                        ^^^^^^^^ reference scip-dotnet nuget . . VBMain/Statements#TryWithoutExceptionVariable().(fileName)
'                                 enclosing_range 17:23-17:38
'                                 ^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/String#Length.
'                                        enclosing_range 17:23-17:38
                  Console.WriteLine("empty file name")
'                 ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
'                         enclosing_range 18:16-18:52
'                         ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
'                                   enclosing_range 18:16-18:52
              Catch
                  Console.WriteLine("failed")
'                 ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
'                         enclosing_range 20:16-20:43
'                         ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
'                                   enclosing_range 20:16-20:43
              End Try
          End Sub

          Private Function [Default]() As (A As String, B As Boolean)
'                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Default().
'                                    enclosing_range 24:8-24:67
'                                    documentation ```vb\nPrivate Function Statements.Default() As (A As String, B As Boolean)\n```
              Dim C As (A As String, B As Boolean) = ("42", 42)
'                 ^ definition local 1
'                   enclosing_range 24:8-27:20
'                   documentation ```vb\nC As (A As String, B As Boolean)\n```
'                   relationship type_definition local 2
              Return C
'                    ^ reference local 1
'                      enclosing_range 26:19-26:20
          End Function

          Public Class Inferred
'                      ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Inferred#
'                               enclosing_range 29:8-29:29
'                               documentation ```vb\nClass Inferred\n```
              Property F1 As Int32
'                      ^^ definition scip-dotnet nuget . . VBMain/Statements#Inferred#F1.
'                         enclosing_range 30:12-30:32
'                         documentation ```vb\nPublic Property Inferred.F1 As Integer\n```
'                         relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                            ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                  enclosing_range 30:27-30:32
              Property F2 As Int32
'                      ^^ definition scip-dotnet nuget . . VBMain/Statements#Inferred#F2.
'                         enclosing_range 31:12-31:32
'                         documentation ```vb\nPublic Property Inferred.F2 As Integer\n```
'                         relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                            ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                  enclosing_range 31:27-31:32
          End Class

          Private Sub InferredTuples()
'                     ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#InferredTuples().
'                                    enclosing_range 34:8-34:36
'                                    documentation ```vb\nPrivate Sub Statements.InferredTuples()\n```
              Dim List = New List(Of Inferred)()
'                 ^^^^ definition local 3
'                      enclosing_range 34:8-37:15
'                      documentation ```vb\nList As Class List(Of Inferred)\n```
'                      relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#
'                                    ^^^^^^^^ reference scip-dotnet nuget . . VBMain/Statements#Inferred#
'                                             enclosing_range 35:35-35:43
              Dim Result = List.Select(Function(c) (c.F1, c.F2)).Where(Function(t) t.F2 = 1)
'                 ^^^^^^ definition local 4
'                        enclosing_range 34:8-37:15
'                        documentation ```vb\nResult As Interface IEnumerable(Of (F1 As Integer, F2 As Integer))\n```
'                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
'                          ^^^^ reference local 3
'                               enclosing_range 36:25-36:62
'                               ^^^^^^ reference scip-dotnet nuget System.Linq 10.0.0.0 Linq/Enumerable#Select(+1).
'                                      enclosing_range 36:25-36:62
'                                               ^ definition local 6
'                                                 enclosing_range 36:37-36:48
'                                                 documentation ```vb\nc As Inferred\n```
'                                                 relationship type_definition scip-dotnet nuget . . VBMain/Statements#Inferred#
'                                                   ^ reference local 6
'                                                     enclosing_range 36:50-36:54
'                                                     ^^ reference scip-dotnet nuget . . VBMain/Statements#Inferred#F1.
'                                                        enclosing_range 36:50-36:54
'                                                         ^ reference local 6
'                                                           enclosing_range 36:56-36:60
'                                                           ^^ reference scip-dotnet nuget . . VBMain/Statements#Inferred#F2.
'                                                              enclosing_range 36:56-36:60
'                                                                ^^^^^ reference scip-dotnet nuget System.Linq 10.0.0.0 Linq/Enumerable#Where().
'                                                                      enclosing_range 36:25-36:90
'                                                                               ^ definition local 8
'                                                                                 enclosing_range 36:69-36:80
'                                                                                 documentation ```vb\nt As (F1 As Integer, F2 As Integer)\n```
'                                                                                 relationship type_definition local 9
'                                                                                  ^ reference local 8
'                                                                                    enclosing_range 36:81-36:85
'                                                                                    ^^ reference local 10
'                                                                                       enclosing_range 36:81-36:85
          End Sub

          Private Function MultipleInitializers() As Integer
'                          ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MultipleInitializers().
'                                               enclosing_range 39:8-39:58
'                                               documentation ```vb\nPrivate Function Statements.MultipleInitializers() As Integer\n```
              Dim a As Integer = 1, b As Integer = 2
'                 ^ definition local 11
'                   enclosing_range 39:8-42:20
'                   documentation ```vb\na As Integer\n```
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                   ^ definition local 12
'                                     enclosing_range 39:8-42:20
'                                     documentation ```vb\nb As Integer\n```
'                                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return a + b
'                    ^ reference local 11
'                      enclosing_range 41:19-41:24
'                        ^ reference local 12
'                          enclosing_range 41:19-41:24
          End Function

          Class MyDisposable
'               ^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                            enclosing_range 44:8-44:26
'                            documentation ```vb\nClass MyDisposable\n```
'                            relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#
              Implements IDisposable
'                        ^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#
'                                    enclosing_range 45:23-45:34

              Private Sub Dispose() Implements IDisposable.Dispose
'                         ^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MyDisposable#Dispose().
'                                 enclosing_range 47:12-47:64
'                                 documentation ```vb\nPrivate Sub MyDisposable.Dispose()\n```
'                                 relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#Dispose().
'                                              ^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#
'                                                          enclosing_range 47:45-47:64
'                                                          ^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#Dispose().
'                                                                  enclosing_range 47:45-47:64
                  Throw New NotImplementedException()
'                           ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
'                                                   enclosing_range 48:22-48:51
              End Sub
          End Class

          Private Function [Using]() As MyDisposable
'                          ^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Using().
'                                  enclosing_range 52:8-52:50
'                                  documentation ```vb\nPrivate Function Statements.Using() As MyDisposable\n```
'                                       ^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                                                    enclosing_range 52:38-52:50
              Dim b = New MyDisposable()
'                 ^ definition local 13
'                   enclosing_range 52:8-58:20
'                   documentation ```vb\nb As Class MyDisposable\n```
'                   relationship type_definition scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                                      enclosing_range 53:20-53:38

              Using a = b
'                   ^ definition local 14
'                     enclosing_range 52:8-58:20
'                     documentation ```vb\na As Class MyDisposable\n```
'                     relationship type_definition scip-dotnet nuget . . VBMain/Statements#MyDisposable#
'                       ^ reference local 13
'                         enclosing_range 55:22-55:23
                  Return a
'                        ^ reference local 14
'                          enclosing_range 56:23-56:24
              End Using
          End Function

          Private Function MultipleUsing() As Long
'                          ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#MultipleUsing().
'                                        enclosing_range 60:8-60:48
'                                        documentation ```vb\nPrivate Function Statements.MultipleUsing() As Long\n```
              Using a As Stream = File.OpenRead("a"), b As Stream = File.OpenRead("a")
'                   ^ definition local 15
'                     enclosing_range 60:8-64:20
'                     documentation ```vb\na As Class Stream\n```
'                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
'                        ^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
'                               enclosing_range 61:23-61:29
'                                 ^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
'                                      enclosing_range 61:32-61:50
'                                      ^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#OpenRead().
'                                               enclosing_range 61:32-61:50
'                                                     ^ definition local 16
'                                                       enclosing_range 60:8-64:20
'                                                       documentation ```vb\nb As Class Stream\n```
'                                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
'                                                          ^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
'                                                                 enclosing_range 61:57-61:63
'                                                                   ^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
'                                                                        enclosing_range 61:66-61:84
'                                                                        ^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#OpenRead().
'                                                                                 enclosing_range 61:66-61:84
                  Return a.Length + b.Length
'                        ^ reference local 15
'                          enclosing_range 62:23-62:31
'                          ^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#Length.
'                                 enclosing_range 62:23-62:31
'                                   ^ reference local 16
'                                     enclosing_range 62:34-62:42
'                                     ^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#Length.
'                                            enclosing_range 62:34-62:42
              End Using
          End Function

          Private Function Foreach() As Integer
'                          ^^^^^^^ definition scip-dotnet nuget . . VBMain/Statements#Foreach().
'                                  enclosing_range 66:8-66:45
'                                  documentation ```vb\nPrivate Function Statements.Foreach() As Integer\n```
              Dim y = New Integer() {1}
'                 ^ definition local 17
'                   enclosing_range 66:8-75:20
'                   documentation ```vb\ny As Integer()\n```
'                   relationship type_definition local 18
              Dim z = 0
'                 ^ definition local 19
'                   enclosing_range 66:8-75:20
'                   documentation ```vb\nz As Integer\n```
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#

              For Each x As Integer In y
'                      ^ definition local 20
'                        enclosing_range 66:8-75:20
'                        documentation ```vb\nx As Integer\n```
'                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                      ^ reference local 17
'                                        enclosing_range 70:37-70:38
                  z += x
'                 ^ reference local 19
'                   enclosing_range 71:16-71:17
'                      ^ reference local 20
'                        enclosing_range 71:21-71:22
              Next

              Return z
'                    ^ reference local 19
'                      enclosing_range 74:19-74:20
          End Function

      End Class
  End Namespace
