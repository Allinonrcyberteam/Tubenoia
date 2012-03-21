Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.IO
Imports ProjectWIFE
Public Class frmRank
    Private INI As New INI(Configuration.INI_Configuration.DefaultConfig, My.Application.Info.DirectoryPath & "\config.ini")
    Dim F As New Functions.General
    Dim MaxThread As Integer = CInt(INI("General")("Threads").value)
    Dim Videos As New Queue(Of String())
    Private Sub frmRank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        F.SetCueText(txtKeywords, " Enter keywords (eg. ""youtube downloader"", seperate with spaces)")
        F.SetCueText(txtVideo, " Enter your YouTube video link (eg. http://www.youtube.com/watch?v=)")
        VIDEO.ImageKey = IL.Images.Keys(2)
        RANK.ImageKey = IL.Images.Keys(0)
        KWS.ImageKey = IL.Images.Keys(1)
        Log.ContextMenu = CM
        CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub frmRank_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        VIDEO.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        For Each itm As ListViewItem In Log.SelectedItems
            itm.Remove()
        Next
    End Sub
    Public Function ExportList(ByVal List As ListView, ByVal Path As String) As Boolean
        Try
            Dim csvFileContents As New System.Text.StringBuilder
            Dim CurrLine As String = String.Empty
            CurrLine = String.Empty
            For Each item As ListViewItem In List.Items
                Dim i As Integer = 0
                For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                    If i = 0 Then
                        CurrLine += (String.Format("{0}", subItem.Text))
                        i += 1
                    ElseIf i = 3 Then
                        CurrLine += (String.Format("{0} ", subItem.Text))
                        i += 1
                    Else
                        CurrLine += (String.Format("{0} — ", subItem.Text))
                        i += 1
                    End If
                Next
                csvFileContents.AppendLine(CurrLine.Substring(0, CurrLine.Length - 1))
                CurrLine = String.Empty
            Next
            Dim Sys As New System.IO.StreamWriter(Path)
            Sys.WriteLine(csvFileContents.ToString)
            Sys.Flush()
            Sys.Dispose()
            Return True
        Catch
            Return False
        End Try
    End Function
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
        SD.FileName = "Rank_List.txt"
        If SD.ShowDialog = DialogResult.OK Then
            ExportList(Log, SD.FileName)
            F.Logs("Rank Check list exported to " & SD.FileName, 4, IL, frmLog.Log)
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Log.Items.Clear()
    End Sub
    Private Function GetRank(ByVal FIND As String, ByVal KEYWORDS As String, ByVal MAX As Integer) As String
        Dim W As New WebWrapper
        Dim HTML As String = vbNullString
        Dim Page As Integer = 1
        If Not Page > MAX Then
            HTML = W.httpGet("http://www.youtube.com/results?search_query=" & Replace(KEYWORDS, " ", "+") & "&page=" & Page & "&persist_hl=1&hl=en")
            Page += 1
        Else
            Return "Not in the first " & MAX & " pages"
        End If
        Dim I2 As Integer = 0
        If I2 = 1 Then
GetPage:    If Not Page > MAX Then
                Dim suggested_categories As String = F.GetBetweenR(HTML, "&suggested_categories=", "&page=", 0, False)
                HTML = W.httpGet("http://www.youtube.com/results?search_query=" & Replace(KEYWORDS, " ", "+") & "&suggested_categories=" & suggested_categories & "&page=" & Page & "&persist_hl=1&hl=en")
                Page += 1
            Else
                Return "Not in the first " & MAX & " pages"
            End If
        End If
        Dim temp() As String = Regex.Split(HTML, "<div class=""result-item \*sr "">")
        For I = 1 To UBound(temp)
            Dim HH As String = Regex.Split(temp(I), "yt.www.translation.enableTranslate")(0).Trim()
            If Not HH.Contains("playlist-extra-thumb") Then
                If HH.Contains(FIND) Then
                    Return "Page " & Page - 1 & " result #" & I
                End If
            End If
        Next
        GoTo GetPage
    End Function
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Public Sub FindRankList(ByVal Stuff As Object)
        Dim W As New WebWrapper
        Dim ID As String = Mid(Split(Stuff(0), "=")(1), 1, 11)
        Dim L As String = GetRank(ID, Stuff(1), Pages.Value)
        If StrConv(L, vbLowerCase).Contains("not") Then
            For Each itm As ListViewItem In Log.Items
                If itm.SubItems(1).Text.Contains("Gathering..") And itm.SubItems(2).Text.Contains(Stuff(1)) And itm.SubItems(3).Text.Contains(ID) Then
                    itm.ImageKey = IL.Images.Keys(4)
                    itm.SubItems(1).Text = L
                End If
            Next
        Else
            For Each itm As ListViewItem In Log.Items
                If itm.SubItems(1).Text.Contains("Gathering..") And itm.SubItems(2).Text.Contains(Stuff(1)) And itm.SubItems(3).Text.Contains(ID) Then
                    itm.ImageKey = IL.Images.Keys(3)
                    itm.SubItems(1).Text = L
                End If
            Next
        End If
        If Videos.Count > 0 Then
            Dim A As Object = Videos.Dequeue
            FindRankList({A(0), A(1)})
        End If
    End Sub
    Public Sub FindRank(ByVal Stuff As Object)
        Dim ID As String = Mid(Split(Stuff(0), "=")(1), 1, 11)
        Dim LV2 As New ListViewItem
        LV2.ImageKey = IL.Images.Keys(5)
        LV2.SubItems.Add("Gathering..")
        LV2.SubItems.Add(Stuff(1))
        LV2.SubItems.Add(Stuff(0))
        Log.Items.Add(LV2)
        Dim L As String = GetRank(ID, Stuff(1), Pages.Value)
        If StrConv(L, vbLowerCase).Contains("not") Then
            For Each itm As ListViewItem In Log.Items
                If itm.SubItems(1).Text.Contains("Gathering..") And itm.SubItems(2).Text.Contains(Stuff(1)) And itm.SubItems(3).Text.Contains(ID) Then
                    itm.ImageKey = IL.Images.Keys(4)
                    itm.SubItems(1).Text = L
                End If
            Next
        Else
            For Each itm As ListViewItem In Log.Items
                If itm.SubItems(1).Text.Contains("Gathering..") And itm.SubItems(2).Text.Contains(Stuff(1)) And itm.SubItems(3).Text.Contains(ID) Then
                    itm.ImageKey = IL.Images.Keys(3)
                    itm.SubItems(1).Text = L
                End If
            Next
        End If
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If Not StrConv(txtVideo.Text, VbStrConv.Lowercase).Contains("?v=") Then
            MsgBox("The video URL you've entered is not a valid YouTube link", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txtKeywords.Text = vbNullString Then
            MsgBox("You have not entered any keywords to search for", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim T As New Threading.Thread(AddressOf FindRank)
        Dim Video As String = txtVideo.Text
        Dim Keywords As String = txtKeywords.Text
        T.Start({Video, Keywords})
    End Sub
    Private Function Lines(ByVal text As String) As String()
        Dim T As String, O As New List(Of String)
        Using R As New StringReader(text)
            While R.Peek > -1
                T = R.ReadLine
                If T <> "" Then O.Add(T)
            End While
        End Using
        Return O.ToArray
    End Function
    Private Sub btnChkList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChkList.Click
        Using T As New OpenFileDialog
            If T.ShowDialog = DialogResult.OK Then
                Dim Users = Lines(IO.File.ReadAllText(T.FileName))
                Dim Buffer As String()
                For I = 0 To Users.Length - 1
                    If Users(I).Contains("|||") Then
                        Buffer = Users(I).Split("|||")
                        Videos.Enqueue({Buffer(0), Buffer(3)})
                        Dim LV2 As New ListViewItem
                        LV2.ImageKey = IL.Images.Keys(5)
                        LV2.SubItems.Add("Gathering..")
                        LV2.SubItems.Add(Buffer(3))
                        LV2.SubItems.Add(Buffer(0))
                        Log.Items.Add(LV2)
                    End If
                Next
            End If
        End Using
        Try
            For i = 0 To MaxThread - 1
                If Videos.Count > 0 Then
                    Dim T As New Threading.Thread(AddressOf FindRankList)
                    Dim A As Object = Videos.Dequeue
                    T.Start({A(0), A(1)})
                End If
            Next
        Catch
        End Try
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        For Each itm As ListViewItem In Log.SelectedItems
            Process.Start(itm.SubItems(3).Text)
        Next
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        For Each itm As ListViewItem In Log.SelectedItems
            If Not itm.SubItems(1).Text.Contains("Not") Then
                Dim Page As String = F.GetBetweenR(itm.SubItems(1).Text, "Page ", " result", 0, True)
                Process.Start("http://www.youtube.com/results?search_query=" & F.URLEncode(itm.SubItems(2).Text) & "&page=" & Page)
            End If
        Next
    End Sub
End Class