  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                enclosing_range 0:8-0:26
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . System/Diagnostics/CodeAnalysis/
'                                         enclosing_range 0:8-0:39
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . System/Diagnostics/
'                            enclosing_range 0:8-0:26
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . System/Diagnostics/CodeAnalysis/
'                                         enclosing_range 0:8-0:39

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/VBMain/
'                  enclosing_range 2:10-2:16
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/Diagnostics/CodeAnalysis/SuppressMessageAttribute#`.ctor`().
'                      enclosing_range 3:5-3:20
      Public Class Interfaces
'                  ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#
'                             enclosing_range 3:4-4:27
'                             documentation ```vb\nClass Interfaces\n```
          Interface IOne
'                   ^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IOne#
'                        enclosing_range 5:8-5:22
'                        documentation ```vb\nInterface IOne\n```
          End Interface

          Interface ITwo
'                   ^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#ITwo#
'                        enclosing_range 8:8-8:22
'                        documentation ```vb\nInterface ITwo\n```
          End Interface

          Interface IThree
'                   ^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IThree#
'                          enclosing_range 11:8-11:24
'                          documentation ```vb\nInterface IThree\n```
          End Interface

          Interface IProperties
'                   ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IProperties#
'                               enclosing_range 14:8-14:29
'                               documentation ```vb\nInterface IProperties\n```
              ReadOnly Property [Get] As Byte
'                               ^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IProperties#Get.
'                                     enclosing_range 15:12-15:43
'                                     documentation ```vb\nReadOnly Property IProperties.Get As Byte\n```
'                                     relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Byte#
              WriteOnly Property [Set] As Char
'                                ^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IProperties#Set.
'                                      enclosing_range 16:12-16:44
'                                      documentation ```vb\nWriteOnly Property IProperties.Set As Char\n```
'                                      relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Char#
              Property GetSet As UInteger
'                      ^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IProperties#GetSet.
'                             enclosing_range 17:12-17:39
'                             documentation ```vb\nProperty IProperties.GetSet As UInteger\n```
'                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/UInt32#
              Property SetGet As Long
'                      ^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IProperties#SetGet.
'                             enclosing_range 18:12-18:35
'                             documentation ```vb\nProperty IProperties.SetGet As Long\n```
'                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#
          End Interface

          Interface IMethods
'                   ^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IMethods#
'                            enclosing_range 21:8-21:26
'                            documentation ```vb\nInterface IMethods\n```
              Sub [Nothing]()
'                 ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IMethods#Nothing().
'                           enclosing_range 22:12-22:27
'                           documentation ```vb\nSub IMethods.Nothing()\n```
              Function Output() As Integer
'                      ^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IMethods#Output().
'                             enclosing_range 23:12-23:40
'                             documentation ```vb\nFunction IMethods.Output() As Integer\n```
              Sub Input(ByVal a As String)
'                 ^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IMethods#Input().
'                       enclosing_range 24:12-24:40
'                       documentation ```vb\nSub IMethods.Input(a As String)\n```
'                             ^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IMethods#Input().(a)
'                               enclosing_range 24:12-24:40
'                               documentation ```vb\na As String\n```
'                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
              Function InputOutput(ByVal a As String) As Integer
'                      ^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IMethods#InputOutput().
'                                  enclosing_range 25:12-25:62
'                                  documentation ```vb\nFunction IMethods.InputOutput(a As String) As Integer\n```
'                                        ^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IMethods#InputOutput().(a)
'                                          enclosing_range 25:12-25:62
'                                          documentation ```vb\na As String\n```
'                                          relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/String#
          End Interface

          Interface IEvent
'                   ^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IEvent#
'                          enclosing_range 28:8-28:24
'                          documentation ```vb\nInterface IEvent\n```
              Event SomeEvent As EventHandler(Of Integer)
'                   ^^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IEvent#SomeEvent#
'                             enclosing_range 29:12-29:55
'                             documentation ```vb\nEvent IEvent.SomeEvent As EventHandler(Of Integer)\n```
'                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
          End Interface

          Interface IIndex
'                   ^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IIndex#
'                          enclosing_range 32:8-32:24
'                          documentation ```vb\nInterface IIndex\n```
              Default Property Item(ByVal index As Integer) As Boolean
'                              ^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IIndex#Item.
'                                   enclosing_range 33:12-33:68
'                                   documentation ```vb\nDefault Property IIndex.Item(index As Integer) As Boolean\n```
'                                   relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Boolean#
'                                         ^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IIndex#Item.(index)
'                                               enclosing_range 33:12-33:68
'                                               documentation ```vb\nindex As Integer\n```
'                                               relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int32#
          End Interface

          Private Interface IInherit
'                           ^^^^^^^^ definition scip-dotnet nuget . . VBMain/VBMain/Interfaces#IInherit#
'                                    enclosing_range 36:8-36:34
'                                    documentation ```vb\nInterface IInherit\n```
'                                    relationship implementation scip-dotnet nuget . . VBMain/VBMain/Interfaces#IOne#
'                                    relationship implementation scip-dotnet nuget . . VBMain/VBMain/Interfaces#ITwo#
              Inherits IOne, ITwo
'                      ^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Interfaces#IOne#
'                           enclosing_range 37:21-37:25
'                            ^^^^ reference scip-dotnet nuget . . VBMain/VBMain/Interfaces#ITwo#
'                                 enclosing_range 37:27-37:31
          End Interface
      End Class
  End Namespace
