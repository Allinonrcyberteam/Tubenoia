Imports System.Text.RegularExpressions
Imports System.Text
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization
Public Class frmUserCommentScraper
    Dim F As New Functions.General
    Dim W As New WebWrapper
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
    Private Sub RetrieveUsers(ByVal Stuff As Object)
        Try
            Dim Added As Integer = 0
            Dim Page As Integer = 1
Start:      Dim Comment As String = W.httpGet(String.Format("http://www.youtube.com/all_comments?v={1}&page={0}&persist_hl=1&hl=en", Page, Stuff(0)))
            Dim temp() As String = Regex.Split(Comment, "<li class=""comment """)
            Dim Title As String = Nothing
            For I = 1 To UBound(temp)
                Dim HH As String = Regex.Split(temp(I), "</li>")(0).Trim()
                Dim LV As New ListViewItem
                Dim M As Match = Regex.Match(HH, "data-author=\""(.*?)\""", RegexOptions.IgnoreCase)
                Dim Username As String = ""
                If M.Success Then
                    Username = M.Groups(1).Value
                End If
                If BW.CancellationPending = False Then
                    If Title = Nothing Then
                        Title = F.GetBetweenR(Comment, "vtitle", "runtime", 0, True)
                        Title = F.GetBetweenR(Title, Stuff(0) & """>", "</a>", 0, True)
                    End If

                    Dim M2 As String = F.GetBetweenR(HH, "<span class=\""time\"">", "</span>", 0, True) 'Regex.Match(HH, "<span class=\""time\"">(.*?)" & vbCrLf & "</span>", RegexOptions.IgnoreCase)
                    Dim Online As String = ""
                    Dim Online2 As String = ""
                    If Not M2 = Nothing Then
                        Online = M2
                        Online2 = M2 'M2.Groups(1).Value
                    End If

                    If chkOnly.Checked Then
                        Select Case CB.Text
                            Case "Posted less than 10 minutes ago"
                                If Online.Contains("minute") Then
                                    Online = Split(Online, " minute")(0)
                                    If CInt(Online) <= 10 Then
                                        If Not Added = Stuff(1) Then
                                            LV.Text = Username
                                            LV.SubItems.Add("http://www.youtube.com/" & Username)
                                            LV.SubItems.Add(Online2)
                                            LV.SubItems.Add(Title)
                                            lstUsers.Items.Add(LV)
                                            Added += 1
                                        End If
                                    End If
                                ElseIf Online.Contains("seconds") Then
                                    If Not Added = Stuff(1) Then
                                        LV.Text = Username
                                        LV.SubItems.Add("http://www.youtube.com/" & Username)
                                        LV.SubItems.Add(Online2)
                                        LV.SubItems.Add(Title)
                                        lstUsers.Items.Add(LV)
                                        Added += 1
                                    End If
                                Else
                                    Exit Sub
                                End If
                            Case "Posted less than an hour ago"
                                If Online.Contains("hour") Then
                                    Online = Split(Online, " hour")(0)
                                    If CInt(Online) <= 1 Then
                                        If Not Added = Stuff(1) Then
                                            LV.Text = Username
                                            LV.SubItems.Add("http://www.youtube.com/" & Username)
                                            LV.SubItems.Add(Online2)
                                            LV.SubItems.Add(Title)
                                            lstUsers.Items.Add(LV)
                                            Added += 1
                                        End If
                                    End If
                                ElseIf Online.Contains("minute") Then
                                    If Not Added = Stuff(1) Then
                                        LV.Text = Username
                                        LV.SubItems.Add("http://www.youtube.com/" & Username)
                                        LV.SubItems.Add(Online2)
                                        LV.SubItems.Add(Title)
                                        lstUsers.Items.Add(LV)
                                        Added += 1
                                    End If
                                ElseIf Online.Contains("seconds") Then
                                    If Not Added = Stuff(1) Then
                                        LV.Text = Username
                                        LV.SubItems.Add("http://www.youtube.com/" & Username)
                                        LV.SubItems.Add(Online2)
                                        LV.SubItems.Add(Title)
                                        lstUsers.Items.Add(LV)
                                        Added += 1
                                    End If
                                Else
                                    Exit Sub
                                End If
                            Case "Posted less than a day ago"
                                If Online.Contains("day") Then
                                    Online = Split(Online, " day")(0)
                                    If CInt(Online) <= 1 Then
                                        If Not Added = Stuff(1) Then
                                            LV.Text = Username
                                            LV.SubItems.Add("http://www.youtube.com/" & Username)
                                            LV.SubItems.Add(Online2)
                                            LV.SubItems.Add(Title)
                                            lstUsers.Items.Add(LV)
                                            Added += 1
                                        End If
                                    End If
                                ElseIf Online.Contains("hour") Then
                                    If Not Added = Stuff(1) Then
                                        LV.Text = Username
                                        LV.SubItems.Add("http://www.youtube.com/" & Username)
                                        LV.SubItems.Add(Online2)
                                        LV.SubItems.Add(Title)
                                        lstUsers.Items.Add(LV)
                                        Added += 1
                                    End If
                                ElseIf Online.Contains("minute") Then
                                    If Not Added = Stuff(1) Then
                                        LV.Text = Username
                                        LV.SubItems.Add("http://www.youtube.com/" & Username)
                                        LV.SubItems.Add(Online2)
                                        LV.SubItems.Add(Title)
                                        lstUsers.Items.Add(LV)
                                        Added += 1
                                    End If
                                ElseIf Online.Contains("seconds") Then
                                    If Not Added = Stuff(1) Then
                                        LV.Text = Username
                                        LV.SubItems.Add("http://www.youtube.com/" & Username)
                                        LV.SubItems.Add(Online2)
                                        LV.SubItems.Add(Title)
                                        lstUsers.Items.Add(LV)
                                        Added += 1
                                    End If
                                Else
                                    Exit Sub
                                End If
                        End Select
                    Else
                        If Not Added = Stuff(1) Then
                            LV.Text = Username
                            LV.SubItems.Add("http://www.youtube.com/" & Username)
                            LV.SubItems.Add(Online2)
                            LV.SubItems.Add(Title)
                            lstUsers.Items.Add(LV)
                            Added += 1
                        End If
                    End If
                Else
                    Exit Sub
                End If
            Next
            If Comment.Contains("&page=") And Comment.Contains("Next</a>") Then
                If Not Added = Stuff(1) Then
                    Page += 1
                    GoTo Start
                Else
                    btnScrape.Text = "Scrape"
                    Me.Refresh()
                End If
            Else
                btnScrape.Text = "Scrape"
                Me.Refresh()
            End If
        Catch
            btnScrape.Text = "Scrape"
            Me.Refresh()
        End Try
    End Sub
    Private Sub frmUserCommentScraper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        F.SetCueText(txtVideo, " Please enter the video URL here")
        CB.SelectedItem = CB.Items(0)
        lstUsers.ContextMenu = CM
    End Sub
    Private Sub frmUserCommentScraper_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        TIME.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnScrape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScrape.Click
        If btnScrape.Text = "Scrape" Then
            If txtVideo.Text <> "" And txtVideo.Text.Contains("?v=") Then
                BW.RunWorkerAsync()
                btnScrape.Text = "Stop"
            Else
                MsgBox("Please enter a video URL", MsgBoxStyle.Critical)
            End If
        Else
            btnScrape.Text = "Scrape"
            BW.CancelAsync()
        End If
    End Sub
    Private Sub chkOnly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOnly.CheckedChanged
        If CB.Enabled = False Then
            CB.Enabled = True
        Else
            CB.Enabled = False
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        lstUsers.Items.Clear()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        MsgBox("Removed " & RemoveDuplicates(lstUsers) & " duplicates!", MsgBoxStyle.Information)
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim SD As New SaveFileDialog
        SD.Filter = "Tubenoia Channel List (*.TNCL)|*.TNCL"
        SD.FilterIndex = 1
        SD.Title = "Export Channel List"
        SD.FileName = "channels.TNCL"
        If SD.ShowDialog = DialogResult.OK Then
            Dim fStream As New FileStream(SD.FileName, FileMode.Create)
            Dim binFormat As New BinaryFormatter
            Dim stuff As New List(Of ListViewItem)
            For Each itm As ListViewItem In lstUsers.Items
                stuff.Add(itm)
            Next
            binFormat.Serialize(fStream, stuff)
            F.Logs("User Comment Scraper list exported to " & SD.FileName, 2, frmLog.IL, frmLog.Log)
            fStream.Close()
        End If
    End Sub
    Private Sub BW_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        Dim ID As String = Nothing
        ID = Mid(Split(txtVideo.Text, "watch?v=")(1), 1, 11)
        Dim T As New Threading.Thread(AddressOf RetrieveUsers)
        T.Start({ID, Pages.Value})
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Dim S As New StringBuilder
        For Each itm As ListViewItem In lstUsers.Items
            If itm.Index = lstUsers.Items.Count - 1 Then
                S.Append(itm.Text)
            Else
                S.AppendLine(itm.Text)
            End If
        Next
        Dim SD As New SaveFileDialog
        SD.Filter = "Text File (*.txt)|*.txt"
        SD.FilterIndex = 1
        SD.Title = "Export Channel List"
        SD.FileName = "channels.txt"
        If SD.ShowDialog = DialogResult.OK Then
            Dim Sys As New System.IO.StreamWriter(SD.FileName)
            Sys.Write(S.ToString)
            Sys.Flush()
            Sys.Dispose()
            F.Logs("User Comment Scraper list exported to " & SD.FileName, 2, frmLog.IL, frmLog.Log)
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        For Each itm As ListViewItem In lstUsers.SelectedItems
            itm.Remove()
        Next
    End Sub
End Class