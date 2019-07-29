﻿'//////////////////////////////////////////////////////////////////////////////
'
' This file was automatically generated by RANOREX.
' DO NOT MODIFY THIS FILE! It is regenerated by the designer.
' All your modifications will be lost!
' http://www.ranorex.com
'
'//////////////////////////////////////////////////////////////////////////////

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Threading
Imports WinForms = System.Windows.Forms

Imports Ranorex
Imports Ranorex.Core
Imports Ranorex.Core.Testing
Imports Ranorex.Core.Repository

Namespace RemoteTest
    ''' <summary>
    '''The OpenBrowser recording.
    ''' </summary>
    <TestModule("1c2dfa70-ebc9-4fdc-b41d-956584f2f009", ModuleType.Recording, 1)> _
    Partial Public Class OpenBrowser
        Implements ITestModule
    
        ''' <summary>
        ''' Holds an instance of the RemoteTestRepository repository.
        ''' </summary>
        Public Shared repo as RemoteTestRepository = RemoteTestRepository.Instance
    
        Shared _instance as OpenBrowser = new OpenBrowser()
    
        ''' <summary>
        ''' Constructs a new instance.
        ''' </summary>
        Sub New()
        End Sub
    
        ''' <summary>
        ''' Gets a static instance of this recording.
        ''' </summary>
        Public Shared ReadOnly Property Instance As OpenBrowser
            Get
                Return _instance
            End Get
        End Property

#Region "Variables"

#End Region

        ''' <summary>
        ''' Starts the replay of the static recording <see cref="Instance"/>.
        ''' </summary>
            <System.CodeDom.Compiler.GeneratedCode("Ranorex", Global.Ranorex.Core.Constants.CodeGenVersion)> _
        Public Shared Sub Start()
            TestModuleRunner.Run(Instance)
        End Sub
    
        ''' <summary>
        ''' Performs the playback of actions in this recording.
        ''' </summary>
        ''' <remarks>You should not call this method directly, instead pass the module
        ''' instance to the <see cref="TestModuleRunner.Run(Of ITestModule)"/> method
        ''' that will in turn invoke this method.</remarks>
        <System.CodeDom.Compiler.GeneratedCode("Ranorex", Global.Ranorex.Core.Constants.CodeGenVersion)> _
        Sub Run() Implements ITestModule.Run
            Mouse.DefaultMoveTime = 300
            Keyboard.DefaultKeyPressTime = 20
            Delay.SpeedFactor = 1.00
    
            Init()
    
            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.ranorex.com' with browser 'chrome' in normal mode.", new RecordItemIndex(0))
            Host.Current.OpenBrowser("https://www.ranorex.com", "chrome", "", False, False, False, False, False, True)
            Delay.Milliseconds(0)
            
        End Sub

#Region "Image Feature Data"
#End Region

    End Class

End Namespace