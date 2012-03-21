<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommentScraper
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommentScraper))
        Me.Theme = New Tubenoia.NTheme()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Comments = New System.Windows.Forms.NumericUpDown()
        Me.Seperator2 = New Tubenoia.Seperator()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.Seperator1 = New Tubenoia.Seperator()
        Me.seperatorA = New Tubenoia.Seperator()
        Me.chkReplies = New System.Windows.Forms.CheckBox()
        Me.lstComments = New System.Windows.Forms.ListView()
        Me.Author = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Content = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnStart = New Tubenoia.NButton()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.BW = New System.ComponentModel.BackgroundWorker()
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.Theme.SuspendLayout()
        CType(Me.Comments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Controls.Add(Me.Comments)
        Me.Theme.Controls.Add(Me.Seperator2)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.Seperator1)
        Me.Theme.Controls.Add(Me.seperatorA)
        Me.Theme.Controls.Add(Me.chkReplies)
        Me.Theme.Controls.Add(Me.lstComments)
        Me.Theme.Controls.Add(Me.btnStart)
        Me.Theme.Controls.Add(Me.txtPath)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 22
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(512, 393)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Comment Scraper"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1008
        Me.Label1.Text = "Maximum users:"
        '
        'Comments
        '
        Me.Comments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Comments.BackColor = System.Drawing.Color.White
        Me.Comments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Comments.Increment = New Decimal(New Integer() {20, 0, 0, 0})
        Me.Comments.Location = New System.Drawing.Point(103, 101)
        Me.Comments.Maximum = New Decimal(New Integer() {1569325055, 23283064, 0, 0})
        Me.Comments.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Comments.Name = "Comments"
        Me.Comments.Size = New System.Drawing.Size(397, 21)
        Me.Comments.TabIndex = 1007
        Me.Comments.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'Seperator2
        '
        Me.Seperator2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator2.BackColor = System.Drawing.Color.White
        Me.Seperator2.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator2.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator2.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator2.Image = Nothing
        Me.Seperator2.Location = New System.Drawing.Point(8, 121)
        Me.Seperator2.Name = "Seperator2"
        Me.Seperator2.NoRounding = False
        Me.Seperator2.Size = New System.Drawing.Size(496, 10)
        Me.Seperator2.TabIndex = 41
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(462, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 40
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(484, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 39
        Me.btnExit.Text = "X"
        '
        'Seperator1
        '
        Me.Seperator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator1.BackColor = System.Drawing.Color.White
        Me.Seperator1.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator1.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator1.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator1.Image = Nothing
        Me.Seperator1.Location = New System.Drawing.Point(8, 90)
        Me.Seperator1.Name = "Seperator1"
        Me.Seperator1.NoRounding = False
        Me.Seperator1.Size = New System.Drawing.Size(496, 10)
        Me.Seperator1.TabIndex = 23
        '
        'seperatorA
        '
        Me.seperatorA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.seperatorA.BackColor = System.Drawing.Color.White
        Me.seperatorA.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.seperatorA.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.seperatorA.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.seperatorA.Image = Nothing
        Me.seperatorA.Location = New System.Drawing.Point(8, 64)
        Me.seperatorA.Name = "seperatorA"
        Me.seperatorA.NoRounding = False
        Me.seperatorA.Size = New System.Drawing.Size(496, 10)
        Me.seperatorA.TabIndex = 22
        '
        'chkReplies
        '
        Me.chkReplies.AutoSize = True
        Me.chkReplies.Location = New System.Drawing.Point(12, 74)
        Me.chkReplies.Name = "chkReplies"
        Me.chkReplies.Size = New System.Drawing.Size(95, 17)
        Me.chkReplies.TabIndex = 21
        Me.chkReplies.Text = "Include replies"
        Me.chkReplies.UseVisualStyleBackColor = True
        '
        'lstComments
        '
        Me.lstComments.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstComments.AllowColumnReorder = True
        Me.lstComments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstComments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Author, Me.Content, Me.Time})
        Me.lstComments.FullRowSelect = True
        Me.lstComments.GridLines = True
        Me.lstComments.Location = New System.Drawing.Point(12, 140)
        Me.lstComments.Name = "lstComments"
        Me.lstComments.Size = New System.Drawing.Size(488, 212)
        Me.lstComments.TabIndex = 20
        Me.lstComments.UseCompatibleStateImageBehavior = False
        Me.lstComments.View = System.Windows.Forms.View.Details
        '
        'Author
        '
        Me.Author.Text = "Author"
        Me.Author.Width = 76
        '
        'Content
        '
        Me.Content.Text = "Content"
        Me.Content.Width = 278
        '
        'Time
        '
        Me.Time.Text = "Time"
        Me.Time.Width = 100
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Image = Nothing
        Me.btnStart.Location = New System.Drawing.Point(12, 358)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.NoRounding = False
        Me.btnStart.Size = New System.Drawing.Size(488, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        '
        'txtPath
        '
        Me.txtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.Location = New System.Drawing.Point(12, 40)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(488, 21)
        Me.txtPath.TabIndex = 12
        '
        'BW
        '
        Me.BW.WorkerSupportsCancellation = True
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Clear list"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Export list"
        '
        'frmCommentScraper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 393)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCommentScraper"
        Me.Text = "Tubenoia — Comment Scraper"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        CType(Me.Comments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnStart As Tubenoia.NButton
    Friend WithEvents chkReplies As System.Windows.Forms.CheckBox
    Friend WithEvents lstComments As System.Windows.Forms.ListView
    Friend WithEvents Author As System.Windows.Forms.ColumnHeader
    Friend WithEvents Content As System.Windows.Forms.ColumnHeader
    Friend WithEvents Time As System.Windows.Forms.ColumnHeader
    Friend WithEvents Seperator1 As Tubenoia.Seperator
    Friend WithEvents seperatorA As Tubenoia.Seperator
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents Seperator2 As Tubenoia.Seperator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Comments As System.Windows.Forms.NumericUpDown
End Class
