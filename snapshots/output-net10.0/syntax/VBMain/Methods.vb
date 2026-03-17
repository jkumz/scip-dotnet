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
'                      enclosing_range 3:4-4:24
      Public Class Methods
'                  ^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#
'                          enclosing_range 3:4-85:13
'                          documentation ```vb\nClass Methods\n```
'                          kind Class
          Private Function SingleParameter(ByVal b As Integer) As Integer
'                          ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#SingleParameter().
'                                          enclosing_range 5:8-7:20
'                                          documentation ```vb\nPrivate Function Methods.SingleParameter(b As Integer) As Integer\n```
'                                          kind Method
'                                                ^ definition scip-dotnet nuget . . VBMain/Methods#SingleParameter().(b)
'                                                  enclosing_range 5:8-5:71
'                                                  documentation ```vb\nb As Integer\n```
'                                                  kind Parameter
'                                                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return b
'                    ^ read_access scip-dotnet nuget . . VBMain/Methods#SingleParameter().(b)
'                      enclosing_range 5:8-7:20
          End Function

          Private Function TwoParameters(ByVal a As Integer, ByVal b As Integer) As Integer
'                          ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#TwoParameters().
'                                        enclosing_range 9:8-11:20
'                                        documentation ```vb\nPrivate Function Methods.TwoParameters(a As Integer, b As Integer) As Integer\n```
'                                        kind Method
'                                              ^ definition scip-dotnet nuget . . VBMain/Methods#TwoParameters().(a)
'                                                enclosing_range 9:8-9:89
'                                                documentation ```vb\na As Integer\n```
'                                                kind Parameter
'                                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                                                  ^ definition scip-dotnet nuget . . VBMain/Methods#TwoParameters().(b)
'                                                                    enclosing_range 9:8-9:89
'                                                                    documentation ```vb\nb As Integer\n```
'                                                                    kind Parameter
'                                                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return a + b
'                    ^ read_access scip-dotnet nuget . . VBMain/Methods#TwoParameters().(a)
'                      enclosing_range 9:8-11:20
'                        ^ read_access scip-dotnet nuget . . VBMain/Methods#TwoParameters().(b)
'                          enclosing_range 9:8-11:20
          End Function

          Private Function Overload1(ByVal a As Integer) As Integer
'                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#Overload1().
'                                    enclosing_range 13:8-15:20
'                                    documentation ```vb\nPrivate Function Methods.Overload1(a As Integer) As Integer\n```
'                                    kind Method
'                                          ^ definition scip-dotnet nuget . . VBMain/Methods#Overload1().(a)
'                                            enclosing_range 13:8-13:65
'                                            documentation ```vb\na As Integer\n```
'                                            kind Parameter
'                                            relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return a
'                    ^ read_access scip-dotnet nuget . . VBMain/Methods#Overload1().(a)
'                      enclosing_range 13:8-15:20
          End Function

          Private Function Overload1(ByVal a As Integer, ByVal b As Integer) As Integer
'                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#Overload1(+1).
'                                    enclosing_range 17:8-19:20
'                                    documentation ```vb\nPrivate Function Methods.Overload1(a As Integer, b As Integer) As Integer\n```
'                                    kind Method
'                                          ^ definition scip-dotnet nuget . . VBMain/Methods#Overload1(+1).(a)
'                                            enclosing_range 17:8-17:85
'                                            documentation ```vb\na As Integer\n```
'                                            kind Parameter
'                                            relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                                              ^ definition scip-dotnet nuget . . VBMain/Methods#Overload1(+1).(b)
'                                                                enclosing_range 17:8-17:85
'                                                                documentation ```vb\nb As Integer\n```
'                                                                kind Parameter
'                                                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return a + b
'                    ^ read_access scip-dotnet nuget . . VBMain/Methods#Overload1(+1).(a)
'                      enclosing_range 17:8-19:20
'                        ^ read_access scip-dotnet nuget . . VBMain/Methods#Overload1(+1).(b)
'                          enclosing_range 17:8-19:20
          End Function

          Private Function Generic(Of T)(ByVal param As T) As T
'                          ^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#Generic().
'                                  enclosing_range 21:8-23:20
'                                  documentation ```vb\nPrivate Function Methods.Generic(Of T)(param As T) As T\n```
'                                  kind Method
'                                     ^ definition local 0
'                                       enclosing_range 21:8-21:61
'                                       documentation ```vb\nT\n```
'                                       kind TypeParameter
'                                              ^^^^^ definition scip-dotnet nuget . . VBMain/Methods#Generic().(param)
'                                                    enclosing_range 21:8-21:61
'                                                    documentation ```vb\nparam As T\n```
'                                                    kind Parameter
'                                                    relationship type_definition local 0
'                                                       ^ read_access local 0
'                                                         enclosing_range 21:8-21:61
'                                                             ^ read_access local 0
'                                                               enclosing_range 21:8-21:61
              Return param
'                    ^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#Generic().(param)
'                          enclosing_range 21:8-23:20
          End Function

          Private Function GenericConstraint(Of T As New)(ByVal param As T) As T
'                          ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#GenericConstraint().
'                                            enclosing_range 25:8-27:20
'                                            documentation ```vb\nPrivate Function Methods.GenericConstraint(Of T As New)(param As T) As T\n```
'                                            kind Method
'                                               ^ definition local 1
'                                                 enclosing_range 25:8-25:78
'                                                 documentation ```vb\nT\n```
'                                                 kind TypeParameter
'                                                               ^^^^^ definition scip-dotnet nuget . . VBMain/Methods#GenericConstraint().(param)
'                                                                     enclosing_range 25:8-25:78
'                                                                     documentation ```vb\nparam As T\n```
'                                                                     kind Parameter
'                                                                     relationship type_definition local 1
'                                                                        ^ read_access local 1
'                                                                          enclosing_range 25:8-25:78
'                                                                              ^ read_access local 1
'                                                                                enclosing_range 25:8-25:78
              Return param
'                    ^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#GenericConstraint().(param)
'                          enclosing_range 25:8-27:20
          End Function

          Private Sub DefaultParameter(ByVal Optional a As Integer = 5)
'                     ^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#DefaultParameter().
'                                      enclosing_range 29:8-30:15
'                                      documentation ```vb\nPrivate Sub Methods.DefaultParameter([a As Integer = 5])\n```
'                                      kind Method
'                                                     ^ definition scip-dotnet nuget . . VBMain/Methods#DefaultParameter().(a)
'                                                       enclosing_range 29:8-29:69
'                                                       documentation ```vb\n[a As Integer = 5]\n```
'                                                       kind Parameter
'                                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          End Sub

          Private Function DefaultParameterOverload(ByVal Optional a As Integer = 5) As Integer
'                          ^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload().
'                                                   enclosing_range 32:8-34:20
'                                                   documentation ```vb\nPrivate Function Methods.DefaultParameterOverload([a As Integer = 5]) As Integer\n```
'                                                   kind Method
'                                                                  ^ definition scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload().(a)
'                                                                    enclosing_range 32:8-32:93
'                                                                    documentation ```vb\n[a As Integer = 5]\n```
'                                                                    kind Parameter
'                                                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return DefaultParameterOverload(a, a)
'                    ^^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload(+1).
'                                             enclosing_range 32:8-34:20
'                                             ^ read_access scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload().(a)
'                                               enclosing_range 32:8-34:20
'                                                ^ read_access scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload().(a)
'                                                  enclosing_range 32:8-34:20
          End Function

          Private Function DefaultParameterOverload(ByVal a As Integer, ByVal b As Integer) As Integer
'                          ^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload(+1).
'                                                   enclosing_range 36:8-38:20
'                                                   documentation ```vb\nPrivate Function Methods.DefaultParameterOverload(a As Integer, b As Integer) As Integer\n```
'                                                   kind Method
'                                                         ^ definition scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload(+1).(a)
'                                                           enclosing_range 36:8-36:100
'                                                           documentation ```vb\na As Integer\n```
'                                                           kind Parameter
'                                                           relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                                                             ^ definition scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload(+1).(b)
'                                                                               enclosing_range 36:8-36:100
'                                                                               documentation ```vb\nb As Integer\n```
'                                                                               kind Parameter
'                                                                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return DefaultParameterOverload()
'                    ^^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#DefaultParameterOverload().
'                                             enclosing_range 36:8-38:20
          End Function

          Interface IHello
'                   ^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#IHello#
'                          enclosing_range 40:8-42:21
'                          documentation ```vb\nInterface IHello\n```
'                          kind Interface
              Function Hello() As String
'                      ^^^^^ definition forward_definition scip-dotnet nuget . . VBMain/Methods#IHello#Hello().
'                            enclosing_range 40:8-42:21
'                            documentation ```vb\nFunction IHello.Hello() As String\n```
'                            kind AbstractMethod
          End Interface

          Class ImplementsHello
'               ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#ImplementsHello#
'                               enclosing_range 44:8-51:17
'                               documentation ```vb\nClass ImplementsHello\n```
'                               kind Class
'                               relationship implementation scip-dotnet nuget . . VBMain/Methods#IHello#
              Implements IHello
'                        ^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#IHello#
'                               enclosing_range 45:12-45:29

              Private Function Hello() As String Implements IHello.Hello
'                              ^^^^^ definition scip-dotnet nuget . . VBMain/Methods#ImplementsHello#Hello().
'                                    enclosing_range 47:12-49:24
'                                    documentation ```vb\nPrivate Function ImplementsHello.Hello() As String\n```
'                                    kind Method
'                                    relationship implementation reference scip-dotnet nuget . . VBMain/Methods#IHello#Hello().
'                                                           ^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#IHello#
'                                                                  enclosing_range 47:12-47:70
'                                                                  ^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#IHello#Hello().
'                                                                        enclosing_range 47:12-47:70
                  Throw New NotImplementedException()
'                           ^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
'                                                   enclosing_range 47:12-49:24
              End Function

          End Class

          Class InheritedOverloads1
'               ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
'                                   enclosing_range 53:8-56:17
'                                   documentation ```vb\nClass InheritedOverloads1\n```
'                                   kind Class
              Public Sub Method()
'                        ^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#Method().
'                               enclosing_range 54:12-55:19
'                               documentation ```vb\nPublic Sub InheritedOverloads1.Method()\n```
'                               kind Method
              End Sub
          End Class

          Class InheritedOverloads2
'               ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#
'                                   enclosing_range 58:8-64:17
'                                   documentation ```vb\nClass InheritedOverloads2\n```
'                                   kind Class
'                                   relationship implementation scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
              Inherits InheritedOverloads1
'                      ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
'                                          enclosing_range 59:12-59:40

              Public Function Method(ByVal parameter As Integer) As Integer
'                             ^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#Method().
'                                    enclosing_range 61:12-63:24
'                                    documentation ```vb\nPublic Function InheritedOverloads2.Method(parameter As Integer) As Integer\n```
'                                    kind Method
'                                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#Method().(parameter)
'                                                    enclosing_range 61:12-61:73
'                                                    documentation ```vb\nparameter As Integer\n```
'                                                    kind Parameter
'                                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
                  Return parameter
'                        ^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#Method().(parameter)
'                                  enclosing_range 61:12-63:24
              End Function
          End Class

          Class InheritedOverloads3
'               ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads3#
'                                   enclosing_range 66:8-72:17
'                                   documentation ```vb\nClass InheritedOverloads3\n```
'                                   kind Class
'                                   relationship implementation scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#
'                                   relationship implementation scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
              Inherits InheritedOverloads2
'                      ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#
'                                          enclosing_range 67:12-67:40

              Public Function Method(ByVal parameter As String) As String
'                             ^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads3#Method().
'                                    enclosing_range 69:12-71:24
'                                    documentation ```vb\nPublic Function InheritedOverloads3.Method(parameter As String) As String\n```
'                                    kind Method
'                                          ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads3#Method().(parameter)
'                                                    enclosing_range 69:12-69:71
'                                                    documentation ```vb\nparameter As String\n```
'                                                    kind Parameter
'                                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
                  Return parameter
'                        ^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads3#Method().(parameter)
'                                  enclosing_range 69:12-71:24
              End Function
          End Class

          Public Shared Sub InheritedOverloads()
'                           ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads().
'                                              enclosing_range 74:8-84:15
'                                              documentation ```vb\nPublic Shared Sub Methods.InheritedOverloads()\n```
'                                              kind StaticMethod
              Dim a As InheritedOverloads1 = New InheritedOverloads1
'                 ^ definition local 2
'                   enclosing_range 74:8-84:15
'                   documentation ```vb\na As Class InheritedOverloads1\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
'                      ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
'                                          enclosing_range 74:8-84:15
'                                                ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
'                                                                    enclosing_range 74:8-84:15
              a.Method()
'             ^ read_access local 2
'               enclosing_range 74:8-84:15
'               ^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#Method().
'                      enclosing_range 74:8-84:15
              Dim b As InheritedOverloads2 = New InheritedOverloads2
'                 ^ definition local 3
'                   enclosing_range 74:8-84:15
'                   documentation ```vb\nb As Class InheritedOverloads2\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#
'                      ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#
'                                          enclosing_range 74:8-84:15
'                                                ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#
'                                                                    enclosing_range 74:8-84:15
              DirectCast(b, InheritedOverloads1).Method()
'                        ^ read_access local 3
'                          enclosing_range 74:8-84:15
'                           ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
'                                               enclosing_range 74:8-84:15
'                                                ^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#Method().
'                                                       enclosing_range 74:8-84:15
              b.Method(42)
'             ^ read_access local 3
'               enclosing_range 74:8-84:15
'               ^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#Method().
'                      enclosing_range 74:8-84:15
              Dim c As InheritedOverloads3 = New InheritedOverloads3
'                 ^ definition local 4
'                   enclosing_range 74:8-84:15
'                   documentation ```vb\nc As Class InheritedOverloads3\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget . . VBMain/Methods#InheritedOverloads3#
'                      ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads3#
'                                          enclosing_range 74:8-84:15
'                                                ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads3#
'                                                                    enclosing_range 74:8-84:15
              DirectCast(c, InheritedOverloads1).Method()
'                        ^ read_access local 4
'                          enclosing_range 74:8-84:15
'                           ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#
'                                               enclosing_range 74:8-84:15
'                                                ^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads1#Method().
'                                                       enclosing_range 74:8-84:15
              DirectCast(c, InheritedOverloads2).Method(42)
'                        ^ read_access local 4
'                          enclosing_range 74:8-84:15
'                           ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#
'                                               enclosing_range 74:8-84:15
'                                                ^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads2#Method().
'                                                       enclosing_range 74:8-84:15
              c.Method("42")
'             ^ read_access local 4
'               enclosing_range 74:8-84:15
'               ^^^^^^ read_access scip-dotnet nuget . . VBMain/Methods#InheritedOverloads3#Method().
'                      enclosing_range 74:8-84:15
          End Sub
      End Class
  End Namespace
