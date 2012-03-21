<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTools
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTools))
        Me.Theme = New Tubenoia.NTheme()
        Me.btnVideoChecker = New Tubenoia.ButtonPane()
        Me.Seperator1 = New Tubenoia.Seperator()
        Me.Seperator3 = New Tubenoia.Seperator()
        Me.Seperator4 = New Tubenoia.Seperator()
        Me.btnAvatarScraper = New Tubenoia.ButtonPane()
        Me.btnFE = New Tubenoia.ButtonPane()
        Me.btnPasswordChanger = New Tubenoia.ButtonPane()
        Me.btnAvatarUploader = New Tubenoia.ButtonPane()
        Me.btnAccProxBinder = New Tubenoia.ButtonPane()
        Me.btnProxyScraper = New Tubenoia.ButtonPane()
        Me.Seperator2 = New Tubenoia.Seperator()
        Me.btnCommentRater = New Tubenoia.ButtonPane()
        Me.seperatorA = New Tubenoia.Seperator()
        Me.btnVideoTools = New Tubenoia.ButtonPane()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.btnCommentObfuscator = New Tubenoia.ButtonPane()
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.btnVideoChecker)
        Me.Theme.Controls.Add(Me.Seperator1)
        Me.Theme.Controls.Add(Me.Seperator3)
        Me.Theme.Controls.Add(Me.Seperator4)
        Me.Theme.Controls.Add(Me.btnAvatarScraper)
        Me.Theme.Controls.Add(Me.btnFE)
        Me.Theme.Controls.Add(Me.btnPasswordChanger)
        Me.Theme.Controls.Add(Me.btnAvatarUploader)
        Me.Theme.Controls.Add(Me.btnAccProxBinder)
        Me.Theme.Controls.Add(Me.btnProxyScraper)
        Me.Theme.Controls.Add(Me.Seperator2)
        Me.Theme.Controls.Add(Me.btnCommentRater)
        Me.Theme.Controls.Add(Me.seperatorA)
        Me.Theme.Controls.Add(Me.btnVideoTools)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.btnCommentObfuscator)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 22
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = False
        Me.Theme.Size = New System.Drawing.Size(639, 318)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Tools"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'btnVideoChecker
        '
        Me.btnVideoChecker.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnVideoChecker.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnVideoChecker.Color1A = System.Drawing.Color.White
        Me.btnVideoChecker.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnVideoChecker.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVideoChecker.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnVideoChecker.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoChecker.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoChecker.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoChecker.Image = CType(resources.GetObject("btnVideoChecker.Image"), System.Drawing.Image)
        Me.btnVideoChecker.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVideoChecker.Location = New System.Drawing.Point(324, 260)
        Me.btnVideoChecker.Name = "btnVideoChecker"
        Me.btnVideoChecker.NoGradient = False
        Me.btnVideoChecker.NoRounding = False
        Me.btnVideoChecker.Selection = True
        Me.btnVideoChecker.SelectionToggle = False
        Me.btnVideoChecker.Size = New System.Drawing.Size(302, 45)
        Me.btnVideoChecker.TabIndex = 10013
        Me.btnVideoChecker.Text = "btnVideoChecker"
        Me.btnVideoChecker.Text1 = "Video Checker"
        Me.btnVideoChecker.Text2 = "check mass uploader exported lists stats"
        Me.btnVideoChecker.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnVideoChecker.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
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
        Me.Seperator1.Location = New System.Drawing.Point(8, 138)
        Me.Seperator1.Name = "Seperator1"
        Me.Seperator1.NoRounding = False
        Me.Seperator1.Size = New System.Drawing.Size(623, 10)
        Me.Seperator1.TabIndex = 13
        '
        'Seperator3
        '
        Me.Seperator3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator3.BackColor = System.Drawing.Color.White
        Me.Seperator3.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator3.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator3.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator3.Image = Nothing
        Me.Seperator3.Location = New System.Drawing.Point(8, 250)
        Me.Seperator3.Name = "Seperator3"
        Me.Seperator3.NoRounding = False
        Me.Seperator3.Size = New System.Drawing.Size(623, 10)
        Me.Seperator3.TabIndex = 17
        '
        'Seperator4
        '
        Me.Seperator4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Seperator4.BackColor = System.Drawing.Color.White
        Me.Seperator4.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator4.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator4.Direction = System.Windows.Forms.Orientation.Vertical
        Me.Seperator4.Image = Nothing
        Me.Seperator4.Location = New System.Drawing.Point(314, 38)
        Me.Seperator4.Name = "Seperator4"
        Me.Seperator4.NoRounding = False
        Me.Seperator4.Size = New System.Drawing.Size(10, 272)
        Me.Seperator4.TabIndex = 10012
        '
        'btnAvatarScraper
        '
        Me.btnAvatarScraper.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnAvatarScraper.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnAvatarScraper.Color1A = System.Drawing.Color.White
        Me.btnAvatarScraper.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnAvatarScraper.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAvatarScraper.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnAvatarScraper.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvatarScraper.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvatarScraper.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvatarScraper.Image = CType(resources.GetObject("btnAvatarScraper.Image"), System.Drawing.Image)
        Me.btnAvatarScraper.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAvatarScraper.Location = New System.Drawing.Point(324, 205)
        Me.btnAvatarScraper.Name = "btnAvatarScraper"
        Me.btnAvatarScraper.NoGradient = False
        Me.btnAvatarScraper.NoRounding = False
        Me.btnAvatarScraper.Selection = True
        Me.btnAvatarScraper.SelectionToggle = False
        Me.btnAvatarScraper.Size = New System.Drawing.Size(302, 45)
        Me.btnAvatarScraper.TabIndex = 25
        Me.btnAvatarScraper.Text = "btnAvatarScraper"
        Me.btnAvatarScraper.Text1 = "Avatar Scraper"
        Me.btnAvatarScraper.Text2 = "get avatars and download them"
        Me.btnAvatarScraper.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnAvatarScraper.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnFE
        '
        Me.btnFE.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnFE.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnFE.Color1A = System.Drawing.Color.White
        Me.btnFE.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnFE.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFE.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnFE.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFE.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFE.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFE.Image = CType(resources.GetObject("btnFE.Image"), System.Drawing.Image)
        Me.btnFE.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFE.Location = New System.Drawing.Point(12, 260)
        Me.btnFE.Name = "btnFE"
        Me.btnFE.NoGradient = False
        Me.btnFE.NoRounding = False
        Me.btnFE.Selection = True
        Me.btnFE.SelectionToggle = False
        Me.btnFE.Size = New System.Drawing.Size(302, 45)
        Me.btnFE.TabIndex = 24
        Me.btnFE.Text = "btnFE"
        Me.btnFE.Text1 = "YouToob FE"
        Me.btnFE.Text2 = "fastest YouTube bot on the web"
        Me.btnFE.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnFE.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnPasswordChanger
        '
        Me.btnPasswordChanger.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnPasswordChanger.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnPasswordChanger.Color1A = System.Drawing.Color.White
        Me.btnPasswordChanger.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnPasswordChanger.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPasswordChanger.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnPasswordChanger.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasswordChanger.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasswordChanger.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasswordChanger.Image = CType(resources.GetObject("btnPasswordChanger.Image"), System.Drawing.Image)
        Me.btnPasswordChanger.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPasswordChanger.Location = New System.Drawing.Point(324, 149)
        Me.btnPasswordChanger.Name = "btnPasswordChanger"
        Me.btnPasswordChanger.NoGradient = False
        Me.btnPasswordChanger.NoRounding = False
        Me.btnPasswordChanger.Selection = True
        Me.btnPasswordChanger.SelectionToggle = False
        Me.btnPasswordChanger.Size = New System.Drawing.Size(302, 45)
        Me.btnPasswordChanger.TabIndex = 22
        Me.btnPasswordChanger.Text = "btnPasswordChanger"
        Me.btnPasswordChanger.Text1 = "Password Changer"
        Me.btnPasswordChanger.Text2 = "change passwords on your user lists"
        Me.btnPasswordChanger.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnPasswordChanger.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnAvatarUploader
        '
        Me.btnAvatarUploader.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnAvatarUploader.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnAvatarUploader.Color1A = System.Drawing.Color.White
        Me.btnAvatarUploader.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnAvatarUploader.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAvatarUploader.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnAvatarUploader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvatarUploader.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvatarUploader.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvatarUploader.Image = CType(resources.GetObject("btnAvatarUploader.Image"), System.Drawing.Image)
        Me.btnAvatarUploader.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAvatarUploader.Location = New System.Drawing.Point(324, 93)
        Me.btnAvatarUploader.Name = "btnAvatarUploader"
        Me.btnAvatarUploader.NoGradient = False
        Me.btnAvatarUploader.NoRounding = False
        Me.btnAvatarUploader.Selection = True
        Me.btnAvatarUploader.SelectionToggle = False
        Me.btnAvatarUploader.Size = New System.Drawing.Size(302, 45)
        Me.btnAvatarUploader.TabIndex = 20
        Me.btnAvatarUploader.Text = "btnAvatarUploader"
        Me.btnAvatarUploader.Text1 = "Avatar Uploader"
        Me.btnAvatarUploader.Text2 = "make your accounts look real"
        Me.btnAvatarUploader.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnAvatarUploader.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnAccProxBinder
        '
        Me.btnAccProxBinder.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnAccProxBinder.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnAccProxBinder.Color1A = System.Drawing.Color.White
        Me.btnAccProxBinder.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnAccProxBinder.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAccProxBinder.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnAccProxBinder.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccProxBinder.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccProxBinder.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccProxBinder.Image = CType(resources.GetObject("btnAccProxBinder.Image"), System.Drawing.Image)
        Me.btnAccProxBinder.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAccProxBinder.Location = New System.Drawing.Point(324, 38)
        Me.btnAccProxBinder.Name = "btnAccProxBinder"
        Me.btnAccProxBinder.NoGradient = False
        Me.btnAccProxBinder.NoRounding = False
        Me.btnAccProxBinder.Selection = True
        Me.btnAccProxBinder.SelectionToggle = False
        Me.btnAccProxBinder.Size = New System.Drawing.Size(302, 45)
        Me.btnAccProxBinder.TabIndex = 18
        Me.btnAccProxBinder.Text = "btnAccProxBinder"
        Me.btnAccProxBinder.Text1 = "Account & Proxy Binder"
        Me.btnAccProxBinder.Text2 = "make unique lists"
        Me.btnAccProxBinder.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnAccProxBinder.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnProxyScraper
        '
        Me.btnProxyScraper.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnProxyScraper.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnProxyScraper.Color1A = System.Drawing.Color.White
        Me.btnProxyScraper.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnProxyScraper.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnProxyScraper.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnProxyScraper.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProxyScraper.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProxyScraper.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProxyScraper.Image = CType(resources.GetObject("btnProxyScraper.Image"), System.Drawing.Image)
        Me.btnProxyScraper.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnProxyScraper.Location = New System.Drawing.Point(12, 205)
        Me.btnProxyScraper.Name = "btnProxyScraper"
        Me.btnProxyScraper.NoGradient = False
        Me.btnProxyScraper.NoRounding = False
        Me.btnProxyScraper.Selection = True
        Me.btnProxyScraper.SelectionToggle = False
        Me.btnProxyScraper.Size = New System.Drawing.Size(302, 45)
        Me.btnProxyScraper.TabIndex = 16
        Me.btnProxyScraper.Text = "btnProxyScraper"
        Me.btnProxyScraper.Text1 = "Proxy Scraper"
        Me.btnProxyScraper.Text2 = "get free proxies"
        Me.btnProxyScraper.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnProxyScraper.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
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
        Me.Seperator2.Location = New System.Drawing.Point(8, 194)
        Me.Seperator2.Name = "Seperator2"
        Me.Seperator2.NoRounding = False
        Me.Seperator2.Size = New System.Drawing.Size(623, 10)
        Me.Seperator2.TabIndex = 15
        '
        'btnCommentRater
        '
        Me.btnCommentRater.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnCommentRater.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnCommentRater.Color1A = System.Drawing.Color.White
        Me.btnCommentRater.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnCommentRater.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCommentRater.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnCommentRater.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommentRater.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommentRater.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommentRater.Image = CType(resources.GetObject("btnCommentRater.Image"), System.Drawing.Image)
        Me.btnCommentRater.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCommentRater.Location = New System.Drawing.Point(12, 149)
        Me.btnCommentRater.Name = "btnCommentRater"
        Me.btnCommentRater.NoGradient = False
        Me.btnCommentRater.NoRounding = False
        Me.btnCommentRater.Selection = True
        Me.btnCommentRater.SelectionToggle = False
        Me.btnCommentRater.Size = New System.Drawing.Size(302, 45)
        Me.btnCommentRater.TabIndex = 14
        Me.btnCommentRater.Text = "btnCommentRater"
        Me.btnCommentRater.Text1 = "Comment Rater"
        Me.btnCommentRater.Text2 = "bring your comments to the highest rated spot"
        Me.btnCommentRater.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnCommentRater.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
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
        Me.seperatorA.Location = New System.Drawing.Point(8, 83)
        Me.seperatorA.Name = "seperatorA"
        Me.seperatorA.NoRounding = False
        Me.seperatorA.Size = New System.Drawing.Size(623, 10)
        Me.seperatorA.TabIndex = 9
        '
        'btnVideoTools
        '
        Me.btnVideoTools.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnVideoTools.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnVideoTools.Color1A = System.Drawing.Color.White
        Me.btnVideoTools.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnVideoTools.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVideoTools.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnVideoTools.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoTools.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoTools.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoTools.Image = CType(resources.GetObject("btnVideoTools.Image"), System.Drawing.Image)
        Me.btnVideoTools.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVideoTools.Location = New System.Drawing.Point(12, 93)
        Me.btnVideoTools.Name = "btnVideoTools"
        Me.btnVideoTools.NoGradient = False
        Me.btnVideoTools.NoRounding = False
        Me.btnVideoTools.Selection = True
        Me.btnVideoTools.SelectionToggle = False
        Me.btnVideoTools.Size = New System.Drawing.Size(302, 45)
        Me.btnVideoTools.TabIndex = 12
        Me.btnVideoTools.Text = "btnVideoTools"
        Me.btnVideoTools.Text1 = "Video Tools"
        Me.btnVideoTools.Text2 = "add likes, subscribers, favorites (...) to videos"
        Me.btnVideoTools.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnVideoTools.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(589, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 11
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(611, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "X"
        '
        'btnCommentObfuscator
        '
        Me.btnCommentObfuscator.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnCommentObfuscator.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnCommentObfuscator.Color1A = System.Drawing.Color.White
        Me.btnCommentObfuscator.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnCommentObfuscator.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCommentObfuscator.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnCommentObfuscator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommentObfuscator.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommentObfuscator.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommentObfuscator.Image = CType(resources.GetObject("btnCommentObfuscator.Image"), System.Drawing.Image)
        Me.btnCommentObfuscator.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCommentObfuscator.Location = New System.Drawing.Point(12, 38)
        Me.btnCommentObfuscator.Name = "btnCommentObfuscator"
        Me.btnCommentObfuscator.NoGradient = False
        Me.btnCommentObfuscator.NoRounding = False
        Me.btnCommentObfuscator.Selection = True
        Me.btnCommentObfuscator.SelectionToggle = False
        Me.btnCommentObfuscator.Size = New System.Drawing.Size(302, 45)
        Me.btnCommentObfuscator.TabIndex = 8
        Me.btnCommentObfuscator.Text = "btnCommentObfuscator"
        Me.btnCommentObfuscator.Text1 = "Comment Obfuscator"
        Me.btnCommentObfuscator.Text2 = "make it stand out, and hide links"
        Me.btnCommentObfuscator.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnCommentObfuscator.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'frmTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 318)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTools"
        Me.Text = "Tubenoia — Tools"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents seperatorA As Tubenoia.Seperator
    Friend WithEvents btnCommentObfuscator As Tubenoia.ButtonPane
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents btnVideoTools As Tubenoia.ButtonPane
    Friend WithEvents btnCommentRater As Tubenoia.ButtonPane
    Friend WithEvents Seperator1 As Tubenoia.Seperator
    Friend WithEvents btnProxyScraper As Tubenoia.ButtonPane
    Friend WithEvents Seperator2 As Tubenoia.Seperator
    Friend WithEvents btnAccProxBinder As Tubenoia.ButtonPane
    Friend WithEvents Seperator3 As Tubenoia.Seperator
    Friend WithEvents btnAvatarUploader As Tubenoia.ButtonPane
    Friend WithEvents btnPasswordChanger As Tubenoia.ButtonPane
    Friend WithEvents btnFE As Tubenoia.ButtonPane
    Friend WithEvents btnAvatarScraper As Tubenoia.ButtonPane
    Friend WithEvents Seperator4 As Tubenoia.Seperator
    Friend WithEvents btnVideoChecker As Tubenoia.ButtonPane
End Class
