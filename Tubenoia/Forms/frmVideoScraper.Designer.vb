<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVideoScraper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVideoScraper))
        Me.Theme = New Tubenoia.NTheme()
        Me.Seperator3 = New Tubenoia.Seperator()
        Me.btnCommentScraper = New Tubenoia.ButtonPane()
        Me.Seperator2 = New Tubenoia.Seperator()
        Me.btnScrapeViral = New Tubenoia.ButtonPane()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.Seperator1 = New Tubenoia.Seperator()
        Me.btnVideoScraperChannel = New Tubenoia.ButtonPane()
        Me.seperatorA = New Tubenoia.Seperator()
        Me.btnVideoScraperTop = New Tubenoia.ButtonPane()
        Me.btnVideoScraperKeywords = New Tubenoia.ButtonPane()
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.Seperator3)
        Me.Theme.Controls.Add(Me.btnCommentScraper)
        Me.Theme.Controls.Add(Me.Seperator2)
        Me.Theme.Controls.Add(Me.btnScrapeViral)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.Seperator1)
        Me.Theme.Controls.Add(Me.btnVideoScraperChannel)
        Me.Theme.Controls.Add(Me.seperatorA)
        Me.Theme.Controls.Add(Me.btnVideoScraperTop)
        Me.Theme.Controls.Add(Me.btnVideoScraperKeywords)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.White
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 14
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = False
        Me.Theme.Size = New System.Drawing.Size(325, 313)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Video Scraper"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'Seperator3
        '
        Me.Seperator3.BackColor = System.Drawing.Color.White
        Me.Seperator3.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator3.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator3.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator3.Image = Nothing
        Me.Seperator3.Location = New System.Drawing.Point(9, 247)
        Me.Seperator3.Name = "Seperator3"
        Me.Seperator3.NoRounding = False
        Me.Seperator3.Size = New System.Drawing.Size(307, 10)
        Me.Seperator3.TabIndex = 17
        '
        'btnCommentScraper
        '
        Me.btnCommentScraper.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnCommentScraper.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnCommentScraper.Color1A = System.Drawing.Color.White
        Me.btnCommentScraper.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnCommentScraper.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCommentScraper.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnCommentScraper.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommentScraper.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommentScraper.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommentScraper.Image = CType(resources.GetObject("btnCommentScraper.Image"), System.Drawing.Image)
        Me.btnCommentScraper.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCommentScraper.Location = New System.Drawing.Point(12, 257)
        Me.btnCommentScraper.Name = "btnCommentScraper"
        Me.btnCommentScraper.NoGradient = False
        Me.btnCommentScraper.NoRounding = False
        Me.btnCommentScraper.Selection = True
        Me.btnCommentScraper.SelectionToggle = False
        Me.btnCommentScraper.Size = New System.Drawing.Size(302, 45)
        Me.btnCommentScraper.TabIndex = 18
        Me.btnCommentScraper.Text = "btnCommentScraper"
        Me.btnCommentScraper.Text1 = "Comment Scraper"
        Me.btnCommentScraper.Text2 = "scrape comments off videos"
        Me.btnCommentScraper.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnCommentScraper.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'Seperator2
        '
        Me.Seperator2.BackColor = System.Drawing.Color.White
        Me.Seperator2.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator2.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator2.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator2.Image = Nothing
        Me.Seperator2.Location = New System.Drawing.Point(9, 192)
        Me.Seperator2.Name = "Seperator2"
        Me.Seperator2.NoRounding = False
        Me.Seperator2.Size = New System.Drawing.Size(307, 10)
        Me.Seperator2.TabIndex = 15
        '
        'btnScrapeViral
        '
        Me.btnScrapeViral.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnScrapeViral.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnScrapeViral.Color1A = System.Drawing.Color.White
        Me.btnScrapeViral.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnScrapeViral.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnScrapeViral.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnScrapeViral.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScrapeViral.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScrapeViral.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScrapeViral.Image = CType(resources.GetObject("btnScrapeViral.Image"), System.Drawing.Image)
        Me.btnScrapeViral.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnScrapeViral.Location = New System.Drawing.Point(12, 202)
        Me.btnScrapeViral.Name = "btnScrapeViral"
        Me.btnScrapeViral.NoGradient = False
        Me.btnScrapeViral.NoRounding = False
        Me.btnScrapeViral.Selection = True
        Me.btnScrapeViral.SelectionToggle = False
        Me.btnScrapeViral.Size = New System.Drawing.Size(302, 45)
        Me.btnScrapeViral.TabIndex = 16
        Me.btnScrapeViral.Text = "btnScrapeViral"
        Me.btnScrapeViral.Text1 = "About to go viral"
        Me.btnScrapeViral.Text2 = "get the most shared within 24 hours"
        Me.btnScrapeViral.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnScrapeViral.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(275, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 14
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(297, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "X"
        '
        'Seperator1
        '
        Me.Seperator1.BackColor = System.Drawing.Color.White
        Me.Seperator1.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator1.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator1.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator1.Image = Nothing
        Me.Seperator1.Location = New System.Drawing.Point(8, 137)
        Me.Seperator1.Name = "Seperator1"
        Me.Seperator1.NoRounding = False
        Me.Seperator1.Size = New System.Drawing.Size(307, 10)
        Me.Seperator1.TabIndex = 11
        '
        'btnVideoScraperChannel
        '
        Me.btnVideoScraperChannel.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnVideoScraperChannel.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnVideoScraperChannel.Color1A = System.Drawing.Color.White
        Me.btnVideoScraperChannel.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnVideoScraperChannel.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVideoScraperChannel.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnVideoScraperChannel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoScraperChannel.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoScraperChannel.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoScraperChannel.Image = CType(resources.GetObject("btnVideoScraperChannel.Image"), System.Drawing.Image)
        Me.btnVideoScraperChannel.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVideoScraperChannel.Location = New System.Drawing.Point(12, 147)
        Me.btnVideoScraperChannel.Name = "btnVideoScraperChannel"
        Me.btnVideoScraperChannel.NoGradient = False
        Me.btnVideoScraperChannel.NoRounding = False
        Me.btnVideoScraperChannel.Selection = True
        Me.btnVideoScraperChannel.SelectionToggle = False
        Me.btnVideoScraperChannel.Size = New System.Drawing.Size(302, 45)
        Me.btnVideoScraperChannel.TabIndex = 12
        Me.btnVideoScraperChannel.Text = "btnVideoScraperChannel"
        Me.btnVideoScraperChannel.Text1 = "From channel"
        Me.btnVideoScraperChannel.Text2 = "scrape all videos of a user"
        Me.btnVideoScraperChannel.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnVideoScraperChannel.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'seperatorA
        '
        Me.seperatorA.BackColor = System.Drawing.Color.White
        Me.seperatorA.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.seperatorA.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.seperatorA.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.seperatorA.Image = Nothing
        Me.seperatorA.Location = New System.Drawing.Point(8, 82)
        Me.seperatorA.Name = "seperatorA"
        Me.seperatorA.NoRounding = False
        Me.seperatorA.Size = New System.Drawing.Size(308, 10)
        Me.seperatorA.TabIndex = 9
        '
        'btnVideoScraperTop
        '
        Me.btnVideoScraperTop.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnVideoScraperTop.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnVideoScraperTop.Color1A = System.Drawing.Color.White
        Me.btnVideoScraperTop.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnVideoScraperTop.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVideoScraperTop.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnVideoScraperTop.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoScraperTop.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoScraperTop.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoScraperTop.Image = CType(resources.GetObject("btnVideoScraperTop.Image"), System.Drawing.Image)
        Me.btnVideoScraperTop.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVideoScraperTop.Location = New System.Drawing.Point(12, 37)
        Me.btnVideoScraperTop.Name = "btnVideoScraperTop"
        Me.btnVideoScraperTop.NoGradient = False
        Me.btnVideoScraperTop.NoRounding = False
        Me.btnVideoScraperTop.Selection = True
        Me.btnVideoScraperTop.SelectionToggle = False
        Me.btnVideoScraperTop.Size = New System.Drawing.Size(302, 45)
        Me.btnVideoScraperTop.TabIndex = 5
        Me.btnVideoScraperTop.Text = "btnVideoScraperTop"
        Me.btnVideoScraperTop.Text1 = "From top lists"
        Me.btnVideoScraperTop.Text2 = "most viewed, discussed, viewed, favorited"
        Me.btnVideoScraperTop.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnVideoScraperTop.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnVideoScraperKeywords
        '
        Me.btnVideoScraperKeywords.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnVideoScraperKeywords.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnVideoScraperKeywords.Color1A = System.Drawing.Color.White
        Me.btnVideoScraperKeywords.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnVideoScraperKeywords.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVideoScraperKeywords.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnVideoScraperKeywords.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoScraperKeywords.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoScraperKeywords.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoScraperKeywords.Image = CType(resources.GetObject("btnVideoScraperKeywords.Image"), System.Drawing.Image)
        Me.btnVideoScraperKeywords.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVideoScraperKeywords.Location = New System.Drawing.Point(12, 92)
        Me.btnVideoScraperKeywords.Name = "btnVideoScraperKeywords"
        Me.btnVideoScraperKeywords.NoGradient = False
        Me.btnVideoScraperKeywords.NoRounding = False
        Me.btnVideoScraperKeywords.Selection = True
        Me.btnVideoScraperKeywords.SelectionToggle = False
        Me.btnVideoScraperKeywords.Size = New System.Drawing.Size(302, 45)
        Me.btnVideoScraperKeywords.TabIndex = 10
        Me.btnVideoScraperKeywords.Text = "btnVideoScraperKeywords"
        Me.btnVideoScraperKeywords.Text1 = "From keywords"
        Me.btnVideoScraperKeywords.Text2 = "search for related videos"
        Me.btnVideoScraperKeywords.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnVideoScraperKeywords.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'frmVideoScraper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 313)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVideoScraper"
        Me.Text = "Tubenoia — Video Scraper"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.ntheme
    Friend WithEvents btnVideoScraperTop As Tubenoia.ButtonPane
    Friend WithEvents Seperator1 As Tubenoia.Seperator
    Friend WithEvents btnVideoScraperChannel As Tubenoia.ButtonPane
    Friend WithEvents seperatorA As Tubenoia.Seperator
    Friend WithEvents btnVideoScraperKeywords As Tubenoia.ButtonPane
    Friend WithEvents btnMinimize As Tubenoia.nbutton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents Seperator2 As Tubenoia.Seperator
    Friend WithEvents btnScrapeViral As Tubenoia.ButtonPane
    Friend WithEvents Seperator3 As Tubenoia.Seperator
    Friend WithEvents btnCommentScraper As Tubenoia.ButtonPane
End Class
