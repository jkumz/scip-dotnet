  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/
//               enclosing_range 0:10-0:14

  public class ChainedExpressions
//             ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/ChainedExpressions#
//                                enclosing_range 2:0-34:1
//                                documentation ```cs\nclass ChainedExpressions\n```
  {
      public int Value { get; set; }
//               ^^^^^ definition scip-dotnet nuget . . Main/ChainedExpressions#Value.
//                     enclosing_range 4:4-4:34
//                     documentation ```cs\npublic int ChainedExpressions.Value { get; set; }\n```
//                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      public ChainedExpressions Next { get; set; } = null!;
//           ^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/ChainedExpressions#
//                              enclosing_range 5:11-5:29
//                              ^^^^ definition scip-dotnet nuget . . Main/ChainedExpressions#Next.
//                                   enclosing_range 5:4-5:57
//                                   documentation ```cs\npublic ChainedExpressions ChainedExpressions.Next { get; set; }\n```
//                                   relationship type_definition scip-dotnet nuget . . Main/ChainedExpressions#

      public ChainedExpressions Method(int x) => this;
//           ^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/ChainedExpressions#
//                              enclosing_range 7:11-7:29
//                              ^^^^^^ definition scip-dotnet nuget . . Main/ChainedExpressions#Method().
//                                     enclosing_range 7:4-7:52
//                                     documentation ```cs\npublic ChainedExpressions ChainedExpressions.Method(int x)\n```
//                                         ^ definition scip-dotnet nuget . . Main/ChainedExpressions#Method().(x)
//                                           enclosing_range 7:4-7:52
//                                           documentation ```cs\nint x\n```
//                                           relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#

      public void TestChains()
//                ^^^^^^^^^^ definition scip-dotnet nuget . . Main/ChainedExpressions#TestChains().
//                           enclosing_range 9:4-33:5
//                           documentation ```cs\npublic void ChainedExpressions.TestChains()\n```
      {
          var obj = new ChainedExpressions();
//            ^^^ definition local 0
//                enclosing_range 9:4-33:5
//                documentation ```cs\nChainedExpressions? obj\n```
//                relationship type_definition scip-dotnet nuget . . Main/ChainedExpressions#
//                      ^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/ChainedExpressions#
//                                         enclosing_range 11:18-11:42

          // Simple member access: a.b
          var v1 = obj.Value;
//            ^^ definition local 1
//               enclosing_range 9:4-33:5
//               documentation ```cs\nint v1\n```
//               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                 ^^^ reference local 0
//                     enclosing_range 14:17-14:26
//                     ^^^^^ reference scip-dotnet nuget . . Main/ChainedExpressions#Value.
//                           enclosing_range 14:17-14:26

          // Chained member access: a.b.c
          var v2 = obj.Next.Value;
//            ^^ definition local 2
//               enclosing_range 9:4-33:5
//               documentation ```cs\nint v2\n```
//               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                 ^^^ reference local 0
//                     enclosing_range 17:17-17:25
//                     ^^^^ reference scip-dotnet nuget . . Main/ChainedExpressions#Next.
//                          enclosing_range 17:17-17:25
//                          ^^^^^ reference scip-dotnet nuget . . Main/ChainedExpressions#Value.
//                                enclosing_range 17:17-17:31

          // Member access + invocation: a.b(41)
          var v3 = obj.Method(41);
//            ^^ definition local 3
//               enclosing_range 9:4-33:5
//               documentation ```cs\nChainedExpressions? v3\n```
//               relationship type_definition scip-dotnet nuget . . Main/ChainedExpressions#
//                 ^^^ reference local 0
//                     enclosing_range 20:17-20:31
//                     ^^^^^^ reference scip-dotnet nuget . . Main/ChainedExpressions#Method().
//                            enclosing_range 20:17-20:31

          // Complex chain: a.b(41).c(42).d(43)
          var v4 = obj.Method(41).Method(42).Method(43);
//            ^^ definition local 4
//               enclosing_range 9:4-33:5
//               documentation ```cs\nChainedExpressions? v4\n```
//               relationship type_definition scip-dotnet nuget . . Main/ChainedExpressions#
//                 ^^^ reference local 0
//                     enclosing_range 23:17-23:31
//                     ^^^^^^ reference scip-dotnet nuget . . Main/ChainedExpressions#Method().
//                            enclosing_range 23:17-23:31
//                                ^^^^^^ reference scip-dotnet nuget . . Main/ChainedExpressions#Method().
//                                       enclosing_range 23:17-23:42
//                                           ^^^^^^ reference scip-dotnet nuget . . Main/ChainedExpressions#Method().
//                                                  enclosing_range 23:17-23:53

          // Chained member + invocation: a.b.c(41)
          var v5 = obj.Next.Method(41);
//            ^^ definition local 5
//               enclosing_range 9:4-33:5
//               documentation ```cs\nChainedExpressions? v5\n```
//               relationship type_definition scip-dotnet nuget . . Main/ChainedExpressions#
//                 ^^^ reference local 0
//                     enclosing_range 26:17-26:25
//                     ^^^^ reference scip-dotnet nuget . . Main/ChainedExpressions#Next.
//                          enclosing_range 26:17-26:25
//                          ^^^^^^ reference scip-dotnet nuget . . Main/ChainedExpressions#Method().
//                                 enclosing_range 26:17-26:36

          // Standalone reference
          var v6 = obj;
//            ^^ definition local 6
//               enclosing_range 9:4-33:5
//               documentation ```cs\nChainedExpressions? v6\n```
//               relationship type_definition scip-dotnet nuget . . Main/ChainedExpressions#
//                 ^^^ reference local 0
//                     enclosing_range 29:17-29:20

          // Binary expression
          var v7 = obj.Value + obj.Value;
//            ^^ definition local 7
//               enclosing_range 9:4-33:5
//               documentation ```cs\nint v7\n```
//               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                 ^^^ reference local 0
//                     enclosing_range 32:17-32:26
//                     ^^^^^ reference scip-dotnet nuget . . Main/ChainedExpressions#Value.
//                           enclosing_range 32:17-32:26
//                             ^^^ reference local 0
//                                 enclosing_range 32:29-32:38
//                                 ^^^^^ reference scip-dotnet nuget . . Main/ChainedExpressions#Value.
//                                       enclosing_range 32:29-32:38
      }
  }
