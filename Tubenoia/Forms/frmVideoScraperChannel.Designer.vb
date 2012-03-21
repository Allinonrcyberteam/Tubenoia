<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVideoScraperChannel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVideoScraperChannel))
        Me.Theme = New Tubenoia.NTheme()
        Me.lstVideos = New System.Windows.Forms.ListView()
        Me.URL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TITLE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnScrape = New Tubenoia.NButton()
        Me.txtChannel = New System.Windows.Forms.TextBox()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.lstMenu = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.lstVideos)
        Me.Theme.Controls.Add(Me.btnScrape)
        Me.Theme.Controls.Add(Me.txtChannel)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.White
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 14
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(510, 398)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Video Scraper — From channel"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
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
        Me.lstVideos.Location = New System.Drawing.Point(12, 93)
        Me.lstVideos.Name = "lstVideos"
        Me.lstVideos.Size = New System.Drawing.Size(486, 293)
        Me.lstVideos.TabIndex = 1003
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
        'btnScrape
        '
        Me.btnScrape.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnScrape.Image = Nothing
        Me.btnScrape.Location = New System.Drawing.Point(12, 64)
        Me.btnScrape.Name = "btnScrape"
        Me.btnScrape.NoRounding = False
        Me.btnScrape.Size = New System.Drawing.Size(486, 23)
        Me.btnScrape.TabIndex = 1002
        Me.btnScrape.Text = "Scrape"
        '
        'txtChannel
        '
        Me.txtChannel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChannel.BackColor = System.Drawing.Color.White
        Me.txtChannel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtChannel.Location = New System.Drawing.Point(12, 37)
        Me.txtChannel.Name = "txtChannel"
        Me.txtChannel.Size = New System.Drawing.Size(486, 21)
        Me.txtChannel.TabIndex = 1001
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
        'frmVideoScraperChannel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 398)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVideoScraperChannel"
        Me.Text = "Tubenoia — Video Scraper — From channel"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.ntheme
    Friend WithEvents btnMinimize As Tubenoia.nbutton
    Friend WithEvents btnExit As Tubenoia.nbutton
    Friend WithEvents txtChannel As System.Windows.Forms.TextBox
    Friend WithEvents btnScrape As Tubenoia.nbutton
    Friend WithEvents lstVideos As System.Windows.Forms.ListView
    Friend WithEvents URL As System.Windows.Forms.ColumnHeader
    Friend WithEvents TITLE As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
End Class
