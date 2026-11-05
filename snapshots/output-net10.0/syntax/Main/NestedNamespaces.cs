  namespace Main.Nested.Alpha
//          ^^^^ reference scip-dotnet nuget . . Main/
//               enclosing_range 0:10-0:21
//               ^^^^^^ reference scip-dotnet nuget . . Main/Nested/
//                      enclosing_range 0:10-0:21
//                      ^^^^^ reference scip-dotnet nuget . . Main/Nested/Alpha/
//                            enclosing_range 0:10-0:27
  {
      public class Widget
//                 ^^^^^^ definition scip-dotnet nuget . . Main/Nested/Alpha/Widget#
//                        enclosing_range 2:4-4:5
//                        documentation ```cs\nclass Widget\n```
      {
      }
  }

  namespace Main.Other.Alpha
//          ^^^^ reference scip-dotnet nuget . . Main/
//               enclosing_range 7:10-7:20
//               ^^^^^ reference scip-dotnet nuget . . Main/Other/
//                     enclosing_range 7:10-7:20
//                     ^^^^^ reference scip-dotnet nuget . . Main/Other/Alpha/
//                           enclosing_range 7:10-7:26
  {
      public class Widget
//                 ^^^^^^ definition scip-dotnet nuget . . Main/Other/Alpha/Widget#
//                        enclosing_range 9:4-11:5
//                        documentation ```cs\nclass Widget\n```
      {
      }
  }

  namespace Main
//          ^^^^ reference scip-dotnet nuget . . Main/
//               enclosing_range 14:10-14:14
  {
      namespace Nested
//              ^^^^^^ reference scip-dotnet nuget . . Main/Nested/
//                     enclosing_range 16:14-16:20
      {
          namespace Gamma
//                  ^^^^^ reference scip-dotnet nuget . . Main/Nested/Gamma/
//                        enclosing_range 18:18-18:23
          {
              public class Widget
//                         ^^^^^^ definition scip-dotnet nuget . . Main/Nested/Gamma/Widget#
//                                enclosing_range 20:12-24:13
//                                documentation ```cs\nclass Widget\n```
              {
                  public Alpha.Widget First = new();
//                       ^^^^^ reference scip-dotnet nuget . . Main/Nested/Alpha/
//                             enclosing_range 22:23-22:35
//                             ^^^^^^ reference scip-dotnet nuget . . Main/Nested/Alpha/Widget#
//                                    enclosing_range 22:23-22:35
//                                    ^^^^^ definition scip-dotnet nuget . . Main/Nested/Gamma/Widget#First.
//                                          enclosing_range 22:16-22:50
//                                          documentation ```cs\npublic Widget Widget.First\n```
//                                          relationship type_definition scip-dotnet nuget . . Main/Nested/Alpha/Widget#
                  public Main.Other.Alpha.Widget Second = new();
//                       ^^^^ reference scip-dotnet nuget . . Main/
//                            enclosing_range 23:23-23:33
//                            ^^^^^ reference scip-dotnet nuget . . Main/Other/
//                                  enclosing_range 23:23-23:33
//                                  ^^^^^ reference scip-dotnet nuget . . Main/Other/Alpha/
//                                        enclosing_range 23:23-23:39
//                                        ^^^^^^ reference scip-dotnet nuget . . Main/Other/Alpha/Widget#
//                                               enclosing_range 23:23-23:46
//                                               ^^^^^^ definition scip-dotnet nuget . . Main/Nested/Gamma/Widget#Second.
//                                                      enclosing_range 23:16-23:62
//                                                      documentation ```cs\npublic Widget Widget.Second\n```
//                                                      relationship type_definition scip-dotnet nuget . . Main/Other/Alpha/Widget#
              }
          }
      }
  }
