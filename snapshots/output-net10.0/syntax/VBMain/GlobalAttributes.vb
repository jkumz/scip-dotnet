  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ read_access scip-dotnet nuget . . System/
'                enclosing_range 0:8-0:26
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39
'                ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
'                            enclosing_range 0:8-0:26
'                            ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39

  Namespace VBMain
'           ^^^^^^ read_access scip-dotnet nuget . . VBMain/
'                  enclosing_range 2:10-2:16
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
'                      enclosing_range 3:5-3:20
      <AttributeUsage(AttributeTargets.[Class], AllowMultiple:=True, Inherited:=True)>
'      ^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeUsageAttribute#`.ctor`().
'                     enclosing_range 4:5-4:19
'                     ^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeTargets#
'                                      enclosing_range 4:20-4:44
'                                      ^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeTargets#Class.
'                                              enclosing_range 4:20-4:44
'                                               ^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeUsageAttribute#AllowMultiple.
'                                                             enclosing_range 4:46-4:59
'                                                                    ^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeUsageAttribute#Inherited.
'                                                                              enclosing_range 4:67-4:76
      Public Class GlobalAttributes
'                  ^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#
'                                   enclosing_range 3:4-5:33
'                                   documentation ```vb\nClass GlobalAttributes\n```
'                                   kind Class
'                                   relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#
          Inherits Attribute
'                  ^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#
'                            enclosing_range 6:17-6:26

          Class AuthorAttribute
'               ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#
'                               enclosing_range 8:8-8:29
'                               documentation ```vb\nClass AuthorAttribute\n```
'                               kind Class
'                               relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#
              Inherits Attribute
'                      ^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#
'                                enclosing_range 9:21-9:30

              Public Sub New(ByVal name As String)
'                        ^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
'                            enclosing_range 11:12-11:48
'                            documentation ```vb\nPublic Sub AuthorAttribute.New(name As String)\n```
'                            kind Constructor
'                                  ^^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().(name)
'                                       enclosing_range 11:12-11:48
'                                       documentation ```vb\nname As String\n```
'                                       kind Parameter
'                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
              End Sub
          End Class

          <Author("PropertyAttribute")>
'          ^^^^^^ read_access scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
'                 enclosing_range 15:9-15:15
          Public Z As Integer
'                ^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#Z.
'                  enclosing_range 15:8-16:27
'                  documentation ```vb\nPublic GlobalAttributes.Z As Integer\n```
'                  kind Field
'                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#

          <Author("MethodAttribute")>
'          ^^^^^^ read_access scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
'                 enclosing_range 18:9-18:15
          Private Function Method1() As Integer
'                          ^^^^^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#Method1().
'                                  enclosing_range 18:8-19:45
'                                  documentation ```vb\nPrivate Function GlobalAttributes.Method1() As Integer\n```
'                                  kind Method
              Return 0
          End Function

          <Author("EnumAttribute")>
'          ^^^^^^ read_access scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
'                 enclosing_range 23:9-23:15
          Enum A
'              ^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#A#
'                enclosing_range 23:8-24:14
'                documentation ```vb\nEnum A\n```
'                kind Enum
'                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IComparable#
'                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IConvertible#
'                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/ISpanFormattable#
'                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IFormattable#
              B
'             ^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#A#B.
'               enclosing_range 25:12-25:13
'               documentation ```vb\nA.B = 0\n```
'               kind Constant
'               relationship type_definition scip-dotnet nuget . . VBMain/GlobalAttributes#A#
              C
'             ^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#A#C.
'               enclosing_range 26:12-26:13
'               documentation ```vb\nA.C = 1\n```
'               kind Constant
'               relationship type_definition scip-dotnet nuget . . VBMain/GlobalAttributes#A#
          End Enum

          <Author("EventAttribute")>
'          ^^^^^^ read_access scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
'                 enclosing_range 29:9-29:15
          Public Event SomeEvent As EventHandler
'                      ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#SomeEvent#
'                                enclosing_range 29:8-30:46
'                                documentation ```vb\nPublic Event GlobalAttributes.SomeEvent As EventHandler\n```
'                                kind Event
'                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                   ^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                                enclosing_range 30:34-30:46

          <Author("TypeParameterAttribute")>
'          ^^^^^^ read_access scip-dotnet nuget . . VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
'                 enclosing_range 32:9-32:15
          Public Class InnerClass(Of T)
'                      ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#InnerClass#
'                                 enclosing_range 32:8-33:37
'                                 documentation ```vb\nClass InnerClass(Of T)\n```
'                                 kind Class
'                                    ^ definition local 0
'                                      enclosing_range 32:8-33:37
'                                      documentation ```vb\nT\n```
'                                      kind TypeParameter
              Private Sub Method(Of T2)()
'                         ^^^^^^ definition scip-dotnet nuget . . VBMain/GlobalAttributes#InnerClass#Method().
'                                enclosing_range 34:12-34:39
'                                documentation ```vb\nPrivate Sub InnerClass(Of T).Method(Of T2)()\n```
'                                kind Method
'                                   ^^ definition local 1
'                                      enclosing_range 34:12-34:39
'                                      documentation ```vb\nT2\n```
'                                      kind TypeParameter
              End Sub
          End Class
      End Class
  End Namespace
