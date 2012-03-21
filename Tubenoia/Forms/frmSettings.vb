Imports DeathByCaptcha
Imports ProjectWIFE
Public Class frmSettings
    'SaveSetting -> Application.ProductName
    'GetSetting
    Dim F As New Functions.General
    Private INI As INI
    Private Sub CreateDefaultSettings()
        INI("General")("Changelog").Value = "0"
        INI("General")("First").Value = "1"
        INI("Captcha")("UseDBC").Value = "Dismiss"
        INI("General")("Threads").Value = "1"
        INI.Save()
    End Sub
    Private Sub LoadSettings()
        Dim Threads As Integer = CInt(INI("General")("Threads").Value)
        If Threads > 50 Then
            Threads = 50
            tbThreads.Value = Threads
        Else
            tbThreads.Value = Threads
        End If
        Dim UseDBC As String = INI("Captcha")("UseDBC").Value
        If UseDBC = "Use" Then
            txtDBCUser.Text = INI("Captcha")("DBCU").Value
            txtDBCPass.Text = INI("Captcha")("DBCP").Value
            Timeout.Value = INI("Captcha")("DBCTimeout").Value
            chkDBC.Checked = True
            chkDismissCaptcha.Checked = False
        ElseIf UseDBC = "Dismiss" Then
            chkDBC.Checked = False
            chkDismissCaptcha.Checked = True
        ElseIf UseDBC = "Manual" Then
            chkManualCaptcha.Checked = True
        End If
    End Sub
    Private Sub SaveSettings()
        Dim Threads As Integer = CInt(INI("General")("Threads").Value)
        If Not Threads = tbThreads.Value Then
            INI("General")("Threads").Value = tbThreads.Value
        End If
        If chkDBC.Checked = True Then
            INI("Captcha")("UseDBC").Value = "Use"
            INI("Captcha")("DBCU").Value = txtDBCUser.Text
            INI("Captcha")("DBCP").Value = txtDBCPass.Text
            INI("Captcha")("DBCTimeout").Value = Timeout.Value
        ElseIf chkDismissCaptcha.Checked = True Then
            INI("Captcha")("UseDBC").Value = "Dismiss"
        ElseIf chkManualCaptcha.Checked = True Then
            INI("Captcha")("UseDBC").Value = "Manual"
        End If
        INI.Tidy()
        INI.Save()
    End Sub
    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Menu.ExpandAll()
        If Not IO.File.Exists(My.Application.Info.DirectoryPath & "\config.ini") Then
            Dim config As New System.IO.StreamWriter(My.Application.Info.DirectoryPath & "\config.ini")
            config.Write(My.Resources.config)
            config.Close()
        End If
        INI = New INI(Configuration.INI_Configuration.DefaultConfig, My.Application.Info.DirectoryPath & "\config.ini")
        If INI("General")("First").Value = "0" Then
            CreateDefaultSettings()
        End If
        LoadSettings()
        lblNumThreads.Text = tbThreads.Value
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Me.Hide()
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Menu_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles Menu.AfterSelect
        Select Case StrConv(e.Node.Text, VbStrConv.Lowercase)
            Case "multithreading"
                Page.CurrentFrame = 1
                Title.Text = e.Node.Text
            Case "captcha"
                Page.CurrentFrame = 2
                Title.Text = e.Node.Text
                F.SetCueText(txtDBCPass, "Enter your Death by Captcha USERNAME")
                F.SetCueText(txtDBCUser, "Enter your Death by Captcha PASSWORD")
            Case Else
                Page.CurrentFrame = 0
                Title.Text = "Information"
        End Select
    End Sub
    Private Sub tbThreads_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbThreads.Scroll
        lblNumThreads.Text = tbThreads.Value
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveSettings()
        MsgBox("Your settings have been changed successfully!", MsgBoxStyle.Information, "Tubenoia Settings")
    End Sub
    Private Sub btnDBCVerify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDBCVerify.Click
        Try
            Dim Login As New HttpClient(txtDBCUser.Text, txtDBCPass.Text)
            lblDBCUsername.Text = txtDBCUser.Text
            lblDBCBalance.Text = "$" & (Login.Balance / 100).ToString("F2")
            lblDBCValid.Text = "Yes"
            lblDBCValid.ForeColor = Color.LimeGreen
        Catch ex As AccessDeniedException
            lblDBCUsername.Text = txtDBCUser.Text
            lblDBCBalance.Text = "$0.00"
            lblDBCValid.Text = "No"
            lblDBCValid.ForeColor = Color.Red
        End Try
    End Sub
    Private Sub ToggleDBC(ByVal Visible As Boolean)
        txtDBCPass.Enabled = Visible
        txtDBCUser.Enabled = Visible
        btnDBCVerify.Enabled = Visible
        Timeout.Enabled = Visible
    End Sub
    Private Sub chkDBC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDBC.CheckedChanged
        If txtDBCPass.Enabled = True Then
            ToggleDBC(False)
        Else
            ToggleDBC(True)
        End If
    End Sub
End Class