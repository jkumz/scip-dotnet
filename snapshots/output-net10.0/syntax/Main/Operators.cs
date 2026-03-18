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
  public class Operators
//             ^^^^^^^^^ definition scip-dotnet nuget . . Main/Operators#
//                       enclosing_range 4:0-65:1
//                       documentation ```cs\nclass Operators\n```
//                       kind Class
  {
      class PlusMinus
//          ^^^^^^^^^ definition scip-dotnet nuget . . Main/Operators#PlusMinus#
//                    enclosing_range 7:4-23:5
//                    documentation ```cs\nclass PlusMinus\n```
//                    kind Class
      {
          public static int operator +(PlusMinus a)
//                                     ^^^^^^^^^ read_access scip-dotnet nuget . . Main/Operators#PlusMinus#
//                                               enclosing_range 9:37-9:46
//                                               ^ definition scip-dotnet nuget . . Main/Operators#PlusMinus#op_UnaryPlus().(a)
//                                                 enclosing_range 9:8-12:9
//                                                 documentation ```cs\nPlusMinus a\n```
//                                                 kind Parameter
//                                                 relationship type_definition scip-dotnet nuget . . Main/Operators#PlusMinus#
          {
              return 0;
          }

          public static int operator +(PlusMinus a, PlusMinus b)
//                                     ^^^^^^^^^ read_access scip-dotnet nuget . . Main/Operators#PlusMinus#
//                                               enclosing_range 14:37-14:46
//                                               ^ definition scip-dotnet nuget . . Main/Operators#PlusMinus#op_Addition().(a)
//                                                 enclosing_range 14:8-17:9
//                                                 documentation ```cs\nPlusMinus a\n```
//                                                 kind Parameter
//                                                 relationship type_definition scip-dotnet nuget . . Main/Operators#PlusMinus#
//                                                  ^^^^^^^^^ read_access scip-dotnet nuget . . Main/Operators#PlusMinus#
//                                                            enclosing_range 14:50-14:59
//                                                            ^ definition scip-dotnet nuget . . Main/Operators#PlusMinus#op_Addition().(b)
//                                                              enclosing_range 14:8-17:9
//                                                              documentation ```cs\nPlusMinus b\n```
//                                                              kind Parameter
//                                                              relationship type_definition scip-dotnet nuget . . Main/Operators#PlusMinus#
          {
              return 0;
          }

          public static int operator -(PlusMinus a)
//                                     ^^^^^^^^^ read_access scip-dotnet nuget . . Main/Operators#PlusMinus#
//                                               enclosing_range 19:37-19:46
//                                               ^ definition scip-dotnet nuget . . Main/Operators#PlusMinus#op_UnaryNegation().(a)
//                                                 enclosing_range 19:8-22:9
//                                                 documentation ```cs\nPlusMinus a\n```
//                                                 kind Parameter
//                                                 relationship type_definition scip-dotnet nuget . . Main/Operators#PlusMinus#
          {
              return 0;
          }
      }

      class TrueFalse
//          ^^^^^^^^^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#
//                    enclosing_range 25:4-64:5
//                    documentation ```cs\nclass TrueFalse\n```
//                    kind Class
      {
          protected bool Equals(TrueFalse other)
//                       ^^^^^^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#Equals().
//                              enclosing_range 27:8-30:9
//                              documentation ```cs\nprotected bool TrueFalse.Equals(TrueFalse other)\n```
//                              kind Method
//                              ^^^^^^^^^ read_access scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                        enclosing_range 27:30-27:39
//                                        ^^^^^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#Equals().(other)
//                                              enclosing_range 27:8-30:9
//                                              documentation ```cs\nTrueFalse other\n```
//                                              kind Parameter
//                                              relationship type_definition scip-dotnet nuget . . Main/Operators#TrueFalse#
          {
              throw new NotImplementedException();
//                      ^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
//                                              enclosing_range 29:18-29:47
          }

          public override bool Equals(object? obj)
//                             ^^^^^^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#Equals(+1).
//                                    enclosing_range 32:8-38:9
//                                    documentation ```cs\npublic override bool TrueFalse.Equals(object? obj)\n```
//                                    kind Method
//                                    relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#Equals().
//                                            ^^^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#Equals(+1).(obj)
//                                                enclosing_range 32:8-38:9
//                                                documentation ```cs\nobject? obj\n```
//                                                kind Parameter
          {
              if (ReferenceEquals(null, obj)) return false;
//                ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#ReferenceEquals().
//                                enclosing_range 34:16-34:42
//                                      ^^^ read_access scip-dotnet nuget . . Main/Operators#TrueFalse#Equals(+1).(obj)
//                                          enclosing_range 34:38-34:41
              if (ReferenceEquals(this, obj)) return true;
//                ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#ReferenceEquals().
//                                enclosing_range 35:16-35:42
//                                      ^^^ read_access scip-dotnet nuget . . Main/Operators#TrueFalse#Equals(+1).(obj)
//                                          enclosing_range 35:38-35:41
              if (obj.GetType() != this.GetType()) return false;
//                ^^^ read_access scip-dotnet nuget . . Main/Operators#TrueFalse#Equals(+1).(obj)
//                    enclosing_range 36:16-36:29
//                    ^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#GetType().
//                            enclosing_range 36:16-36:29
//                                      ^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#GetType().
//                                              enclosing_range 36:33-36:47
              return Equals((TrueFalse)obj);
//                   ^^^^^^ read_access scip-dotnet nuget . . Main/Operators#TrueFalse#Equals().
//                          enclosing_range 37:19-37:41
//                           ^^^^^^^^^ read_access scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                     enclosing_range 37:26-37:40
//                                     ^^^ read_access scip-dotnet nuget . . Main/Operators#TrueFalse#Equals(+1).(obj)
//                                         enclosing_range 37:26-37:40
          }

          public override int GetHashCode()
//                            ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#GetHashCode().
//                                        enclosing_range 40:8-43:9
//                                        documentation ```cs\npublic override int TrueFalse.GetHashCode()\n```
//                                        kind Method
//                                        relationship implementation reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Object#GetHashCode().
          {
              throw new NotImplementedException();
//                      ^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
//                                              enclosing_range 42:18-42:47
          }

          public static bool operator true(TrueFalse a)
//                                         ^^^^^^^^^ read_access scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                                   enclosing_range 45:41-45:50
//                                                   ^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#op_True().(a)
//                                                     enclosing_range 45:8-48:9
//                                                     documentation ```cs\nTrueFalse a\n```
//                                                     kind Parameter
//                                                     relationship type_definition scip-dotnet nuget . . Main/Operators#TrueFalse#
          {
              return true;
          }

          public static bool operator false(TrueFalse a)
//                                          ^^^^^^^^^ read_access scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                                    enclosing_range 50:42-50:51
//                                                    ^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#op_False().(a)
//                                                      enclosing_range 50:8-53:9
//                                                      documentation ```cs\nTrueFalse a\n```
//                                                      kind Parameter
//                                                      relationship type_definition scip-dotnet nuget . . Main/Operators#TrueFalse#
          {
              return false;
          }

          public static bool operator !=(TrueFalse a, TrueFalse b)
//                                       ^^^^^^^^^ read_access scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                                 enclosing_range 55:39-55:48
//                                                 ^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#op_Inequality().(a)
//                                                   enclosing_range 55:8-58:9
//                                                   documentation ```cs\nTrueFalse a\n```
//                                                   kind Parameter
//                                                   relationship type_definition scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                                    ^^^^^^^^^ read_access scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                                              enclosing_range 55:52-55:61
//                                                              ^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#op_Inequality().(b)
//                                                                enclosing_range 55:8-58:9
//                                                                documentation ```cs\nTrueFalse b\n```
//                                                                kind Parameter
//                                                                relationship type_definition scip-dotnet nuget . . Main/Operators#TrueFalse#
          {
              return true;
          }

          public static bool operator ==(TrueFalse a, TrueFalse b)
//                                       ^^^^^^^^^ read_access scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                                 enclosing_range 60:39-60:48
//                                                 ^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#op_Equality().(a)
//                                                   enclosing_range 60:8-63:9
//                                                   documentation ```cs\nTrueFalse a\n```
//                                                   kind Parameter
//                                                   relationship type_definition scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                                    ^^^^^^^^^ read_access scip-dotnet nuget . . Main/Operators#TrueFalse#
//                                                              enclosing_range 60:52-60:61
//                                                              ^ definition scip-dotnet nuget . . Main/Operators#TrueFalse#op_Equality().(b)
//                                                                enclosing_range 60:8-63:9
//                                                                documentation ```cs\nTrueFalse b\n```
//                                                                kind Parameter
//                                                                relationship type_definition scip-dotnet nuget . . Main/Operators#TrueFalse#
          {
              return true;
          }
      }
  }
