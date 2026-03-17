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
  public class Properties
//             ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Properties#
//                        enclosing_range 2:0-18:1
//                        documentation ```cs\nclass Properties\n```
//                        kind Class
  {
      byte Get { get; }
//         ^^^ definition scip-dotnet nuget . . Main/Properties#Get.
//             enclosing_range 4:0-18:1
//             documentation ```cs\nprivate byte Properties.Get { get; }\n```
//             kind Property
//             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Byte#

      char Set
//         ^^^ definition scip-dotnet nuget . . Main/Properties#Set.
//             enclosing_range 4:0-18:1
//             documentation ```cs\nprivate char Properties.Set { set; }\n```
//             kind Property
//             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Char#
      {
          set { throw new NotImplementedException(); }
//                        ^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
//                                                enclosing_range 9:4-12:5
      }

      uint GetSet { get; set; }
//         ^^^^^^ definition scip-dotnet nuget . . Main/Properties#GetSet.
//                enclosing_range 4:0-18:1
//                documentation ```cs\nprivate uint Properties.GetSet { get; set; }\n```
//                kind Property
//                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/UInt32#
      long SetGet { set; get; }
//         ^^^^^^ definition scip-dotnet nuget . . Main/Properties#SetGet.
//                enclosing_range 4:0-18:1
//                documentation ```cs\nprivate long Properties.SetGet { get; set; }\n```
//                kind Property
//                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#

      string? Init { get; init; }
//            ^^^^ definition scip-dotnet nuget . . Main/Properties#Init.
//                 enclosing_range 4:0-18:1
//                 documentation ```cs\nprivate string? Properties.Init { get; init; }\n```
//                 kind Property
//                 relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
  }
