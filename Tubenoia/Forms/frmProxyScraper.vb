Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Net.Sockets
Imports ProjectWIFE
Public Class frmProxyScraper
    Dim F As New Functions.General
    Dim W As New WebWrapper
    Private INI As New INI(Configuration.INI_Configuration.DefaultConfig, My.Application.Info.DirectoryPath & "\config.ini")
    Dim MaxThread As Integer
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub frmProxyScraper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaxThread = CInt(INI("General")("Threads").Value)
        If MaxThread > 50 Then
            MaxThread = 50
        End If
        lstIPs.ContextMenu = CM
        CheckForIllegalCrossThreadCalls = False
    End Sub
    Dim Start As Boolean = False
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If MenuItem1.Text = "Start Scraping" Then
            Start = True
            Dim T As New Threading.Thread(AddressOf Scraping)
            T.Start()
            MenuItem1.Text = "Stop Scraping"
        Else
            Start = False
            MenuItem1.Text = "Start Scraping"
        End If
    End Sub
    Public Function CheckProxy(ByVal Proxy As Uri) As Boolean
        Try
            Dim HTML As String
            Dim WW As New WebWrapper
            WW.SetProxy(Proxy.Host, Proxy.Port)
            If Timeout.Value > 0 Then
                HTML = WW.httpGetTime("http://www.youtube.com/", Timeout.Value * 1000)
            Else
                HTML = WW.httpGet("http://www.youtube.com/")
            End If
            If HTML.Contains("Broadcast Yourself") Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function
    Public Function CheckProxySocket(ByVal Proxy As Uri) As Boolean
        Try
            Dim iProxy As Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            iProxy.ReceiveTimeout = 500 : iProxy.SendTimeout = 500
            Try
                '' Connect using a timeout (1/2 second)
                Dim result As IAsyncResult = iProxy.BeginConnect(Proxy.Host, Proxy.Port, Nothing, Nothing)
                Dim success As Boolean = result.AsyncWaitHandle.WaitOne(500, True)
                If (Not success) Then
                    iProxy.Close() : Return False
                End If
            Catch ex As Exception
                Return False
            End Try

            Dim bytData() As Byte, strData As String
            Dim iDataLen As Integer = 1024
            strData = String.Format("CONNECT {0}:{1} HTTP/1.0{2}{2}", "www.youtube.com", 80, vbNewLine)

            bytData = System.Text.ASCIIEncoding.ASCII.GetBytes(strData)
            If iProxy.Connected Then
                iProxy.Send(bytData, bytData.Length, SocketFlags.None)
                ReDim bytData(1024)
                Do
                    Try
                        iDataLen = iProxy.Receive(bytData, bytData.Length, SocketFlags.None)
                    Catch ex As Exception
                        iProxy.Close() : Return False
                    End Try
                    If iDataLen > 0 Then
                        strData = System.Text.ASCIIEncoding.ASCII.GetString(bytData)
                        Exit Do
                    End If
                Loop
            Else
                Return False
            End If
            iProxy.Close()
            Dim strAttribs() As String
            strAttribs = strData.Split(" "c)
            If strAttribs(1).Equals("200") Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function
    Private Sub Scraping()
        Do While Start
            Dim Page As Integer = 1
Starter:    If Page <= nPages.Value Then
                Dim HTML As String = W.httpGet("http://hidemyass.com/proxy-list/" & Page)
                Dim temp() As String = Regex.Split(HTML, "<tr class=")
                Dim Title As String = Nothing
                For I = 1 To UBound(temp)
                    Dim HH As String = Regex.Split(temp(I), "</tr>")(0).Trim()
                    If Not HH.Contains("Planet Lab") Then
                        'Trace.WriteLine(F.GetBetweenR(HH, "<span>", "</span>", 0, True) & ":" & F.GetBetweenR(HH, "<td>", "</td>", 1, True))
                        Dim LV As New ListViewItem
                        LV.Text = F.GetBetweenR(HH, "<span>", "</span>", 0, True)
                        LV.SubItems.Add(F.GetBetweenR(HH, "<td>", "</td>", 1, True))
                        lstIPs.Items.Add(LV)
                    End If
                Next
                If Start Then
                    Page += 1
                    GoTo Starter
                Else
                    Exit Sub
                End If
            Else
                MenuItem1.Text = "Start Scraping"
                Start = False
                Exit Sub
            End If
        Loop
    End Sub
    Private Sub Checking()
        Try
            'If Proxies.Count > 0 Then
Start:      Dim Proxy As Array = Proxies.Dequeue
            If CheckProxy(New Uri("http://" & Proxy(0) & ":" & Proxy(1))) = True Then
                If lstIPs.InvokeRequired Then
                    lstIPs.Invoke(New dChangeB(AddressOf ChangeB), Proxy(2), Color.LightGreen)
                Else
                    lstIPs.Items(Proxy(2)).BackColor = Color.LightGreen
                End If
            Else
                If lstIPs.InvokeRequired Then
                    lstIPs.Invoke(New dChangeB(AddressOf ChangeB), Proxy(2), Color.LightPink)
                Else
                    lstIPs.Items(Proxy(2)).BackColor = Color.LightPink
                End If
            End If
            'End If
            If Proxies.Count > 0 Then
                'GoTo Start
                Checking()
            Else
                MenuItem5.Text = "Start Checking"
                Exit Sub
            End If
        Catch
        End Try
    End Sub
    Private Sub CheckingSockets()
        Try
            'If Proxies.Count > 0 Then
Start:      Dim Proxy As Array = Proxies.Dequeue
            If CheckProxySocket(New Uri("http://" & Proxy(0) & ":" & Proxy(1))) = True Then
                If lstIPs.InvokeRequired Then
                    lstIPs.Invoke(New dChangeB(AddressOf ChangeB), Proxy(2), Color.LightGreen)
                Else
                    lstIPs.Items(Proxy(2)).BackColor = Color.LightGreen
                End If
            Else
                If lstIPs.InvokeRequired Then
                    lstIPs.Invoke(New dChangeB(AddressOf ChangeB), Proxy(2), Color.LightPink)
                Else
                    lstIPs.Items(Proxy(2)).BackColor = Color.LightPink
                End If
            End If
            'End If
            If Proxies.Count > 0 Then
                'GoTo Start
                CheckingSockets()
            Else
                MenuItem5.Text = "Start Checking"
                Exit Sub
            End If
        Catch
        End Try
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        lstIPs.Items.Clear()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim S As New StringBuilder
        For Each itm As ListViewItem In lstIPs.Items
            If itm.Index = lstIPs.Items.Count - 1 Then
                S.Append(itm.Text & ":" & itm.SubItems(1).Text)
            Else
                S.AppendLine(itm.Text & ":" & itm.SubItems(1).Text)
            End If
        Next
        Dim SD As New SaveFileDialog
        SD.Filter = "Text Files (*.txt)|*.txt"
        SD.FilterIndex = 1
        SD.Title = "Export List"
        SD.FileName = "Proxies.txt"
        If SD.ShowDialog = DialogResult.OK Then
            Dim Sys As New System.IO.StreamWriter(SD.FileName)
            Sys.Write(S.ToString)
            Sys.Flush()
            Sys.Dispose()
            F.Logs("Proxy Scraper list exported to " & SD.FileName, 2, frmLog.IL, frmLog.Log)
        End If
    End Sub
    Dim Proxies As New Queue(Of Array)
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If MenuItem5.Text = "Start Checking" Then
            If MsgBox("Do you want to check with HTTP checking, or sockets? Sockets is much faster, but inaccurate, but HTTP is close to 100% accurate. Press Yes for HTTP, and No for Sockets", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For Each I As ListViewItem In lstIPs.Items
                    Proxies.Enqueue({I.Text, I.SubItems(1).Text, I.Index})
                Next
                For i = 0 To MaxThread - 1
                    Dim T As New Threading.Thread(New Threading.ThreadStart(AddressOf Checking))
                    T.Start()
                Next
                MenuItem5.Text = "Stop Checking"
            Else
                For Each I As ListViewItem In lstIPs.Items
                    Proxies.Enqueue({I.Text, I.SubItems(1).Text, I.Index})
                Next
                For i = 0 To MaxThread - 1
                    Dim T As New Threading.Thread(New Threading.ThreadStart(AddressOf CheckingSockets))
                    T.Start()
                Next
                MenuItem5.Text = "Stop Checking"
            End If
        Else
            Proxies.Clear()
            MenuItem5.Text = "Start Checking"
        End If
    End Sub
    Delegate Sub dChangeB(ByVal index As Integer, ByVal color As Color)
    Private Sub ChangeB(ByVal index As Integer, ByVal color As Color)
        lstIPs.Items(index).BackColor = color
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        For Each itm As ListViewItem In lstIPs.Items
            If itm.BackColor = Color.LightPink Then
                itm.Remove()
            End If
        Next
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        For Each itm As ListViewItem In lstIPs.Items
            If itm.BackColor.ToString = "Color [Window]" Then
                itm.Remove()
            End If
        Next
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Using T As New OpenFileDialog
            If T.ShowDialog = DialogResult.OK Then
                Dim Users = F.Lines(IO.File.ReadAllText(T.FileName))
                Dim Buffer As String()
                For I = 0 To Users.Length - 1
                    If Users(I).Contains(":") Then
                        Buffer = Users(I).Split(":")
                        lstIPs.Items.Add(Buffer(0)).SubItems.Add(Buffer(1))
                    End If
                Next
            End If
        End Using
    End Sub
End Class