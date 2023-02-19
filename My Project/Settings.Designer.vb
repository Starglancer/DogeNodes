﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property IPAddress() As String
            Get
                Return CType(Me("IPAddress"),String)
            End Get
            Set
                Me("IPAddress") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property NodePort() As String
            Get
                Return CType(Me("NodePort"),String)
            End Get
            Set
                Me("NodePort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Country")>  _
        Public Property Statistics() As String
            Get
                Return CType(Me("Statistics"),String)
            End Get
            Set
                Me("Statistics") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("9")>  _
        Public Property GreenToYellow() As Integer
            Get
                Return CType(Me("GreenToYellow"),Integer)
            End Get
            Set
                Me("GreenToYellow") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("18")>  _
        Public Property YellowToRed() As Integer
            Get
                Return CType(Me("YellowToRed"),Integer)
            End Get
            Set
                Me("YellowToRed") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("9")>  _
        Public ReadOnly Property GreenToYellowDefault() As Integer
            Get
                Return CType(Me("GreenToYellowDefault"),Integer)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("18")>  _
        Public ReadOnly Property YellowToRedDefault() As Integer
            Get
                Return CType(Me("YellowToRedDefault"),Integer)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property HideTrayIcon() As Boolean
            Get
                Return CType(Me("HideTrayIcon"),Boolean)
            End Get
            Set
                Me("HideTrayIcon") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public ReadOnly Property HideTrayIconDefault() As Boolean
            Get
                Return CType(Me("HideTrayIconDefault"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MinimiseToTray() As Boolean
            Get
                Return CType(Me("MinimiseToTray"),Boolean)
            End Get
            Set
                Me("MinimiseToTray") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property MinimiseToTrayDefault() As Boolean
            Get
                Return CType(Me("MinimiseToTrayDefault"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MinimiseOnClose() As Boolean
            Get
                Return CType(Me("MinimiseOnClose"),Boolean)
            End Get
            Set
                Me("MinimiseOnClose") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property MinimiseOnCloseDefault() As Boolean
            Get
                Return CType(Me("MinimiseOnCloseDefault"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Summary")>  _
        Public Property StartupTab() As String
            Get
                Return CType(Me("StartupTab"),String)
            End Get
            Set
                Me("StartupTab") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Summary")>  _
        Public ReadOnly Property StartupTabDefault() As String
            Get
                Return CType(Me("StartupTabDefault"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property WindowsNotification() As Boolean
            Get
                Return CType(Me("WindowsNotification"),Boolean)
            End Get
            Set
                Me("WindowsNotification") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property WindowsNotificationDefault() As Boolean
            Get
                Return CType(Me("WindowsNotificationDefault"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ApplicationNotification() As Boolean
            Get
                Return CType(Me("ApplicationNotification"),Boolean)
            End Get
            Set
                Me("ApplicationNotification") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public ReadOnly Property ApplicationNotificationDefault() As Boolean
            Get
                Return CType(Me("ApplicationNotificationDefault"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property AllowLogging() As Boolean
            Get
                Return CType(Me("AllowLogging"),Boolean)
            End Get
            Set
                Me("AllowLogging") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property AllowLoggingDefault() As Boolean
            Get
                Return CType(Me("AllowLoggingDefault"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property AllowEmailNotification() As Boolean
            Get
                Return CType(Me("AllowEmailNotification"),Boolean)
            End Get
            Set
                Me("AllowEmailNotification") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property AllowEmailNotificationDefault() As Boolean
            Get
                Return CType(Me("AllowEmailNotificationDefault"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Warning and Error")>  _
        Public Property WindowsNotificationLevel() As String
            Get
                Return CType(Me("WindowsNotificationLevel"),String)
            End Get
            Set
                Me("WindowsNotificationLevel") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Warning and Error")>  _
        Public ReadOnly Property WindowsNotificationLevelDefault() As String
            Get
                Return CType(Me("WindowsNotificationLevelDefault"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Warning and Error")>  _
        Public Property ApplicationNotificationLevel() As String
            Get
                Return CType(Me("ApplicationNotificationLevel"),String)
            End Get
            Set
                Me("ApplicationNotificationLevel") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Warning and Error")>  _
        Public ReadOnly Property ApplicationNotificationLevelDefault() As String
            Get
                Return CType(Me("ApplicationNotificationLevelDefault"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Warning and Error")>  _
        Public Property LoggingLevel() As String
            Get
                Return CType(Me("LoggingLevel"),String)
            End Get
            Set
                Me("LoggingLevel") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Warning and Error")>  _
        Public ReadOnly Property LoggingLevelDefault() As String
            Get
                Return CType(Me("LoggingLevelDefault"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Warning and Error")>  _
        Public Property EmailNotificationLevel() As String
            Get
                Return CType(Me("EmailNotificationLevel"),String)
            End Get
            Set
                Me("EmailNotificationLevel") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Warning and Error")>  _
        Public ReadOnly Property EmailNotificationLevelDefault() As String
            Get
                Return CType(Me("EmailNotificationLevelDefault"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SMTPHost() As String
            Get
                Return CType(Me("SMTPHost"),String)
            End Get
            Set
                Me("SMTPHost") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SMTPPort() As String
            Get
                Return CType(Me("SMTPPort"),String)
            End Get
            Set
                Me("SMTPPort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SMTPUsername() As String
            Get
                Return CType(Me("SMTPUsername"),String)
            End Get
            Set
                Me("SMTPUsername") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SMTPPassword() As String
            Get
                Return CType(Me("SMTPPassword"),String)
            End Get
            Set
                Me("SMTPPassword") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UseSSL() As Boolean
            Get
                Return CType(Me("UseSSL"),Boolean)
            End Get
            Set
                Me("UseSSL") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property EmailAddress() As String
            Get
                Return CType(Me("EmailAddress"),String)
            End Get
            Set
                Me("EmailAddress") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CurrentAgentVersion() As String
            Get
                Return CType(Me("CurrentAgentVersion"),String)
            End Get
            Set
                Me("CurrentAgentVersion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property StartMinimised() As Boolean
            Get
                Return CType(Me("StartMinimised"),Boolean)
            End Get
            Set
                Me("StartMinimised") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property StartMinimisedDefault() As Boolean
            Get
                Return CType(Me("StartMinimisedDefault"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property StartWithWindows() As Boolean
            Get
                Return CType(Me("StartWithWindows"),Boolean)
            End Get
            Set
                Me("StartWithWindows") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property StartWithWindowsDefault() As Boolean
            Get
                Return CType(Me("StartWithWindowsDefault"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property DesktopShortcut() As Boolean
            Get
                Return CType(Me("DesktopShortcut"),Boolean)
            End Get
            Set
                Me("DesktopShortcut") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public ReadOnly Property DesktopShortcutDefault() As Boolean
            Get
                Return CType(Me("DesktopShortcutDefault"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("v1.00")>  _
        Public ReadOnly Property DogeNodesVersion() As String
            Get
                Return CType(Me("DogeNodesVersion"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowTooltips() As Boolean
            Get
                Return CType(Me("ShowTooltips"),Boolean)
            End Get
            Set
                Me("ShowTooltips") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public ReadOnly Property ShowTooltipsDefault() As Boolean
            Get
                Return CType(Me("ShowTooltipsDefault"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property HighlightNode() As Boolean
            Get
                Return CType(Me("HighlightNode"),Boolean)
            End Get
            Set
                Me("HighlightNode") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public ReadOnly Property HighlightNodeDefault() As Boolean
            Get
                Return CType(Me("HighlightNodeDefault"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://sourceforge.net/projects/dogenodes/files/latest/download")>  _
        Public ReadOnly Property DownLoadURL() As String
            Get
                Return CType(Me("DownLoadURL"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("22556")>  _
        Public ReadOnly Property DefaultPort() As String
            Get
                Return CType(Me("DefaultPort"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://github.com/dogecoin/dogecoin")>  _
        Public ReadOnly Property DogecoinCoreURL() As String
            Get
                Return CType(Me("DogecoinCoreURL"),String)
            End Get
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.BlockchainNodes.My.MySettings
            Get
                Return Global.BlockchainNodes.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
