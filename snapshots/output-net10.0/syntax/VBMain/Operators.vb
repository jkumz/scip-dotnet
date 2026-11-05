  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                enclosing_range 0:8-0:26
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            enclosing_range 0:8-0:26
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
'                  enclosing_range 2:10-2:16
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
'                      enclosing_range 3:5-3:20
      Public Class Operators
'                  ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Operators#
'                            enclosing_range 3:4-4:26
'                            documentation ```vb\nClass Operators\n```
          Public Class PlusMinus
'                      ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                enclosing_range 5:8-5:30
'                                documentation ```vb\nClass PlusMinus\n```
              Public Shared Operator +(A As PlusMinus)
'                                      ^ definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#op_UnaryPlus().(A)
'                                        enclosing_range 6:12-6:52
'                                        documentation ```vb\nA As PlusMinus\n```
'                                        relationship type_definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                           ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                                     enclosing_range 6:42-6:51
                  Return 0
              End Operator

              Public Shared Operator +(A As PlusMinus, B As PlusMinus)
'                                      ^ definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#op_Addition().(A)
'                                        enclosing_range 10:12-10:68
'                                        documentation ```vb\nA As PlusMinus\n```
'                                        relationship type_definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                           ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                                     enclosing_range 10:42-10:51
'                                                      ^ definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#op_Addition().(B)
'                                                        enclosing_range 10:12-10:68
'                                                        documentation ```vb\nB As PlusMinus\n```
'                                                        relationship type_definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                                           ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                                                     enclosing_range 10:58-10:67
                  Return 0
              End Operator

              Public Shared Operator -(A As PlusMinus)
'                                      ^ definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#op_UnaryNegation().(A)
'                                        enclosing_range 14:12-14:52
'                                        documentation ```vb\nA As PlusMinus\n```
'                                        relationship type_definition scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                           ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#PlusMinus#
'                                                     enclosing_range 14:42-14:51
                  Return 0
              End Operator
          End Class

          Public Class TrueFalse
'                      ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                enclosing_range 19:8-19:30
'                                documentation ```vb\nClass TrueFalse\n```
              Public Shared Operator IsTrue(A As TrueFalse) As Boolean
'                                           ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_True().(A)
'                                             enclosing_range 20:12-20:68
'                                             documentation ```vb\nA As TrueFalse\n```
'                                             relationship type_definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                          enclosing_range 20:47-20:56
                  Return True
              End Operator

              Public Shared Operator IsFalse(A As TrueFalse) As Boolean
'                                            ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_False().(A)
'                                              enclosing_range 24:12-24:69
'                                              documentation ```vb\nA As TrueFalse\n```
'                                              relationship type_definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                 ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                           enclosing_range 24:48-24:57
                  Return False
              End Operator

              Public Shared Operator =(A As TrueFalse, B As TrueFalse) As Boolean
'                                      ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_Equality().(A)
'                                        enclosing_range 28:12-28:79
'                                        documentation ```vb\nA As TrueFalse\n```
'                                        relationship type_definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                           ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                     enclosing_range 28:42-28:51
'                                                      ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_Equality().(B)
'                                                        enclosing_range 28:12-28:79
'                                                        documentation ```vb\nB As TrueFalse\n```
'                                                        relationship type_definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                           ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                                     enclosing_range 28:58-28:67
                  Return True
              End Operator

              Public Shared Operator <>(A As TrueFalse, B As TrueFalse) As Boolean
'                                       ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_Inequality().(A)
'                                         enclosing_range 32:12-32:80
'                                         documentation ```vb\nA As TrueFalse\n```
'                                         relationship type_definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                            ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                      enclosing_range 32:43-32:52
'                                                       ^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#op_Inequality().(B)
'                                                         enclosing_range 32:12-32:80
'                                                         documentation ```vb\nB As TrueFalse\n```
'                                                         relationship type_definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                            ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                                      enclosing_range 32:59-32:68
                  Return True
              End Operator

              Public Overrides Function Equals(obj As Object) As Boolean
'                                       ^^^^^^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().
'                                              enclosing_range 36:12-36:70
'                                              documentation ```vb\nPublic Overrides Function TrueFalse.Equals(obj As Object) As Boolean\n```
'                                              relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#Equals().
'                                              ^^^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().(obj)
'                                                  enclosing_range 36:12-36:70
'                                                  documentation ```vb\nobj As Object\n```
                  If ReferenceEquals(Nothing, obj) Then Return False
'                    ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#ReferenceEquals().
'                                    enclosing_range 37:19-37:48
'                                             ^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().(obj)
'                                                 enclosing_range 37:44-37:47
                  If ReferenceEquals(Me, obj) Then Return True
'                    ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#ReferenceEquals().
'                                    enclosing_range 38:19-38:43
'                                        ^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().(obj)
'                                            enclosing_range 38:39-38:42
                  If obj.GetType() <> Me.GetType() Then Return False
'                    ^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().(obj)
'                        enclosing_range 39:19-39:32
'                        ^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#GetType().
'                                enclosing_range 39:19-39:32
'                                        ^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#GetType().
'                                                enclosing_range 39:36-39:48
                  Return Equals(CType(obj, TrueFalse))
'                        ^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().
'                               enclosing_range 40:23-40:52
'                                     ^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#Equals().(obj)
'                                         enclosing_range 40:30-40:51
'                                          ^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Operators#TrueFalse#
'                                                    enclosing_range 40:30-40:51
              End Function

              Public Overrides Function GetHashCode() As Integer
'                                       ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Operators#TrueFalse#GetHashCode().
'                                                   enclosing_range 43:12-43:62
'                                                   documentation ```vb\nPublic Overrides Function TrueFalse.GetHashCode() As Integer\n```
'                                                   relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#GetHashCode().
                  Throw New NotImplementedException()
'                           ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
'                                                   enclosing_range 44:22-44:51
              End Function

          End Class
      End Class
  End Namespace
