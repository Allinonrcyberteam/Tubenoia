Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.Runtime.Serialization
Public Class frmMessageSender
    ' TODO: Login to account from list (+ proxy), if it worked, move on to sending. If limit reached, change account (+ proxy), and move on.
    ' TODO: Add "video attachment" option. (1 or multiple)
    ' TODO: Add embed video option

    'Checkbox for title option. If no "title" is there, then use a word like "a video". EG: I recently saw that you watched "TITLE"/a music video, due to your comment.

    Dim Account As YouTube
    Dim F As New Functions.General
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        lstRecipents.Items.Clear()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Tubenoia Supported Lists (*.TNCL *.TNSL *.TNFL)|*.TNCL;*.TNSL;*.TNFL"
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Extension As String = IO.Path.GetExtension(OFD.FileName)
            Dim fStream As FileStream
            Try
                fStream = New FileStream(OFD.FileName, FileMode.Open)
                Dim binFormat As New BinaryFormatter
                Dim f As New List(Of ListViewItem)
                f = binFormat.Deserialize(fStream)
                For Each itm As ListViewItem In f
                    'MsgBox(itm.SubItems(3).Text) == TITLE
                    Dim T As New ListViewItem
                    T.Text = itm.Text
                    T.SubItems.Add(itm.SubItems(1))
                    lstRecipents.Items.Add(T)
                Next
            Catch anex As ArgumentNullException
                MsgBox("The inventory could not be accessed")
            Catch ex As SerializationException
                MsgBox("The application failed to retrieve the inventory")
            Finally
                fStream.Close()
            End Try
        Else
            Return
        End If
    End Sub
    Private Sub frmFriendAdder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstRecipents.ContextMenu = CM
        Userlist.ContextMenu = CMs
        lstMessages.ContextMenu = CMm
        CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub Log(ByVal Text As String)
        Dim LV As New ListViewItem
        LV.Text = TimeOfDay()
        LV.SubItems.Add(Text)
        lstLog.Items.Add(LV)
    End Sub
    Private Sub Log(ByVal Item As String, ByVal Color As Color, Optional ByVal Bold As Boolean = False)
        Dim LV As New ListViewItem
        If Bold Then
            LV.Font = New Font(lstLog.Font, FontStyle.Bold)
        End If
        LV.ForeColor = Color
        LV.Text = TimeOfDay()
        LV.SubItems.Add(Item)
        lstLog.Items.Add(LV)
    End Sub
    Private Sub checkFirst()
        Try
            Dim S As String
            S = Senders.Dequeue
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
            If PU <> Nothing Then
                Account = New YouTube(U, P, Nothing, True, PIP, PPORT, PU, PP)
            ElseIf PIP <> Nothing Then
                Account = New YouTube(U, P, Nothing, True, PIP, PPORT)
            Else
                Account = New YouTube(U, P, Nothing)
            End If
            If Account.Login = "Yes" Then
                Log("Logged successfully into " & U & "!", Color.Green, True)
                lblTotal.Text = Recipents.Count
                Log("Starting mass adder...")
                Work = New Threading.Thread(AddressOf Start)
                Work.Start()
            Else
                If Senders.Count > 0 Then
                    Log("Login failed. Couldn't log in to " & U & ". Moving on..", Color.Red, True)
                Else
                    Log("Login failed. Couldn't log in to " & U & ". No more senders.", Color.Red, True)
                    btnStart.Text = "Start"
                    btnStart.Refresh()
                    Return
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Dim Recipents As New Queue(Of ListViewItem)
    Dim Senders As New Queue(Of String)
    Dim Check As Threading.Thread
    Dim Work As Threading.Thread
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If btnStart.Text = "Start" Then
            If lstRecipents.Items.Count > 0 Then
                If Userlist.Items.Count > 0 Then
                    For Each itm As ListViewItem In lstRecipents.Items
                        Recipents.Enqueue(itm)
                    Next
                    For Each itm As ListViewItem In Userlist.Items
                        If itm.SubItems.Count = 7 Then
                            Senders.Enqueue(itm.Text & ":" & itm.SubItems(1).Text & ":" & itm.Index & ":" & itm.SubItems(2).Text & ":" & itm.SubItems(3).Text & ":" & itm.SubItems(4).Text & ":" & itm.SubItems(5).Text)
                        ElseIf itm.SubItems.Count = 5 Then
                            Senders.Enqueue(itm.Text & ":" & itm.SubItems(1).Text & ":" & itm.Index & ":" & itm.SubItems(2).Text & ":" & itm.SubItems(3).Text)
                        Else
                            Senders.Enqueue(itm.Text & ":" & itm.SubItems(1).Text & ":" & itm.Index)
                        End If
                    Next
                    Check = New Threading.Thread(AddressOf checkFirst)
                    Check.Start()
                    btnStart.Text = "Stop"
                Else
                    MsgBox("No accounts to send from")
                End If
            Else
                MsgBox("No recipents")
            End If
        ElseIf btnStart.Text = "Stop" Then
            Try
                Check.Abort()
            Catch
            End Try
            Try
                Work.Abort()
            Catch
            End Try
            Success = 0
            Fail = 0
            lblFailed.Text = "0"
            lblNext.Text = "N/A"
            lblTotal.Text = "0"
            lblSuccess.Text = "0"

            Recipents.Clear()
            btnStart.Text = "Start"
            Log("Mass message sender stopped")
        ElseIf btnStart.Text = "Restart" Then
            Try
                Check.Abort()
            Catch ex As Exception
            End Try
            Check = New Threading.Thread(AddressOf checkFirst)
            Check.Start()
            btnStart.Text = "Stop"
        End If
    End Sub
    Private Sub Minimum_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Minimum.Scroll
        If Minimum.Value > Maximum.Value Then
            Maximum.Value = Minimum.Value
        End If
        lblMin.Text = Minimum.Value & " secs"
        lblMax.Text = Maximum.Value & " secs"
    End Sub
    Private Sub Maximum_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Maximum.Scroll
        If Maximum.Value < Minimum.Value Then
            Minimum.Value = Maximum.Value
        End If
        lblMax.Text = Maximum.Value & " secs"
        lblMin.Text = Minimum.Value & " secs"
    End Sub
    Dim Fail As Integer
    Dim Success As Integer
    Private Sub Start()
        'AddHandler Account.FriendAdderLimit, AddressOf LimitReached
Start:  Try
            Dim Channel As ListViewItem = Recipents.Dequeue
            Dim Username As String = Channel.Text
Restart:    Dim Reply As String = "" 'Account.FriendAdder(Username)
            If Reply = "Yes" Then
                Success += 1
                lblSuccess.Text = Success
                lblNext.Text = Username
                Log("Successfully sent message to " & Username, Color.Green, True)
                Channel.BackColor = Color.LightGreen
            ElseIf Reply = "Kinda" Then
                Fail += 1
                lblFailed.Text = Fail
                Log(Username & " have enabled friend lock", Color.Red, True)
                Channel.BackColor = Color.LightPink
            ElseIf Reply = "Limit" Then
                Debug.WriteLine("Going into limit reached")
                Wait = Func.RandomInteger(failedMinimum.Value, failedMaximum.Value)
                Log("Message sending limit reached... waiting " & Wait & " seconds", Color.Red, True)
                Threading.Thread.Sleep(Wait * 1000)
                GoTo Restart
            End If
            If Recipents.Count > 0 Then
                Dim Wait As Integer = Func.RandomInteger(Minimum.Value, Maximum.Value)
                Log("Waiting " & Wait & " seconds before next message")
                Threading.Thread.Sleep(Wait * 1000)
                GoTo Start
            Else
                btnStart.Text = "Start"
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub failedMinimum_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles failedMinimum.Scroll
        If failedMinimum.Value > failedMaximum.Value Then
            failedMaximum.Value = failedMinimum.Value
        End If
        lblMinFail.Text = failedMinimum.Value & " secs"
        lblMaxFail.Text = failedMaximum.Value & " secs"
    End Sub
    Private Sub failedMaximum_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles failedMaximum.Scroll
        If failedMaximum.Value < failedMinimum.Value Then
            failedMinimum.Value = failedMaximum.Value
        End If
        lblMaxFail.Text = failedMaximum.Value & " secs"
        lblMinFail.Text = failedMinimum.Value & " secs"
    End Sub
    Dim Func As New Functions.General
    Private Sub LimitReached()
        Debug.WriteLine("Going into limit reached")
        Wait = Func.RandomInteger(failedMinimum.Value, failedMaximum.Value)
        Log("Message sending limit reached... waiting " & Wait & " seconds", Color.Red, True)
        'Threading.Thread.Sleep(Wait * 1000)
        Work.Abort()
        Threading.Thread.Sleep(10000)
        Work = New Threading.Thread(AddressOf Start)
        Work.Start()
    End Sub
    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        Try
            Check.Abort()
        Catch
        End Try
        Try
            Work.Abort()
        Catch
        End Try

        btnStart.Text = "Restart"
        Log("Mass message sender paused")
    End Sub
    Dim Wait As Integer
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        Dim Response As String
        Response = InputBox("Please enter a account below to add to the list" & vbNewLine & " (username:password(optional :proxy_IP:proxy_PORT:proxy_username:proxy_password) format)")
        If Response <> Nothing Then
            If Response.Contains(":") Then
                Dim Buffer As String()
                Buffer = Response.Split(":")
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
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
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
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Userlist.Items.Clear()
    End Sub
End Class