Public Class frmAddVideo
    Private F As New Functions.General
    Public V As String = Nothing
    Public R As String = Nothing
    Private Sub frmAddVideo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        F.SetCueText(txtVideo, "http://www.youtube.com/watch?v=ID")
        Resolution.SelectedItem = Resolution.Items(0)
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtVideo.Text.Contains("?v=") Then
            V = txtVideo.Text
            R = Resolution.Text
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Video link is invalid! You wrote: " & txtVideo.Text, MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class