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
'                      enclosing_range 3:4-4:26
      Public Class Operators
'                  ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Operators#
'                            enclosing_range 3:4-48:13
'                            documentation ```vb\nClass Operators\n```
'                            kind Class
          Public Class PlusMinus
'                      ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                enclosing_range 5:8-17:17
'                                documentation ```vb\nClass PlusMinus\n```
'                                kind Class
              Public Shared Operator +(A As PlusMinus)
'                                      ^ definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#op_UnaryPlus().(A)
'                                        enclosing_range 6:12-6:52
'                                        documentation ```vb\nA As PlusMinus\n```
'                                        kind Parameter
'                                        relationship type_definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                           ^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                                     enclosing_range 6:12-6:52
                  Return 0
              End Operator

              Public Shared Operator +(A As PlusMinus, B As PlusMinus)
'                                      ^ definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#op_Addition().(A)
'                                        enclosing_range 10:12-10:68
'                                        documentation ```vb\nA As PlusMinus\n```
'                                        kind Parameter
'                                        relationship type_definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                           ^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                                     enclosing_range 10:12-10:68
'                                                      ^ definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#op_Addition().(B)
'                                                        enclosing_range 10:12-10:68
'                                                        documentation ```vb\nB As PlusMinus\n```
'                                                        kind Parameter
'                                                        relationship type_definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                                           ^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                                                     enclosing_range 10:12-10:68
                  Return 0
              End Operator

              Public Shared Operator -(A As PlusMinus)
'                                      ^ definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#op_UnaryNegation().(A)
'                                        enclosing_range 14:12-14:52
'                                        documentation ```vb\nA As PlusMinus\n```
'                                        kind Parameter
'                                        relationship type_definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                           ^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                                     enclosing_range 14:12-14:52
                  Return 0
              End Operator
          End Class

          Public Class TrueFalse
'                      ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                enclosing_range 19:8-47:17
'                                documentation ```vb\nClass TrueFalse\n```
'                                kind Class
              Public Shared Operator IsTrue(A As TrueFalse) As Boolean
'                                           ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_True().(A)
'                                             enclosing_range 20:12-20:68
'                                             documentation ```vb\nA As TrueFalse\n```
'                                             kind Parameter
'                                             relationship type_definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                ^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                          enclosing_range 20:12-20:68
                  Return True
              End Operator

              Public Shared Operator IsFalse(A As TrueFalse) As Boolean
'                                            ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_False().(A)
'                                              enclosing_range 24:12-24:69
'                                              documentation ```vb\nA As TrueFalse\n```
'                                              kind Parameter
'                                              relationship type_definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                 ^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                           enclosing_range 24:12-24:69
                  Return False
              End Operator

              Public Shared Operator =(A As TrueFalse, B As TrueFalse) As Boolean
'                                      ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_Equality().(A)
'                                        enclosing_range 28:12-28:79
'                                        documentation ```vb\nA As TrueFalse\n```
'                                        kind Parameter
'                                        relationship type_definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                           ^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                     enclosing_range 28:12-28:79
'                                                      ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_Equality().(B)
'                                                        enclosing_range 28:12-28:79
'                                                        documentation ```vb\nB As TrueFalse\n```
'                                                        kind Parameter
'                                                        relationship type_definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                           ^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                                     enclosing_range 28:12-28:79
                  Return True
              End Operator

              Public Shared Operator <>(A As TrueFalse, B As TrueFalse) As Boolean
'                                       ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_Inequality().(A)
'                                         enclosing_range 32:12-32:80
'                                         documentation ```vb\nA As TrueFalse\n```
'                                         kind Parameter
'                                         relationship type_definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                            ^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                      enclosing_range 32:12-32:80
'                                                       ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_Inequality().(B)
'                                                         enclosing_range 32:12-32:80
'                                                         documentation ```vb\nB As TrueFalse\n```
'                                                         kind Parameter
'                                                         relationship type_definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                            ^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                                      enclosing_range 32:12-32:80
                  Return True
              End Operator

              Public Overrides Function Equals(obj As Object) As Boolean
'                                       ^^^^^^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().
'                                              enclosing_range 36:12-41:24
'                                              documentation ```vb\nPublic Overrides Function TrueFalse.Equals(obj As Object) As Boolean\n```
'                                              kind Method
'                                              relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#Equals().
'                                              ^^^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().(obj)
'                                                  enclosing_range 36:12-36:70
'                                                  documentation ```vb\nobj As Object\n```
'                                                  kind Parameter
                  If ReferenceEquals(Nothing, obj) Then Return False
'                    ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#ReferenceEquals().
'                                    enclosing_range 36:12-41:24
'                                             ^^^ read_access scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().(obj)
'                                                 enclosing_range 36:12-41:24
                  If ReferenceEquals(Me, obj) Then Return True
'                    ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#ReferenceEquals().
'                                    enclosing_range 36:12-41:24
'                                        ^^^ read_access scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().(obj)
'                                            enclosing_range 36:12-41:24
                  If obj.GetType() <> Me.GetType() Then Return False
'                    ^^^ read_access scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().(obj)
'                        enclosing_range 36:12-41:24
'                        ^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#GetType().
'                                enclosing_range 36:12-41:24
'                                        ^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#GetType().
'                                                enclosing_range 36:12-41:24
                  Return Equals(CType(obj, TrueFalse))
'                        ^^^^^^ read_access scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().
'                               enclosing_range 36:12-41:24
'                                     ^^^ read_access scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().(obj)
'                                         enclosing_range 36:12-41:24
'                                          ^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                    enclosing_range 36:12-41:24
              End Function

              Public Overrides Function GetHashCode() As Integer
'                                       ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#GetHashCode().
'                                                   enclosing_range 43:12-45:24
'                                                   documentation ```vb\nPublic Overrides Function TrueFalse.GetHashCode() As Integer\n```
'                                                   kind Method
'                                                   relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#GetHashCode().
                  Throw New NotImplementedException()
'                           ^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
'                                                   enclosing_range 43:12-45:24
              End Function

          End Class
      End Class
  End Namespace
