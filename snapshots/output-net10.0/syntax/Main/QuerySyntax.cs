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
  public class QuerySyntax
//             ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#
//                         enclosing_range 4:0-77:1
//                         documentation ```cs\nclass QuerySyntax\n```
//                         kind Class
  {
      List<IGeneric> sourceA = new List<IGeneric>();
//         ^^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#
//                  enclosing_range 7:9-7:17
//                   ^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#sourceA.
//                           enclosing_range 7:4-7:50
//                           documentation ```cs\nprivate List<IGeneric> QuerySyntax.sourceA\n```
//                           kind Field
//                           relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#
//                                      ^^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#
//                                               enclosing_range 7:38-7:46
      List<IGeneric> sourceB = new List<IGeneric>();
//         ^^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#
//                  enclosing_range 8:9-8:17
//                   ^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#sourceB.
//                           enclosing_range 8:4-8:50
//                           documentation ```cs\nprivate List<IGeneric> QuerySyntax.sourceB\n```
//                           kind Field
//                           relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#
//                                      ^^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#
//                                               enclosing_range 8:38-8:46

      interface IGeneric
//              ^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#IGeneric#
//                       enclosing_range 10:4-13:5
//                       documentation ```cs\ninterface IGeneric\n```
//                       kind Interface
      {
          string Method();
//               ^^^^^^ definition forward_definition scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                      enclosing_range 12:8-12:24
//                      documentation ```cs\nstring IGeneric.Method()\n```
//                      kind AbstractMethod
      }

      void Select()
//         ^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Select().
//                enclosing_range 15:4-18:5
//                documentation ```cs\nprivate void QuerySyntax.Select()\n```
//                kind Method
      {
          var x = from a in sourceA select a.Method();
//            ^ definition local 0
//              enclosing_range 15:4-18:5
//              documentation ```cs\nIEnumerable<string>? x\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
//                     ^ definition local 1
//                       enclosing_range 15:4-18:5
//                       documentation ```cs\n? a\n```
//                          ^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#sourceA.
//                                  enclosing_range 17:26-17:33
//                                         ^ read_access local 1
//                                           enclosing_range 17:41-17:51
//                                           ^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                                  enclosing_range 17:41-17:51
      }

      void Projection()
//         ^^^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Projection().
//                    enclosing_range 20:4-24:5
//                    documentation ```cs\nprivate void QuerySyntax.Projection()\n```
//                    kind Method
      {
          var x = from a in sourceA select new { Name = a.Method() };
//            ^ definition local 2
//              enclosing_range 20:4-24:5
//              documentation ```cs\nIEnumerable<<anonymous type: string Name>>? x\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
//                     ^ definition local 3
//                       enclosing_range 20:4-24:5
//                       documentation ```cs\n? a\n```
//                          ^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#sourceA.
//                                  enclosing_range 22:26-22:33
//                                               ^^^^ read_access local 5
//                                                    enclosing_range 22:47-22:51
//                                                      ^ read_access local 3
//                                                        enclosing_range 22:54-22:64
//                                                        ^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                                               enclosing_range 22:54-22:64
          var b = from a in x select a.Name;
//            ^ definition local 6
//              enclosing_range 20:4-24:5
//              documentation ```cs\nIEnumerable<string>? b\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
//                     ^ definition local 7
//                       enclosing_range 20:4-24:5
//                       documentation ```cs\n? a\n```
//                          ^ read_access local 2
//                            enclosing_range 23:26-23:27
//                                   ^ read_access local 7
//                                     enclosing_range 23:35-23:41
//                                     ^^^^ read_access local 5
//                                          enclosing_range 23:35-23:41
      }

      void Where()
//         ^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Where().
//               enclosing_range 26:4-29:5
//               documentation ```cs\nprivate void QuerySyntax.Where()\n```
//               kind Method
      {
          var x = from a in sourceA where a.Method().StartsWith("a") select a;
//            ^ definition local 8
//              enclosing_range 26:4-29:5
//              documentation ```cs\nIEnumerable<IGeneric>? x\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
//                     ^ definition local 9
//                       enclosing_range 26:4-29:5
//                       documentation ```cs\n? a\n```
//                          ^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#sourceA.
//                                  enclosing_range 28:26-28:33
//                                        ^ read_access local 9
//                                          enclosing_range 28:40-28:50
//                                          ^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                                 enclosing_range 28:40-28:50
//                                                   ^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/String#StartsWith(+1).
//                                                              enclosing_range 28:40-28:66
//                                                                          ^ read_access local 9
//                                                                            enclosing_range 28:74-28:75
      }

      void Let()
//         ^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Let().
//             enclosing_range 31:4-36:5
//             documentation ```cs\nprivate void QuerySyntax.Let()\n```
//             kind Method
      {
          var x = from a in sourceA
//            ^ definition local 10
//              enclosing_range 31:4-36:5
//              documentation ```cs\nIEnumerable<<anonymous type: string A, string B>>? x\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
//                     ^ definition local 11
//                       enclosing_range 31:4-36:5
//                       documentation ```cs\n? a\n```
//                          ^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#sourceA.
//                                  enclosing_range 33:26-33:33
                  let z = new { A = a.Method(), B = a.Method() }
//                    ^ definition local 12
//                      enclosing_range 31:4-36:5
//                      documentation ```cs\n? z\n```
//                              ^ read_access local 14
//                                enclosing_range 34:30-34:31
//                                  ^ read_access local 11
//                                    enclosing_range 34:34-34:44
//                                    ^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                           enclosing_range 34:34-34:44
//                                              ^ read_access local 15
//                                                enclosing_range 34:46-34:47
//                                                  ^ read_access local 11
//                                                    enclosing_range 34:50-34:60
//                                                    ^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                                           enclosing_range 34:50-34:60
                  select z;
//                       ^ read_access local 12
//                         enclosing_range 35:23-35:24
      }

      void Join()
//         ^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Join().
//              enclosing_range 38:4-43:5
//              documentation ```cs\nprivate void QuerySyntax.Join()\n```
//              kind Method
      {
          var x = from a in sourceA
//            ^ definition local 16
//              enclosing_range 38:4-43:5
//              documentation ```cs\nIEnumerable<<anonymous type: string A, string B>>? x\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
//                     ^ definition local 17
//                       enclosing_range 38:4-43:5
//                       documentation ```cs\n? a\n```
//                          ^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#sourceA.
//                                  enclosing_range 40:26-40:33
                  join b in sourceB on a.Method() equals b.Method()
//                     ^ definition local 18
//                       enclosing_range 38:4-43:5
//                       documentation ```cs\n? b\n```
//                          ^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#sourceB.
//                                  enclosing_range 41:26-41:33
//                                     ^ read_access local 17
//                                       enclosing_range 41:37-41:47
//                                       ^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                              enclosing_range 41:37-41:47
//                                                       ^ read_access local 18
//                                                         enclosing_range 41:55-41:65
//                                                         ^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                                                enclosing_range 41:55-41:65
                  select new { A = a.Method(), B = b.Method() };
//                             ^ read_access local 14
//                               enclosing_range 42:29-42:30
//                                 ^ read_access local 17
//                                   enclosing_range 42:33-42:43
//                                   ^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                          enclosing_range 42:33-42:43
//                                             ^ read_access local 15
//                                               enclosing_range 42:45-42:46
//                                                 ^ read_access local 18
//                                                   enclosing_range 42:49-42:59
//                                                   ^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                                          enclosing_range 42:49-42:59
      }

      void MultipleFrom()
//         ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#MultipleFrom().
//                      enclosing_range 45:4-51:5
//                      documentation ```cs\nprivate void QuerySyntax.MultipleFrom()\n```
//                      kind Method
      {
          var x = from a in sourceA
//            ^ definition local 19
//              enclosing_range 45:4-51:5
//              documentation ```cs\nIEnumerable<<anonymous type: string A, string B>>? x\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
//                     ^ definition local 20
//                       enclosing_range 45:4-51:5
//                       documentation ```cs\n? a\n```
//                          ^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#sourceA.
//                                  enclosing_range 47:26-47:33
                  from b in sourceB
//                     ^ definition local 21
//                       enclosing_range 45:4-51:5
//                       documentation ```cs\n? b\n```
//                          ^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#sourceB.
//                                  enclosing_range 48:26-48:33
                  where a.Method() == b.Method()
//                      ^ read_access local 20
//                        enclosing_range 49:22-49:32
//                        ^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                               enclosing_range 49:22-49:32
//                                    ^ read_access local 21
//                                      enclosing_range 49:36-49:46
//                                      ^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                             enclosing_range 49:36-49:46
                  select new { A = a.Method(), B = b.Method() };
//                             ^ read_access local 14
//                               enclosing_range 50:29-50:30
//                                 ^ read_access local 20
//                                   enclosing_range 50:33-50:43
//                                   ^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                          enclosing_range 50:33-50:43
//                                             ^ read_access local 15
//                                               enclosing_range 50:45-50:46
//                                                 ^ read_access local 21
//                                                   enclosing_range 50:49-50:59
//                                                   ^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#IGeneric#Method().
//                                                          enclosing_range 50:49-50:59
      }

      void JoinInto(List<Student> students1, List<Student> students2)
//         ^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#JoinInto().
//                  enclosing_range 53:4-59:5
//                  documentation ```cs\nprivate void QuerySyntax.JoinInto(List<Student> students1, List<Student> students2)\n```
//                  kind Method
//                       ^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#Student#
//                               enclosing_range 53:23-53:30
//                                ^^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#JoinInto().(students1)
//                                          enclosing_range 53:4-59:5
//                                          documentation ```cs\nList<Student> students1\n```
//                                          kind Parameter
//                                          relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#
//                                                ^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#Student#
//                                                        enclosing_range 53:48-53:55
//                                                         ^^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#JoinInto().(students2)
//                                                                   enclosing_range 53:4-59:5
//                                                                   documentation ```cs\nList<Student> students2\n```
//                                                                   kind Parameter
//                                                                   relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#
      {
          var innerGroupJoinQuery =
//            ^^^^^^^^^^^^^^^^^^^ definition local 22
//                                enclosing_range 53:4-59:5
//                                documentation ```cs\nIEnumerable<<anonymous type: string Student, interface IEnumerable<Student> Students>>? innerGroupJoinQuery\n```
//                                kind Variable
//                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Generic/IEnumerable#
              from student1 in students1
//                 ^^^^^^^^ definition local 23
//                          enclosing_range 53:4-59:5
//                          documentation ```cs\n? student1\n```
//                             ^^^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#JoinInto().(students1)
//                                       enclosing_range 56:29-56:38
              join student2 in students2 on student1.ID equals student2.ID into studentGroup
//                 ^^^^^^^^ definition local 24
//                          enclosing_range 53:4-59:5
//                          documentation ```cs\n? student2\n```
//                             ^^^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#JoinInto().(students2)
//                                       enclosing_range 57:29-57:38
//                                          ^^^^^^^^ read_access local 23
//                                                   enclosing_range 57:42-57:53
//                                                   ^^ read_access scip-dotnet nuget . . Main/QuerySyntax#Student#ID.
//                                                      enclosing_range 57:42-57:53
//                                                             ^^^^^^^^ read_access local 24
//                                                                      enclosing_range 57:61-57:72
//                                                                      ^^ read_access scip-dotnet nuget . . Main/QuerySyntax#Student#ID.
//                                                                         enclosing_range 57:61-57:72
//                                                                              ^^^^^^^^^^^^ definition local 25
//                                                                                           enclosing_range 53:4-59:5
//                                                                                           documentation ```cs\n? studentGroup\n```
              select new { Student = student1.First, Students = studentGroup };
//                         ^^^^^^^ read_access local 27
//                                 enclosing_range 58:25-58:32
//                                   ^^^^^^^^ read_access local 23
//                                            enclosing_range 58:35-58:49
//                                            ^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#Student#First.
//                                                  enclosing_range 58:35-58:49
//                                                   ^^^^^^^^ read_access local 28
//                                                            enclosing_range 58:51-58:59
//                                                              ^^^^^^^^^^^^ read_access local 25
//                                                                           enclosing_range 58:62-58:74
      }

      void Continuation(List<Student> students)
//         ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Continuation().
//                      enclosing_range 61:4-69:5
//                      documentation ```cs\nprivate void QuerySyntax.Continuation(List<Student> students)\n```
//                      kind Method
//                           ^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#Student#
//                                   enclosing_range 61:27-61:34
//                                    ^^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Continuation().(students)
//                                             enclosing_range 61:4-69:5
//                                             documentation ```cs\nList<Student> students\n```
//                                             kind Parameter
//                                             relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#
      {
          var sortedGroups =
//            ^^^^^^^^^^^^ definition local 29
//                         enclosing_range 61:4-69:5
//                         documentation ```cs\nIOrderedEnumerable<IGrouping<char, Student>>? sortedGroups\n```
//                         kind Variable
//                         relationship type_definition scip-dotnet nuget System.Linq 10.0.0.0 Linq/IOrderedEnumerable#
              from student in students
//                 ^^^^^^^ definition local 30
//                         enclosing_range 61:4-69:5
//                         documentation ```cs\n? student\n```
//                            ^^^^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#Continuation().(students)
//                                     enclosing_range 64:28-64:36
              orderby student.Last, student.First
//                    ^^^^^^^ read_access local 30
//                            enclosing_range 65:20-65:32
//                            ^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#Student#Last.
//                                 enclosing_range 65:20-65:32
//                                  ^^^^^^^ read_access local 30
//                                          enclosing_range 65:34-65:47
//                                          ^^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#Student#First.
//                                                enclosing_range 65:34-65:47
              group student by student.Last[0] into newGroup
//                  ^^^^^^^ read_access local 30
//                          enclosing_range 66:18-66:25
//                             ^^^^^^^ read_access local 30
//                                     enclosing_range 66:29-66:41
//                                     ^^^^ read_access scip-dotnet nuget . . Main/QuerySyntax#Student#Last.
//                                          enclosing_range 66:29-66:41
//                                                  ^^^^^^^^ definition local 31
//                                                           enclosing_range 61:4-69:5
//                                                           documentation ```cs\n? newGroup\n```
              orderby newGroup.Key
//                    ^^^^^^^^ read_access local 31
//                             enclosing_range 67:20-67:32
//                             ^^^ read_access scip-dotnet nuget System.Linq 10.0.0.0 Linq/IGrouping#Key.
//                                 enclosing_range 67:20-67:32
              select newGroup;
//                   ^^^^^^^^ read_access local 31
//                            enclosing_range 68:19-68:27
      }

      private class Student
//                  ^^^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Student#
//                          enclosing_range 71:4-76:5
//                          documentation ```cs\nclass Student\n```
//                          kind Class
      {
          public string First { get; set; }
//                      ^^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Student#First.
//                            enclosing_range 73:8-73:41
//                            documentation ```cs\npublic string Student.First { get; set; }\n```
//                            kind Property
//                            relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
          public string Last { get; set; }
//                      ^^^^ definition scip-dotnet nuget . . Main/QuerySyntax#Student#Last.
//                           enclosing_range 74:8-74:40
//                           documentation ```cs\npublic string Student.Last { get; set; }\n```
//                           kind Property
//                           relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
          public int ID { get; set; }
//                   ^^ definition scip-dotnet nuget . . Main/QuerySyntax#Student#ID.
//                      enclosing_range 75:8-75:35
//                      documentation ```cs\npublic int Student.ID { get; set; }\n```
//                      kind Property
//                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      }
  }
