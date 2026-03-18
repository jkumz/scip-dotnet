  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ read_access scip-dotnet nuget . . System/
//             enclosing_range 0:6-0:24
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
//                                      enclosing_range 0:6-0:37
//             ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
//                         enclosing_range 0:6-0:24
//                         ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/
//                                      enclosing_range 0:6-0:37
  using DiffPlex.DiffBuilder;
//      ^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffPlex/
//               enclosing_range 1:6-1:26
//      ^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget DiffPlex 1.7.1.0 DiffBuilder/
//                           enclosing_range 1:6-1:26
//               ^^^^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffBuilder/
//                           enclosing_range 1:6-1:26
  using DiffPlex.DiffBuilder.Model;
//      ^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffPlex/
//               enclosing_range 2:6-2:26
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget DiffPlex 1.7.1.0 Model/
//                                 enclosing_range 2:6-2:32
//               ^^^^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffBuilder/
//                           enclosing_range 2:6-2:26
//                           ^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 Model/
//                                 enclosing_range 2:6-2:32

  namespace Main;
//          ^^^^ read_access scip-dotnet nuget . . Main/
//               enclosing_range 4:10-4:14

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
//                 enclosing_range 6:1-6:16
  public class Packages
//             ^^^^^^^^ definition scip-dotnet nuget . . Main/Packages#
//                      enclosing_range 6:0-13:1
//                      documentation ```cs\nclass Packages\n```
//                      kind Class
  {
      DiffPaneModel Diff()
//    ^^^^^^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 Model/DiffPaneModel#
//                  enclosing_range 9:4-9:17
//                  ^^^^ definition scip-dotnet nuget . . Main/Packages#Diff().
//                       enclosing_range 9:4-12:5
//                       documentation ```cs\nprivate DiffPaneModel Packages.Diff()\n```
//                       kind Method
      {
          return InlineDiffBuilder.Diff("a", "b");
//               ^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffBuilder/InlineDiffBuilder#
//                                 enclosing_range 11:15-11:47
//                                 ^^^^ read_access scip-dotnet nuget DiffPlex 1.7.1.0 DiffBuilder/InlineDiffBuilder#Diff().
//                                      enclosing_range 11:15-11:47
      }
  }
