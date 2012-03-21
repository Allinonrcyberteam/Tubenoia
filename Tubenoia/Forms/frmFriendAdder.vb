Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.Runtime.Serialization
Public Class frmFriendAdder
    Dim Account As New YouTube("", "", Nothing)
    Dim F As New Functions.General
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        lstFriends.Items.Clear()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Tubenoia Supported Lists (*.TNCL *.TNSL *.TNFL)|*.TNCL;*.TNSL;*.TNFL"
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Extension As String = IO.Path.GetExtension(OFD.FileName)
            Dim fStream As FileStream
            If StrConv(Extension, VbStrConv.Lowercase).Contains("txt") Then
                Using T As New OpenFileDialog
                    If T.ShowDialog = DialogResult.OK Then
                        Dim Users = F.Lines(IO.File.ReadAllText(T.FileName))
                        For I = 0 To Users.Length - 1
                            Dim T2 As New ListViewItem
                            T2.Text = Users(I)
                            lstFriends.Items.Add(T2)
                        Next
                    End If
                End Using
            Else
                Try
                    fStream = New FileStream(OFD.FileName, FileMode.Open)
                    Dim binFormat As New BinaryFormatter
                    Dim f As New List(Of ListViewItem)
                    f = binFormat.Deserialize(fStream)
                    For Each itm As ListViewItem In f
                        Dim T As New ListViewItem
                        T.Text = itm.Text
                        T.SubItems.Add(itm.SubItems(1))
                        lstFriends.Items.Add(T)
                    Next
                Catch anex As ArgumentNullException
                    MsgBox("The inventory could not be accessed")
                Catch ex As SerializationException
                    MsgBox("The application failed to retrieve the inventory")
                Finally
                    fStream.Close()
                End Try
            End If
        Else
            Return
        End If
    End Sub
    Private Sub frmFriendAdder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstFriends.ContextMenu = CM
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
            If Account.Username = "" Then
                Account = New YouTube(txtUsername.Text, txtPassword.Text, Nothing)
                If Account.Login = "Yes" Then
                    Log("Logged successfully into " & txtUsername.Text & "!", Color.Green, True)
                    lblTotal.Text = Friends.Count
                    Log("Starting mass adder...")

                    Work = New Threading.Thread(AddressOf Start)
                    Work.Start()
                Else
                    Log("Login failed", Color.Red, True)
                    MsgBox("Account information is not correct")
                End If
            Else
                lblTotal.Text = Friends.Count
                Log("Already logged in... continuing")
                Try
                    Work.Abort()
                Catch
                End Try
                Work = New Threading.Thread(AddressOf Start)
                Work.Start()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Dim Friends As New Queue(Of ListViewItem)
    Dim Check As Threading.Thread
    Dim Work As Threading.Thread
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If btnStart.Text = "Start" Then
            If lstFriends.Items.Count > 0 Then
                If txtUsername.Text <> Nothing Then
                    If txtPassword.Text <> Nothing Then
                        Log("Logging in to account...")
                        For Each itm As ListViewItem In lstFriends.Items
                            Friends.Enqueue(itm)
                        Next
                        Check = New Threading.Thread(AddressOf checkFirst)
                        Check.Start()
                        btnStart.Text = "Stop"
                    Else
                        MsgBox("No password is entered")
                    End If
                Else
                    MsgBox("No username is entered")
                End If
            Else
                MsgBox("No channels to add")
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

            Friends.Clear()
            btnStart.Text = "Start"
            Log("Friend adder stopped")
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
            Dim Channel As ListViewItem = Friends.Dequeue
            Dim Username As String = Channel.Text
Restart:    Dim Reply As String = Account.FriendAdder(Username)
            If Reply = "Yes" Then
                Success += 1
                lblSuccess.Text = Success
                lblNext.Text = Username
                Log("Successfully sent request to " & Username, Color.Green, True)
                Channel.BackColor = Color.LightGreen
            ElseIf Reply = "No" Then
                Fail += 1
                lblFailed.Text = Fail
                Log("Failed to send request to " & Username, Color.Red, True)
                Channel.BackColor = Color.LightPink
            ElseIf Reply = "Limit" Then
                Debug.WriteLine("Going into limit reached")
                Wait = Func.RandomInteger(failedMinimum.Value, failedMaximum.Value)
                Log("Friend adding limit reached... waiting " & Wait & " seconds", Color.Red, True)
                Threading.Thread.Sleep(Wait * 1000)
                GoTo Restart
            End If
            If Friends.Count > 0 Then
                Dim Wait As Integer = Func.RandomInteger(Minimum.Value, Maximum.Value)
                Log("Waiting " & Wait & " seconds before next request")
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
        Log("Friend adding limit reached... waiting " & Wait & " seconds", Color.Red, True)
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
        Log("Friend adder paused")
    End Sub
    Dim Wait As Integer
End Class