﻿'------------------------------------------------------------------------------
' <auto-generated>
<<<<<<< HEAD
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.42000
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
=======
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
>>>>>>> aee8daaeeb741c5ab5122162078b19f147d3567e
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

<<<<<<< HEAD

Namespace My
    
    'REMARQUE : Ce fichier étant généré automatiquement, ne le modifiez pas directement.  Pour apporter des modifications,
    ' ou si vous rencontrez des erreurs de build dans ce fichier, accédez au Concepteur de projets
    ' (allez dans les propriétés du projet ou double-cliquez sur le nœud My Project dans
    ' l'Explorateur de solutions), puis apportez vos modifications sous l'onglet Application.
    '
    Partial Friend Class MyApplication
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Public Sub New()
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = false
            Me.EnableVisualStyles = true
            Me.SaveMySettingsOnExit = true
            Me.ShutDownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
            Me.HighDpiMode = HighDpiMode.DpiUnaware
        End Sub
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Global.vb_projet.adminform
        End Sub
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
            Me.MinimumSplashScreenDisplayTime = 0
            Return MyBase.OnInitialize(commandLineArgs)
        End Function
=======
Namespace My

    'NOTE: This file is auto-generated; do not modify it directly.  To make changes,
    ' or if you encounter build errors in this file, go to the Project Designer
    ' (go to Project Properties or double-click the My Project node in
    ' Solution Explorer), and make changes on the Application tab.
    '
    Partial Friend Class MyApplication

        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Public Sub New()
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = False
            Me.EnableVisualStyles = True
            Me.SaveMySettingsOnExit = True
            Me.ShutDownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub

        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Form1
        End Sub
>>>>>>> aee8daaeeb741c5ab5122162078b19f147d3567e
    End Class
End Namespace
