<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVideoScraperTop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVideoScraperTop))
        Me.lstVideos = New System.Windows.Forms.ListView()
        Me.URL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TITLE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstMenu = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.Theme = New Tubenoia.NTheme()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.Results = New System.Windows.Forms.NumericUpDown()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.btnExit = New Tubenoia.NButton()
        Me.btnGather = New Tubenoia.NButton()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.cbTimespan = New System.Windows.Forms.ComboBox()
        Me.lblTimestamp = New System.Windows.Forms.Label()
        Me.Theme.SuspendLayout()
        CType(Me.Results, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lstVideos.Location = New System.Drawing.Point(12, 146)
        Me.lstVideos.Name = "lstVideos"
        Me.lstVideos.Size = New System.Drawing.Size(486, 379)
        Me.lstVideos.TabIndex = 6
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
        'lstMenu
        '
        Me.lstMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5})
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
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Clear List"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Export List"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "Watch"
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.Results)
        Me.Theme.Controls.Add(Me.lblCategory)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.btnGather)
        Me.Theme.Controls.Add(Me.cbCategory)
        Me.Theme.Controls.Add(Me.cbTimespan)
        Me.Theme.Controls.Add(Me.lblTimestamp)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Theme.ForeColor = System.Drawing.Color.White
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 14
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(510, 537)
        Me.Theme.TabIndex = 12
        Me.Theme.Text = "   Tubenoia — Video Scraper — From top results"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 1012
        Me.Label1.Text = "Maximum results:"
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
        Me.btnMinimize.TabIndex = 14
        Me.btnMinimize.Text = "_"
        '
        'Results
        '
        Me.Results.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Results.BackColor = System.Drawing.Color.White
        Me.Results.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Results.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.Results.Location = New System.Drawing.Point(102, 90)
        Me.Results.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Results.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.Results.Name = "Results"
        Me.Results.Size = New System.Drawing.Size(396, 21)
        Me.Results.TabIndex = 1011
        Me.Results.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.lblCategory.Location = New System.Drawing.Point(14, 66)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(56, 13)
        Me.lblCategory.TabIndex = 11
        Me.lblCategory.Text = "Category:"
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
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "X"
        '
        'btnGather
        '
        Me.btnGather.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGather.Image = Nothing
        Me.btnGather.Location = New System.Drawing.Point(12, 117)
        Me.btnGather.Name = "btnGather"
        Me.btnGather.NoRounding = False
        Me.btnGather.Size = New System.Drawing.Size(486, 23)
        Me.btnGather.TabIndex = 0
        Me.btnGather.Text = "Gather videos"
        '
        'cbCategory
        '
        Me.cbCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Items.AddRange(New Object() {"Top rated", "Top favorites", "Most viewed", "Most popular", "Most recent", "Most discussed"})
        Me.cbCategory.Location = New System.Drawing.Point(102, 63)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(396, 21)
        Me.cbCategory.TabIndex = 10
        '
        'cbTimespan
        '
        Me.cbTimespan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTimespan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTimespan.FormattingEnabled = True
        Me.cbTimespan.Items.AddRange(New Object() {"Today", "This week", "This month", "All time"})
        Me.cbTimespan.Location = New System.Drawing.Point(102, 38)
        Me.cbTimespan.Name = "cbTimespan"
        Me.cbTimespan.Size = New System.Drawing.Size(396, 21)
        Me.cbTimespan.TabIndex = 7
        '
        'lblTimestamp
        '
        Me.lblTimestamp.AutoSize = True
        Me.lblTimestamp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.lblTimestamp.Location = New System.Drawing.Point(14, 41)
        Me.lblTimestamp.Name = "lblTimestamp"
        Me.lblTimestamp.Size = New System.Drawing.Size(59, 13)
        Me.lblTimestamp.TabIndex = 8
        Me.lblTimestamp.Text = "Time span:"
        '
        'frmVideoScraperTop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 537)
        Me.Controls.Add(Me.lstVideos)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVideoScraperTop"
        Me.Text = "Tubenoia — Video Scraper — From top results"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        CType(Me.Results, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents cbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblTimestamp As System.Windows.Forms.Label
    Friend WithEvents cbTimespan As System.Windows.Forms.ComboBox
    Friend WithEvents lstVideos As System.Windows.Forms.ListView
    Friend WithEvents URL As System.Windows.Forms.ColumnHeader
    Friend WithEvents TITLE As System.Windows.Forms.ColumnHeader
    Friend WithEvents Theme As Tubenoia.ntheme
    Friend WithEvents btnGather As Tubenoia.nbutton
    Friend WithEvents lstMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents btnMinimize As Tubenoia.nbutton
    Friend WithEvents btnExit As Tubenoia.nbutton
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Results As numericupdown
End Class
