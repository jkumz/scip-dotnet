  using System.Diagnostics.CodeAnalysis;
//      ^^^^^^ read_access scip-dotnet nuget . . System/
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
//             ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
//                         ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/

  namespace Main;
//          ^^^^ read_access scip-dotnet nuget . . Main/
//               enclosing_range 2:0-339:1

  [SuppressMessage("ReSharper", "all")]
// ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
//                 enclosing_range 4:0-339:1
  public class Expressions
//             ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#
//                         enclosing_range 2:0-339:1
//                         documentation ```cs\nclass Expressions\n```
//                         kind Class
  {
      void AssignmentToPrefixUnaryExpressions()
//         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AssignmentToPrefixUnaryExpressions().
//                                            enclosing_range 4:0-339:1
//                                            documentation ```cs\nprivate void Expressions.AssignmentToPrefixUnaryExpressions()\n```
//                                            kind Method
      {
          var a = 42;
//            ^ definition local 0
//              enclosing_range 7:4-22:5
//              documentation ```cs\nint a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          var b = 42;
//            ^ definition local 1
//              enclosing_range 7:4-22:5
//              documentation ```cs\nint b\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          a = +a;
//        ^ write_access local 0
//          enclosing_range 7:4-22:5
//             ^ read_access local 0
//               enclosing_range 7:4-22:5
          a = -a;
//        ^ write_access local 0
//          enclosing_range 7:4-22:5
//             ^ read_access local 0
//               enclosing_range 7:4-22:5
          a = ~a;
//        ^ write_access local 0
//          enclosing_range 7:4-22:5
//             ^ read_access local 0
//               enclosing_range 7:4-22:5
          a = ++a;
//        ^ write_access local 0
//          enclosing_range 7:4-22:5
//              ^ write_access local 0
//                enclosing_range 7:4-22:5
          a = --a;
//        ^ write_access local 0
//          enclosing_range 7:4-22:5
//              ^ write_access local 0
//                enclosing_range 7:4-22:5
          a = a++;
//        ^ write_access local 0
//          enclosing_range 7:4-22:5
//            ^ write_access local 0
//              enclosing_range 7:4-22:5
          a = a--;
//        ^ write_access local 0
//          enclosing_range 7:4-22:5
//            ^ write_access local 0
//              enclosing_range 7:4-22:5
          b = a!;
//        ^ write_access local 1
//          enclosing_range 7:4-22:5
//            ^ read_access local 0
//              enclosing_range 7:4-22:5

          var c = true;
//            ^ definition local 2
//              enclosing_range 7:4-22:5
//              documentation ```cs\nbool c\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
          c = !c;
//        ^ write_access local 2
//          enclosing_range 7:4-22:5
//             ^ read_access local 2
//               enclosing_range 7:4-22:5
      }

      void AssignmentToPrefixBinaryExpressions()
//         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AssignmentToPrefixBinaryExpressions().
//                                             enclosing_range 4:0-339:1
//                                             documentation ```cs\nprivate void Expressions.AssignmentToPrefixBinaryExpressions()\n```
//                                             kind Method
      {
          var a = 42;
//            ^ definition local 3
//              enclosing_range 24:4-38:5
//              documentation ```cs\nint a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          a = a + a;
//        ^ write_access local 3
//          enclosing_range 24:4-38:5
//            ^ read_access local 3
//              enclosing_range 24:4-38:5
//                ^ read_access local 3
//                  enclosing_range 24:4-38:5
          a = a - a;
//        ^ write_access local 3
//          enclosing_range 24:4-38:5
//            ^ read_access local 3
//              enclosing_range 24:4-38:5
//                ^ read_access local 3
//                  enclosing_range 24:4-38:5
          a = a * a;
//        ^ write_access local 3
//          enclosing_range 24:4-38:5
//            ^ read_access local 3
//              enclosing_range 24:4-38:5
//                ^ read_access local 3
//                  enclosing_range 24:4-38:5
          a = a / a;
//        ^ write_access local 3
//          enclosing_range 24:4-38:5
//            ^ read_access local 3
//              enclosing_range 24:4-38:5
//                ^ read_access local 3
//                  enclosing_range 24:4-38:5
          a = a % a;
//        ^ write_access local 3
//          enclosing_range 24:4-38:5
//            ^ read_access local 3
//              enclosing_range 24:4-38:5
//                ^ read_access local 3
//                  enclosing_range 24:4-38:5
          a = a & a;
//        ^ write_access local 3
//          enclosing_range 24:4-38:5
//            ^ read_access local 3
//              enclosing_range 24:4-38:5
//                ^ read_access local 3
//                  enclosing_range 24:4-38:5
          a = a | a;
//        ^ write_access local 3
//          enclosing_range 24:4-38:5
//            ^ read_access local 3
//              enclosing_range 24:4-38:5
//                ^ read_access local 3
//                  enclosing_range 24:4-38:5
          a = a ^ a;
//        ^ write_access local 3
//          enclosing_range 24:4-38:5
//            ^ read_access local 3
//              enclosing_range 24:4-38:5
//                ^ read_access local 3
//                  enclosing_range 24:4-38:5
          a = a >> a;
//        ^ write_access local 3
//          enclosing_range 24:4-38:5
//            ^ read_access local 3
//              enclosing_range 24:4-38:5
//                 ^ read_access local 3
//                   enclosing_range 24:4-38:5
          a = a << a;
//        ^ write_access local 3
//          enclosing_range 24:4-38:5
//            ^ read_access local 3
//              enclosing_range 24:4-38:5
//                 ^ read_access local 3
//                   enclosing_range 24:4-38:5
          a = a >>> a;
//        ^ write_access local 3
//          enclosing_range 24:4-38:5
//            ^ read_access local 3
//              enclosing_range 24:4-38:5
//                  ^ read_access local 3
//                    enclosing_range 24:4-38:5
      }

      void AssignmentToBinaryEqualityExpression()
//         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AssignmentToBinaryEqualityExpression().
//                                              enclosing_range 4:0-339:1
//                                              documentation ```cs\nprivate void Expressions.AssignmentToBinaryEqualityExpression()\n```
//                                              kind Method
      {
          var a = true;
//            ^ definition local 4
//              enclosing_range 40:4-52:5
//              documentation ```cs\nbool a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
          var b = true;
//            ^ definition local 5
//              enclosing_range 40:4-52:5
//              documentation ```cs\nbool b\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
          var c = 42;
//            ^ definition local 6
//              enclosing_range 40:4-52:5
//              documentation ```cs\nint c\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          var d = 42;
//            ^ definition local 7
//              enclosing_range 40:4-52:5
//              documentation ```cs\nint d\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          a = a == b;
//        ^ write_access local 4
//          enclosing_range 40:4-52:5
//            ^ read_access local 4
//              enclosing_range 40:4-52:5
//                 ^ read_access local 5
//                   enclosing_range 40:4-52:5
          a = a != b;
//        ^ write_access local 4
//          enclosing_range 40:4-52:5
//            ^ read_access local 4
//              enclosing_range 40:4-52:5
//                 ^ read_access local 5
//                   enclosing_range 40:4-52:5
          a = c < d;
//        ^ write_access local 4
//          enclosing_range 40:4-52:5
//            ^ read_access local 6
//              enclosing_range 40:4-52:5
//                ^ read_access local 7
//                  enclosing_range 40:4-52:5
          a = c <= d;
//        ^ write_access local 4
//          enclosing_range 40:4-52:5
//            ^ read_access local 6
//              enclosing_range 40:4-52:5
//                 ^ read_access local 7
//                   enclosing_range 40:4-52:5
          a = c > d;
//        ^ write_access local 4
//          enclosing_range 40:4-52:5
//            ^ read_access local 6
//              enclosing_range 40:4-52:5
//                ^ read_access local 7
//                  enclosing_range 40:4-52:5
          a = c >= d;
//        ^ write_access local 4
//          enclosing_range 40:4-52:5
//            ^ read_access local 6
//              enclosing_range 40:4-52:5
//                 ^ read_access local 7
//                   enclosing_range 40:4-52:5
      }

      void AssignmentToBinaryExpression()
//         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AssignmentToBinaryExpression().
//                                      enclosing_range 4:0-339:1
//                                      documentation ```cs\nprivate void Expressions.AssignmentToBinaryExpression()\n```
//                                      kind Method
      {
          var a = 42;
//            ^ definition local 8
//              enclosing_range 54:4-67:5
//              documentation ```cs\nint a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          a += a;
//        ^ write_access local 8
//          enclosing_range 54:4-67:5
//             ^ read_access local 8
//               enclosing_range 54:4-67:5
          a -= a;
//        ^ write_access local 8
//          enclosing_range 54:4-67:5
//             ^ read_access local 8
//               enclosing_range 54:4-67:5
          a *= a;
//        ^ write_access local 8
//          enclosing_range 54:4-67:5
//             ^ read_access local 8
//               enclosing_range 54:4-67:5
          a /= a;
//        ^ write_access local 8
//          enclosing_range 54:4-67:5
//             ^ read_access local 8
//               enclosing_range 54:4-67:5
          a %= a;
//        ^ write_access local 8
//          enclosing_range 54:4-67:5
//             ^ read_access local 8
//               enclosing_range 54:4-67:5
          a++;
//        ^ write_access local 8
//          enclosing_range 54:4-67:5
          a--;
//        ^ write_access local 8
//          enclosing_range 54:4-67:5
          a <<= a;
//        ^ write_access local 8
//          enclosing_range 54:4-67:5
//              ^ read_access local 8
//                enclosing_range 54:4-67:5
          a >>= a;
//        ^ write_access local 8
//          enclosing_range 54:4-67:5
//              ^ read_access local 8
//                enclosing_range 54:4-67:5
          a >>>= a;
//        ^ write_access local 8
//          enclosing_range 54:4-67:5
//               ^ read_access local 8
//                 enclosing_range 54:4-67:5
      }

      struct Struct
//           ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Struct#
//                  enclosing_range 4:0-339:1
//                  documentation ```cs\nstruct Struct\n```
//                  kind Struct
      {
          public int Property;
//                   ^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Struct#Property.
//                            enclosing_range 71:8-71:28
//                            documentation ```cs\npublic int Struct.Property\n```
//                            kind Field
//                            relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      }

      struct IndexedClass
//           ^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#IndexedClass#
//                        enclosing_range 4:0-339:1
//                        documentation ```cs\nstruct IndexedClass\n```
//                        kind Struct
      {
          public int Property;
//                   ^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#IndexedClass#Property.
//                            enclosing_range 76:8-76:28
//                            documentation ```cs\npublic int IndexedClass.Property\n```
//                            kind Field
//                            relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#

          public int this[int index]
//                            ^^^^^ definition scip-dotnet nuget . . Main/Expressions#IndexedClass#`this[]`.(index)
//                                  enclosing_range 78:8-82:9
//                                  documentation ```cs\nint index\n```
//                                  kind Parameter
//                                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          {
              get { return Property; }
//                         ^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#IndexedClass#Property.
//                                  enclosing_range 78:8-82:9
              set { Property = value; }
//                  ^^^^^^^^ write_access scip-dotnet nuget . . Main/Expressions#IndexedClass#Property.
//                           enclosing_range 78:8-82:9
//                             ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#IndexedClass#set_Item().(value)
//                                   enclosing_range 78:8-82:9
          }
      }

      void AssignmentToLeftValueTypes()
//         ^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AssignmentToLeftValueTypes().
//                                    enclosing_range 4:0-339:1
//                                    documentation ```cs\nprivate void Expressions.AssignmentToLeftValueTypes()\n```
//                                    kind Method
      {
          (var a, var b) = (1, 2);
//             ^ definition local 9
//               enclosing_range 85:4-106:5
//               documentation ```cs\nint a\n```
//               kind Variable
//               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                    ^ definition local 10
//                      enclosing_range 85:4-106:5
//                      documentation ```cs\nint b\n```
//                      kind Variable
//                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          a = 1;
//        ^ write_access local 9
//          enclosing_range 85:4-106:5
          var c = new Struct { Property = 42 };
//            ^ definition local 11
//              enclosing_range 85:4-106:5
//              documentation ```cs\nStruct c\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget . . Main/Expressions#Struct#
//                    ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Struct#
//                           enclosing_range 85:4-106:5
//                             ^^^^^^^^ write_access scip-dotnet nuget . . Main/Expressions#Struct#Property.
//                                      enclosing_range 85:4-106:5
          c.Property = 1;
//        ^ read_access local 11
//          enclosing_range 85:4-106:5
//          ^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Struct#Property.
//                   enclosing_range 85:4-106:5
          var d = new IndexedClass();
//            ^ definition local 12
//              enclosing_range 85:4-106:5
//              documentation ```cs\nIndexedClass d\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget . . Main/Expressions#IndexedClass#
//                    ^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#IndexedClass#
//                                 enclosing_range 85:4-106:5
          d[b] = 1;
//        ^ read_access local 12
//          enclosing_range 85:4-106:5
//          ^ read_access local 10
//            enclosing_range 85:4-106:5
          (a, b) = (1, 2);
//         ^ read_access local 9
//           enclosing_range 85:4-106:5
//            ^ read_access local 10
//              enclosing_range 85:4-106:5
          var x = new IndexedClass
//            ^ definition local 13
//              enclosing_range 85:4-106:5
//              documentation ```cs\nIndexedClass x\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget . . Main/Expressions#IndexedClass#
//                    ^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#IndexedClass#
//                                 enclosing_range 85:4-106:5
          {
              Property = 1,
//            ^^^^^^^^ write_access scip-dotnet nuget . . Main/Expressions#IndexedClass#Property.
//                     enclosing_range 85:4-106:5
              [b] = 1
//             ^ read_access local 10
//               enclosing_range 85:4-106:5
          };
          (a) = 1;
//         ^ read_access local 9
//           enclosing_range 85:4-106:5
          unsafe
          {
              int myInt = 5;
//                ^^^^^ definition local 14
//                      enclosing_range 85:4-106:5
//                      documentation ```cs\nint myInt\n```
//                      kind Variable
//                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
              int* p = &myInt;
//                 ^ definition local 15
//                   enclosing_range 85:4-106:5
//                   documentation ```cs\nint* p\n```
//                   kind Variable
//                   relationship type_definition local 16
//                      ^^^^^ read_access local 14
//                            enclosing_range 85:4-106:5
              Console.WriteLine("myInt = {0}, *p = {1}", myInt, *p);
//            ^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                    enclosing_range 85:4-106:5
//                    ^^^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+14).
//                              enclosing_range 85:4-106:5
//                                                       ^^^^^ read_access local 14
//                                                             enclosing_range 85:4-106:5
//                                                               ^ read_access local 15
//                                                                 enclosing_range 85:4-106:5
          }
      }

      void TernaryExpression()
//         ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TernaryExpression().
//                           enclosing_range 4:0-339:1
//                           documentation ```cs\nprivate void Expressions.TernaryExpression()\n```
//                           kind Method
      {
          var x = true;
//            ^ definition local 17
//              enclosing_range 108:4-114:5
//              documentation ```cs\nbool x\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
          var y = x ? "foo" : "bar";
//            ^ definition local 18
//              enclosing_range 108:4-114:5
//              documentation ```cs\nstring? y\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
//                ^ read_access local 17
//                  enclosing_range 108:4-114:5
          object z = true;
//               ^ definition local 19
//                 enclosing_range 108:4-114:5
//                 documentation ```cs\nobject z\n```
//                 kind Variable
          var t = z is bool ? 42 : 41;
//            ^ definition local 20
//              enclosing_range 108:4-114:5
//              documentation ```cs\nint t\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                ^ read_access local 19
//                  enclosing_range 108:4-114:5
      }

      class Cast
//          ^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#
//               enclosing_range 4:0-339:1
//               documentation ```cs\nclass Cast\n```
//               kind Class
      {
          public Cast nested;
//               ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                    enclosing_range 118:8-118:27
//                    ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#nested.
//                           enclosing_range 118:8-118:27
//                           documentation ```cs\npublic Cast Cast.nested\n```
//                           kind Field
//                           relationship type_definition scip-dotnet nuget . . Main/Expressions#Cast#
          public Cast2 nested2;
//               ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#Cast2#
//                     enclosing_range 119:8-119:29
//                     ^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#nested2.
//                             enclosing_range 119:8-119:29
//                             documentation ```cs\npublic Cast2 Cast.nested2\n```
//                             kind Field
//                             relationship type_definition scip-dotnet nuget . . Main/Expressions#Cast#Cast2#

          public Cast plus(Cast other)
//               ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                    enclosing_range 121:8-125:9
//                    ^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#plus().
//                         enclosing_range 116:4-130:5
//                         documentation ```cs\npublic Cast Cast.plus(Cast other)\n```
//                         kind Method
//                         ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                              enclosing_range 121:8-125:9
//                              ^^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#plus().(other)
//                                    enclosing_range 121:8-125:9
//                                    documentation ```cs\nCast other\n```
//                                    kind Parameter
//                                    relationship type_definition scip-dotnet nuget . . Main/Expressions#Cast#
          {
              nested = other;
//            ^^^^^^ write_access scip-dotnet nuget . . Main/Expressions#Cast#nested.
//                   enclosing_range 121:8-125:9
//                     ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#plus().(other)
//                           enclosing_range 121:8-125:9
              return this;
          }

          public class Cast2
//                     ^^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#Cast2#
//                           enclosing_range 116:4-130:5
//                           documentation ```cs\nclass Cast2\n```
//                           kind Class
          {
          }
      }

      int CastExpressions()
//        ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#CastExpressions().
//                        enclosing_range 4:0-339:1
//                        documentation ```cs\nprivate int Expressions.CastExpressions()\n```
//                        kind Method
      {
          object a = new Cast();
//               ^ definition local 21
//                 enclosing_range 132:4-143:5
//                 documentation ```cs\nobject a\n```
//                 kind Variable
//                       ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                            enclosing_range 132:4-143:5
          object b = new Cast();
//               ^ definition local 22
//                 enclosing_range 132:4-143:5
//                 documentation ```cs\nobject b\n```
//                 kind Variable
//                       ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                            enclosing_range 132:4-143:5
          Cast c = ((Cast)a).plus((Cast)b);
//        ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//             enclosing_range 132:4-143:5
//             ^ definition local 23
//               enclosing_range 132:4-143:5
//               documentation ```cs\nCast c\n```
//               kind Variable
//               relationship type_definition scip-dotnet nuget . . Main/Expressions#Cast#
//                   ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                        enclosing_range 132:4-143:5
//                        ^ read_access local 21
//                          enclosing_range 132:4-143:5
//                           ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#plus().
//                                enclosing_range 132:4-143:5
//                                 ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                                      enclosing_range 132:4-143:5
//                                      ^ read_access local 22
//                                        enclosing_range 132:4-143:5
          Cast d = (Cast)new object[] { a, b }[0];
//        ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//             enclosing_range 132:4-143:5
//             ^ definition local 24
//               enclosing_range 132:4-143:5
//               documentation ```cs\nCast d\n```
//               kind Variable
//               relationship type_definition scip-dotnet nuget . . Main/Expressions#Cast#
//                  ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                       enclosing_range 132:4-143:5
//                                      ^ read_access local 21
//                                        enclosing_range 132:4-143:5
//                                         ^ read_access local 22
//                                           enclosing_range 132:4-143:5
          var e = (Cast.Cast2)(c.nested.nested2);
//            ^ definition local 25
//              enclosing_range 132:4-143:5
//              documentation ```cs\nCast2? e\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget . . Main/Expressions#Cast#Cast2#
//                 ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                      enclosing_range 132:4-143:5
//                      ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#Cast2#
//                            enclosing_range 132:4-143:5
//                             ^ read_access local 23
//                               enclosing_range 132:4-143:5
//                               ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#nested.
//                                      enclosing_range 132:4-143:5
//                                      ^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#nested2.
//                                              enclosing_range 132:4-143:5
          var f = (Int32)(1);
//            ^ definition local 26
//              enclosing_range 132:4-143:5
//              documentation ```cs\nint f\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                 ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                       enclosing_range 132:4-143:5
          var g = (Int32)(1);
//            ^ definition local 27
//              enclosing_range 132:4-143:5
//              documentation ```cs\nint g\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                 ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                       enclosing_range 132:4-143:5
          var h = (Int32)((1));
//            ^ definition local 28
//              enclosing_range 132:4-143:5
//              documentation ```cs\nint h\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                 ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                       enclosing_range 132:4-143:5
          return f + g + h;
//               ^ read_access local 26
//                 enclosing_range 132:4-143:5
//                   ^ read_access local 27
//                     enclosing_range 132:4-143:5
//                       ^ read_access local 28
//                         enclosing_range 132:4-143:5
      }

      object AnonymousObject()
//           ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AnonymousObject().
//                           enclosing_range 4:0-339:1
//                           documentation ```cs\nprivate object Expressions.AnonymousObject()\n```
//                           kind Method
      {
          var x = new { Helper = "" };
//            ^ definition local 29
//              enclosing_range 145:4-153:5
//              documentation ```cs\n<anonymous type: string Helper>? x\n```
//              kind Variable
//              relationship type_definition local 30
//                      ^^^^^^ read_access local 31
//                             enclosing_range 145:4-153:5
          var y = new
//            ^ definition local 32
//              enclosing_range 145:4-153:5
//              documentation ```cs\n<anonymous type: AnonymousType <anonymous type: string Helper> x>? y\n```
//              kind Variable
//              relationship type_definition local 33
          {
              x
//            ^ read_access local 29
//              enclosing_range 145:4-153:5
          };
          return y.x.Helper;
//               ^ read_access local 32
//                 enclosing_range 145:4-153:5
//                 ^ read_access local 34
//                   enclosing_range 145:4-153:5
//                   ^^^^^^ read_access local 31
//                          enclosing_range 145:4-153:5
      }

      class TargetType
//          ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TargetType#
//                     enclosing_range 4:0-339:1
//                     documentation ```cs\nclass TargetType\n```
//                     kind Class
      {
          public TargetType(string name)
//               ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TargetType#`.ctor`().
//                          enclosing_range 155:4-160:5
//                          documentation ```cs\npublic TargetType.TargetType(string name)\n```
//                          kind Constructor
//                                 ^^^^ definition scip-dotnet nuget . . Main/Expressions#TargetType#`.ctor`().(name)
//                                      enclosing_range 157:8-159:9
//                                      documentation ```cs\nstring name\n```
//                                      kind Parameter
//                                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
          {
          }
      }

      TargetType TargetTypeNew()
//    ^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#TargetType#
//               enclosing_range 162:4-166:5
//               ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TargetTypeNew().
//                             enclosing_range 4:0-339:1
//                             documentation ```cs\nprivate TargetType Expressions.TargetTypeNew()\n```
//                             kind Method
      {
          TargetType x = new("x");
//        ^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#TargetType#
//                   enclosing_range 162:4-166:5
//                   ^ definition local 35
//                     enclosing_range 162:4-166:5
//                     documentation ```cs\nTargetType x\n```
//                     kind Variable
//                     relationship type_definition scip-dotnet nuget . . Main/Expressions#TargetType#
          return x;
//               ^ read_access local 35
//                 enclosing_range 162:4-166:5
      }

      int Checked()
//        ^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Checked().
//                enclosing_range 4:0-339:1
//                documentation ```cs\nprivate int Expressions.Checked()\n```
//                kind Method
      {
          var three = checked(1 + 2);
//            ^^^^^ definition local 36
//                  enclosing_range 168:4-172:5
//                  documentation ```cs\nint three\n```
//                  kind Variable
//                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          return three;
//               ^^^^^ read_access local 36
//                     enclosing_range 168:4-172:5
      }

      class ObjectCreationClass
//          ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                              enclosing_range 4:0-339:1
//                              documentation ```cs\nclass ObjectCreationClass\n```
//                              kind Class
      {
          public D field;
//               ^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#
//                 enclosing_range 176:8-176:23
//                 ^^^^^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#field.
//                       enclosing_range 176:8-176:23
//                       documentation ```cs\npublic D ObjectCreationClass.field\n```
//                       kind Field
//                       relationship type_definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#

          public ObjectCreationClass(D field)
//               ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#`.ctor`().
//                                   enclosing_range 174:4-189:5
//                                   documentation ```cs\npublic ObjectCreationClass.ObjectCreationClass(D field)\n```
//                                   kind Constructor
//                                   ^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#
//                                     enclosing_range 178:8-181:9
//                                     ^^^^^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#`.ctor`().(field)
//                                           enclosing_range 178:8-181:9
//                                           documentation ```cs\nD field\n```
//                                           kind Parameter
//                                           relationship type_definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#
          {
              this.field = field;
//                 ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#field.
//                       enclosing_range 178:8-181:9
//                         ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#`.ctor`().(field)
//                               enclosing_range 178:8-181:9
          }

          public class D
//                     ^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#
//                       enclosing_range 174:4-189:5
//                       documentation ```cs\nclass D\n```
//                       kind Class
          {
              public D(int a, string b)
//                   ^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#`.ctor`().
//                     enclosing_range 183:8-188:9
//                     documentation ```cs\npublic D.D(int a, string b)\n```
//                     kind Constructor
//                         ^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#`.ctor`().(a)
//                           enclosing_range 185:12-187:13
//                           documentation ```cs\nint a\n```
//                           kind Parameter
//                           relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                                   ^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#`.ctor`().(b)
//                                     enclosing_range 185:12-187:13
//                                     documentation ```cs\nstring b\n```
//                                     kind Parameter
//                                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
              {
              }
          }
      }

      void ObjectCreation()
//         ^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreation().
//                        enclosing_range 4:0-339:1
//                        documentation ```cs\nprivate void Expressions.ObjectCreation()\n```
//                        kind Method
      {
          var a = new ObjectCreationClass.D(1, "hi");
//            ^ definition local 37
//              enclosing_range 191:4-200:5
//              documentation ```cs\nD? a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#
//                    ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                                        enclosing_range 191:4-200:5
//                                        ^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#
//                                          enclosing_range 191:4-200:5
          var b = new ObjectCreationClass(a)
//            ^ definition local 38
//              enclosing_range 191:4-200:5
//              documentation ```cs\nObjectCreationClass? b\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                    ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                                        enclosing_range 191:4-200:5
//                                        ^ read_access local 37
//                                          enclosing_range 191:4-200:5
          {
              field = a,
//            ^^^^^ write_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#field.
//                  enclosing_range 191:4-200:5
//                    ^ read_access local 37
//                      enclosing_range 191:4-200:5
          };
          b = new ObjectCreationClass(a);
//        ^ write_access local 38
//          enclosing_range 191:4-200:5
//                ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                                    enclosing_range 191:4-200:5
//                                    ^ read_access local 37
//                                      enclosing_range 191:4-200:5
          b = new ObjectCreationClass(a) { };
//        ^ write_access local 38
//          enclosing_range 191:4-200:5
//                ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                                    enclosing_range 191:4-200:5
//                                    ^ read_access local 37
//                                      enclosing_range 191:4-200:5
      }

      class NamedParametersClass
//          ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#
//                               enclosing_range 4:0-339:1
//                               documentation ```cs\nclass NamedParametersClass\n```
//                               kind Class
      {
          public int A;
//                   ^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#A.
//                     enclosing_range 204:8-204:21
//                     documentation ```cs\npublic int NamedParametersClass.A\n```
//                     kind Field
//                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          public string B;
//                      ^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#B.
//                        enclosing_range 205:8-205:24
//                        documentation ```cs\npublic string NamedParametersClass.B\n```
//                        kind Field
//                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#

          public NamedParametersClass(int a, string b)
//               ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().
//                                    enclosing_range 202:4-218:5
//                                    documentation ```cs\npublic NamedParametersClass.NamedParametersClass(int a, string b)\n```
//                                    kind Constructor
//                                        ^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(a)
//                                          enclosing_range 207:8-211:9
//                                          documentation ```cs\nint a\n```
//                                          kind Parameter
//                                          relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                                                  ^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(b)
//                                                    enclosing_range 207:8-211:9
//                                                    documentation ```cs\nstring b\n```
//                                                    kind Parameter
//                                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
          {
              A = a;
//            ^ write_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#A.
//              enclosing_range 207:8-211:9
//                ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(a)
//                  enclosing_range 207:8-211:9
              B = b;
//            ^ write_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#B.
//              enclosing_range 207:8-211:9
//                ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(b)
//                  enclosing_range 207:8-211:9
          }

          public void Update(int a, string b)
//                    ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().
//                           enclosing_range 202:4-218:5
//                           documentation ```cs\npublic void NamedParametersClass.Update(int a, string b)\n```
//                           kind Method
//                               ^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(a)
//                                 enclosing_range 213:8-217:9
//                                 documentation ```cs\nint a\n```
//                                 kind Parameter
//                                 relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                                         ^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(b)
//                                           enclosing_range 213:8-217:9
//                                           documentation ```cs\nstring b\n```
//                                           kind Parameter
//                                           relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
          {
              A = a;
//            ^ write_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#A.
//              enclosing_range 213:8-217:9
//                ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(a)
//                  enclosing_range 213:8-217:9
              B = b;
//            ^ write_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#B.
//              enclosing_range 213:8-217:9
//                ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(b)
//                  enclosing_range 213:8-217:9
          }
      }

      NamedParametersClass NamedParameters()
//    ^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#
//                         enclosing_range 220:4-225:5
//                         ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#NamedParameters().
//                                         enclosing_range 4:0-339:1
//                                         documentation ```cs\nprivate NamedParametersClass Expressions.NamedParameters()\n```
//                                         kind Method
      {
          var a = new NamedParametersClass(b: "hi", a: 1);
//            ^ definition local 39
//              enclosing_range 220:4-225:5
//              documentation ```cs\nNamedParametersClass? a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#
//                    ^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#
//                                         enclosing_range 220:4-225:5
//                                         ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(b)
//                                           enclosing_range 220:4-225:5
//                                                  ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(a)
//                                                    enclosing_range 220:4-225:5
          a.Update(b: "foo", a: 42);
//        ^ read_access local 39
//          enclosing_range 220:4-225:5
//          ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().
//                 enclosing_range 220:4-225:5
//                 ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(b)
//                   enclosing_range 220:4-225:5
//                           ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(a)
//                             enclosing_range 220:4-225:5
          return a;
//               ^ read_access local 39
//                 enclosing_range 220:4-225:5
      }

      Func<int, int> AnonymousFunction()
//                   ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AnonymousFunction().
//                                     enclosing_range 4:0-339:1
//                                     documentation ```cs\nprivate Func<int, int> Expressions.AnonymousFunction()\n```
//                                     kind Method
      {
          var d = delegate (int _, int _) { return 42; };
//            ^ definition local 40
//              enclosing_range 227:4-231:5
//              documentation ```cs\nFunc<int, int, int>? d\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Func#
//                              ^ definition local 42
//                                enclosing_range 227:4-231:5
//                                documentation ```cs\nint _\n```
//                                kind Parameter
//                                relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                                     ^ definition local 43
//                                       enclosing_range 227:4-231:5
//                                       documentation ```cs\nint _\n```
//                                       kind Parameter
//                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          return delegate (int a) { return a + d.Invoke(a, a); };
//                             ^ definition local 45
//                               enclosing_range 227:4-231:5
//                               documentation ```cs\nint a\n```
//                               kind Parameter
//                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                                         ^ read_access local 45
//                                           enclosing_range 227:4-231:5
//                                             ^ read_access local 40
//                                               enclosing_range 227:4-231:5
//                                               ^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Func#Invoke().
//                                                      enclosing_range 227:4-231:5
//                                                      ^ read_access local 45
//                                                        enclosing_range 227:4-231:5
//                                                         ^ read_access local 45
//                                                           enclosing_range 227:4-231:5
      }

      class Lambda
//          ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Lambda#
//                 enclosing_range 4:0-339:1
//                 documentation ```cs\nclass Lambda\n```
//                 kind Class
      {
          public string func(Lambda x)
//                      ^^^^ definition scip-dotnet nuget . . Main/Expressions#Lambda#func().
//                           enclosing_range 233:4-239:5
//                           documentation ```cs\npublic string Lambda.func(Lambda x)\n```
//                           kind Method
//                           ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Lambda#
//                                  enclosing_range 235:8-238:9
//                                  ^ definition scip-dotnet nuget . . Main/Expressions#Lambda#func().(x)
//                                    enclosing_range 235:8-238:9
//                                    documentation ```cs\nLambda x\n```
//                                    kind Parameter
//                                    relationship type_definition scip-dotnet nuget . . Main/Expressions#Lambda#
          {
              return "";
          }
      }

      void LambdaExpressions()
//         ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#LambdaExpressions().
//                           enclosing_range 4:0-339:1
//                           documentation ```cs\nprivate void Expressions.LambdaExpressions()\n```
//                           kind Method
      {
          var a = (string x) => x + 1;
//            ^ definition local 46
//              enclosing_range 241:4-246:5
//              documentation ```cs\nFunc<string, string>? a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Func#
//                        ^ definition local 48
//                          enclosing_range 241:4-246:5
//                          documentation ```cs\nstring x\n```
//                          kind Parameter
//                          relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
//                              ^ read_access local 48
//                                enclosing_range 241:4-246:5
          var b = (Lambda a, Lambda b) => { return a.func(b); };
//            ^ definition local 49
//              enclosing_range 241:4-246:5
//              documentation ```cs\nFunc<Lambda, Lambda, string>? b\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Func#
//                 ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Lambda#
//                        enclosing_range 241:4-246:5
//                        ^ definition local 51
//                          enclosing_range 241:4-246:5
//                          documentation ```cs\nLambda a\n```
//                          kind Parameter
//                          relationship type_definition scip-dotnet nuget . . Main/Expressions#Lambda#
//                           ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Lambda#
//                                  enclosing_range 241:4-246:5
//                                  ^ definition local 52
//                                    enclosing_range 241:4-246:5
//                                    documentation ```cs\nLambda b\n```
//                                    kind Parameter
//                                    relationship type_definition scip-dotnet nuget . . Main/Expressions#Lambda#
//                                                 ^ read_access local 51
//                                                   enclosing_range 241:4-246:5
//                                                   ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Lambda#func().
//                                                        enclosing_range 241:4-246:5
//                                                        ^ read_access local 52
//                                                          enclosing_range 241:4-246:5
          var c = string (Lambda a, Lambda _) => { return "hi"; };
//            ^ definition local 53
//              enclosing_range 241:4-246:5
//              documentation ```cs\nFunc<Lambda, Lambda, string>? c\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Func#
//                        ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Lambda#
//                               enclosing_range 241:4-246:5
//                               ^ definition local 55
//                                 enclosing_range 241:4-246:5
//                                 documentation ```cs\nLambda a\n```
//                                 kind Parameter
//                                 relationship type_definition scip-dotnet nuget . . Main/Expressions#Lambda#
//                                  ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Lambda#
//                                         enclosing_range 241:4-246:5
//                                         ^ definition local 56
//                                           enclosing_range 241:4-246:5
//                                           documentation ```cs\nLambda _\n```
//                                           kind Parameter
//                                           relationship type_definition scip-dotnet nuget . . Main/Expressions#Lambda#
      }

      void TupleExpressions()
//         ^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TupleExpressions().
//                          enclosing_range 4:0-339:1
//                          documentation ```cs\nprivate void Expressions.TupleExpressions()\n```
//                          kind Method
      {
          var a = (1, 2, "");
//            ^ definition local 57
//              enclosing_range 248:4-251:5
//              documentation ```cs\n(int, int, string) a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/ValueTuple#
      }

      void ArrayCreation()
//         ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#ArrayCreation().
//                       enclosing_range 4:0-339:1
//                       documentation ```cs\nprivate void Expressions.ArrayCreation()\n```
//                       kind Method
      {
          var a = new[,] { { 1, 1 }, { 2, 2 }, { 3, 3 } };
//            ^ definition local 58
//              enclosing_range 253:4-262:5
//              documentation ```cs\nint[*,*]? a\n```
//              kind Variable
//              relationship type_definition local 59
          Span<int> b = stackalloc[] { 1, 2, 3 };
//                  ^ definition local 60
//                    enclosing_range 253:4-262:5
//                    documentation ```cs\nSpan<int> b\n```
//                    kind Variable
//                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Span#
          Span<int> c = stackalloc int[] { 1, 2, 3 };
//                  ^ definition local 61
//                    enclosing_range 253:4-262:5
//                    documentation ```cs\nSpan<int> c\n```
//                    kind Variable
//                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Span#
          var d = new int[3] { 1, 2, 3 };
//            ^ definition local 62
//              enclosing_range 253:4-262:5
//              documentation ```cs\nint[]? d\n```
//              kind Variable
//              relationship type_definition local 63
          var e = new byte[,] { { 1, 2 }, { 2, 3 } };
//            ^ definition local 64
//              enclosing_range 253:4-262:5
//              documentation ```cs\nbyte[*,*]? e\n```
//              kind Variable
//              relationship type_definition local 65
          var f = new int[3, 2] { { 1, 1 }, { 2, 2 }, { 3, 3 } };
//            ^ definition local 66
//              enclosing_range 253:4-262:5
//              documentation ```cs\nint[*,*]? f\n```
//              kind Variable
//              relationship type_definition local 59
          var g = new (string b, string c)[3];
//            ^ definition local 67
//              enclosing_range 253:4-262:5
//              documentation ```cs\n(string b, string c)[]? g\n```
//              kind Variable
//              relationship type_definition local 68
      }

      void MakeRef()
//         ^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#MakeRef().
//                 enclosing_range 4:0-339:1
//                 documentation ```cs\nprivate void Expressions.MakeRef()\n```
//                 kind Method
      {
          var g = "";
//            ^ definition local 69
//              enclosing_range 264:4-268:5
//              documentation ```cs\nstring? g\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
          var a = __makeref(g);
//            ^ definition local 70
//              enclosing_range 264:4-268:5
//              documentation ```cs\nTypedReference a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/TypedReference#
//                          ^ read_access local 69
//                            enclosing_range 264:4-268:5
      }

      void SizeOf()
//         ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#SizeOf().
//                enclosing_range 4:0-339:1
//                documentation ```cs\nprivate void Expressions.SizeOf()\n```
//                kind Method
      {
          var a = sizeof(int);
//            ^ definition local 71
//              enclosing_range 270:4-273:5
//              documentation ```cs\nint a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
      }

      void TypeOf()
//         ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TypeOf().
//                enclosing_range 4:0-339:1
//                documentation ```cs\nprivate void Expressions.TypeOf()\n```
//                kind Method
      {
          var a = typeof(int);
//            ^ definition local 72
//              enclosing_range 275:4-281:5
//              documentation ```cs\nType? a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Type#
          var b = typeof(List<string>.Enumerator);
//            ^ definition local 73
//              enclosing_range 275:4-281:5
//              documentation ```cs\nType? b\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Type#
//                                    ^^^^^^^^^^ read_access scip-dotnet nuget System.Collections 10.0.0.0 Generic/List#Enumerator#
//                                               enclosing_range 275:4-281:5
          var c = typeof(Dictionary<,>);
//            ^ definition local 74
//              enclosing_range 275:4-281:5
//              documentation ```cs\nType? c\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Type#
          var d = typeof(Tuple<,,,>);
//            ^ definition local 75
//              enclosing_range 275:4-281:5
//              documentation ```cs\nType? d\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Type#
      }

      interface IAnimal
//              ^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#IAnimal#
//                      enclosing_range 4:0-339:1
//                      documentation ```cs\ninterface IAnimal\n```
//                      kind Interface
      {
          string Sound();
//               ^^^^^ definition forward_definition scip-dotnet nuget . . Main/Expressions#IAnimal#Sound().
//                     enclosing_range 283:4-286:5
//                     documentation ```cs\nstring IAnimal.Sound()\n```
//                     kind AbstractMethod
      }

      public class Dog : IAnimal
//                 ^^^ definition scip-dotnet nuget . . Main/Expressions#Dog#
//                     enclosing_range 4:0-339:1
//                     documentation ```cs\nclass Dog\n```
//                     kind Class
//                     relationship implementation scip-dotnet nuget . . Main/Expressions#IAnimal#
//                       ^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#IAnimal#
//                               enclosing_range 288:4-294:5
      {
          public string Sound()
//                      ^^^^^ definition scip-dotnet nuget . . Main/Expressions#Dog#Sound().
//                            enclosing_range 288:4-294:5
//                            documentation ```cs\npublic string Dog.Sound()\n```
//                            kind Method
//                            relationship implementation reference scip-dotnet nuget . . Main/Expressions#IAnimal#Sound().
          {
              return "woof";
          }
      }

      public class Cat : IAnimal
//                 ^^^ definition scip-dotnet nuget . . Main/Expressions#Cat#
//                     enclosing_range 4:0-339:1
//                     documentation ```cs\nclass Cat\n```
//                     kind Class
//                     relationship implementation scip-dotnet nuget . . Main/Expressions#IAnimal#
//                       ^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#IAnimal#
//                               enclosing_range 296:4-302:5
      {
          public string Sound()
//                      ^^^^^ definition scip-dotnet nuget . . Main/Expressions#Cat#Sound().
//                            enclosing_range 296:4-302:5
//                            documentation ```cs\npublic string Cat.Sound()\n```
//                            kind Method
//                            relationship implementation reference scip-dotnet nuget . . Main/Expressions#IAnimal#Sound().
          {
              return "meow";
          }
      }

      void Switch()
//         ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Switch().
//                enclosing_range 4:0-339:1
//                documentation ```cs\nprivate void Expressions.Switch()\n```
//                kind Method
      {
          int some = 42;
//            ^^^^ definition local 76
//                 enclosing_range 304:4-320:5
//                 documentation ```cs\nint some\n```
//                 kind Variable
//                 relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          var a = some switch
//            ^ definition local 77
//              enclosing_range 304:4-320:5
//              documentation ```cs\nstring? a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
//                ^^^^ read_access local 76
//                     enclosing_range 304:4-320:5
          {
              1 => "one",
              2 => "two",
              _ => "more"
          };
          IAnimal dog = new Dog();
//        ^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#IAnimal#
//                enclosing_range 304:4-320:5
//                ^^^ definition local 78
//                    enclosing_range 304:4-320:5
//                    documentation ```cs\nIAnimal dog\n```
//                    kind Variable
//                    relationship type_definition scip-dotnet nuget . . Main/Expressions#IAnimal#
//                          ^^^ read_access scip-dotnet nuget . . Main/Expressions#Dog#
//                              enclosing_range 304:4-320:5
          var b = dog switch
//            ^ definition local 79
//              enclosing_range 304:4-320:5
//              documentation ```cs\nstring? b\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
//                ^^^ read_access local 78
//                    enclosing_range 304:4-320:5
          {
              Cat c => c.Sound(),
//            ^^^ read_access scip-dotnet nuget . . Main/Expressions#Cat#
//                enclosing_range 304:4-320:5
//                ^ definition local 80
//                  enclosing_range 304:4-320:5
//                  documentation ```cs\nCat c\n```
//                  kind Variable
//                  relationship type_definition scip-dotnet nuget . . Main/Expressions#Cat#
//                     ^ read_access local 80
//                       enclosing_range 304:4-320:5
//                       ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cat#Sound().
//                             enclosing_range 304:4-320:5
              Dog c => c.Sound(),
//            ^^^ read_access scip-dotnet nuget . . Main/Expressions#Dog#
//                enclosing_range 304:4-320:5
//                ^ definition local 81
//                  enclosing_range 304:4-320:5
//                  documentation ```cs\nDog c\n```
//                  kind Variable
//                  relationship type_definition scip-dotnet nuget . . Main/Expressions#Dog#
//                     ^ read_access local 81
//                       enclosing_range 304:4-320:5
//                       ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Dog#Sound().
//                             enclosing_range 304:4-320:5
              _ => throw new ArgumentOutOfRangeException()
//                           ^^^^^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/ArgumentOutOfRangeException#
//                                                       enclosing_range 304:4-320:5
          };
      }

      void Dictionary()
//         ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Dictionary().
//                    enclosing_range 4:0-339:1
//                    documentation ```cs\nprivate void Expressions.Dictionary()\n```
//                    kind Method
      {
          var a = new Dictionary<string, int> { ["a"] = 65 };
//            ^ definition local 82
//              enclosing_range 322:4-325:5
//              documentation ```cs\nDictionary<string, int>? a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Collections 10.0.0.0 Generic/Dictionary#
      }

      void Is()
//         ^^ definition scip-dotnet nuget . . Main/Expressions#Is().
//            enclosing_range 4:0-339:1
//            documentation ```cs\nprivate void Expressions.Is()\n```
//            kind Method
      {
          object s = "s";
//               ^ definition local 83
//                 enclosing_range 327:4-338:5
//                 documentation ```cs\nobject s\n```
//                 kind Variable
          if (s is string s2)
//            ^ read_access local 83
//              enclosing_range 327:4-338:5
//                        ^^ definition local 84
//                           enclosing_range 327:4-338:5
//                           documentation ```cs\nstring s2\n```
//                           kind Variable
//                           relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
          {
              Console.WriteLine(s2);
//            ^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                    enclosing_range 327:4-338:5
//                    ^^^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
//                              enclosing_range 327:4-338:5
//                              ^^ read_access local 84
//                                 enclosing_range 327:4-338:5
          }

          var c = s is "test";
//            ^ definition local 85
//              enclosing_range 327:4-338:5
//              documentation ```cs\nbool c\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
//                ^ read_access local 83
//                  enclosing_range 327:4-338:5
          var a = s is int.MaxValue;
//            ^ definition local 86
//              enclosing_range 327:4-338:5
//              documentation ```cs\nbool a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
//                ^ read_access local 83
//                  enclosing_range 327:4-338:5
//                         ^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#MaxValue.
//                                  enclosing_range 327:4-338:5
          var d = s is nameof(a);
//            ^ definition local 87
//              enclosing_range 327:4-338:5
//              documentation ```cs\nbool d\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
//                ^ read_access local 83
//                  enclosing_range 327:4-338:5
//                            ^ read_access local 86
//                              enclosing_range 327:4-338:5
      }
  }
