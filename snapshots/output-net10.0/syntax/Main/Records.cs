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
  public class Records
//             ^^^^^^^ definition scip-dotnet nuget . . Main/Records#
//                     enclosing_range 4:0-61:1
//                     documentation ```cs\nclass Records\n```
  {
      record Basic
//           ^^^^^ definition scip-dotnet nuget . . Main/Records#Basic#
//                 enclosing_range 7:4-10:5
//                 documentation ```cs\nrecord Basic\n```
//                 relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
      {
          int Age { get; init; }
//            ^^^ definition scip-dotnet nuget . . Main/Records#Basic#Age.
//                enclosing_range 9:8-9:30
//                documentation ```cs\nprivate int Basic.Age { get; init; }\n```
//                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      }

      record struct Struct
//                  ^^^^^^ definition scip-dotnet nuget . . Main/Records#Struct#
//                         enclosing_range 12:4-15:5
//                         documentation ```cs\nrecord struct Struct\n```
//                         relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
      {
          int Age { get; init; }
//            ^^^ definition scip-dotnet nuget . . Main/Records#Struct#Age.
//                enclosing_range 14:8-14:30
//                documentation ```cs\nprivate int Struct.Age { get; init; }\n```
//                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      }

      record class Class
//                 ^^^^^ definition scip-dotnet nuget . . Main/Records#Class#
//                       enclosing_range 17:4-20:5
//                       documentation ```cs\nrecord Class\n```
//                       relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
      {
          int Age { get; init; }
//            ^^^ definition scip-dotnet nuget . . Main/Records#Class#Age.
//                enclosing_range 19:8-19:30
//                documentation ```cs\nprivate int Class.Age { get; init; }\n```
//                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      }

      public record TypeParameterConstraint<T> where T : struct
//                  ^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Records#TypeParameterConstraint#
//                                          enclosing_range 22:4-24:5
//                                          documentation ```cs\nrecord TypeParameterConstraint<T> where T : struct\n```
//                                          relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                                          ^ definition local 0
//                                            enclosing_range 22:4-24:5
//                                            documentation ```cs\nT\n```
//                                                   ^ reference local 0
//                                                     enclosing_range 22:51-22:52
      {
      }

      interface I1
//              ^^ definition scip-dotnet nuget . . Main/Records#I1#
//                 enclosing_range 26:4-28:6
//                 documentation ```cs\ninterface I1\n```
      {
      };

      interface I2
//              ^^ definition scip-dotnet nuget . . Main/Records#I2#
//                 enclosing_range 30:4-32:6
//                 documentation ```cs\ninterface I2\n```
      {
      };


      record Person(string FirstName, string LastName) : I1, I2
//           ^^^^^^ definition scip-dotnet nuget . . Main/Records#Person#
//                  enclosing_range 35:4-40:6
//                  documentation ```cs\nrecord Person\n```
//                  relationship implementation scip-dotnet nuget . . Main/Records#I1#
//                  relationship implementation scip-dotnet nuget . . Main/Records#I2#
//                  relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                         ^^^^^^^^^ definition scip-dotnet nuget . . Main/Records#Person#`.ctor`().(FirstName)
//                                   enclosing_range 35:4-40:6
//                                   documentation ```cs\nstring FirstName\n```
//                                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
//                                           ^^^^^^^^ definition scip-dotnet nuget . . Main/Records#Person#`.ctor`().(LastName)
//                                                    enclosing_range 35:4-40:6
//                                                    documentation ```cs\nstring LastName\n```
//                                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
//                                                       ^^ reference scip-dotnet nuget . . Main/Records#I1#
//                                                          enclosing_range 35:55-35:57
//                                                           ^^ reference scip-dotnet nuget . . Main/Records#I2#
//                                                              enclosing_range 35:59-35:61
      {
          public Person(string FirstName) : this(FirstName, FirstName)
//               ^^^^^^ definition scip-dotnet nuget . . Main/Records#Person#`.ctor`(+1).
//                      enclosing_range 37:8-39:9
//                      documentation ```cs\npublic Person.Person(string FirstName)\n```
//                             ^^^^^^^^^ definition scip-dotnet nuget . . Main/Records#Person#`.ctor`(+1).(FirstName)
//                                       enclosing_range 37:8-39:9
//                                       documentation ```cs\nstring FirstName\n```
//                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
//                                               ^^^^^^^^^ reference scip-dotnet nuget . . Main/Records#Person#`.ctor`(+1).(FirstName)
//                                                         enclosing_range 37:47-37:56
//                                                          ^^^^^^^^^ reference scip-dotnet nuget . . Main/Records#Person#`.ctor`(+1).(FirstName)
//                                                                    enclosing_range 37:58-37:67
          {
          }
      };

      record Teacher(string FirstName, string LastName, string Subject) : Person(FirstName, LastName), I1, I2;
//           ^^^^^^^ definition scip-dotnet nuget . . Main/Records#Teacher#
//                   enclosing_range 42:4-42:108
//                   documentation ```cs\nrecord Teacher\n```
//                   relationship implementation scip-dotnet nuget . . Main/Records#Person#
//                   relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                   relationship implementation scip-dotnet nuget . . Main/Records#I1#
//                   relationship implementation scip-dotnet nuget . . Main/Records#I2#
//                   relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                          ^^^^^^^^^ definition scip-dotnet nuget . . Main/Records#Teacher#`.ctor`().(FirstName)
//                                    enclosing_range 42:4-42:108
//                                    documentation ```cs\nstring FirstName\n```
//                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
//                                            ^^^^^^^^ definition scip-dotnet nuget . . Main/Records#Teacher#`.ctor`().(LastName)
//                                                     enclosing_range 42:4-42:108
//                                                     documentation ```cs\nstring LastName\n```
//                                                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
//                                                             ^^^^^^^ definition scip-dotnet nuget . . Main/Records#Teacher#`.ctor`().(Subject)
//                                                                     enclosing_range 42:4-42:108
//                                                                     documentation ```cs\nstring Subject\n```
//                                                                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
//                                                                        ^^^^^^ reference scip-dotnet nuget . . Main/Records#Person#
//                                                                               enclosing_range 42:72-42:78
//                                                                               ^^^^^^^^^ reference scip-dotnet nuget . . Main/Records#Teacher#`.ctor`().(FirstName)
//                                                                                         enclosing_range 42:79-42:88
//                                                                                          ^^^^^^^^ reference scip-dotnet nuget . . Main/Records#Teacher#`.ctor`().(LastName)
//                                                                                                   enclosing_range 42:90-42:98
//                                                                                                     ^^ reference scip-dotnet nuget . . Main/Records#I1#
//                                                                                                        enclosing_range 42:101-42:103
//                                                                                                         ^^ reference scip-dotnet nuget . . Main/Records#I2#
//                                                                                                            enclosing_range 42:105-42:107

      void UsingRecords()
//         ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Records#UsingRecords().
//                      enclosing_range 44:4-48:5
//                      documentation ```cs\nprivate void Records.UsingRecords()\n```
      {
          var person = new Person("a", "b");
//            ^^^^^^ definition local 1
//                   enclosing_range 44:4-48:5
//                   documentation ```cs\nPerson? person\n```
//                   relationship type_definition scip-dotnet nuget . . Main/Records#Person#
//                         ^^^^^^ reference scip-dotnet nuget . . Main/Records#Person#
//                                enclosing_range 46:21-46:41
          var teacher = new Teacher("a", "b", "c");
//            ^^^^^^^ definition local 2
//                    enclosing_range 44:4-48:5
//                    documentation ```cs\nTeacher? teacher\n```
//                    relationship type_definition scip-dotnet nuget . . Main/Records#Teacher#
//                          ^^^^^^^ reference scip-dotnet nuget . . Main/Records#Teacher#
//                                  enclosing_range 47:22-47:48
      }

      record I3<T>;
//           ^^ definition scip-dotnet nuget . . Main/Records#I3#
//              enclosing_range 50:4-50:17
//              documentation ```cs\nrecord I3<T>\n```
//              relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//              ^ definition local 3
//                enclosing_range 50:4-50:17
//                documentation ```cs\nT\n```

      record Teacher2() : I3<Person>(), I1;
//           ^^^^^^^^ definition scip-dotnet nuget . . Main/Records#Teacher2#
//                    enclosing_range 52:4-52:41
//                    documentation ```cs\nrecord Teacher2\n```
//                    relationship implementation scip-dotnet nuget . . Main/Records#I3#
//                    relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                    relationship implementation scip-dotnet nuget . . Main/Records#I1#
//                    relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
//                           ^^^^^^ reference scip-dotnet nuget . . Main/Records#Person#
//                                  enclosing_range 52:27-52:33
//                                      ^^ reference scip-dotnet nuget . . Main/Records#I1#
//                                         enclosing_range 52:38-52:40

      record SealedToString
//           ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Records#SealedToString#
//                          enclosing_range 54:4-60:5
//                          documentation ```cs\nrecord SealedToString\n```
//                          relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IEquatable#
      {
          public sealed override string ToString()
//                                      ^^^^^^^^ definition scip-dotnet nuget . . Main/Records#SealedToString#ToString().
//                                               enclosing_range 56:8-59:9
//                                               documentation ```cs\npublic override sealed string SealedToString.ToString()\n```
//                                               relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#ToString().
          {
              return "";
          }
      }
  }
