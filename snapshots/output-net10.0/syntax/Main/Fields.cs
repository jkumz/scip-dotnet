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
  public class Fields
//             ^^^^^^ definition scip-dotnet nuget . . Main/Fields#
//                    enclosing_range 4:0-31:1
//                    documentation ```cs\nclass Fields\n```
//                    kind Class
  {
      class Fields1
//          ^^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#
//                  enclosing_range 7:4-20:5
//                  documentation ```cs\nclass Fields1\n```
//                  kind Class
      {
          private readonly int Property1;
//                             ^^^^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#Property1.
//                                       enclosing_range 9:8-9:39
//                                       documentation ```cs\nprivate readonly int Fields1.Property1\n```
//                                       kind Field
//                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          private Int64 Property2, Property3;
//                ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#
//                      enclosing_range 10:16-10:21
//                      ^^^^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#Property2.
//                                enclosing_range 10:8-10:43
//                                documentation ```cs\nprivate long Fields1.Property2\n```
//                                kind Field
//                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#
//                                 ^^^^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#Property3.
//                                           enclosing_range 10:8-10:43
//                                           documentation ```cs\nprivate long Fields1.Property3\n```
//                                           kind Field
//                                           relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#
          private Tuple<char, Nullable<int>> Property4;
//                                           ^^^^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#Property4.
//                                                     enclosing_range 11:8-11:53
//                                                     documentation ```cs\nprivate Tuple<char, int?> Fields1.Property4\n```
//                                                     kind Field
//                                                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Tuple#

          public Fields1(long field2, long field3, Tuple<char, int?> field4, int field1)
//               ^^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().
//                       enclosing_range 13:8-19:9
//                       documentation ```cs\npublic Fields1.Fields1(long field2, long field3, Tuple<char, int?> field4, int field1)\n```
//                       kind Constructor
//                            ^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field2)
//                                   enclosing_range 13:8-19:9
//                                   documentation ```cs\nlong field2\n```
//                                   kind Parameter
//                                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#
//                                         ^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field3)
//                                                enclosing_range 13:8-19:9
//                                                documentation ```cs\nlong field3\n```
//                                                kind Parameter
//                                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#
//                                                                   ^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field4)
//                                                                          enclosing_range 13:8-19:9
//                                                                          documentation ```cs\nTuple<char, int?> field4\n```
//                                                                          kind Parameter
//                                                                          relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Tuple#
//                                                                               ^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field1)
//                                                                                      enclosing_range 13:8-19:9
//                                                                                      documentation ```cs\nint field1\n```
//                                                                                      kind Parameter
//                                                                                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          {
              Property2 = field2;
//            ^^^^^^^^^ write_access scip-dotnet nuget . . Main/Fields#Fields1#Property2.
//                      enclosing_range 15:12-15:30
//                        ^^^^^^ read_access scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field2)
//                               enclosing_range 15:12-15:30
              Property3 = field3;
//            ^^^^^^^^^ write_access scip-dotnet nuget . . Main/Fields#Fields1#Property3.
//                      enclosing_range 16:12-16:30
//                        ^^^^^^ read_access scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field3)
//                               enclosing_range 16:12-16:30
              Property4 = field4;
//            ^^^^^^^^^ write_access scip-dotnet nuget . . Main/Fields#Fields1#Property4.
//                      enclosing_range 17:12-17:30
//                        ^^^^^^ read_access scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field4)
//                               enclosing_range 17:12-17:30
              Property1 = field1;
//            ^^^^^^^^^ write_access scip-dotnet nuget . . Main/Fields#Fields1#Property1.
//                      enclosing_range 18:12-18:30
//                        ^^^^^^ read_access scip-dotnet nuget . . Main/Fields#Fields1#`.ctor`().(field1)
//                               enclosing_range 18:12-18:30
          }
      }

      class Fields2
//          ^^^^^^^ definition scip-dotnet nuget . . Main/Fields#Fields2#
//                  enclosing_range 22:4-30:5
//                  documentation ```cs\nclass Fields2\n```
//                  kind Class
      {
          // Function pointer equivalent without calling convention
          unsafe delegate*<string, int> a;
//                                      ^ definition scip-dotnet nuget . . Main/Fields#Fields2#a.
//                                        enclosing_range 25:8-25:40
//                                        documentation ```cs\nprivate delegate*<string, int> Fields2.a\n```
//                                        kind Field
//                                        relationship type_definition local 0
          unsafe delegate*<delegate*<in string, int>, delegate*<ref string, ref readonly int>> b;
//                                                                                             ^ definition scip-dotnet nuget . . Main/Fields#Fields2#b.
//                                                                                               enclosing_range 26:8-26:95
//                                                                                               documentation ```cs\nprivate delegate*<delegate*<in string, int>, delegate*<ref string, ref readonly int>> Fields2.b\n```
//                                                                                               kind Field
//                                                                                               relationship type_definition local 1

          // Function pointer equivalent with calling convention
          unsafe delegate* managed<string, int> c;
//                                              ^ definition scip-dotnet nuget . . Main/Fields#Fields2#c.
//                                                enclosing_range 29:8-29:48
//                                                documentation ```cs\nprivate delegate*<string, int> Fields2.c\n```
//                                                kind Field
//                                                relationship type_definition local 0
      }
  }
