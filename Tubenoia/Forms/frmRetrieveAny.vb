Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Public Class frmRetrieveAny
    Dim F As New Functions.General
    Private Sub frmRetrieveAny_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        lstChannels.ContextMenu = CM
    End Sub
    Private Sub frmRetrieveAny_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Channel.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        lstChannels.Items.Clear()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim SD As New SaveFileDialog
        SD.Filter = "Tubenoia Channel List (*.TNCL)|*.TNCL"
        SD.FilterIndex = 1
        SD.Title = "Export Channel List"
        SD.FileName = "custom_scraped.TNSL"
        If SD.ShowDialog = DialogResult.OK Then
            Dim fStream As New FileStream(SD.FileName, FileMode.Create)
            Dim binFormat As New BinaryFormatter
            Dim stuff As New List(Of ListViewItem)
            For Each itm As ListViewItem In lstChannels.Items
                stuff.Add(itm)
            Next
            binFormat.Serialize(fStream, stuff)
            F.Logs("Custom Scraper list exported to " & SD.FileName, 2, frmLog.IL, frmLog.Log)
            fStream.Close()
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim S As New StringBuilder
        For Each itm As ListViewItem In lstChannels.Items
            If itm.Index = lstChannels.Items.Count - 1 Then
                S.Append(itm.Text)
            Else
                S.AppendLine(itm.Text)
            End If
        Next
        Dim SD As New SaveFileDialog
        SD.Filter = "Text File (*.txt)|*.txt"
        SD.FilterIndex = 1
        SD.Title = "Export Channel List"
        SD.FileName = "custom_scraped.txt"
        If SD.ShowDialog = DialogResult.OK Then
            Dim Sys As New System.IO.StreamWriter(SD.FileName)
            Sys.Write(S.ToString)
            Sys.Flush()
            Sys.Dispose()
            F.Logs("Custom Scraper list exported to " & SD.FileName, 2, frmLog.IL, frmLog.Log)
        End If
    End Sub
    Function RemoveDuplicates(ByVal lstView As ListView) As Integer
        Dim itemI As ListViewItem
        Dim itemJ As ListViewItem
        Dim count As Integer
        For i As Integer = lstView.Items.Count - 1 To 0 Step -1
            itemI = lstView.Items(i)
            For z As Integer = i + 1 To lstView.Items.Count - 1 Step 1
                itemJ = lstView.Items(z)
                If itemI.Text = itemJ.Text Then
                    lstView.Items.Remove(itemJ)
                    count = count + 1
                    Exit For
                End If
            Next z
        Next (i)
        Return count
    End Function
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        MsgBox("Removed " & RemoveDuplicates(lstChannels) & " duplicated channels", MsgBoxStyle.Information)
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        For Each itm As ListViewItem In lstChannels.SelectedItems
            itm.Remove()
        Next
    End Sub
End Class