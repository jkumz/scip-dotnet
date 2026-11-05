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
      <AttributeUsage(AttributeTargets.[Class], AllowMultiple:=True, Inherited:=True)>
'      ^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeUsageAttribute#`.ctor`().
'                     enclosing_range 4:5-4:19
'                     ^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeTargets#
'                                      enclosing_range 4:20-4:44
'                                      ^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeTargets#Class.
'                                              enclosing_range 4:20-4:44
'                                               ^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeUsageAttribute#AllowMultiple.
'                                                             enclosing_range 4:46-4:59
'                                                                    ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeUsageAttribute#Inherited.
'                                                                              enclosing_range 4:67-4:76
      Public Class GlobalAttributes
'                  ^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#
'                                   enclosing_range 3:4-5:33
'                                   documentation ```vb\nClass GlobalAttributes\n```
'                                   relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#
          Inherits Attribute
'                  ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#
'                            enclosing_range 6:17-6:26

          Class AuthorAttribute
'               ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#AuthorAttribute#
'                               enclosing_range 8:8-8:29
'                               documentation ```vb\nClass AuthorAttribute\n```
'                               relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#
              Inherits Attribute
'                      ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#
'                                enclosing_range 9:21-9:30

              Public Sub New(ByVal name As String)
'                        ^^^ definition scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
'                            enclosing_range 11:12-11:48
'                            documentation ```vb\nPublic Sub AuthorAttribute.New(name As String)\n```
'                                  ^^^^ definition scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().(name)
'                                       enclosing_range 11:12-11:48
'                                       documentation ```vb\nname As String\n```
'                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
              End Sub
          End Class

          <Author("PropertyAttribute")>
'          ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
'                 enclosing_range 15:9-15:15
          Public Z As Integer
'                ^ definition scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#Z.
'                  enclosing_range 15:8-16:27
'                  documentation ```vb\nPublic GlobalAttributes.Z As Integer\n```
'                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#

          <Author("MethodAttribute")>
'          ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
'                 enclosing_range 18:9-18:15
          Private Function Method1() As Integer
'                          ^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#Method1().
'                                  enclosing_range 18:8-19:45
'                                  documentation ```vb\nPrivate Function GlobalAttributes.Method1() As Integer\n```
              Return 0
          End Function

          <Author("EnumAttribute")>
'          ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
'                 enclosing_range 23:9-23:15
          Enum A
'              ^ definition scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#A#
'                enclosing_range 23:8-24:14
'                documentation ```vb\nEnum A\n```
'                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IComparable#
'                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IConvertible#
'                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/ISpanFormattable#
'                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IFormattable#
              B
'             ^ definition scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#A#B.
'               enclosing_range 25:12-25:13
'               documentation ```vb\nA.B = 0\n```
'               relationship type_definition scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#A#
              C
'             ^ definition scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#A#C.
'               enclosing_range 26:12-26:13
'               documentation ```vb\nA.C = 1\n```
'               relationship type_definition scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#A#
          End Enum

          <Author("EventAttribute")>
'          ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
'                 enclosing_range 29:9-29:15
          Public Event SomeEvent As EventHandler
'                      ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#SomeEvent#
'                                enclosing_range 29:8-30:46
'                                documentation ```vb\nPublic Event GlobalAttributes.SomeEvent As EventHandler\n```
'                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                   ^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                                enclosing_range 30:34-30:46

          <Author("TypeParameterAttribute")>
'          ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#AuthorAttribute#`.ctor`().
'                 enclosing_range 32:9-32:15
          Public Class InnerClass(Of T)
'                      ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#InnerClass#
'                                 enclosing_range 32:8-33:37
'                                 documentation ```vb\nClass InnerClass(Of T)\n```
'                                    ^ definition local 0
'                                      enclosing_range 32:8-33:37
'                                      documentation ```vb\nT\n```
              Private Sub Method(Of T2)()
'                         ^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/GlobalAttributes#InnerClass#Method().
'                                enclosing_range 34:12-34:39
'                                documentation ```vb\nPrivate Sub InnerClass(Of T).Method(Of T2)()\n```
'                                   ^^ definition local 1
'                                      enclosing_range 34:12-34:39
'                                      documentation ```vb\nT2\n```
              End Sub
          End Class
      End Class
  End Namespace
