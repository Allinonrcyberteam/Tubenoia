Imports System.Text

Public Class frmAccProxBinder
    Dim F As New Functions.General
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Using T As New OpenFileDialog
            If T.ShowDialog = DialogResult.OK Then
                Dim Users = F.Lines(IO.File.ReadAllText(T.FileName))
                Dim Buffer As String()
                For I = 0 To Users.Length - 1
                    If Users(I).Contains(":") Then
                        Buffer = Users(I).Split(":")
                        Userlist.Items.Add(Buffer(0)).SubItems.Add(Buffer(1))
                    End If
                Next
            End If
        End Using
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Userlist.Items.Clear()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Using T As New OpenFileDialog
            If T.ShowDialog = DialogResult.OK Then
                Dim Users = F.Lines(IO.File.ReadAllText(T.FileName))
                Dim Buffer As String()
                For I = 0 To Users.Length - 1
                    If Users(I).Contains(":") Then
                        Buffer = Users(I).Split(":")
                        If UBound(Buffer) = 3 Then
                            Dim LV As New ListViewItem
                            LV.Text = Buffer(0)
                            LV.SubItems.Add(Buffer(1))
                            LV.SubItems.Add(Buffer(2))
                            LV.SubItems.Add(Buffer(3))
                            Proxylist.Items.Add(LV)
                        Else
                            Dim LV As New ListViewItem
                            LV.Text = Buffer(0)
                            LV.SubItems.Add(Buffer(1))
                            Proxylist.Items.Add(LV)
                        End If
                    End If
                Next
            End If
        End Using
    End Sub
    Private Sub frmAccProxBinder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Userlist.ContextMenu = CMa
        Proxylist.ContextMenu = CMp
        Exportlist.ContextMenu = CMe
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Exportlist.Items.Clear()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Proxylist.Items.Clear()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Dim S As New StringBuilder
        For Each itm As ListViewItem In Exportlist.Items
            If itm.Index = Exportlist.Items.Count - 1 Then
                Dim SSS As String = ""
                For Each SI As ListViewItem.ListViewSubItem In itm.SubItems
                    If SI.Text <> "" Then : SSS += SI.Text & ":" : End If
                Next
                SSS = SSS.Remove(SSS.Length - 1, 1)
                S.Append(SSS)
            Else
                Dim SSS As String = ""
                For Each SI As ListViewItem.ListViewSubItem In itm.SubItems
                    If SI.Text <> "" Then : SSS += SI.Text & ":" : End If
                Next
                SSS = SSS.Remove(SSS.Length - 1, 1)
                S.AppendLine(SSS)
            End If
        Next
        Dim SD As New SaveFileDialog
        SD.Filter = "Text Files (*.txt)|*.txt"
        SD.FilterIndex = 1
        SD.Title = "Export List"
        SD.FileName = "Accounts_Binded.txt"
        If SD.ShowDialog = DialogResult.OK Then
            Dim Sys As New System.IO.StreamWriter(SD.FileName)
            Sys.Write(S.ToString)
            Sys.Flush()
            Sys.Dispose()
            F.Logs("Account Binder list exported to " & SD.FileName, 2, frmLog.IL, frmLog.Log)
        End If
    End Sub
    Private Sub btnBind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBind.Click
        If Userlist.Items.Count > 0 Then
            If Proxylist.Items.Count > 0 Then
Start:          Dim SSS As String = ""
                For Each SI As ListViewItem.ListViewSubItem In Userlist.Items(0).SubItems
                    If SI.Text <> "" Then : SSS += SI.Text & ":" : End If
                Next
                Dim SSS2 As String = ""
                For Each SI As ListViewItem.ListViewSubItem In Proxylist.Items(0).SubItems
                    SSS2 += SI.Text & ":"
                Next
                SSS2 = SSS2.Remove(SSS2.Length - 1, 1)

                Dim response As String = SSS & SSS2
                Dim Buffer As String()
                Buffer = response.Split(":")
                If UBound(Buffer) = 5 Then
                    Dim T2 As New ListViewItem
                    T2.Text = Buffer(0)
                    T2.SubItems.Add(Buffer(1))
                    T2.SubItems.Add(Buffer(2))
                    T2.SubItems.Add(Buffer(3))
                    T2.SubItems.Add(Buffer(4))
                    T2.SubItems.Add(Buffer(5))
                    Exportlist.Items.Add(T2)
                ElseIf UBound(Buffer) = 3 Then
                    Dim T2 As New ListViewItem
                    T2.Text = Buffer(0)
                    T2.SubItems.Add(Buffer(1))
                    T2.SubItems.Add(Buffer(2))
                    T2.SubItems.Add(Buffer(3))
                    Exportlist.Items.Add(T2)
                Else
                    Dim T2 As New ListViewItem
                    T2.Text = Buffer(0)
                    T2.SubItems.Add(Buffer(1))
                    Exportlist.Items.Add(T2)
                End If

                Userlist.Items(0).Remove()
                Proxylist.Items(0).Remove()

                If Proxylist.Items.Count > 0 And Userlist.Items.Count > 0 Then
                    GoTo Start
                End If
            Else
                MsgBox("There is no proxies in the proxy list")
            End If
        Else
            MsgBox("There is no accounts in the userlist")
        End If
    End Sub
End Class