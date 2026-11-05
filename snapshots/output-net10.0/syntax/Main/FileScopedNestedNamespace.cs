  using Main.Nested.Alpha;
//      ^^^^ reference scip-dotnet nuget . . Main/
//           enclosing_range 0:6-0:17
//      ^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Nested/Alpha/
//                        enclosing_range 0:6-0:23
//           ^^^^^^ reference scip-dotnet nuget . . Main/Nested/
//                  enclosing_range 0:6-0:17
//                  ^^^^^ reference scip-dotnet nuget . . Main/Nested/Alpha/
//                        enclosing_range 0:6-0:23

  namespace Main.FileScoped.Alpha;
//          ^^^^ reference scip-dotnet nuget . . Main/
//               enclosing_range 2:10-2:25
//               ^^^^^^^^^^ reference scip-dotnet nuget . . Main/FileScoped/
//                          enclosing_range 2:10-2:25
//                          ^^^^^ reference scip-dotnet nuget . . Main/FileScoped/Alpha/
//                                enclosing_range 2:10-2:31

  public class Widget
//             ^^^^^^ definition scip-dotnet nuget . . Main/FileScoped/Alpha/Widget#
//                    enclosing_range 4:0-9:1
//                    documentation ```cs\nclass Widget\n```
  {
      public Main.Nested.Alpha.Widget Nested = new();
//           ^^^^ reference scip-dotnet nuget . . Main/
//                enclosing_range 6:11-6:22
//                ^^^^^^ reference scip-dotnet nuget . . Main/Nested/
//                       enclosing_range 6:11-6:22
//                       ^^^^^ reference scip-dotnet nuget . . Main/Nested/Alpha/
//                             enclosing_range 6:11-6:28
//                             ^^^^^^ reference scip-dotnet nuget . . Main/Nested/Alpha/Widget#
//                                    enclosing_range 6:11-6:35
//                                    ^^^^^^ definition scip-dotnet nuget . . Main/FileScoped/Alpha/Widget#Nested.
//                                           enclosing_range 6:4-6:51
//                                           documentation ```cs\npublic Widget Widget.Nested\n```
//                                           relationship type_definition scip-dotnet nuget . . Main/Nested/Alpha/Widget#
      public Main.Other.Alpha.Widget Other = new();
//           ^^^^ reference scip-dotnet nuget . . Main/
//                enclosing_range 7:11-7:21
//                ^^^^^ reference scip-dotnet nuget . . Main/Other/
//                      enclosing_range 7:11-7:21
//                      ^^^^^ reference scip-dotnet nuget . . Main/Other/Alpha/
//                            enclosing_range 7:11-7:27
//                            ^^^^^^ reference scip-dotnet nuget . . Main/Other/Alpha/Widget#
//                                   enclosing_range 7:11-7:34
//                                   ^^^^^ definition scip-dotnet nuget . . Main/FileScoped/Alpha/Widget#Other.
//                                         enclosing_range 7:4-7:49
//                                         documentation ```cs\npublic Widget Widget.Other\n```
//                                         relationship type_definition scip-dotnet nuget . . Main/Other/Alpha/Widget#
      public Main.Nested.Gamma.Widget Gamma = new();
//           ^^^^ reference scip-dotnet nuget . . Main/
//                enclosing_range 8:11-8:22
//                ^^^^^^ reference scip-dotnet nuget . . Main/Nested/
//                       enclosing_range 8:11-8:22
//                       ^^^^^ reference scip-dotnet nuget . . Main/Nested/Gamma/
//                             enclosing_range 8:11-8:28
//                             ^^^^^^ reference scip-dotnet nuget . . Main/Nested/Gamma/Widget#
//                                    enclosing_range 8:11-8:35
//                                    ^^^^^ definition scip-dotnet nuget . . Main/FileScoped/Alpha/Widget#Gamma.
//                                          enclosing_range 8:4-8:50
//                                          documentation ```cs\npublic Widget Widget.Gamma\n```
//                                          relationship type_definition scip-dotnet nuget . . Main/Nested/Gamma/Widget#
  }
