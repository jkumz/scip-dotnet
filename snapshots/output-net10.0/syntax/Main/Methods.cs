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
  public class Methods
//             ^^^^^^^ definition scip-dotnet nuget . . Main/Methods#
//                     enclosing_range 4:0-112:1
//                     documentation ```cs\nclass Methods\n```
//                     kind Class
  {
      int SingleParameter(int b)
//        ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#SingleParameter().
//                        enclosing_range 7:4-10:5
//                        documentation ```cs\nprivate int Methods.SingleParameter(int b)\n```
//                        kind Method
//                            ^ definition scip-dotnet nuget . . Main/Methods#SingleParameter().(b)
//                              enclosing_range 7:4-10:5
//                              documentation ```cs\nint b\n```
//                              kind Parameter
//                              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      {
          return b;
//               ^ read_access scip-dotnet nuget . . Main/Methods#SingleParameter().(b)
//                 enclosing_range 9:15-9:16
      }

      int TwoParameters(int a, int b)
//        ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#TwoParameters().
//                      enclosing_range 12:4-15:5
//                      documentation ```cs\nprivate int Methods.TwoParameters(int a, int b)\n```
//                      kind Method
//                          ^ definition scip-dotnet nuget . . Main/Methods#TwoParameters().(a)
//                            enclosing_range 12:4-15:5
//                            documentation ```cs\nint a\n```
//                            kind Parameter
//                            relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                                 ^ definition scip-dotnet nuget . . Main/Methods#TwoParameters().(b)
//                                   enclosing_range 12:4-15:5
//                                   documentation ```cs\nint b\n```
//                                   kind Parameter
//                                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      {
          return a + b;
//               ^ read_access scip-dotnet nuget . . Main/Methods#TwoParameters().(a)
//                 enclosing_range 14:15-14:20
//                   ^ read_access scip-dotnet nuget . . Main/Methods#TwoParameters().(b)
//                     enclosing_range 14:15-14:20
      }

      int Overload1(int a)
//        ^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#Overload1().
//                  enclosing_range 17:4-20:5
//                  documentation ```cs\nprivate int Methods.Overload1(int a)\n```
//                  kind Method
//                      ^ definition scip-dotnet nuget . . Main/Methods#Overload1().(a)
//                        enclosing_range 17:4-20:5
//                        documentation ```cs\nint a\n```
//                        kind Parameter
//                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      {
          return a;
//               ^ read_access scip-dotnet nuget . . Main/Methods#Overload1().(a)
//                 enclosing_range 19:15-19:16
      }

      int Overload1(int a, int b)
//        ^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#Overload1(+1).
//                  enclosing_range 22:4-25:5
//                  documentation ```cs\nprivate int Methods.Overload1(int a, int b)\n```
//                  kind Method
//                      ^ definition scip-dotnet nuget . . Main/Methods#Overload1(+1).(a)
//                        enclosing_range 22:4-25:5
//                        documentation ```cs\nint a\n```
//                        kind Parameter
//                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                             ^ definition scip-dotnet nuget . . Main/Methods#Overload1(+1).(b)
//                               enclosing_range 22:4-25:5
//                               documentation ```cs\nint b\n```
//                               kind Parameter
//                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      {
          return a + b;
//               ^ read_access scip-dotnet nuget . . Main/Methods#Overload1(+1).(a)
//                 enclosing_range 24:15-24:20
//                   ^ read_access scip-dotnet nuget . . Main/Methods#Overload1(+1).(b)
//                     enclosing_range 24:15-24:20
      }

      T Generic<T>(T param)
//    ^ read_access local 0
//      enclosing_range 27:4-27:5
//      ^^^^^^^ definition scip-dotnet nuget . . Main/Methods#Generic().
//              enclosing_range 27:4-30:5
//              documentation ```cs\nprivate T Methods.Generic<T>(T param)\n```
//              kind Method
//              ^ definition local 0
//                enclosing_range 27:4-30:5
//                documentation ```cs\nT\n```
//                kind TypeParameter
//                 ^ read_access local 0
//                   enclosing_range 27:17-27:18
//                   ^^^^^ definition scip-dotnet nuget . . Main/Methods#Generic().(param)
//                         enclosing_range 27:4-30:5
//                         documentation ```cs\nT param\n```
//                         kind Parameter
//                         relationship type_definition local 0
      {
          return param;
//               ^^^^^ read_access scip-dotnet nuget . . Main/Methods#Generic().(param)
//                     enclosing_range 29:15-29:20
      }

      T GenericConstraint<T>(T param) where T : new()
//    ^ read_access local 1
//      enclosing_range 32:4-32:5
//      ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#GenericConstraint().
//                        enclosing_range 32:4-35:5
//                        documentation ```cs\nprivate T Methods.GenericConstraint<T>(T param) where T : new()\n```
//                        kind Method
//                        ^ definition local 1
//                          enclosing_range 32:4-35:5
//                          documentation ```cs\nT\n```
//                          kind TypeParameter
//                           ^ read_access local 1
//                             enclosing_range 32:27-32:28
//                             ^^^^^ definition scip-dotnet nuget . . Main/Methods#GenericConstraint().(param)
//                                   enclosing_range 32:4-35:5
//                                   documentation ```cs\nT param\n```
//                                   kind Parameter
//                                   relationship type_definition local 1
//                                          ^ read_access local 1
//                                            enclosing_range 32:42-32:43
      {
          return param;
//               ^^^^^ read_access scip-dotnet nuget . . Main/Methods#GenericConstraint().(param)
//                     enclosing_range 34:15-34:20
      }

      void DefaultParameter(int a = 5)
//         ^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#DefaultParameter().
//                          enclosing_range 37:4-39:5
//                          documentation ```cs\nprivate void Methods.DefaultParameter([int a = 5])\n```
//                          kind Method
//                              ^ definition scip-dotnet nuget . . Main/Methods#DefaultParameter().(a)
//                                enclosing_range 37:4-39:5
//                                documentation ```cs\n[int a = 5]\n```
//                                kind Parameter
//                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      {
      }

      int DefaultParameterOverload(int a = 5)
//        ^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#DefaultParameterOverload().
//                                 enclosing_range 41:4-44:5
//                                 documentation ```cs\nprivate int Methods.DefaultParameterOverload([int a = 5])\n```
//                                 kind Method
//                                     ^ definition scip-dotnet nuget . . Main/Methods#DefaultParameterOverload().(a)
//                                       enclosing_range 41:4-44:5
//                                       documentation ```cs\n[int a = 5]\n```
//                                       kind Parameter
//                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      {
          return DefaultParameterOverload(a, a);
//               ^^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Methods#DefaultParameterOverload(+1).
//                                        enclosing_range 43:15-43:45
//                                        ^ read_access scip-dotnet nuget . . Main/Methods#DefaultParameterOverload().(a)
//                                          enclosing_range 43:40-43:41
//                                           ^ read_access scip-dotnet nuget . . Main/Methods#DefaultParameterOverload().(a)
//                                             enclosing_range 43:43-43:44
      }

      int DefaultParameterOverload(int a, int b)
//        ^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#DefaultParameterOverload(+1).
//                                 enclosing_range 46:4-49:5
//                                 documentation ```cs\nprivate int Methods.DefaultParameterOverload(int a, int b)\n```
//                                 kind Method
//                                     ^ definition scip-dotnet nuget . . Main/Methods#DefaultParameterOverload(+1).(a)
//                                       enclosing_range 46:4-49:5
//                                       documentation ```cs\nint a\n```
//                                       kind Parameter
//                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                                            ^ definition scip-dotnet nuget . . Main/Methods#DefaultParameterOverload(+1).(b)
//                                              enclosing_range 46:4-49:5
//                                              documentation ```cs\nint b\n```
//                                              kind Parameter
//                                              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      {
          return DefaultParameterOverload();
//               ^^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Methods#DefaultParameterOverload().
//                                        enclosing_range 48:15-48:41
      }

      interface IHello
//              ^^^^^^ definition scip-dotnet nuget . . Main/Methods#IHello#
//                     enclosing_range 51:4-54:5
//                     documentation ```cs\ninterface IHello\n```
//                     kind Interface
      {
          string Hello();
//               ^^^^^ definition forward_definition scip-dotnet nuget . . Main/Methods#IHello#Hello().
//                     enclosing_range 53:8-53:23
//                     documentation ```cs\nstring IHello.Hello()\n```
//                     kind AbstractMethod
      }

      class ImplementsHello : IHello
//          ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#ImplementsHello#
//                          enclosing_range 56:4-62:5
//                          documentation ```cs\nclass ImplementsHello\n```
//                          kind Class
//                          relationship implementation scip-dotnet nuget . . Main/Methods#IHello#
//                            ^^^^^^ read_access scip-dotnet nuget . . Main/Methods#IHello#
//                                   enclosing_range 56:28-56:34
      {
          string IHello.Hello()
//               ^^^^^^ read_access scip-dotnet nuget . . Main/Methods#IHello#
//                      enclosing_range 58:15-58:21
//                      ^^^^^ definition scip-dotnet nuget . . Main/Methods#ImplementsHello#`Main.Methods.IHello.Hello`().
//                            enclosing_range 58:8-61:9
//                            documentation ```cs\nprivate string ImplementsHello.IHello.Hello()\n```
//                            kind Method
//                            relationship implementation reference scip-dotnet nuget . . Main/Methods#IHello#Hello().
          {
              return "";
          }
      }

      class InheritedOverloads1
//          ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads1#
//                              enclosing_range 64:4-69:5
//                              documentation ```cs\nclass InheritedOverloads1\n```
//                              kind Class
      {
          public void Method()
//                    ^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads1#Method().
//                           enclosing_range 66:8-68:9
//                           documentation ```cs\npublic void InheritedOverloads1.Method()\n```
//                           kind Method
          {
          }
      }

      class InheritedOverloads2 : InheritedOverloads1
//          ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads2#
//                              enclosing_range 71:4-77:5
//                              documentation ```cs\nclass InheritedOverloads2\n```
//                              kind Class
//                              relationship implementation scip-dotnet nuget . . Main/Methods#InheritedOverloads1#
//                                ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads1#
//                                                    enclosing_range 71:32-71:51
      {
          public int Method(int parameter)
//                   ^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads2#Method().
//                          enclosing_range 73:8-76:9
//                          documentation ```cs\npublic int InheritedOverloads2.Method(int parameter)\n```
//                          kind Method
//                              ^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads2#Method().(parameter)
//                                        enclosing_range 73:8-76:9
//                                        documentation ```cs\nint parameter\n```
//                                        kind Parameter
//                                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          {
              return parameter;
//                   ^^^^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads2#Method().(parameter)
//                             enclosing_range 75:19-75:28
          }
      }

      class InheritedOverloads3 : InheritedOverloads2
//          ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads3#
//                              enclosing_range 79:4-85:5
//                              documentation ```cs\nclass InheritedOverloads3\n```
//                              kind Class
//                              relationship implementation scip-dotnet nuget . . Main/Methods#InheritedOverloads2#
//                              relationship implementation scip-dotnet nuget . . Main/Methods#InheritedOverloads1#
//                                ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads2#
//                                                    enclosing_range 79:32-79:51
      {
          public string Method(string parameter)
//                      ^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads3#Method().
//                             enclosing_range 81:8-84:9
//                             documentation ```cs\npublic string InheritedOverloads3.Method(string parameter)\n```
//                             kind Method
//                                    ^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads3#Method().(parameter)
//                                              enclosing_range 81:8-84:9
//                                              documentation ```cs\nstring parameter\n```
//                                              kind Parameter
//                                              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
          {
              return parameter;
//                   ^^^^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads3#Method().(parameter)
//                             enclosing_range 83:19-83:28
          }
      }

      public static void InheritedOverloads()
//                       ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#InheritedOverloads().
//                                          enclosing_range 87:4-95:5
//                                          documentation ```cs\npublic static void Methods.InheritedOverloads()\n```
//                                          kind StaticMethod
      {
          new InheritedOverloads1().Method();
//            ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads1#
//                                enclosing_range 89:8-89:33
//                                  ^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads1#Method().
//                                         enclosing_range 89:8-89:42
          new InheritedOverloads2().Method();
//            ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads2#
//                                enclosing_range 90:8-90:33
//                                  ^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads1#Method().
//                                         enclosing_range 90:8-90:42
          new InheritedOverloads2().Method(42);
//            ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads2#
//                                enclosing_range 91:8-91:33
//                                  ^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads2#Method().
//                                         enclosing_range 91:8-91:44
          new InheritedOverloads3().Method();
//            ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads3#
//                                enclosing_range 92:8-92:33
//                                  ^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads1#Method().
//                                         enclosing_range 92:8-92:42
          new InheritedOverloads3().Method(42);
//            ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads3#
//                                enclosing_range 93:8-93:33
//                                  ^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads2#Method().
//                                         enclosing_range 93:8-93:44
          new InheritedOverloads3().Method("42");
//            ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads3#
//                                enclosing_range 94:8-94:33
//                                  ^^^^^^ read_access scip-dotnet nuget . . Main/Methods#InheritedOverloads3#Method().
//                                         enclosing_range 94:8-94:46
      }

      public class LocalFunction
//                 ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Methods#LocalFunction#
//                               enclosing_range 97:4-111:5
//                               documentation ```cs\nclass LocalFunction\n```
//                               kind Class
      {
          public static void Method()
//                           ^^^^^^ definition scip-dotnet nuget . . Main/Methods#LocalFunction#Method().
//                                  enclosing_range 99:8-110:9
//                                  documentation ```cs\npublic static void LocalFunction.Method()\n```
//                                  kind StaticMethod
          {
              var myWorld = GetWorld();
//                ^^^^^^^ definition local 2
//                        enclosing_range 99:8-110:9
//                        documentation ```cs\nstring? myWorld\n```
//                        kind Variable
//                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
//                          ^^^^^^^^ read_access local 3
//                                   enclosing_range 101:26-101:36
              SayHi(myWorld);
//            ^^^^^ read_access local 4
//                  enclosing_range 102:12-102:26
//                  ^^^^^^^ read_access local 2
//                          enclosing_range 102:18-102:25

              string GetWorld() => "world";
//                   ^^^^^^^^ definition local 3
//                            enclosing_range 104:12-104:41
//                            documentation ```cs\nstring GetWorld()\n```
//                            kind Method

              void SayHi(string world)
//                 ^^^^^ definition local 4
//                       enclosing_range 106:12-109:13
//                       documentation ```cs\nvoid SayHi(string world)\n```
//                       kind Method
//                              ^^^^^ definition local 5
//                                    enclosing_range 106:12-109:13
//                                    documentation ```cs\nstring world\n```
//                                    kind Parameter
//                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
              {
                  Console.WriteLine($"Hello {world}!");
//                ^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                        enclosing_range 108:16-108:52
//                        ^^^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
//                                  enclosing_range 108:16-108:52
//                                           ^^^^^ read_access local 5
//                                                 enclosing_range 108:43-108:48
              }
          }
      }
  }
