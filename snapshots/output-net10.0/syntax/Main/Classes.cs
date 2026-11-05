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
  public class Classes
//             ^^^^^^^ definition scip-dotnet nuget . . Main/Classes#
//                     enclosing_range 4:0-92:1
//                     documentation ```cs\nclass Classes\n```
  {
      public string Name;
//                  ^^^^ definition scip-dotnet nuget . . Main/Classes#Name.
//                       enclosing_range 7:4-7:23
//                       documentation ```cs\npublic string Classes.Name\n```
//                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
      public const int IntConstant = 1;
//                     ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#IntConstant.
//                                 enclosing_range 8:4-8:37
//                                 documentation ```cs\npublic const int Classes.IntConstant = 1\n```
//                                 relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      public const string StringConstant = $"hello";
//                        ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#StringConstant.
//                                       enclosing_range 9:4-9:50
//                                       documentation ```cs\npublic const string Classes.StringConstant = "hello"\n```
//                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#

      public Classes(int name)
//           ^^^^^^^ definition scip-dotnet nuget . . Main/Classes#`.ctor`().
//                   enclosing_range 11:4-14:5
//                   documentation ```cs\npublic Classes.Classes(int name)\n```
//                       ^^^^ definition scip-dotnet nuget . . Main/Classes#`.ctor`().(name)
//                            enclosing_range 11:4-14:5
//                            documentation ```cs\nint name\n```
//                            relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      {
          Name = "name";
//        ^^^^ reference scip-dotnet nuget . . Main/Classes#Name.
//             enclosing_range 13:8-13:21
      }

      public Classes(string name) => Name = name;
//           ^^^^^^^ definition scip-dotnet nuget . . Main/Classes#`.ctor`(+1).
//                   enclosing_range 16:4-16:47
//                   documentation ```cs\npublic Classes.Classes(string name)\n```
//                          ^^^^ definition scip-dotnet nuget . . Main/Classes#`.ctor`(+1).(name)
//                               enclosing_range 16:4-16:47
//                               documentation ```cs\nstring name\n```
//                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
//                                   ^^^^ reference scip-dotnet nuget . . Main/Classes#Name.
//                                        enclosing_range 16:35-16:46
//                                          ^^^^ reference scip-dotnet nuget . . Main/Classes#`.ctor`(+1).(name)
//                                               enclosing_range 16:35-16:46

      ~Classes()
//     ^^^^^^^ definition scip-dotnet nuget . . Main/Classes#Finalize().
//             enclosing_range 18:4-21:5
//             documentation ```cs\nprotected Classes.~Classes()\n```
      {
          Console.WriteLine(42);
//        ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                enclosing_range 20:8-20:29
//                ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+7).
//                          enclosing_range 20:8-20:29
      }

      public class ObjectClass : object, SomeInterface
//                 ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#ObjectClass#
//                             enclosing_range 23:4-25:5
//                             documentation ```cs\nclass ObjectClass\n```
//                             relationship implementation scip-dotnet nuget . . Main/SomeInterface#
//                                       ^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/SomeInterface#
//                                                     enclosing_range 23:39-23:52
      {
      }

      public partial class PartialClass
//                         ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#PartialClass#
//                                      enclosing_range 27:4-29:5
//                                      documentation ```cs\nclass PartialClass\n```
      {
      }

      class TypeParameterClass<T>
//          ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#TypeParameterClass#
//                             enclosing_range 31:4-33:5
//                             documentation ```cs\nclass TypeParameterClass<T>\n```
//                             ^ definition local 0
//                               enclosing_range 31:4-33:5
//                               documentation ```cs\nT\n```
      {
      }

      internal class InternalMultipleTypeParametersClass<T1, T2>
//                   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#InternalMultipleTypeParametersClass#
//                                                       enclosing_range 35:4-37:5
//                                                       documentation ```cs\nclass InternalMultipleTypeParametersClass<T1, T2>\n```
//                                                       ^^ definition local 1
//                                                          enclosing_range 35:4-37:5
//                                                          documentation ```cs\nT1\n```
//                                                           ^^ definition local 2
//                                                              enclosing_range 35:4-37:5
//                                                              documentation ```cs\nT2\n```
      {
      }

      interface ICovariantContravariant<in T1, out T2>
//              ^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#ICovariantContravariant#
//                                      enclosing_range 39:4-50:5
//                                      documentation ```cs\ninterface ICovariantContravariant<in T1, out T2>\n```
//                                         ^^ definition local 3
//                                            enclosing_range 39:4-50:5
//                                            documentation ```cs\nin T1\n```
//                                                 ^^ definition local 4
//                                                    enclosing_range 39:4-50:5
//                                                    documentation ```cs\nout T2\n```
      {
          public void Method1(T1 t1)
//                    ^^^^^^^ definition scip-dotnet nuget . . Main/Classes#ICovariantContravariant#Method1().
//                            enclosing_range 41:8-44:9
//                            documentation ```cs\nvoid ICovariantContravariant<in T1, out T2>.Method1(T1 t1)\n```
//                            ^^ reference local 3
//                               enclosing_range 41:28-41:30
//                               ^^ definition scip-dotnet nuget . . Main/Classes#ICovariantContravariant#Method1().(t1)
//                                  enclosing_range 41:8-44:9
//                                  documentation ```cs\nT1 t1\n```
//                                  relationship type_definition local 3
          {
              Console.WriteLine(t1);
//            ^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                    enclosing_range 43:12-43:33
//                    ^^^^^^^^^ reference scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+9).
//                              enclosing_range 43:12-43:33
//                              ^^ reference scip-dotnet nuget . . Main/Classes#ICovariantContravariant#Method1().(t1)
//                                 enclosing_range 43:30-43:32
          }

          public T2? Method2()
//               ^^ reference local 4
//                  enclosing_range 46:15-46:18
//                   ^^^^^^^ definition scip-dotnet nuget . . Main/Classes#ICovariantContravariant#Method2().
//                           enclosing_range 46:8-49:9
//                           documentation ```cs\nT2? ICovariantContravariant<in T1, out T2>.Method2()\n```
          {
              return default(T2);
//                           ^^ reference local 4
//                              enclosing_range 48:19-48:30
          }
      }

      public class StructConstraintClass<T> where T : struct
//                 ^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#StructConstraintClass#
//                                       enclosing_range 52:4-54:5
//                                       documentation ```cs\nclass StructConstraintClass<T> where T : struct\n```
//                                       ^ definition local 5
//                                         enclosing_range 52:4-54:5
//                                         documentation ```cs\nT\n```
//                                                ^ reference local 5
//                                                  enclosing_range 52:48-52:49
      {
      }

      public class UnmanagedConstraintClass<T> where T : unmanaged
//                 ^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#UnmanagedConstraintClass#
//                                          enclosing_range 56:4-58:5
//                                          documentation ```cs\nclass UnmanagedConstraintClass<T> where T : unmanaged\n```
//                                          ^ definition local 6
//                                            enclosing_range 56:4-58:5
//                                            documentation ```cs\nT\n```
//                                                   ^ reference local 6
//                                                     enclosing_range 56:51-56:52
      {
      }

      public class ClassConstraintClass<T> where T : class
//                 ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#ClassConstraintClass#
//                                      enclosing_range 60:4-62:5
//                                      documentation ```cs\nclass ClassConstraintClass<T> where T : class\n```
//                                      ^ definition local 7
//                                        enclosing_range 60:4-62:5
//                                        documentation ```cs\nT\n```
//                                               ^ reference local 7
//                                                 enclosing_range 60:47-60:48
      {
      }

      public class NonNullableConstraintClass<T> where T : notnull
//                 ^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#NonNullableConstraintClass#
//                                            enclosing_range 64:4-66:5
//                                            documentation ```cs\nclass NonNullableConstraintClass<T> where T : notnull\n```
//                                            ^ definition local 8
//                                              enclosing_range 64:4-66:5
//                                              documentation ```cs\nT\n```
//                                                     ^ reference local 8
//                                                       enclosing_range 64:53-64:54
      {
      }

      public class NewConstraintClass<T> where T : new()
//                 ^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#NewConstraintClass#
//                                    enclosing_range 68:4-70:5
//                                    documentation ```cs\nclass NewConstraintClass<T> where T : new()\n```
//                                    ^ definition local 9
//                                      enclosing_range 68:4-70:5
//                                      documentation ```cs\nT\n```
//                                             ^ reference local 9
//                                               enclosing_range 68:45-68:46
      {
      }

      public class TypeParameterConstraintClass<T> where T : SomeInterface
//                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#TypeParameterConstraintClass#
//                                              enclosing_range 72:4-74:5
//                                              documentation ```cs\nclass TypeParameterConstraintClass<T> where T : SomeInterface\n```
//                                              ^ definition local 10
//                                                enclosing_range 72:4-74:5
//                                                documentation ```cs\nT\n```
//                                                       ^ reference local 10
//                                                         enclosing_range 72:55-72:56
//                                                           ^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/SomeInterface#
//                                                                         enclosing_range 72:59-72:72
      {
      }

      private class MultipleTypeParameterConstraintsClass<T1, T2> where T1 : SomeInterface, SomeInterface2, new()
//                  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#MultipleTypeParameterConstraintsClass#
//                                                        enclosing_range 76:4-79:5
//                                                        documentation ```cs\nclass MultipleTypeParameterConstraintsClass<T1, T2> where T1 : SomeInterface, SomeInterface2, new() where T2 : SomeInterface2\n```
//                                                        ^^ definition local 11
//                                                           enclosing_range 76:4-79:5
//                                                           documentation ```cs\nT1\n```
//                                                            ^^ definition local 12
//                                                               enclosing_range 76:4-79:5
//                                                               documentation ```cs\nT2\n```
//                                                                      ^^ reference local 11
//                                                                         enclosing_range 76:70-76:72
//                                                                           ^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/SomeInterface#
//                                                                                         enclosing_range 76:75-76:88
//                                                                                          ^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/SomeInterface2#
//                                                                                                         enclosing_range 76:90-76:104
          where T2 : SomeInterface2
//              ^^ reference local 12
//                 enclosing_range 77:14-77:16
//                   ^^^^^^^^^^^^^^ reference scip-dotnet nuget . . Main/SomeInterface2#
//                                  enclosing_range 77:19-77:33
      {
      }

      class IndexClass
//          ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Classes#IndexClass#
//                     enclosing_range 81:4-90:5
//                     documentation ```cs\nclass IndexClass\n```
      {
          private bool a;
//                     ^ definition scip-dotnet nuget . . Main/Classes#IndexClass#a.
//                       enclosing_range 83:8-83:23
//                       documentation ```cs\nprivate bool IndexClass.a\n```
//                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#

          public bool this[int index]
//                             ^^^^^ definition scip-dotnet nuget . . Main/Classes#IndexClass#`this[]`.(index)
//                                   enclosing_range 85:8-89:9
//                                   documentation ```cs\nint index\n```
//                                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          {
              get { return a; }
//                         ^ reference scip-dotnet nuget . . Main/Classes#IndexClass#a.
//                           enclosing_range 87:25-87:26
              set { a = value; }
//                  ^ reference scip-dotnet nuget . . Main/Classes#IndexClass#a.
//                    enclosing_range 88:18-88:27
//                      ^^^^^ reference scip-dotnet nuget . . Main/Classes#IndexClass#set_Item().(value)
//                            enclosing_range 88:18-88:27
          }
      }

  }

  public interface SomeInterface
//                 ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/SomeInterface#
//                               enclosing_range 94:0-96:1
//                               documentation ```cs\ninterface SomeInterface\n```
  {
  }

  internal interface SomeInterface2
//                   ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/SomeInterface2#
//                                  enclosing_range 98:0-100:1
//                                  documentation ```cs\ninterface SomeInterface2\n```
  {
  }
