Public Class frmCommentObfuscator
    Dim TT1 As New ToolTip
    Dim F As New Functions.General
    Private Sub btnObfuscate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObfuscate.Click
        If txtInput.Text = "" Then
            TT1.IsBalloon = True
            TT1.ToolTipIcon = ToolTipIcon.Info
            TT1.InitialDelay = 0
            TT1.ShowAlways = True
            TT1.Show("Oops, you've forgot to enter a comment to obfuscate!", txtInput)
            Dim T As New CountDown(3)
            AddHandler T.TimesOut, AddressOf RemoveTT1
            T.Start()
        Else
            txtOutput.Text = F.CommentObfuscate(txtInput.Text)
        End If
    End Sub
    Private Sub RemoveTT1()
        TT1.RemoveAll()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub frmCommemtObfuscator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtOutput.ContextMenu = CM
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        My.Computer.Clipboard.SetText(txtOutput.Text)
    End Sub
End Class