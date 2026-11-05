  namespace SymbolKinds
//          ^^^^^^^^^^^ reference scip-dotnet nuget . . SymbolKinds/
//                      enclosing_range 0:10-0:21
  {
      public interface IShape
//                     ^^^^^^ definition scip-dotnet nuget . . SymbolKinds/IShape#
//                            enclosing_range 2:4-4:5
//                            documentation ```cs\ninterface IShape\n```
      {
      }

      public struct Point
//                  ^^^^^ definition scip-dotnet nuget . . SymbolKinds/Point#
//                        enclosing_range 6:4-8:5
//                        documentation ```cs\nstruct Point\n```
      {
      }

      public enum Color
//                ^^^^^ definition scip-dotnet nuget . . SymbolKinds/Color#
//                      enclosing_range 10:4-13:5
//                      documentation ```cs\nenum Color\n```
//                      relationship implementation scip-dotnet nuget System.Runtime 8.0.0.0 System/IComparable#
//                      relationship implementation scip-dotnet nuget System.Runtime 8.0.0.0 System/IConvertible#
//                      relationship implementation scip-dotnet nuget System.Runtime 8.0.0.0 System/ISpanFormattable#
//                      relationship implementation scip-dotnet nuget System.Runtime 8.0.0.0 System/IFormattable#
      {
          Red
//        ^^^ definition scip-dotnet nuget . . SymbolKinds/Color#Red.
//            enclosing_range 12:8-12:11
//            documentation ```cs\nColor.Red = 0\n```
//            relationship type_definition scip-dotnet nuget . . SymbolKinds/Color#
      }

      public delegate void Handler();
//                         ^^^^^^^ definition scip-dotnet nuget . . SymbolKinds/Handler#
//                                 enclosing_range 15:4-15:35
//                                 documentation ```cs\ndelegate void Handler()\n```
//                                 relationship implementation scip-dotnet nuget System.Runtime 8.0.0.0 System/MulticastDelegate#
//                                 relationship implementation scip-dotnet nuget System.Runtime 8.0.0.0 System/Delegate#
//                                 relationship implementation scip-dotnet nuget System.Runtime 8.0.0.0 System/ICloneable#
//                                 relationship implementation scip-dotnet nuget System.Runtime 8.0.0.0 Serialization/ISerializable#

      public class Kinds
//                 ^^^^^ definition scip-dotnet nuget . . SymbolKinds/Kinds#
//                       enclosing_range 17:4-41:5
//                       documentation ```cs\nclass Kinds\n```
      {
          public const int Constant = 1;
//                         ^^^^^^^^ definition scip-dotnet nuget . . SymbolKinds/Kinds#Constant.
//                                  enclosing_range 19:8-19:38
//                                  documentation ```cs\npublic const int Kinds.Constant = 1\n```
//                                  relationship type_definition scip-dotnet nuget System.Runtime 8.0.0.0 System/Int32#
          public int Field;
//                   ^^^^^ definition scip-dotnet nuget . . SymbolKinds/Kinds#Field.
//                         enclosing_range 20:8-20:25
//                         documentation ```cs\npublic int Kinds.Field\n```
//                         relationship type_definition scip-dotnet nuget System.Runtime 8.0.0.0 System/Int32#
          public static int StaticField;
//                          ^^^^^^^^^^^ definition scip-dotnet nuget . . SymbolKinds/Kinds#StaticField.
//                                      enclosing_range 21:8-21:38
//                                      documentation ```cs\npublic static int Kinds.StaticField\n```
//                                      relationship type_definition scip-dotnet nuget System.Runtime 8.0.0.0 System/Int32#

          public Kinds()
//               ^^^^^ definition scip-dotnet nuget . . SymbolKinds/Kinds#`.ctor`().
//                     enclosing_range 23:8-25:9
//                     documentation ```cs\npublic Kinds.Kinds()\n```
          {
          }

          public int Property { get; set; }
//                   ^^^^^^^^ definition scip-dotnet nuget . . SymbolKinds/Kinds#Property.
//                            enclosing_range 27:8-27:41
//                            documentation ```cs\npublic int Kinds.Property { get; set; }\n```
//                            relationship type_definition scip-dotnet nuget System.Runtime 8.0.0.0 System/Int32#
          public static int StaticProperty { get; set; }
//                          ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . SymbolKinds/Kinds#StaticProperty.
//                                         enclosing_range 28:8-28:54
//                                         documentation ```cs\npublic static int Kinds.StaticProperty { get; set; }\n```
//                                         relationship type_definition scip-dotnet nuget System.Runtime 8.0.0.0 System/Int32#

          public event Handler? Event;
//                     ^^^^^^^ reference scip-dotnet nuget . . SymbolKinds/Handler#
//                             enclosing_range 30:21-30:29
//                              ^^^^^ definition scip-dotnet nuget . . SymbolKinds/Kinds#Event#
//                                    enclosing_range 30:8-30:36
//                                    documentation ```cs\npublic event Handler? Kinds.Event\n```
//                                    relationship type_definition scip-dotnet nuget . . SymbolKinds/Handler#
          public static event Handler? StaticEvent;
//                            ^^^^^^^ reference scip-dotnet nuget . . SymbolKinds/Handler#
//                                    enclosing_range 31:28-31:36
//                                     ^^^^^^^^^^^ definition scip-dotnet nuget . . SymbolKinds/Kinds#StaticEvent#
//                                                 enclosing_range 31:8-31:49
//                                                 documentation ```cs\npublic static event Handler? Kinds.StaticEvent\n```
//                                                 relationship type_definition scip-dotnet nuget . . SymbolKinds/Handler#

          public void Method()
//                    ^^^^^^ definition scip-dotnet nuget . . SymbolKinds/Kinds#Method().
//                           enclosing_range 33:8-36:9
//                           documentation ```cs\npublic void Kinds.Method()\n```
          {
              /* 🚀 */ StaticMethod();
//                     ^^^^^^^^^^^^ reference scip-dotnet nuget . . SymbolKinds/Kinds#StaticMethod().
//                                  enclosing_range 35:21-35:35
          }

          public static void StaticMethod()
//                           ^^^^^^^^^^^^ definition scip-dotnet nuget . . SymbolKinds/Kinds#StaticMethod().
//                                        enclosing_range 38:8-40:9
//                                        documentation ```cs\npublic static void Kinds.StaticMethod()\n```
          {
          }
      }

      public static class KindsExtensions
//                        ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . SymbolKinds/KindsExtensions#
//                                        enclosing_range 43:4-48:5
//                                        documentation ```cs\nclass KindsExtensions\n```
      {
          public static void Extension(this Kinds kinds)
//                           ^^^^^^^^^ definition scip-dotnet nuget . . SymbolKinds/KindsExtensions#Extension().
//                                     enclosing_range 45:8-47:9
//                                     documentation ```cs\npublic void Kinds.Extension()\n```
//                                          ^^^^^ reference scip-dotnet nuget . . SymbolKinds/Kinds#
//                                                enclosing_range 45:42-45:47
//                                                ^^^^^ definition scip-dotnet nuget . . SymbolKinds/KindsExtensions#Extension().(kinds)
//                                                      enclosing_range 45:8-47:9
//                                                      documentation ```cs\nKinds kinds\n```
//                                                      relationship type_definition scip-dotnet nuget . . SymbolKinds/Kinds#
          {
          }
      }
  }
