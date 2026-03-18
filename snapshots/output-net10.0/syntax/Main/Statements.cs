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
  public class Statements
//             ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Statements#
//                        enclosing_range 4:0-92:1
//                        documentation ```cs\nclass Statements\n```
//                        kind Class
  {
      void Try()
//         ^^^ definition scip-dotnet nuget . . Main/Statements#Try().
//             enclosing_range 7:4-17:5
//             documentation ```cs\nprivate void Statements.Try()\n```
//             kind Method
      {
          try
          {
              File.ReadLines("asd");
//            ^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
//                 enclosing_range 11:12-11:33
//                 ^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#ReadLines().
//                           enclosing_range 11:12-11:33
          }
          catch (Exception err)
//               ^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Exception#
//                         enclosing_range 13:15-13:24
//                         ^^^ definition local 0
//                             enclosing_range 7:4-17:5
//                             documentation ```cs\nException err\n```
//                             kind Variable
//                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Exception#
          {
              Console.WriteLine(err);
//            ^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                    enclosing_range 15:12-15:34
//                    ^^^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+9).
//                              enclosing_range 15:12-15:34
//                              ^^^ read_access local 0
//                                  enclosing_range 15:30-15:33
          }
      }

      (string a, bool b) Default()
//                       ^^^^^^^ definition scip-dotnet nuget . . Main/Statements#Default().
//                               enclosing_range 19:4-23:5
//                               documentation ```cs\nprivate (string a, bool b) Statements.Default()\n```
//                               kind Method
      {
          (string a, bool b) c = default;
//                           ^ definition local 1
//                             enclosing_range 19:4-23:5
//                             documentation ```cs\n(string a, bool b) c\n```
//                             kind Variable
//                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/ValueTuple#
          return c;
//               ^ read_access local 1
//                 enclosing_range 22:15-22:16
      }

      void Deconstruction()
//         ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Statements#Deconstruction().
//                        enclosing_range 25:4-30:5
//                        documentation ```cs\nprivate void Statements.Deconstruction()\n```
//                        kind Method
      {
          var point = (1, 2);
//            ^^^^^ definition local 2
//                  enclosing_range 25:4-30:5
//                  documentation ```cs\n(int, int) point\n```
//                  kind Variable
//                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/ValueTuple#
          int x = 0;
//            ^ definition local 3
//              enclosing_range 25:4-30:5
//              documentation ```cs\nint x\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          (x, int y) = point;
//         ^ read_access local 3
//           enclosing_range 29:9-29:10
//                ^ definition local 4
//                  enclosing_range 25:4-30:5
//                  documentation ```cs\nint y\n```
//                  kind Variable
//                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                     ^^^^^ read_access local 2
//                           enclosing_range 29:8-29:26
      }

      record Inferred(int F1, int F2);
//           ^^^^^^^^ definition scip-dotnet nuget . . Main/Statements#Inferred#
//                    enclosing_range 32:4-32:36
//                    documentation ```cs\nrecord Inferred\n```
//                    kind Class
//                    relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                        ^^ definition scip-dotnet nuget . . Main/Statements#Inferred#`.ctor`().(F1)
//                           enclosing_range 32:4-32:36
//                           documentation ```cs\nint F1\n```
//                           kind Parameter
//                           relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                                ^^ definition scip-dotnet nuget . . Main/Statements#Inferred#`.ctor`().(F2)
//                                   enclosing_range 32:4-32:36
//                                   documentation ```cs\nint F2\n```
//                                   kind Parameter
//                                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#

      void InferredTuples()
//         ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Statements#InferredTuples().
//                        enclosing_range 34:4-38:5
//                        documentation ```cs\nprivate void Statements.InferredTuples()\n```
//                        kind Method
      {
          var list = new List<Inferred>();
//            ^^^^ definition local 5
//                 enclosing_range 34:4-38:5
//                 documentation ```cs\nList<Inferred>? list\n```
//                 kind Variable
//                 relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#
//                            ^^^^^^^^ read_access scip-dotnet nuget . . Main/Statements#Inferred#
//                                     enclosing_range 36:28-36:36
          var result = list.Select(c => (c.F1, c.F2)).Where(t => t.F2 == 1);
//            ^^^^^^ definition local 6
//                   enclosing_range 34:4-38:5
//                   documentation ```cs\nIEnumerable<(int F1, int F2)>? result\n```
//                   kind Variable
//                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
//                     ^^^^ read_access local 5
//                          enclosing_range 37:21-37:51
//                          ^^^^^^ read_access scip-dotnet nuget System.Linq 10.0.0.0 Linq/Enumerable#Select().
//                                 enclosing_range 37:21-37:51
//                                 ^ definition local 8
//                                   enclosing_range 34:4-38:5
//                                   documentation ```cs\nInferred c\n```
//                                   kind Parameter
//                                   relationship type_definition scip-dotnet nuget . . Main/Statements#Inferred#
//                                       ^ read_access local 8
//                                         enclosing_range 37:39-37:43
//                                         ^^ read_access scip-dotnet nuget . . Main/Statements#Inferred#F1.
//                                            enclosing_range 37:39-37:43
//                                             ^ read_access local 8
//                                               enclosing_range 37:45-37:49
//                                               ^^ read_access scip-dotnet nuget . . Main/Statements#Inferred#F2.
//                                                  enclosing_range 37:45-37:49
//                                                    ^^^^^ read_access scip-dotnet nuget System.Linq 10.0.0.0 Linq/Enumerable#Where().
//                                                          enclosing_range 37:21-37:73
//                                                          ^ definition local 10
//                                                            enclosing_range 34:4-38:5
//                                                            documentation ```cs\n(int F1, int F2) t\n```
//                                                            kind Parameter
//                                                            relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/ValueTuple#
//                                                               ^ read_access local 10
//                                                                 enclosing_range 37:63-37:67
//                                                                 ^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/ValueTuple#F2.
//                                                                    enclosing_range 37:63-37:67
      }

      int MultipleInitializers()
//        ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Statements#MultipleInitializers().
//                             enclosing_range 40:4-44:5
//                             documentation ```cs\nprivate int Statements.MultipleInitializers()\n```
//                             kind Method
      {
          int a = 1, b = 2;
//            ^ definition local 11
//              enclosing_range 40:4-44:5
//              documentation ```cs\nint a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                   ^ definition local 12
//                     enclosing_range 40:4-44:5
//                     documentation ```cs\nint b\n```
//                     kind Variable
//                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          return a + b;
//               ^ read_access local 11
//                 enclosing_range 43:15-43:20
//                   ^ read_access local 12
//                     enclosing_range 43:15-43:20
      }

      void RefVariable()
//         ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Statements#RefVariable().
//                     enclosing_range 46:4-50:5
//                     documentation ```cs\nprivate void Statements.RefVariable()\n```
//                     kind Method
      {
          var data = new int[] { 1, 2 };
//            ^^^^ definition local 13
//                 enclosing_range 46:4-50:5
//                 documentation ```cs\nint[]? data\n```
//                 kind Variable
//                 relationship type_definition local 14
          ref var value = ref data[0];
//                ^^^^^ definition local 15
//                      enclosing_range 46:4-50:5
//                      documentation ```cs\nref int value\n```
//                      kind Variable
//                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                            ^^^^ read_access local 13
//                                 enclosing_range 49:28-49:35
      }

      class MyDisposable : IDisposable
//          ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Statements#MyDisposable#
//                       enclosing_range 52:4-57:5
//                       documentation ```cs\nclass MyDisposable\n```
//                       kind Class
//                       relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#
//                         ^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#
//                                     enclosing_range 52:25-52:36
      {
          public void Dispose()
//                    ^^^^^^^ definition scip-dotnet nuget . . Main/Statements#MyDisposable#Dispose().
//                            enclosing_range 54:8-56:9
//                            documentation ```cs\npublic void MyDisposable.Dispose()\n```
//                            kind Method
//                            relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/IDisposable#Dispose().
          {
          }
      }

      MyDisposable Using()
//    ^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Statements#MyDisposable#
//                 enclosing_range 59:4-59:16
//                 ^^^^^ definition scip-dotnet nuget . . Main/Statements#Using().
//                       enclosing_range 59:4-66:5
//                       documentation ```cs\nprivate MyDisposable Statements.Using()\n```
//                       kind Method
      {
          var b = new MyDisposable();
//            ^ definition local 16
//              enclosing_range 59:4-66:5
//              documentation ```cs\nMyDisposable? b\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget . . Main/Statements#MyDisposable#
//                    ^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Statements#MyDisposable#
//                                 enclosing_range 61:16-61:34
          using (var a = b)
//                   ^ definition local 17
//                     enclosing_range 59:4-66:5
//                     documentation ```cs\nMyDisposable? a\n```
//                     kind Variable
//                     relationship type_definition scip-dotnet nuget . . Main/Statements#MyDisposable#
//                       ^ read_access local 16
//                         enclosing_range 62:23-62:24
          {
              return a;
//                   ^ read_access local 17
//                     enclosing_range 64:19-64:20
          }
      }

      long MultipleUsing()
//         ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Statements#MultipleUsing().
//                       enclosing_range 68:4-74:5
//                       documentation ```cs\nprivate long Statements.MultipleUsing()\n```
//                       kind Method
      {
          using (Stream a = File.OpenRead("a"), b = File.OpenRead("a"))
//               ^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
//                      enclosing_range 70:15-70:21
//                      ^ definition local 18
//                        enclosing_range 68:4-74:5
//                        documentation ```cs\nStream a\n```
//                        kind Variable
//                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
//                          ^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
//                               enclosing_range 70:26-70:44
//                               ^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#OpenRead().
//                                        enclosing_range 70:26-70:44
//                                              ^ definition local 19
//                                                enclosing_range 68:4-74:5
//                                                documentation ```cs\nStream b\n```
//                                                kind Variable
//                                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#
//                                                  ^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#
//                                                       enclosing_range 70:50-70:68
//                                                       ^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/File#OpenRead().
//                                                                enclosing_range 70:50-70:68
          {
              return a.Length + b.Length;
//                   ^ read_access local 18
//                     enclosing_range 72:19-72:27
//                     ^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#Length.
//                            enclosing_range 72:19-72:27
//                              ^ read_access local 19
//                                enclosing_range 72:30-72:38
//                                ^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 IO/Stream#Length.
//                                       enclosing_range 72:30-72:38
          }
      }

      int Foreach()
//        ^^^^^^^ definition scip-dotnet nuget . . Main/Statements#Foreach().
//                enclosing_range 76:4-83:5
//                documentation ```cs\nprivate int Statements.Foreach()\n```
//                kind Method
      {
          var y = new int[] { 1 };
//            ^ definition local 20
//              enclosing_range 76:4-83:5
//              documentation ```cs\nint[]? y\n```
//              kind Variable
//              relationship type_definition local 14
          var z = 0;
//            ^ definition local 21
//              enclosing_range 76:4-83:5
//              documentation ```cs\nint z\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          foreach (int x in y)
//                     ^ definition local 22
//                       enclosing_range 76:4-83:5
//                       documentation ```cs\nint x\n```
//                       kind Variable
//                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                          ^ read_access local 20
//                            enclosing_range 80:26-80:27
              z += x;
//            ^ write_access local 21
//              enclosing_range 81:12-81:18
//                 ^ read_access local 22
//                   enclosing_range 81:12-81:18
          return z;
//               ^ read_access local 21
//                 enclosing_range 82:15-82:16
      }

      void ForeachVariable(List<(int, int)> names)
//         ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Statements#ForeachVariable().
//                         enclosing_range 85:4-91:5
//                         documentation ```cs\nprivate void Statements.ForeachVariable(List<(int, int)> names)\n```
//                         kind Method
//                                          ^^^^^ definition scip-dotnet nuget . . Main/Statements#ForeachVariable().(names)
//                                                enclosing_range 85:4-91:5
//                                                documentation ```cs\nList<(int, int)> names\n```
//                                                kind Parameter
//                                                relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#
      {
          foreach ((int firstName, int lastName) in names)
//                      ^^^^^^^^^ definition local 23
//                                enclosing_range 85:4-91:5
//                                documentation ```cs\nint firstName\n```
//                                kind Variable
//                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                                     ^^^^^^^^ definition local 24
//                                              enclosing_range 85:4-91:5
//                                              documentation ```cs\nint lastName\n```
//                                              kind Variable
//                                              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                                                  ^^^^^ read_access scip-dotnet nuget . . Main/Statements#ForeachVariable().(names)
//                                                        enclosing_range 87:50-87:55
          {
              Console.WriteLine($"FirstName:{firstName}, LastName:{lastName}");
//            ^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                    enclosing_range 89:12-89:76
//                    ^^^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
//                              enclosing_range 89:12-89:76
//                                           ^^^^^^^^^ read_access local 23
//                                                     enclosing_range 89:43-89:52
//                                                                 ^^^^^^^^ read_access local 24
//                                                                          enclosing_range 89:65-89:73
          }
      }
  }
