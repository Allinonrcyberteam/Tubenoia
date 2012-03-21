Imports System.Text.RegularExpressions
Imports System.IO
Imports DeathByCaptcha
Imports Google.GData.Extensions
Imports Google.GData.YouTube
Imports Google.YouTube
Imports Google.GData.Client
Imports ProjectWIFE
Public Class YouTube
#Region "Events"
    Event UploadProgressChanged(ByVal sender As Object, ByVal Progress As Integer, ByVal Index As Integer)
    Event UploadFailed(ByVal sender As Object, ByVal err As String, ByVal index As Integer)
    Event UploadFinished(ByVal sender As Object, ByVal ID As String, ByVal index As Integer)
    Event FriendAdderLimit(ByVal sender As Object)
#End Region
#Region "Declerations"
    Public Username As String = ""
    Private Password As String
    Private URL As String
    Private HTML As String
    Public ID As String
    Private S As New WebWrapper
    Private F As New Functions.General

    Private QueIndex As Integer
    Private INI As New INI(Configuration.INI_Configuration.DefaultConfig, My.Application.Info.DirectoryPath & "\config.ini")

    Private Proxy As String
    Private Port As String
    Private PUsername As String
    Private PPassword As String

    Private DisplayRect As Rectangle = Screen.PrimaryScreen.Bounds
    Private Resolution As String = F.URLEncode(String.Format("h={0}&w={1}&d={2}", DisplayRect.Height, DisplayRect.Width, My.Computer.Screen.BitsPerPixel))

    Private upload_url As String = "http://upload.youtube.com/my_videos_upload?restrict=html_form"
    Private upload_video_url1 As String = "http://www.youtube.com/gen_204?a=multi_up_queue&si=%SI%&uk=%UK%&ac=1&gbe=1&fl=0&b=0&fn=0&ti=1&d=0&ta=0&pv=0&c=0&m=0&t=0&ft=0&dn=upload.youtube.com&fe=scotty&ut=html_form"
    Private upload_video_url2 As String = "http://upload.youtube.com/upload/rupio"
    Private upload_video_url3 As String = "http://www.youtube.com/gen_204?a=multi_up_start&si=%SI%&uk=%UK%&ac=1&gbe=1&fl=0&b=0&fn=0&ti=1&d=0&ta=0&pv=0&c=0&m=0&t=0&ft=0&dn=upload.youtube.com&fe=scotty&ut=html_form"
    Private upload_video_url4 As String = "http://www.youtube.com/gen_204?a=multi_up_finish&si=%SI%&uk=%UK%&ac=1&gbe=1&fl=0&b=0&fn=0&ti=1&d=0&ta=0&pv=0&c=0&m=0&t=23001&ft=0&dn=upload.youtube.com&fe=scotty&ut=html_form"
    Private upload_video_set_info As String = "http://upload.youtube.com/my_videos_upload"

    Private DBCTimeout As Integer
    Private DBCU As String
    Private DBCP As String
    Private UseDBC As String
#End Region
#Region "Functions"
#Region "Randoms"
#End Region
#Region "New"
    Public Sub ChangeVideo(ByVal URL As String)
        Dim MSG As String = "Please enter the captcha"
        Dim Tries As Integer = 0
        Me.URL = URL
Login:  Me.HTML = S.httpGet(URL)
Start:  If HTML.Contains("verificationImage") Then
            If UseDBC = "Use" Then
                Dim challenge_enc As String
                challenge_enc = F.GetBetween(Me.HTML, "challenge_enc"" value=""", """>")
                Dim captcha_image As Byte()
                captcha_image = ImageToByte("http://www.youtube.com/cimg?c=" & challenge_enc)
                Dim nexts As String
                nexts = F.GetBetween(Me.HTML, "next"" value=""", """>")
                Dim action_verify As String
                action_verify = F.GetBetween(Me.HTML, "action_verify"" value=""", """>")
                Dim submit As String = "Submit"
                submit = F.GetBetween(Me.HTML, "submit"" value=""", """>")
                Dim session_token2 As String
                session_token2 = F.GetBetween(Me.HTML, "'XSRF_TOKEN': '", "',")
                Dim client As New HttpClient(DBCU, DBCP)
                Dim captcha As Captcha = client.Decode(captcha_image, DBCTimeout)
                Dim urlPOST As String = "http://www.youtube.com/das_captcha?next=" & nexts
                Dim post As String = "challenge_enc=" & F.URLEncode(challenge_enc) & "&next=" & F.URLEncode(nexts) & "&response=" & captcha.Text & "&action_verify=" & action_verify & "&submit=" & submit & "&session_token=" & F.URLEncode(session_token2)
                Me.HTML = S.httpPost(urlPOST, post)
                If Me.HTML.Contains("Incorrect match for the verification code") Then
                    If client.Report(captcha) Then
                        Console.WriteLine("-------------------------------") : Console.WriteLine("Reported as incorrectly solved") : Console.WriteLine("-------------------------------")
                        GoTo Start
                    Else
                        Console.WriteLine("-------------------------------") : Console.WriteLine("Failed reporting as incorrectly solved") : Console.WriteLine("-------------------------------")
                        GoTo Start
                    End If
                End If
            ElseIf UseDBC = "Manual" Then
                Dim challenge_enc As String
                challenge_enc = F.GetBetween(Me.HTML, "challenge_enc"" value=""", """>")
                Dim captcha_image As Bitmap = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("http://www.youtube.com/cimg?c=" & challenge_enc)))
                Dim nexts As String
                nexts = F.GetBetween(Me.HTML, "next"" value=""", """>")
                Dim action_verify As String
                action_verify = F.GetBetween(Me.HTML, "action_verify"" value=""", """>")
                Dim submit As String = "Submit"
                submit = F.GetBetween(Me.HTML, "submit"" value=""", """>")
                Dim session_token2 As String
                session_token2 = F.GetBetween(Me.HTML, "'XSRF_TOKEN': '", "',")
                Dim C As New frmCaptcha
                C.PB.Image = captcha_image
                C.Theme.Text = MSG
                Dim RESOLVED As String = ""
                If C.ShowDialog = DialogResult.OK Then
                    RESOLVED = C.txtCaptcha.Text
                End If
                Dim urlPOST As String = "http://www.youtube.com/das_captcha?next=" & nexts
                Dim post As String = "challenge_enc=" & F.URLEncode(challenge_enc) & "&next=" & F.URLEncode(nexts) & "&response=" & RESOLVED & "&action_verify=" & action_verify & "&submit=" & submit & "&session_token=" & F.URLEncode(session_token2)
                Me.HTML = S.httpPost(urlPOST, post)
                If Me.HTML.Contains("Incorrect match for the verification code") Then
                    MSG = "Incorrect captcha, please enter again"
                    If Tries < 3 Then
                        Tries += 1
                        GoTo Login
                    End If
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub
    Sub New(ByVal Username As String, ByVal Password As String, ByVal URL As String, Optional ByVal UseProxy As Boolean = False, Optional ByVal Proxy As String = "", Optional ByVal Port As Integer = 0, Optional ByVal PUsername As String = "", Optional ByVal PPassword As String = "")
        MyBase.New()
        Me.Username = Username
        Me.Password = Password
        Me.URL = URL
        If Not URL = Nothing Then
            Me.ID = Mid(Split(URL, "watch?v=")(1), 1, 11)
        End If
        If INI("Captcha")("UseDBC").Value = "Use" Then
            UseDBC = "Use"
            DBCU = INI("Captcha")("DBCU").Value
            DBCP = INI("Captcha")("DBCP").Value
            DBCTimeout = CInt(INI("Captcha")("DBCTimeout").Value)
        ElseIf INI("Captcha")("UseDBC").Value = "Manual" Then
            UseDBC = "Manual"
        Else
            UseDBC = "Dismiss"
        End If
        If UseProxy = True Then
            Me.Proxy = Proxy
            Me.Port = Port
            If Not PPassword = "" Then
                Me.PPassword = PPassword
                Me.PUsername = PUsername
            End If
            If Not Me.PPassword = "" Then
                S.SetProxy(Proxy, Port, True, Me.PUsername, Me.PPassword)
            Else
                S.SetProxy(Proxy, Port)
            End If
        End If
    End Sub
#End Region
#Region "Login"
    Public Function SaveTextToFile(ByVal strData As String, _
     ByVal FullPath As String, _
       Optional ByVal ErrInfo As String = "") As Boolean

        Dim Contents As String
        Dim bAns As Boolean = False
        Dim objReader As StreamWriter
        Try


            objReader = New StreamWriter(FullPath)
            objReader.Write(strData)
            objReader.Close()
            bAns = True
        Catch Ex As Exception
            ErrInfo = Ex.Message

        End Try
        Return bAns
    End Function
    Public Function Login(Optional ByVal Timeout As Boolean = False, Optional ByVal Time As Integer = 0) As String
        Try
            'S.cookies.Add(New System.Net.Cookie("NEW_LOGIN_UI", "1", "/", "google.com"))
            S.ClearCookies()
            Dim MSG As String = "Please enter the captcha"
            Dim Tries As Integer = 0
            Dim lHTML As String
            Dim dsh As String = String.Empty
            Dim GALX As String = String.Empty
            If Timeout Then
                lHTML = S.httpGetTime("https://www.google.com/accounts/ServiceLogin?uilel=3&service=youtube&passive=true&continue=http%3A%2F%2Fwww.youtube.com%2Fsignin%3Faction_handle_signin%3Dtrue%26nomobiletemp%3D1%26hl%3Den_US%26next%3D%252F&hl=en_US&ltmpl=sso", Time)
            Else
                lHTML = S.httpGet("https://www.google.com/accounts/ServiceLogin?uilel=3&service=youtube&passive=true&continue=http%3A%2F%2Fwww.youtube.com%2Fsignin%3Faction_handle_signin%3Dtrue%26nomobiletemp%3D1%26hl%3Den_US%26next%3D%252F&hl=en_US&ltmpl=sso")
            End If
Login:      If lHTML.Contains("verificationImage") Then
                If UseDBC = "Use" Then
                    Dim challenge_enc As String
                    challenge_enc = F.GetBetween(Me.HTML, "challenge_enc"" value=""", """>")
                    Dim captcha_image As Byte()
                    captcha_image = ImageToByte("http://www.youtube.com/cimg?c=" & challenge_enc)
                    Dim nexts As String
                    nexts = F.GetBetween(Me.HTML, "next"" value=""", """>")
                    Dim action_verify As String
                    action_verify = F.GetBetween(Me.HTML, "action_verify"" value=""", """>")
                    Dim submit As String = "Submit"
                    submit = F.GetBetween(Me.HTML, "submit"" value=""", """>")
                    Dim session_token2 As String
                    session_token2 = F.GetBetween(Me.HTML, "'XSRF_TOKEN': '", "',")
                    Dim client As New HttpClient(DBCU, DBCP)
                    Dim captcha As Captcha = client.Decode(captcha_image, DBCTimeout)
                    Dim urlPOST As String = "http://www.youtube.com/das_captcha?next=" & nexts
                    Dim post As String = "challenge_enc=" & F.URLEncode(challenge_enc) & "&next=" & F.URLEncode(nexts) & "&response=" & captcha.Text & "&action_verify=" & action_verify & "&submit=" & submit & "&session_token=" & F.URLEncode(session_token2)
                    Me.HTML = S.httpPost(urlPOST, post)
                    If Me.HTML.Contains("Incorrect match for the verification code") Then
                        If client.Report(captcha) Then
                            Console.WriteLine("-------------------------------") : Console.WriteLine("Reported as incorrectly solved") : Console.WriteLine("-------------------------------")
                            GoTo Login
                        Else
                            Console.WriteLine("-------------------------------") : Console.WriteLine("Failed reporting as incorrectly solved") : Console.WriteLine("-------------------------------")
                            GoTo Login
                        End If
                    End If
                ElseIf UseDBC = "Manual" Then
                    Dim challenge_enc As String
                    challenge_enc = F.GetBetween(Me.HTML, "challenge_enc"" value=""", """>")
                    Dim captcha_image As Bitmap = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("http://www.youtube.com/cimg?c=" & challenge_enc)))
                    Dim nexts As String
                    nexts = F.GetBetween(Me.HTML, "next"" value=""", """>")
                    Dim action_verify As String
                    action_verify = F.GetBetween(Me.HTML, "action_verify"" value=""", """>")
                    Dim submit As String = "Submit"
                    submit = F.GetBetween(Me.HTML, "submit"" value=""", """>")
                    Dim session_token2 As String
                    session_token2 = F.GetBetween(Me.HTML, "'XSRF_TOKEN': '", "',")
                    Dim C As New frmCaptcha
                    C.PB.Image = captcha_image
                    C.Theme.Text = MSG
                    Dim RESOLVED As String = ""
                    If C.ShowDialog = DialogResult.OK Then
                        RESOLVED = C.txtCaptcha.Text
                    End If
                    Dim urlPOST As String = "http://www.youtube.com/das_captcha?next=" & nexts
                    Dim post As String = "challenge_enc=" & F.URLEncode(challenge_enc) & "&next=" & F.URLEncode(nexts) & "&response=" & RESOLVED & "&action_verify=" & action_verify & "&submit=" & submit & "&session_token=" & F.URLEncode(session_token2)
                    Me.HTML = S.httpPost(urlPOST, post)
                    If Me.HTML.Contains("Incorrect match for the verification code") Then
                        MSG = "Incorrect captcha, please enter again"
                        If Tries < 3 Then
                            Tries += 1
                            GoTo Login
                        End If
                    End If
                Else
                    Return "No"
                End If
            End If
            Try
                If lHTML.Contains("CheckConnection") Then
                    Dim CheckConnection As String
                    CheckConnection = F.GetBetweenR(lHTML, "iframeUri: '", "',", 0, True)
                    CheckConnection = Replace(CheckConnection, "\x26", "&")
                    CheckConnection = Replace(CheckConnection, "\x2F", "/")
                    S.httpGet(CheckConnection)
                End If
            Catch
            End Try
            dsh = F.GetBetweenR(lHTML, "id=""dsh"" value=""", """", 0, True)
            GALX = F.GetBetweenR(lHTML, "name=""GALX""", "input", 0, True)
            GALX = F.GetBetweenR(GALX, "value=""", """", 0, True)
            Dim action As String = F.GetBetweenR(lHTML, "<form id=""gaia_loginform""", "method=""post""", 0, True)
            action = F.GetBetweenR(action, "action=""", """", 0, True)
            Dim pstMsg As String = "1" 'F.GetBetween(lHTML, "id=" & Chr(34) & "pstMsg" & Chr(34), " />")
            'pstMsg = F.GetBetween(pstMsg, "value=" & Chr(34), Chr(34))
            Dim hl As String = F.GetBetweenR(lHTML, "id=""hl"" value=""", """", 0, True)
            Dim continues As String = F.URLEncode(F.HTMLDecode(F.GetBetweenR(lHTML, "id=""continue"" value=""", """", 0, True)))
            Dim dnConn As String = "https%3A%2F%2Faccounts.youtube.com"
            'Dim POSTDATA As String = String.Format("ltmpl=sso&pstMsg={4}&dnConn={5}&continue={6}&service=youtube&uilel=3&dsh={0}&ltmpl=sso&hl={7}&ltmpl=sso&timeStmp=&secTok=&GALX={1}&Email={2}&Passwd={3}&PersistentCookie=yes&rmShown=1&signIn=Sign+in&asts=", dsh, GALX, Username, Password, pstMsg, dnConn, continues, hl)
            Dim POSTDATA As String = String.Format("continue=http%3A%2F%2Fwww.youtube.com%2Fsignin%3Faction_handle_signin%3Dtrue%26nomobiletemp%3D1%26hl%3Den_US%26next%3D%252F&service=youtube&uilel=3&dsh={0}&ltmpl=sso&hl=en_US&ltmpl=sso&GALX={1}&pstMsg=1&dnConn=https%3A%2F%2Faccounts.youtube.com&timeStmp=&secTok=&Email={2}&Passwd={3}&signIn=Sign+in&PersistentCookie=yes&rmShown=1", dsh, GALX, Username, Password)

            'Dim POSTDATA As String = String.Format("continue={0}&service=youtube&uilel=3&dsh={1}&ltmpl=sso&hl={2}&ltmpl=sso&GALX={3}&pstMsg=1&dnConn={4}&timeStmp=&secTok=&Email={5}&Passwd={6}&signIn=Sign+in&PersistentCookie=yes&rmShown=1", continues, dsh, hl, GALX, dnConn, Username, Password)
            lHTML = S.httpPost(action, POSTDATA, True)
            'Beg:        lHTML = F.GetBetweenR(lHTML, "HREF=""", """", 0, True)
            '           lHTML = S.httpGet(F.HTMLDecode(lHTML))
            '          If lHTML.Contains("Moved") And lHTML.Contains("machid") = False Then : GoTo Beg : End If
            ' SaveTextToFile(lHTML, "C:\Users\SpK\Desktop\tset.html")
            ' Process.Start("C:\Users\SpK\Desktop\tset.html")
            ' System.Threading.Thread.Sleep(1000)
            ' System.IO.File.Delete("C:\Users\SpK\Desktop\tset.html")

            If lHTML.Contains("location.replace(") Or lHTML.Contains("<title>Google Accounts</title>") Then
                Dim HTML2 As String
                Dim STR2 As String
                If lHTML.Contains("<title>Google Accounts</title>") Then
                    STR2 = F.GetBetweenR(lHTML, "url=", """>", 0, True)
                    'Dim SIDT As String
                    'SIDT = F.GetBetweenR(STR2, "sidt=", "&amp;", 0, True)
                    'STR2 = Replace(STR2, SIDT, F.URLDecode(SIDT))
                    STR2 = System.Web.HttpUtility.HtmlDecode(STR2)
                    HTML2 = S.httpGet(STR2)
                    If HTML2.Contains("url=&#39;") Then
                        STR2 = F.GetBetweenR(HTML2, "url=&#39;", "&#39;", 0, True)
                        STR2 = System.Web.HttpUtility.HtmlDecode(STR2)
                        HTML2 = S.httpGet(STR2)
                    End If
                ElseIf lHTML.Contains("location.replace(") Then
                    STR2 = F.GetBetween(lHTML, "url=&#39;", "&#39;")
                    'Dim SIDT As String
                    'SIDT = F.GetBetweenR(STR2, "sidt=", "&amp;", 0, True)
                    'STR2 = Replace(STR2, SIDT, F.URLDecode(SIDT))
                    STR2 = System.Web.HttpUtility.HtmlDecode(STR2)
                    HTML2 = S.httpGet(STR2)
                    If HTML2.Contains("<title>Redirecting</title>") Then
                        HTML2 = S.httpGet(System.Web.HttpUtility.HtmlDecode(F.GetBetween(HTML2, "url=&#39;", "&#39;")))
                    End If
                End If
                'If STR2.Contains("google") Then
                '    Dim aCont As String = Split(STR2, "continue=")(1)
                '    Dim bCont As String = Replace(F.URLDecode(Split(STR2, "continue=")(0)), "&amp;", "&")
                '    STR2 = F.URLDecode(aCont & bCont)
                'Else
                '    STR2 = Replace(STR2, "&amp;", "&")
                'End If
                If Not HTML2.Contains("Accounts Help") Or HTML2.Contains("Verify your account") Then
                    If Me.URL = Nothing Then
                        Return "Yes"
                    Else
                        Me.HTML = S.httpGetRef(Me.URL, "http://www.youtube.com/")
                    End If
Start:              If HTML.Contains("verificationImage") Then
                        If UseDBC = "Use" Then
                            Dim challenge_enc As String
                            challenge_enc = F.GetBetween(Me.HTML, "challenge_enc"" value=""", """>")
                            Dim captcha_image As Byte()
                            captcha_image = ImageToByte("http://www.youtube.com/cimg?c=" & challenge_enc)
                            Dim nexts As String
                            nexts = F.GetBetween(Me.HTML, "next"" value=""", """>")
                            Dim action_verify As String
                            action_verify = F.GetBetween(Me.HTML, "action_verify"" value=""", """>")
                            Dim submit As String = "Submit"
                            submit = F.GetBetween(Me.HTML, "submit"" value=""", """>")
                            Dim session_token2 As String
                            session_token2 = F.GetBetween(Me.HTML, "'XSRF_TOKEN': '", "',")
                            Dim client As New HttpClient(DBCU, DBCP)
                            Dim captcha As Captcha = client.Decode(captcha_image, DBCTimeout)
                            Dim urlPOST As String = "http://www.youtube.com/das_captcha?next=" & nexts
                            Dim post As String = "challenge_enc=" & F.URLEncode(challenge_enc) & "&next=" & F.URLEncode(nexts) & "&response=" & captcha.Text & "&action_verify=" & action_verify & "&submit=" & submit & "&session_token=" & F.URLEncode(session_token2)
                            Me.HTML = S.httpPost(urlPOST, post)
                            If Me.HTML.Contains("Incorrect match for the verification code") Then
                                If client.Report(captcha) Then
                                    Console.WriteLine("-------------------------------") : Console.WriteLine("Reported as incorrectly solved") : Console.WriteLine("-------------------------------")
                                    GoTo Start
                                Else
                                    Console.WriteLine("-------------------------------") : Console.WriteLine("Failed reporting as incorrectly solved") : Console.WriteLine("-------------------------------")
                                    GoTo Start
                                End If
                            End If
                        ElseIf UseDBC = "Manual" Then
                            Dim challenge_enc As String
                            challenge_enc = F.GetBetween(Me.HTML, "challenge_enc"" value=""", """>")
                            Dim captcha_image As Bitmap = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("http://www.youtube.com/cimg?c=" & challenge_enc)))
                            Dim nexts As String
                            nexts = F.GetBetween(Me.HTML, "next"" value=""", """>")
                            Dim action_verify As String
                            action_verify = F.GetBetween(Me.HTML, "action_verify"" value=""", """>")
                            Dim submit As String = "Submit"
                            submit = F.GetBetween(Me.HTML, "submit"" value=""", """>")
                            Dim session_token2 As String
                            session_token2 = F.GetBetween(Me.HTML, "'XSRF_TOKEN': '", "',")
                            Dim C As New frmCaptcha
                            C.PB.Image = captcha_image
                            C.Theme.Text = MSG
                            Dim RESOLVED As String = ""
                            If C.ShowDialog = DialogResult.OK Then
                                RESOLVED = C.txtCaptcha.Text
                            End If
                            Dim urlPOST As String = "http://www.youtube.com/das_captcha?next=" & nexts
                            Dim post As String = "challenge_enc=" & F.URLEncode(challenge_enc) & "&next=" & F.URLEncode(nexts) & "&response=" & RESOLVED & "&action_verify=" & action_verify & "&submit=" & submit & "&session_token=" & F.URLEncode(session_token2)
                            Me.HTML = S.httpPost(urlPOST, post)
                            If Me.HTML.Contains("Incorrect match for the verification code") Then
                                MSG = "Incorrect captcha, please enter again"
                                If Tries < 3 Then
                                    Tries += 1
                                    GoTo Login
                                End If
                            End If
                        Else
                            Return "No"
                        End If
                    End If
                    Return "Yes"
                End If
            End If
            Return "No"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
#End Region
#Region "Dislike"
    Public Function [Dislike]() As Boolean
        Try
            'HTML = GetBetweenReg(HTML, "action_dislike_video=1", "station_id", 0, True)
            Dim session_token As String = F.GetBetween(Me.HTML, "yt.net.ajax.setToken('watch_actions_ajax', """, """);") 'GetBetweenReg(HTML, "yt.net.ajax.setToken('watch_ajax', """, """);", 0, True)
            Dim station_id As String = ""
            Dim post As String = "video_id=" & ID & "&session_token=" & F.URLEncode(session_token) & "&screen=" & Resolution
            Dim response As String = S.httpPost("http://www.youtube.com/watch_actions_ajax?action_dislike_video=1", post)
            If response.Contains("dislike") Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function
#End Region
#Region "Like"
    Public Function [Like]() As Boolean
        Try
            Dim session_token As String = F.GetBetween(Me.HTML, "yt.net.ajax.setToken('watch_actions_ajax', """, """);")
            Dim station_id As String = ""
            Dim post As String = "video_id=" & ID & "&screen=" & Resolution & "&session_token=" & F.URLEncode(session_token)
            Dim response As String = S.httpPost("http://www.youtube.com/watch_actions_ajax?action_like_video=1", post)
            If response.Contains("Thanks!") Then
                Return True
            End If
            Return False
        Catch
            Return False
        End Try
    End Function
#End Region
#Region "Rate Comment"
    Dim page As Integer = 1
    Dim commentIDG As String = ""
    Public Function [RateCommentID](ByVal ID As String, ByVal Up As Boolean, Optional ByRef User As String = "") As Boolean
        Try
            Dim HTML As String = S.httpGet("http://www.youtube.com/comment?lc=" & ID)
            Dim video_id As String = Mid(Split(HTML, "<link rel=""canonical"" href=""/watch?v=")(1), 1, 11)
            Dim sSession As String
            sSession = HTML
            Dim session_token As String = F.GetBetweenR(sSession, "'COMMENT_VOTE_XSRF' : 'session_token=", "',", 0, True)
            sSession = "session_token=" & F.URLEncode(session_token)
            Dim CommentS As String = GetBetweenComms(HTML, "<li class=""comment", """>", True, ID)
            If CommentS.Contains("hidden flagged") Then
                Return False
            End If
            Dim commentIDz As String = getCommentID(CommentS)
            Dim commentTag As String = getCommentTag(CommentS)
            Dim commentOldVote As String = getCommentOldVote(CommentS)
            Dim commentAuthor As String = getCommentAuthor(CommentS)
            Dim response As String = vbNullString
            If commentTag <> vbNullString Then
                If Up Then
                    response = S.httpPost("http://www.youtube.com/comment_voting?a=1&id=" & ID & "&video_id=" & video_id & "&old_vote=" & commentOldVote & "&tag=" & commentTag, sSession) ', "http://www.youtube.com/watch?v=" & video_id)
                Else
                    response = S.httpPost("http://www.youtube.com/comment_voting?a=-1&id=" & ID & "&video_id=" & video_id & "&old_vote=" & commentOldVote & "&tag=" & commentTag, sSession) ', "http://www.youtube.com/watch?v=" & video_id)
                End If
            Else
                If Up Then
                    response = S.httpPost("http://www.youtube.com/comment_voting?a=1&id=" & ID & "&video_id=" & video_id & "&old_vote=" & commentOldVote, sSession) ', "http://www.youtube.com/watch?v=" & video_id)
                Else
                    response = S.httpPost("http://www.youtube.com/comment_voting?a=-1&id=" & ID & "&video_id=" & video_id & "&old_vote=" & commentOldVote, sSession) ', "http://www.youtube.com/watch?v=" & video_id)
                End If
            End If
            Trace.WriteLine(response)
            If Up Then
                If response.Contains("watch-comment-up-on") Then
                    User = commentAuthor
                    Return True
                Else
                    Return False
                End If
            Else
                If response.Contains("watch-comment-down-on") Then
                    User = commentAuthor
                    Return True
                Else
                    Return False
                End If
            End If
        Catch
            Return False
        End Try
    End Function
    Public Function [RateComment](ByVal video_id As String, ByVal Username As String, Optional ByRef commentID As String = "") As Boolean
        Try
            If page = 11 Then
                Return False
            End If
            Dim HTML As String = S.httpGet("http://www.youtube.com/all_comments?v=" & video_id & "&page=" & page)
Check:      If Not HTML.Contains(Username) Then
                If Not page = 11 Then
                    page += 1
                    HTML = S.httpGet("http://www.youtube.com/all_comments?v=" & video_id & "&page=" & page)
                    GoTo Check
                Else
                    Return False
                End If
            End If
            Dim sSession As String
            sSession = HTML
            Dim session_token As String = F.GetBetweenR(sSession, "'COMMENT_VOTE_XSRF' : 'session_token=", "',", 0, True)
            sSession = "session_token=" & F.URLEncode(session_token)
            Dim CommentS As String = GetBetweenComms(HTML, "<li class=""comment", """>", True, "data-author=""" & Username)
            If CommentS.Contains("hidden flagged") Then
                Return False
            End If
            Dim commentIDz As String = getCommentID(CommentS)
            Dim commentTag As String = getCommentTag(CommentS)
            Dim commentOldVote As String = getCommentOldVote(CommentS)
            If commentIDG = "" Then
                commentIDG = commentIDz
            End If
            commentID = commentIDG
            Dim response As String
            If commentTag <> vbNullString Then
                response = S.httpPost("http://www.youtube.com/comment_voting?a=1&id=" & commentIDG & "&video_id=" & video_id & "&old_vote=" & commentOldVote & "&tag=" & commentTag, sSession) ', "http://www.youtube.com/all_comments?v=" & video_id & "&page=" & page)
            Else
                response = S.httpPost("http://www.youtube.com/comment_voting?a=1&id=" & commentIDG & "&video_id=" & video_id & "&old_vote=" & commentOldVote, sSession) ', "http://www.youtube.com/all_comments?v=" & video_id & "&page=" & page)
            End If
            If response.Contains("watch-comment-score watch-comment-green") Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function
    Private Function GetBetweenComms(ByVal input As String, ByVal str1 As String, ByVal str2 As String, ByVal trim As Boolean, ByVal searchFor As String) As String
        Try
            Dim temp() As String = Regex.Split(input, str1)
            For i = 1 To UBound(temp)
                If Regex.Split(StrConv(temp(i), vbLowerCase), str2)(0).Contains(StrConv(searchFor, vbLowerCase)) Then
                    If trim = True Then
                        Return Regex.Split(temp(i), str2)(0).Trim()
                    Else
                        Return Regex.Split(temp(i), str2)(0)
                    End If
                End If
            Next
            Return vbNullString
        Catch
            Return vbNullString
        End Try
    End Function
    Private Function getCommentID(ByVal commentSRC As String) As String
        Try
            Return F.GetBetweenR(commentSRC, "data-id=""", """", 0, True)
        Catch
            Return vbNullString
        End Try
    End Function
    Private Function getCommentTag(ByVal commentSRC As String) As String
        Try
            Return F.GetBetweenR(commentSRC, "data-tag=""", """", 0, True)
        Catch
            Return vbNullString
        End Try
    End Function
    Private Function getCommentAuthor(ByVal commentSRC As String) As String
        Try
            Return F.GetBetweenR(commentSRC, "data-author=""", """", 0, True)
        Catch
            Return vbNullString
        End Try
    End Function
    Private Function getCommentOldVote(ByVal commentSRC As String) As String
        Try
            Return F.GetBetweenR(commentSRC, "data-score=""", """", 0, True)
        Catch
            Return vbNullString
        End Try
    End Function
#End Region
#Region "Subscribe"
    Public Function [Subscribe](Optional ByRef sUser As String = "") As Boolean
        Try
            Dim session_token As String = F.GetBetweenR(Me.HTML, "data-subscription-xsrf=""", """ data-subscription-feature=""", 0, True)
            Dim Username As String
            If Me.HTML.Contains("data-subscription-username") Then
                Username = F.GetBetweenR(Me.HTML, "data-subscription-username=""", """ data-subscription-expandable-id=""", 0, True)
            ElseIf Me.HTML.Contains("data-subscription-value") Then
                Username = F.GetBetweenR(Me.HTML, "data-subscription-value=""", """ data-subscription-menu-type=""", 0, True)
            End If
            Dim menu_type As String = F.GetBetweenR(Me.HTML, "data-subscription-menu-type=""", """", 0, True)
            Dim response As String = S.httpPost("http://www.youtube.com/subscription_ajax?action_create_subscription_to_user=1", "session_token=" & session_token & "&menu_type=" & menu_type & "&u=" & Username)
            sUser = Username
            Debug.WriteLine(response)
            If response.Contains("You are now") Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function
#End Region
#Region "Favorite"
    Public Function [Favorite]() As Boolean
        Try
            Dim HTML2 As String
            HTML2 = F.GetBetweenR(Me.HTML, "<ul class=""addto-menu"">", "</ul>", 0, True)
            Dim session_token As String = F.GetBetweenR(HTML2, """session_token"" value=""", """/>", 0, True)
            Dim post As String = "video_ids=" & ID & "&playlist_id=&new_playlist_name=" & "&session_token=" & F.URLEncode(session_token)
            Dim response As String = S.httpPost("http://www.youtube.com/addto_ajax?feature=watch&action_add_to_favorites=1", post)
            If response.Contains("Added") Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function
#End Region
#Region "Friend Request"
    Public Function [Friend](Optional ByRef Username As String = "") As Boolean
        Try
            Dim sUser As String
            If Me.HTML.Contains("data-subscription-username") Then
                sUser = F.GetBetweenR(Me.HTML, "data-subscription-username=""", """ data-subscription-expandable-id=""", 0, True)
            ElseIf Me.HTML.Contains("data-subscription-value") Then
                sUser = F.GetBetweenR(Me.HTML, "data-subscription-value=""", """ data-subscription-menu-type=""", 0, True)
            End If
            Dim session_token As String = S.httpGet("http://www.youtube.com/user/" & sUser)
            session_token = F.GetBetweenR(session_token, "window.ajax_session_info = 'session_token=", "';", 0, True)
            Dim response As String = S.httpPost("http://www.youtube.com/profile_ajax?action_ajax=1&user=" & sUser & "&new=1&box_method=add_friend&box_name=user_profile", "session_token=" & session_token & "&messages=%5B%7B%22type%22%3A%22box_method%22%2C%22request%22%3A%7B%22name%22%3A%22user_profile%22%2C%22x_position%22%3A0%2C%22y_position%22%3A0%2C%22palette%22%3A%22default%22%2C%22method%22%3A%22add_friend%22%2C%22params%22%3A%7B%22username%22%3A%22" & sUser & "%22%7D%7D%7D%5D")
            Debug.WriteLine(response)
            If response.Contains("sent") Then
                Username = sUser
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function
    Public Function [FriendAdder](ByVal Channel As String) As String
        Try
            Dim sUser As String = Channel
Login:      Dim session_token As String = S.httpGet("http://www.youtube.com/user/" & sUser)
            Dim MSG As String = "Please enter the captcha"
            Dim Tries As Integer = 0
Start:      If session_token.Contains("verificationImage") Then
                If UseDBC = "Use" Then
                    Dim challenge_enc As String
                    challenge_enc = F.GetBetween(session_token, "challenge_enc"" value=""", """>")
                    Dim captcha_image As Byte()
                    captcha_image = ImageToByte("http://www.youtube.com/cimg?c=" & challenge_enc)
                    Dim nexts As String
                    nexts = F.GetBetween(session_token, "next"" value=""", """>")
                    Dim action_verify As String
                    action_verify = F.GetBetween(session_token, "action_verify"" value=""", """>")
                    Dim submit As String = "Submit"
                    submit = F.GetBetween(session_token, "submit"" value=""", """>")
                    Dim session_token2 As String
                    session_token2 = F.GetBetween(session_token, "'XSRF_TOKEN': '", "',")
                    Dim client As New HttpClient(DBCU, DBCP)
                    Dim captcha As Captcha = client.Decode(captcha_image, DBCTimeout)
                    Dim urlPOST As String = "http://www.youtube.com/das_captcha?next=" & nexts
                    Dim post As String = "challenge_enc=" & F.URLEncode(challenge_enc) & "&next=" & F.URLEncode(nexts) & "&response=" & captcha.Text & "&action_verify=" & action_verify & "&submit=" & submit & "&session_token=" & F.URLEncode(session_token2)
                    session_token = S.httpPost(urlPOST, post)
                    If session_token.Contains("Incorrect match for the verification code") Then
                        If client.Report(captcha) Then
                            Console.WriteLine("-------------------------------") : Console.WriteLine("Reported as incorrectly solved") : Console.WriteLine("-------------------------------")
                            GoTo Start
                        Else
                            Console.WriteLine("-------------------------------") : Console.WriteLine("Failed reporting as incorrectly solved") : Console.WriteLine("-------------------------------")
                            GoTo Start
                        End If
                    End If
                ElseIf UseDBC = "Manual" Then
                    Dim challenge_enc As String
                    challenge_enc = F.GetBetween(session_token, "challenge_enc"" value=""", """>")
                    Dim captcha_image As Bitmap = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("http://www.youtube.com/cimg?c=" & challenge_enc)))
                    Dim nexts As String
                    nexts = F.GetBetween(session_token, "next"" value=""", """>")
                    Dim action_verify As String
                    action_verify = F.GetBetween(session_token, "action_verify"" value=""", """>")
                    Dim submit As String = "Submit"
                    submit = F.GetBetween(session_token, "submit"" value=""", """>")
                    Dim session_token2 As String
                    session_token2 = F.GetBetween(session_token, "'XSRF_TOKEN': '", "',")
                    Dim C As New frmCaptcha
                    C.PB.Image = captcha_image
                    C.Theme.Text = MSG
                    Dim RESOLVED As String = ""
                    If C.ShowDialog = DialogResult.OK Then
                        RESOLVED = C.txtCaptcha.Text
                    End If
                    Dim urlPOST As String = "http://www.youtube.com/das_captcha?next=" & nexts
                    Dim post As String = "challenge_enc=" & F.URLEncode(challenge_enc) & "&next=" & F.URLEncode(nexts) & "&response=" & RESOLVED & "&action_verify=" & action_verify & "&submit=" & submit & "&session_token=" & F.URLEncode(session_token2)
                    session_token = S.httpPost(urlPOST, post)
                    If session_token.Contains("Incorrect match for the verification code") Then
                        MSG = "Incorrect captcha, please enter again"
                        If Tries < 3 Then
                            Tries += 1
                            GoTo Login
                        End If
                    End If
                Else
                    Exit Function
                End If
            End If
            session_token = F.GetBetweenR(session_token, "window.ajax_session_info = 'session_token=", "';", 0, True)
            Dim response As String = S.httpPost("http://www.youtube.com/profile_ajax?action_ajax=1&user=" & sUser & "&new=1&box_method=add_friend&box_name=user_profile", "session_token=" & session_token & "&messages=%5B%7B%22type%22%3A%22box_method%22%2C%22request%22%3A%7B%22name%22%3A%22user_profile%22%2C%22x_position%22%3A0%2C%22y_position%22%3A0%2C%22palette%22%3A%22default%22%2C%22method%22%3A%22add_friend%22%2C%22params%22%3A%7B%22username%22%3A%22" & sUser & "%22%7D%7D%7D%5D")
            Debug.WriteLine(response)
            If response.Contains("sent") Then
                Username = sUser
                Return "Yes"
            ElseIf response.Contains("You have recently contacted too many users") Then
                RaiseEvent FriendAdderLimit(Me)
                Return "Limit"
            Else
                Return "No"
            End If
        Catch
            Return "No"
        End Try
    End Function
#End Region
#Region "Comment"
    Public Function [Comment](ByVal strComment As String, Optional ByRef CommentID As String = vbNullString) As Boolean
        Try
            Dim MSG As String = "Please enter the captcha"
            Dim Tries As Integer = 0
Start:      Dim SESSION_TOKEN As String = F.URLEncode(F.GetBetweenR(Me.HTML, """session_token"" value=""", """/>", 0, True))
            If strComment.Contains("{") And strComment.Contains("}") Then
                strComment = F.Spin(strComment)
            End If
            If Me.HTML.Contains("Adding comments has been disabled for this video") Then
                Return False
            End If
            Dim CLENGTH As Integer = strComment.Length
            Dim COM As String = F.URLEncode(strComment) '.Replace("+", "%20")
            Dim LEFT As Integer = 500 - CLENGTH
            Dim POST As String = String.Format("form_id=&reply_parent_id=&video_id={0}&return_ajax=true&screen=" & Resolution & "&source=w&session_token={1}&comment={2}&={3}", ID, SESSION_TOKEN, COM, LEFT)
            Dim wordcount As Integer
            Dim words As String()
            words = Split(strComment, " ")
            wordcount = words.Length
            Dim REQURL As String = String.Format("http://www.youtube.com/comment_servlet?add_comment=1&len={0}&wc={1}", CLENGTH, wordcount)
            Dim RESPONSE As String = S.httpPost(REQURL, POST)
Check:      If RESPONSE.Contains("author-viewing") Then
                CommentID = F.GetBetweenR(RESPONSE, "data-id=""", """", 0, True)

                Debug.WriteLine(POST)
                Debug.WriteLine(REQURL)

                Return True
            ElseIf RESPONSE.Contains("CAPTCHA") Then
                If UseDBC = "Use" Then
                    Dim C_SESSION As String = F.GetBetweenR(Me.HTML, "&#39;session_token=", "&#39;", 0, True)
                    'Dim C_SESSION As String = F.GetBetweenR(Me.HTML, "name=""challenge"" value=""", """>", 0, True)
                    Dim STUFF As String = S.httpPost("http://www.youtube.com/comment_servlet?gimme_captcha=1&watch5=1", "session_token=" & C_SESSION)
                    Dim IMGURL As String = "http://www.youtube.com" & F.GetBetweenR(STUFF, "src=""", """>", 1, True)
                    Dim IMAGE As Byte() = ImageToByte(IMGURL)
                    Dim CHALLENGE As String = F.URLEncode(Split(IMGURL, "=")(1) & "==")
                    Dim CLIENT As New HttpClient(DBCU, DBCP)
                    Dim CAPTCHA As Captcha = CLIENT.Decode(IMAGE, DBCTimeout)
                    Dim RESOLVED As String = CAPTCHA.Text
                    POST = String.Format("form_id=&reply_parent_id=&video_id={0}&return_ajax=true&screen=" & Resolution & "&source=w&session_token={1}&response={4}&challenge={5}&comment={2}&={3}", ID, SESSION_TOKEN, COM, LEFT, RESOLVED, CHALLENGE)
                    RESPONSE = S.httpPost(REQURL, POST)
                    If RESPONSE.Contains("[CDATA[INLINE_CAPTCHAFAIL]]") Then
                        If CLIENT.Report(CAPTCHA) Then
                            Console.WriteLine("-------------------------------") : Console.WriteLine("Reported as incorrectly solved") : Console.WriteLine("-------------------------------")
                            Me.HTML = S.httpGet(Me.URL)
                            GoTo Start
                        Else
                            Console.WriteLine("-------------------------------") : Console.WriteLine("Failed reporting as incorrectly solved") : Console.WriteLine("-------------------------------")
                            Me.HTML = S.httpGet(Me.URL)
                            GoTo Start
                        End If
                    End If
                ElseIf UseDBC = "Manual" Then
                    Dim C_SESSION As String = F.GetBetweenR(Me.HTML, "&#39;session_token=", "&#39;", 0, True)
                    Dim STUFF As String = S.httpPost("http://www.youtube.com/comment_servlet?gimme_captcha=1&watch5=1", "session_token=" & C_SESSION)
                    Dim IMGURL As String = "http://www.youtube.com" & F.GetBetweenR(STUFF, "src=""", """>", 1, True)
                    Dim IMAGE As Byte() = ImageToByte(IMGURL)
                    Dim CHALLENGE As String = F.URLEncode(Split(IMGURL, "=")(1) & "==")
                    Dim C As New frmCaptcha
                    C.PB.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(IMGURL)))
                    C.Theme.Text = MSG
                    Dim RESOLVED As String = ""
                    If C.ShowDialog = DialogResult.OK Then
                        RESOLVED = C.txtCaptcha.Text
                    End If
                    POST = String.Format("form_id=&reply_parent_id=&video_id={0}&return_ajax=true&screen=" & Resolution & "&source=w&session_token={1}&response={4}&challenge={5}&comment={2}&={3}", ID, SESSION_TOKEN, COM, LEFT, RESOLVED, CHALLENGE)
                    RESPONSE = S.httpPost(REQURL, POST)
                    GoTo Check
                End If
            ElseIf RESPONSE.Contains("BLOCKED") Then
                Debug.WriteLine(RESPONSE)
                Return False
            ElseIf RESPONSE.Contains("[CDATA[INLINE_CAPTCHAFAIL]]") Then
                Me.HTML = S.httpGet(Me.URL)
                MSG = "Incorrect captcha, please enter again"
                If Tries < 3 Then
                    Tries += 1
                    GoTo Start
                End If
            Else
                Debug.WriteLine(RESPONSE)
                Return False
            End If
        Catch
            Debug.WriteLine("Catched")
            Return False
        End Try
        Return False
    End Function
#End Region
#Region "Flag"
    Public Function [Flag](ByVal reason As String) As Boolean
        Try
            Dim R As Integer
            If reason = "scams / fraud" Then
                R = 21
            ElseIf reason = "misleading text" Then
                R = 19
            End If
            Dim session_token As String = F.GetBetween(Me.HTML, "yt.net.ajax.setToken('watch_ajax', """, """);")
            Dim Tries As Integer = 0
            Dim MSG As String = "Please enter the captcha"
Captcha:    Dim PrePOST As String = S.httpGet("http://www.youtube.com/watch_ajax?video_id=" & ID & "&action_get_flag_video_component=1")
            If PrePOST.Contains("verificationImage") Then
                If UseDBC = "Use" Then
                    Dim challenge As String = F.GetBetweenR(PrePOST, "<input type=""hidden"" name=""challenge"" value=""", """>", 0, True)
                    Dim client As New HttpClient(DBCU, DBCP)
                    Dim captcha As Captcha = client.Decode(ImageToByte("http://www.youtube.com/cimg?c=" & challenge), DBCTimeout)
                    Dim POST As String = String.Format("session_token={0}&action_flag_video=1&video_id={1}&reason=Z&sub_reason={2}&flag_id=&flag_t_mins=&flag_t_secs=&flag_desc=&flag_protected_group=&anno_reason=&anno_sub_reason=&flag_anno_id=&flag_anno_t_mins=&flag_anno_t_secs=&flag_anno_desc=&flag_anno_protected_group=&response={3}&challenge={4}", F.URLEncode(session_token), ID, R, captcha.Text, challenge)
                    Dim response As String = S.httpPost("http://www.youtube.com/watch_ajax?log_action_flag", POST)
                    If response.Contains("[CDATA[0]]") Then
                        Return True
                    Else
                        client.Report(captcha)
                        GoTo Captcha
                    End If
                ElseIf UseDBC = "Manual" Then
                    Dim C As New frmCaptcha
                    Dim challenge As String = F.GetBetweenR(PrePOST, "<input type=""hidden"" name=""challenge"" value=""", """>", 0, True)
                    Dim captcha_image As Bitmap = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("http://www.youtube.com/cimg?c=" & challenge)))
                    C.PB.Image = captcha_image
                    C.Theme.Text = MSG
                    Dim RESOLVED As String = ""
                    If C.ShowDialog = DialogResult.OK Then
                        RESOLVED = C.txtCaptcha.Text
                    End If
                    Dim POST As String = String.Format("session_token={0}&action_flag_video=1&video_id={1}&reason=Z&sub_reason={2}&flag_id=&flag_t_mins=&flag_t_secs=&flag_desc=&flag_protected_group=&anno_reason=&anno_sub_reason=&flag_anno_id=&flag_anno_t_mins=&flag_anno_t_secs=&flag_anno_desc=&flag_anno_protected_group=&response={3}&challenge={4}", F.URLEncode(session_token), ID, R, RESOLVED, challenge)
                    Dim response As String = S.httpPost("http://www.youtube.com/watch_ajax?log_action_flag", POST)
                    If response.Contains("[CDATA[0]]") Then
                        Return True
                    Else
                        If Tries < 3 Then
                            MSG = "Incorrect captcha, please enter again"
                            Tries += 1
                            GoTo Captcha
                        End If
                    End If
                Else
                    Return False
                End If
            End If
            Return False
        Catch
            Return False
        End Try
    End Function
#End Region
#Region "Message"
    Event FriendLock(ByVal Index As Integer)
    Event SentNoReceive(ByVal Index As Integer)
    Event MessageSent(ByVal Index As Integer)
    Event MessageLimit(ByVal Index As Integer)
    Public Function Message(ByVal Index As Integer, ByVal ToWho As String, ByVal Subject As String, ByVal Body As String, Optional ByVal Embed As Boolean = False, Optional ByVal ID As String = "") As String
        Dim POST As String
        If Body.Contains("{") And Body.Contains("|") And Body.Contains("}") Then
            Body = F.Spin(Body)
        End If
        If Subject.Contains("{") And Subject.Contains("|") And Subject.Contains("}") Then
            Subject = F.Spin(Subject)
        End If
        If Embed = False Then
            POST = F.URLEncode("[{""type"":""send_message"",""request"":{""to_users"":""" & ToWho & """,""to_all_subscribers"":""false"",""subject"":""" & Subject & """,""message_text"":""" & Body & """}}]")
        Else
            POST = F.URLEncode("[{""type"":""send_message"",""request"":{""to_users"":""" & ToWho & """,""to_all_subscribers"":""false"",""subject"":""" & Subject & """,""video_id"":""" & ID & """,""message_text"":""" & Body & """}}]")
        End If
        Dim session_token As String = S.httpGet("http://www.youtube.com/inbox?feature=mhum&folder=messages")
        If Embed = True Then
            If Not session_token.Contains("value=""" & ID & """") Then
                ChangeVideo("http://www.youtube.com/watch?v=" & ID)
                Me.ID = ID
                Favorite()
            End If
        End If
        'If session_token.Contains("location.replace") Then
        'session_token = S.httpGet(F.GetBetweenR(session_token, "url=&#39;", "&#39", 0, True))
        'End If
        session_token = F.GetBetweenR(session_token, "inbox.initialize\('session_token=", "',", 0, True)
        Dim RESPONSE As String = S.httpPost("http://www.youtube.com/inbox?action_ajax=1", String.Format("session_token={0}&messages={1}", session_token, POST))
        If RESPONSE.Contains("Your message has been sent!") Then
            Dim Sent As String = S.httpPost("http://www.youtube.com/inbox?action_ajax=1&folder=sent", "session_token=" & session_token & "&messages=%5B%7B%22type%22%3A%22display_messages%22%2C%22request%22%3A%7B%22folder%22%3A%22sent%22%2C%22start%22%3A0%2C%22num%22%3A20%2C%22messages_deleted%22%3A%5B%5D%2C%22messages_read%22%3A%5B%5D%7D%7D%5D")
            Sent = System.Web.HttpUtility.HtmlDecode(Sent.Replace("\u0025", "%").Replace("\u002c", ",").Replace("\u007c", "|").Replace("\u003f", "?").Replace("\u003d", "=").Replace("\u0026", "&").Replace("\u002f", "/").Replace("\u003a", ":").Replace("\u003c", "<").Replace("\n", vbNewLine).Replace("u003e", ">").Replace("\", ""))
            Dim Last As String = F.GetBetweenR(Sent, "<tr id=", "<div class=""video-details"">", 0, True)
            Dim _S As String
            Dim _B As String
            _S = F.GetBetweenR(Last, "-subject"" value=""", """/>", 0, True)
            _B = F.GetBetweenR(Last, "<div class=""body"">", "</div>", 0, True)
            _B = F.GetBetweenR(_B, "<span", "</span>", 0, True)
            If _S.Contains(Subject) And _B.Contains(Body) Then
                RaiseEvent MessageSent(Index)
                Return "Yes"
            Else
                RaiseEvent SentNoReceive(Index)
                Return "Kinda"
            End If
        ElseIf RESPONSE.ToLower.Contains("friend lock") Then
            RaiseEvent FriendLock(Index)
            Return "Lock"
        Else
            RaiseEvent MessageLimit(Index)
            Return "Limit"
        End If
        Return False
    End Function
#End Region
#Region "Uploader"
    Private Sub SProgressChanged(ByVal sender As Object, ByVal Progress As Integer, ByVal index As Integer)
        RaiseEvent UploadProgressChanged(Me, Progress, index)
    End Sub
    Private Function FixIllegal(ByVal str As String) As String
        Return str
        'Return Regex.Replace(str, "[^A-Za-z0-9\,]", "")
    End Function
    Public Function Upload(ByVal Title As String, ByVal Description As String, ByVal Keywords As String, ByVal Cat As String, ByVal File As String, ByVal Privacy As String, ByVal Index As Integer, ByVal AllowComment As String, ByVal AllowRatings As Boolean, Optional ByRef ID As String = "") As String
        '2   =>  'Autos & Vehicles'
        '23  =>  'Comedy'
        '27  =>  'Education'
        '24  =>  'Entertainment'
        '1   =>  'Film & Animation'
        '20  =>  'Gaming'
        '26  =>  'Howto & Style'
        '10  =>  'Music'
        '25  =>  'News & Politics'
        '29  =>  'Nonprofits & Activism'
        '22  =>  'People & Blogs'
        '15  =>  'Pets & Animals'
        '28  =>  'Science & Technology'
        '17  =>  'Sports'
        '19  =>  'Travel & Places'
        Privacy = Privacy.ToLower
        Dim Category As Integer
        If Cat = "Film & Animation" Then
            Category = 1
        ElseIf Cat = "Cars & Vehicles" Then
            Category = 2
        ElseIf Cat = "Music" Then
            Category = 10
        ElseIf Cat = "Pets & Animals" Then
            Category = 15
        ElseIf Cat = "Sport" Then
            Category = 17
        ElseIf Cat = "Travel & Events" Then
            Category = 19
        ElseIf Cat = "Gaming" Then
            Category = 20
        ElseIf Cat = "Comedy" Then
            Category = 23
        ElseIf Cat = "Entertainment" Then
            Category = 24
        ElseIf Cat = "Howto & Style" Then
            Category = 26
        ElseIf Cat = "News & Politics" Then
            Category = 25
        ElseIf Cat = "Education" Then
            Category = 27
        ElseIf Cat = "Science & Technology" Then
            Category = 28
        End If
        Try
            QueIndex = Index
            Dim TM As New TypingMonkey
Login:      Dim Response As String = S.httpGet(upload_url)
            If Response.Contains("location.replace(""") Then
                Response = S.httpGet(F.GetBetweenR(Response, "&#39;", "&#39", 0, True))
            End If
            Dim MSG As String = "Please enter the captcha"
            Dim Tries As Integer = 0
Start:      If Response.Contains("verificationImage") Then
                If UseDBC = "Use" Then
                    Dim challenge_enc As String
                    challenge_enc = F.GetBetween(Response, "challenge_enc"" value=""", """>")
                    Dim captcha_image As Byte()
                    captcha_image = ImageToByte("http://www.youtube.com/cimg?c=" & challenge_enc)
                    Dim nexts As String
                    nexts = F.GetBetween(Response, "next"" value=""", """>")
                    Dim action_verify As String
                    action_verify = F.GetBetween(Response, "action_verify"" value=""", """>")
                    Dim submit As String = "Submit"
                    submit = F.GetBetween(Response, "submit"" value=""", """>")
                    Dim response2 As String
                    response2 = F.GetBetween(Response, "'XSRF_TOKEN': '", "',")
                    Dim client As New HttpClient(DBCU, DBCP)
                    Dim captcha As Captcha = client.Decode(captcha_image, DBCTimeout)
                    Dim urlPOST As String = "http://www.youtube.com/das_captcha?next=" & nexts
                    Dim post As String = "challenge_enc=" & F.URLEncode(challenge_enc) & "&next=" & F.URLEncode(nexts) & "&response=" & captcha.Text & "&action_verify=" & action_verify & "&submit=" & submit & "&response=" & F.URLEncode(response2)
                    Response = S.httpPost(urlPOST, post)
                    If Response.Contains("Incorrect match for the verification code") Then
                        If client.Report(captcha) Then
                            Console.WriteLine("-------------------------------") : Console.WriteLine("Reported as incorrectly solved") : Console.WriteLine("-------------------------------")
                            GoTo Start
                        Else
                            Console.WriteLine("-------------------------------") : Console.WriteLine("Failed reporting as incorrectly solved") : Console.WriteLine("-------------------------------")
                            GoTo Start
                        End If
                    End If
                ElseIf UseDBC = "Manual" Then
                    Dim challenge_enc As String
                    challenge_enc = F.GetBetween(Response, "challenge_enc"" value=""", """>")
                    Dim captcha_image As Bitmap = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("http://www.youtube.com/cimg?c=" & challenge_enc)))
                    Dim nexts As String
                    nexts = F.GetBetween(Response, "next"" value=""", """>")
                    Dim action_verify As String
                    action_verify = F.GetBetween(Response, "action_verify"" value=""", """>")
                    Dim submit As String = "Submit"
                    submit = F.GetBetween(Response, "submit"" value=""", """>")
                    Dim response2 As String
                    response2 = F.GetBetween(Response, "'XSRF_TOKEN': '", "',")
                    Dim C As New frmCaptcha
                    C.PB.Image = captcha_image
                    C.Theme.Text = MSG
                    Dim RESOLVED As String = ""
                    If C.ShowDialog = DialogResult.OK Then
                        RESOLVED = C.txtCaptcha.Text
                    End If
                    Dim urlPOST As String = "http://www.youtube.com/das_captcha?next=" & nexts
                    Dim post As String = "challenge_enc=" & F.URLEncode(challenge_enc) & "&next=" & F.URLEncode(nexts) & "&response=" & RESOLVED & "&action_verify=" & action_verify & "&submit=" & submit & "&response=" & F.URLEncode(response2)
                    Response = S.httpPost(urlPOST, post)
                    If Response.Contains("Incorrect match for the verification code") Then
                        MSG = "Incorrect captcha, please enter again"
                        If Tries < 3 Then
                            Tries += 1
                            GoTo Login
                        End If
                    End If
                Else
                    Exit Function
                End If
            End If
            Dim SI As String = F.GetBetweenR(Response, "'sessionKey': '", "',", 0, True)
            Dim UK As String = F.GetBetweenR(Response, "'uploadKey': '", "',", 0, True)
            Dim session_token As String = F.GetBetweenR(Response, "session_token"" value=""", """/>", 0, True)
            '--
            Dim U_URL1 As String = Replace(upload_video_url1, "%UK%", UK)
            U_URL1 = Replace(U_URL1, "%SI%", SI)
            Dim U_URL3 As String = Replace(upload_video_url3, "%UK%", UK)
            U_URL3 = Replace(U_URL3, "%SI%", SI)
            Dim U_URL4 As String = Replace(upload_video_url4, "%UK%", UK)
            U_URL4 = Replace(U_URL4, "%SI%", SI)
            '--
            Response = S.httpGet(U_URL1)
            '--
            Dim U_URL1_POST As String = vbNewLine

            U_URL1_POST += "{""protocolVersion"":""0.8"",""createSessionRequest"":{""fields"":[{""external"":{""name"":""file"",""filename"":""" & TM.TypeAway(5) & "_" & IO.Path.GetFileName(File) & """,""formPost"":{}}},{""inlined"":{""name"":""return_address"",""content"":""upload.youtube.com"",""contentType"":""text/plain""}},{""inlined"":{""name"":""upload_key"",""content"":""" & UK & """,""contentType"":""text/plain""}},{""inlined"":{""name"":""action_postvideo"",""content"":""1"",""contentType"":""text/plain""}},{""inlined"":{""name"":""live_thumbnail_id"",""content"":""" & SI & ".0"",""contentType"":""text/plain""}},{""inlined"":{""name"":""parent_video_id"",""content"":"""",""contentType"":""text/plain""}},{""inlined"":{""name"":""allow_offweb"",""content"":""True"",""contentType"":""text/plain""}},{""inlined"":{""name"":""privacy"",""content"":""public"",""contentType"":""text/plain""}},{""inlined"":{""name"":""uploader_type"",""content"":""Web_HTML"",""contentType"":""text/plain""}}]}}"
            U_URL1_POST += vbNewLine
            '--
            Response = S.httpPost(upload_video_url2, U_URL1_POST)
            If Not Response.Contains("IN_PROGRESS") Then
                Return Response
            End If

            Dim content_type As String = F.GetBetweenR(Response, "content_type"":""", """}]", 0, True)
            Dim FileUploadURL As String = Replace(F.GetBetweenR(Response, """url"":""", """},", 0, True), "\u0026", "&")
            '--
            Response = S.httpGet(upload_video_url3)
            '--
            Dim BOUNDARY As String = DateTime.Now.Ticks.ToString("x")
            Dim FILEPOST As Byte() = System.IO.File.ReadAllBytes(File)
            Dim Header1 As Byte() = System.Text.Encoding.UTF8.GetBytes("--" & BOUNDARY & vbCrLf & "Content-Disposition: form-data; name=""Filedata""; filename=""" & File & """" & vbCrLf & "Content-Type: " & content_type & vbCrLf & vbCrLf)
            Dim Header2 As Byte() = System.Text.Encoding.UTF8.GetBytes(vbCrLf & "--" & BOUNDARY & "--")
            Dim MS As New MemoryStream
            MS.Write(Header1, 0, Header1.Length)
            MS.Write(FILEPOST, 0, FILEPOST.Length)
            MS.Write(Header2, 0, Header2.Length)

            AddHandler S.UploadProgress, AddressOf Me.SProgressChanged
            Response = S.httpPostUploadVideo(FileUploadURL, MS.ToArray, "multipart/form-data; boundary=" & BOUNDARY, QueIndex)
            MS.Close()
            Try
                If Response.Contains("SUCCESS") Then
                    Dim video_id As String = F.GetBetweenR(Response, "video_id"":""", """,", 0, True)
                    ID = video_id
                    '--
                    Response = S.httpGet(upload_video_url4)
                    '--
                    Dim VideoPage As String = S.httpGet("http://www.youtube.com/my_videos_edit?ns=1&video_id=" & video_id & "&next=%2Fmy_videos")
                    Dim private_video_token As String = F.GetBetweenR(VideoPage, "name=""private_video_token"" value=""", """/>", 0, True)
                    If private_video_token = "" Then
                        RaiseEvent UploadFailed(Me, "Upload failed. Error: " & "Couldn't parse PVT", Index)
                        Exit Function
                    End If
                    session_token = F.GetBetweenR(VideoPage, "'XSRF_TOKEN': '", "',", 0, True)
                    If session_token = "" Then
                        RaiseEvent UploadFailed(Me, "Upload failed. Error: " & "Couldn't parse ST", Index)
                        Exit Function
                    End If
                    'Response = S.httpPost(upload_video_set_info, String.Format("session_token={0}&action_edit_video=1&updated_flag=0&video_id={1}&title={2}&description={3}&keywords={4}&category={5}&privacy={6}", F.URLEncode(session_token), video_id, F.URLEncode(Title), F.URLEncode(Description), F.URLEncode(Keywords), Category, Privacy))
                    Response = S.httpPost("http://www.youtube.com/my_videos_edit", "ns=1&next=&video_id=" & video_id & "&action_videosave=1&ignore_broadcast_settings=0&field_myvideo_title=" & F.URLEncode(F.Spin(Title)) & "&field_myvideo_descr=" & F.URLEncode(F.Spin(Description)) & "&field_myvideo_keywords=" & F.URLEncode(FixIllegal(F.Spin(Keywords))) & "&field_myvideo_categories=" & Category & "&field_privacy=" & Privacy & "&private_video_token=" & private_video_token & "&private-url=http%3A%2F%2Fwww.youtube.com%2Fwatch_private%3Fv%3D" & video_id & "%26sharing_token%3D" & private_video_token & "&allow_comments=" & AllowComment & "&allow_comment_ratings=Yes&allow_responses=Kinda&allow_ratings=" & IIf(AllowRatings, "Yes", "No") & "&allow_embedding=Yes&allow_syndication=Yes&field_date_day=0&field_date_mon=0&field_date_yr=0&location=&altitude=&session_token=" & session_token)
                    '--
                    RaiseEvent UploadFinished(Me, ID, Index)
                    Return "Yes"
                Else
                    Dim error_description As String = F.GetBetweenR(Response, "err_description"":""", """,", 0, True)
                    RaiseEvent UploadFailed(Me, "Upload failed. Error: " & error_description, Index)
                    Return error_description
                End If
            Catch ex As Exception
                RaiseEvent UploadFailed(Me, "Upload failed. Error: " & ex.Message, Index)
                Return "No"
            End Try
            Return "No"
        Catch
            Return "No"
        End Try
    End Function
    Public Function UploadBytes(ByVal Title As String, ByVal Description As String, ByVal Keywords As String, ByVal Cat As String, ByVal Bytes() As Byte, ByVal Privacy As String, ByVal Index As Integer, ByVal AllowComment As String, ByVal AllowRatings As Boolean, Optional ByRef ID As String = "") As String
        '2   =>  'Autos & Vehicles'
        '23  =>  'Comedy'
        '27  =>  'Education'
        '24  =>  'Entertainment'
        '1   =>  'Film & Animation'
        '20  =>  'Gaming'
        '26  =>  'Howto & Style'
        '10  =>  'Music'
        '25  =>  'News & Politics'
        '29  =>  'Nonprofits & Activism'
        '22  =>  'People & Blogs'
        '15  =>  'Pets & Animals'
        '28  =>  'Science & Technology'
        '17  =>  'Sports'
        '19  =>  'Travel & Places'
        Privacy = Privacy.ToLower
        Dim Category As Integer
        If Cat = "Film & Animation" Then
            Category = 1
        ElseIf Cat = "Cars & Vehicles" Then
            Category = 2
        ElseIf Cat = "Music" Then
            Category = 10
        ElseIf Cat = "Pets & Animals" Then
            Category = 15
        ElseIf Cat = "Sport" Then
            Category = 17
        ElseIf Cat = "Travel & Events" Then
            Category = 19
        ElseIf Cat = "Gaming" Then
            Category = 20
        ElseIf Cat = "Comedy" Then
            Category = 23
        ElseIf Cat = "Entertainment" Then
            Category = 24
        ElseIf Cat = "Howto & Style" Then
            Category = 26
        ElseIf Cat = "News & Politics" Then
            Category = 25
        ElseIf Cat = "Education" Then
            Category = 27
        ElseIf Cat = "Science & Technology" Then
            Category = 28
        End If
        Try
            QueIndex = Index
            Dim TM As New TypingMonkey
Login:      Dim Response As String = S.httpGet(upload_url)
            If Response.Contains("location.replace(""") Then
                Response = S.httpGet(F.GetBetweenR(Response, "&#39;", "&#39", 0, True))
            End If
            Dim MSG As String = "Please enter the captcha"
            Dim Tries As Integer = 0
Start:      If Response.Contains("verificationImage") Then
                If UseDBC = "Use" Then
                    Dim challenge_enc As String
                    challenge_enc = F.GetBetween(Response, "challenge_enc"" value=""", """>")
                    Dim captcha_image As Byte()
                    captcha_image = ImageToByte("http://www.youtube.com/cimg?c=" & challenge_enc)
                    Dim nexts As String
                    nexts = F.GetBetween(Response, "next"" value=""", """>")
                    Dim action_verify As String
                    action_verify = F.GetBetween(Response, "action_verify"" value=""", """>")
                    Dim submit As String = "Submit"
                    submit = F.GetBetween(Response, "submit"" value=""", """>")
                    Dim response2 As String
                    response2 = F.GetBetween(Response, "'XSRF_TOKEN': '", "',")
                    Dim client As New HttpClient(DBCU, DBCP)
                    Dim captcha As Captcha = client.Decode(captcha_image, DBCTimeout)
                    Dim urlPOST As String = "http://www.youtube.com/das_captcha?next=" & nexts
                    Dim post As String = "challenge_enc=" & F.URLEncode(challenge_enc) & "&next=" & F.URLEncode(nexts) & "&response=" & captcha.Text & "&action_verify=" & action_verify & "&submit=" & submit & "&response=" & F.URLEncode(response2)
                    Response = S.httpPost(urlPOST, post)
                    If Response.Contains("Incorrect match for the verification code") Then
                        If client.Report(captcha) Then
                            Console.WriteLine("-------------------------------") : Console.WriteLine("Reported as incorrectly solved") : Console.WriteLine("-------------------------------")
                            GoTo Start
                        Else
                            Console.WriteLine("-------------------------------") : Console.WriteLine("Failed reporting as incorrectly solved") : Console.WriteLine("-------------------------------")
                            GoTo Start
                        End If
                    End If
                ElseIf UseDBC = "Manual" Then
                    Dim challenge_enc As String
                    challenge_enc = F.GetBetween(Response, "challenge_enc"" value=""", """>")
                    Dim captcha_image As Bitmap = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("http://www.youtube.com/cimg?c=" & challenge_enc)))
                    Dim nexts As String
                    nexts = F.GetBetween(Response, "next"" value=""", """>")
                    Dim action_verify As String
                    action_verify = F.GetBetween(Response, "action_verify"" value=""", """>")
                    Dim submit As String = "Submit"
                    submit = F.GetBetween(Response, "submit"" value=""", """>")
                    Dim response2 As String
                    response2 = F.GetBetween(Response, "'XSRF_TOKEN': '", "',")
                    Dim C As New frmCaptcha
                    C.PB.Image = captcha_image
                    C.Theme.Text = MSG
                    Dim RESOLVED As String = ""
                    If C.ShowDialog = DialogResult.OK Then
                        RESOLVED = C.txtCaptcha.Text
                    End If
                    Dim urlPOST As String = "http://www.youtube.com/das_captcha?next=" & nexts
                    Dim post As String = "challenge_enc=" & F.URLEncode(challenge_enc) & "&next=" & F.URLEncode(nexts) & "&response=" & RESOLVED & "&action_verify=" & action_verify & "&submit=" & submit & "&response=" & F.URLEncode(response2)
                    Response = S.httpPost(urlPOST, post)
                    If Response.Contains("Incorrect match for the verification code") Then
                        MSG = "Incorrect captcha, please enter again"
                        If Tries < 3 Then
                            Tries += 1
                            GoTo Login
                        End If
                    End If
                Else
                    Exit Function
                End If
            End If
            Dim SI As String = F.GetBetweenR(Response, "'sessionKey': '", "',", 0, True)
            Dim UK As String = F.GetBetweenR(Response, "'uploadKey': '", "',", 0, True)
            Dim session_token As String = F.GetBetweenR(Response, "session_token"" value=""", """/>", 0, True)
            '--
            Dim U_URL1 As String = Replace(upload_video_url1, "%UK%", UK)
            U_URL1 = Replace(U_URL1, "%SI%", SI)
            Dim U_URL3 As String = Replace(upload_video_url3, "%UK%", UK)
            U_URL3 = Replace(U_URL3, "%SI%", SI)
            Dim U_URL4 As String = Replace(upload_video_url4, "%UK%", UK)
            U_URL4 = Replace(U_URL4, "%SI%", SI)
            '--
            Response = S.httpGet(U_URL1)
            '--
            Dim U_URL1_POST As String = vbNewLine

            U_URL1_POST += "{""protocolVersion"":""0.8"",""createSessionRequest"":{""fields"":[{""external"":{""name"":""file"",""filename"":""" & TM.TypeAway(5) & "_.mp4" & """,""formPost"":{}}},{""inlined"":{""name"":""return_address"",""content"":""upload.youtube.com"",""contentType"":""text/plain""}},{""inlined"":{""name"":""upload_key"",""content"":""" & UK & """,""contentType"":""text/plain""}},{""inlined"":{""name"":""action_postvideo"",""content"":""1"",""contentType"":""text/plain""}},{""inlined"":{""name"":""live_thumbnail_id"",""content"":""" & SI & ".0"",""contentType"":""text/plain""}},{""inlined"":{""name"":""parent_video_id"",""content"":"""",""contentType"":""text/plain""}},{""inlined"":{""name"":""allow_offweb"",""content"":""True"",""contentType"":""text/plain""}},{""inlined"":{""name"":""privacy"",""content"":""public"",""contentType"":""text/plain""}},{""inlined"":{""name"":""uploader_type"",""content"":""Web_HTML"",""contentType"":""text/plain""}}]}}"
            U_URL1_POST += vbNewLine
            '--
            Response = S.httpPost(upload_video_url2, U_URL1_POST)
            If Not Response.Contains("IN_PROGRESS") Then
                RaiseEvent UploadFailed(Me, Response, Index)
                Return Response
            End If

            Dim content_type As String = F.GetBetweenR(Response, "content_type"":""", """}]", 0, True)
            Dim FileUploadURL As String = Replace(F.GetBetweenR(Response, """url"":""", """},", 0, True), "\u0026", "&")
            '--
            Response = S.httpGet(upload_video_url3)
            '--
            Dim BOUNDARY As String = DateTime.Now.Ticks.ToString("x")
            Dim FILEPOST As Byte() = Bytes
            Dim Header1 As Byte() = System.Text.Encoding.UTF8.GetBytes("--" & BOUNDARY & vbCrLf & "Content-Disposition: form-data; name=""Filedata""; filename=""" & TM.TypeAway(5) & "_.mp4" & """" & vbCrLf & "Content-Type: " & content_type & vbCrLf & vbCrLf)
            Dim Header2 As Byte() = System.Text.Encoding.UTF8.GetBytes(vbCrLf & "--" & BOUNDARY & "--")
            Dim MS As New MemoryStream
            MS.Write(Header1, 0, Header1.Length)
            MS.Write(FILEPOST, 0, FILEPOST.Length)
            MS.Write(Header2, 0, Header2.Length)

            AddHandler S.UploadProgress, AddressOf Me.SProgressChanged
            Response = S.httpPostUploadVideo(FileUploadURL, MS.ToArray, "multipart/form-data; boundary=" & BOUNDARY, QueIndex)
            MS.Close()
            Try
                If Response.Contains("SUCCESS") Then
                    Dim video_id As String = F.GetBetweenR(Response, "video_id"":""", """,", 0, True)
                    ID = video_id
                    '--
                    Response = S.httpGet(upload_video_url4)
                    '--
                    Dim VideoPage As String = S.httpGet("http://www.youtube.com/my_videos_edit?ns=1&video_id=" & video_id & "&next=%2Fmy_videos")
                    Dim private_video_token As String = F.GetBetweenR(VideoPage, "name=""private_video_token"" value=""", """/>", 0, True)
                    If private_video_token = "" Then
                        RaiseEvent UploadFailed(Me, "Upload failed. Error: " & "Couldn't parse PVT", Index)
                        Exit Function
                    End If
                    session_token = F.GetBetweenR(VideoPage, "'XSRF_TOKEN': '", "',", 0, True)
                    If session_token = "" Then
                        RaiseEvent UploadFailed(Me, "Upload failed. Error: " & "Couldn't parse ST", Index)
                        Exit Function
                    End If
                    'Response = S.httpPost(upload_video_set_info, String.Format("session_token={0}&action_edit_video=1&updated_flag=0&video_id={1}&title={2}&description={3}&keywords={4}&category={5}&privacy={6}", F.URLEncode(session_token), video_id, F.URLEncode(Title), F.URLEncode(Description), F.URLEncode(Keywords), Category, Privacy))
                    Response = S.httpPost("http://www.youtube.com/my_videos_edit", "ns=1&next=&video_id=" & video_id & "&action_videosave=1&ignore_broadcast_settings=0&field_myvideo_title=" & F.URLEncode(F.Spin(Title)) & "&field_myvideo_descr=" & F.URLEncode(F.Spin(Description)) & "&field_myvideo_keywords=" & F.URLEncode(FixIllegal(F.Spin(Keywords))) & "&field_myvideo_categories=" & Category & "&field_privacy=" & Privacy & "&private_video_token=" & private_video_token & "&private-url=http%3A%2F%2Fwww.youtube.com%2Fwatch_private%3Fv%3D" & video_id & "%26sharing_token%3D" & private_video_token & "&allow_comments=" & AllowComment & "&allow_comment_ratings=Yes&allow_responses=Kinda&allow_ratings=" & IIf(AllowRatings, "Yes", "No") & "&allow_embedding=Yes&allow_syndication=Yes&field_date_day=0&field_date_mon=0&field_date_yr=0&location=&altitude=&session_token=" & session_token)
                    '--
                    RaiseEvent UploadFinished(Me, ID, Index)
                    Return "Yes"
                Else
                    Dim error_description As String = F.GetBetweenR(Response, "err_description"":""", """,", 0, True)
                    RaiseEvent UploadFailed(Me, "Upload failed. Error: " & error_description, Index)
                    Return error_description
                End If
            Catch ex As Exception
                RaiseEvent UploadFailed(Me, "Upload failed. Error: " & ex.Message, Index)
                Return "No"
            End Try
            Return "No"
        Catch ex As Exception
            RaiseEvent UploadFailed(Me, "Upload failed. Error: " & ex.Message, Index)
            Return "No"
        End Try
    End Function
#End Region
#Region "Avatar Uploader"
    Public Function Avatar(ByVal File As String) As Boolean
        Try
            Dim PAGE As String = S.httpGet("http://www.youtube.com/account_dialog_profile_picture")
            Dim SESSION_TOKEN As String = F.GetBetweenR(PAGE, """session_token"" value=""", """/>", 0, True)
            Dim BOUNDARY As String = DateTime.Now.Ticks.ToString("x")
            Dim H1 As Byte() = System.Text.Encoding.UTF8.GetBytes("--" & BOUNDARY & vbCrLf & "Content-Disposition: form-data; name=""session_token""" & vbCrLf & vbCrLf & SESSION_TOKEN & vbCrLf & "--" & BOUNDARY & vbCrLf & "Content-Disposition: form-data; name=""profile_picture_option""" & vbCrLf & vbCrLf & "uploaded_image" & vbCrLf & "--" & BOUNDARY & vbCrLf & "Content-Disposition: form-data; name=""imagefile""; filename=""" & IO.Path.GetFileName(File) & """" & vbCrLf & "Content-Type: image/png" & vbCrLf & vbCrLf)
            Dim FILEPOST As Byte() = System.IO.File.ReadAllBytes(File)
            Dim F1 As Byte() = System.Text.Encoding.UTF8.GetBytes(vbCrLf & "--" & BOUNDARY & "--")
            Dim MS As New MemoryStream
            MS.Write(H1, 0, H1.Length)
            MS.Write(FILEPOST, 0, FILEPOST.Length)
            MS.Write(F1, 0, F1.Length)
            Dim RESPONSE As String = S.httpPostCustom("http://www.youtube.com/account_dialog_profile_picture?action_change_picture=1", MS.ToArray, "multipart/form-data; boundary=" & BOUNDARY)
            If RESPONSE.Contains("session_token") Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function
#End Region
#Region "Channel Settings"
    Public Function ChannelSettings(ByVal Invisible As Boolean, ByVal ChangeTheme As Boolean, Optional ByVal ThemeName As String = Nothing) As Boolean
        Try
            Dim Hidden As String
            If Invisible Then
                Hidden = "yes"
            Else
                Hidden = "no"
            End If
            Dim PAGE As String = S.httpGet("http://www.youtube.com/user/" & Username & "?feature=mhum")
            Dim session_token As String = F.GetBetweenR(PAGE, "window.ajax_session_info = 'session_token=", "';", 0, True)
            If ChangeTheme Then
                Me.ChangeTheme(session_token, ThemeName)
            End If
            ChangeInfo(session_token)
            Dim POST As String = F.URLEncode("[{""type"":""save_channel_settings"",""request"":{""title"":"""",""channel_type"":""g"",""channel_hidden"":""" & Hidden & """,""keywords"":"""",""find_me_via_email"":[""agreed""],"""":""""}}]")
            Dim RESPONSE As String = S.httpPost("http://www.youtube.com/profile_ajax?action_ajax=1&user=" & Username & "&new=1", String.Format("session_token={0}&messages={1}", session_token, POST))
            If RESPONSE.Contains("{""success"": true}") Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function
    Private Sub ChangeTheme(ByVal session_token As String, ByVal ThemeName As String)
        Try
            Dim ThemeMSG As String = Nothing
            Select Case ThemeName
                Case "Stealth"
                    ThemeMSG = "%5B%7B%22type%22%3A%22save_theme%22%2C%22request%22%3A%7B%22themes%22%3A%7B%22blue%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Blue%22%2C%22background_color%22%3A%22%23003366%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%230066CC%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FFFFFF%22%2C%22link_color%22%3A%22%2399C2EB%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%233D8BD8%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%230000CC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22scary%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Red%22%2C%22background_color%22%3A%22%23660000%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23990000%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FFFFFF%22%2C%22link_color%22%3A%22%23FF0000%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%23660000%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FF0000%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22clean%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Clean%22%2C%22background_color%22%3A%22%23FFFFFF%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23D6D6D6%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23606060%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23606060%22%2C%22link_color%22%3A%22%230030C0%22%2C%22body_text_color%22%3A%22%23000000%22%2C%22box_background_color%22%3A%22%23FFFFFF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%230030C0%22%2C%22font%22%3A%22Arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22fire%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Fire%22%2C%22background_color%22%3A%22%23660000%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23FF0000%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FFFF00%22%2C%22link_color%22%3A%22%23FFDBA6%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%23FF9900%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFFF00%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22forest%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Forest%22%2C%22background_color%22%3A%22%23274E13%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%2338761D%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23274E13%22%2C%22link_color%22%3A%22%2338761D%22%2C%22body_text_color%22%3A%22%23274E13%22%2C%22box_background_color%22%3A%22%236AA84F%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFFFFF%22%2C%22font%22%3A%22Arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22sunlight%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Sunlight%22%2C%22background_color%22%3A%22%23FFE599%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23E69138%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23E69138%22%2C%22link_color%22%3A%22%23E69138%22%2C%22body_text_color%22%3A%22%23E69138%22%2C%22box_background_color%22%3A%22%23FFD966%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFD966%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22default%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Grey%22%2C%22background_color%22%3A%22%23CCCCCC%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23999999%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23000000%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23000000%22%2C%22link_color%22%3A%22%230000CC%22%2C%22body_text_color%22%3A%22%23333333%22%2C%22box_background_color%22%3A%22%23EEEEFF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%230000CC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22stealth%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Stealth%22%2C%22background_color%22%3A%22%23000000%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23444444%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23000000%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23000000%22%2C%22link_color%22%3A%22%23444444%22%2C%22body_text_color%22%3A%22%23444444%22%2C%22box_background_color%22%3A%22%23666666%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23CCCCCC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%228bit%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%228-bit%22%2C%22background_color%22%3A%22%23666666%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23444444%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23AAAAAA%22%2C%22link_color%22%3A%22%23FF0000%22%2C%22body_text_color%22%3A%22%23666666%22%2C%22box_background_color%22%3A%22%23000000%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FF0000%22%2C%22font%22%3A%22Courier%20New%22%2C%22wrapper_opacity%22%3A255%7D%2C%22bugbelly%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Bugbelly%22%2C%22background_color%22%3A%22%23339900%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%2300FF00%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%2300FF00%22%2C%22link_color%22%3A%22%2300FF00%22%2C%22body_text_color%22%3A%22%2338761D%22%2C%22box_background_color%22%3A%22%23CCFF00%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFD966%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22default2%22%3A%7B%22background_image%22%3A%22http%3A%2F%2Fi2.ytimg.com%2Fbg%2F1VTESMQQfJi_ah4zhhPlDA%2F101.jpg%3Fapp%3Dbg%26v%3D4d9338a2%22%2C%22display_name%22%3A%22WPID%22%2C%22background_color%22%3A%22%230a0a0c%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%230a0a0e%22%2C%22builtin%22%3Afalse%2C%22wrapper_text_color%22%3A%22%23660000%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23660000%22%2C%22link_color%22%3A%22%23990000%22%2C%22body_text_color%22%3A%22%23666666%22%2C%22box_background_color%22%3A%22%23000000%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A%220%22%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%239900CC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A%220%22%7D%2C%22princess%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Princess%22%2C%22background_color%22%3A%22%23FF99CC%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23AA66CC%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%238A2C87%22%2C%22link_color%22%3A%22%23351C75%22%2C%22body_text_color%22%3A%22%23333366%22%2C%22box_background_color%22%3A%22%23FFFFFF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23351C75%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22berry%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Berry%22%2C%22background_color%22%3A%22%234C1130%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23660099%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%239900FF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FF00FF%22%2C%22link_color%22%3A%22%23FFCCCC%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%239900FF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%7D%7D%2C%22wrapper_link_color%22%3A%22%23B4A7D6%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%7D%2C%22theme_name%22%3A%22default2%22%2C%22background_image_counter%22%3A2%7D%7D%5D"
                Case "Clean"
                    ThemeMSG = "%5B%7B%22type%22%3A%22save_theme%22%2C%22request%22%3A%7B%22themes%22%3A%7B%22blue%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Blue%22%2C%22background_color%22%3A%22%23003366%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%230066CC%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FFFFFF%22%2C%22link_color%22%3A%22%2399C2EB%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%233D8BD8%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%230000CC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22scary%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Red%22%2C%22background_color%22%3A%22%23660000%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23990000%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FFFFFF%22%2C%22link_color%22%3A%22%23FF0000%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%23660000%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FF0000%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22clean%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Clean%22%2C%22background_color%22%3A%22%23FFFFFF%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23D6D6D6%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23606060%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23606060%22%2C%22link_color%22%3A%22%230030C0%22%2C%22body_text_color%22%3A%22%23000000%22%2C%22box_background_color%22%3A%22%23FFFFFF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%230030C0%22%2C%22font%22%3A%22Arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22fire%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Fire%22%2C%22background_color%22%3A%22%23660000%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23FF0000%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FFFF00%22%2C%22link_color%22%3A%22%23FFDBA6%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%23FF9900%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFFF00%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22forest%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Forest%22%2C%22background_color%22%3A%22%23274E13%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%2338761D%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23274E13%22%2C%22link_color%22%3A%22%2338761D%22%2C%22body_text_color%22%3A%22%23274E13%22%2C%22box_background_color%22%3A%22%236AA84F%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFFFFF%22%2C%22font%22%3A%22Arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22sunlight%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Sunlight%22%2C%22background_color%22%3A%22%23FFE599%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23E69138%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23E69138%22%2C%22link_color%22%3A%22%23E69138%22%2C%22body_text_color%22%3A%22%23E69138%22%2C%22box_background_color%22%3A%22%23FFD966%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFD966%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22default%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Grey%22%2C%22background_color%22%3A%22%23CCCCCC%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23999999%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23000000%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23000000%22%2C%22link_color%22%3A%22%230000CC%22%2C%22body_text_color%22%3A%22%23333333%22%2C%22box_background_color%22%3A%22%23EEEEFF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%230000CC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22stealth%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Stealth%22%2C%22background_color%22%3A%22%23000000%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23444444%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23000000%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23000000%22%2C%22link_color%22%3A%22%23444444%22%2C%22body_text_color%22%3A%22%23444444%22%2C%22box_background_color%22%3A%22%23666666%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23CCCCCC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%228bit%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%228-bit%22%2C%22background_color%22%3A%22%23666666%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23444444%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23AAAAAA%22%2C%22link_color%22%3A%22%23FF0000%22%2C%22body_text_color%22%3A%22%23666666%22%2C%22box_background_color%22%3A%22%23000000%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FF0000%22%2C%22font%22%3A%22Courier%20New%22%2C%22wrapper_opacity%22%3A255%7D%2C%22bugbelly%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Bugbelly%22%2C%22background_color%22%3A%22%23339900%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%2300FF00%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%2300FF00%22%2C%22link_color%22%3A%22%2300FF00%22%2C%22body_text_color%22%3A%22%2338761D%22%2C%22box_background_color%22%3A%22%23CCFF00%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFD966%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22default2%22%3A%7B%22background_image%22%3A%22http%3A%2F%2Fi2.ytimg.com%2Fbg%2F1VTESMQQfJi_ah4zhhPlDA%2F101.jpg%3Fapp%3Dbg%26v%3D4d9338a2%22%2C%22display_name%22%3A%22WPID%22%2C%22background_color%22%3A%22%230a0a0c%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%230a0a0e%22%2C%22builtin%22%3Afalse%2C%22wrapper_text_color%22%3A%22%23660000%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23660000%22%2C%22link_color%22%3A%22%23990000%22%2C%22body_text_color%22%3A%22%23666666%22%2C%22box_background_color%22%3A%22%23000000%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A%220%22%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%239900CC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A%220%22%7D%2C%22princess%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Princess%22%2C%22background_color%22%3A%22%23FF99CC%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23AA66CC%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%238A2C87%22%2C%22link_color%22%3A%22%23351C75%22%2C%22body_text_color%22%3A%22%23333366%22%2C%22box_background_color%22%3A%22%23FFFFFF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23351C75%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22berry%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Berry%22%2C%22background_color%22%3A%22%234C1130%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23660099%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%239900FF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FF00FF%22%2C%22link_color%22%3A%22%23FFCCCC%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%239900FF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%7D%7D%2C%22wrapper_link_color%22%3A%22%23B4A7D6%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%7D%2C%22theme_name%22%3A%22clean%22%2C%22background_image_counter%22%3A2%7D%7D%5D"
                Case "Sunlight"
                    ThemeMSG = "%5B%7B%22type%22%3A%22save_theme%22%2C%22request%22%3A%7B%22themes%22%3A%7B%22blue%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Blue%22%2C%22background_color%22%3A%22%23003366%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%230066CC%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FFFFFF%22%2C%22link_color%22%3A%22%2399C2EB%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%233D8BD8%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%230000CC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22scary%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Red%22%2C%22background_color%22%3A%22%23660000%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23990000%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FFFFFF%22%2C%22link_color%22%3A%22%23FF0000%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%23660000%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FF0000%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22clean%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Clean%22%2C%22background_color%22%3A%22%23FFFFFF%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23D6D6D6%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23606060%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23606060%22%2C%22link_color%22%3A%22%230030C0%22%2C%22body_text_color%22%3A%22%23000000%22%2C%22box_background_color%22%3A%22%23FFFFFF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%230030C0%22%2C%22font%22%3A%22Arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22fire%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Fire%22%2C%22background_color%22%3A%22%23660000%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23FF0000%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FFFF00%22%2C%22link_color%22%3A%22%23FFDBA6%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%23FF9900%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFFF00%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22forest%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Forest%22%2C%22background_color%22%3A%22%23274E13%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%2338761D%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23274E13%22%2C%22link_color%22%3A%22%2338761D%22%2C%22body_text_color%22%3A%22%23274E13%22%2C%22box_background_color%22%3A%22%236AA84F%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFFFFF%22%2C%22font%22%3A%22Arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22sunlight%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Sunlight%22%2C%22background_color%22%3A%22%23FFE599%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23E69138%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23E69138%22%2C%22link_color%22%3A%22%23E69138%22%2C%22body_text_color%22%3A%22%23E69138%22%2C%22box_background_color%22%3A%22%23FFD966%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFD966%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22default%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Grey%22%2C%22background_color%22%3A%22%23CCCCCC%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23999999%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23000000%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23000000%22%2C%22link_color%22%3A%22%230000CC%22%2C%22body_text_color%22%3A%22%23333333%22%2C%22box_background_color%22%3A%22%23EEEEFF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%230000CC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22stealth%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Stealth%22%2C%22background_color%22%3A%22%23000000%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23444444%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23000000%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23000000%22%2C%22link_color%22%3A%22%23444444%22%2C%22body_text_color%22%3A%22%23444444%22%2C%22box_background_color%22%3A%22%23666666%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23CCCCCC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%228bit%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%228-bit%22%2C%22background_color%22%3A%22%23666666%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23444444%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23AAAAAA%22%2C%22link_color%22%3A%22%23FF0000%22%2C%22body_text_color%22%3A%22%23666666%22%2C%22box_background_color%22%3A%22%23000000%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FF0000%22%2C%22font%22%3A%22Courier%20New%22%2C%22wrapper_opacity%22%3A255%7D%2C%22bugbelly%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Bugbelly%22%2C%22background_color%22%3A%22%23339900%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%2300FF00%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%2300FF00%22%2C%22link_color%22%3A%22%2300FF00%22%2C%22body_text_color%22%3A%22%2338761D%22%2C%22box_background_color%22%3A%22%23CCFF00%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFD966%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22default2%22%3A%7B%22background_image%22%3A%22http%3A%2F%2Fi2.ytimg.com%2Fbg%2F1VTESMQQfJi_ah4zhhPlDA%2F101.jpg%3Fapp%3Dbg%26v%3D4d9338a2%22%2C%22display_name%22%3A%22WPID%22%2C%22background_color%22%3A%22%230a0a0c%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%230a0a0e%22%2C%22builtin%22%3Afalse%2C%22wrapper_text_color%22%3A%22%23660000%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23660000%22%2C%22link_color%22%3A%22%23990000%22%2C%22body_text_color%22%3A%22%23666666%22%2C%22box_background_color%22%3A%22%23000000%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A%220%22%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%239900CC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A%220%22%7D%2C%22princess%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Princess%22%2C%22background_color%22%3A%22%23FF99CC%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23AA66CC%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%238A2C87%22%2C%22link_color%22%3A%22%23351C75%22%2C%22body_text_color%22%3A%22%23333366%22%2C%22box_background_color%22%3A%22%23FFFFFF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23351C75%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22berry%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Berry%22%2C%22background_color%22%3A%22%234C1130%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23660099%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%239900FF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FF00FF%22%2C%22link_color%22%3A%22%23FFCCCC%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%239900FF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%7D%7D%2C%22wrapper_link_color%22%3A%22%23B4A7D6%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%7D%2C%22theme_name%22%3A%22sunlight%22%2C%22background_image_counter%22%3A2%7D%7D%5D"
                Case "Blue"
                    ThemeMSG = "%5B%7B%22type%22%3A%22save_theme%22%2C%22request%22%3A%7B%22themes%22%3A%7B%22blue%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Blue%22%2C%22background_color%22%3A%22%23003366%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%230066CC%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FFFFFF%22%2C%22link_color%22%3A%22%2399C2EB%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%233D8BD8%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%230000CC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22scary%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Red%22%2C%22background_color%22%3A%22%23660000%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23990000%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FFFFFF%22%2C%22link_color%22%3A%22%23FF0000%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%23660000%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FF0000%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22clean%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Clean%22%2C%22background_color%22%3A%22%23FFFFFF%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23D6D6D6%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23606060%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23606060%22%2C%22link_color%22%3A%22%230030C0%22%2C%22body_text_color%22%3A%22%23000000%22%2C%22box_background_color%22%3A%22%23FFFFFF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%230030C0%22%2C%22font%22%3A%22Arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22fire%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Fire%22%2C%22background_color%22%3A%22%23660000%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23FF0000%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FFFF00%22%2C%22link_color%22%3A%22%23FFDBA6%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%23FF9900%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFFF00%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22forest%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Forest%22%2C%22background_color%22%3A%22%23274E13%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%2338761D%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23274E13%22%2C%22link_color%22%3A%22%2338761D%22%2C%22body_text_color%22%3A%22%23274E13%22%2C%22box_background_color%22%3A%22%236AA84F%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFFFFF%22%2C%22font%22%3A%22Arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22sunlight%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Sunlight%22%2C%22background_color%22%3A%22%23FFE599%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23E69138%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23E69138%22%2C%22link_color%22%3A%22%23E69138%22%2C%22body_text_color%22%3A%22%23E69138%22%2C%22box_background_color%22%3A%22%23FFD966%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFD966%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22default%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Grey%22%2C%22background_color%22%3A%22%23CCCCCC%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23999999%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23000000%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23000000%22%2C%22link_color%22%3A%22%230000CC%22%2C%22body_text_color%22%3A%22%23333333%22%2C%22box_background_color%22%3A%22%23EEEEFF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%230000CC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22stealth%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Stealth%22%2C%22background_color%22%3A%22%23000000%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23444444%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23000000%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23000000%22%2C%22link_color%22%3A%22%23444444%22%2C%22body_text_color%22%3A%22%23444444%22%2C%22box_background_color%22%3A%22%23666666%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23CCCCCC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%228bit%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%228-bit%22%2C%22background_color%22%3A%22%23666666%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23444444%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23AAAAAA%22%2C%22link_color%22%3A%22%23FF0000%22%2C%22body_text_color%22%3A%22%23666666%22%2C%22box_background_color%22%3A%22%23000000%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23FF0000%22%2C%22font%22%3A%22Courier%20New%22%2C%22wrapper_opacity%22%3A255%7D%2C%22bugbelly%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Bugbelly%22%2C%22background_color%22%3A%22%23339900%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%2300FF00%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%2300FF00%22%2C%22link_color%22%3A%22%2300FF00%22%2C%22body_text_color%22%3A%22%2338761D%22%2C%22box_background_color%22%3A%22%23CCFF00%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%7D%7D%2C%22wrapper_link_color%22%3A%22%23FFD966%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22default2%22%3A%7B%22background_image%22%3A%22http%3A%2F%2Fi2.ytimg.com%2Fbg%2F1VTESMQQfJi_ah4zhhPlDA%2F101.jpg%3Fapp%3Dbg%26v%3D4d9338a2%22%2C%22display_name%22%3A%22WPID%22%2C%22background_color%22%3A%22%230a0a0c%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%230a0a0e%22%2C%22builtin%22%3Afalse%2C%22wrapper_text_color%22%3A%22%23660000%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23660000%22%2C%22link_color%22%3A%22%23990000%22%2C%22body_text_color%22%3A%22%23666666%22%2C%22box_background_color%22%3A%22%23000000%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A%220%22%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%239900CC%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A%220%22%7D%2C%22princess%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Princess%22%2C%22background_color%22%3A%22%23FF99CC%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23AA66CC%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%23FFFFFF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%238A2C87%22%2C%22link_color%22%3A%22%23351C75%22%2C%22body_text_color%22%3A%22%23333366%22%2C%22box_background_color%22%3A%22%23FFFFFF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%2C%22name%22%3A%22default%22%7D%7D%2C%22wrapper_link_color%22%3A%22%23351C75%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%2C%22berry%22%3A%7B%22background_image%22%3A%22%22%2C%22display_name%22%3A%22Berry%22%2C%22background_color%22%3A%22%234C1130%22%2C%22background_repeat%22%3A%22no-repeat%22%2C%22wrapper_color%22%3A%22%23660099%22%2C%22builtin%22%3Atrue%2C%22wrapper_text_color%22%3A%22%239900FF%22%2C%22palettes%22%3A%7B%22default%22%3A%7B%22title_text_color%22%3A%22%23FF00FF%22%2C%22link_color%22%3A%22%23FFCCCC%22%2C%22body_text_color%22%3A%22%23FFFFFF%22%2C%22box_background_color%22%3A%22%239900FF%22%2C%22display_name%22%3A%22Default%22%2C%22box_opacity%22%3A255%7D%7D%2C%22wrapper_link_color%22%3A%22%23B4A7D6%22%2C%22font%22%3A%22arial%22%2C%22wrapper_opacity%22%3A255%7D%7D%2C%22theme_name%22%3A%22blue%22%2C%22background_image_counter%22%3A2%7D%7D%5D"
            End Select
            S.httpPost("http://www.youtube.com/profile_ajax?action_ajax=1&user=" & Username & "&new=1", String.Format("session_token={0}&messages={1}", session_token, ThemeMSG))
        Catch
        End Try
    End Sub
    Private Sub ChangeInfo(ByVal session_token As String, Optional ByVal website As String = Nothing)
        Try
            Dim messages As String = "[{""type"":""box_method"",""request"":{""name"":""user_profile"",""x_position"":0,""y_position"":0,""palette"":""default"",""method"":""save"",""params"":{"""":"""",""displayed_fields"":[""first_name"",""total_video_views"",""genre"",""age"",""last_login"",""subscriber_count"",""url"",""description"",""profile"",""hometown"",""country"",""occupation"",""companies"",""schools"",""hobbies"",""movies"",""music"",""books""],""first_name"":"""",""genre"":"""",""url"":""" & website & """,""description"":"""",""profile"":"""",""hometown"":"""",""country"":""NO"",""occupation"":"""",""companies"":"""",""schools"":"""",""hobbies"":"""",""movies"":"""",""music"":"""",""books"":""""}}}]"
            Dim POST As String = String.Format("session_token={0}&messages={1}", session_token, messages)
            S.httpPost("http://www.youtube.com/profile_ajax?action_ajax=1&user=" & Me.Username & "&new=1&box_method=save&box_name=user_profile", POST)
        Catch
        End Try
    End Sub
#End Region
#Region "Captcha ImageToByte"
    Public Shared Function ImageToByte(ByVal url As String) As Byte()
        Try
            Dim request As Net.HttpWebRequest = DirectCast(Net.HttpWebRequest.Create(url), Net.HttpWebRequest)
            Dim response As Net.HttpWebResponse = DirectCast(request.GetResponse, Net.HttpWebResponse)
            Dim img As Image = Image.FromStream(response.GetResponseStream())
            response.Close()
            Dim imgStream As MemoryStream = New MemoryStream()
            img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
            imgStream.Close()
            Dim byteArray As Byte() = imgStream.ToArray()
            imgStream.Dispose()
            Return byteArray
        Catch
            Return Nothing
        End Try
    End Function
#End Region
#Region "Channel Comments"
    Public Function CommentChannel(ByVal Channel As String, ByVal Body As String) As Boolean
        Dim MSG As String = "Please enter the captcha"
        Dim Tries As Integer = 0
        Dim PAGE As String = S.httpGet("http://www.youtube.com/user/" & Channel)
        Dim ST As String = F.GetBetween(PAGE, "window.ajax_session_info", "username")
        ST = F.GetBetweenR(ST, "session_token=", "';", 0, True)
        Dim RESPONSE As String = S.httpPost("http://www.youtube.com/profile_ajax?action_ajax=1&user=" & Channel & "&new=1&box_method=add_comment&box_name=user_comments", "session_token=" & ST & "&messages=%5B%7B%22type%22%3A%22box_method%22%2C%22request%22%3A%7B%22name%22%3A%22user_comments%22%2C%22x_position%22%3A1%2C%22y_position%22%3A48%2C%22palette%22%3A%22default%22%2C%22method%22%3A%22add_comment%22%2C%22params%22%3A%7B%22comment%22%3A%22" & F.URLEncode(Body) & "%22%2C%22view_all_mode%22%3A%22False%22%7D%7D%7D%5D")
Check:  If RESPONSE.Contains("captcha_html") Then
            If UseDBC = "Use" Then
                Dim challenge_enc As String
                challenge_enc = F.GetBetween(RESPONSE, "value=\""", "\""")
                Dim captcha_image As Byte()
                captcha_image = ImageToByte("http://www.youtube.com/cimg?c=" & challenge_enc)
                Dim client As New HttpClient(DBCU, DBCP)
                Dim captcha As Captcha = client.Decode(captcha_image, DBCTimeout)
                RESPONSE = S.httpPost("http://www.youtube.com/profile_ajax?action_ajax=1&user=" & Channel & "&new=1&box_method=add_comment&box_name=user_comments", "session_token=" & ST & "&messages=%5B%7B%22type%22%3A%22box_method%22%2C%22request%22%3A%7B%22name%22%3A%22user_comments%22%2C%22x_position%22%3A1%2C%22y_position%22%3A48%2C%22palette%22%3A%22default%22%2C%22method%22%3A%22add_comment%22%2C%22params%22%3A%7B%22comment%22%3A%22" & F.URLEncode(Body) & "%22%2C%22view_all_mode%22%3A%22False%22%2C%22challenge%22%3A%22" & challenge_enc & "%22%2C%22response%22%3A%22" & captcha.Text & "%22%7D%7D%7D%5D")
                If RESPONSE.Contains("captcha_html") Then
                    client.Report(captcha)
                    GoTo Check
                Else
                    GoTo Check
                End If
            ElseIf UseDBC = "Manual" Then
                Dim challenge_enc As String
                challenge_enc = F.GetBetween(RESPONSE, "value=\""", "\""")
                Dim captcha_image As Bitmap = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("http://www.youtube.com/cimg?c=" & challenge_enc)))
                Dim C As New frmCaptcha
                C.PB.Image = captcha_image
                C.Theme.Text = MSG
                Dim RESOLVED As String = ""
                If C.ShowDialog = DialogResult.OK Then
                    RESOLVED = C.txtCaptcha.Text
                End If
                RESPONSE = S.httpPost("http://www.youtube.com/profile_ajax?action_ajax=1&user=" & Channel & "&new=1&box_method=add_comment&box_name=user_comments", "session_token=" & ST & "&messages=%5B%7B%22type%22%3A%22box_method%22%2C%22request%22%3A%7B%22name%22%3A%22user_comments%22%2C%22x_position%22%3A1%2C%22y_position%22%3A48%2C%22palette%22%3A%22default%22%2C%22method%22%3A%22add_comment%22%2C%22params%22%3A%7B%22comment%22%3A%22" & F.URLEncode(Body) & "%22%2C%22view_all_mode%22%3A%22False%22%2C%22challenge%22%3A%22" & challenge_enc & "%22%2C%22response%22%3A%22" & RESOLVED & "%22%7D%7D%7D%5D")
                If RESPONSE.Contains("captcha_html") Then
                    MSG = "Incorrect captcha, please enter again"
                    If Tries < 3 Then
                        Tries += 1
                        GoTo Check
                    Else
                        Return False
                    End If
                Else
                    GoTo Check
                End If
            Else
                Return False
            End If
        ElseIf RESPONSE.Contains("""success"": true") Then
            Return True
        End If
        Return False
    End Function
#End Region
#Region "Change Password"
    Public Function [ChangePassword](ByVal NewPass As String) As Boolean
        Dim Page As String = S.httpGet("https://www.google.com/accounts/EditPasswd?hl=en_US")
        Dim hl As String = "en_US"
        Dim timeStmp As String = F.GetBetweenR(Page, "timeStmp", ">", 1, True)
        timeStmp = F.GetBetweenR(timeStmp, "value='", "'", 0, True)
        Dim secTok As String = F.GetBetweenR(Page, "secTok", ">", 1, True)
        secTok = F.URLEncode(F.GetBetweenR(secTok, "value='", "'", 0, True))
        Dim OldPasswd As String = Me.Password
        'Dim oldpasswd As String = "sometyti"
        Dim Passwd As String = NewPass
        Dim PasswdAgain As String = NewPass
        Dim p As String = vbNullString
        Dim save As String = "Save"
        Dim Response As String
        Response = S.httpPost("https://www.google.com/accounts/UpdatePasswd", String.Format("hl={0}&timeStmp={1}&secTok={2}&OldPasswd={3}&Passwd={4}&PasswdAgain={5}&p={6}&save={7}", hl, timeStmp, secTok, OldPasswd, Passwd, PasswdAgain, p, save))
        If Response.Contains("Account overview") Or Response.Contains("Your new password has been saved") Then
            Debug.WriteLine(Response)

            Return True
        End If
        Return False
    End Function
#End Region
#End Region
End Class
Public Class YouTubeAPI
#Region "Declerations"
    'Private developerKey As String = "AI39si4SpQkcgTV6VikC9W1CJVjtbrTd7xtSNlbmyOjyeDztRHgn_MOSORD4efH9S43Yw9FMfZfW8U3BXCiRU62ovMXf0p_ogw"
    Private INI As New INI(Configuration.INI_Configuration.DefaultConfig, My.Application.Info.DirectoryPath & "\config.ini")
    Private developerKey As String = "AI39si5AfSwQZ2riEE_sLpqE4FGnrD8AVKHX9-qmEuzoYLE4L1Q_UujMDl1xRwNLIE_GQVzL0t8bzcAlsrn5XxVxOQPPiSv7ag"
    Private Username As String
    Private Password As String
    Private appName As String = "Tubenoia"
    Private DBCTimeout As Integer
    Private DBCU As String
    Private DBCP As String
    Private UseDBC As String
    Dim F As New Functions.General
    Dim Token As String = Nothing
    Dim settings As YouTubeRequestSettings
    Dim request As YouTubeRequest
#End Region
#Region "Functions"
#Region "Captcha ImageToByte"
    Public Shared Function ImageToByte(ByVal url As String) As Byte()
        Try
            Dim request As Net.HttpWebRequest = DirectCast(Net.HttpWebRequest.Create(url), Net.HttpWebRequest)
            Dim response As Net.HttpWebResponse = DirectCast(request.GetResponse, Net.HttpWebResponse)
            Dim img As Image = Image.FromStream(response.GetResponseStream())
            response.Close()
            Dim imgStream As MemoryStream = New MemoryStream()
            img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
            imgStream.Close()
            Dim byteArray As Byte() = imgStream.ToArray()
            imgStream.Dispose()
            Return byteArray
        Catch
            Return Nothing
        End Try
    End Function
#End Region
    Sub New(ByVal Username As String, ByVal Password As String)
        Me.Username = Username
        Me.Password = Password
        If INI("Captcha")("UseDBC").Value = "Use" Then
            UseDBC = "Use"
            DBCU = INI("Captcha")("DBCU").Value
            DBCP = INI("Captcha")("DBCP").Value
            DBCTimeout = CInt(INI("Captcha")("DBCTimeout").Value)
        ElseIf INI("Captcha")("UseDBC").Value = "Manual" Then
            UseDBC = "Manual"
        Else
            UseDBC = "Dismiss"
        End If
        settings = New YouTubeRequestSettings(appName, developerKey, Username, Password)
        request = New YouTubeRequest(settings)
    End Sub
    'BadAuthentication	The login request used a username or password that is not recognized.
    'NotVerified	The account email address has not been verified. The user will need to access their Google account directly to resolve the issue before logging in using a non-Google application.
    'TermsNotAgreed	The user has not agreed to terms. The user will need to access their Google account directly to resolve the issue before logging in using a non-Google application.
    'CaptchaRequired	A CAPTCHA is required. (A response with this error code will also contain an image URL and a CAPTCHA token.)
    'Unknown	The error is unknown or unspecified; the request contained invalid input or was malformed.
    'AccountDeleted	The user account has been deleted.
    'AccountDisabled	The user account has been disabled.
    'ServiceDisabled	The user's access to the specified service has been disabled. (The user account may still be valid.)
    'ServiceUnavailable	The service is not available; try again later.
    Public Function Login() As Boolean
        Try
            If Token = Nothing Then
                Try
                    Token = request.Service.QueryClientLoginToken()
                Catch
                    Return False
                End Try
                Return True
            End If
        Catch e As CaptchaRequiredException
            If UseDBC = "Use" Then
                Dim image() As Byte = ImageToByte(e.Url)
                Dim client As New HttpClient(DBCU, DBCP)
                Dim cap As Captcha = client.Decode(image, DBCTimeout)
                Dim requestFactory As GDataGAuthRequestFactory = DirectCast(request.Service.RequestFactory, GDataGAuthRequestFactory)
                requestFactory.CaptchaAnswer = cap.Text
                requestFactory.CaptchaToken = e.Token
                Try
                    Token = request.Service.QueryClientLoginToken()
                Catch ee As CaptchaRequiredException
                    client.Report(cap)
                    Return False
                End Try
                Return True
            ElseIf UseDBC = "Manual" Then
                Dim captcha_image As Bitmap = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(e.Url)))
                Dim C As New frmCaptcha
                C.PB.Image = captcha_image
                Dim RESOLVED As String = ""
                If C.ShowDialog = DialogResult.OK Then
                    RESOLVED = C.txtCaptcha.Text
                End If
                Dim requestFactory As GDataGAuthRequestFactory = DirectCast(request.Service.RequestFactory, GDataGAuthRequestFactory)
                requestFactory.CaptchaAnswer = RESOLVED
                requestFactory.CaptchaToken = e.Token
                Try
                    Token = request.Service.QueryClientLoginToken()
                Catch ee As CaptchaRequiredException
                    Return False
                End Try
            ElseIf UseDBC = "Dismiss" Then
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function SendMessage(ByVal user As String, ByVal video As String, ByVal subject As String, ByVal message As String)
        Try
            Dim friendsInbox As String = "http://gdata.youtube.com/feeds/api/users/" & user & "/inbox"
            Dim videoEntryUrl As String = "http://gdata.youtube.com/feeds/api/videos/" & video
            Dim videoEntry As YouTubeEntry = DirectCast(request.Service.Get(videoEntryUrl), YouTubeEntry)
            Dim newMessage As New MessageEntry
            newMessage.Title.Text = subject
            newMessage.Summary.Text = message
            newMessage.Id = videoEntry.Id
            request.Service.Insert(New Uri(friendsInbox), newMessage)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
End Class
Public Class YouTubeDownloader
#Region "Events"
    Public Event FileDownloadPercentageChanged(ByVal Percentage As Integer, ByVal index As Integer)
    Public Event FileDownloadComplete(ByVal index As Integer)
    Public Event FileDownloadFailed(ByVal index As Integer, ByVal ex As Exception)
#End Region
#Region "Declerations"
    Private S As New WebWrapper
    Private F As New Functions.General
    Private HTML As String
    Private ID As String
    Private index As Integer
#End Region
#Region "Functions"
#Region "New"
    Sub New(ByVal Video As String, ByVal Index As Integer)
        ID = Mid(Split(Video, "watch?v=")(1), 1, 11)
        HTML = S.httpGet("http://www.youtube.com/watch?v=" & ID)
        Me.index = Index
    End Sub
#End Region
#Region "Download"
    Public Function DownloadFile(ByVal URL As String, ByVal Location As String) As Boolean
        Try
            Dim WC As New Net.WebClient
            WC.DownloadFile(URL, Location)
            RaiseEvent FileDownloadComplete(index)
            Return True
        Catch ex As Exception
            RaiseEvent FileDownloadFailed(index, ex)
            Return False
        End Try
    End Function
    Private Function GetFileName(ByVal URL As String) As String
        Try
            Return URL.Substring(URL.LastIndexOf("/") + 1)
        Catch ex As Exception
            Return URL
        End Try
    End Function
    Public Function DownloadFileWithProgress(ByVal URL As String, ByVal Location As String) As Boolean
        Dim FS As FileStream
        Try
            Dim wRemote As Net.WebRequest
            Dim bBuffer As Byte()
            ReDim bBuffer(256)
            Dim iBytesRead As Integer
            Dim iTotalBytesRead As Integer
            Dim Percentage As Integer
            Dim oPercentage As Integer
            FS = New FileStream(Location, FileMode.Create, FileAccess.Write)
            wRemote = Net.WebRequest.Create(URL)
            Dim myWebResponse As Net.WebResponse = wRemote.GetResponse
            Dim sChunks As Stream = myWebResponse.GetResponseStream
            Do
                oPercentage = Percentage
                Percentage = Math.Round((iTotalBytesRead / myWebResponse.ContentLength) * 100)
                If Percentage > oPercentage Then
                    RaiseEvent FileDownloadPercentageChanged(Percentage, index)
                End If
                iBytesRead = sChunks.Read(bBuffer, 0, 256)
                FS.Write(bBuffer, 0, iBytesRead)
                iTotalBytesRead += iBytesRead
            Loop While Not iBytesRead = 0
            sChunks.Close()
            FS.Close()
            RaiseEvent FileDownloadComplete(index)
            Return True
        Catch ex As Exception
            If Not (FS Is Nothing) Then
                FS.Close()
                FS = Nothing
            End If
            RaiseEvent FileDownloadFailed(index, ex)
            Return False
        End Try
    End Function
    Public Shared Function FormatFileSize(ByVal Size As Long) As String
        Try
            Dim KB As Integer = 1024
            Dim MB As Integer = KB * KB
            ' Return size of file in kilobytes.
            If Size < KB Then
                Return (Size.ToString("D") & " bytes")
            Else
                Select Case Size / KB
                    Case Is < 1000
                        Return (Size / KB).ToString("N") & "KB"
                    Case Is < 1000000
                        Return (Size / MB).ToString("N") & "MB"
                    Case Is < 10000000
                        Return (Size / MB / KB).ToString("N") & "GB"
                End Select
            End If
            Return Size.ToString
        Catch ex As Exception
            Return Size.ToString
        End Try
    End Function
    Public Sub Download(ByVal Path As String, ByVal Highest As Boolean, Optional ByVal Res As Integer = 1080)
        ' Try
        Dim ResTag As String = "5"
        Dim Extension As String = ".flv"
        If Res = 1080 Then
            ResTag = "37"
            Extension = ".mp4"
        ElseIf Res = 720 Then
            ResTag = "22"
            Extension = ".mp4"
        ElseIf Res = 480 Then
            ResTag = "35"
            Extension = ".flv"
        ElseIf Res = 360 Then
            ResTag = "34"
            Extension = ".flv"
        ElseIf Res = 240 Then
            ResTag = "5"
            Extension = ".flv"
        End If
        Dim High As New Queue(Of String)
        If Highest Then
            High.Enqueue("37")
            High.Enqueue("22")
            High.Enqueue("35")
            High.Enqueue("34")
            High.Enqueue("5")
        End If
        Dim TM As New TypingMonkey
        Dim Title As String = F.GetBetweenR(HTML, "<meta name=""title"" content=""", """>", 0, True)
        Dim Ext As String = F.URLEncode(System.Web.HttpUtility.HtmlDecode(Title)) & "_" & TM.TypeAway(5)
        If Ext.Contains("\") Then : Ext = Replace(Ext, "\", " ") : End If
        If Ext.Contains("/") Then : Ext = Replace(Ext, "/", " ") : End If
        If Ext.Contains(":") Then : Ext = Replace(Ext, ":", " ") : End If
        If Ext.Contains("*") Then : Ext = Replace(Ext, "*", " ") : End If
        If Ext.Contains("?") Then : Ext = Replace(Ext, "?", " ") : End If
        If Ext.Contains("|") Then : Ext = Replace(Ext, "|", " ") : End If
        If Ext.Contains("<") Then : Ext = Replace(Ext, "<", " ") : End If
        If Ext.Contains(">") Then : Ext = Replace(Ext, ">", " ") : End If

        Dim swfConfig As String
        If HTML.Contains("param name=""flashvars""") Then
            swfConfig = F.GetBetweenR(HTML, "param name=""flashvars""", "allowscriptaccess", 0, True)
        Else
            swfConfig = F.GetBetweenR(HTML, "flashvars=""", "allowscriptaccess", 0, True)
        End If
    
        'Dim swfConfig As String = F.GetBetweenR(HTML, """fmt_url_map"": """, """, ""hl"": """, 0, True)

        swfConfig = swfConfig.Replace("\/", "/").Replace("%25", "%").Replace("%2C", ",").Replace("%7C", "|").Replace("%3F", "?").Replace("%3D", "=").Replace("%26", "&").Replace("%2F", "/").Replace("%3A", ":")
        swfConfig = swfConfig.Replace("\u0025", "%").Replace("\u002c", ",").Replace("\u007c", "|").Replace("\u003f", "?").Replace("\u003d", "=").Replace("\u0026", "&").Replace("\u002f", "/").Replace("\u003a", ":")
        'swfConfig = swfConfig.Replace(F.GetBetweenR(swfConfig, """", "fmt_url_map", 0, True), "")
        'swfConfig = swfConfig.Replace(swfConfig.Substring(0, 5), vbNullString)
        'swfConfig = F.GetBetweenR(swfConfig, """fmt__map"": """, """, ""csi_page_type""", 0, True)

        '<NEW>
        If swfConfig.Contains("url_encoded_fmt_stream_map") Then
            Dim ptchn As String = Nothing
            Dim ptk As String = Nothing
            If swfConfig.Contains("iv_logging_level") Then
                swfConfig = F.URLDecode(F.HTMLDecode(F.GetBetweenR(swfConfig, "url_encoded_fmt_stream_map=", "iv_logging_level", 0, True)))
                If swfConfig.Contains("ptchn=") And swfConfig.Contains("ptk=") Then
                    ptchn = F.GetBetweenR(HTML, "ptchn=", "&", 0, True)
                    ptk = F.GetBetweenR(HTML, "ptk=", "&", 0, True)
                End If
            Else
                swfConfig = F.URLDecode(F.HTMLDecode(F.GetBetweenR(swfConfig, "url_encoded_fmt_stream_map=", "watermark=", 0, True)))
            End If


            Dim Splut As String() = Split(swfConfig, "url=")
            Dim Links As New List(Of String())

            For Each Str As String In Splut
                If Str.Length < 500 And Str.Length > 100 And Not Str.Contains("ad-emea.doubleclick.net") Then
                    If StrReverse(Str).Substring(0, 4).Contains(",") Then
                        Str = Str.Replace("," & StrReverse(Split(StrReverse(Str), ",")(0)), vbNullString)
                    End If
                    Dim itag As String = F.GetBetweenR(Str, "itag=", "&", 0, True)
                    If Not ptk Is Nothing And ptchn Is Nothing Then
                        Links.Add({Split(Str, "&quality=")(0) & "&ptk=" & ptk & "&ptchn=" & ptchn & "&title=" & Ext, itag})
                    Else
                        Links.Add({Split(Str, "&quality=")(0) & "&title=" & Ext, itag})
                    End If
                End If
            Next

            Dim T As Integer
LoopIt:     For Each Str As String() In Links
                Dim ITAG As String = Str(1)
                If ITAG = ResTag Then
                    'Process.Start(Str(0))
                    DownloadFileWithProgress(Str(0), Path & Ext & Extension)
                    Return
                End If
            Next
            If Highest Then
                If High.Count > 0 Then
                    ResTag = High.Dequeue
                    If ResTag = "37" Then
                        Extension = ".mp4"
                    ElseIf ResTag = "22" Then
                        Extension = ".mp4"
                    ElseIf ResTag = "35" Then
                        Extension = ".flv"
                    ElseIf ResTag = "34" Then
                        Extension = ".flv"
                    ElseIf ResTag = "5" Then
                        Extension = ".flv"
                    End If
                    GoTo LoopIt
                End If
            Else
                ResTag = "5"
                Extension = ".flv"
                If T = 0 Then
                    T = 1
                    GoTo LoopIt
                End If
            End If
        Else
            swfConfig = F.GetBetweenR(swfConfig, "fmt_url_map=", "hl=", 0, True)
            Dim Splut As String() = Split(swfConfig, "|")
            Dim Links As New List(Of String())

            For Each Str As String In Splut
                If Str.Length < 400 And Str.Length > 100 And Not Str.Contains("ad-emea.doubleclick.net") Then
                    If StrReverse(Str).Substring(0, 4).Contains(",") Then
                        Str = Str.Replace("," & StrReverse(Split(StrReverse(Str), ",")(0)), vbNullString)
                    End If
                    Dim itag As String = F.GetBetweenR(Str, "itag=", "&", 0, True)
                    Links.Add({Str & "&title=" & Ext, itag})
                End If
            Next

            Dim T As Integer
LoopIt1:    For Each Str As String() In Links
                Dim ITAG As String = Str(1)
                If ITAG = ResTag Then
                    'Process.Start(Str(0))
                    DownloadFileWithProgress(Str(0), Path & Ext & Extension)
                    Return
                End If
            Next
            If Highest Then
                If High.Count > 0 Then
                    ResTag = High.Dequeue
                    If ResTag = "37" Then
                        Extension = ".mp4"
                    ElseIf ResTag = "22" Then
                        Extension = ".mp4"
                    ElseIf ResTag = "35" Then
                        Extension = ".flv"
                    ElseIf ResTag = "34" Then
                        Extension = ".flv"
                    ElseIf ResTag = "5" Then
                        Extension = ".flv"
                    End If
                    GoTo LoopIt
                End If
            Else
                ResTag = "5"
                Extension = ".flv"
                If T = 0 Then
                    T = 1
                    GoTo LoopIt1
                End If
            End If
        End If
        '  Catch ex As Exception
        'RaiseEvent FileDownloadFailed(index, ex)
        '   End Try
    End Sub
#End Region
#End Region
End Class
Public Class Download
#Region "Events"
    Public Event FileDownloadPercentageChanged(ByVal Percentage As Integer, ByVal index As Integer)
    Public Event FileDownloadComplete(ByVal index As Integer)
    Public Event FileDownloadFailed(ByVal index As Integer, ByVal ex As Exception)
#End Region
#Region "Declerations"
    Private S As New WebWrapper
    Private F As New Functions.General
    Private index As Integer
#End Region
#Region "Functions"
#Region "New"
    Sub New(ByVal Index As Integer)
        Me.index = Index
    End Sub
#End Region
#Region "Download"
    Public Function DownloadFile(ByVal URL As String, ByVal Location As String) As Boolean
        Try
            Dim WC As New Net.WebClient
            WC.DownloadFile(URL, Location)
            RaiseEvent FileDownloadComplete(index)
            Return True
        Catch ex As Exception
            RaiseEvent FileDownloadFailed(index, ex)
            Return False
        End Try
    End Function
    Private Function GetFileName(ByVal URL As String) As String
        Try
            Return URL.Substring(URL.LastIndexOf("/") + 1)
        Catch ex As Exception
            Return URL
        End Try
    End Function
    Public Function DownloadFileWithProgress(ByVal URL As String, ByVal Location As String) As Boolean
        Dim FS As FileStream
        Try
            Dim wRemote As Net.WebRequest
            Dim bBuffer As Byte()
            ReDim bBuffer(256)
            Dim iBytesRead As Integer
            Dim iTotalBytesRead As Integer
            Dim Percentage As Integer
            Dim oPercentage As Integer
            FS = New FileStream(Location, FileMode.Create, FileAccess.Write)
            wRemote = Net.WebRequest.Create(URL)
            Dim myWebResponse As Net.WebResponse = wRemote.GetResponse
            Dim sChunks As Stream = myWebResponse.GetResponseStream
            Do
                oPercentage = Percentage
                Percentage = Math.Round((iTotalBytesRead / myWebResponse.ContentLength) * 100)
                If Percentage > oPercentage Then
                    RaiseEvent FileDownloadPercentageChanged(Percentage, index)
                End If
                iBytesRead = sChunks.Read(bBuffer, 0, 256)
                FS.Write(bBuffer, 0, iBytesRead)
                iTotalBytesRead += iBytesRead
            Loop While Not iBytesRead = 0
            sChunks.Close()
            FS.Close()
            RaiseEvent FileDownloadComplete(index)
            Return True
        Catch ex As Exception
            If Not (FS Is Nothing) Then
                FS.Close()
                FS = Nothing
            End If
            RaiseEvent FileDownloadFailed(index, ex)
            Return False
        End Try
    End Function
    Public Shared Function FormatFileSize(ByVal Size As Long) As String
        Try
            Dim KB As Integer = 1024
            Dim MB As Integer = KB * KB
            ' Return size of file in kilobytes.
            If Size < KB Then
                Return (Size.ToString("D") & " bytes")
            Else
                Select Case Size / KB
                    Case Is < 1000
                        Return (Size / KB).ToString("N") & "KB"
                    Case Is < 1000000
                        Return (Size / MB).ToString("N") & "MB"
                    Case Is < 10000000
                        Return (Size / MB / KB).ToString("N") & "GB"
                End Select
            End If
            Return Size.ToString
        Catch ex As Exception
            Return Size.ToString
        End Try
    End Function
#End Region
#End Region
End Class