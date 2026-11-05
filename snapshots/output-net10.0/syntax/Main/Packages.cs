  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             enclosing_range 0:6-0:24
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . System/Diagnostics/CodeAnalysis/
//                                      enclosing_range 0:6-0:37
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . System/Diagnostics/
//                         enclosing_range 0:6-0:24
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . System/Diagnostics/CodeAnalysis/
//                                      enclosing_range 0:6-0:37
  using DiffPlex.DiffBuilder;
//      ^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffPlex/
//               enclosing_range 1:6-1:26
//      ^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffPlex/DiffBuilder/
//                           enclosing_range 1:6-1:26
//               ^^^^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffPlex/DiffBuilder/
//                           enclosing_range 1:6-1:26
  using DiffPlex.DiffBuilder.Model;
//      ^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffPlex/
//               enclosing_range 2:6-2:26
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffPlex/DiffBuilder/Model/
//                                 enclosing_range 2:6-2:32
//               ^^^^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffPlex/DiffBuilder/
//                           enclosing_range 2:6-2:26
//                           ^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffPlex/DiffBuilder/Model/
//                                 enclosing_range 2:6-2:32

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/
//               enclosing_range 4:10-4:14

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Diagnostics/CodeAnalysis/SuppressMessageAttribute#`.ctor`().
//                 enclosing_range 6:1-6:16
  public class Packages
//             ^^^^^^^^ definition scip-dotnet nuget . . Main/Packages#
//                      enclosing_range 6:0-13:1
//                      documentation ```cs\nclass Packages\n```
  {
      DiffPaneModel Diff()
//    ^^^^^^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffPlex/DiffBuilder/Model/DiffPaneModel#
//                  enclosing_range 9:4-9:17
//                  ^^^^ definition scip-dotnet nuget . . Main/Packages#Diff().
//                       enclosing_range 9:4-12:5
//                       documentation ```cs\nprivate DiffPaneModel Packages.Diff()\n```
      {
          return InlineDiffBuilder.Diff("a", "b");
//               ^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffPlex/DiffBuilder/InlineDiffBuilder#
//                                 enclosing_range 11:15-11:47
//                                 ^^^^ reference scip-dotnet nuget DiffPlex 1.9.0.0 DiffPlex/DiffBuilder/InlineDiffBuilder#Diff().
//                                      enclosing_range 11:15-11:47
      }
  }
