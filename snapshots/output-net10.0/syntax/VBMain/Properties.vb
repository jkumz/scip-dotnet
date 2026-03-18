  Imports System.Diagnostics.CodeAnalysis
'         ^^^^^^ read_access scip-dotnet nuget . . System/
'                enclosing_range 0:8-0:26
'         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ import scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39
'                ^^^^^^^^^^^ read_access scip-dotnet nuget . . Diagnostics/
'                            enclosing_range 0:8-0:26
'                            ^^^^^^^^^^^^ read_access scip-dotnet nuget . . CodeAnalysis/
'                                         enclosing_range 0:8-0:39

  Namespace VBMain
'           ^^^^^^ read_access scip-dotnet nuget . . VBMain/
'                  enclosing_range 2:10-2:16
      <SuppressMessage("ReSharper", "all")>
'      ^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 CodeAnalysis/SuppressMessageAttribute#`.ctor`().
'                      enclosing_range 3:5-3:20
      Public Class Properties
'                  ^^^^^^^^^^ definition scip-dotnet nuget . . VBMain/Properties#
'                             enclosing_range 3:4-4:27
'                             documentation ```vb\nClass Properties\n```
'                             kind Class
          Private ReadOnly Property [Get] As Byte
'                                   ^^^^^ definition scip-dotnet nuget . . VBMain/Properties#Get.
'                                         enclosing_range 5:8-5:47
'                                         documentation ```vb\nPrivate ReadOnly Property Properties.Get As Byte\n```
'                                         kind Property
'                                         relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Byte#

          Private WriteOnly Property [Set] As Char
'                                    ^^^^^ definition scip-dotnet nuget . . VBMain/Properties#Set.
'                                          enclosing_range 7:8-7:48
'                                          documentation ```vb\nPrivate WriteOnly Property Properties.Set As Char\n```
'                                          kind Property
'                                          relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Char#
              Set(ByVal value As Char)
'                       ^^^^^ definition scip-dotnet nuget . . VBMain/Properties#set_Set().(value)
'                             enclosing_range 8:12-8:36
'                             documentation ```vb\nvalue As Char\n```
'                             kind Parameter
'                             relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Char#
                  Throw New NotImplementedException()
'                           ^^^^^^^^^^^^^^^^^^^^^^^ read_access scip-dotnet nuget System.Runtime 10.0.0.0 System/NotImplementedException#
'                                                   enclosing_range 9:22-9:51
              End Set
          End Property

          Private Property GetSet As UInteger
'                          ^^^^^^ definition scip-dotnet nuget . . VBMain/Properties#GetSet.
'                                 enclosing_range 13:8-13:43
'                                 documentation ```vb\nPrivate Property Properties.GetSet As UInteger\n```
'                                 kind Property
'                                 relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/UInt32#
          Private Property SetGet As Long
'                          ^^^^^^ definition scip-dotnet nuget . . VBMain/Properties#SetGet.
'                                 enclosing_range 14:8-14:39
'                                 documentation ```vb\nPrivate Property Properties.SetGet As Long\n```
'                                 kind Property
'                                 relationship type_definition scip-dotnet nuget System.Runtime 10.0.0.0 System/Int64#
      End Class
  End Namespace
