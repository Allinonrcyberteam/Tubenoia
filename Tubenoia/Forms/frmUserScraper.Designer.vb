<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserScraper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserScraper))
        Me.Theme = New Tubenoia.NTheme()
        Me.Seperator2 = New Tubenoia.Seperator()
        Me.btnUserFromAny = New Tubenoia.ButtonPane()
        Me.Seperator1 = New Tubenoia.Seperator()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnUserFromSubscribers = New Tubenoia.ButtonPane()
        Me.btnExit = New Tubenoia.NButton()
        Me.seperatorA = New Tubenoia.Seperator()
        Me.btnUserFromComment = New Tubenoia.ButtonPane()
        Me.btnUserFromFriends = New Tubenoia.ButtonPane()
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.Seperator2)
        Me.Theme.Controls.Add(Me.btnUserFromAny)
        Me.Theme.Controls.Add(Me.Seperator1)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnUserFromSubscribers)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.seperatorA)
        Me.Theme.Controls.Add(Me.btnUserFromComment)
        Me.Theme.Controls.Add(Me.btnUserFromFriends)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.White
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 14
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = False
        Me.Theme.Size = New System.Drawing.Size(325, 263)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — User Scraper"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'Seperator2
        '
        Me.Seperator2.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator2.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator2.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator2.Image = Nothing
        Me.Seperator2.Location = New System.Drawing.Point(8, 194)
        Me.Seperator2.Name = "Seperator2"
        Me.Seperator2.NoRounding = False
        Me.Seperator2.Size = New System.Drawing.Size(308, 10)
        Me.Seperator2.TabIndex = 18
        '
        'btnUserFromAny
        '
        Me.btnUserFromAny.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnUserFromAny.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUserFromAny.Color1A = System.Drawing.Color.White
        Me.btnUserFromAny.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnUserFromAny.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserFromAny.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUserFromAny.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserFromAny.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserFromAny.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserFromAny.Image = CType(resources.GetObject("btnUserFromAny.Image"), System.Drawing.Image)
        Me.btnUserFromAny.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserFromAny.Location = New System.Drawing.Point(12, 205)
        Me.btnUserFromAny.Name = "btnUserFromAny"
        Me.btnUserFromAny.NoGradient = False
        Me.btnUserFromAny.NoRounding = False
        Me.btnUserFromAny.Selection = True
        Me.btnUserFromAny.SelectionToggle = False
        Me.btnUserFromAny.Size = New System.Drawing.Size(302, 45)
        Me.btnUserFromAny.TabIndex = 19
        Me.btnUserFromAny.Text = "btnUserFromAny"
        Me.btnUserFromAny.Text1 = "From any page"
        Me.btnUserFromAny.Text2 = "scrape from a custom page (any)"
        Me.btnUserFromAny.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnUserFromAny.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'Seperator1
        '
        Me.Seperator1.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator1.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator1.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator1.Image = Nothing
        Me.Seperator1.Location = New System.Drawing.Point(8, 138)
        Me.Seperator1.Name = "Seperator1"
        Me.Seperator1.NoRounding = False
        Me.Seperator1.Size = New System.Drawing.Size(308, 10)
        Me.Seperator1.TabIndex = 16
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
        Me.btnMinimize.TabIndex = 16
        Me.btnMinimize.Text = "_"
        '
        'btnUserFromSubscribers
        '
        Me.btnUserFromSubscribers.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnUserFromSubscribers.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUserFromSubscribers.Color1A = System.Drawing.Color.White
        Me.btnUserFromSubscribers.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnUserFromSubscribers.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserFromSubscribers.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUserFromSubscribers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserFromSubscribers.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserFromSubscribers.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserFromSubscribers.Image = CType(resources.GetObject("btnUserFromSubscribers.Image"), System.Drawing.Image)
        Me.btnUserFromSubscribers.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserFromSubscribers.Location = New System.Drawing.Point(12, 149)
        Me.btnUserFromSubscribers.Name = "btnUserFromSubscribers"
        Me.btnUserFromSubscribers.NoGradient = False
        Me.btnUserFromSubscribers.NoRounding = False
        Me.btnUserFromSubscribers.Selection = True
        Me.btnUserFromSubscribers.SelectionToggle = False
        Me.btnUserFromSubscribers.Size = New System.Drawing.Size(302, 45)
        Me.btnUserFromSubscribers.TabIndex = 17
        Me.btnUserFromSubscribers.Text = "btnUserFromSubscribers"
        Me.btnUserFromSubscribers.Text1 = "From subscribers"
        Me.btnUserFromSubscribers.Text2 = "scrape from a users subscriber list"
        Me.btnUserFromSubscribers.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnUserFromSubscribers.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
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
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "X"
        '
        'seperatorA
        '
        Me.seperatorA.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.seperatorA.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.seperatorA.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.seperatorA.Image = Nothing
        Me.seperatorA.Location = New System.Drawing.Point(8, 82)
        Me.seperatorA.Name = "seperatorA"
        Me.seperatorA.NoRounding = False
        Me.seperatorA.Size = New System.Drawing.Size(308, 10)
        Me.seperatorA.TabIndex = 14
        '
        'btnUserFromComment
        '
        Me.btnUserFromComment.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnUserFromComment.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUserFromComment.Color1A = System.Drawing.Color.White
        Me.btnUserFromComment.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnUserFromComment.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserFromComment.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUserFromComment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserFromComment.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserFromComment.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserFromComment.Image = CType(resources.GetObject("btnUserFromComment.Image"), System.Drawing.Image)
        Me.btnUserFromComment.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserFromComment.Location = New System.Drawing.Point(12, 37)
        Me.btnUserFromComment.Name = "btnUserFromComment"
        Me.btnUserFromComment.NoGradient = False
        Me.btnUserFromComment.NoRounding = False
        Me.btnUserFromComment.Selection = True
        Me.btnUserFromComment.SelectionToggle = False
        Me.btnUserFromComment.Size = New System.Drawing.Size(302, 45)
        Me.btnUserFromComment.TabIndex = 13
        Me.btnUserFromComment.Text = "btnUserFromComment"
        Me.btnUserFromComment.Text1 = "From comments"
        Me.btnUserFromComment.Text2 = "scrape users from comments"
        Me.btnUserFromComment.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnUserFromComment.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnUserFromFriends
        '
        Me.btnUserFromFriends.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnUserFromFriends.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUserFromFriends.Color1A = System.Drawing.Color.White
        Me.btnUserFromFriends.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnUserFromFriends.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserFromFriends.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUserFromFriends.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserFromFriends.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserFromFriends.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserFromFriends.Image = CType(resources.GetObject("btnUserFromFriends.Image"), System.Drawing.Image)
        Me.btnUserFromFriends.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserFromFriends.Location = New System.Drawing.Point(12, 93)
        Me.btnUserFromFriends.Name = "btnUserFromFriends"
        Me.btnUserFromFriends.NoGradient = False
        Me.btnUserFromFriends.NoRounding = False
        Me.btnUserFromFriends.Selection = True
        Me.btnUserFromFriends.SelectionToggle = False
        Me.btnUserFromFriends.Size = New System.Drawing.Size(302, 45)
        Me.btnUserFromFriends.TabIndex = 15
        Me.btnUserFromFriends.Text = "btnUserFromFriends"
        Me.btnUserFromFriends.Text1 = "From friends"
        Me.btnUserFromFriends.Text2 = "scrape from a users friend list"
        Me.btnUserFromFriends.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnUserFromFriends.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'frmUserScraper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 263)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUserScraper"
        Me.Text = "Tubenoia — User Scraper"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.ntheme
    Friend WithEvents btnMinimize As Tubenoia.nbutton
    Friend WithEvents btnExit As Tubenoia.nbutton
    Friend WithEvents Seperator1 As Tubenoia.Seperator
    Friend WithEvents btnUserFromSubscribers As Tubenoia.ButtonPane
    Friend WithEvents seperatorA As Tubenoia.Seperator
    Friend WithEvents btnUserFromComment As Tubenoia.ButtonPane
    Friend WithEvents btnUserFromFriends As Tubenoia.ButtonPane
    Friend WithEvents Seperator2 As Tubenoia.Seperator
    Friend WithEvents btnUserFromAny As Tubenoia.ButtonPane
End Class
