  namespace ProjectBesideSolution;
//          ^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . ProjectBesideSolution/
//                                enclosing_range 0:10-0:31

  public static class Program
//                    ^^^^^^^ definition scip-dotnet nuget . . ProjectBesideSolution/Program#
//                            enclosing_range 2:0-8:1
//                            documentation ```cs\nclass Program\n```
  {
      public static void Main()
//                       ^^^^ definition scip-dotnet nuget . . ProjectBesideSolution/Program#Main().
//                            enclosing_range 4:4-7:5
//                            documentation ```cs\npublic static void Program.Main()\n```
      {
          Console.WriteLine("Hello, World!");
//        ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                enclosing_range 6:8-6:42
//                ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
//                          enclosing_range 6:8-6:42
      }
  }
