  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ read_access scip-dotnet nuget . . System/
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
//             ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ read_access scip-dotnet nuget . . Main/
//               enclosing_range 2:0-15:1

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
//                 enclosing_range 4:0-15:1
  public class Literals
//             ^^^^^^^^ definition scip-dotnet nuget . . Main/Literals#
//                      enclosing_range 2:0-15:1
//                      documentation ```cs\nclass Literals\n```
//                      kind Class
  {
      string Interpolation()
//           ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Literals#Interpolation().
//                         enclosing_range 4:0-15:1
//                         documentation ```cs\nprivate string Literals.Interpolation()\n```
//                         kind Method
      {
          var a = 1;
//            ^ definition local 0
//              enclosing_range 7:4-14:5
//              documentation ```cs\nint a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          var b = 2;
//            ^ definition local 1
//              enclosing_range 7:4-14:5
//              documentation ```cs\nint b\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          var c = 3;
//            ^ definition local 2
//              enclosing_range 7:4-14:5
//              documentation ```cs\nint c\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          var d = 3;
//            ^ definition local 3
//              enclosing_range 7:4-14:5
//              documentation ```cs\nint d\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          return $"a={a} b={b:0.00} c={c,24} d={d:g}";
//                    ^ read_access local 0
//                      enclosing_range 7:4-14:5
//                          ^ read_access local 1
//                            enclosing_range 7:4-14:5
//                                     ^ read_access local 2
//                                       enclosing_range 7:4-14:5
//                                              ^ read_access local 3
//                                                enclosing_range 7:4-14:5
      }
  }
