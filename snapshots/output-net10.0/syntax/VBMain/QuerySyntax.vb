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
      Public Class QuerySyntax
'                  ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#
'                              enclosing_range 3:4-47:13
'                              documentation ```vb\nClass QuerySyntax\n```
'                              kind Class
          Private sourceA As List(Of IGeneric) = New List(Of IGeneric)()
'                 ^^^^^^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#sourceA.
'                         enclosing_range 5:8-5:70
'                         documentation ```vb\nPrivate QuerySyntax.sourceA As List(Of IGeneric)\n```
'                         kind Field
'                         relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#
'                                    ^^^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#
'                                             enclosing_range 5:8-5:70
'                                                            ^^^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#
'                                                                     enclosing_range 5:8-5:70
          Private sourceB As List(Of IGeneric) = New List(Of IGeneric)()
'                 ^^^^^^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#sourceB.
'                         enclosing_range 6:8-6:70
'                         documentation ```vb\nPrivate QuerySyntax.sourceB As List(Of IGeneric)\n```
'                         kind Field
'                         relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#
'                                    ^^^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#
'                                             enclosing_range 6:8-6:70
'                                                            ^^^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#
'                                                                     enclosing_range 6:8-6:70

          Interface IGeneric
'                   ^^^^^^^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#
'                            enclosing_range 8:8-10:21
'                            documentation ```vb\nInterface IGeneric\n```
'                            kind Interface
              Function Method() As String
'                      ^^^^^^ definition forward_definition scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#Method().
'                             enclosing_range 8:8-10:21
'                             documentation ```vb\nFunction IGeneric.Method() As String\n```
'                             kind AbstractMethod
          End Interface

          Private Sub [Select]()
'                     ^^^^^^^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#Select().
'                              enclosing_range 12:8-14:15
'                              documentation ```vb\nPrivate Sub QuerySyntax.Select()\n```
'                              kind Method
              Dim x = From a In sourceA Select a.Method()
'                 ^ definition local 0
'                   enclosing_range 12:8-14:15
'                   documentation ```vb\nx As Interface IEnumerable(Of String)\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
'                          ^ definition local 1
'                            enclosing_range 12:8-14:15
'                            documentation ```vb\na As Interface IGeneric\n```
'                               ^^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#sourceA.
'                                       enclosing_range 12:8-14:15
'                                              ^ read_access local 1
'                                                enclosing_range 12:8-14:15
'                                                ^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#Method().
'                                                       enclosing_range 12:8-14:15
          End Sub

          Private Sub Projection()
'                     ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#Projection().
'                                enclosing_range 16:8-19:15
'                                documentation ```vb\nPrivate Sub QuerySyntax.Projection()\n```
'                                kind Method
              Dim x = From a In sourceA Select New With {Key .Name = a.Method()}
'                 ^ definition local 2
'                   enclosing_range 16:8-19:15
'                   documentation ```vb\nx As Interface IEnumerable(Of <anonymous type: Key Name As String>)\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
'                          ^ definition local 3
'                            enclosing_range 16:8-19:15
'                            documentation ```vb\na As Interface IGeneric\n```
'                               ^^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#sourceA.
'                                       enclosing_range 16:8-19:15
'                                                             ^^^^ read_access local 5
'                                                                  enclosing_range 16:8-19:15
'                                                                    ^ read_access local 3
'                                                                      enclosing_range 16:8-19:15
'                                                                      ^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#Method().
'                                                                             enclosing_range 16:8-19:15
              Dim b = From a In x Select a.Name
'                 ^ definition local 6
'                   enclosing_range 16:8-19:15
'                   documentation ```vb\nb As Interface IEnumerable(Of String)\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
'                          ^ definition local 7
'                            enclosing_range 16:8-19:15
'                            documentation ```vb\na As AnonymousType <anonymous type: Key Name As String>\n```
'                               ^ read_access local 2
'                                 enclosing_range 16:8-19:15
'                                        ^ read_access local 7
'                                          enclosing_range 16:8-19:15
'                                          ^^^^ read_access local 5
'                                               enclosing_range 16:8-19:15
          End Sub

          Private Sub Where()
'                     ^^^^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#Where().
'                           enclosing_range 21:8-23:15
'                           documentation ```vb\nPrivate Sub QuerySyntax.Where()\n```
'                           kind Method
              Dim x = From a In sourceA Where a.Method().StartsWith("a") Select a
'                 ^ definition local 8
'                   enclosing_range 21:8-23:15
'                   documentation ```vb\nx As Interface IEnumerable(Of IGeneric)\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
'                          ^ definition local 9
'                            enclosing_range 21:8-23:15
'                            documentation ```vb\na As Interface IGeneric\n```
'                               ^^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#sourceA.
'                                       enclosing_range 21:8-23:15
'                                             ^ read_access local 9
'                                               enclosing_range 21:8-23:15
'                                               ^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#Method().
'                                                      enclosing_range 21:8-23:15
'                                                        ^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/String#StartsWith(+1).
'                                                                   enclosing_range 21:8-23:15
'                                                                               ^ read_access local 9
'                                                                                 enclosing_range 21:8-23:15
          End Sub

          Private Sub [Let]()
'                     ^^^^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#Let().
'                           enclosing_range 25:8-27:15
'                           documentation ```vb\nPrivate Sub QuerySyntax.Let()\n```
'                           kind Method
              Dim x = From a In sourceA Let z = New With {Key .A = a.Method(), Key .B = a.Method()} Select z
'                 ^ definition local 10
'                   enclosing_range 25:8-27:15
'                   documentation ```vb\nx As Interface IEnumerable(Of <anonymous type: Key A As String, Key B As String>)\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
'                          ^ definition local 11
'                            enclosing_range 25:8-27:15
'                            documentation ```vb\na As Interface IGeneric\n```
'                               ^^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#sourceA.
'                                       enclosing_range 25:8-27:15
'                                           ^ definition local 12
'                                             enclosing_range 25:8-27:15
'                                             documentation ```vb\nz As AnonymousType <anonymous type: Key A As String, Key B As String>\n```
'                                                              ^ read_access local 14
'                                                                enclosing_range 25:8-27:15
'                                                                  ^ read_access local 11
'                                                                    enclosing_range 25:8-27:15
'                                                                    ^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#Method().
'                                                                           enclosing_range 25:8-27:15
'                                                                                   ^ read_access local 15
'                                                                                     enclosing_range 25:8-27:15
'                                                                                       ^ read_access local 11
'                                                                                         enclosing_range 25:8-27:15
'                                                                                         ^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#Method().
'                                                                                                enclosing_range 25:8-27:15
'                                                                                                          ^ read_access local 12
'                                                                                                            enclosing_range 25:8-27:15
          End Sub

          Private Sub Join()
'                     ^^^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#Join().
'                          enclosing_range 29:8-31:15
'                          documentation ```vb\nPrivate Sub QuerySyntax.Join()\n```
'                          kind Method
              Dim x = From a In sourceA Join b In sourceB On a.Method() Equals b.Method() Select New With {Key .A = a.Method(), Key .B = b.Method()}
'                 ^ definition local 16
'                   enclosing_range 29:8-31:15
'                   documentation ```vb\nx As Interface IEnumerable(Of <anonymous type: Key A As String, Key B As String>)\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
'                          ^ definition local 17
'                            enclosing_range 29:8-31:15
'                            documentation ```vb\na As Interface IGeneric\n```
'                               ^^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#sourceA.
'                                       enclosing_range 29:8-31:15
'                                            ^ definition local 18
'                                              enclosing_range 29:8-31:15
'                                              documentation ```vb\nb As Interface IGeneric\n```
'                                                 ^^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#sourceB.
'                                                         enclosing_range 29:8-31:15
'                                                            ^ read_access local 17
'                                                              enclosing_range 29:8-31:15
'                                                              ^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#Method().
'                                                                     enclosing_range 29:8-31:15
'                                                                              ^ read_access local 18
'                                                                                enclosing_range 29:8-31:15
'                                                                                ^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#Method().
'                                                                                       enclosing_range 29:8-31:15
'                                                                                                               ^ read_access local 14
'                                                                                                                 enclosing_range 29:8-31:15
'                                                                                                                   ^ read_access local 17
'                                                                                                                     enclosing_range 29:8-31:15
'                                                                                                                     ^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#Method().
'                                                                                                                            enclosing_range 29:8-31:15
'                                                                                                                                    ^ read_access local 15
'                                                                                                                                      enclosing_range 29:8-31:15
'                                                                                                                                        ^ read_access local 18
'                                                                                                                                          enclosing_range 29:8-31:15
'                                                                                                                                          ^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#Method().
'                                                                                                                                                 enclosing_range 29:8-31:15
          End Sub

          Private Sub MultipleFrom()
'                     ^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#MultipleFrom().
'                                  enclosing_range 33:8-35:15
'                                  documentation ```vb\nPrivate Sub QuerySyntax.MultipleFrom()\n```
'                                  kind Method
              Dim x = From a In sourceA From b In sourceB Where a.Method() = b.Method() Select c = New With {Key .A = a.Method(), Key .B = b.Method()} Where c.A = String.Empty
'                 ^ definition local 19
'                   enclosing_range 33:8-35:15
'                   documentation ```vb\nx As Interface IEnumerable(Of <anonymous type: Key A As String, Key B As String>)\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
'                          ^ definition local 20
'                            enclosing_range 33:8-35:15
'                            documentation ```vb\na As Interface IGeneric\n```
'                               ^^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#sourceA.
'                                       enclosing_range 33:8-35:15
'                                            ^ definition local 21
'                                              enclosing_range 33:8-35:15
'                                              documentation ```vb\nb As Interface IGeneric\n```
'                                                 ^^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#sourceB.
'                                                         enclosing_range 33:8-35:15
'                                                               ^ read_access local 20
'                                                                 enclosing_range 33:8-35:15
'                                                                 ^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#Method().
'                                                                        enclosing_range 33:8-35:15
'                                                                            ^ read_access local 21
'                                                                              enclosing_range 33:8-35:15
'                                                                              ^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#Method().
'                                                                                     enclosing_range 33:8-35:15
'                                                                                              ^ definition local 22
'                                                                                                enclosing_range 33:8-35:15
'                                                                                                documentation ```vb\nc As AnonymousType <anonymous type: Key A As String, Key B As String>\n```
'                                                                                                                 ^ read_access local 14
'                                                                                                                   enclosing_range 33:8-35:15
'                                                                                                                     ^ read_access local 20
'                                                                                                                       enclosing_range 33:8-35:15
'                                                                                                                       ^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#Method().
'                                                                                                                              enclosing_range 33:8-35:15
'                                                                                                                                      ^ read_access local 15
'                                                                                                                                        enclosing_range 33:8-35:15
'                                                                                                                                          ^ read_access local 21
'                                                                                                                                            enclosing_range 33:8-35:15
'                                                                                                                                            ^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#IGeneric#Method().
'                                                                                                                                                   enclosing_range 33:8-35:15
'                                                                                                                                                            ^ read_access local 22
'                                                                                                                                                              enclosing_range 33:8-35:15
'                                                                                                                                                              ^ read_access local 14
'                                                                                                                                                                enclosing_range 33:8-35:15
'                                                                                                                                                                         ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/String#Empty.
'                                                                                                                                                                               enclosing_range 33:8-35:15
          End Sub

          Private Sub Into(Students As List(Of Student))
'                     ^^^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#Into().
'                          enclosing_range 37:8-39:15
'                          documentation ```vb\nPrivate Sub QuerySyntax.Into(Students As List(Of Student))\n```
'                          kind Method
'                          ^^^^^^^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#Into().(Students)
'                                   enclosing_range 37:8-37:54
'                                   documentation ```vb\nStudents As List(Of Student)\n```
'                                   kind Parameter
'                                   relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#
'                                              ^^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#Student#
'                                                      enclosing_range 37:8-37:54
              Dim sortedGroups = From student In Students Order By student.Last, student.First Group student By student.Last Into newGroup = Group Order By newGroup
'                 ^^^^^^^^^^^^ definition local 23
'                              enclosing_range 37:8-39:15
'                              documentation ```vb\nsortedGroups As Interface IOrderedEnumerable(Of <anonymous type: Key Last As String, Key newGroup As Interface IEnumerable(Of Student)>)\n```
'                              kind Variable
'                              relationship type_definition scip-dotnet nuget System.Linq 10.0.0.0 Linq/IOrderedEnumerable#
'                                     ^^^^^^^ definition local 24
'                                             enclosing_range 37:8-39:15
'                                             documentation ```vb\nstudent As Class Student\n```
'                                                ^^^^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#Into().(Students)
'                                                         enclosing_range 37:8-39:15
'                                                                  ^^^^^^^ read_access local 24
'                                                                          enclosing_range 37:8-39:15
'                                                                          ^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#Student#Last.
'                                                                               enclosing_range 37:8-39:15
'                                                                                ^^^^^^^ read_access local 24
'                                                                                        enclosing_range 37:8-39:15
'                                                                                        ^^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#Student#First.
'                                                                                              enclosing_range 37:8-39:15
'                                                                                                    ^^^^^^^ read_access local 24
'                                                                                                            enclosing_range 37:8-39:15
'                                                                                                               ^^^^^^^ read_access local 24
'                                                                                                                       enclosing_range 37:8-39:15
'                                                                                                                       ^^^^ read_access scip-dotnet nuget . . VBMain/QuerySyntax#Student#Last.
'                                                                                                                            enclosing_range 37:8-39:15
'                                                                                                                                 ^^^^^^^^ definition local 25
'                                                                                                                                          enclosing_range 37:8-39:15
'                                                                                                                                          documentation ```vb\nnewGroup As Interface IEnumerable(Of Student)\n```
'                                                                                                                                                           ^^^^^^^^ read_access local 25
'                                                                                                                                                                    enclosing_range 37:8-39:15
          End Sub

          Private Class Student
'                       ^^^^^^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#Student#
'                               enclosing_range 41:8-45:17
'                               documentation ```vb\nClass Student\n```
'                               kind Class
              Public Property First As String
'                             ^^^^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#Student#First.
'                                   enclosing_range 41:8-45:17
'                                   documentation ```vb\nPublic Property Student.First As String\n```
'                                   kind Property
'                                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
              Public Property Last As String
'                             ^^^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#Student#Last.
'                                  enclosing_range 41:8-45:17
'                                  documentation ```vb\nPublic Property Student.Last As String\n```
'                                  kind Property
'                                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
              Public Property ID As Integer
'                             ^^ definition scip-dotnet nuget . . VBMain/QuerySyntax#Student#ID.
'                                enclosing_range 41:8-45:17
'                                documentation ```vb\nPublic Property Student.ID As Integer\n```
'                                kind Property
'                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          End Class

      End Class
  End Namespace
