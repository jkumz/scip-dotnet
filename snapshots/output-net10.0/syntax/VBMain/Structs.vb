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
      Public Class Structs
'                  ^^^^^^^ definition scip-dotnet nuget . . VBMain/Structs#
'                          enclosing_range 3:4-12:13
'                          documentation ```vb\nClass Structs\n```
'                          kind Class
          Structure BasicStruct
'                   ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Structs#BasicStruct#
'                               enclosing_range 5:8-11:21
'                               documentation ```vb\nStructure BasicStruct\n```
'                               kind Struct
              Public Property1 As Integer
'                    ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Structs#BasicStruct#Property1.
'                              enclosing_range 6:12-6:39
'                              documentation ```vb\nPublic BasicStruct.Property1 As Integer\n```
'                              kind Field
'                              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#

              Public Sub New(ByVal field1 As Integer)
'                        ^^^ definition scip-dotnet nuget . . VBMain/Structs#BasicStruct#`.ctor`(+1).
'                            enclosing_range 8:12-10:19
'                            documentation ```vb\nPublic Sub BasicStruct.New(field1 As Integer)\n```
'                            kind Constructor
'                                  ^^^^^^ definition scip-dotnet nuget . . VBMain/Structs#BasicStruct#`.ctor`(+1).(field1)
'                                         enclosing_range 8:12-8:51
'                                         documentation ```vb\nfield1 As Integer\n```
'                                         kind Parameter
'                                         relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
                  Property1 = field1
'                 ^^^^^^^^^ write_access scip-dotnet nuget . . VBMain/Structs#BasicStruct#Property1.
'                           enclosing_range 8:12-10:19
'                             ^^^^^^ read_access scip-dotnet nuget . . VBMain/Structs#BasicStruct#`.ctor`(+1).(field1)
'                                    enclosing_range 8:12-10:19
              End Sub
          End Structure
      End Class
  End Namespace
