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
  public class Interfaces
//             ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#
//                        enclosing_range 4:0-69:1
//                        documentation ```cs\nclass Interfaces\n```
//                        kind Class
  {
      public interface IOne
//                     ^^^^ definition scip-dotnet nuget . . Main/Interfaces#IOne#
//                          enclosing_range 7:4-9:6
//                          documentation ```cs\ninterface IOne\n```
//                          kind Interface
      {
      };

      public interface ITwo
//                     ^^^^ definition scip-dotnet nuget . . Main/Interfaces#ITwo#
//                          enclosing_range 11:4-13:6
//                          documentation ```cs\ninterface ITwo\n```
//                          kind Interface
      {
      };

      public interface IThree
//                     ^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IThree#
//                            enclosing_range 15:4-17:6
//                            documentation ```cs\ninterface IThree\n```
//                            kind Interface
      {
      };

      public interface IProperties
//                     ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IProperties#
//                                 enclosing_range 19:4-25:5
//                                 documentation ```cs\ninterface IProperties\n```
//                                 kind Interface
      {
          byte Get { get; }
//             ^^^ definition forward_definition scip-dotnet nuget . . Main/Interfaces#IProperties#Get.
//                 enclosing_range 21:8-21:25
//                 documentation ```cs\nbyte IProperties.Get { get; }\n```
//                 kind Property
//                 relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Byte#
          char Set { set; }
//             ^^^ definition forward_definition scip-dotnet nuget . . Main/Interfaces#IProperties#Set.
//                 enclosing_range 22:8-22:25
//                 documentation ```cs\nchar IProperties.Set { set; }\n```
//                 kind Property
//                 relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Char#
          uint GetSet { get; set; }
//             ^^^^^^ definition forward_definition scip-dotnet nuget . . Main/Interfaces#IProperties#GetSet.
//                    enclosing_range 23:8-23:33
//                    documentation ```cs\nuint IProperties.GetSet { get; set; }\n```
//                    kind Property
//                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/UInt32#
          long SetGet { set; get; }
//             ^^^^^^ definition forward_definition scip-dotnet nuget . . Main/Interfaces#IProperties#SetGet.
//                    enclosing_range 24:8-24:33
//                    documentation ```cs\nlong IProperties.SetGet { get; set; }\n```
//                    kind Property
//                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#
      }

      interface IMethods
//              ^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IMethods#
//                       enclosing_range 27:4-33:6
//                       documentation ```cs\ninterface IMethods\n```
//                       kind Interface
      {
          void Nothing();
//             ^^^^^^^ definition forward_definition scip-dotnet nuget . . Main/Interfaces#IMethods#Nothing().
//                     enclosing_range 29:8-29:23
//                     documentation ```cs\nvoid IMethods.Nothing()\n```
//                     kind AbstractMethod
          int Output();
//            ^^^^^^ definition forward_definition scip-dotnet nuget . . Main/Interfaces#IMethods#Output().
//                   enclosing_range 30:8-30:21
//                   documentation ```cs\nint IMethods.Output()\n```
//                   kind AbstractMethod
          void Input(string a);
//             ^^^^^ definition forward_definition scip-dotnet nuget . . Main/Interfaces#IMethods#Input().
//                   enclosing_range 31:8-31:29
//                   documentation ```cs\nvoid IMethods.Input(string a)\n```
//                   kind AbstractMethod
//                          ^ definition scip-dotnet nuget . . Main/Interfaces#IMethods#Input().(a)
//                            enclosing_range 31:8-31:29
//                            documentation ```cs\nstring a\n```
//                            kind Parameter
//                            relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
          int InputOutput(string a);
//            ^^^^^^^^^^^ definition forward_definition scip-dotnet nuget . . Main/Interfaces#IMethods#InputOutput().
//                        enclosing_range 32:8-32:34
//                        documentation ```cs\nint IMethods.InputOutput(string a)\n```
//                        kind AbstractMethod
//                               ^ definition scip-dotnet nuget . . Main/Interfaces#IMethods#InputOutput().(a)
//                                 enclosing_range 32:8-32:34
//                                 documentation ```cs\nstring a\n```
//                                 kind Parameter
//                                 relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
      };

      interface IEvent
//              ^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IEvent#
//                     enclosing_range 35:4-38:5
//                     documentation ```cs\ninterface IEvent\n```
//                     kind Interface
      {
          event EventHandler<int> SomeEvent;
//                                ^^^^^^^^^ definition forward_definition scip-dotnet nuget . . Main/Interfaces#IEvent#SomeEvent#
//                                          enclosing_range 37:8-37:42
//                                          documentation ```cs\nevent EventHandler<int> IEvent.SomeEvent\n```
//                                          kind Event
//                                          relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
      }

      interface IIndex
//              ^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IIndex#
//                     enclosing_range 40:4-43:5
//                     documentation ```cs\ninterface IIndex\n```
//                     kind Interface
      {
          bool this[int index] { get; set; }
//                      ^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IIndex#`this[]`.(index)
//                            enclosing_range 42:8-42:42
//                            documentation ```cs\nint index\n```
//                            kind Parameter
//                            relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      }

      interface IDefault
//              ^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IDefault#
//                       enclosing_range 45:4-51:5
//                       documentation ```cs\ninterface IDefault\n```
//                       kind Interface
      {
          void Log(string message)
//             ^^^ definition scip-dotnet nuget . . Main/Interfaces#IDefault#Log().
//                 enclosing_range 47:8-50:9
//                 documentation ```cs\nvoid IDefault.Log(string message)\n```
//                 kind Method
//                        ^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IDefault#Log().(message)
//                                enclosing_range 47:8-50:9
//                                documentation ```cs\nstring message\n```
//                                kind Parameter
//                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
          {
              Console.WriteLine(message);
//            ^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                    enclosing_range 49:12-49:38
//                    ^^^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
//                              enclosing_range 49:12-49:38
//                              ^^^^^^^ read_access scip-dotnet nuget . . Main/Interfaces#IDefault#Log().(message)
//                                      enclosing_range 49:30-49:37
          }
      }


      private interface IInherit : IOne, ITwo
//                      ^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IInherit#
//                               enclosing_range 54:4-56:5
//                               documentation ```cs\ninterface IInherit\n```
//                               kind Interface
//                               relationship implementation scip-dotnet nuget . . Main/Interfaces#IOne#
//                               relationship implementation scip-dotnet nuget . . Main/Interfaces#ITwo#
//                                 ^^^^ read_access scip-dotnet nuget . . Main/Interfaces#IOne#
//                                      enclosing_range 54:33-54:37
//                                       ^^^^ read_access scip-dotnet nuget . . Main/Interfaces#ITwo#
//                                            enclosing_range 54:39-54:43
      {
      }

      public interface IGetNext<T> where T : IGetNext<T>
//                     ^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IGetNext#
//                              enclosing_range 58:4-64:5
//                              documentation ```cs\ninterface IGetNext<T> where T : IGetNext<T>\n```
//                              kind Interface
//                              ^ definition local 0
//                                enclosing_range 58:4-64:5
//                                documentation ```cs\nT\n```
//                                kind TypeParameter
//                                       ^ read_access local 0
//                                         enclosing_range 58:39-58:40
//                                                    ^ read_access local 0
//                                                      enclosing_range 58:52-58:53
      {
          static IGetNext<T> operator ++(IGetNext<T> other)
//                        ^ read_access local 0
//                          enclosing_range 60:24-60:25
//                                                ^ read_access local 0
//                                                  enclosing_range 60:48-60:49
//                                                   ^^^^^ definition scip-dotnet nuget . . Main/Interfaces#IGetNext#op_Increment().(other)
//                                                         enclosing_range 60:8-63:9
//                                                         documentation ```cs\nIGetNext<T> other\n```
//                                                         kind Parameter
//                                                         relationship type_definition scip-dotnet nuget . . Main/Interfaces#IGetNext#
          {
              throw new NotImplementedException();
//                      ^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
//                                              enclosing_range 62:18-62:47
          }
      }

      private interface ITypeParameter<T1, T2> : ITwo where T1 : IOne where T2 : IThree
//                      ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Interfaces#ITypeParameter#
//                                     enclosing_range 66:4-68:5
//                                     documentation ```cs\ninterface ITypeParameter<T1, T2> where T1 : IOne where T2 : IThree\n```
//                                     kind Interface
//                                     relationship implementation scip-dotnet nuget . . Main/Interfaces#ITwo#
//                                     ^^ definition local 1
//                                        enclosing_range 66:4-68:5
//                                        documentation ```cs\nT1\n```
//                                        kind TypeParameter
//                                         ^^ definition local 2
//                                            enclosing_range 66:4-68:5
//                                            documentation ```cs\nT2\n```
//                                            kind TypeParameter
//                                               ^^^^ read_access scip-dotnet nuget . . Main/Interfaces#ITwo#
//                                                    enclosing_range 66:47-66:51
//                                                          ^^ read_access local 1
//                                                             enclosing_range 66:58-66:60
//                                                               ^^^^ read_access scip-dotnet nuget . . Main/Interfaces#IOne#
//                                                                    enclosing_range 66:63-66:67
//                                                                          ^^ read_access local 2
//                                                                             enclosing_range 66:74-66:76
//                                                                               ^^^^^^ read_access scip-dotnet nuget . . Main/Interfaces#IThree#
//                                                                                      enclosing_range 66:79-66:85
      {
      }
  }
