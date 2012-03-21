Imports System.Net
Imports System.Threading
Public Class WebWrapper
#Region "Events"
    Event UploadProgress(ByVal sender As Object, ByVal Progress As Integer, ByVal index As Integer)
#End Region
#Region "Declerations"
    Private UseProxy As Boolean = False
    Private UA As String = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.107 Safari/535.1"
    Private Proxy As New WebProxy
    Public LastPage As String = "http://youtube.com/"
    Private WebRequest As Net.HttpWebRequest
    Private WebResponse As Net.HttpWebResponse
    Public cookies As New Net.CookieContainer
    Private ProxyUsername As String
    Private ProxyPassword As String
    Private UserAgents As New List(Of String)
    Private F As New Functions.General
#End Region
#Region "Functions"
    Sub New()
        UserAgents.Add("Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.112 Safari/535.1")
        'UserAgents.Add("Mozilla/5.0 (Windows; U; Windows NT 6.1; nb-NO; rv:1.9.2.18) Gecko/20110614 Firefox/3.6.18")
        'UserAgents.Add("Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)")
        UA = UserAgents(F.RandomInteger(0, UserAgents.Count - 1))
    End Sub
    Public Sub setUa(ByVal useragent As String)
        UA = useragent
        WebRequest.UserAgent = UA
    End Sub
    Public Sub SetProxy(ByVal ip As String, ByVal port As Integer, Optional ByVal Login As Boolean = False, Optional ByVal Username As String = vbNullString, Optional ByVal Password As String = vbNullString)
        If Login = False Then
            Proxy = New WebProxy(ip, port)
            UseProxy = True
            Proxy.Credentials = Nothing
            Proxy.UseDefaultCredentials = True
        Else
            ProxyUsername = Username
            ProxyPassword = Password
            Proxy.UseDefaultCredentials = False
            Dim CR As System.Net.ICredentials = New NetworkCredential(Username, Password)
            Proxy = New WebProxy(ip, port)
            UseProxy = True
            Proxy.Credentials = CR
        End If
    End Sub
    Public Sub DontUseProxy()
        Proxy = Nothing
        UseProxy = False
    End Sub
    Public Sub ClearCookies()
        cookies = New Net.CookieContainer
    End Sub
    Private Function ReadStream(ByVal Stream As IO.Stream) As String
        Dim ResponseReader As IO.StreamReader
        Dim ResponseData As String
        ResponseReader = New IO.StreamReader(Stream)
        ResponseData = ResponseReader.ReadToEnd()
        ResponseReader.Close()
        Return ResponseData
    End Function
    Private Sub WriteStream(ByVal PostData As String)
        Dim RequestWriter As IO.StreamWriter
        RequestWriter = New IO.StreamWriter(WebRequest.GetRequestStream)
        RequestWriter.Write(PostData)
        RequestWriter.Close()
    End Sub

    Function httpGet(ByVal Address As String) As String
        Try
            WebRequest = HttpWebRequest.Create(Address)
            'WebRequest.ContentType = "application/x-www-form-urlencoded"
            WebRequest.Method = "GET"
            WebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"
            WebRequest.Headers.Add("Cache-Control", "no-cache")
            WebRequest.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7")
            'WebRequest.Headers.Add("Accept-Encoding", "gzip,deflate,sdch")
            WebRequest.Headers.Add("Accept-Language", "en-us;q=0.3,en;q=0.1")
            WebRequest.KeepAlive = True
            'WebRequest.Headers.Add("Keep-Alive", "300")
            'WebRequest.CookieContainer = New Net.CookieContainer()
            WebRequest.CookieContainer = cookies
            WebRequest.UserAgent = UA
            WebRequest.Referer = LastPage
            If UseProxy = True Then
                WebRequest.Proxy = Proxy
            Else
                WebRequest.Proxy = Nothing
            End If
            WebResponse = WebRequest.GetResponse()
            For Each cook As Cookie In WebResponse.Cookies
                'If cook.Name.ToLower.Contains("geo") = False And cook.Name.ToLower.Contains("demographics") = False And cook.Name.ToLower.Contains("visitor_info1_live") = False Then
                cookies.Add(cook)
                'End If
            Next
            LastPage = Address
            Return ReadStream(WebResponse.GetResponseStream())
        Catch
            Return Nothing
        End Try
    End Function
    Function httpGetTime(ByVal Address As String, ByVal TOUT As Integer) As String
        Try
            WebRequest = HttpWebRequest.Create(Address)
            'WebRequest.ContentType = "application/x-www-form-urlencoded"
            WebRequest.Method = "GET"
            WebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"
            WebRequest.Headers.Add("Cache-Control", "no-cache")
            WebRequest.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7")
            'WebRequest.Headers.Add("Accept-Encoding", "gzip,deflate,sdch")
            WebRequest.Headers.Add("Accept-Language", "en-us;q=0.3,en;q=0.1")
            WebRequest.KeepAlive = True
            'WebRequest.Headers.Add("Keep-Alive", "300")
            'WebRequest.CookieContainer = New Net.CookieContainer()
            WebRequest.CookieContainer = cookies
            WebRequest.UserAgent = UA
            WebRequest.Referer = LastPage
            WebRequest.Timeout = TOUT
            If UseProxy = True Then
                WebRequest.Proxy = Proxy
            Else
                WebRequest.Proxy = Nothing
            End If
            WebResponse = WebRequest.GetResponse()
            For Each cook As Cookie In WebResponse.Cookies
                'If cook.Name.ToLower.Contains("geo") = False And cook.Name.ToLower.Contains("demographics") = False And cook.Name.ToLower.Contains("visitor_info1_live") = False Then
                cookies.Add(cook)
                'End If
            Next
            LastPage = Address
            Return ReadStream(WebResponse.GetResponseStream())
        Catch
            Return Nothing
        End Try
    End Function
    Function httpGetRef(ByVal Address As String, ByVal Ref As String) As String
        Try
            WebRequest = HttpWebRequest.Create(Address)
            'WebRequest.ContentType = "application/x-www-form-urlencoded"
            WebRequest.Method = "GET"
            WebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"
            WebRequest.Headers.Add("Cache-Control", "no-cache")
            WebRequest.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7")
            'WebRequest.Headers.Add("Accept-Encoding", "gzip,deflate,sdch")
            WebRequest.Headers.Add("Accept-Language", "en-US,en;q=0.5")
            WebRequest.KeepAlive = True
            'WebRequest.Headers.Add("Keep-Alive", "300")
            'WebRequest.CookieContainer = New Net.CookieContainer()
            WebRequest.CookieContainer = cookies
            WebRequest.UserAgent = UA
            WebRequest.Referer = Ref
            If UseProxy = True Then
                WebRequest.Proxy = Proxy
            Else
                WebRequest.Proxy = Nothing
            End If
            WebResponse = WebRequest.GetResponse()
            For Each cook As Cookie In WebResponse.Cookies
                'If cook.Name.ToLower.Contains("geo") = False And cook.Name.ToLower.Contains("demographics") = False And cook.Name.ToLower.Contains("visitor_info1_live") = False Then
                cookies.Add(cook)
                'End If
            Next
            LastPage = Address
            Return ReadStream(WebResponse.GetResponseStream())
        Catch
            Return Nothing
        End Try
    End Function
    Public Function AcceptAllCertifications(ByVal sender As Object, ByVal certification As System.Security.Cryptography.X509Certificates.X509Certificate, ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, ByVal sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function
    Function httpPost(ByVal Address As String, ByVal PostData As String, Optional ByVal Redir As Boolean = True) As String
        ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf AcceptAllCertifications)

        WebRequest = HttpWebRequest.Create(Address)
        WebRequest.UserAgent = UA
        WebRequest.ContentType = "application/x-www-form-urlencoded"
        WebRequest.Method = "POST"
        WebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"
        WebRequest.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7")
        'WebRequest.Headers.Add("Accept-Encoding", "gzip,deflate,sdch")
        WebRequest.Headers.Add("Accept-Language", "en-us;q=0.3,en;q=0.1")
        WebRequest.KeepAlive = True
        'WebRequest.Headers.Add("Keep-Alive", "300")
        WebRequest.Headers.Add("Cache-Control", "no-cache")

        'WebRequest.CookieContainer = New Net.CookieContainer()
        WebRequest.CookieContainer = cookies
        If UseProxy = True Then
            WebRequest.Proxy = Proxy
        Else
            WebRequest.Proxy = Nothing
        End If
        WebRequest.Referer = LastPage
        If Redir Then
            WebRequest.AllowAutoRedirect = True
        Else
            WebRequest.AllowAutoRedirect = False
        End If
        WriteStream(PostData)
        WebResponse = WebRequest.GetResponse()
        For Each cook As Cookie In WebResponse.Cookies
            'If cook.Name.ToLower.Contains("geo") = False And cook.Name.ToLower.Contains("demographics") = False And cook.Name.ToLower.Contains("visitor_info1_live") = False Then
            cookies.Add(cook)
            'End If
        Next
        LastPage = Address
        Return ReadStream(WebResponse.GetResponseStream())
    End Function

    Public Function httpPostCustom(ByVal Address As String, ByVal Data As Byte(), ByVal Content_Type As String) As String
        WebRequest = HttpWebRequest.Create(Address)
        WebRequest.Method = "POST"
        WebRequest.ContentType = Content_Type
        WebRequest.ContentLength = Data.Length
        If UseProxy = True Then
            WebRequest.Proxy = Proxy
        Else
            WebRequest.Proxy = Nothing
        End If
        WebRequest.CookieContainer = cookies
        Using postStream As System.IO.Stream = WebRequest.GetRequestStream()
            postStream.Write(Data, 0, Data.Length)
            postStream.Close()
            Dim webResponse As WebResponse = WebRequest.GetResponse()
            Using responseStream As System.IO.Stream = webResponse.GetResponseStream()
                Using reader As New System.IO.StreamReader(responseStream)
                    Dim theResp As String = reader.ReadToEnd
                    Return theResp
                    reader.Close()
                End Using
                responseStream.Close()
            End Using
            webResponse.Close()
        End Using
    End Function
    Public Function httpPostUploadVideo(ByVal Address As String, ByVal Data As Byte(), ByVal Content_Type As String, Optional ByVal index As Integer = 1) As String
        Try
            WebRequest = HttpWebRequest.Create(Address)
            WebRequest.Method = "POST"
            WebRequest.ContentType = Content_Type
            WebRequest.ContentLength = Data.Length
            WebRequest.AllowWriteStreamBuffering = False
            WebRequest.ServicePoint.Expect100Continue = False
            WebRequest.KeepAlive = False
            WebRequest.ProtocolVersion = HttpVersion.Version10
            WebRequest.ReadWriteTimeout = Timeout.Infinite
            WebRequest.Timeout = Timeout.Infinite
            If UseProxy = True Then
                WebRequest.Proxy = Proxy
            Else
                WebRequest.Proxy = Nothing
            End If
            WebRequest.CookieContainer = cookies
            Using postStream As System.IO.Stream = WebRequest.GetRequestStream()
                postStream.ReadTimeout = Timeout.Infinite
                postStream.WriteTimeout = Timeout.Infinite
                'postStream.Write(Data, 0, Data.Length)
                Dim UploadedBytes As Integer
                Dim UploadedKBytes As Integer
                Dim Percentage As Integer
                For Each B As Byte In Data
                    postStream.WriteByte(B)
                    UploadedBytes += 1
                    If UploadedBytes = 1024 Then
                        UploadedBytes = 0
                        UploadedKBytes += 1024
                        Percentage = Math.Round((UploadedKBytes / Data.Length) * 100)
                        RaiseEvent UploadProgress(Me, Percentage, index)
                    End If
                Next
                postStream.Close()
                Dim webResponse As WebResponse = WebRequest.GetResponse()
                Using responseStream As System.IO.Stream = webResponse.GetResponseStream()
                    Using reader As New System.IO.StreamReader(responseStream)
                        Dim theResp As String = reader.ReadToEnd
                        Return theResp
                        reader.Close()
                    End Using
                    responseStream.Close()
                End Using
                webResponse.Close()
            End Using
        Catch
            RaiseEvent UploadProgress(Me, 0, index)
            Return Nothing
        End Try
    End Function

    Public Function SSLSockGET(ByVal Website As String) As String
        Dim Socket = New CHILKATSOCKETLib.ChilkatSocket
        Dim bAbort = False
        Socket.UnlockComponent("SocketT34MB34N_77CC90E8lvpA")
        Socket.HeartbeatMs = 200
        Dim getReq As String
        'getReq = Socket.BuildHttpGetRequest("http://" & Website)

        Dim Path As String = "/" & Split(Website, "/")(1)
        Debug.WriteLine(Path)

        getReq = "GET " & Path & " HTTP/1.1" & vbCrLf & _
        "Host: " & Split(Website, "/")(0).Replace("http://", "") & vbCrLf & _
        "Connection: keep-alive" & vbCrLf & _
        "Cache-Control: max-age = 0" & vbCrLf & _
        "User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/534.30 (KHTML, like Gecko) Chrome/12.0.742.91 Safari/534.30" & vbCrLf & _
        "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8" & vbCrLf & _
        "Accept-Encoding: gzip, deflate, sdch" & vbCrLf & _
        "Accept-Charset: ISO-8859-1,utf-8;q=0.7,*;q=0.3" & vbCrLf & vbCrLf

        Dim success = Socket.Connect(Website, 443, 5000, 20000)
        If (success = 0) Then
            Return Socket.LastErrorText
            Exit Function
        End If
        Dim cert As CHILKATCERTIFICATELib.ChilkatCert
        cert = Socket.GetSslServerCert()
        success = Socket.SendString(getReq)
        If (success = 0) Then
            Return Socket.LastErrorText
            Exit Function
        End If
        Socket.ReceivePacketSize = 40000
        Socket.MaxReadIdleMs = 10000
        Dim status As String
        status = Socket.ReceiveUntilMatch(vbCrLf)
        If (Len(status) = 0) Then
            Return Socket.LastErrorText
            Exit Function
        End If
        Debug.WriteLine(status)
        Dim responseHeader As String
        responseHeader = Socket.ReceiveUntilMatch(vbCrLf & vbCrLf)
        If (Len(responseHeader) = 0) Then
            Return Socket.LastErrorText
            Exit Function
        End If
        Debug.WriteLine(responseHeader)
        Dim mime As New CHILKATMIMELib.ChilkatMime
        mime.UnlockComponent("SMIMET34MB34N_2AE1EF4DGA7U")
        mime.LoadMime(responseHeader)
        'Dim contentLenStr As String
        'contentLenStr = mime.GetHeaderField("content-length")
        'Dim contentLen As Integer
        'contentLen = Val(contentLenStr)
        Dim htmlPage As Object
        'htmlPage = Socket.ReceiveUntilMatch("</html>")
        htmlPage = Socket.ReceiveBytesN(1000)
        Return htmlPage
        'Dim cc As New ChilkatCharset2Lib.ChilkatCharset2
        'cc.UnlockComponent("CharsetT34MB34N_2DB2A2DBCRje")
        'Dim CharSetText = cc.GetHtmlCharset(htmlPage)
        'Try
        '    If (Len(CharSetText) = 0) Then
        '        CharSetText = "windows-1252"
        '    End If
        'Catch
        '    CharSetText = "windows-1252"
        'End Try
        'cc.FromCharset = CharSetText
        'Return cc.ConvertToUnicode(htmlPage)
    End Function
#End Region
End Class

