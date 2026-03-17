  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ read_access scip-dotnet nuget . . System/
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
//             ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ read_access scip-dotnet nuget . . Main/
//               enclosing_range 2:0-20:1

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
//                 enclosing_range 4:0-20:1
  public class Preprocessors
//             ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Preprocessors#
//                           enclosing_range 2:0-20:1
//                           documentation ```cs\nclass Preprocessors\n```
//                           kind Class
  {
      string OS()
//           ^^ definition scip-dotnet nuget . . Main/Preprocessors#OS().
//              enclosing_range 4:0-20:1
//              documentation ```cs\nprivate string Preprocessors.OS()\n```
//              kind Method
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
//                  kind Variable
//                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
  #endif
          return os;
//               ^^ read_access local 0
//                  enclosing_range 7:4-19:5
      }
  }
