Public Class frmFilters
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnUserFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserFilter.Click
        frmUserFilter.Show()
    End Sub
    Private Sub btnVideoFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVideoFilter.Click
        frmVideoFilter.Show()
    End Sub
End Class