  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ reference scip-dotnet nuget . . System/
'                enclosing_range 0:8-0:26
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39
'                ^^^^^^^^^^^ reference scip-dotnet nuget . . Diagnostics/
'                            enclosing_range 0:8-0:26
'                            ^^^^^^^^^^^^ reference scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39

  Namespace VBMain
'           ^^^^^^ reference scip-dotnet nuget . . VBMain/
'                  enclosing_range 2:10-2:16
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
'                      enclosing_range 3:5-3:20
      Public Class Events
'                  ^^^^^^ definition scip-dotnet nuget . . VBMain/Events#
'                         enclosing_range 3:4-4:23
'                         documentation ```vb\nClass Events\n```
          Private EventHandlerList As New ArrayList
'                 ^^^^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Events#EventHandlerList.
'                                  enclosing_range 5:8-5:49
'                                  documentation ```vb\nPrivate Events.EventHandlerList As ArrayList\n```
'                                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 Collections/ArrayList#
'                                         ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 Collections/ArrayList#
'                                                   enclosing_range 5:36-5:49

          Public Event Event1 As EventHandler(Of Integer)
'                      ^^^^^^ definition scip-dotnet nuget . . VBMain/Events#Event1#
'                             enclosing_range 7:8-7:55
'                             documentation ```vb\nPublic Event Events.Event1 As EventHandler(Of Integer)\n```
'                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#

          Public Custom Event Event2 As EventHandler
'                             ^^^^^^ definition scip-dotnet nuget . . VBMain/Events#Event2#
'                                    enclosing_range 9:8-9:50
'                                    documentation ```vb\nPublic Event Events.Event2 As EventHandler\n```
'                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                       ^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                                    enclosing_range 9:38-9:50

              AddHandler(ByVal value As EventHandler)
'                              ^^^^^ definition scip-dotnet nuget . . VBMain/Events#add_Event2().(value)
'                                    enclosing_range 11:12-11:51
'                                    documentation ```vb\nvalue As EventHandler\n```
'                                    relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                       ^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                                    enclosing_range 11:38-11:50
                  EventHandlerList.Add(value)
'                 ^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Events#EventHandlerList.
'                                  enclosing_range 12:16-12:43
'                                  ^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 Collections/ArrayList#Add().
'                                      enclosing_range 12:16-12:43
'                                      ^^^^^ reference scip-dotnet nuget . . VBMain/Events#add_Event2().(value)
'                                            enclosing_range 12:37-12:42
              End AddHandler

              RemoveHandler(ByVal value As EventHandler)
'                                 ^^^^^ definition scip-dotnet nuget . . VBMain/Events#remove_Event2().(value)
'                                       enclosing_range 15:12-15:54
'                                       documentation ```vb\nvalue As EventHandler\n```
'                                       relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                          ^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                                       enclosing_range 15:41-15:53
                  EventHandlerList.Remove(value)
'                 ^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Events#EventHandlerList.
'                                  enclosing_range 16:16-16:46
'                                  ^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 Collections/ArrayList#Remove().
'                                         enclosing_range 16:16-16:46
'                                         ^^^^^ reference scip-dotnet nuget . . VBMain/Events#remove_Event2().(value)
'                                               enclosing_range 16:40-16:45
              End RemoveHandler

              RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
'                              ^^^^^^ definition scip-dotnet nuget . . VBMain/Events#raise_Event2().(sender)
'                                     enclosing_range 19:12-19:68
'                                     documentation ```vb\nsender As Object\n```
'                                                      ^ definition scip-dotnet nuget . . VBMain/Events#raise_Event2().(e)
'                                                        enclosing_range 19:12-19:68
'                                                        documentation ```vb\ne As EventArgs\n```
'                                                        relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventArgs#
'                                                           ^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/EventArgs#
'                                                                     enclosing_range 19:58-19:67
                  For Each handler As EventHandler In EventHandlerList
'                          ^^^^^^^ definition local 0
'                                  enclosing_range 19:12-25:26
'                                  documentation ```vb\nhandler As Delegate Sub EventHandler(sender As Object, e As EventArgs)\n```
'                                  relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                     ^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#
'                                                  enclosing_range 20:36-20:48
'                                                     ^^^^^^^^^^^^^^^^ reference scip-dotnet nuget . . VBMain/Events#EventHandlerList.
'                                                                      enclosing_range 20:52-20:68
                      If handler IsNot Nothing Then
'                        ^^^^^^^ reference local 0
'                                enclosing_range 21:23-21:44
                          handler.BeginInvoke(sender, e, Nothing, Nothing)
'                         ^^^^^^^ reference local 0
'                                 enclosing_range 22:24-22:72
'                                 ^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/EventHandler#BeginInvoke().
'                                             enclosing_range 22:24-22:72
'                                             ^^^^^^ reference scip-dotnet nuget . . VBMain/Events#raise_Event2().(sender)
'                                                    enclosing_range 22:44-22:50
'                                                     ^ reference scip-dotnet nuget . . VBMain/Events#raise_Event2().(e)
'                                                       enclosing_range 22:52-22:53
                      End If
                  Next
              End RaiseEvent
          End Event

          Private Sub Event1Handler() Handles Me.Event1
'                     ^^^^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Events#Event1Handler().
'                                   enclosing_range 28:8-28:53
'                                   documentation ```vb\nPrivate Sub Events.Event1Handler()\n```
'                                                ^^^^^^ reference scip-dotnet nuget . . VBMain/Events#Event1#
'                                                       enclosing_range 28:47-28:53
              Throw New NotImplementedException()
'                       ^^^^^^^^^^^^^^^^^^^^^^^ reference scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
'                                               enclosing_range 29:18-29:47
          End Sub
      End Class
  End Namespace
