  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ read_access scip-dotnet nuget . . System/
'                enclosing_range 0:0-0:39
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:0-0:39
'                ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
'                            enclosing_range 0:0-0:39
'                            ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:0-0:39

  Namespace VBMain
'           ^^^^^^ read_access scip-dotnet nuget . . VBMain/
'                  enclosing_range 2:0-2:16
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
'                      enclosing_range 3:4-4:27
      Public Class Interfaces
'                  ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#
'                             enclosing_range 3:4-39:13
'                             documentation ```vb\nClass Interfaces\n```
'                             kind Class
          Interface IOne
'                   ^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IOne#
'                        enclosing_range 5:8-6:21
'                        documentation ```vb\nInterface IOne\n```
'                        kind Interface
          End Interface

          Interface ITwo
'                   ^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#ITwo#
'                        enclosing_range 8:8-9:21
'                        documentation ```vb\nInterface ITwo\n```
'                        kind Interface
          End Interface

          Interface IThree
'                   ^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IThree#
'                          enclosing_range 11:8-12:21
'                          documentation ```vb\nInterface IThree\n```
'                          kind Interface
          End Interface

          Interface IProperties
'                   ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IProperties#
'                               enclosing_range 14:8-19:21
'                               documentation ```vb\nInterface IProperties\n```
'                               kind Interface
              ReadOnly Property [Get] As Byte
'                               ^^^^^ definition forward_definition scip-dotnet nuget . . VBMain/Interfaces#IProperties#Get.
'                                     enclosing_range 14:8-19:21
'                                     documentation ```vb\nReadOnly Property IProperties.Get As Byte\n```
'                                     kind Property
'                                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Byte#
              WriteOnly Property [Set] As Char
'                                ^^^^^ definition forward_definition scip-dotnet nuget . . VBMain/Interfaces#IProperties#Set.
'                                      enclosing_range 14:8-19:21
'                                      documentation ```vb\nWriteOnly Property IProperties.Set As Char\n```
'                                      kind Property
'                                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Char#
              Property GetSet As UInteger
'                      ^^^^^^ definition forward_definition scip-dotnet nuget . . VBMain/Interfaces#IProperties#GetSet.
'                             enclosing_range 14:8-19:21
'                             documentation ```vb\nProperty IProperties.GetSet As UInteger\n```
'                             kind Property
'                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/UInt32#
              Property SetGet As Long
'                      ^^^^^^ definition forward_definition scip-dotnet nuget . . VBMain/Interfaces#IProperties#SetGet.
'                             enclosing_range 14:8-19:21
'                             documentation ```vb\nProperty IProperties.SetGet As Long\n```
'                             kind Property
'                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#
          End Interface

          Interface IMethods
'                   ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IMethods#
'                            enclosing_range 21:8-26:21
'                            documentation ```vb\nInterface IMethods\n```
'                            kind Interface
              Sub [Nothing]()
'                 ^^^^^^^^^ definition forward_definition scip-dotnet nuget . . VBMain/Interfaces#IMethods#Nothing().
'                           enclosing_range 21:8-26:21
'                           documentation ```vb\nSub IMethods.Nothing()\n```
'                           kind AbstractMethod
              Function Output() As Integer
'                      ^^^^^^ definition forward_definition scip-dotnet nuget . . VBMain/Interfaces#IMethods#Output().
'                             enclosing_range 21:8-26:21
'                             documentation ```vb\nFunction IMethods.Output() As Integer\n```
'                             kind AbstractMethod
              Sub Input(ByVal a As String)
'                 ^^^^^ definition forward_definition scip-dotnet nuget . . VBMain/Interfaces#IMethods#Input().
'                       enclosing_range 21:8-26:21
'                       documentation ```vb\nSub IMethods.Input(a As String)\n```
'                       kind AbstractMethod
'                             ^ definition scip-dotnet nuget . . VBMain/Interfaces#IMethods#Input().(a)
'                               enclosing_range 24:12-24:40
'                               documentation ```vb\na As String\n```
'                               kind Parameter
'                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
              Function InputOutput(ByVal a As String) As Integer
'                      ^^^^^^^^^^^ definition forward_definition scip-dotnet nuget . . VBMain/Interfaces#IMethods#InputOutput().
'                                  enclosing_range 21:8-26:21
'                                  documentation ```vb\nFunction IMethods.InputOutput(a As String) As Integer\n```
'                                  kind AbstractMethod
'                                        ^ definition scip-dotnet nuget . . VBMain/Interfaces#IMethods#InputOutput().(a)
'                                          enclosing_range 25:12-25:62
'                                          documentation ```vb\na As String\n```
'                                          kind Parameter
'                                          relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
          End Interface

          Interface IEvent
'                   ^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IEvent#
'                          enclosing_range 28:8-30:21
'                          documentation ```vb\nInterface IEvent\n```
'                          kind Interface
              Event SomeEvent As EventHandler(Of Integer)
'                   ^^^^^^^^^ definition forward_definition scip-dotnet nuget . . VBMain/Interfaces#IEvent#SomeEvent#
'                             enclosing_range 28:8-30:21
'                             documentation ```vb\nEvent IEvent.SomeEvent As EventHandler(Of Integer)\n```
'                             kind Event
'                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
          End Interface

          Interface IIndex
'                   ^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IIndex#
'                          enclosing_range 32:8-34:21
'                          documentation ```vb\nInterface IIndex\n```
'                          kind Interface
              Default Property Item(ByVal index As Integer) As Boolean
'                              ^^^^ definition forward_definition scip-dotnet nuget . . VBMain/Interfaces#IIndex#Item.
'                                   enclosing_range 32:8-34:21
'                                   documentation ```vb\nDefault Property IIndex.Item(index As Integer) As Boolean\n```
'                                   kind Property
'                                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
'                                         ^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IIndex#Item.(index)
'                                               enclosing_range 33:12-33:68
'                                               documentation ```vb\nindex As Integer\n```
'                                               kind Parameter
'                                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          End Interface

          Private Interface IInherit
'                           ^^^^^^^^ definition scip-dotnet nuget . . VBMain/Interfaces#IInherit#
'                                    enclosing_range 36:8-38:21
'                                    documentation ```vb\nInterface IInherit\n```
'                                    kind Interface
'                                    relationship implementation scip-dotnet nuget . . VBMain/Interfaces#IOne#
'                                    relationship implementation scip-dotnet nuget . . VBMain/Interfaces#ITwo#
              Inherits IOne, ITwo
'                      ^^^^ read_access scip-dotnet nuget . . VBMain/Interfaces#IOne#
'                           enclosing_range 37:12-37:31
'                            ^^^^ read_access scip-dotnet nuget . . VBMain/Interfaces#ITwo#
'                                 enclosing_range 37:12-37:31
          End Interface
      End Class
  End Namespace
