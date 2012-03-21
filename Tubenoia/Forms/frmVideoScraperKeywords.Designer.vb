<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVideoScraperKeywords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVideoScraperKeywords))
        Me.Theme = New Tubenoia.NTheme()
        Me.btnHelp = New Tubenoia.NButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Results = New System.Windows.Forms.NumericUpDown()
        Me.cbOrderby = New System.Windows.Forms.ComboBox()
        Me.btnScrape = New Tubenoia.NButton()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.lstVideos = New System.Windows.Forms.ListView()
        Me.URL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TITLE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtKeywords = New System.Windows.Forms.TextBox()
        Me.btnExit = New Tubenoia.NButton()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.lstMenu = New System.Windows.Forms.ContextMenu()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.TT1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Theme.SuspendLayout()
        CType(Me.Results, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.btnHelp)
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Controls.Add(Me.Results)
        Me.Theme.Controls.Add(Me.cbOrderby)
        Me.Theme.Controls.Add(Me.btnScrape)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.lstVideos)
        Me.Theme.Controls.Add(Me.txtKeywords)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.White
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 14
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(510, 535)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Video Scraper — From keywords"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.Location = New System.Drawing.Point(360, 37)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.NoRounding = False
        Me.btnHelp.Size = New System.Drawing.Size(28, 21)
        Me.btnHelp.TabIndex = 1011
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 1010
        Me.Label1.Text = "Maximum results:"
        '
        'Results
        '
        Me.Results.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Results.BackColor = System.Drawing.Color.White
        Me.Results.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Results.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.Results.Location = New System.Drawing.Point(102, 93)
        Me.Results.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Results.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.Results.Name = "Results"
        Me.Results.Size = New System.Drawing.Size(396, 21)
        Me.Results.TabIndex = 1009
        Me.Results.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'cbOrderby
        '
        Me.cbOrderby.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOrderby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrderby.FormattingEnabled = True
        Me.cbOrderby.Items.AddRange(New Object() {"Relevance", "Published", "View count", "Rating"})
        Me.cbOrderby.Location = New System.Drawing.Point(394, 37)
        Me.cbOrderby.Name = "cbOrderby"
        Me.cbOrderby.Size = New System.Drawing.Size(104, 21)
        Me.cbOrderby.TabIndex = 1007
        '
        'btnScrape
        '
        Me.btnScrape.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnScrape.Image = Nothing
        Me.btnScrape.Location = New System.Drawing.Point(12, 64)
        Me.btnScrape.Name = "btnScrape"
        Me.btnScrape.NoRounding = False
        Me.btnScrape.Size = New System.Drawing.Size(486, 23)
        Me.btnScrape.TabIndex = 1005
        Me.btnScrape.Text = "Scrape"
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(460, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 8
        Me.btnMinimize.Text = "_"
        '
        'lstVideos
        '
        Me.lstVideos.AllowColumnReorder = True
        Me.lstVideos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstVideos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.URL, Me.TITLE})
        Me.lstVideos.FullRowSelect = True
        Me.lstVideos.GridLines = True
        Me.lstVideos.Location = New System.Drawing.Point(12, 120)
        Me.lstVideos.Name = "lstVideos"
        Me.lstVideos.Size = New System.Drawing.Size(486, 403)
        Me.lstVideos.TabIndex = 1006
        Me.lstVideos.UseCompatibleStateImageBehavior = False
        Me.lstVideos.View = System.Windows.Forms.View.Details
        '
        'URL
        '
        Me.URL.Text = "URL"
        Me.URL.Width = 108
        '
        'TITLE
        '
        Me.TITLE.Text = "TITLE"
        Me.TITLE.Width = 332
        '
        'txtKeywords
        '
        Me.txtKeywords.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeywords.BackColor = System.Drawing.Color.White
        Me.txtKeywords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtKeywords.Location = New System.Drawing.Point(12, 37)
        Me.txtKeywords.Name = "txtKeywords"
        Me.txtKeywords.Size = New System.Drawing.Size(342, 21)
        Me.txtKeywords.TabIndex = 1004
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(482, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "X"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Select All"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Clear List"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Delete"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Export List"
        '
        'lstMenu
        '
        Me.lstMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5})
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "Watch"
        '
        'frmVideoScraperKeywords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 535)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVideoScraperKeywords"
        Me.Text = "Tubenoia — Video Scraper — From keywords"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        CType(Me.Results, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.ntheme
    Friend WithEvents btnMinimize As Tubenoia.nbutton
    Friend WithEvents btnExit As Tubenoia.nbutton
    Friend WithEvents btnScrape As Tubenoia.nbutton
    Friend WithEvents lstVideos As System.Windows.Forms.ListView
    Friend WithEvents URL As System.Windows.Forms.ColumnHeader
    Friend WithEvents TITLE As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtKeywords As System.Windows.Forms.TextBox
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents lstMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents cbOrderby As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Results As NumericUpDown
    Friend WithEvents TT1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnHelp As Tubenoia.NButton
End Class
