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
      Public Class Fields
'                  ^^^^^^ definition scip-dotnet nuget . . VBMain/Fields#
'                         enclosing_range 3:4-4:23
'                         documentation ```vb\nClass Fields\n```
'                         kind Class
          Class Fields1
'               ^^^^^^^ definition scip-dotnet nuget . . VBMain/Fields#Fields1#
'                       enclosing_range 5:8-5:21
'                       documentation ```vb\nClass Fields1\n```
'                       kind Class
              Private ReadOnly Property1 As Integer
'                              ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Fields#Fields1#Property1.
'                                        enclosing_range 6:12-6:49
'                                        documentation ```vb\nPrivate ReadOnly Fields1.Property1 As Integer\n```
'                                        kind Field
'                                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              Private Property2, Property3 As Int64
'                     ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Fields#Fields1#Property2.
'                               enclosing_range 7:12-7:49
'                               documentation ```vb\nPrivate Fields1.Property2 As Long\n```
'                               kind Field
'                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#
'                                ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Fields#Fields1#Property3.
'                                          enclosing_range 7:12-7:49
'                                          documentation ```vb\nPrivate Fields1.Property3 As Long\n```
'                                          kind Field
'                                          relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#
'                                             ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#
'                                                   enclosing_range 7:44-7:49
              Private Property4 As Tuple(Of Char, Nullable(Of Integer))
'                     ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Fields#Fields1#Property4.
'                               enclosing_range 8:12-8:69
'                               documentation ```vb\nPrivate Fields1.Property4 As Tuple(Of Char, Integer?)\n```
'                               kind Field
'                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Tuple#

              Public Sub New(ByVal field2 As Long, ByVal field3 As Long, ByVal field4 As Tuple(Of Char, Integer?), ByVal field1 As Integer)
'                        ^^^ definition scip-dotnet nuget . . VBMain/Fields#Fields1#`.ctor`().
'                            enclosing_range 10:12-10:137
'                            documentation ```vb\nPublic Sub Fields1.New(field2 As Long, field3 As Long, field4 As Tuple(Of Char, Integer?), field1 As Integer)\n```
'                            kind Constructor
'                                  ^^^^^^ definition scip-dotnet nuget . . VBMain/Fields#Fields1#`.ctor`().(field2)
'                                         enclosing_range 10:12-10:137
'                                         documentation ```vb\nfield2 As Long\n```
'                                         kind Parameter
'                                         relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#
'                                                        ^^^^^^ definition scip-dotnet nuget . . VBMain/Fields#Fields1#`.ctor`().(field3)
'                                                               enclosing_range 10:12-10:137
'                                                               documentation ```vb\nfield3 As Long\n```
'                                                               kind Parameter
'                                                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#
'                                                                              ^^^^^^ definition scip-dotnet nuget . . VBMain/Fields#Fields1#`.ctor`().(field4)
'                                                                                     enclosing_range 10:12-10:137
'                                                                                     documentation ```vb\nfield4 As Tuple(Of Char, Integer?)\n```
'                                                                                     kind Parameter
'                                                                                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Tuple#
'                                                                                                                        ^^^^^^ definition scip-dotnet nuget . . VBMain/Fields#Fields1#`.ctor`().(field1)
'                                                                                                                               enclosing_range 10:12-10:137
'                                                                                                                               documentation ```vb\nfield1 As Integer\n```
'                                                                                                                               kind Parameter
'                                                                                                                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
                  Property2 = field2
'                 ^^^^^^^^^ write_access scip-dotnet nuget . . VBMain/Fields#Fields1#Property2.
'                           enclosing_range 11:16-11:25
'                             ^^^^^^ read_access scip-dotnet nuget . . VBMain/Fields#Fields1#`.ctor`().(field2)
'                                    enclosing_range 11:28-11:34
                  Property3 = field3
'                 ^^^^^^^^^ write_access scip-dotnet nuget . . VBMain/Fields#Fields1#Property3.
'                           enclosing_range 12:16-12:25
'                             ^^^^^^ read_access scip-dotnet nuget . . VBMain/Fields#Fields1#`.ctor`().(field3)
'                                    enclosing_range 12:28-12:34
                  Property4 = field4
'                 ^^^^^^^^^ write_access scip-dotnet nuget . . VBMain/Fields#Fields1#Property4.
'                           enclosing_range 13:16-13:25
'                             ^^^^^^ read_access scip-dotnet nuget . . VBMain/Fields#Fields1#`.ctor`().(field4)
'                                    enclosing_range 13:28-13:34
                  Property1 = field1
'                 ^^^^^^^^^ write_access scip-dotnet nuget . . VBMain/Fields#Fields1#Property1.
'                           enclosing_range 14:16-14:25
'                             ^^^^^^ read_access scip-dotnet nuget . . VBMain/Fields#Fields1#`.ctor`().(field1)
'                                    enclosing_range 14:28-14:34
              End Sub
          End Class
      End Class
  End Namespace
