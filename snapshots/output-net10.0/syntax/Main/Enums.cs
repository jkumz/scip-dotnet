  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ read_access scip-dotnet nuget . . System/
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
//             ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ read_access scip-dotnet nuget . . Main/
//               enclosing_range 2:0-18:1

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
//                 enclosing_range 4:0-18:1
  public class Enums
//             ^^^^^ definition scip-dotnet nuget . . Main/Enums#
//                   enclosing_range 2:0-18:1
//                   documentation ```cs\nclass Enums\n```
//                   kind Class
  {
      enum EnumWithIntValues
//         ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Enums#EnumWithIntValues#
//                           enclosing_range 4:0-18:1
//                           documentation ```cs\nenum EnumWithIntValues\n```
//                           kind Enum
//                           relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IComparable#
//                           relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IConvertible#
//                           relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/ISpanFormattable#
//                           relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IFormattable#
      {
          Ten = 10,
//        ^^^ definition scip-dotnet nuget . . Main/Enums#EnumWithIntValues#Ten.
//            enclosing_range 7:4-11:5
//            documentation ```cs\nEnumWithIntValues.Ten = 10\n```
//            kind Constant
//            relationship type_definition scip-dotnet nuget . . Main/Enums#EnumWithIntValues#
          Twenty = 20
//        ^^^^^^ definition scip-dotnet nuget . . Main/Enums#EnumWithIntValues#Twenty.
//               enclosing_range 7:4-11:5
//               documentation ```cs\nEnumWithIntValues.Twenty = 20\n```
//               kind Constant
//               relationship type_definition scip-dotnet nuget . . Main/Enums#EnumWithIntValues#
      }

      enum EnumWithByteValues
//         ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Enums#EnumWithByteValues#
//                            enclosing_range 4:0-18:1
//                            documentation ```cs\nenum EnumWithByteValues\n```
//                            kind Enum
//                            relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IComparable#
//                            relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IConvertible#
//                            relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/ISpanFormattable#
//                            relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IFormattable#
      {
          Five = 0x05,
//        ^^^^ definition scip-dotnet nuget . . Main/Enums#EnumWithByteValues#Five.
//             enclosing_range 13:4-17:5
//             documentation ```cs\nEnumWithByteValues.Five = 5\n```
//             kind Constant
//             relationship type_definition scip-dotnet nuget . . Main/Enums#EnumWithByteValues#
          Fifteen = 0x0F
//        ^^^^^^^ definition scip-dotnet nuget . . Main/Enums#EnumWithByteValues#Fifteen.
//                enclosing_range 13:4-17:5
//                documentation ```cs\nEnumWithByteValues.Fifteen = 15\n```
//                kind Constant
//                relationship type_definition scip-dotnet nuget . . Main/Enums#EnumWithByteValues#
      }
  }
