Public Class frmCaptcha
    Private Sub nbutton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResolved.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub frmCaptcha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class