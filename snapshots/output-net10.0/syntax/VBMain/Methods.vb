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
      Public Class Methods
'                  ^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#
'                          enclosing_range 3:4-4:24
'                          documentation ```vb\nClass Methods\n```
          Private Function SingleParameter(ByVal b As Integer) As Integer
'                          ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#SingleParameter().
'                                          enclosing_range 5:8-5:71
'                                          documentation ```vb\nPrivate Function Methods.SingleParameter(b As Integer) As Integer\n```
'                                                ^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#SingleParameter().(b)
'                                                  enclosing_range 5:8-5:71
'                                                  documentation ```vb\nb As Integer\n```
'                                                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return b
'                    ^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#SingleParameter().(b)
'                      enclosing_range 6:19-6:20
          End Function

          Private Function TwoParameters(ByVal a As Integer, ByVal b As Integer) As Integer
'                          ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#TwoParameters().
'                                        enclosing_range 9:8-9:89
'                                        documentation ```vb\nPrivate Function Methods.TwoParameters(a As Integer, b As Integer) As Integer\n```
'                                              ^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#TwoParameters().(a)
'                                                enclosing_range 9:8-9:89
'                                                documentation ```vb\na As Integer\n```
'                                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                                                  ^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#TwoParameters().(b)
'                                                                    enclosing_range 9:8-9:89
'                                                                    documentation ```vb\nb As Integer\n```
'                                                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return a + b
'                    ^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#TwoParameters().(a)
'                      enclosing_range 10:19-10:24
'                        ^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#TwoParameters().(b)
'                          enclosing_range 10:19-10:24
          End Function

          Private Function Overload1(ByVal a As Integer) As Integer
'                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#Overload1().
'                                    enclosing_range 13:8-13:65
'                                    documentation ```vb\nPrivate Function Methods.Overload1(a As Integer) As Integer\n```
'                                          ^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#Overload1().(a)
'                                            enclosing_range 13:8-13:65
'                                            documentation ```vb\na As Integer\n```
'                                            relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return a
'                    ^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#Overload1().(a)
'                      enclosing_range 14:19-14:20
          End Function

          Private Function Overload1(ByVal a As Integer, ByVal b As Integer) As Integer
'                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#Overload1(+1).
'                                    enclosing_range 17:8-17:85
'                                    documentation ```vb\nPrivate Function Methods.Overload1(a As Integer, b As Integer) As Integer\n```
'                                          ^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#Overload1(+1).(a)
'                                            enclosing_range 17:8-17:85
'                                            documentation ```vb\na As Integer\n```
'                                            relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                                              ^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#Overload1(+1).(b)
'                                                                enclosing_range 17:8-17:85
'                                                                documentation ```vb\nb As Integer\n```
'                                                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return a + b
'                    ^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#Overload1(+1).(a)
'                      enclosing_range 18:19-18:24
'                        ^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#Overload1(+1).(b)
'                          enclosing_range 18:19-18:24
          End Function

          Private Function Generic(Of T)(ByVal param As T) As T
'                          ^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#Generic().
'                                  enclosing_range 21:8-21:61
'                                  documentation ```vb\nPrivate Function Methods.Generic(Of T)(param As T) As T\n```
'                                     ^ definition local 0
'                                       enclosing_range 21:8-21:61
'                                       documentation ```vb\nT\n```
'                                              ^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#Generic().(param)
'                                                    enclosing_range 21:8-21:61
'                                                    documentation ```vb\nparam As T\n```
'                                                    relationship type_definition local 0
'                                                       ^ reference local 0
'                                                         enclosing_range 21:54-21:55
'                                                             ^ reference local 0
'                                                               enclosing_range 21:60-21:61
              Return param
'                    ^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#Generic().(param)
'                          enclosing_range 22:19-22:24
          End Function

          Private Function GenericConstraint(Of T As New)(ByVal param As T) As T
'                          ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#GenericConstraint().
'                                            enclosing_range 25:8-25:78
'                                            documentation ```vb\nPrivate Function Methods.GenericConstraint(Of T As New)(param As T) As T\n```
'                                               ^ definition local 1
'                                                 enclosing_range 25:8-25:78
'                                                 documentation ```vb\nT\n```
'                                                               ^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#GenericConstraint().(param)
'                                                                     enclosing_range 25:8-25:78
'                                                                     documentation ```vb\nparam As T\n```
'                                                                     relationship type_definition local 1
'                                                                        ^ reference local 1
'                                                                          enclosing_range 25:71-25:72
'                                                                              ^ reference local 1
'                                                                                enclosing_range 25:77-25:78
              Return param
'                    ^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#GenericConstraint().(param)
'                          enclosing_range 26:19-26:24
          End Function

          Private Sub DefaultParameter(ByVal Optional a As Integer = 5)
'                     ^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#DefaultParameter().
'                                      enclosing_range 29:8-29:69
'                                      documentation ```vb\nPrivate Sub Methods.DefaultParameter([a As Integer = 5])\n```
'                                                     ^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#DefaultParameter().(a)
'                                                       enclosing_range 29:8-29:69
'                                                       documentation ```vb\n[a As Integer = 5]\n```
'                                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          End Sub

          Private Function DefaultParameterOverload(ByVal Optional a As Integer = 5) As Integer
'                          ^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#DefaultParameterOverload().
'                                                   enclosing_range 32:8-32:93
'                                                   documentation ```vb\nPrivate Function Methods.DefaultParameterOverload([a As Integer = 5]) As Integer\n```
'                                                                  ^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#DefaultParameterOverload().(a)
'                                                                    enclosing_range 32:8-32:93
'                                                                    documentation ```vb\n[a As Integer = 5]\n```
'                                                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return DefaultParameterOverload(a, a)
'                    ^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#DefaultParameterOverload(+1).
'                                             enclosing_range 33:19-33:49
'                                             ^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#DefaultParameterOverload().(a)
'                                               enclosing_range 33:44-33:45
'                                                ^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#DefaultParameterOverload().(a)
'                                                  enclosing_range 33:47-33:48
          End Function

          Private Function DefaultParameterOverload(ByVal a As Integer, ByVal b As Integer) As Integer
'                          ^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#DefaultParameterOverload(+1).
'                                                   enclosing_range 36:8-36:100
'                                                   documentation ```vb\nPrivate Function Methods.DefaultParameterOverload(a As Integer, b As Integer) As Integer\n```
'                                                         ^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#DefaultParameterOverload(+1).(a)
'                                                           enclosing_range 36:8-36:100
'                                                           documentation ```vb\na As Integer\n```
'                                                           relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                                                             ^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#DefaultParameterOverload(+1).(b)
'                                                                               enclosing_range 36:8-36:100
'                                                                               documentation ```vb\nb As Integer\n```
'                                                                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return DefaultParameterOverload()
'                    ^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#DefaultParameterOverload().
'                                             enclosing_range 37:19-37:45
          End Function

          Interface IHello
'                   ^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#IHello#
'                          enclosing_range 40:8-40:24
'                          documentation ```vb\nInterface IHello\n```
              Function Hello() As String
'                      ^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#IHello#Hello().
'                            enclosing_range 41:12-41:38
'                            documentation ```vb\nFunction IHello.Hello() As String\n```
          End Interface

          Class ImplementsHello
'               ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#ImplementsHello#
'                               enclosing_range 44:8-44:29
'                               documentation ```vb\nClass ImplementsHello\n```
'                               relationship implementation scip-dotnet nuget . . VBMain/VBMain/Methods#IHello#
              Implements IHello
'                        ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#IHello#
'                               enclosing_range 45:23-45:29

              Private Function Hello() As String Implements IHello.Hello
'                              ^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#ImplementsHello#Hello().
'                                    enclosing_range 47:12-47:70
'                                    documentation ```vb\nPrivate Function ImplementsHello.Hello() As String\n```
'                                    relationship implementation reference scip-dotnet nuget . . VBMain/VBMain/Methods#IHello#Hello().
'                                                           ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#IHello#
'                                                                  enclosing_range 47:58-47:70
'                                                                  ^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#IHello#Hello().
'                                                                        enclosing_range 47:58-47:70
                  Throw New NotImplementedException()
'                           ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
'                                                   enclosing_range 48:22-48:51
              End Function

          End Class

          Class InheritedOverloads1
'               ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads1#
'                                   enclosing_range 53:8-53:33
'                                   documentation ```vb\nClass InheritedOverloads1\n```
              Public Sub Method()
'                        ^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads1#Method().
'                               enclosing_range 54:12-54:31
'                               documentation ```vb\nPublic Sub InheritedOverloads1.Method()\n```
              End Sub
          End Class

          Class InheritedOverloads2
'               ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads2#
'                                   enclosing_range 58:8-58:33
'                                   documentation ```vb\nClass InheritedOverloads2\n```
'                                   relationship implementation scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads1#
              Inherits InheritedOverloads1
'                      ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads1#
'                                          enclosing_range 59:21-59:40

              Public Function Method(ByVal parameter As Integer) As Integer
'                             ^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads2#Method().
'                                    enclosing_range 61:12-61:73
'                                    documentation ```vb\nPublic Function InheritedOverloads2.Method(parameter As Integer) As Integer\n```
'                                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads2#Method().(parameter)
'                                                    enclosing_range 61:12-61:73
'                                                    documentation ```vb\nparameter As Integer\n```
'                                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
                  Return parameter
'                        ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads2#Method().(parameter)
'                                  enclosing_range 62:23-62:32
              End Function
          End Class

          Class InheritedOverloads3
'               ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads3#
'                                   enclosing_range 66:8-66:33
'                                   documentation ```vb\nClass InheritedOverloads3\n```
'                                   relationship implementation scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads2#
'                                   relationship implementation scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads1#
              Inherits InheritedOverloads2
'                      ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads2#
'                                          enclosing_range 67:21-67:40

              Public Function Method(ByVal parameter As String) As String
'                             ^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads3#Method().
'                                    enclosing_range 69:12-69:71
'                                    documentation ```vb\nPublic Function InheritedOverloads3.Method(parameter As String) As String\n```
'                                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads3#Method().(parameter)
'                                                    enclosing_range 69:12-69:71
'                                                    documentation ```vb\nparameter As String\n```
'                                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
                  Return parameter
'                        ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads3#Method().(parameter)
'                                  enclosing_range 70:23-70:32
              End Function
          End Class

          Public Shared Sub InheritedOverloads()
'                           ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads().
'                                              enclosing_range 74:8-74:46
'                                              documentation ```vb\nPublic Shared Sub Methods.InheritedOverloads()\n```
              Dim a As InheritedOverloads1 = New InheritedOverloads1
'                 ^ definition local 2
'                   enclosing_range 74:8-84:15
'                   documentation ```vb\na As Class InheritedOverloads1\n```
'                   relationship type_definition scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads1#
'                      ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads1#
'                                          enclosing_range 75:21-75:40
'                                                ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads1#
'                                                                    enclosing_range 75:43-75:66
              a.Method()
'             ^ reference local 2
'               enclosing_range 76:12-76:22
'               ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads1#Method().
'                      enclosing_range 76:12-76:22
              Dim b As InheritedOverloads2 = New InheritedOverloads2
'                 ^ definition local 3
'                   enclosing_range 74:8-84:15
'                   documentation ```vb\nb As Class InheritedOverloads2\n```
'                   relationship type_definition scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads2#
'                      ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads2#
'                                          enclosing_range 77:21-77:40
'                                                ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads2#
'                                                                    enclosing_range 77:43-77:66
              DirectCast(b, InheritedOverloads1).Method()
'                        ^ reference local 3
'                          enclosing_range 78:12-78:46
'                           ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads1#
'                                               enclosing_range 78:12-78:46
'                                                ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads1#Method().
'                                                       enclosing_range 78:12-78:55
              b.Method(42)
'             ^ reference local 3
'               enclosing_range 79:12-79:24
'               ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads2#Method().
'                      enclosing_range 79:12-79:24
              Dim c As InheritedOverloads3 = New InheritedOverloads3
'                 ^ definition local 4
'                   enclosing_range 74:8-84:15
'                   documentation ```vb\nc As Class InheritedOverloads3\n```
'                   relationship type_definition scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads3#
'                      ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads3#
'                                          enclosing_range 80:21-80:40
'                                                ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads3#
'                                                                    enclosing_range 80:43-80:66
              DirectCast(c, InheritedOverloads1).Method()
'                        ^ reference local 4
'                          enclosing_range 81:12-81:46
'                           ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads1#
'                                               enclosing_range 81:12-81:46
'                                                ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads1#Method().
'                                                       enclosing_range 81:12-81:55
              DirectCast(c, InheritedOverloads2).Method(42)
'                        ^ reference local 4
'                          enclosing_range 82:12-82:46
'                           ^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads2#
'                                               enclosing_range 82:12-82:46
'                                                ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads2#Method().
'                                                       enclosing_range 82:12-82:57
              c.Method("42")
'             ^ reference local 4
'               enclosing_range 83:12-83:26
'               ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Methods#InheritedOverloads3#Method().
'                      enclosing_range 83:12-83:26
          End Sub
      End Class
  End Namespace
