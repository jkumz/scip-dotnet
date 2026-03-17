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
'                      enclosing_range 3:4-4:23
      Public Class Events
'                  ^^^^^^ definition scip-dotnet nuget . . VBMain/Events#
'                         enclosing_range 3:4-31:13
'                         documentation ```vb\nClass Events\n```
'                         kind Class
          Private EventHandlerList As New ArrayList
'                 ^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Events#EventHandlerList.
'                                  enclosing_range 5:8-5:49
'                                  documentation ```vb\nPrivate Events.EventHandlerList As ArrayList\n```
'                                  kind Field
'                                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Collections/ArrayList#
'                                         ^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 Collections/ArrayList#
'                                                   enclosing_range 5:8-5:49

          Public Event Event1 As EventHandler(Of Integer)
'                      ^^^^^^ definition scip-dotnet nuget . . VBMain/Events#Event1#
'                             enclosing_range 3:4-31:13
'                             documentation ```vb\nPublic Event Events.Event1 As EventHandler(Of Integer)\n```
'                             kind Event
'                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#

          Public Custom Event Event2 As EventHandler
'                             ^^^^^^ definition scip-dotnet nuget . . VBMain/Events#Event2#
'                                    enclosing_range 9:8-26:17
'                                    documentation ```vb\nPublic Event Events.Event2 As EventHandler\n```
'                                    kind Event
'                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                       ^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                                    enclosing_range 9:8-9:50

              AddHandler(ByVal value As EventHandler)
'                              ^^^^^ definition scip-dotnet nuget . . VBMain/Events#add_Event2().(value)
'                                    enclosing_range 11:12-11:51
'                                    documentation ```vb\nvalue As EventHandler\n```
'                                    kind Parameter
'                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                       ^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                                    enclosing_range 11:12-11:51
                  EventHandlerList.Add(value)
'                 ^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Events#EventHandlerList.
'                                  enclosing_range 11:12-13:26
'                                  ^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 Collections/ArrayList#Add().
'                                      enclosing_range 11:12-13:26
'                                      ^^^^^ read_access scip-dotnet nuget . . VBMain/Events#add_Event2().(value)
'                                            enclosing_range 11:12-13:26
              End AddHandler

              RemoveHandler(ByVal value As EventHandler)
'                                 ^^^^^ definition scip-dotnet nuget . . VBMain/Events#remove_Event2().(value)
'                                       enclosing_range 15:12-15:54
'                                       documentation ```vb\nvalue As EventHandler\n```
'                                       kind Parameter
'                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                          ^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                                       enclosing_range 15:12-15:54
                  EventHandlerList.Remove(value)
'                 ^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Events#EventHandlerList.
'                                  enclosing_range 15:12-17:29
'                                  ^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 Collections/ArrayList#Remove().
'                                         enclosing_range 15:12-17:29
'                                         ^^^^^ read_access scip-dotnet nuget . . VBMain/Events#remove_Event2().(value)
'                                               enclosing_range 15:12-17:29
              End RemoveHandler

              RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
'                              ^^^^^^ definition scip-dotnet nuget . . VBMain/Events#raise_Event2().(sender)
'                                     enclosing_range 19:12-19:68
'                                     documentation ```vb\nsender As Object\n```
'                                     kind Parameter
'                                                      ^ definition scip-dotnet nuget . . VBMain/Events#raise_Event2().(e)
'                                                        enclosing_range 19:12-19:68
'                                                        documentation ```vb\ne As EventArgs\n```
'                                                        kind Parameter
'                                                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventArgs#
'                                                           ^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/EventArgs#
'                                                                     enclosing_range 19:12-19:68
                  For Each handler As EventHandler In EventHandlerList
'                          ^^^^^^^ definition local 0
'                                  enclosing_range 19:12-25:26
'                                  documentation ```vb\nhandler As Delegate Sub EventHandler(sender As Object, e As EventArgs)\n```
'                                  kind Variable
'                                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                     ^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                                  enclosing_range 19:12-25:26
'                                                     ^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget . . VBMain/Events#EventHandlerList.
'                                                                      enclosing_range 19:12-25:26
                      If handler IsNot Nothing Then
'                        ^^^^^^^ read_access local 0
'                                enclosing_range 19:12-25:26
                          handler.BeginInvoke(sender, e, Nothing, Nothing)
'                         ^^^^^^^ read_access local 0
'                                 enclosing_range 19:12-25:26
'                                 ^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#BeginInvoke().
'                                             enclosing_range 19:12-25:26
'                                             ^^^^^^ read_access scip-dotnet nuget . . VBMain/Events#raise_Event2().(sender)
'                                                    enclosing_range 19:12-25:26
'                                                     ^ read_access scip-dotnet nuget . . VBMain/Events#raise_Event2().(e)
'                                                       enclosing_range 19:12-25:26
                      End If
                  Next
              End RaiseEvent
          End Event

          Private Sub Event1Handler() Handles Me.Event1
'                     ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Events#Event1Handler().
'                                   enclosing_range 28:8-30:15
'                                   documentation ```vb\nPrivate Sub Events.Event1Handler()\n```
'                                   kind Method
'                                                ^^^^^^ read_access scip-dotnet nuget . . VBMain/Events#Event1#
'                                                       enclosing_range 28:8-28:53
              Throw New NotImplementedException()
'                       ^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
'                                               enclosing_range 28:8-30:15
          End Sub
      End Class
  End Namespace
