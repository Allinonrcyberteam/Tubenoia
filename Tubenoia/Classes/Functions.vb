Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Reflection

Namespace Functions
    Public Class General
        Private Const EM_SETCUEBANNER As Integer = &H1501
        <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
        Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
        End Function
        Public Sub SetCueText(ByVal control As Control, ByVal text As String)
            SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
        End Sub
        Public Function Lines(ByVal text As String) As String()
            Dim T As String, O As New List(Of String)
            Using R As New StringReader(text)
                While R.Peek > -1
                    T = R.ReadLine
                    If T <> "" Then O.Add(T)
                End While
            End Using
            Return O.ToArray
        End Function
        Public Sub Logs(ByVal Content As String, ByVal ImageKey As Integer, ByVal IL As ImageList, ByVal LogList As ListView)
            Dim LV As New ListViewItem
            LV.ImageKey = IL.Images.Keys(ImageKey)
            LV.SubItems.Add(TimeOfDay)
            LV.SubItems.Add(Content)
            LogList.Items.Add(LV)
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
                        ElseIf i = 2 Then
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
        Public Function CommentObfuscate(ByVal Input As String) As String
            'Input = StrConv(Input, VbStrConv.Uppercase)
            Input = Replace(Input, "A", "Ａ")
            Input = Replace(Input, "Y", "Ｙ")
            Input = Replace(Input, "O", "Ｏ")
            Input = Replace(Input, "I", "Ｉ")
            Input = Replace(Input, "E", "Ｅ")
            Input = Replace(Input, "T", "Ｔ")
            Input = Replace(Input, "C", "Ｃ")
            Input = Replace(Input, "W", "Ｗ")
            Input = Replace(Input, "F", "Ｆ")
            Input = Replace(Input, "G", "Ｇ")
            Input = Replace(Input, "H", "Ｈ")
            Input = Replace(Input, "M", "Ｍ")
            Input = Replace(Input, "N", "Ｎ")
            Input = Replace(Input, "B", "Ｂ")
            Input = Replace(Input, "J", "Ｊ")
            Input = Replace(Input, "D", "Ｄ")
            Input = Replace(Input, "Q", "Ｑ")
            Input = Replace(Input, "T", "Ｔ")
            Input = Replace(Input, "V", "Ｖ")
            Input = Replace(Input, "Y", "Ｙ")
            Input = Replace(Input, "R", "Ｒ")
            Input = Replace(Input, "Z", "Ｚ")
            Input = Replace(Input, "L", "Ｌ")
            Input = Replace(Input, "S", "Ｓ")
            Input = Replace(Input, "K", "Ｋ")
            Input = Replace(Input, "U", "Ｕ")
            Input = Replace(Input, "P", "Ｐ")
            Input = Replace(Input, "X", "Ｘ")

            Input = Replace(Input, "a", "ａ")
            Input = Replace(Input, "b", "ｂ")
            Input = Replace(Input, "c", "ｃ")
            Input = Replace(Input, "d", "ｄ")
            Input = Replace(Input, "e", "ｅ")
            Input = Replace(Input, "f", "ｆ")
            Input = Replace(Input, "g", "ｇ")
            Input = Replace(Input, "h", "ｈ")
            Input = Replace(Input, "i", "ｉ")
            Input = Replace(Input, "j", "ｊ")
            Input = Replace(Input, "k", "ｋ")
            Input = Replace(Input, "l", "ｌ")
            Input = Replace(Input, "m", "ｍ")
            Input = Replace(Input, "n", "ｎ")
            Input = Replace(Input, "o", "ｏ")
            Input = Replace(Input, "p", "ｐ")
            Input = Replace(Input, "q", "ｑ")
            Input = Replace(Input, "r", "ｒ")
            Input = Replace(Input, "s", "ｓ")
            Input = Replace(Input, "t", "ｔ")
            Input = Replace(Input, "u", "ｕ")
            Input = Replace(Input, "v", "ｖ")
            Input = Replace(Input, "w", "ｗ")
            Input = Replace(Input, "x", "ｘ")
            Input = Replace(Input, "y", "ｙ")
            Input = Replace(Input, "z", "ｚ")


            Input = Replace(Input, "!", "！")
            Return Input
        End Function
        Public Function GetBetween(ByRef strSource As String, ByRef strStart As String, ByRef strEnd As String, Optional ByRef startPos As Integer = 0) As String
            Try
                Dim iPos As Integer, iEnd As Integer, lenStart As Integer = strStart.Length
                Dim strResult As String
                strResult = String.Empty
                iPos = strSource.IndexOf(strStart, startPos)
                iEnd = strSource.IndexOf(strEnd, iPos + lenStart)
                If iPos <> -1 AndAlso iEnd <> -1 Then
                    strResult = strSource.Substring(iPos + lenStart, iEnd - (iPos + lenStart))
                End If
                Return strResult
            Catch
                Return False
            End Try
        End Function
        Public Function ScrapeUsers(ByVal Source As String) As List(Of String)
            Dim myMatches As MatchCollection
            Dim I As Integer
            Dim L As New List(Of String)
            Dim myRegex As New Regex("user/(.*?)""")
            myMatches = myRegex.Matches(Source)
            Dim successfulMatch As Match
            For Each successfulMatch In myMatches
                If successfulMatch.Groups(1).Value.Contains("?") Then
                    L.Add(Split(successfulMatch.Groups(1).Value, "?")(0))
                Else
                    L.Add(successfulMatch.Groups(1).Value)
                End If
                I += 1
            Next
            Return L
        End Function
        Public Function RandomInteger(ByVal Lowerbound As Integer, ByVal Upperbound As Integer) As Integer
            Randomize()
            RandomInteger = Int((Upperbound - Lowerbound + 1) * Rnd() + Lowerbound)
        End Function
        Public Function GetBetweenR(ByVal input As String, ByVal str1 As String, ByVal str2 As String, _
            ByVal index As Integer, ByVal trim As Boolean) As String
            Dim temp As String = Regex.Split(input, str1)(index + 1)
            If trim Then
                Return Regex.Split(temp, str2)(0).Trim()
            Else
                Return Regex.Split(temp, str2)(0)
            End If
        End Function
        Public Function HTMLDecode(ByVal input As String)
            Return System.Web.HttpUtility.HtmlDecode(input)
        End Function
        Public Function HTMLEncode(ByVal input As String)
            Return System.Web.HttpUtility.HtmlEncode(input)
        End Function
        Public Function GetExtension(ByVal FileName As String)
            Try
                Return FileName.Substring(InStrRev(FileName, "."))
            Catch
                Return Nothing
            End Try
        End Function
        Public Function URLEncode(ByVal Input As String) As String
            Return System.Web.HttpUtility.UrlEncode(Input)
        End Function
        Public Function URLDecode(ByVal Input As String) As String
            Return System.Web.HttpUtility.UrlDecode(Input)
        End Function
        Public Function SpinOld(ByVal str As String) As String
            Try
                Dim input As String = str
                If input.Contains("{newline}") Then
                    input = Replace(input, "{newline}", vbNewLine)
                End If
                Dim matchs As MatchCollection = Regex.Matches(input, "(?:\{)(.*?)(?:\})")
                Dim match As Match
                For Each match In matchs
                    Dim str3 As String = match.Groups.Item(1).Value
                    If str3.Contains("|") Then
                        Dim strArray As String() = match.Groups.Item(1).Value.Split(New Char() {"|"c})
                        Randomize()
                        Dim index As Integer = New Random().Next(strArray.Length)
                        input = input.Replace(("{" & str3 & "}"), strArray(index))
                    ElseIf str3.Contains("rand:") And str3.Contains("|") = False Then
                        Dim TM As New TypingMonkey
                        Dim Length As Integer = Split(str3, "rand:")(1)
                        input = input.Replace(("{" & str3 & "}"), TM.TypeAway(Length))
                    Else
                        Dim strArray As String() = match.Groups.Item(1).Value.Split(New Char() {"|"c})
                        Randomize()
                        Dim index As Integer = New Random().Next(strArray.Length)
                        input = input.Replace(("{" & str3 & "}"), strArray(index))
                    End If
                Next
                Return input
            Catch
                Return vbNullString
            End Try
        End Function
        Public Function Spin(ByVal str As String) As String
            Try
                Dim input As String = str
                If input.Contains("{newline}") Then
                    input = Replace(input, "{newline}", vbNewLine)
                End If
                Dim matchs As MatchCollection = Regex.Matches(input, "(?:\{)(.*?)(?:\})")
                Dim match As Match
                For Each match In matchs
                    Dim str3 As String = match.Groups.Item(1).Value
Start:              If input.Contains("{") Then
                        If str3.Contains("|") Then
                            'Dim strArray As String() = match.Groups.Item(1).Value.Split(New Char() {"|"c})
                            'Randomize()
                            'Dim index As Integer = New Random().Next(strArray.Length)
                            'input = input.Replace(("{" & str3 & "}"), strArray(index))
                            'Dim strData As String
                            Dim strTemp As String
                            Dim i As Long
                            Dim j As Long
                            Dim intCounter As Integer
                            Dim strOptions As String
                            intCounter = 0
                            'Do
                            intCounter = intCounter + 1
                            strTemp = ""
                            i = InStr(1, input, "{", vbTextCompare)
                            If i > 1 Then strTemp = Mid$(input, 1, i - 1)
                            j = InStr(1, input, "}", vbTextCompare)
                            strTemp = strTemp & "[" & CStr(intCounter) & "]" & Mid$(input, j + 1)
                            strOptions = Mid$(input, i + 1, j - i - 1)
                            input = strTemp
                            myStorage(intCounter).strValues = Split(strOptions, "|")
                            'Loop While (InStr(1, input, "{", vbTextCompare) > 0 And InStr(1, input, "}", vbTextCompare) > 0)
                            Randomize()
                            For i = 1 To intCounter
                                j = RandomInteger(LBound(myStorage(i).strValues), UBound(myStorage(i).strValues))
                                input = Replace(input, "[" & CStr(i) & "]", myStorage(i).strValues(j))
                            Next
                            GoTo Nexxt
                        ElseIf str3.Contains("rand:") Then
                            Dim TM As New TypingMonkey
                            'Dim Length As Integer = Split(str3, "rand:")(1)
                            'input = input.Replace(("{" & str3 & "}"), TM.TypeAway(Length))
                            Dim strTemp As String
                            Dim i As Long
                            Dim j As Long
                            Dim intCounter As Integer
                            Dim strOptions As String
                            intCounter = 0
                            'Do
                            intCounter = intCounter + 1
                            strTemp = ""
                            i = InStr(1, input, "{rand:", vbTextCompare)
                            If i > 1 Then strTemp = Mid$(input, 1, i - 1)
                            j = InStr(1, input, "}", vbTextCompare)
                            strOptions = Mid$(input, i + 1, j - i - 1)
                            strTemp = strTemp & "[" & CStr(intCounter) & ":" & Split(strOptions, ":")(1) & "]" & Mid$(input, j + 1)
                            input = strTemp
                            'Loop While (InStr(1, input, "{rand:", vbTextCompare) > 0 And InStr(1, input, "}", vbTextCompare) > 0)
                            Randomize()
                            For i = 1 To intCounter
                                Dim lengths As String
                                Dim length As Integer
                                lengths = GetBetween(input, "[" & CStr(i), "]")
                                length = CInt(Split(lengths, ":")(1))
                                'j = RandomInteger(LBound(myStorage(i).strValues), UBound(myStorage(i).strValues))
                                input = Replace(input, "[" & CStr(i) & ":" & length & "]", TM.TypeAway(length))
                            Next
                            GoTo Nexxt
                        Else
                            Return input
                        End If
                    Else
                        Return input
                    End If
Nexxt:          Next
                Return input
            Catch
                Return vbNullString
            End Try
        End Function
        Private Structure STORAGE
            Dim strValues() As String
        End Structure
        Dim myStorage(0 To 999) As STORAGE
    End Class
End Namespace
Class TypingMonkey
    Private Const legalCharacters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
    Shared random As New Random()
    ''' <summary>
    ''' The Typing Monkey Generates a random string with the given length.
    ''' </summary>
    ''' <param name="size">Size of the string</param>
    ''' <returns>Random string</returns>
    Public Function TypeAway(ByVal size As Integer) As String
        Randomize()
        Dim builder As New StringBuilder()
        Dim ch As Char
        For i As Integer = 0 To size - 1
            ch = legalCharacters(random.[Next](0, legalCharacters.Length))
            builder.Append(ch)
        Next
        Return builder.ToString()
    End Function
End Class
''' <summary>
''' Implements a countdown timer that raises an event each millisecond but most important when the time have run out.
''' </summary>
<System.ComponentModel.DefaultEvent("TimesOut")> Public Class CountDown



    Private Time As Timer
    Private TimeLeft As ULong

    ''' <summary>
    ''' Initializes a new instance of the CountDown class.
    ''' </summary>
    Public Sub New()
        SetNew()
    End Sub
    ''' <summary>
    ''' Initializes a new instance of the CountDown class with the value from a System.Timespan.
    ''' </summary>
    ''' <param name="Span">The System.TimeSpan to take the value from</param>
    Public Sub New(ByVal Span As TimeSpan)
        TimeLeft = Span.Seconds
    End Sub
    ''' <summary>
    ''' Initializes a new instance of the CountDown class with the value from Seconds.
    ''' </summary>
    ''' <param name="Seconds">Number of Seconds</param>
    Public Sub New(ByVal Seconds As Integer)
        SetNew()
        TimeLeft = Seconds
    End Sub
    ''' <summary>
    ''' Initializes a new instance of the CountDown class with the value from Seconds and Minutes.
    ''' </summary>
    ''' <param name="Seconds">Number of Seconds</param>
    ''' <param name="Minutes">Number of Minutes</param>
    Public Sub New(ByVal Seconds As Integer, ByVal Minutes As Integer)
        SetNew()
        TimeLeft = Seconds + Minutes * 60
    End Sub
    ''' <summary>
    ''' Initializes a new instance of the CountDown class with the value from Seconds, Minutes and Hours.
    ''' </summary>
    ''' <param name="Seconds">Number of Seconds</param>
    ''' <param name="Minutes">Number of Minutes</param>
    ''' <param name="Hours">Number of Hours</param>
    Public Sub New(ByVal Seconds As Integer, ByVal Minutes As Integer, ByVal Hours As Integer)
        SetNew()
        TimeLeft = Seconds + Minutes * 60 + Hours * 3600
    End Sub
    ''' <summary>
    ''' Initializes a new instance of the CountDown class with the value from Seconds, Minutes, Hours and Days.
    ''' </summary>
    ''' <param name="Seconds">Number of Seconds</param>
    ''' <param name="Minutes">Number of Minutes</param>
    ''' <param name="Hours">Number of Hours</param>
    ''' <param name="Days">Number of Days</param>
    Public Sub New(ByVal Seconds As Integer, ByVal Minutes As Integer, ByVal Hours As Integer, ByVal Days As Integer)
        SetNew()
        TimeLeft = Seconds + Minutes * 60 + Hours * 3600 + Days * 86400
    End Sub

    Private Sub SetNew()
        Time = New Timer
        Time.Interval = 1000
        AddHandler Time.Tick, AddressOf Timer_Tick
    End Sub


    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TimeLeft -= 1

        RaiseEvent Tick(Me, TimeLeft)

        If TimeLeft = 0 Then
            Time.Stop()
            RaiseEvent TimesOut(Me, e)
        End If
    End Sub


    ''' <summary>
    ''' Start the timer.
    ''' </summary>
    Public Sub Start()
        If TimeLeft <> 0 Then
            Time.Start()
        Else
            Throw New NullReferenceException
        End If
    End Sub
    ''' <summary>
    ''' Pause the timer.
    ''' </summary>
    Public Sub Pause()
        Time.Stop()
    End Sub
    ''' <summary>
    ''' Stop the timer and reset the time.
    ''' </summary>
    Public Sub Reset()
        TimeLeft = 0
        Time.Stop()
    End Sub

    ''' <summary>
    ''' Set the time of the timer with the value from a System.Timespan.
    ''' </summary>
    ''' <param name="Span">The System.TimeSpan to take the value from</param>
    Public Sub SetTime(ByVal Span As TimeSpan)
        TimeLeft = Span.TotalSeconds
    End Sub
    ''' <summary>
    ''' Set the time of the timer with Seconds.
    ''' </summary>
    ''' <param name="Seconds">Number of Seconds</param>
    Public Sub SetTime(ByVal Seconds As Integer)
        TimeLeft = Seconds
    End Sub
    ''' <summary>
    ''' Set the time of the timer with Seconds and Minutes.
    ''' </summary>
    ''' <param name="Seconds">Number of Seconds</param>
    ''' <param name="Minutes">Number of Minutes</param>
    Public Sub SetTime(ByVal Seconds As Integer, ByVal Minutes As Integer)
        TimeLeft = Seconds + Minutes * 60
    End Sub
    ''' <summary>
    ''' Set the time of the timer with Seconds, Minutes and Hours.
    ''' </summary>
    ''' <param name="Seconds">Number of Seconds</param>
    ''' <param name="Minutes">Number of Minutes</param>
    ''' <param name="Hours">Number of Hours</param>
    Public Sub SetTime(ByVal Seconds As Integer, ByVal Minutes As Integer, ByVal Hours As Integer)
        TimeLeft = Seconds + Minutes * 60 + Hours * 3600
    End Sub
    ''' <summary>
    ''' Set the time of the timer with Seconds, Minutes, Hours and Days.
    ''' </summary>
    ''' <param name="Seconds">Number of Seconds</param>
    ''' <param name="Minutes">Number of Minutes</param>
    ''' <param name="Hours">Number of Hours</param>
    ''' <param name="Days">Number of Days</param>
    Public Sub SetTime(ByVal Seconds As Integer, ByVal Minutes As Integer, ByVal Hours As Integer, ByVal Days As Integer)
        TimeLeft = Seconds + Minutes * 60 + Hours * 3600 + Days * 86400
    End Sub

    ''' <summary>
    ''' Add extra time to the timer with the value from a System.Timespan.
    ''' </summary>
    ''' <param name="Span">The System.TimeSpan to take the value from</param>
    Public Sub AddTime(ByVal Span As TimeSpan)
        TimeLeft += Span.TotalSeconds
    End Sub
    ''' <summary>
    ''' Add extra time to the timer with Seconds.
    ''' </summary>
    ''' <param name="Seconds">Number of Seconds</param>
    Public Sub AddTime(ByVal Seconds As Integer)
        TimeLeft += Seconds
    End Sub
    ''' <summary>
    ''' Add extra time to the timer with Seconds and Minutes.
    ''' </summary>
    ''' <param name="Seconds">Number of Seconds</param>
    ''' <param name="Minutes">Number of Minutes</param>
    Public Sub AddTime(ByVal Seconds As Integer, ByVal Minutes As Integer)
        TimeLeft += Seconds + Minutes * 60
    End Sub
    ''' <summary>
    ''' Add extra time to the timer with Seconds, Minutes and Hours.
    ''' </summary>
    ''' <param name="Seconds">Number of Seconds</param>
    ''' <param name="Minutes">Number of Minutes</param>
    ''' <param name="Hours">Number of Hours</param>
    Public Sub AddTime(ByVal Seconds As Integer, ByVal Minutes As Integer, ByVal Hours As Integer)
        TimeLeft += Seconds + Minutes * 60 + Hours * 3600
    End Sub
    ''' <summary>
    ''' Add extra time to the timer with Seconds, Minutes, Hours and Days.
    ''' </summary>
    ''' <param name="Seconds">Number of Seconds</param>
    ''' <param name="Minutes">Number of Minutes</param>
    ''' <param name="Hours">Number of Hours</param>
    ''' <param name="Days">Number of Days</param>
    Public Sub AddTime(ByVal Seconds As Integer, ByVal Minutes As Integer, ByVal Hours As Integer, ByVal Days As Integer)
        TimeLeft += Seconds + Minutes * 60 + Hours * 3600 + Days * 86400
    End Sub


    ''' <summary>
    ''' Returns the number of Seconds left.
    ''' </summary>
    Public ReadOnly Property Seconds() As Integer
        Get
            Return TimeSplit(3)
        End Get
    End Property
    ''' <summary>
    ''' Returns the number of Minutes left.
    ''' </summary>
    Public ReadOnly Property Minutes() As Integer
        Get
            Return TimeSplit(2)
        End Get
    End Property
    ''' <summary>
    ''' Returns the number of Hours left.
    ''' </summary>
    Public ReadOnly Property Hours() As Integer
        Get
            Return TimeSplit(1)
        End Get
    End Property
    ''' <summary>
    ''' Returns the number of Days left.
    ''' </summary>
    Public ReadOnly Property Days() As Integer
        Get
            Return TimeSplit(0)
        End Get
    End Property

    Private Function TimeSplit() As Integer()
        Dim TimeLeftClone As ULong = TimeLeft
        Dim ReturnValue(4) As Integer


        While TimeLeftClone > 0
            Select Case TimeLeftClone
                Case Is >= 86400
                    TimeLeftClone -= 86400
                    ReturnValue(0) += 1
                Case Is >= 3600
                    TimeLeftClone -= 3600
                    ReturnValue(1) += 1
                Case Is >= 60
                    TimeLeftClone -= 60
                    ReturnValue(2) += 1
                Case Else
                    ReturnValue(3) = TimeLeftClone
                    TimeLeftClone = 0
            End Select
        End While

        Return ReturnValue
    End Function



    ''' <summary>
    ''' Returns the time in Seconds.
    ''' </summary>
    Public ReadOnly Property TotalSeconds() As Double
        Get
            Return New Double = TimeLeft
        End Get
    End Property
    ''' <summary>
    ''' Returns the time in Minutes.
    ''' </summary>
    Public ReadOnly Property TotalMinutes() As Double
        Get
            Return New Double = TimeLeft / 60
        End Get
    End Property
    ''' <summary>
    ''' Returns the time in Hours.
    ''' </summary>
    Public ReadOnly Property TotalHours() As Double
        Get
            Return New Double = TimeLeft / 3600
        End Get
    End Property
    ''' <summary>
    ''' Returns the time in Days.
    ''' </summary>
    Public ReadOnly Property TotalDays() As Double
        Get
            Return New Double = TimeLeft / 86400
        End Get
    End Property


    ''' <summary>
    ''' Raises when the timer reaches 0.
    ''' </summary>
    Public Event TimesOut(ByVal sender As Object, ByVal e As EventArgs)
    ''' <summary>
    ''' Raises each Seconds.
    ''' </summary>
    Public Event Tick(ByVal sender As Object, ByVal Left As ULong)


End Class