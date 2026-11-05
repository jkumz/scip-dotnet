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
      Public Class Enums
'                  ^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Enums#
'                        enclosing_range 3:4-4:22
'                        documentation ```vb\nClass Enums\n```
          Enum EnumWithIntValues
'              ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Enums#EnumWithIntValues#
'                                enclosing_range 5:8-5:30
'                                documentation ```vb\nEnum EnumWithIntValues\n```
'                                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IComparable#
'                                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IConvertible#
'                                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/ISpanFormattable#
'                                relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IFormattable#
              Ten = 10
'             ^^^ definition scip-dotnet nuget . . VBMain/VBMain/Enums#EnumWithIntValues#Ten.
'                 enclosing_range 6:12-6:20
'                 documentation ```vb\nEnumWithIntValues.Ten = 10\n```
'                 relationship type_definition scip-dotnet nuget . . VBMain/VBMain/Enums#EnumWithIntValues#
              Twenty = 20
'             ^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Enums#EnumWithIntValues#Twenty.
'                    enclosing_range 7:12-7:23
'                    documentation ```vb\nEnumWithIntValues.Twenty = 20\n```
'                    relationship type_definition scip-dotnet nuget . . VBMain/VBMain/Enums#EnumWithIntValues#
          End Enum

          Enum EnumWithByteValues
'              ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Enums#EnumWithByteValues#
'                                 enclosing_range 10:8-10:31
'                                 documentation ```vb\nEnum EnumWithByteValues\n```
'                                 relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IComparable#
'                                 relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IConvertible#
'                                 relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/ISpanFormattable#
'                                 relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IFormattable#
              Five = &H5
'             ^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Enums#EnumWithByteValues#Five.
'                  enclosing_range 11:12-11:22
'                  documentation ```vb\nEnumWithByteValues.Five = 5\n```
'                  relationship type_definition scip-dotnet nuget . . VBMain/VBMain/Enums#EnumWithByteValues#
              Fifteen = &HF
'             ^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Enums#EnumWithByteValues#Fifteen.
'                     enclosing_range 12:12-12:25
'                     documentation ```vb\nEnumWithByteValues.Fifteen = 15\n```
'                     relationship type_definition scip-dotnet nuget . . VBMain/VBMain/Enums#EnumWithByteValues#
          End Enum
      End Class
  End Namespace
