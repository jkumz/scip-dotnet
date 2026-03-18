  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ read_access scip-dotnet nuget . . System/
//             enclosing_range 0:6-0:24
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
//                                      enclosing_range 0:6-0:37
//             ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
//                         enclosing_range 0:6-0:24
//                         ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/
//                                      enclosing_range 0:6-0:37

  namespace Main;
//          ^^^^ read_access scip-dotnet nuget . . Main/
//               enclosing_range 2:10-2:14

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
//                 enclosing_range 4:1-4:16
  public class Structs
//             ^^^^^^^ definition scip-dotnet nuget . . Main/Structs#
//                     enclosing_range 4:0-16:1
//                     documentation ```cs\nclass Structs\n```
//                     kind Class
  {
      struct BasicStruct
//           ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Structs#BasicStruct#
//                       enclosing_range 7:4-15:5
//                       documentation ```cs\nstruct BasicStruct\n```
//                       kind Struct
      {
          public int Property1;
//                   ^^^^^^^^^ definition scip-dotnet nuget . . Main/Structs#BasicStruct#Property1.
//                             enclosing_range 9:8-9:29
//                             documentation ```cs\npublic int BasicStruct.Property1\n```
//                             kind Field
//                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#

          public BasicStruct(int field1)
//               ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Structs#BasicStruct#`.ctor`().
//                           enclosing_range 11:8-14:9
//                           documentation ```cs\npublic BasicStruct.BasicStruct(int field1)\n```
//                           kind Constructor
//                               ^^^^^^ definition scip-dotnet nuget . . Main/Structs#BasicStruct#`.ctor`().(field1)
//                                      enclosing_range 11:8-14:9
//                                      documentation ```cs\nint field1\n```
//                                      kind Parameter
//                                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          {
              Property1 = field1;
//            ^^^^^^^^^ write_access scip-dotnet nuget . . Main/Structs#BasicStruct#Property1.
//                      enclosing_range 13:12-13:30
//                        ^^^^^^ read_access scip-dotnet nuget . . Main/Structs#BasicStruct#`.ctor`().(field1)
//                               enclosing_range 13:12-13:30
          }
      }
  }
