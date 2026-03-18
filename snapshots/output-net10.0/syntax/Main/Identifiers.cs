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
  #pragma warning disable CS0219
  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
//                 enclosing_range 4:1-4:16
  public class Identifiers
//             ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Identifiers#
//                         enclosing_range 4:0-19:1
//                         documentation ```cs\nclass Identifiers\n```
//                         kind Class
  {
      void SpecialNames()
//         ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Identifiers#SpecialNames().
//                      enclosing_range 7:4-18:5
//                      documentation ```cs\nprivate void Identifiers.SpecialNames()\n```
//                      kind Method
      {
          var @const = 42;
//            ^^^^^^ definition local 0
//                   enclosing_range 7:4-18:5
//                   documentation ```cs\nint @const\n```
//                   kind Variable
//                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          int @var = @const;
//            ^^^^ definition local 1
//                 enclosing_range 7:4-18:5
//                 documentation ```cs\nint var\n```
//                 kind Variable
//                 relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                   ^^^^^^ read_access local 0
//                          enclosing_range 10:19-10:25
          var under_score = 0;
//            ^^^^^^^^^^^ definition local 2
//                        enclosing_range 7:4-18:5
//                        documentation ```cs\nint under_score\n```
//                        kind Variable
//                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          var with1number = 0;
//            ^^^^^^^^^^^ definition local 3
//                        enclosing_range 7:4-18:5
//                        documentation ```cs\nint with1number\n```
//                        kind Variable
//                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          var varæble = 0;
//            ^^^^^^^ definition local 4
//                    enclosing_range 7:4-18:5
//                    documentation ```cs\nint varæble\n```
//                    kind Variable
//                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          var Переменная = 0;
//            ^^^^^^^^^^ definition local 5
//                       enclosing_range 7:4-18:5
//                       documentation ```cs\nint Переменная\n```
//                       kind Variable
//                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          var first‿letter = 0;
//            ^^^^^^^^^^^^ definition local 6
//                         enclosing_range 7:4-18:5
//                         documentation ```cs\nint first‿letter\n```
//                         kind Variable
//                         relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          var ග්‍රහලෝකය = 0;
//            ^^^^^^^^^ definition local 7
//                      enclosing_range 7:4-18:5
//                      documentation ```cs\nint ග්රහලෝකය\n```
//                      kind Variable
//                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          var _كوكبxxx = 0;
//            ^^^^^^^^ definition local 8
//                     enclosing_range 7:4-18:5
//                     documentation ```cs\nint _كوكبxxx\n```
//                     kind Variable
//                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      }
  }
  #pragma warning restore CS0219
