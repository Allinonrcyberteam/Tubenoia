Imports ProjectWIFE
Imports System.Text.RegularExpressions
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Public Class frmMain
    Public Version As String = "1.0.0.74"
    Private INI As INI
    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)> _
    Public Shared Function IsDebuggerPresent() As Boolean
    End Function
    Private Sub frmMain_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If IsDebuggerPresent() = False Then
            If Not IO.File.Exists(My.Application.Info.DirectoryPath & "\config.ini") Then
                Dim config As New System.IO.StreamWriter(My.Application.Info.DirectoryPath & "\config.ini")
                config.Write(My.Resources.config)
                config.Close()
            End If
            INI = New INI(Configuration.INI_Configuration.DefaultConfig, My.Application.Info.DirectoryPath & "\config.ini")
            Try
                If INI("General")("Changelog").Value = "0" Then
                End If
            Catch
                Dim config As New System.IO.StreamWriter(My.Application.Info.DirectoryPath & "\config.ini")
                config.Write(My.Resources.config)
                config.Close()
                INI = New INI(Configuration.INI_Configuration.DefaultConfig, My.Application.Info.DirectoryPath & "\config.ini")
            End Try
            If INI("General")("First").Value = "0" Then
                CreateDefaultSettings()
            End If
            Theme.Text += "  [Version " & Version & "]"
            Me.Text += "  [Version " & Version & "]"
            'Try
            '    If T.Message.Length <> 14 Then : MsgBox(T.Message) : End If
            'Catch
            'End Try
            If INI("General")("Changelog").Value = "0" Then
                frmChangeLog.ShowDialog(Me)
                INI("General")("Changelog").Value = "1"
                INI.Save()
            End If
            'If T.Check(T.Username, T.Serial) = False Then
            '    No()
            'End If
            'If T.Time = 1337 Then
            '    No()
            'End If
        Else
            Environment.Exit(0)
        End If
    End Sub
    Public Sub No()
        Environment.Exit(0)
    End Sub
    Private Sub CreateDefaultSettings()
        INI("General")("Changelog").Value = "0"
        INI("General")("First").Value = "1"
        INI("Captcha")("UseDBC").Value = "Dismiss"
        INI("General")("Threads").Value = "1"
        INI.Save()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnLogViewer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogViewer.Click
        frmLog.Show()
    End Sub
    Private Sub btnRankChecker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRankChecker.Click
        frmRank.Show()
    End Sub
    Private Sub btnVideoScraper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVideoScraper.Click
        frmVideoScraper.Show()
    End Sub
    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        frmSettings.Show()
    End Sub
    Private Sub btnAccountChecker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccountChecker.Click
        frmAccountChecker.Show()
    End Sub
    Private Sub btnUserScrapers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserScrapers.Click
        frmUserScraper.Show()
    End Sub
    Private Sub btnFilters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilters.Click
        frmFilters.Show()
    End Sub
    Private Sub btnMassDownloader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMassDownloader.Click
        frmMassDownload.Show()
    End Sub
    Private Sub btnTools_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTools.Click
        frmTools.Show()
    End Sub
    Private Sub btnMassUploader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMassUploader.Click
        frmMassUploader.Show()
    End Sub
    Private Sub btnMassFriendAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMassFriendAdd.Click
        frmFriendAdder.Show()
    End Sub
    Private Sub btnMassMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMassMessage.Click

    End Sub
End Class
