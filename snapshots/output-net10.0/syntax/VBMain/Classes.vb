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
      Public Class Classes
'                  ^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#
'                          enclosing_range 3:4-77:13
'                          documentation ```vb\nClass Classes\n```
'                          kind Class

          Public Name As String
'                ^^^^ definition scip-dotnet nuget . . VBMain/Classes#Name.
'                     enclosing_range 6:8-6:29
'                     documentation ```vb\nPublic Classes.Name As String\n```
'                     kind Field
'                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
          Public Const IntConstant As Integer = 1
'                      ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#IntConstant.
'                                  enclosing_range 7:8-7:47
'                                  documentation ```vb\nPublic Const Classes.IntConstant As Integer = 1\n```
'                                  kind Constant
'                                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          Public Const StringConstant As String = "hello"
'                      ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#StringConstant.
'                                     enclosing_range 8:8-8:55
'                                     documentation ```vb\nPublic Const Classes.StringConstant As String = "hello"\n```
'                                     kind Constant
'                                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#

          Public Sub New(ByVal name As Integer)
'                    ^^^ definition scip-dotnet nuget . . VBMain/Classes#`.ctor`().
'                        enclosing_range 10:8-12:15
'                        documentation ```vb\nPublic Sub Classes.New(name As Integer)\n```
'                        kind Constructor
'                              ^^^^ definition scip-dotnet nuget . . VBMain/Classes#`.ctor`().(name)
'                                   enclosing_range 10:8-10:45
'                                   documentation ```vb\nname As Integer\n```
'                                   kind Parameter
'                                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Me.Name = "name"
'                ^^^^ read_access scip-dotnet nuget . . VBMain/Classes#Name.
'                     enclosing_range 10:8-12:15
          End Sub

          Public Sub New(ByVal name As String)
'                    ^^^ definition scip-dotnet nuget . . VBMain/Classes#`.ctor`(+1).
'                        enclosing_range 14:8-16:15
'                        documentation ```vb\nPublic Sub Classes.New(name As String)\n```
'                        kind Constructor
'                              ^^^^ definition scip-dotnet nuget . . VBMain/Classes#`.ctor`(+1).(name)
'                                   enclosing_range 14:8-14:44
'                                   documentation ```vb\nname As String\n```
'                                   kind Parameter
'                                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
              Me.Name = name
'                ^^^^ read_access scip-dotnet nuget . . VBMain/Classes#Name.
'                     enclosing_range 14:8-16:15
'                       ^^^^ read_access scip-dotnet nuget . . VBMain/Classes#`.ctor`(+1).(name)
'                            enclosing_range 14:8-16:15
          End Sub

          Protected Overrides Sub Finalize()
'                                 ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#Finalize().
'                                          enclosing_range 18:8-20:15
'                                          documentation ```vb\nProtected Overrides Sub Classes.Finalize()\n```
'                                          kind Method
'                                          relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#Finalize().
              Console.WriteLine(42)
'             ^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#
'                     enclosing_range 18:8-20:15
'                     ^^^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+7).
'                               enclosing_range 18:8-20:15
          End Sub

          Public Class ObjectClass
'                      ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#ObjectClass#
'                                  enclosing_range 22:8-25:17
'                                  documentation ```vb\nClass ObjectClass\n```
'                                  kind Class
'                                  relationship implementation scip-dotnet nuget . . VBMain/Classes#SomeInterface#
              Inherits Object
              Implements SomeInterface
'                        ^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Classes#SomeInterface#
'                                      enclosing_range 24:12-24:36
          End Class

          Public Partial Class PartialClass
'                              ^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#PartialClass#
'                                           enclosing_range 27:8-28:17
'                                           documentation ```vb\nClass PartialClass\n```
'                                           kind Class
          End Class

          Class TypeParameterClass(Of T)
'               ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#TypeParameterClass#
'                                  enclosing_range 30:8-31:17
'                                  documentation ```vb\nClass TypeParameterClass(Of T)\n```
'                                  kind Class
'                                     ^ definition local 0
'                                       enclosing_range 30:8-30:38
'                                       documentation ```vb\nT\n```
'                                       kind TypeParameter
          End Class

          Friend Class InternalMultipleTypeParametersClass(Of T1, T2)
'                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#InternalMultipleTypeParametersClass#
'                                                          enclosing_range 33:8-34:17
'                                                          documentation ```vb\nClass InternalMultipleTypeParametersClass(Of T1, T2)\n```
'                                                          kind Class
'                                                             ^^ definition local 1
'                                                                enclosing_range 33:8-33:67
'                                                                documentation ```vb\nT1\n```
'                                                                kind TypeParameter
'                                                                 ^^ definition local 2
'                                                                    enclosing_range 33:8-33:67
'                                                                    documentation ```vb\nT2\n```
'                                                                    kind TypeParameter
          End Class

          Interface ICovariantContravariant(Of In T1, Out T2)
'                   ^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#ICovariantContravariant#
'                                           enclosing_range 36:8-41:21
'                                           documentation ```vb\nInterface ICovariantContravariant(Of In T1, Out T2)\n```
'                                           kind Interface
'                                                 ^^ definition local 3
'                                                    enclosing_range 36:8-36:59
'                                                    documentation ```vb\nIn T1\n```
'                                                    kind TypeParameter
'                                                         ^^ definition local 4
'                                                            enclosing_range 36:8-36:59
'                                                            documentation ```vb\nOut T2\n```
'                                                            kind TypeParameter
              Sub Method1(ByVal t1 As T1)
'                 ^^^^^^^ definition forward_definition scip-dotnet nuget . . VBMain/Classes#ICovariantContravariant#Method1().
'                         enclosing_range 36:8-41:21
'                         documentation ```vb\nSub ICovariantContravariant(Of In T1, Out T2).Method1(t1 As T1)\n```
'                         kind AbstractMethod
'                               ^^ definition scip-dotnet nuget . . VBMain/Classes#ICovariantContravariant#Method1().(t1)
'                                  enclosing_range 37:12-37:39
'                                  documentation ```vb\nt1 As T1\n```
'                                  kind Parameter
'                                  relationship type_definition local 3
'                                     ^^ read_access local 3
'                                        enclosing_range 37:12-37:39

              Function Method2() As T2
'                      ^^^^^^^ definition forward_definition scip-dotnet nuget . . VBMain/Classes#ICovariantContravariant#Method2().
'                              enclosing_range 36:8-41:21
'                              documentation ```vb\nFunction ICovariantContravariant(Of In T1, Out T2).Method2() As T2\n```
'                              kind AbstractMethod
'                                   ^^ read_access local 4
'                                      enclosing_range 39:12-39:36

          End Interface

          Public Class StructConstraintClass(Of T As Structure)
'                      ^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#StructConstraintClass#
'                                            enclosing_range 43:8-44:17
'                                            documentation ```vb\nClass StructConstraintClass(Of T As Structure)\n```
'                                            kind Class
'                                               ^ definition local 5
'                                                 enclosing_range 43:8-43:61
'                                                 documentation ```vb\nT\n```
'                                                 kind TypeParameter
          End Class

          Public Class ClassConstraintClass(Of T As Class)
'                      ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#ClassConstraintClass#
'                                           enclosing_range 46:8-47:17
'                                           documentation ```vb\nClass ClassConstraintClass(Of T As Class)\n```
'                                           kind Class
'                                              ^ definition local 6
'                                                enclosing_range 46:8-46:56
'                                                documentation ```vb\nT\n```
'                                                kind TypeParameter
          End Class

          Public Class NewConstraintClass(Of T As New)
'                      ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#NewConstraintClass#
'                                         enclosing_range 49:8-50:17
'                                         documentation ```vb\nClass NewConstraintClass(Of T As New)\n```
'                                         kind Class
'                                            ^ definition local 7
'                                              enclosing_range 49:8-49:52
'                                              documentation ```vb\nT\n```
'                                              kind TypeParameter
          End Class

          Public Class TypeParameterConstraintClass(Of T As SomeInterface)
'                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#TypeParameterConstraintClass#
'                                                   enclosing_range 52:8-53:17
'                                                   documentation ```vb\nClass TypeParameterConstraintClass(Of T As SomeInterface)\n```
'                                                   kind Class
'                                                      ^ definition local 8
'                                                        enclosing_range 52:8-52:72
'                                                        documentation ```vb\nT\n```
'                                                        kind TypeParameter
'                                                           ^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Classes#SomeInterface#
'                                                                         enclosing_range 52:8-52:72
          End Class

          Private Class MultipleTypeParameterConstraintsClass(Of T1 As {SomeInterface, SomeInterface2, New}, T2 As SomeInterface2)
'                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#MultipleTypeParameterConstraintsClass#
'                                                             enclosing_range 55:8-56:17
'                                                             documentation ```vb\nClass MultipleTypeParameterConstraintsClass(Of T1 As {SomeInterface, SomeInterface2, New}, T2 As SomeInterface2)\n```
'                                                             kind Class
'                                                                ^^ definition local 9
'                                                                   enclosing_range 55:8-55:128
'                                                                   documentation ```vb\nT1\n```
'                                                                   kind TypeParameter
'                                                                       ^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Classes#SomeInterface#
'                                                                                     enclosing_range 55:8-55:128
'                                                                                      ^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Classes#SomeInterface2#
'                                                                                                     enclosing_range 55:8-55:128
'                                                                                                            ^^ definition local 10
'                                                                                                               enclosing_range 55:8-55:128
'                                                                                                               documentation ```vb\nT2\n```
'                                                                                                               kind TypeParameter
'                                                                                                                  ^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Classes#SomeInterface2#
'                                                                                                                                 enclosing_range 55:8-55:128
          End Class

          Class IndexClass
'               ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#IndexClass#
'                          enclosing_range 58:8-69:17
'                          documentation ```vb\nClass IndexClass\n```
'                          kind Class
              Private a As Boolean
'                     ^ definition scip-dotnet nuget . . VBMain/Classes#IndexClass#a.
'                       enclosing_range 59:12-59:32
'                       documentation ```vb\nPrivate IndexClass.a As Boolean\n```
'                       kind Field
'                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#

              Default Public Property Item(ByVal index As Integer) As Boolean
'                                     ^^^^ definition scip-dotnet nuget . . VBMain/Classes#IndexClass#Item.
'                                          enclosing_range 61:12-68:24
'                                          documentation ```vb\nPublic Default Property IndexClass.Item(index As Integer) As Boolean\n```
'                                          kind Property
'                                          relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
'                                                ^^^^^ definition scip-dotnet nuget . . VBMain/Classes#IndexClass#Item.(index)
'                                                      enclosing_range 61:12-61:75
'                                                      documentation ```vb\nindex As Integer\n```
'                                                      kind Parameter
'                                                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
                  Get
                      Return a
'                            ^ read_access scip-dotnet nuget . . VBMain/Classes#IndexClass#a.
'                              enclosing_range 62:16-64:23
                  End Get
                  Set(ByVal value As Boolean)
'                           ^^^^^ definition scip-dotnet nuget . . VBMain/Classes#IndexClass#set_Item().(value)
'                                 enclosing_range 65:16-65:43
'                                 documentation ```vb\nvalue As Boolean\n```
'                                 kind Parameter
'                                 relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
                      a = value
'                     ^ write_access scip-dotnet nuget . . VBMain/Classes#IndexClass#a.
'                       enclosing_range 65:16-67:23
'                         ^^^^^ read_access scip-dotnet nuget . . VBMain/Classes#IndexClass#set_Item().(value)
'                               enclosing_range 65:16-67:23
                  End Set
              End Property
          End Class

          Interface SomeInterface
'                   ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#SomeInterface#
'                                 enclosing_range 71:8-72:21
'                                 documentation ```vb\nInterface SomeInterface\n```
'                                 kind Interface
          End Interface

          Friend Interface SomeInterface2
'                          ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Classes#SomeInterface2#
'                                         enclosing_range 74:8-75:21
'                                         documentation ```vb\nInterface SomeInterface2\n```
'                                         kind Interface
          End Interface

      End Class

  End Namespace
