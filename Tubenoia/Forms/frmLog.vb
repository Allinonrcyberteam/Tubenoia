Public Class frmLog
    Dim F As New Functions.General
    Private Sub frmLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TIME.ImageKey = IL.Images.Keys(0)
        CONTENT.ImageKey = IL.Images.Keys(1)
        Log.ContextMenu = CM
        CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub frmLog_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CONTENT.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        For Each itm As ListViewItem In Log.SelectedItems
            itm.Remove()
        Next
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        For Each itm As ListViewItem In Log.Items
            itm.Selected = True
        Next
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim SD As New SaveFileDialog
        SD.Filter = "Text Files (*.txt)|*.txt"
        SD.FilterIndex = 1
        SD.Title = "Export log"
        SD.FileName = "Log.txt"
        If SD.ShowDialog = DialogResult.OK Then
            F.ExportList(Log, SD.FileName)
            F.Logs("Log exported to " & SD.FileName, 2, IL, Log)
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Log.Items.Clear()
    End Sub
End Class