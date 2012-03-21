<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVideoFilter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVideoFilter))
        Me.Theme = New Tubenoia.NTheme()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.commentsz = New System.Windows.Forms.NumericUpDown()
        Me.chkComments = New System.Windows.Forms.CheckBox()
        Me.Seperator1 = New Tubenoia.Seperator()
        Me.seperatorA = New Tubenoia.Seperator()
        Me.rYT = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rApi = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.videos = New System.Windows.Forms.NumericUpDown()
        Me.chkRatings = New System.Windows.Forms.CheckBox()
        Me.subs = New System.Windows.Forms.NumericUpDown()
        Me.chkFavs = New System.Windows.Forms.CheckBox()
        Me.friends = New System.Windows.Forms.NumericUpDown()
        Me.chkViews = New System.Windows.Forms.CheckBox()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.lstVideos = New System.Windows.Forms.ListView()
        Me.Video = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.Theme.SuspendLayout()
        CType(Me.commentsz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.videos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.friends, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.Label5)
        Me.Theme.Controls.Add(Me.commentsz)
        Me.Theme.Controls.Add(Me.chkComments)
        Me.Theme.Controls.Add(Me.Seperator1)
        Me.Theme.Controls.Add(Me.seperatorA)
        Me.Theme.Controls.Add(Me.rYT)
        Me.Theme.Controls.Add(Me.Label4)
        Me.Theme.Controls.Add(Me.rApi)
        Me.Theme.Controls.Add(Me.Label3)
        Me.Theme.Controls.Add(Me.Label2)
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Controls.Add(Me.videos)
        Me.Theme.Controls.Add(Me.chkRatings)
        Me.Theme.Controls.Add(Me.subs)
        Me.Theme.Controls.Add(Me.chkFavs)
        Me.Theme.Controls.Add(Me.friends)
        Me.Theme.Controls.Add(Me.chkViews)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.lstVideos)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.White
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 14
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(557, 548)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Video Filter"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(485, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 10065
        Me.Label5.Text = "comments"
        '
        'commentsz
        '
        Me.commentsz.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.commentsz.Enabled = False
        Me.commentsz.Location = New System.Drawing.Point(125, 119)
        Me.commentsz.Maximum = New Decimal(New Integer() {-402653185, -1613725636, 54210108, 0})
        Me.commentsz.Name = "commentsz"
        Me.commentsz.Size = New System.Drawing.Size(351, 21)
        Me.commentsz.TabIndex = 10064
        '
        'chkComments
        '
        Me.chkComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.chkComments.Location = New System.Drawing.Point(13, 121)
        Me.chkComments.Name = "chkComments"
        Me.chkComments.Size = New System.Drawing.Size(116, 17)
        Me.chkComments.TabIndex = 10063
        Me.chkComments.Text = "Video has at least"
        Me.chkComments.UseVisualStyleBackColor = True
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
        Me.Seperator1.Location = New System.Drawing.Point(8, 166)
        Me.Seperator1.Name = "Seperator1"
        Me.Seperator1.NoRounding = False
        Me.Seperator1.Size = New System.Drawing.Size(541, 10)
        Me.Seperator1.TabIndex = 10062
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
        Me.seperatorA.Location = New System.Drawing.Point(8, 140)
        Me.seperatorA.Name = "seperatorA"
        Me.seperatorA.NoRounding = False
        Me.seperatorA.Size = New System.Drawing.Size(541, 10)
        Me.seperatorA.TabIndex = 10061
        '
        'rYT
        '
        Me.rYT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rYT.AutoSize = True
        Me.rYT.BackColor = System.Drawing.Color.White
        Me.rYT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.rYT.Location = New System.Drawing.Point(325, 149)
        Me.rYT.Name = "rYT"
        Me.rYT.Size = New System.Drawing.Size(154, 17)
        Me.rYT.TabIndex = 10056
        Me.rYT.Text = "YouTube (slower, no limits)"
        Me.rYT.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 10055
        Me.Label4.Text = "Get data from:"
        '
        'rApi
        '
        Me.rApi.AutoSize = True
        Me.rApi.BackColor = System.Drawing.Color.White
        Me.rApi.Checked = True
        Me.rApi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.rApi.Location = New System.Drawing.Point(125, 149)
        Me.rApi.Name = "rApi"
        Me.rApi.Size = New System.Drawing.Size(114, 17)
        Me.rApi.TabIndex = 10054
        Me.rApi.TabStop = True
        Me.rApi.Text = "API (Faster, limits)"
        Me.rApi.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(485, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 10053
        Me.Label3.Text = "favorites"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(485, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 10052
        Me.Label2.Text = "ratings"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(485, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 10051
        Me.Label1.Text = "views"
        '
        'videos
        '
        Me.videos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.videos.Enabled = False
        Me.videos.Location = New System.Drawing.Point(125, 92)
        Me.videos.Maximum = New Decimal(New Integer() {-402653185, -1613725636, 54210108, 0})
        Me.videos.Name = "videos"
        Me.videos.Size = New System.Drawing.Size(351, 21)
        Me.videos.TabIndex = 10050
        '
        'chkRatings
        '
        Me.chkRatings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.chkRatings.Location = New System.Drawing.Point(13, 94)
        Me.chkRatings.Name = "chkRatings"
        Me.chkRatings.Size = New System.Drawing.Size(116, 17)
        Me.chkRatings.TabIndex = 10049
        Me.chkRatings.Text = "Video has at least"
        Me.chkRatings.UseVisualStyleBackColor = True
        '
        'subs
        '
        Me.subs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.subs.Enabled = False
        Me.subs.Location = New System.Drawing.Point(125, 67)
        Me.subs.Maximum = New Decimal(New Integer() {-402653185, -1613725636, 54210108, 0})
        Me.subs.Name = "subs"
        Me.subs.Size = New System.Drawing.Size(351, 21)
        Me.subs.TabIndex = 10048
        '
        'chkFavs
        '
        Me.chkFavs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.chkFavs.Location = New System.Drawing.Point(13, 69)
        Me.chkFavs.Name = "chkFavs"
        Me.chkFavs.Size = New System.Drawing.Size(116, 17)
        Me.chkFavs.TabIndex = 10047
        Me.chkFavs.Text = "Video has at least"
        Me.chkFavs.UseVisualStyleBackColor = True
        '
        'friends
        '
        Me.friends.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.friends.Enabled = False
        Me.friends.Location = New System.Drawing.Point(125, 40)
        Me.friends.Maximum = New Decimal(New Integer() {-402653185, -1613725636, 54210108, 0})
        Me.friends.Name = "friends"
        Me.friends.Size = New System.Drawing.Size(351, 21)
        Me.friends.TabIndex = 10046
        '
        'chkViews
        '
        Me.chkViews.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.chkViews.Location = New System.Drawing.Point(13, 42)
        Me.chkViews.Name = "chkViews"
        Me.chkViews.Size = New System.Drawing.Size(116, 17)
        Me.chkViews.TabIndex = 10045
        Me.chkViews.Text = "Video has at least"
        Me.chkViews.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(507, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 10036
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(529, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 10035
        Me.btnExit.Text = "X"
        '
        'lstVideos
        '
        Me.lstVideos.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstVideos.AllowColumnReorder = True
        Me.lstVideos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstVideos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Video, Me.Status})
        Me.lstVideos.FullRowSelect = True
        Me.lstVideos.GridLines = True
        Me.lstVideos.Location = New System.Drawing.Point(11, 182)
        Me.lstVideos.Name = "lstVideos"
        Me.lstVideos.Size = New System.Drawing.Size(534, 355)
        Me.lstVideos.TabIndex = 19
        Me.lstVideos.UseCompatibleStateImageBehavior = False
        Me.lstVideos.View = System.Windows.Forms.View.Details
        '
        'Video
        '
        Me.Video.Text = "Video"
        Me.Video.Width = 316
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 121
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem4, Me.MenuItem1, Me.MenuItem3, Me.MenuItem7, Me.MenuItem10, Me.MenuItem5, Me.MenuItem6, Me.MenuItem8, Me.MenuItem9})
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Start"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 2
        Me.MenuItem1.Text = "Load list"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Text = "Export list"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 4
        Me.MenuItem7.Text = "Clear list"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 5
        Me.MenuItem10.Text = "Remove duplicates"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 6
        Me.MenuItem5.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 7
        Me.MenuItem6.Text = "Remove filtered"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 8
        Me.MenuItem8.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 9
        Me.MenuItem9.Text = "Visit video"
        '
        'frmVideoFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 548)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVideoFilter"
        Me.Text = "Tubenoia — Video Filter"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        CType(Me.commentsz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.videos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.friends, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.ntheme
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents Video As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents lstVideos As System.Windows.Forms.ListView
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents videos As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkRatings As System.Windows.Forms.CheckBox
    Friend WithEvents subs As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkFavs As System.Windows.Forms.CheckBox
    Friend WithEvents friends As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkViews As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents rYT As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rApi As System.Windows.Forms.RadioButton
    Friend WithEvents Seperator1 As Tubenoia.Seperator
    Friend WithEvents seperatorA As Tubenoia.Seperator
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents commentsz As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkComments As System.Windows.Forms.CheckBox
End Class
