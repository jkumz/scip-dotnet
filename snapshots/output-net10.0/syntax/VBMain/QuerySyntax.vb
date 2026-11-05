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
      Public Class QuerySyntax
'                  ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#
'                              enclosing_range 3:4-4:28
'                              documentation ```vb\nClass QuerySyntax\n```
          Private sourceA As List(Of IGeneric) = New List(Of IGeneric)()
'                 ^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#sourceA.
'                         enclosing_range 5:8-5:70
'                         documentation ```vb\nPrivate QuerySyntax.sourceA As List(Of IGeneric)\n```
'                         relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 System/Collections/Generic/List#
'                                    ^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#
'                                             enclosing_range 5:35-5:43
'                                                            ^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#
'                                                                     enclosing_range 5:59-5:67
          Private sourceB As List(Of IGeneric) = New List(Of IGeneric)()
'                 ^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#sourceB.
'                         enclosing_range 6:8-6:70
'                         documentation ```vb\nPrivate QuerySyntax.sourceB As List(Of IGeneric)\n```
'                         relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 System/Collections/Generic/List#
'                                    ^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#
'                                             enclosing_range 6:35-6:43
'                                                            ^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#
'                                                                     enclosing_range 6:59-6:67

          Interface IGeneric
'                   ^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#
'                            enclosing_range 8:8-8:26
'                            documentation ```vb\nInterface IGeneric\n```
              Function Method() As String
'                      ^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#Method().
'                             enclosing_range 9:12-9:39
'                             documentation ```vb\nFunction IGeneric.Method() As String\n```
          End Interface

          Private Sub [Select]()
'                     ^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Select().
'                              enclosing_range 12:8-12:30
'                              documentation ```vb\nPrivate Sub QuerySyntax.Select()\n```
              Dim x = From a In sourceA Select a.Method()
'                 ^ definition local 0
'                   enclosing_range 12:8-14:15
'                   documentation ```vb\nx As Interface IEnumerable(Of String)\n```
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Collections/Generic/IEnumerable#
'                          ^ definition local 1
'                            enclosing_range 12:8-14:15
'                            documentation ```vb\na As Interface IGeneric\n```
'                               ^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#sourceA.
'                                       enclosing_range 13:30-13:37
'                                              ^ reference local 1
'                                                enclosing_range 13:45-13:55
'                                                ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#Method().
'                                                       enclosing_range 13:45-13:55
          End Sub

          Private Sub Projection()
'                     ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Projection().
'                                enclosing_range 16:8-16:32
'                                documentation ```vb\nPrivate Sub QuerySyntax.Projection()\n```
              Dim x = From a In sourceA Select New With {Key .Name = a.Method()}
'                 ^ definition local 2
'                   enclosing_range 16:8-19:15
'                   documentation ```vb\nx As Interface IEnumerable(Of <anonymous type: Key Name As String>)\n```
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Collections/Generic/IEnumerable#
'                          ^ definition local 3
'                            enclosing_range 16:8-19:15
'                            documentation ```vb\na As Interface IGeneric\n```
'                               ^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#sourceA.
'                                       enclosing_range 17:30-17:37
'                                                             ^^^^ reference local 5
'                                                                  enclosing_range 17:60-17:64
'                                                                    ^ reference local 3
'                                                                      enclosing_range 17:67-17:77
'                                                                      ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#Method().
'                                                                             enclosing_range 17:67-17:77
              Dim b = From a In x Select a.Name
'                 ^ definition local 6
'                   enclosing_range 16:8-19:15
'                   documentation ```vb\nb As Interface IEnumerable(Of String)\n```
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Collections/Generic/IEnumerable#
'                          ^ definition local 7
'                            enclosing_range 16:8-19:15
'                            documentation ```vb\na As AnonymousType <anonymous type: Key Name As String>\n```
'                               ^ reference local 2
'                                 enclosing_range 18:30-18:31
'                                        ^ reference local 7
'                                          enclosing_range 18:39-18:45
'                                          ^^^^ reference local 5
'                                               enclosing_range 18:39-18:45
          End Sub

          Private Sub Where()
'                     ^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Where().
'                           enclosing_range 21:8-21:27
'                           documentation ```vb\nPrivate Sub QuerySyntax.Where()\n```
              Dim x = From a In sourceA Where a.Method().StartsWith("a") Select a
'                 ^ definition local 8
'                   enclosing_range 21:8-23:15
'                   documentation ```vb\nx As Interface IEnumerable(Of IGeneric)\n```
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Collections/Generic/IEnumerable#
'                          ^ definition local 9
'                            enclosing_range 21:8-23:15
'                            documentation ```vb\na As Interface IGeneric\n```
'                               ^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#sourceA.
'                                       enclosing_range 22:30-22:37
'                                             ^ reference local 9
'                                               enclosing_range 22:44-22:54
'                                               ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#Method().
'                                                      enclosing_range 22:44-22:54
'                                                        ^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/String#StartsWith(+1).
'                                                                   enclosing_range 22:44-22:70
'                                                                               ^ reference local 9
'                                                                                 enclosing_range 22:78-22:79
          End Sub

          Private Sub [Let]()
'                     ^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Let().
'                           enclosing_range 25:8-25:27
'                           documentation ```vb\nPrivate Sub QuerySyntax.Let()\n```
              Dim x = From a In sourceA Let z = New With {Key .A = a.Method(), Key .B = a.Method()} Select z
'                 ^ definition local 10
'                   enclosing_range 25:8-27:15
'                   documentation ```vb\nx As Interface IEnumerable(Of <anonymous type: Key A As String, Key B As String>)\n```
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Collections/Generic/IEnumerable#
'                          ^ definition local 11
'                            enclosing_range 25:8-27:15
'                            documentation ```vb\na As Interface IGeneric\n```
'                               ^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#sourceA.
'                                       enclosing_range 26:30-26:37
'                                           ^ definition local 12
'                                             enclosing_range 25:8-27:15
'                                             documentation ```vb\nz As AnonymousType <anonymous type: Key A As String, Key B As String>\n```
'                                                              ^ reference local 14
'                                                                enclosing_range 26:61-26:62
'                                                                  ^ reference local 11
'                                                                    enclosing_range 26:65-26:75
'                                                                    ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#Method().
'                                                                           enclosing_range 26:65-26:75
'                                                                                   ^ reference local 15
'                                                                                     enclosing_range 26:82-26:83
'                                                                                       ^ reference local 11
'                                                                                         enclosing_range 26:86-26:96
'                                                                                         ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#Method().
'                                                                                                enclosing_range 26:86-26:96
'                                                                                                          ^ reference local 12
'                                                                                                            enclosing_range 26:105-26:106
          End Sub

          Private Sub Join()
'                     ^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Join().
'                          enclosing_range 29:8-29:26
'                          documentation ```vb\nPrivate Sub QuerySyntax.Join()\n```
              Dim x = From a In sourceA Join b In sourceB On a.Method() Equals b.Method() Select New With {Key .A = a.Method(), Key .B = b.Method()}
'                 ^ definition local 16
'                   enclosing_range 29:8-31:15
'                   documentation ```vb\nx As Interface IEnumerable(Of <anonymous type: Key A As String, Key B As String>)\n```
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Collections/Generic/IEnumerable#
'                          ^ definition local 17
'                            enclosing_range 29:8-31:15
'                            documentation ```vb\na As Interface IGeneric\n```
'                               ^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#sourceA.
'                                       enclosing_range 30:30-30:37
'                                            ^ definition local 18
'                                              enclosing_range 29:8-31:15
'                                              documentation ```vb\nb As Interface IGeneric\n```
'                                                 ^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#sourceB.
'                                                         enclosing_range 30:48-30:55
'                                                            ^ reference local 17
'                                                              enclosing_range 30:59-30:69
'                                                              ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#Method().
'                                                                     enclosing_range 30:59-30:69
'                                                                              ^ reference local 18
'                                                                                enclosing_range 30:77-30:87
'                                                                                ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#Method().
'                                                                                       enclosing_range 30:77-30:87
'                                                                                                               ^ reference local 14
'                                                                                                                 enclosing_range 30:110-30:111
'                                                                                                                   ^ reference local 17
'                                                                                                                     enclosing_range 30:114-30:124
'                                                                                                                     ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#Method().
'                                                                                                                            enclosing_range 30:114-30:124
'                                                                                                                                    ^ reference local 15
'                                                                                                                                      enclosing_range 30:131-30:132
'                                                                                                                                        ^ reference local 18
'                                                                                                                                          enclosing_range 30:135-30:145
'                                                                                                                                          ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#Method().
'                                                                                                                                                 enclosing_range 30:135-30:145
          End Sub

          Private Sub MultipleFrom()
'                     ^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#MultipleFrom().
'                                  enclosing_range 33:8-33:34
'                                  documentation ```vb\nPrivate Sub QuerySyntax.MultipleFrom()\n```
              Dim x = From a In sourceA From b In sourceB Where a.Method() = b.Method() Select c = New With {Key .A = a.Method(), Key .B = b.Method()} Where c.A = String.Empty
'                 ^ definition local 19
'                   enclosing_range 33:8-35:15
'                   documentation ```vb\nx As Interface IEnumerable(Of <anonymous type: Key A As String, Key B As String>)\n```
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Collections/Generic/IEnumerable#
'                          ^ definition local 20
'                            enclosing_range 33:8-35:15
'                            documentation ```vb\na As Interface IGeneric\n```
'                               ^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#sourceA.
'                                       enclosing_range 34:30-34:37
'                                            ^ definition local 21
'                                              enclosing_range 33:8-35:15
'                                              documentation ```vb\nb As Interface IGeneric\n```
'                                                 ^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#sourceB.
'                                                         enclosing_range 34:48-34:55
'                                                               ^ reference local 20
'                                                                 enclosing_range 34:62-34:72
'                                                                 ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#Method().
'                                                                        enclosing_range 34:62-34:72
'                                                                            ^ reference local 21
'                                                                              enclosing_range 34:75-34:85
'                                                                              ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#Method().
'                                                                                     enclosing_range 34:75-34:85
'                                                                                              ^ definition local 22
'                                                                                                enclosing_range 33:8-35:15
'                                                                                                documentation ```vb\nc As AnonymousType <anonymous type: Key A As String, Key B As String>\n```
'                                                                                                                 ^ reference local 14
'                                                                                                                   enclosing_range 34:112-34:113
'                                                                                                                     ^ reference local 20
'                                                                                                                       enclosing_range 34:116-34:126
'                                                                                                                       ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#Method().
'                                                                                                                              enclosing_range 34:116-34:126
'                                                                                                                                      ^ reference local 15
'                                                                                                                                        enclosing_range 34:133-34:134
'                                                                                                                                          ^ reference local 21
'                                                                                                                                            enclosing_range 34:137-34:147
'                                                                                                                                            ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#IGeneric#Method().
'                                                                                                                                                   enclosing_range 34:137-34:147
'                                                                                                                                                            ^ reference local 22
'                                                                                                                                                              enclosing_range 34:155-34:158
'                                                                                                                                                              ^ reference local 14
'                                                                                                                                                                enclosing_range 34:155-34:158
'                                                                                                                                                                         ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/String#Empty.
'                                                                                                                                                                               enclosing_range 34:161-34:173
          End Sub

          Private Sub Into(Students As List(Of Student))
'                     ^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Into().
'                          enclosing_range 37:8-37:54
'                          documentation ```vb\nPrivate Sub QuerySyntax.Into(Students As List(Of Student))\n```
'                          ^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Into().(Students)
'                                   enclosing_range 37:8-37:54
'                                   documentation ```vb\nStudents As List(Of Student)\n```
'                                   relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 System/Collections/Generic/List#
'                                              ^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Student#
'                                                      enclosing_range 37:45-37:52
              Dim sortedGroups = From student In Students Order By student.Last, student.First Group student By student.Last Into newGroup = Group Order By newGroup
'                 ^^^^^^^^^^^^ definition local 23
'                              enclosing_range 37:8-39:15
'                              documentation ```vb\nsortedGroups As Interface IOrderedEnumerable(Of <anonymous type: Key Last As String, Key newGroup As Interface IEnumerable(Of Student)>)\n```
'                              relationship type_definition scip-dotnet nuget System.Linq 10.0.0.0 System/Linq/IOrderedEnumerable#
'                                     ^^^^^^^ definition local 24
'                                             enclosing_range 37:8-39:15
'                                             documentation ```vb\nstudent As Class Student\n```
'                                                ^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Into().(Students)
'                                                         enclosing_range 38:47-38:55
'                                                                  ^^^^^^^ reference local 24
'                                                                          enclosing_range 38:65-38:77
'                                                                          ^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Student#Last.
'                                                                               enclosing_range 38:65-38:77
'                                                                                ^^^^^^^ reference local 24
'                                                                                        enclosing_range 38:79-38:92
'                                                                                        ^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Student#First.
'                                                                                              enclosing_range 38:79-38:92
'                                                                                                    ^^^^^^^ reference local 24
'                                                                                                            enclosing_range 38:99-38:106
'                                                                                                               ^^^^^^^ reference local 24
'                                                                                                                       enclosing_range 38:110-38:122
'                                                                                                                       ^^^^ reference scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Student#Last.
'                                                                                                                            enclosing_range 38:110-38:122
'                                                                                                                                 ^^^^^^^^ definition local 25
'                                                                                                                                          enclosing_range 37:8-39:15
'                                                                                                                                          documentation ```vb\nnewGroup As Interface IEnumerable(Of Student)\n```
'                                                                                                                                                           ^^^^^^^^ reference local 25
'                                                                                                                                                                    enclosing_range 38:154-38:162
          End Sub

          Private Class Student
'                       ^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Student#
'                               enclosing_range 41:8-41:29
'                               documentation ```vb\nClass Student\n```
              Public Property First As String
'                             ^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Student#First.
'                                   enclosing_range 42:12-42:43
'                                   documentation ```vb\nPublic Property Student.First As String\n```
'                                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
              Public Property Last As String
'                             ^^^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Student#Last.
'                                  enclosing_range 43:12-43:42
'                                  documentation ```vb\nPublic Property Student.Last As String\n```
'                                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
              Public Property ID As Integer
'                             ^^ definition scip-dotnet nuget . . VBMain/VBMain/QuerySyntax#Student#ID.
'                                enclosing_range 44:12-44:41
'                                documentation ```vb\nPublic Property Student.ID As Integer\n```
'                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          End Class

      End Class
  End Namespace
