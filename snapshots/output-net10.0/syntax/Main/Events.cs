  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ reference scip-dotnet nuget . . System/
//             enclosing_range 0:6-0:24
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . System/Diagnostics/CodeAnalysis/
//                                      enclosing_range 0:6-0:37
//             ^^^^^^^^^^^ reference scip-dotnet nuget . . System/Diagnostics/
//                         enclosing_range 0:6-0:24
//                         ^^^^^^^^^^^^ reference scip-dotnet nuget . . System/Diagnostics/CodeAnalysis/
//                                      enclosing_range 0:6-0:37

  namespace Main;
//          ^^^^ reference scip-dotnet nuget . . Main/
//               enclosing_range 2:10-2:14

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Diagnostics/CodeAnalysis/SuppressMessageAttribute#`.ctor`().
//                 enclosing_range 4:1-4:16
  public class Events
//             ^^^^^^ definition scip-dotnet nuget . . Main/Events#
//                    enclosing_range 4:0-28:1
//                    documentation ```cs\nclass Events\n```
  {
      public event EventHandler<int> Event1
//                                   ^^^^^^ definition scip-dotnet nuget . . Main/Events#Event1#
//                                          enclosing_range 7:4-11:5
//                                          documentation ```cs\npublic event EventHandler<int> Events.Event1\n```
//                                          relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
      {
          add { }
          remove { }
      }

      public event EventHandler Event2
//                 ^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
//                              enclosing_range 13:17-13:29
//                              ^^^^^^ definition scip-dotnet nuget . . Main/Events#Event2#
//                                     enclosing_range 13:4-17:5
//                                     documentation ```cs\npublic event EventHandler Events.Event2\n```
//                                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
      {
          add => addSomething();
//               ^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Events#addSomething().
//                            enclosing_range 15:15-15:29
          remove => removeSomething();
//                  ^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/Events#removeSomething().
//                                  enclosing_range 16:18-16:35
      }

      private void removeSomething()
//                 ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Events#removeSomething().
//                                 enclosing_range 19:4-22:5
//                                 documentation ```cs\nprivate void Events.removeSomething()\n```
      {
          throw new NotImplementedException();
//                  ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
//                                          enclosing_range 21:14-21:43
      }

      private void addSomething()
//                 ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Events#addSomething().
//                              enclosing_range 24:4-27:5
//                              documentation ```cs\nprivate void Events.addSomething()\n```
      {
          throw new NotImplementedException();
//                  ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
//                                          enclosing_range 26:14-26:43
      }
  }
