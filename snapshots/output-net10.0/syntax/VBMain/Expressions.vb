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
      Public Class Expressions
'                  ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#
'                              enclosing_range 3:4-242:13
'                              documentation ```vb\nClass Expressions\n```
'                              kind Class

          Private Sub AssignmentToPrefixUnaryExpressions()
'                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#AssignmentToPrefixUnaryExpressions().
'                                                        enclosing_range 6:8-15:15
'                                                        documentation ```vb\nPrivate Sub Expressions.AssignmentToPrefixUnaryExpressions()\n```
'                                                        kind Method
              Dim A = 42
'                 ^ definition local 0
'                   enclosing_range 6:8-15:15
'                   documentation ```vb\nA As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Dim B = 42
'                 ^ definition local 1
'                   enclosing_range 6:8-15:15
'                   documentation ```vb\nB As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              A = +A
'             ^ write_access local 0
'               enclosing_range 6:8-15:15
'                  ^ read_access local 0
'                    enclosing_range 6:8-15:15
              A = -A
'             ^ write_access local 0
'               enclosing_range 6:8-15:15
'                  ^ read_access local 0
'                    enclosing_range 6:8-15:15
              A = Not A
'             ^ write_access local 0
'               enclosing_range 6:8-15:15
'                     ^ read_access local 0
'                       enclosing_range 6:8-15:15
              B = A
'             ^ write_access local 1
'               enclosing_range 6:8-15:15
'                 ^ read_access local 0
'                   enclosing_range 6:8-15:15
              Dim C = True
'                 ^ definition local 2
'                   enclosing_range 6:8-15:15
'                   documentation ```vb\nC As Boolean\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
              C = Not C
'             ^ write_access local 2
'               enclosing_range 6:8-15:15
'                     ^ read_access local 2
'                       enclosing_range 6:8-15:15
          End Sub

          Private Sub AssignmentToPrefixBinaryExpressions()
'                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#AssignmentToPrefixBinaryExpressions().
'                                                         enclosing_range 17:8-31:15
'                                                         documentation ```vb\nPrivate Sub Expressions.AssignmentToPrefixBinaryExpressions()\n```
'                                                         kind Method
              Dim A = 42
'                 ^ definition local 3
'                   enclosing_range 17:8-31:15
'                   documentation ```vb\nA As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              A = A + A
'             ^ write_access local 3
'               enclosing_range 17:8-31:15
'                 ^ read_access local 3
'                   enclosing_range 17:8-31:15
'                     ^ read_access local 3
'                       enclosing_range 17:8-31:15
              A = A - A
'             ^ write_access local 3
'               enclosing_range 17:8-31:15
'                 ^ read_access local 3
'                   enclosing_range 17:8-31:15
'                     ^ read_access local 3
'                       enclosing_range 17:8-31:15
              A = A * A
'             ^ write_access local 3
'               enclosing_range 17:8-31:15
'                 ^ read_access local 3
'                   enclosing_range 17:8-31:15
'                     ^ read_access local 3
'                       enclosing_range 17:8-31:15
              A = A / A
'             ^ write_access local 3
'               enclosing_range 17:8-31:15
'                 ^ read_access local 3
'                   enclosing_range 17:8-31:15
'                     ^ read_access local 3
'                       enclosing_range 17:8-31:15
              A = A \ A
'             ^ write_access local 3
'               enclosing_range 17:8-31:15
'                 ^ read_access local 3
'                   enclosing_range 17:8-31:15
'                     ^ read_access local 3
'                       enclosing_range 17:8-31:15
              A = A ^ A
'             ^ write_access local 3
'               enclosing_range 17:8-31:15
'                 ^ read_access local 3
'                   enclosing_range 17:8-31:15
'                     ^ read_access local 3
'                       enclosing_range 17:8-31:15
              A = A Mod A
'             ^ write_access local 3
'               enclosing_range 17:8-31:15
'                 ^ read_access local 3
'                   enclosing_range 17:8-31:15
'                       ^ read_access local 3
'                         enclosing_range 17:8-31:15
              A = A And A
'             ^ write_access local 3
'               enclosing_range 17:8-31:15
'                 ^ read_access local 3
'                   enclosing_range 17:8-31:15
'                       ^ read_access local 3
'                         enclosing_range 17:8-31:15
              A = A Or A
'             ^ write_access local 3
'               enclosing_range 17:8-31:15
'                 ^ read_access local 3
'                   enclosing_range 17:8-31:15
'                      ^ read_access local 3
'                        enclosing_range 17:8-31:15
              A = A Xor A
'             ^ write_access local 3
'               enclosing_range 17:8-31:15
'                 ^ read_access local 3
'                   enclosing_range 17:8-31:15
'                       ^ read_access local 3
'                         enclosing_range 17:8-31:15
              A = A << A
'             ^ write_access local 3
'               enclosing_range 17:8-31:15
'                 ^ read_access local 3
'                   enclosing_range 17:8-31:15
'                      ^ read_access local 3
'                        enclosing_range 17:8-31:15
              A = A >> A
'             ^ write_access local 3
'               enclosing_range 17:8-31:15
'                 ^ read_access local 3
'                   enclosing_range 17:8-31:15
'                      ^ read_access local 3
'                        enclosing_range 17:8-31:15
          End Sub

          Private Sub AssignmentToBinaryEqualityExpression()
'                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#AssignmentToBinaryEqualityExpression().
'                                                          enclosing_range 33:8-44:15
'                                                          documentation ```vb\nPrivate Sub Expressions.AssignmentToBinaryEqualityExpression()\n```
'                                                          kind Method
              Dim A = True
'                 ^ definition local 4
'                   enclosing_range 33:8-44:15
'                   documentation ```vb\nA As Boolean\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
              Dim B = True
'                 ^ definition local 5
'                   enclosing_range 33:8-44:15
'                   documentation ```vb\nB As Boolean\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
              Dim C = 42
'                 ^ definition local 6
'                   enclosing_range 33:8-44:15
'                   documentation ```vb\nC As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Dim D = 42
'                 ^ definition local 7
'                   enclosing_range 33:8-44:15
'                   documentation ```vb\nD As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              A = A = B
'             ^ write_access local 4
'               enclosing_range 33:8-44:15
'                 ^ read_access local 4
'                   enclosing_range 33:8-44:15
'                     ^ read_access local 5
'                       enclosing_range 33:8-44:15
              A = A <> B
'             ^ write_access local 4
'               enclosing_range 33:8-44:15
'                 ^ read_access local 4
'                   enclosing_range 33:8-44:15
'                      ^ read_access local 5
'                        enclosing_range 33:8-44:15
              A = C < D
'             ^ write_access local 4
'               enclosing_range 33:8-44:15
'                 ^ read_access local 6
'                   enclosing_range 33:8-44:15
'                     ^ read_access local 7
'                       enclosing_range 33:8-44:15
              A = C <= D
'             ^ write_access local 4
'               enclosing_range 33:8-44:15
'                 ^ read_access local 6
'                   enclosing_range 33:8-44:15
'                      ^ read_access local 7
'                        enclosing_range 33:8-44:15
              A = C > D
'             ^ write_access local 4
'               enclosing_range 33:8-44:15
'                 ^ read_access local 6
'                   enclosing_range 33:8-44:15
'                     ^ read_access local 7
'                       enclosing_range 33:8-44:15
              A = C >= D
'             ^ write_access local 4
'               enclosing_range 33:8-44:15
'                 ^ read_access local 6
'                   enclosing_range 33:8-44:15
'                      ^ read_access local 7
'                        enclosing_range 33:8-44:15
          End Sub

          Private Sub AssignmentToBinaryExpression()
'                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#AssignmentToBinaryExpression().
'                                                  enclosing_range 46:8-57:15
'                                                  documentation ```vb\nPrivate Sub Expressions.AssignmentToBinaryExpression()\n```
'                                                  kind Method
              Dim A = 42
'                 ^ definition local 8
'                   enclosing_range 46:8-57:15
'                   documentation ```vb\nA As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              A += A
'             ^ write_access local 8
'               enclosing_range 46:8-57:15
'                  ^ read_access local 8
'                    enclosing_range 46:8-57:15
              A -= A
'             ^ write_access local 8
'               enclosing_range 46:8-57:15
'                  ^ read_access local 8
'                    enclosing_range 46:8-57:15
              A *= A
'             ^ write_access local 8
'               enclosing_range 46:8-57:15
'                  ^ read_access local 8
'                    enclosing_range 46:8-57:15
              A /= A
'             ^ write_access local 8
'               enclosing_range 46:8-57:15
'                  ^ read_access local 8
'                    enclosing_range 46:8-57:15
              A \= A
'             ^ write_access local 8
'               enclosing_range 46:8-57:15
'                  ^ read_access local 8
'                    enclosing_range 46:8-57:15
              A &= A
'             ^ write_access local 8
'               enclosing_range 46:8-57:15
'                  ^ read_access local 8
'                    enclosing_range 46:8-57:15
              A <<= A
'             ^ write_access local 8
'               enclosing_range 46:8-57:15
'                   ^ read_access local 8
'                     enclosing_range 46:8-57:15
              A >>= A
'             ^ write_access local 8
'               enclosing_range 46:8-57:15
'                   ^ read_access local 8
'                     enclosing_range 46:8-57:15
              A ^= A
'             ^ write_access local 8
'               enclosing_range 46:8-57:15
'                  ^ read_access local 8
'                    enclosing_range 46:8-57:15
          End Sub

          Structure Struct
'                   ^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Struct#
'                          enclosing_range 59:8-61:21
'                          documentation ```vb\nStructure Struct\n```
'                          kind Struct
              Public [Property] As Integer
'                    ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Struct#Property.
'                               enclosing_range 60:12-60:40
'                               documentation ```vb\nPublic Struct.Property As Integer\n```
'                               kind Field
'                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          End Structure

          Structure IndexedClass
'                   ^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#IndexedClass#
'                                enclosing_range 63:8-74:21
'                                documentation ```vb\nStructure IndexedClass\n```
'                                kind Struct
              Public [Property] As Integer
'                    ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#IndexedClass#Property.
'                               enclosing_range 64:12-64:40
'                               documentation ```vb\nPublic IndexedClass.Property As Integer\n```
'                               kind Field
'                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#

              Default Public Property Item(ByVal index As Integer) As Integer
'                                     ^^^^ definition scip-dotnet nuget . . VBMain/Expressions#IndexedClass#Item.
'                                          enclosing_range 66:12-73:24
'                                          documentation ```vb\nPublic Default Property IndexedClass.Item(index As Integer) As Integer\n```
'                                          kind Property
'                                          relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                                ^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#IndexedClass#Item.(index)
'                                                      enclosing_range 66:12-66:75
'                                                      documentation ```vb\nindex As Integer\n```
'                                                      kind Parameter
'                                                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
                  Get
                      Return [Property]
'                            ^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#IndexedClass#Property.
'                                       enclosing_range 67:16-69:23
                  End Get
                  Set(ByVal value As Integer)
'                           ^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#IndexedClass#set_Item().(value)
'                                 enclosing_range 70:16-70:43
'                                 documentation ```vb\nvalue As Integer\n```
'                                 kind Parameter
'                                 relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
                      [Property] = value
'                     ^^^^^^^^^^ write_access scip-dotnet nuget . . VBMain/Expressions#IndexedClass#Property.
'                                enclosing_range 70:16-72:23
'                                  ^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#IndexedClass#set_Item().(value)
'                                        enclosing_range 70:16-72:23
                  End Set
              End Property
          End Structure

          Private Sub AssignmentToLeftValueTypes()
'                     ^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#AssignmentToLeftValueTypes().
'                                                enclosing_range 76:8-89:15
'                                                documentation ```vb\nPrivate Sub Expressions.AssignmentToLeftValueTypes()\n```
'                                                kind Method
              Dim E As (A As Integer, B As Integer) = (1, 2)
'                 ^ definition local 9
'                   enclosing_range 76:8-89:15
'                   documentation ```vb\nE As (A As Integer, B As Integer)\n```
'                   kind Variable
'                   relationship type_definition local 10
              Dim A = 1
'                 ^ definition local 11
'                   enclosing_range 76:8-89:15
'                   documentation ```vb\nA As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Dim C = New Struct With {
'                 ^ definition local 12
'                   enclosing_range 76:8-89:15
'                   documentation ```vb\nC As Structure Struct\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget . . VBMain/Expressions#Struct#
'                         ^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Struct#
'                                enclosing_range 76:8-89:15
                  .[Property] = 42
'                  ^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Struct#Property.
'                             enclosing_range 76:8-89:15
              }
              C.[Property] = 1
'             ^ read_access local 12
'               enclosing_range 76:8-89:15
'               ^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Struct#Property.
'                          enclosing_range 76:8-89:15
              Dim D = New IndexedClass()
'                 ^ definition local 13
'                   enclosing_range 76:8-89:15
'                   documentation ```vb\nD As Structure IndexedClass\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget . . VBMain/Expressions#IndexedClass#
'                         ^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#IndexedClass#
'                                      enclosing_range 76:8-89:15
              D(E.B) = 1
'             ^ read_access local 13
'               enclosing_range 76:8-89:15
'               ^ read_access local 9
'                 enclosing_range 76:8-89:15
'                 ^ read_access local 14
'                   enclosing_range 76:8-89:15
              Dim X = New IndexedClass With {
'                 ^ definition local 15
'                   enclosing_range 76:8-89:15
'                   documentation ```vb\nX As Structure IndexedClass\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget . . VBMain/Expressions#IndexedClass#
'                         ^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#IndexedClass#
'                                      enclosing_range 76:8-89:15
                  .[Property] = 1
'                  ^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#IndexedClass#Property.
'                             enclosing_range 76:8-89:15
              }
              E.A = 1
'             ^ read_access local 9
'               enclosing_range 76:8-89:15
'               ^ read_access local 16
'                 enclosing_range 76:8-89:15
          End Sub

          Private Sub TernaryExpression()
'                     ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#TernaryExpression().
'                                       enclosing_range 91:8-96:15
'                                       documentation ```vb\nPrivate Sub Expressions.TernaryExpression()\n```
'                                       kind Method
              Dim X = True
'                 ^ definition local 17
'                   enclosing_range 91:8-96:15
'                   documentation ```vb\nX As Boolean\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
              Dim Y = If(X, "foo", "bar")
'                 ^ definition local 18
'                   enclosing_range 91:8-96:15
'                   documentation ```vb\nY As String\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
'                        ^ read_access local 17
'                          enclosing_range 91:8-96:15
              Dim Z As Object = True
'                 ^ definition local 19
'                   enclosing_range 91:8-96:15
'                   documentation ```vb\nZ As Object\n```
'                   kind Variable
              Dim T = If(TypeOf Z Is Boolean, 42, 41)
'                 ^ definition local 20
'                   enclosing_range 91:8-96:15
'                   documentation ```vb\nT As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                               ^ read_access local 19
'                                 enclosing_range 91:8-96:15
          End Sub

          Class Cast
'               ^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Cast#
'                    enclosing_range 98:8-109:17
'                    documentation ```vb\nClass Cast\n```
'                    kind Class
              Public Nested As Cast
'                    ^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Cast#Nested.
'                           enclosing_range 99:12-99:33
'                           documentation ```vb\nPublic Cast.Nested As Cast\n```
'                           kind Field
'                           relationship type_definition scip-dotnet nuget . . VBMain/Expressions#Cast#
'                              ^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#
'                                   enclosing_range 99:12-99:33
              Public Nested2 As Cast2
'                    ^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Cast#Nested2.
'                            enclosing_range 100:12-100:35
'                            documentation ```vb\nPublic Cast.Nested2 As Cast2\n```
'                            kind Field
'                            relationship type_definition scip-dotnet nuget . . VBMain/Expressions#Cast#Cast2#
'                               ^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#Cast2#
'                                     enclosing_range 100:12-100:35

              Public Function Plus(ByVal other As Cast) As Cast
'                             ^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Cast#Plus().
'                                  enclosing_range 102:12-105:24
'                                  documentation ```vb\nPublic Function Cast.Plus(other As Cast) As Cast\n```
'                                  kind Method
'                                        ^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Cast#Plus().(other)
'                                              enclosing_range 102:12-102:61
'                                              documentation ```vb\nother As Cast\n```
'                                              kind Parameter
'                                              relationship type_definition scip-dotnet nuget . . VBMain/Expressions#Cast#
'                                                 ^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#
'                                                      enclosing_range 102:12-102:61
'                                                          ^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#
'                                                               enclosing_range 102:12-102:61
                  Nested = other
'                 ^^^^^^ write_access scip-dotnet nuget . . VBMain/Expressions#Cast#Nested.
'                        enclosing_range 102:12-105:24
'                          ^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#Plus().(other)
'                                enclosing_range 102:12-105:24
                  Return Me
              End Function

              Public Class Cast2
'                          ^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Cast#Cast2#
'                                enclosing_range 107:12-108:21
'                                documentation ```vb\nClass Cast2\n```
'                                kind Class
              End Class
          End Class

          Private Function CastExpressions() As Integer
'                          ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#CastExpressions().
'                                          enclosing_range 111:8-121:20
'                                          documentation ```vb\nPrivate Function Expressions.CastExpressions() As Integer\n```
'                                          kind Method
              Dim A As Object = New Cast()
'                 ^ definition local 21
'                   enclosing_range 111:8-121:20
'                   documentation ```vb\nA As Object\n```
'                   kind Variable
'                                   ^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#
'                                        enclosing_range 111:8-121:20
              Dim B As Object = New Cast()
'                 ^ definition local 22
'                   enclosing_range 111:8-121:20
'                   documentation ```vb\nB As Object\n```
'                   kind Variable
'                                   ^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#
'                                        enclosing_range 111:8-121:20
              Dim C As Cast = (CType(A, Cast)).Plus(CType(B, Cast))
'                 ^ definition local 23
'                   enclosing_range 111:8-121:20
'                   documentation ```vb\nC As Class Cast\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget . . VBMain/Expressions#Cast#
'                      ^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#
'                           enclosing_range 111:8-121:20
'                                    ^ read_access local 21
'                                      enclosing_range 111:8-121:20
'                                       ^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#
'                                            enclosing_range 111:8-121:20
'                                              ^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#Plus().
'                                                   enclosing_range 111:8-121:20
'                                                         ^ read_access local 22
'                                                           enclosing_range 111:8-121:20
'                                                            ^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#
'                                                                 enclosing_range 111:8-121:20
              Dim D As Cast = CType(New Object() {A, B}(0), Cast)
'                 ^ definition local 24
'                   enclosing_range 111:8-121:20
'                   documentation ```vb\nD As Class Cast\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget . . VBMain/Expressions#Cast#
'                      ^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#
'                           enclosing_range 111:8-121:20
'                                                 ^ read_access local 21
'                                                   enclosing_range 111:8-121:20
'                                                    ^ read_access local 22
'                                                      enclosing_range 111:8-121:20
'                                                           ^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#
'                                                                enclosing_range 111:8-121:20
              Dim E = CType((C.Nested.Nested2), Cast.Cast2)
'                 ^ definition local 25
'                   enclosing_range 111:8-121:20
'                   documentation ```vb\nE As Class Cast2\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget . . VBMain/Expressions#Cast#Cast2#
'                            ^ read_access local 23
'                              enclosing_range 111:8-121:20
'                              ^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#Nested.
'                                     enclosing_range 111:8-121:20
'                                     ^^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#Nested2.
'                                             enclosing_range 111:8-121:20
'                                               ^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#
'                                                    enclosing_range 111:8-121:20
'                                                    ^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Cast#Cast2#
'                                                          enclosing_range 111:8-121:20
              Dim F = CType((1), Int32)
'                 ^ definition local 26
'                   enclosing_range 111:8-121:20
'                   documentation ```vb\nF As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                      enclosing_range 111:8-121:20
              Dim G = CType((1), Int32)
'                 ^ definition local 27
'                   enclosing_range 111:8-121:20
'                   documentation ```vb\nG As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                      enclosing_range 111:8-121:20
              Dim H = CType(((1)), Int32)
'                 ^ definition local 28
'                   enclosing_range 111:8-121:20
'                   documentation ```vb\nH As Integer\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                  ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                        enclosing_range 111:8-121:20
              Return F + G + H
'                    ^ read_access local 26
'                      enclosing_range 111:8-121:20
'                        ^ read_access local 27
'                          enclosing_range 111:8-121:20
'                            ^ read_access local 28
'                              enclosing_range 111:8-121:20
          End Function

          Private Function AnonymousObject() As Object
'                          ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#AnonymousObject().
'                                          enclosing_range 123:8-127:20
'                                          documentation ```vb\nPrivate Function Expressions.AnonymousObject() As Object\n```
'                                          kind Method
              Dim X = New With {Key .Helper = ""}
'                 ^ definition local 29
'                   enclosing_range 123:8-127:20
'                   documentation ```vb\nX As AnonymousType <anonymous type: Key Helper As String>\n```
'                   kind Variable
'                   relationship type_definition local 30
'                                    ^^^^^^ read_access local 31
'                                           enclosing_range 123:8-127:20
              Dim Y = New With {X}
'                 ^ definition local 32
'                   enclosing_range 123:8-127:20
'                   documentation ```vb\nY As AnonymousType <anonymous type: X As AnonymousType <anonymous type: Key Helper As String>>\n```
'                   kind Variable
'                   relationship type_definition local 33
'                               ^ read_access local 29
'                                 enclosing_range 123:8-127:20
              Return Y.x.Helper
'                    ^ read_access local 32
'                      enclosing_range 123:8-127:20
'                      ^ read_access local 34
'                        enclosing_range 123:8-127:20
'                        ^^^^^^ read_access local 31
'                               enclosing_range 123:8-127:20
          End Function

          Class ObjectCreationClass
'               ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#
'                                   enclosing_range 129:8-140:17
'                                   documentation ```vb\nClass ObjectCreationClass\n```
'                                   kind Class
              Public Field As D
'                    ^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#Field.
'                          enclosing_range 130:12-130:29
'                          documentation ```vb\nPublic ObjectCreationClass.Field As D\n```
'                          kind Field
'                          relationship type_definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#
'                             ^ read_access scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#
'                               enclosing_range 130:12-130:29

              Public Sub New(ByVal field As D)
'                        ^^^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#`.ctor`().
'                            enclosing_range 132:12-134:19
'                            documentation ```vb\nPublic Sub ObjectCreationClass.New(field As D)\n```
'                            kind Constructor
'                                  ^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#`.ctor`().(field)
'                                        enclosing_range 132:12-132:44
'                                        documentation ```vb\nfield As D\n```
'                                        kind Parameter
'                                        relationship type_definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#
'                                           ^ read_access scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#
'                                             enclosing_range 132:12-132:44
                  Me.Field = field
'                    ^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#Field.
'                          enclosing_range 132:12-134:19
'                            ^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#`.ctor`().(field)
'                                  enclosing_range 132:12-134:19
              End Sub

              Public Class D
'                          ^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#
'                            enclosing_range 136:12-139:21
'                            documentation ```vb\nClass D\n```
'                            kind Class
                  Public Sub New(ByVal a As Integer, ByVal b As String)
'                            ^^^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#`.ctor`().
'                                enclosing_range 137:16-138:23
'                                documentation ```vb\nPublic Sub D.New(a As Integer, b As String)\n```
'                                kind Constructor
'                                      ^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#`.ctor`().(a)
'                                        enclosing_range 137:16-137:69
'                                        documentation ```vb\na As Integer\n```
'                                        kind Parameter
'                                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                                          ^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#`.ctor`().(b)
'                                                            enclosing_range 137:16-137:69
'                                                            documentation ```vb\nb As String\n```
'                                                            kind Parameter
'                                                            relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
                  End Sub
              End Class
          End Class

          Private Sub ObjectCreation()
'                     ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreation().
'                                    enclosing_range 142:8-148:15
'                                    documentation ```vb\nPrivate Sub Expressions.ObjectCreation()\n```
'                                    kind Method
              Dim A = New ObjectCreationClass.D(1, "hi")
'                 ^ definition local 35
'                   enclosing_range 142:8-148:15
'                   documentation ```vb\nA As Class D\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#
'                         ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#
'                                             enclosing_range 142:8-148:15
'                                             ^ read_access scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#D#
'                                               enclosing_range 142:8-148:15
              Dim B = New ObjectCreationClass(A) With {
'                 ^ definition local 36
'                   enclosing_range 142:8-148:15
'                   documentation ```vb\nB As Class ObjectCreationClass\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#
'                         ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#
'                                             enclosing_range 142:8-148:15
'                                             ^ read_access local 35
'                                               enclosing_range 142:8-148:15
                  .Field = A
'                  ^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#Field.
'                        enclosing_range 142:8-148:15
'                          ^ read_access local 35
'                            enclosing_range 142:8-148:15
              }
              B = New ObjectCreationClass(A)
'             ^ write_access local 36
'               enclosing_range 142:8-148:15
'                     ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#ObjectCreationClass#
'                                         enclosing_range 142:8-148:15
'                                         ^ read_access local 35
'                                           enclosing_range 142:8-148:15
          End Sub

          Class NamedParametersClass
'               ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#
'                                    enclosing_range 150:8-163:17
'                                    documentation ```vb\nClass NamedParametersClass\n```
'                                    kind Class
              Public A As Integer
'                    ^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#A.
'                      enclosing_range 151:12-151:31
'                      documentation ```vb\nPublic NamedParametersClass.A As Integer\n```
'                      kind Field
'                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Public B As String
'                    ^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#B.
'                      enclosing_range 152:12-152:30
'                      documentation ```vb\nPublic NamedParametersClass.B As String\n```
'                      kind Field
'                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#

              Public Sub New(ByVal a As Integer, ByVal b As String)
'                        ^^^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#`.ctor`().
'                            enclosing_range 154:12-157:19
'                            documentation ```vb\nPublic Sub NamedParametersClass.New(a As Integer, b As String)\n```
'                            kind Constructor
'                                  ^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#`.ctor`().(a)
'                                    enclosing_range 154:12-154:65
'                                    documentation ```vb\na As Integer\n```
'                                    kind Parameter
'                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                                      ^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#`.ctor`().(b)
'                                                        enclosing_range 154:12-154:65
'                                                        documentation ```vb\nb As String\n```
'                                                        kind Parameter
'                                                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
                  Me.A = a
'                    ^ read_access scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#A.
'                      enclosing_range 154:12-157:19
'                        ^ read_access scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#`.ctor`().(a)
'                          enclosing_range 154:12-157:19
                  Me.B = b
'                    ^ read_access scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#B.
'                      enclosing_range 154:12-157:19
'                        ^ read_access scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#`.ctor`().(b)
'                          enclosing_range 154:12-157:19
              End Sub

              Public Sub Update(ByVal a As Integer, ByVal b As String)
'                        ^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().
'                               enclosing_range 159:12-162:19
'                               documentation ```vb\nPublic Sub NamedParametersClass.Update(a As Integer, b As String)\n```
'                               kind Method
'                                     ^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().(a)
'                                       enclosing_range 159:12-159:68
'                                       documentation ```vb\na As Integer\n```
'                                       kind Parameter
'                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                                         ^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().(b)
'                                                           enclosing_range 159:12-159:68
'                                                           documentation ```vb\nb As String\n```
'                                                           kind Parameter
'                                                           relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
                  Me.A = a
'                    ^ read_access scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#A.
'                      enclosing_range 159:12-162:19
'                        ^ read_access scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().(a)
'                          enclosing_range 159:12-162:19
                  Me.B = b
'                    ^ read_access scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#B.
'                      enclosing_range 159:12-162:19
'                        ^ read_access scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().(b)
'                          enclosing_range 159:12-162:19
              End Sub
          End Class

          Private Function NamedParameters() As NamedParametersClass
'                          ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#NamedParameters().
'                                          enclosing_range 165:8-169:20
'                                          documentation ```vb\nPrivate Function Expressions.NamedParameters() As NamedParametersClass\n```
'                                          kind Method
'                                               ^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#
'                                                                    enclosing_range 165:8-165:66
              Dim A = New NamedParametersClass(b:="hi", a:=1)
'                 ^ definition local 37
'                   enclosing_range 165:8-169:20
'                   documentation ```vb\nA As Class NamedParametersClass\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#
'                         ^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#
'                                              enclosing_range 165:8-169:20
'                                              ^ read_access scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#`.ctor`().(b)
'                                                enclosing_range 165:8-169:20
'                                                       ^ read_access scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#`.ctor`().(a)
'                                                         enclosing_range 165:8-169:20
              A.Update(b:="foo", a:=42)
'             ^ read_access local 37
'               enclosing_range 165:8-169:20
'               ^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().
'                      enclosing_range 165:8-169:20
'                      ^ read_access scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().(b)
'                        enclosing_range 165:8-169:20
'                                ^ read_access scip-dotnet nuget . . VBMain/Expressions#NamedParametersClass#Update().(a)
'                                  enclosing_range 165:8-169:20
              Return A
'                    ^ read_access local 37
'                      enclosing_range 165:8-169:20
          End Function

          Private Function AnonymousFunction() As Func(Of Integer, Integer)
'                          ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#AnonymousFunction().
'                                            enclosing_range 171:8-174:20
'                                            documentation ```vb\nPrivate Function Expressions.AnonymousFunction() As Func(Of Integer, Integer)\n```
'                                            kind Method
              Dim d = Function(ByVal __ As Integer, ByVal ___ As Integer) 42
'                 ^ definition local 38
'                   enclosing_range 171:8-174:20
'                   documentation ```vb\nd As AnonymousType Function <generated method>(__ As Integer, ___ As Integer) As Integer\n```
'                   kind Variable
'                   relationship type_definition local 39
'                                    ^^ definition local 41
'                                       enclosing_range 172:20-172:71
'                                       documentation ```vb\n__ As Integer\n```
'                                       kind Parameter
'                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                                         ^^^ definition local 42
'                                                             enclosing_range 172:20-172:71
'                                                             documentation ```vb\n___ As Integer\n```
'                                                             kind Parameter
'                                                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Return Function(ByVal a As Integer) a + d.Invoke(a, a)
'                                   ^ definition local 44
'                                     enclosing_range 173:19-173:47
'                                     documentation ```vb\na As Integer\n```
'                                     kind Parameter
'                                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
'                                                 ^ read_access local 44
'                                                   enclosing_range 171:8-174:20
'                                                     ^ read_access local 38
'                                                       enclosing_range 171:8-174:20
'                                                       ^^^^^^ read_access local 45
'                                                              enclosing_range 171:8-174:20
'                                                              ^ read_access local 44
'                                                                enclosing_range 171:8-174:20
'                                                                 ^ read_access local 44
'                                                                   enclosing_range 171:8-174:20
          End Function

          Class Lambda
'               ^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Lambda#
'                      enclosing_range 176:8-180:17
'                      documentation ```vb\nClass Lambda\n```
'                      kind Class
              Public Function func(ByVal x As Lambda) As String
'                             ^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Lambda#func().
'                                  enclosing_range 177:12-179:24
'                                  documentation ```vb\nPublic Function Lambda.func(x As Lambda) As String\n```
'                                  kind Method
'                                        ^ definition scip-dotnet nuget . . VBMain/Expressions#Lambda#func().(x)
'                                          enclosing_range 177:12-177:61
'                                          documentation ```vb\nx As Lambda\n```
'                                          kind Parameter
'                                          relationship type_definition scip-dotnet nuget . . VBMain/Expressions#Lambda#
'                                             ^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Lambda#
'                                                    enclosing_range 177:12-177:61
                  Return ""
              End Function
          End Class

          Private Sub LambdaExpressions()
'                     ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#LambdaExpressions().
'                                       enclosing_range 182:8-190:15
'                                       documentation ```vb\nPrivate Sub Expressions.LambdaExpressions()\n```
'                                       kind Method
              Dim a = Function(ByVal x As String) x & 1
'                 ^ definition local 46
'                   enclosing_range 182:8-190:15
'                   documentation ```vb\na As AnonymousType Function <generated method>(x As String) As String\n```
'                   kind Variable
'                   relationship type_definition local 47
'                                    ^ definition local 49
'                                      enclosing_range 183:20-183:47
'                                      documentation ```vb\nx As String\n```
'                                      kind Parameter
'                                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
'                                                 ^ read_access local 49
'                                                   enclosing_range 182:8-190:15
              Dim b = Function(ByVal aa As Lambda, ByVal bb As Lambda) aa.func(bb)
'                 ^ definition local 50
'                   enclosing_range 182:8-190:15
'                   documentation ```vb\nb As AnonymousType Function <generated method>(aa As Lambda, bb As Lambda) As String\n```
'                   kind Variable
'                   relationship type_definition local 51
'                                    ^^ definition local 53
'                                       enclosing_range 184:20-184:68
'                                       documentation ```vb\naa As Lambda\n```
'                                       kind Parameter
'                                       relationship type_definition scip-dotnet nuget . . VBMain/Expressions#Lambda#
'                                          ^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Lambda#
'                                                 enclosing_range 184:20-184:68
'                                                        ^^ definition local 54
'                                                           enclosing_range 184:20-184:68
'                                                           documentation ```vb\nbb As Lambda\n```
'                                                           kind Parameter
'                                                           relationship type_definition scip-dotnet nuget . . VBMain/Expressions#Lambda#
'                                                              ^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Lambda#
'                                                                     enclosing_range 184:20-184:68
'                                                                      ^^ read_access local 53
'                                                                         enclosing_range 182:8-190:15
'                                                                         ^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Lambda#func().
'                                                                              enclosing_range 182:8-190:15
'                                                                              ^^ read_access local 54
'                                                                                 enclosing_range 182:8-190:15
              Dim c = Function(aaa As Lambda, __ As Lambda)
'                 ^ definition local 55
'                   enclosing_range 182:8-190:15
'                   documentation ```vb\nc As AnonymousType Function <generated method>(aaa As Lambda, __ As Lambda) As String\n```
'                   kind Variable
'                   relationship type_definition local 56
'                              ^^^ definition local 58
'                                  enclosing_range 185:20-185:57
'                                  documentation ```vb\naaa As Lambda\n```
'                                  kind Parameter
'                                  relationship type_definition scip-dotnet nuget . . VBMain/Expressions#Lambda#
'                                     ^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Lambda#
'                                            enclosing_range 185:20-185:57
'                                             ^^ definition local 59
'                                                enclosing_range 185:20-185:57
'                                                documentation ```vb\n__ As Lambda\n```
'                                                kind Parameter
'                                                relationship type_definition scip-dotnet nuget . . VBMain/Expressions#Lambda#
'                                                   ^^^^^^ read_access scip-dotnet nuget . . VBMain/Expressions#Lambda#
'                                                          enclosing_range 185:20-185:57
                          If True Then
                              Return "hi"
                          End If
                      End Function
          End Sub

          Private Sub TupleExpression()
'                     ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#TupleExpression().
'                                     enclosing_range 192:8-194:15
'                                     documentation ```vb\nPrivate Sub Expressions.TupleExpression()\n```
'                                     kind Method
              Dim A = (1, 2, "")
'                 ^ definition local 60
'                   enclosing_range 192:8-194:15
'                   documentation ```vb\nA As (Integer, Integer, String)\n```
'                   kind Variable
'                   relationship type_definition local 61
          End Sub

          Private Sub ArrayCreation()
'                     ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#ArrayCreation().
'                                   enclosing_range 196:8-217:15
'                                   documentation ```vb\nPrivate Sub Expressions.ArrayCreation()\n```
'                                   kind Method
              Dim a = {
'                 ^ definition local 62
'                   enclosing_range 196:8-217:15
'                   documentation ```vb\na As Integer(*,*)\n```
'                   kind Variable
'                   relationship type_definition local 63
              {1, 1},
              {2, 2},
              {3, 3}}
              Dim d = New Integer(2) {1, 2, 3}
'                 ^ definition local 64
'                   enclosing_range 196:8-217:15
'                   documentation ```vb\nd As Integer()\n```
'                   kind Variable
'                   relationship type_definition local 65
              Dim e = New Byte(,) {
'                 ^ definition local 66
'                   enclosing_range 196:8-217:15
'                   documentation ```vb\ne As Byte(*,*)\n```
'                   kind Variable
'                   relationship type_definition local 67
              {1, 2},
              {2, 3}}
              Dim f = New Integer(2, 1) {
'                 ^ definition local 68
'                   enclosing_range 196:8-217:15
'                   documentation ```vb\nf As Integer(*,*)\n```
'                   kind Variable
'                   relationship type_definition local 63
              {1, 1},
              {2, 2},
              {3, 3}}

              Dim numbers(4) As Integer
'                 ^^^^^^^ definition local 69
'                         enclosing_range 196:8-217:15
'                         documentation ```vb\nnumbers As Integer()\n```
'                         kind Variable
'                         relationship type_definition local 65
              Dim numbers2 = New Integer() {1, 2, 4, 8}
'                 ^^^^^^^^ definition local 70
'                          enclosing_range 196:8-217:15
'                          documentation ```vb\nnumbers2 As Integer()\n```
'                          kind Variable
'                          relationship type_definition local 65
              ReDim Preserve numbers(15)
'                            ^^^^^^^ read_access local 69
'                                    enclosing_range 196:8-217:15
              ReDim numbers(15)
'                   ^^^^^^^ read_access local 69
'                           enclosing_range 196:8-217:15
              Dim matrix(5, 5) As Double
'                 ^^^^^^ definition local 71
'                        enclosing_range 196:8-217:15
'                        documentation ```vb\nmatrix As Double(*,*)\n```
'                        kind Variable
'                        relationship type_definition local 72
              Dim matrix2 = New Integer(,) {{1, 2, 3}, {2, 3, 4}, {3, 4, 5}, {4, 5, 6}}
'                 ^^^^^^^ definition local 73
'                         enclosing_range 196:8-217:15
'                         documentation ```vb\nmatrix2 As Integer(*,*)\n```
'                         kind Variable
'                         relationship type_definition local 63
              Dim sales()() As Double = New Double(11)() {}
'                 ^^^^^ definition local 74
'                       enclosing_range 196:8-217:15
'                       documentation ```vb\nsales As Double()()\n```
'                       kind Variable
'                       relationship type_definition local 75
          End Sub

          Private Sub [TypeOf]()
'                     ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#TypeOf().
'                              enclosing_range 219:8-224:15
'                              documentation ```vb\nPrivate Sub Expressions.TypeOf()\n```
'                              kind Method
              Dim a = GetType(Integer)
'                 ^ definition local 76
'                   enclosing_range 219:8-224:15
'                   documentation ```vb\na As Class Type\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Type#
              Dim b = GetType(List(Of String).Enumerator)
'                 ^ definition local 77
'                   enclosing_range 219:8-224:15
'                   documentation ```vb\nb As Class Type\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Type#
'                                             ^^^^^^^^^^ read_access scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#Enumerator#
'                                                        enclosing_range 219:8-224:15
              Dim c = GetType(Dictionary(Of,))
'                 ^ definition local 78
'                   enclosing_range 219:8-224:15
'                   documentation ```vb\nc As Class Type\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Type#
              Dim d = GetType(Tuple(Of,,,))
'                 ^ definition local 79
'                   enclosing_range 219:8-224:15
'                   documentation ```vb\nd As Class Type\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Type#
          End Sub

          Private Sub SelectCase()
'                     ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#SelectCase().
'                                enclosing_range 226:8-236:15
'                                documentation ```vb\nPrivate Sub Expressions.SelectCase()\n```
'                                kind Method
              Dim Some = 42
'                 ^^^^ definition local 80
'                      enclosing_range 226:8-236:15
'                      documentation ```vb\nSome As Integer\n```
'                      kind Variable
'                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Select Case Some
'                         ^^^^ read_access local 80
'                              enclosing_range 226:8-236:15
                  Case 1
                      Debug.WriteLine("One")
'                     ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 Diagnostics/Debug#
'                           enclosing_range 226:8-236:15
'                           ^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 Diagnostics/Debug#WriteLine(+2).
'                                     enclosing_range 226:8-236:15
                  Case 2
                      Debug.WriteLine("One")
'                     ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 Diagnostics/Debug#
'                           enclosing_range 226:8-236:15
'                           ^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 Diagnostics/Debug#WriteLine(+2).
'                                     enclosing_range 226:8-236:15
                  Case Else
                      Debug.WriteLine("More")
'                     ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 Diagnostics/Debug#
'                           enclosing_range 226:8-236:15
'                           ^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 Diagnostics/Debug#WriteLine(+2).
'                                     enclosing_range 226:8-236:15
              End Select
          End Sub

          Private Sub Dictionary()
'                     ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Expressions#Dictionary().
'                                enclosing_range 238:8-240:15
'                                documentation ```vb\nPrivate Sub Expressions.Dictionary()\n```
'                                kind Method
              Dim A = New Dictionary(Of String, Integer) From {{1, "Test1"}, {2, "Test1"}}
'                 ^ definition local 81
'                   enclosing_range 238:8-240:15
'                   documentation ```vb\nA As Class Dictionary(Of String, Integer)\n```
'                   kind Variable
'                   relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 Generic/Dictionary#
          End Sub

      End Class
  End Namespace
