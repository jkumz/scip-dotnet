  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ read_access scip-dotnet nuget . . System/
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
//             ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ read_access scip-dotnet nuget . . Main/
//               enclosing_range 2:0-28:1

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
//                 enclosing_range 4:0-28:1
  public class Events
//             ^^^^^^ definition scip-dotnet nuget . . Main/Events#
//                    enclosing_range 2:0-28:1
//                    documentation ```cs\nclass Events\n```
//                    kind Class
  {
      public event EventHandler<int> Event1
//                                   ^^^^^^ definition scip-dotnet nuget . . Main/Events#Event1#
//                                          enclosing_range 4:0-28:1
//                                          documentation ```cs\npublic event EventHandler<int> Events.Event1\n```
//                                          kind Event
//                                          relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
      {
          add { }
          remove { }
      }

      public event EventHandler Event2
//                 ^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
//                              enclosing_range 13:4-17:5
//                              ^^^^^^ definition scip-dotnet nuget . . Main/Events#Event2#
//                                     enclosing_range 4:0-28:1
//                                     documentation ```cs\npublic event EventHandler Events.Event2\n```
//                                     kind Event
//                                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
      {
          add => addSomething();
//               ^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Events#addSomething().
//                            enclosing_range 13:4-17:5
          remove => removeSomething();
//                  ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Events#removeSomething().
//                                  enclosing_range 13:4-17:5
      }

      private void removeSomething()
//                 ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Events#removeSomething().
//                                 enclosing_range 4:0-28:1
//                                 documentation ```cs\nprivate void Events.removeSomething()\n```
//                                 kind Method
      {
          throw new NotImplementedException();
//                  ^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
//                                          enclosing_range 19:4-22:5
      }

      private void addSomething()
//                 ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Events#addSomething().
//                              enclosing_range 4:0-28:1
//                              documentation ```cs\nprivate void Events.addSomething()\n```
//                              kind Method
      {
          throw new NotImplementedException();
//                  ^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
//                                          enclosing_range 24:4-27:5
      }
  }
