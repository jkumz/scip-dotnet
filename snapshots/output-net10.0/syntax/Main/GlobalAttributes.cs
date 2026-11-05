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
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
// ^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeUsageAttribute#`.ctor`().
//                enclosing_range 5:1-5:15
//                ^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeTargets#
//                                 enclosing_range 5:16-5:38
//                                 ^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeTargets#Class.
//                                       enclosing_range 5:16-5:38
//                                        ^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeUsageAttribute#AllowMultiple.
//                                                      enclosing_range 5:40-5:53
//                                                              ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/AttributeUsageAttribute#Inherited.
//                                                                        enclosing_range 5:62-5:71
  public class GlobalAttributes : Attribute
//             ^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/GlobalAttributes#
//                              enclosing_range 4:0-44:1
//                              documentation ```cs\nclass GlobalAttributes\n```
//                              relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#
//                                ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#
//                                          enclosing_range 6:32-6:41
  {
      class AuthorAttribute : Attribute
//          ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/GlobalAttributes#AuthorAttribute#
//                          enclosing_range 8:4-13:5
//                          documentation ```cs\nclass AuthorAttribute\n```
//                          relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#
//                            ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Attribute#
//                                      enclosing_range 8:28-8:37
      {
          public AuthorAttribute(string name)
//               ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/GlobalAttributes#AuthorAttribute#`.ctor`().
//                               enclosing_range 10:8-12:9
//                               documentation ```cs\npublic AuthorAttribute.AuthorAttribute(string name)\n```
//                                      ^^^^ definition scip-dotnet nuget . . Main/GlobalAttributes#AuthorAttribute#`.ctor`().(name)
//                                           enclosing_range 10:8-12:9
//                                           documentation ```cs\nstring name\n```
//                                           relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
          {
          }
      }

      [Author("PropertyAttribute")] public int Z;
//     ^^^^^^ reference scip-dotnet nuget . . Main/GlobalAttributes#AuthorAttribute#`.ctor`().
//            enclosing_range 15:5-15:11
//                                             ^ definition scip-dotnet nuget . . Main/GlobalAttributes#Z.
//                                               enclosing_range 15:4-15:47
//                                               documentation ```cs\npublic int GlobalAttributes.Z\n```
//                                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#

      [Author("MethodAttribute")]
//     ^^^^^^ reference scip-dotnet nuget . . Main/GlobalAttributes#AuthorAttribute#`.ctor`().
//            enclosing_range 17:5-17:11
      int Method1()
//        ^^^^^^^ definition scip-dotnet nuget . . Main/GlobalAttributes#Method1().
//                enclosing_range 17:4-21:5
//                documentation ```cs\nprivate int GlobalAttributes.Method1()\n```
      {
          return 0;
      }

      [Author("EnumAttribute")]
//     ^^^^^^ reference scip-dotnet nuget . . Main/GlobalAttributes#AuthorAttribute#`.ctor`().
//            enclosing_range 23:5-23:11
      enum A
//         ^ definition scip-dotnet nuget . . Main/GlobalAttributes#A#
//           enclosing_range 23:4-28:5
//           documentation ```cs\nenum A\n```
//           relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IComparable#
//           relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IConvertible#
//           relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/ISpanFormattable#
//           relationship implementation scip-dotnet nuget System.Runtime 10.0.0.0 System/IFormattable#
      {
          B,
//        ^ definition scip-dotnet nuget . . Main/GlobalAttributes#A#B.
//          enclosing_range 26:8-26:9
//          documentation ```cs\nA.B = 0\n```
//          relationship type_definition scip-dotnet nuget . . Main/GlobalAttributes#A#
          C
//        ^ definition scip-dotnet nuget . . Main/GlobalAttributes#A#C.
//          enclosing_range 27:8-27:9
//          documentation ```cs\nA.C = 1\n```
//          relationship type_definition scip-dotnet nuget . . Main/GlobalAttributes#A#
      }

      [Author("EventAttribute")]
//     ^^^^^^ reference scip-dotnet nuget . . Main/GlobalAttributes#AuthorAttribute#`.ctor`().
//            enclosing_range 30:5-30:11
      public event EventHandler SomeEvent
//                 ^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
//                              enclosing_range 31:17-31:29
//                              ^^^^^^^^^ definition scip-dotnet nuget . . Main/GlobalAttributes#SomeEvent#
//                                        enclosing_range 30:4-35:5
//                                        documentation ```cs\npublic event EventHandler GlobalAttributes.SomeEvent\n```
//                                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
      {
          add { }
          remove { }
      }

      [Author("TypeParameterAttribute")]
//     ^^^^^^ reference scip-dotnet nuget . . Main/GlobalAttributes#AuthorAttribute#`.ctor`().
//            enclosing_range 37:5-37:11
      public class InnerClass<[Author("ClassTypeParameter")] T>
//                 ^^^^^^^^^^ definition scip-dotnet nuget . . Main/GlobalAttributes#InnerClass#
//                            enclosing_range 37:4-43:5
//                            documentation ```cs\nclass InnerClass<T>\n```
//                             ^^^^^^ reference scip-dotnet nuget . . Main/GlobalAttributes#AuthorAttribute#`.ctor`().
//                                    enclosing_range 38:29-38:35
//                                                           ^ definition local 0
//                                                             enclosing_range 37:4-43:5
//                                                             documentation ```cs\nT\n```
      {
          void Method<[Author("MethodTypeParameter")] T2>()
//             ^^^^^^ definition scip-dotnet nuget . . Main/GlobalAttributes#InnerClass#Method().
//                    enclosing_range 40:8-42:9
//                    documentation ```cs\nprivate void InnerClass<T>.Method<T2>()\n```
//                     ^^^^^^ reference scip-dotnet nuget . . Main/GlobalAttributes#AuthorAttribute#`.ctor`().
//                            enclosing_range 40:21-40:27
//                                                    ^^ definition local 1
//                                                       enclosing_range 40:8-42:9
//                                                       documentation ```cs\nT2\n```
          {
          }
      }
  }
