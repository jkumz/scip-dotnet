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
  public class Expressions
//             ^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#
//                         enclosing_range 4:0-339:1
//                         documentation ```cs\nclass Expressions\n```
//                         kind Class
  {
      void AssignmentToPrefixUnaryExpressions()
//         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AssignmentToPrefixUnaryExpressions().
//                                            enclosing_range 7:4-22:5
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
//          enclosing_range 11:8-11:14
//             ^ read_access local 0
//               enclosing_range 11:12-11:14
          a = -a;
//        ^ write_access local 0
//          enclosing_range 12:8-12:14
//             ^ read_access local 0
//               enclosing_range 12:12-12:14
          a = ~a;
//        ^ write_access local 0
//          enclosing_range 13:8-13:14
//             ^ read_access local 0
//               enclosing_range 13:12-13:14
          a = ++a;
//        ^ write_access local 0
//          enclosing_range 14:8-14:15
//              ^ write_access local 0
//                enclosing_range 14:12-14:15
          a = --a;
//        ^ write_access local 0
//          enclosing_range 15:8-15:15
//              ^ write_access local 0
//                enclosing_range 15:12-15:15
          a = a++;
//        ^ write_access local 0
//          enclosing_range 16:8-16:15
//            ^ write_access local 0
//              enclosing_range 16:12-16:15
          a = a--;
//        ^ write_access local 0
//          enclosing_range 17:8-17:15
//            ^ write_access local 0
//              enclosing_range 17:12-17:15
          b = a!;
//        ^ write_access local 1
//          enclosing_range 18:8-18:14
//            ^ read_access local 0
//              enclosing_range 18:12-18:14

          var c = true;
//            ^ definition local 2
//              enclosing_range 7:4-22:5
//              documentation ```cs\nbool c\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
          c = !c;
//        ^ write_access local 2
//          enclosing_range 21:8-21:14
//             ^ read_access local 2
//               enclosing_range 21:12-21:14
      }

      void AssignmentToPrefixBinaryExpressions()
//         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AssignmentToPrefixBinaryExpressions().
//                                             enclosing_range 24:4-38:5
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
//          enclosing_range 27:8-27:17
//            ^ read_access local 3
//              enclosing_range 27:12-27:17
//                ^ read_access local 3
//                  enclosing_range 27:12-27:17
          a = a - a;
//        ^ write_access local 3
//          enclosing_range 28:8-28:17
//            ^ read_access local 3
//              enclosing_range 28:12-28:17
//                ^ read_access local 3
//                  enclosing_range 28:12-28:17
          a = a * a;
//        ^ write_access local 3
//          enclosing_range 29:8-29:17
//            ^ read_access local 3
//              enclosing_range 29:12-29:17
//                ^ read_access local 3
//                  enclosing_range 29:12-29:17
          a = a / a;
//        ^ write_access local 3
//          enclosing_range 30:8-30:17
//            ^ read_access local 3
//              enclosing_range 30:12-30:17
//                ^ read_access local 3
//                  enclosing_range 30:12-30:17
          a = a % a;
//        ^ write_access local 3
//          enclosing_range 31:8-31:17
//            ^ read_access local 3
//              enclosing_range 31:12-31:17
//                ^ read_access local 3
//                  enclosing_range 31:12-31:17
          a = a & a;
//        ^ write_access local 3
//          enclosing_range 32:8-32:17
//            ^ read_access local 3
//              enclosing_range 32:12-32:17
//                ^ read_access local 3
//                  enclosing_range 32:12-32:17
          a = a | a;
//        ^ write_access local 3
//          enclosing_range 33:8-33:17
//            ^ read_access local 3
//              enclosing_range 33:12-33:17
//                ^ read_access local 3
//                  enclosing_range 33:12-33:17
          a = a ^ a;
//        ^ write_access local 3
//          enclosing_range 34:8-34:17
//            ^ read_access local 3
//              enclosing_range 34:12-34:17
//                ^ read_access local 3
//                  enclosing_range 34:12-34:17
          a = a >> a;
//        ^ write_access local 3
//          enclosing_range 35:8-35:18
//            ^ read_access local 3
//              enclosing_range 35:12-35:18
//                 ^ read_access local 3
//                   enclosing_range 35:12-35:18
          a = a << a;
//        ^ write_access local 3
//          enclosing_range 36:8-36:18
//            ^ read_access local 3
//              enclosing_range 36:12-36:18
//                 ^ read_access local 3
//                   enclosing_range 36:12-36:18
          a = a >>> a;
//        ^ write_access local 3
//          enclosing_range 37:8-37:19
//            ^ read_access local 3
//              enclosing_range 37:12-37:19
//                  ^ read_access local 3
//                    enclosing_range 37:12-37:19
      }

      void AssignmentToBinaryEqualityExpression()
//         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AssignmentToBinaryEqualityExpression().
//                                              enclosing_range 40:4-52:5
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
//          enclosing_range 46:8-46:18
//            ^ read_access local 4
//              enclosing_range 46:12-46:18
//                 ^ read_access local 5
//                   enclosing_range 46:12-46:18
          a = a != b;
//        ^ write_access local 4
//          enclosing_range 47:8-47:18
//            ^ read_access local 4
//              enclosing_range 47:12-47:18
//                 ^ read_access local 5
//                   enclosing_range 47:12-47:18
          a = c < d;
//        ^ write_access local 4
//          enclosing_range 48:8-48:17
//            ^ read_access local 6
//              enclosing_range 48:12-48:17
//                ^ read_access local 7
//                  enclosing_range 48:12-48:17
          a = c <= d;
//        ^ write_access local 4
//          enclosing_range 49:8-49:18
//            ^ read_access local 6
//              enclosing_range 49:12-49:18
//                 ^ read_access local 7
//                   enclosing_range 49:12-49:18
          a = c > d;
//        ^ write_access local 4
//          enclosing_range 50:8-50:17
//            ^ read_access local 6
//              enclosing_range 50:12-50:17
//                ^ read_access local 7
//                  enclosing_range 50:12-50:17
          a = c >= d;
//        ^ write_access local 4
//          enclosing_range 51:8-51:18
//            ^ read_access local 6
//              enclosing_range 51:12-51:18
//                 ^ read_access local 7
//                   enclosing_range 51:12-51:18
      }

      void AssignmentToBinaryExpression()
//         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AssignmentToBinaryExpression().
//                                      enclosing_range 54:4-67:5
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
//          enclosing_range 57:8-57:14
//             ^ read_access local 8
//               enclosing_range 57:8-57:14
          a -= a;
//        ^ write_access local 8
//          enclosing_range 58:8-58:14
//             ^ read_access local 8
//               enclosing_range 58:8-58:14
          a *= a;
//        ^ write_access local 8
//          enclosing_range 59:8-59:14
//             ^ read_access local 8
//               enclosing_range 59:8-59:14
          a /= a;
//        ^ write_access local 8
//          enclosing_range 60:8-60:14
//             ^ read_access local 8
//               enclosing_range 60:8-60:14
          a %= a;
//        ^ write_access local 8
//          enclosing_range 61:8-61:14
//             ^ read_access local 8
//               enclosing_range 61:8-61:14
          a++;
//        ^ write_access local 8
//          enclosing_range 62:8-62:11
          a--;
//        ^ write_access local 8
//          enclosing_range 63:8-63:11
          a <<= a;
//        ^ write_access local 8
//          enclosing_range 64:8-64:15
//              ^ read_access local 8
//                enclosing_range 64:8-64:15
          a >>= a;
//        ^ write_access local 8
//          enclosing_range 65:8-65:15
//              ^ read_access local 8
//                enclosing_range 65:8-65:15
          a >>>= a;
//        ^ write_access local 8
//          enclosing_range 66:8-66:16
//               ^ read_access local 8
//                 enclosing_range 66:8-66:16
      }

      struct Struct
//           ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Struct#
//                  enclosing_range 69:4-72:5
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
//                        enclosing_range 74:4-83:5
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
//                                  enclosing_range 80:25-80:33
              set { Property = value; }
//                  ^^^^^^^^ write_access scip-dotnet nuget . . Main/Expressions#IndexedClass#Property.
//                           enclosing_range 81:18-81:34
//                             ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#IndexedClass#set_Item().(value)
//                                   enclosing_range 81:18-81:34
          }
      }

      void AssignmentToLeftValueTypes()
//         ^^^^^^^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AssignmentToLeftValueTypes().
//                                    enclosing_range 85:4-106:5
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
//          enclosing_range 88:8-88:13
          var c = new Struct { Property = 42 };
//            ^ definition local 11
//              enclosing_range 85:4-106:5
//              documentation ```cs\nStruct c\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget . . Main/Expressions#Struct#
//                    ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Struct#
//                           enclosing_range 89:16-89:44
//                             ^^^^^^^^ write_access scip-dotnet nuget . . Main/Expressions#Struct#Property.
//                                      enclosing_range 89:29-89:42
          c.Property = 1;
//        ^ read_access local 11
//          enclosing_range 90:8-90:18
//          ^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Struct#Property.
//                   enclosing_range 90:8-90:18
          var d = new IndexedClass();
//            ^ definition local 12
//              enclosing_range 85:4-106:5
//              documentation ```cs\nIndexedClass d\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget . . Main/Expressions#IndexedClass#
//                    ^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#IndexedClass#
//                                 enclosing_range 91:16-91:34
          d[b] = 1;
//        ^ read_access local 12
//          enclosing_range 92:8-92:12
//          ^ read_access local 10
//            enclosing_range 92:10-92:11
          (a, b) = (1, 2);
//         ^ read_access local 9
//           enclosing_range 93:9-93:10
//            ^ read_access local 10
//              enclosing_range 93:12-93:13
          var x = new IndexedClass
//            ^ definition local 13
//              enclosing_range 85:4-106:5
//              documentation ```cs\nIndexedClass x\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget . . Main/Expressions#IndexedClass#
//                    ^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#IndexedClass#
//                                 enclosing_range 94:16-98:9
          {
              Property = 1,
//            ^^^^^^^^ write_access scip-dotnet nuget . . Main/Expressions#IndexedClass#Property.
//                     enclosing_range 96:12-96:24
              [b] = 1
//             ^ read_access local 10
//               enclosing_range 97:13-97:14
          };
          (a) = 1;
//         ^ read_access local 9
//           enclosing_range 99:8-99:11
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
//                            enclosing_range 103:21-103:27
              Console.WriteLine("myInt = {0}, *p = {1}", myInt, *p);
//            ^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                    enclosing_range 104:12-104:65
//                    ^^^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+14).
//                              enclosing_range 104:12-104:65
//                                                       ^^^^^ read_access local 14
//                                                             enclosing_range 104:55-104:60
//                                                               ^ read_access local 15
//                                                                 enclosing_range 104:62-104:64
          }
      }

      void TernaryExpression()
//         ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TernaryExpression().
//                           enclosing_range 108:4-114:5
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
//                  enclosing_range 111:16-111:33
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
//                  enclosing_range 113:16-113:25
      }

      class Cast
//          ^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#
//               enclosing_range 116:4-130:5
//               documentation ```cs\nclass Cast\n```
//               kind Class
      {
          public Cast nested;
//               ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                    enclosing_range 118:15-118:19
//                    ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#nested.
//                           enclosing_range 118:8-118:27
//                           documentation ```cs\npublic Cast Cast.nested\n```
//                           kind Field
//                           relationship type_definition scip-dotnet nuget . . Main/Expressions#Cast#
          public Cast2 nested2;
//               ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#Cast2#
//                     enclosing_range 119:15-119:20
//                     ^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#nested2.
//                             enclosing_range 119:8-119:29
//                             documentation ```cs\npublic Cast2 Cast.nested2\n```
//                             kind Field
//                             relationship type_definition scip-dotnet nuget . . Main/Expressions#Cast#Cast2#

          public Cast plus(Cast other)
//               ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                    enclosing_range 121:15-121:19
//                    ^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#plus().
//                         enclosing_range 121:8-125:9
//                         documentation ```cs\npublic Cast Cast.plus(Cast other)\n```
//                         kind Method
//                         ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                              enclosing_range 121:25-121:29
//                              ^^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#plus().(other)
//                                    enclosing_range 121:8-125:9
//                                    documentation ```cs\nCast other\n```
//                                    kind Parameter
//                                    relationship type_definition scip-dotnet nuget . . Main/Expressions#Cast#
          {
              nested = other;
//            ^^^^^^ write_access scip-dotnet nuget . . Main/Expressions#Cast#nested.
//                   enclosing_range 123:12-123:26
//                     ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#plus().(other)
//                           enclosing_range 123:12-123:26
              return this;
          }

          public class Cast2
//                     ^^^^^ definition scip-dotnet nuget . . Main/Expressions#Cast#Cast2#
//                           enclosing_range 127:8-129:9
//                           documentation ```cs\nclass Cast2\n```
//                           kind Class
          {
          }
      }

      int CastExpressions()
//        ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#CastExpressions().
//                        enclosing_range 132:4-143:5
//                        documentation ```cs\nprivate int Expressions.CastExpressions()\n```
//                        kind Method
      {
          object a = new Cast();
//               ^ definition local 21
//                 enclosing_range 132:4-143:5
//                 documentation ```cs\nobject a\n```
//                 kind Variable
//                       ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                            enclosing_range 134:19-134:29
          object b = new Cast();
//               ^ definition local 22
//                 enclosing_range 132:4-143:5
//                 documentation ```cs\nobject b\n```
//                 kind Variable
//                       ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                            enclosing_range 135:19-135:29
          Cast c = ((Cast)a).plus((Cast)b);
//        ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//             enclosing_range 136:8-136:12
//             ^ definition local 23
//               enclosing_range 132:4-143:5
//               documentation ```cs\nCast c\n```
//               kind Variable
//               relationship type_definition scip-dotnet nuget . . Main/Expressions#Cast#
//                   ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                        enclosing_range 136:18-136:25
//                        ^ read_access local 21
//                          enclosing_range 136:18-136:25
//                           ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#plus().
//                                enclosing_range 136:17-136:40
//                                 ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                                      enclosing_range 136:32-136:39
//                                      ^ read_access local 22
//                                        enclosing_range 136:32-136:39
          Cast d = (Cast)new object[] { a, b }[0];
//        ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//             enclosing_range 137:8-137:12
//             ^ definition local 24
//               enclosing_range 132:4-143:5
//               documentation ```cs\nCast d\n```
//               kind Variable
//               relationship type_definition scip-dotnet nuget . . Main/Expressions#Cast#
//                  ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                       enclosing_range 137:17-137:47
//                                      ^ read_access local 21
//                                        enclosing_range 137:36-137:44
//                                         ^ read_access local 22
//                                           enclosing_range 137:36-137:44
          var e = (Cast.Cast2)(c.nested.nested2);
//            ^ definition local 25
//              enclosing_range 132:4-143:5
//              documentation ```cs\nCast2? e\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget . . Main/Expressions#Cast#Cast2#
//                 ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#
//                      enclosing_range 138:17-138:27
//                      ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#Cast2#
//                            enclosing_range 138:17-138:27
//                             ^ read_access local 23
//                               enclosing_range 138:29-138:37
//                               ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#nested.
//                                      enclosing_range 138:29-138:37
//                                      ^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cast#nested2.
//                                              enclosing_range 138:29-138:45
          var f = (Int32)(1);
//            ^ definition local 26
//              enclosing_range 132:4-143:5
//              documentation ```cs\nint f\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                 ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                       enclosing_range 139:16-139:26
          var g = (Int32)(1);
//            ^ definition local 27
//              enclosing_range 132:4-143:5
//              documentation ```cs\nint g\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                 ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                       enclosing_range 140:16-140:26
          var h = (Int32)((1));
//            ^ definition local 28
//              enclosing_range 132:4-143:5
//              documentation ```cs\nint h\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                 ^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
//                       enclosing_range 141:16-141:28
          return f + g + h;
//               ^ read_access local 26
//                 enclosing_range 142:15-142:20
//                   ^ read_access local 27
//                     enclosing_range 142:15-142:20
//                       ^ read_access local 28
//                         enclosing_range 142:15-142:24
      }

      object AnonymousObject()
//           ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AnonymousObject().
//                           enclosing_range 145:4-153:5
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
//                             enclosing_range 147:22-147:28
          var y = new
//            ^ definition local 32
//              enclosing_range 145:4-153:5
//              documentation ```cs\n<anonymous type: AnonymousType <anonymous type: string Helper> x>? y\n```
//              kind Variable
//              relationship type_definition local 33
          {
              x
//            ^ read_access local 29
//              enclosing_range 150:12-150:13
          };
          return y.x.Helper;
//               ^ read_access local 32
//                 enclosing_range 152:15-152:18
//                 ^ read_access local 34
//                   enclosing_range 152:15-152:18
//                   ^^^^^^ read_access local 31
//                          enclosing_range 152:15-152:25
      }

      class TargetType
//          ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TargetType#
//                     enclosing_range 155:4-160:5
//                     documentation ```cs\nclass TargetType\n```
//                     kind Class
      {
          public TargetType(string name)
//               ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TargetType#`.ctor`().
//                          enclosing_range 157:8-159:9
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
//               enclosing_range 162:4-162:14
//               ^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TargetTypeNew().
//                             enclosing_range 162:4-166:5
//                             documentation ```cs\nprivate TargetType Expressions.TargetTypeNew()\n```
//                             kind Method
      {
          TargetType x = new("x");
//        ^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#TargetType#
//                   enclosing_range 164:8-164:18
//                   ^ definition local 35
//                     enclosing_range 162:4-166:5
//                     documentation ```cs\nTargetType x\n```
//                     kind Variable
//                     relationship type_definition scip-dotnet nuget . . Main/Expressions#TargetType#
          return x;
//               ^ read_access local 35
//                 enclosing_range 165:15-165:16
      }

      int Checked()
//        ^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Checked().
//                enclosing_range 168:4-172:5
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
//                     enclosing_range 171:15-171:20
      }

      class ObjectCreationClass
//          ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                              enclosing_range 174:4-189:5
//                              documentation ```cs\nclass ObjectCreationClass\n```
//                              kind Class
      {
          public D field;
//               ^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#
//                 enclosing_range 176:15-176:16
//                 ^^^^^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#field.
//                       enclosing_range 176:8-176:23
//                       documentation ```cs\npublic D ObjectCreationClass.field\n```
//                       kind Field
//                       relationship type_definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#

          public ObjectCreationClass(D field)
//               ^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#`.ctor`().
//                                   enclosing_range 178:8-181:9
//                                   documentation ```cs\npublic ObjectCreationClass.ObjectCreationClass(D field)\n```
//                                   kind Constructor
//                                   ^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#
//                                     enclosing_range 178:35-178:36
//                                     ^^^^^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#`.ctor`().(field)
//                                           enclosing_range 178:8-181:9
//                                           documentation ```cs\nD field\n```
//                                           kind Parameter
//                                           relationship type_definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#
          {
              this.field = field;
//                 ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#field.
//                       enclosing_range 180:12-180:22
//                         ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#`.ctor`().(field)
//                               enclosing_range 180:12-180:30
          }

          public class D
//                     ^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#
//                       enclosing_range 183:8-188:9
//                       documentation ```cs\nclass D\n```
//                       kind Class
          {
              public D(int a, string b)
//                   ^ definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#`.ctor`().
//                     enclosing_range 185:12-187:13
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
//                        enclosing_range 191:4-200:5
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
//                                        enclosing_range 193:20-193:41
//                                        ^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#D#
//                                          enclosing_range 193:20-193:41
          var b = new ObjectCreationClass(a)
//            ^ definition local 38
//              enclosing_range 191:4-200:5
//              documentation ```cs\nObjectCreationClass? b\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                    ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                                        enclosing_range 194:16-197:9
//                                        ^ read_access local 37
//                                          enclosing_range 194:40-194:41
          {
              field = a,
//            ^^^^^ write_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#field.
//                  enclosing_range 196:12-196:21
//                    ^ read_access local 37
//                      enclosing_range 196:12-196:21
          };
          b = new ObjectCreationClass(a);
//        ^ write_access local 38
//          enclosing_range 198:8-198:38
//                ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                                    enclosing_range 198:12-198:38
//                                    ^ read_access local 37
//                                      enclosing_range 198:36-198:37
          b = new ObjectCreationClass(a) { };
//        ^ write_access local 38
//          enclosing_range 199:8-199:42
//                ^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#ObjectCreationClass#
//                                    enclosing_range 199:12-199:42
//                                    ^ read_access local 37
//                                      enclosing_range 199:36-199:37
      }

      class NamedParametersClass
//          ^^^^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#
//                               enclosing_range 202:4-218:5
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
//                                    enclosing_range 207:8-211:9
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
//              enclosing_range 209:12-209:17
//                ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(a)
//                  enclosing_range 209:12-209:17
              B = b;
//            ^ write_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#B.
//              enclosing_range 210:12-210:17
//                ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(b)
//                  enclosing_range 210:12-210:17
          }

          public void Update(int a, string b)
//                    ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().
//                           enclosing_range 213:8-217:9
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
//              enclosing_range 215:12-215:17
//                ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(a)
//                  enclosing_range 215:12-215:17
              B = b;
//            ^ write_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#B.
//              enclosing_range 216:12-216:17
//                ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(b)
//                  enclosing_range 216:12-216:17
          }
      }

      NamedParametersClass NamedParameters()
//    ^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#
//                         enclosing_range 220:4-220:24
//                         ^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#NamedParameters().
//                                         enclosing_range 220:4-225:5
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
//                                         enclosing_range 222:16-222:55
//                                         ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(b)
//                                           enclosing_range 222:41-222:42
//                                                  ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#`.ctor`().(a)
//                                                    enclosing_range 222:50-222:51
          a.Update(b: "foo", a: 42);
//        ^ read_access local 39
//          enclosing_range 223:8-223:33
//          ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().
//                 enclosing_range 223:8-223:33
//                 ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(b)
//                   enclosing_range 223:17-223:18
//                           ^ read_access scip-dotnet nuget . . Main/Expressions#NamedParametersClass#Update().(a)
//                             enclosing_range 223:27-223:28
          return a;
//               ^ read_access local 39
//                 enclosing_range 224:15-224:16
      }

      Func<int, int> AnonymousFunction()
//                   ^^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#AnonymousFunction().
//                                     enclosing_range 227:4-231:5
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
//                                           enclosing_range 230:41-230:59
//                                             ^ read_access local 40
//                                               enclosing_range 230:45-230:59
//                                               ^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Func#Invoke().
//                                                      enclosing_range 230:45-230:59
//                                                      ^ read_access local 45
//                                                        enclosing_range 230:54-230:55
//                                                         ^ read_access local 45
//                                                           enclosing_range 230:57-230:58
      }

      class Lambda
//          ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Lambda#
//                 enclosing_range 233:4-239:5
//                 documentation ```cs\nclass Lambda\n```
//                 kind Class
      {
          public string func(Lambda x)
//                      ^^^^ definition scip-dotnet nuget . . Main/Expressions#Lambda#func().
//                           enclosing_range 235:8-238:9
//                           documentation ```cs\npublic string Lambda.func(Lambda x)\n```
//                           kind Method
//                           ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Lambda#
//                                  enclosing_range 235:27-235:33
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
//                           enclosing_range 241:4-246:5
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
//                                enclosing_range 243:30-243:35
          var b = (Lambda a, Lambda b) => { return a.func(b); };
//            ^ definition local 49
//              enclosing_range 241:4-246:5
//              documentation ```cs\nFunc<Lambda, Lambda, string>? b\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Func#
//                 ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Lambda#
//                        enclosing_range 244:17-244:23
//                        ^ definition local 51
//                          enclosing_range 241:4-246:5
//                          documentation ```cs\nLambda a\n```
//                          kind Parameter
//                          relationship type_definition scip-dotnet nuget . . Main/Expressions#Lambda#
//                           ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Lambda#
//                                  enclosing_range 244:27-244:33
//                                  ^ definition local 52
//                                    enclosing_range 241:4-246:5
//                                    documentation ```cs\nLambda b\n```
//                                    kind Parameter
//                                    relationship type_definition scip-dotnet nuget . . Main/Expressions#Lambda#
//                                                 ^ read_access local 51
//                                                   enclosing_range 244:49-244:58
//                                                   ^^^^ read_access scip-dotnet nuget . . Main/Expressions#Lambda#func().
//                                                        enclosing_range 244:49-244:58
//                                                        ^ read_access local 52
//                                                          enclosing_range 244:56-244:57
          var c = string (Lambda a, Lambda _) => { return "hi"; };
//            ^ definition local 53
//              enclosing_range 241:4-246:5
//              documentation ```cs\nFunc<Lambda, Lambda, string>? c\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Func#
//                        ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Lambda#
//                               enclosing_range 245:24-245:30
//                               ^ definition local 55
//                                 enclosing_range 241:4-246:5
//                                 documentation ```cs\nLambda a\n```
//                                 kind Parameter
//                                 relationship type_definition scip-dotnet nuget . . Main/Expressions#Lambda#
//                                  ^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Lambda#
//                                         enclosing_range 245:34-245:40
//                                         ^ definition local 56
//                                           enclosing_range 241:4-246:5
//                                           documentation ```cs\nLambda _\n```
//                                           kind Parameter
//                                           relationship type_definition scip-dotnet nuget . . Main/Expressions#Lambda#
      }

      void TupleExpressions()
//         ^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#TupleExpressions().
//                          enclosing_range 248:4-251:5
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
//                       enclosing_range 253:4-262:5
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
//                 enclosing_range 264:4-268:5
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
//                            enclosing_range 267:16-267:28
      }

      void SizeOf()
//         ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#SizeOf().
//                enclosing_range 270:4-273:5
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
//                enclosing_range 275:4-281:5
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
//                                               enclosing_range 278:23-278:46
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
//                      enclosing_range 283:4-286:5
//                      documentation ```cs\ninterface IAnimal\n```
//                      kind Interface
      {
          string Sound();
//               ^^^^^ definition forward_definition scip-dotnet nuget . . Main/Expressions#IAnimal#Sound().
//                     enclosing_range 285:8-285:23
//                     documentation ```cs\nstring IAnimal.Sound()\n```
//                     kind AbstractMethod
      }

      public class Dog : IAnimal
//                 ^^^ definition scip-dotnet nuget . . Main/Expressions#Dog#
//                     enclosing_range 288:4-294:5
//                     documentation ```cs\nclass Dog\n```
//                     kind Class
//                     relationship implementation scip-dotnet nuget . . Main/Expressions#IAnimal#
//                       ^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#IAnimal#
//                               enclosing_range 288:23-288:30
      {
          public string Sound()
//                      ^^^^^ definition scip-dotnet nuget . . Main/Expressions#Dog#Sound().
//                            enclosing_range 290:8-293:9
//                            documentation ```cs\npublic string Dog.Sound()\n```
//                            kind Method
//                            relationship implementation reference scip-dotnet nuget . . Main/Expressions#IAnimal#Sound().
          {
              return "woof";
          }
      }

      public class Cat : IAnimal
//                 ^^^ definition scip-dotnet nuget . . Main/Expressions#Cat#
//                     enclosing_range 296:4-302:5
//                     documentation ```cs\nclass Cat\n```
//                     kind Class
//                     relationship implementation scip-dotnet nuget . . Main/Expressions#IAnimal#
//                       ^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#IAnimal#
//                               enclosing_range 296:23-296:30
      {
          public string Sound()
//                      ^^^^^ definition scip-dotnet nuget . . Main/Expressions#Cat#Sound().
//                            enclosing_range 298:8-301:9
//                            documentation ```cs\npublic string Cat.Sound()\n```
//                            kind Method
//                            relationship implementation reference scip-dotnet nuget . . Main/Expressions#IAnimal#Sound().
          {
              return "meow";
          }
      }

      void Switch()
//         ^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Switch().
//                enclosing_range 304:4-320:5
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
//                     enclosing_range 307:16-312:9
          {
              1 => "one",
              2 => "two",
              _ => "more"
          };
          IAnimal dog = new Dog();
//        ^^^^^^^ read_access scip-dotnet nuget . . Main/Expressions#IAnimal#
//                enclosing_range 313:8-313:15
//                ^^^ definition local 78
//                    enclosing_range 304:4-320:5
//                    documentation ```cs\nIAnimal dog\n```
//                    kind Variable
//                    relationship type_definition scip-dotnet nuget . . Main/Expressions#IAnimal#
//                          ^^^ read_access scip-dotnet nuget . . Main/Expressions#Dog#
//                              enclosing_range 313:22-313:31
          var b = dog switch
//            ^ definition local 79
//              enclosing_range 304:4-320:5
//              documentation ```cs\nstring? b\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
//                ^^^ read_access local 78
//                    enclosing_range 314:16-319:9
          {
              Cat c => c.Sound(),
//            ^^^ read_access scip-dotnet nuget . . Main/Expressions#Cat#
//                enclosing_range 316:12-316:15
//                ^ definition local 80
//                  enclosing_range 304:4-320:5
//                  documentation ```cs\nCat c\n```
//                  kind Variable
//                  relationship type_definition scip-dotnet nuget . . Main/Expressions#Cat#
//                     ^ read_access local 80
//                       enclosing_range 316:21-316:30
//                       ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Cat#Sound().
//                             enclosing_range 316:21-316:30
              Dog c => c.Sound(),
//            ^^^ read_access scip-dotnet nuget . . Main/Expressions#Dog#
//                enclosing_range 317:12-317:15
//                ^ definition local 81
//                  enclosing_range 304:4-320:5
//                  documentation ```cs\nDog c\n```
//                  kind Variable
//                  relationship type_definition scip-dotnet nuget . . Main/Expressions#Dog#
//                     ^ read_access local 81
//                       enclosing_range 317:21-317:30
//                       ^^^^^ read_access scip-dotnet nuget . . Main/Expressions#Dog#Sound().
//                             enclosing_range 317:21-317:30
              _ => throw new ArgumentOutOfRangeException()
//                           ^^^^^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/ArgumentOutOfRangeException#
//                                                       enclosing_range 318:23-318:56
          };
      }

      void Dictionary()
//         ^^^^^^^^^^ definition scip-dotnet nuget . . Main/Expressions#Dictionary().
//                    enclosing_range 322:4-325:5
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
//            enclosing_range 327:4-338:5
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
//              enclosing_range 330:12-330:26
//                        ^^ definition local 84
//                           enclosing_range 327:4-338:5
//                           documentation ```cs\nstring s2\n```
//                           kind Variable
//                           relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
          {
              Console.WriteLine(s2);
//            ^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#
//                    enclosing_range 332:12-332:33
//                    ^^^^^^^^^ read_access scip-dotnet nuget System.Console 10.0.0.0 System/Console#WriteLine(+11).
//                              enclosing_range 332:12-332:33
//                              ^^ read_access local 84
//                                 enclosing_range 332:30-332:32
          }

          var c = s is "test";
//            ^ definition local 85
//              enclosing_range 327:4-338:5
//              documentation ```cs\nbool c\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
//                ^ read_access local 83
//                  enclosing_range 335:16-335:27
          var a = s is int.MaxValue;
//            ^ definition local 86
//              enclosing_range 327:4-338:5
//              documentation ```cs\nbool a\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
//                ^ read_access local 83
//                  enclosing_range 336:16-336:33
//                         ^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#MaxValue.
//                                  enclosing_range 336:21-336:33
          var d = s is nameof(a);
//            ^ definition local 87
//              enclosing_range 327:4-338:5
//              documentation ```cs\nbool d\n```
//              kind Variable
//              relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
//                ^ read_access local 83
//                  enclosing_range 337:16-337:30
//                            ^ read_access local 86
//                              enclosing_range 337:28-337:29
      }
  }
