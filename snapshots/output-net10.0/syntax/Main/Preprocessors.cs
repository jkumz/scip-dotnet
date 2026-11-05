  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             enclosing_range 0:6-0:24
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/
//                                      enclosing_range 0:6-0:37
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
//                         enclosing_range 0:6-0:24
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/
//                                      enclosing_range 0:6-0:37

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/
//               enclosing_range 2:10-2:14

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
//                 enclosing_range 4:1-4:16
  public class Preprocessors
//             ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Preprocessors#
//                           enclosing_range 4:0-20:1
//                           documentation ```cs\nclass Preprocessors\n```
  {
      string OS()
//           ^^ definition scip-dotnet nuget . . Main/Preprocessors#OS().
//              enclosing_range 7:4-19:5
//              documentation ```cs\nprivate string Preprocessors.OS()\n```
      {
  #if WIN32
          string os = "Win32";
  #warning This class is bad.
  #error Okay, just stop.
  #elif MACOS
          string os = "MacOS";
  #else
          string os = "Unknown";
//               ^^ definition local 0
//                  enclosing_range 7:4-19:5
//                  documentation ```cs\nstring os\n```
//                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
  #endif
          return os;
//               ^^ reference local 0
//                  enclosing_range 18:15-18:17
      }
  }
