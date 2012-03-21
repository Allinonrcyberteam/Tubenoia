Public Class frmChangeLog
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub getChangeLog()
        Dim W As New WebWrapper
        Dim Changelog As String
        Changelog = W.httpGet("http://www.tubenoia.com/changelogs.txt")
        Changes.Text = Changelog
        lblVer.Text = "v" & frmMain.Version
        '__
        Dim textEnd As Integer = Changes.TextLength
        Dim index As Integer = 0
        Dim lastIndex As Integer = Changes.Text.LastIndexOf("FIX")
        While index < lastIndex
            Changes.Find("FIX", index, textEnd, RichTextBoxFinds.MatchCase)
            Changes.SelectionColor = Color.Green
            index = Changes.Text.IndexOf("FIX", index) + 1
        End While
        '____________________________________________________________________
        index = 0
        lastIndex = Changes.Text.LastIndexOf("NEW")
        While index < lastIndex
            Changes.Find("NEW", index, textEnd, RichTextBoxFinds.MatchCase)
            'Changes.SelectionFont = New Font(Changes.Font, 15)
            Changes.SelectionColor = Color.Red
            index = Changes.Text.IndexOf("NEW", index) + 1
        End While
        '____________________________________________________________________
        index = 0
        lastIndex = Changes.Text.LastIndexOf("GIFT")
        While index < lastIndex
            Changes.Find("GIFT", index, textEnd, RichTextBoxFinds.MatchCase)
            'Changes.SelectionFont = New Font(Changes.Font, 15)
            Changes.SelectionColor = Color.Blue
            index = Changes.Text.IndexOf("GIFT", index) + 1
        End While
    End Sub
    Private Sub frmChangeLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim T As New Threading.Thread(AddressOf getChangeLog)
        T.Start()
    End Sub
End Class