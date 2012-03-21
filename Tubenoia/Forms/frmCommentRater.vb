Imports System.Text
Imports ProjectWIFE
Public Class frmCommentRater
    Private INI As New INI(Configuration.INI_Configuration.DefaultConfig, My.Application.Info.DirectoryPath & "\config.ini")
    Dim MaxThread As Integer
    Dim F As New Functions.General
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub frmCommentRater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaxThread = CInt(INI("General")("Threads").Value)
        If MaxThread > 50 Then
            MaxThread = 50
        End If
        F.SetCueText(txtCID, "43 character comment ID...")
        Userlist.ContextMenu = CM
        btnFind.Text = "Find Comment ID from a" & vbNewLine & "comment"
        CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If txtCID.Enabled = False Then
            txtCID.Enabled = True
        Else
            txtCID.Enabled = False
        End If
    End Sub
    Private Sub NButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim T As New frmCommentFinder
        T.ShowDialog()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Userlist.Items.Clear()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        For Each itm As ListViewItem In Userlist.SelectedItems
            itm.Remove()
        Next
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Using T As New OpenFileDialog
            If T.ShowDialog = DialogResult.OK Then
                Dim Users = F.Lines(IO.File.ReadAllText(T.FileName))
                Dim Buffer As String()
                For I = 0 To Users.Length - 1
                    If Users(I).Contains(":") Then
                        Buffer = Users(I).Split(":")
                        If UBound(Buffer) = 5 Then
                            Dim T2 As New ListViewItem
                            T2.Text = Buffer(0)
                            T2.SubItems.Add(Buffer(1))
                            T2.SubItems.Add(Buffer(2))
                            T2.SubItems.Add(Buffer(3))
                            T2.SubItems.Add(Buffer(4))
                            T2.SubItems.Add(Buffer(5))
                            T2.SubItems.Add("")
                            Userlist.Items.Add(T2)
                        ElseIf UBound(Buffer) = 3 Then
                            Dim T2 As New ListViewItem
                            T2.Text = Buffer(0)
                            T2.SubItems.Add(Buffer(1))
                            T2.SubItems.Add(Buffer(2))
                            T2.SubItems.Add(Buffer(3))
                            T2.SubItems.Add("")
                            T2.SubItems.Add("")
                            T2.SubItems.Add("")
                            Userlist.Items.Add(T2)
                        Else
                            Dim T2 As New ListViewItem
                            T2.Text = Buffer(0)
                            T2.SubItems.Add(Buffer(1))
                            T2.SubItems.Add("")
                            T2.SubItems.Add("")
                            T2.SubItems.Add("")
                            T2.SubItems.Add("")
                            T2.SubItems.Add("")
                            Userlist.Items.Add(T2)
                        End If
                    End If
                Next
            End If
        End Using
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim S As New StringBuilder
        For Each itm As ListViewItem In Userlist.Items
            If itm.Index = Userlist.Items.Count - 1 Then
                Dim SSS As String = ""
                For Each SI As ListViewItem.ListViewSubItem In itm.SubItems
                    If SI.Text <> "" And SI.Text.Contains("Successfully") = False And SI.Text.ToLower.Contains("fail") = False Then : If SI.Text <> "" Then : SSS += SI.Text & ":" : End If : End If
                Next
                SSS = SSS.Remove(SSS.Length - 1, 1)
                S.Append(SSS)
            Else
                Dim SSS As String = ""
                For Each SI As ListViewItem.ListViewSubItem In itm.SubItems
                    If SI.Text <> "" And SI.Text.Contains("Successfully") = False And SI.Text.Contains("Logged") = False And SI.Text.ToLower.Contains("fail") = False Then : If SI.Text <> "" Then : SSS += SI.Text & ":" : End If : End If
                Next
                SSS = SSS.Remove(SSS.Length - 1, 1)
                S.AppendLine(SSS)
            End If
        Next
        Dim SD As New SaveFileDialog
        SD.Filter = "Text Files (*.txt)|*.txt"
        SD.FilterIndex = 1
        SD.Title = "Export List"
        SD.FileName = "Accounts.txt"
        If SD.ShowDialog = DialogResult.OK Then
            Dim Sys As New System.IO.StreamWriter(SD.FileName)
            Sys.Write(S.ToString)
            Sys.Flush()
            Sys.Dispose()
            F.Logs("Account Checker list exported to " & SD.FileName, 2, frmLog.IL, frmLog.Log)
        End If
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Dim i = 0
        For Each itm As ListViewItem In Userlist.Items
            If itm.BackColor = Color.LightPink Then
                itm.Remove()
                i += 1
            End If
        Next
        Me.Refresh()
        MsgBox("Removed " & i & " invalid accounts")
    End Sub
    Dim Users As New Queue(Of String)
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If btnStart.Text = "Start" Then
            If Userlist.Items.Count > 0 Then
                If txtCID.Text.Length = 43 Then
                    For Each itm As ListViewItem In Userlist.Items
                        If itm.SubItems.Count = 7 Then
                            Users.Enqueue(itm.Text & ":" & itm.SubItems(1).Text & ":" & itm.Index & ":" & itm.SubItems(2).Text & ":" & itm.SubItems(3).Text & ":" & itm.SubItems(4).Text & ":" & itm.SubItems(5).Text)
                        ElseIf itm.SubItems.Count = 5 Then
                            Users.Enqueue(itm.Text & ":" & itm.SubItems(1).Text & ":" & itm.Index & ":" & itm.SubItems(2).Text & ":" & itm.SubItems(3).Text)
                        Else
                            Users.Enqueue(itm.Text & ":" & itm.SubItems(1).Text & ":" & itm.Index)
                        End If
                    Next
                    If Users.Count > 0 Then
                        For i = 0 To MaxThread - 1
                            Dim T As New Threading.Thread(AddressOf StartIt)
                            T.Start()
                        Next
                        btnStart.Text = "Stop"
                    End If
                Else
                    MsgBox("The supplied comment ID is invalid", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("No users in userlist")
            End If
        Else
            Users.Clear()
            btnStart.Text = "Start"
            Me.Refresh()
        End If
    End Sub
    Private Sub StartIt()
        Try
            Dim S As String = Users.Dequeue
            Dim PLIT As String() = Split(S, ":")
            Dim U As String
            Dim P As String
            Dim I As Integer
            Dim PIP As String
            Dim PPORT As String
            Dim PU As String
            Dim PP As String
            If PLIT(6) <> "" Then
                U = PLIT(0)
                P = PLIT(1)
                I = PLIT(2)
                PIP = PLIT(3)
                PPORT = PLIT(4)
                PU = PLIT(5)
                PP = PLIT(6)
            ElseIf PLIT(4) <> "" Then
                U = PLIT(0)
                P = PLIT(1)
                I = PLIT(2)
                PIP = PLIT(3)
                PPORT = PLIT(4)
            Else
                U = PLIT(0)
                P = PLIT(1)
                I = PLIT(2)
            End If
            Dim YT As YouTube
            If PU <> Nothing Then
                YT = New YouTube(U, P, Nothing, True, PIP, PPORT, PU, PP)
            ElseIf PIP <> Nothing Then
                YT = New YouTube(U, P, Nothing, True, PIP, PPORT)
            Else
                YT = New YouTube(U, P, Nothing)
            End If
            If Timeout.Value > 0 Then
                If YT.Login(True, Timeout.Value * 1000) = "Yes" Then
                    Userlist.Items(I).BackColor = Color.LightGreen
                    Userlist.Items(I).SubItems(6).Text = "Logged successfully in"
                    Dim Author As String = "FAILED"
                    Try
                        If rUp.Checked Then
                            If YT.RateCommentID(txtCID.Text, True, Author) = True Then
                                Userlist.Items(I).SubItems(6).Text = "Successfully thumbed up " & Author & "'s comment"
                            Else
                                Userlist.Items(I).SubItems(6).Text = "Failed to rate comment!"
                            End If
                        Else
                            If YT.RateCommentID(txtCID.Text, False, Author) = True Then
                                Userlist.Items(I).SubItems(6).Text = "Successfully thumbed down " & Author & "'s comment"
                            Else
                                Userlist.Items(I).SubItems(6).Text = "Failed to rate comment!"
                            End If
                        End If
                    Catch
                        Userlist.Items(I).SubItems(6).Text = "Failed to rate comment!"
                    End Try
                Else
                    Userlist.Items(I).BackColor = Color.LightPink
                    Userlist.Items(I).SubItems(6).Text = "Login failed"
                End If
            Else
                If YT.Login() = "Yes" Then
                    Userlist.Items(I).BackColor = Color.LightGreen
                    Userlist.Items(I).SubItems(6).Text = "Logged successfully in"
                    Dim Author As String = "FAILED"
                    Try
                        If rUp.Checked Then
                            If YT.RateCommentID(txtCID.Text, True, Author) = True Then
                                Userlist.Items(I).SubItems(6).Text = "Successfully thumbed up " & Author & "'s comment"
                            Else
                                Userlist.Items(I).SubItems(6).Text = "Failed to rate comment!"
                            End If
                        Else
                            If YT.RateCommentID(txtCID.Text, False, Author) = True Then
                                Userlist.Items(I).SubItems(6).Text = "Successfully thumbed down " & Author & "'s comment"
                            Else
                                Userlist.Items(I).SubItems(6).Text = "Failed to rate comment!"
                            End If
                        End If
                    Catch
                        Userlist.Items(I).SubItems(6).Text = "Failed to rate comment!"
                    End Try
                Else
                    Userlist.Items(I).BackColor = Color.LightPink
                    Userlist.Items(I).SubItems(6).Text = "Login failed"
                End If
            End If

            If Users.Count > 0 Then
                Threading.Thread.Sleep(Delay.Value * 1000)
                StartIt()
            Else
                btnStart.Text = "Start"
                Me.Refresh()
            End If
        Catch
        End Try
    End Sub
End Class