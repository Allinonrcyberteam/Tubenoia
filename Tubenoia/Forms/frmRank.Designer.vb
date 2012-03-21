<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRank
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRank))
        Me.IL = New System.Windows.Forms.ImageList(Me.components)
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.Theme = New Tubenoia.NTheme()
        Me.btnChkList = New Tubenoia.NButton()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New Tubenoia.NButton()
        Me.Pages = New System.Windows.Forms.NumericUpDown()
        Me.Log = New Tubenoia.ListViewEmbeddedControls.ListViewEx()
        Me.ICO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RANK = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.KWS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VIDEO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSearch = New Tubenoia.NButton()
        Me.txtVideo = New System.Windows.Forms.TextBox()
        Me.txtKeywords = New System.Windows.Forms.TextBox()
        Me.Theme.SuspendLayout()
        CType(Me.Pages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IL
        '
        Me.IL.ImageStream = CType(resources.GetObject("IL.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IL.TransparentColor = System.Drawing.Color.Transparent
        Me.IL.Images.SetKeyName(0, "flag.png")
        Me.IL.Images.SetKeyName(1, "tag.png")
        Me.IL.Images.SetKeyName(2, "showreel.png")
        Me.IL.Images.SetKeyName(3, "star.png")
        Me.IL.Images.SetKeyName(4, "lock.png")
        Me.IL.Images.SetKeyName(5, "busy.png")
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem5, Me.MenuItem3, Me.MenuItem4, Me.MenuItem6, Me.MenuItem7})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Delete"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Select All"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Text = "Export List"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.Text = "Clear List"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8, Me.MenuItem9})
        Me.MenuItem7.Text = "Open"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 0
        Me.MenuItem8.Text = "Result page"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 1
        Me.MenuItem9.Text = "Video page"
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.btnChkList)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.Pages)
        Me.Theme.Controls.Add(Me.Log)
        Me.Theme.Controls.Add(Me.btnSearch)
        Me.Theme.Controls.Add(Me.txtVideo)
        Me.Theme.Controls.Add(Me.txtKeywords)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Theme.ForeColor = System.Drawing.Color.White
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 14
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(599, 489)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Rank Checker"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'btnChkList
        '
        Me.btnChkList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChkList.Image = Nothing
        Me.btnChkList.Location = New System.Drawing.Point(12, 147)
        Me.btnChkList.Name = "btnChkList"
        Me.btnChkList.NoRounding = False
        Me.btnChkList.Size = New System.Drawing.Size(575, 23)
        Me.btnChkList.TabIndex = 1005
        Me.btnChkList.Text = "Check a list"
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(549, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 8
        Me.btnMinimize.Text = "_"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1004
        Me.Label1.Text = "Maximum pages:"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(571, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "X"
        '
        'Pages
        '
        Me.Pages.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pages.BackColor = System.Drawing.Color.White
        Me.Pages.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Pages.Location = New System.Drawing.Point(105, 92)
        Me.Pages.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.Pages.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Pages.Name = "Pages"
        Me.Pages.Size = New System.Drawing.Size(482, 21)
        Me.Pages.TabIndex = 1003
        Me.Pages.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Log
        '
        Me.Log.AllowColumnReorder = True
        Me.Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Log.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ICO, Me.RANK, Me.KWS, Me.VIDEO})
        Me.Log.FullRowSelect = True
        Me.Log.GridLines = True
        Me.Log.Location = New System.Drawing.Point(12, 176)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(575, 301)
        Me.Log.SmallImageList = Me.IL
        Me.Log.TabIndex = 1001
        Me.Log.UseCompatibleStateImageBehavior = False
        Me.Log.View = System.Windows.Forms.View.Details
        '
        'ICO
        '
        Me.ICO.Text = ""
        Me.ICO.Width = 24
        '
        'RANK
        '
        Me.RANK.Text = "Rank"
        Me.RANK.Width = 161
        '
        'KWS
        '
        Me.KWS.Text = "Keywords"
        Me.KWS.Width = 117
        '
        'VIDEO
        '
        Me.VIDEO.Text = "Video"
        Me.VIDEO.Width = 247
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Image = Nothing
        Me.btnSearch.Location = New System.Drawing.Point(12, 118)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.NoRounding = False
        Me.btnSearch.Size = New System.Drawing.Size(575, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'txtVideo
        '
        Me.txtVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVideo.BackColor = System.Drawing.Color.White
        Me.txtVideo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtVideo.Location = New System.Drawing.Point(12, 38)
        Me.txtVideo.Name = "txtVideo"
        Me.txtVideo.Size = New System.Drawing.Size(575, 21)
        Me.txtVideo.TabIndex = 1000
        '
        'txtKeywords
        '
        Me.txtKeywords.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeywords.BackColor = System.Drawing.Color.White
        Me.txtKeywords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtKeywords.Location = New System.Drawing.Point(12, 65)
        Me.txtKeywords.Name = "txtKeywords"
        Me.txtKeywords.Size = New System.Drawing.Size(575, 21)
        Me.txtKeywords.TabIndex = 999
        '
        'frmRank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 489)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRank"
        Me.Text = "Tubenoia — Rank Gatherer"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        CType(Me.Pages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.ntheme
    Friend WithEvents txtKeywords As System.Windows.Forms.TextBox
    Friend WithEvents txtVideo As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As Tubenoia.nbutton
    Friend WithEvents Log As Tubenoia.ListViewEmbeddedControls.ListViewEx
    Friend WithEvents RANK As System.Windows.Forms.ColumnHeader
    Friend WithEvents VIDEO As System.Windows.Forms.ColumnHeader
    Friend WithEvents ICO As System.Windows.Forms.ColumnHeader
    Friend WithEvents IL As System.Windows.Forms.ImageList
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMinimize As Tubenoia.nbutton
    Friend WithEvents btnExit As Tubenoia.nbutton
    Friend WithEvents KWS As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnChkList As Tubenoia.nbutton
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents Pages As NumericUpDown
End Class
