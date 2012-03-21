Public Class frmAddUpload
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim OFD As New OpenFileDialog
        OFD.Title = "Open Video File"
        If OFD.ShowDialog = DialogResult.OK Then
            txtFile.Text = OFD.FileName
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.DialogResult = DialogResult.OK
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    Private Sub frmAddUpload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Privacy.SelectedItem = Privacy.Items(0)
        Category.SelectedItem = Category.Items(0)
    End Sub
End Class