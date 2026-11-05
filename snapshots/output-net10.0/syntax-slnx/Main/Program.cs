  namespace SlnxTest;
//          ^^^^^^^^ reference scip-dotnet nuget . . SlnxTest/
//                   enclosing_range 0:10-0:18

  public class Greeter
//             ^^^^^^^ definition scip-dotnet nuget . . SlnxTest/Greeter#
//                     enclosing_range 2:0-5:1
//                     documentation ```cs\nclass Greeter\n```
  {
      public string Greet(string name) => $"Hello, {name}!";
//                  ^^^^^ definition scip-dotnet nuget . . SlnxTest/Greeter#Greet().
//                        enclosing_range 4:4-4:58
//                        documentation ```cs\npublic string Greeter.Greet(string name)\n```
//                               ^^^^ definition scip-dotnet nuget . . SlnxTest/Greeter#Greet().(name)
//                                    enclosing_range 4:4-4:58
//                                    documentation ```cs\nstring name\n```
//                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
//                                                  ^^^^ reference scip-dotnet nuget . . SlnxTest/Greeter#Greet().(name)
//                                                       enclosing_range 4:50-4:54
  }

  public static class Program
//                    ^^^^^^^ definition scip-dotnet nuget . . SlnxTest/Program#
//                            enclosing_range 7:0-14:1
//                            documentation ```cs\nclass Program\n```
  {
      public static void Main()
//                       ^^^^ definition scip-dotnet nuget . . SlnxTest/Program#Main().
//                            enclosing_range 9:4-13:5
//                            documentation ```cs\npublic static void Program.Main()\n```
      {
          var greeter = new Greeter();
//            ^^^^^^^ definition local 0
//                    enclosing_range 9:4-13:5
//                    documentation ```cs\nGreeter? greeter\n```
//                    relationship type_definition scip-dotnet nuget . . SlnxTest/Greeter#
//                          ^^^^^^^ reference scip-dotnet nuget . . SlnxTest/Greeter#
//                                  enclosing_range 11:22-11:35
          Console.WriteLine(greeter.Greet("World"));
//        ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                enclosing_range 12:8-12:49
//                ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
//                          enclosing_range 12:8-12:49
//                          ^^^^^^^ reference local 0
//                                  enclosing_range 12:26-12:48
//                                  ^^^^^ reference scip-dotnet nuget . . SlnxTest/Greeter#Greet().
//                                        enclosing_range 12:26-12:48
      }
  }
