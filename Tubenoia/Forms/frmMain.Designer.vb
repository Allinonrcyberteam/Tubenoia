<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Theme = New Tubenoia.NTheme()
        Me.btnMassFriendAdd = New Tubenoia.ButtonPane()
        Me.btnMassMessage = New Tubenoia.ButtonPane()
        Me.btnMassUploader = New Tubenoia.ButtonPane()
        Me.btnTools = New Tubenoia.ButtonPane()
        Me.btnMassDownloader = New Tubenoia.ButtonPane()
        Me.Seperator4 = New Tubenoia.Seperator()
        Me.Seperator1 = New Tubenoia.Seperator()
        Me.seperatorA = New Tubenoia.Seperator()
        Me.btnFilters = New Tubenoia.ButtonPane()
        Me.Seperator2 = New Tubenoia.Seperator()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnUserScrapers = New Tubenoia.ButtonPane()
        Me.Seperator3 = New Tubenoia.Seperator()
        Me.btnAccountChecker = New Tubenoia.ButtonPane()
        Me.seperatorB = New Tubenoia.Seperator()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.btnSettings = New Tubenoia.ButtonPane()
        Me.btnVideoScraper = New Tubenoia.ButtonPane()
        Me.btnRankChecker = New Tubenoia.ButtonPane()
        Me.btnLogViewer = New Tubenoia.ButtonPane()
        Me.LogoBG = New Tubenoia.GPBOX()
        Me.Theme.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.btnMassFriendAdd)
        Me.Theme.Controls.Add(Me.btnMassMessage)
        Me.Theme.Controls.Add(Me.btnMassUploader)
        Me.Theme.Controls.Add(Me.btnTools)
        Me.Theme.Controls.Add(Me.btnMassDownloader)
        Me.Theme.Controls.Add(Me.Seperator4)
        Me.Theme.Controls.Add(Me.Seperator1)
        Me.Theme.Controls.Add(Me.seperatorA)
        Me.Theme.Controls.Add(Me.btnFilters)
        Me.Theme.Controls.Add(Me.Seperator2)
        Me.Theme.Controls.Add(Me.PictureBox1)
        Me.Theme.Controls.Add(Me.btnUserScrapers)
        Me.Theme.Controls.Add(Me.Seperator3)
        Me.Theme.Controls.Add(Me.btnAccountChecker)
        Me.Theme.Controls.Add(Me.seperatorB)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.btnSettings)
        Me.Theme.Controls.Add(Me.btnVideoScraper)
        Me.Theme.Controls.Add(Me.btnRankChecker)
        Me.Theme.Controls.Add(Me.btnLogViewer)
        Me.Theme.Controls.Add(Me.LogoBG)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Theme.ForeColor = System.Drawing.Color.White
        Me.Theme.Image = Nothing
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 14
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = False
        Me.Theme.Size = New System.Drawing.Size(643, 468)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "                                                               Tubenoia — Main Me" & _
    "nu"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'btnMassFriendAdd
        '
        Me.btnMassFriendAdd.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnMassFriendAdd.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnMassFriendAdd.Color1A = System.Drawing.Color.White
        Me.btnMassFriendAdd.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnMassFriendAdd.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMassFriendAdd.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnMassFriendAdd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMassFriendAdd.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMassFriendAdd.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMassFriendAdd.Image = CType(resources.GetObject("btnMassFriendAdd.Image"), System.Drawing.Image)
        Me.btnMassFriendAdd.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMassFriendAdd.Location = New System.Drawing.Point(329, 355)
        Me.btnMassFriendAdd.Name = "btnMassFriendAdd"
        Me.btnMassFriendAdd.NoGradient = False
        Me.btnMassFriendAdd.NoRounding = False
        Me.btnMassFriendAdd.Selection = True
        Me.btnMassFriendAdd.SelectionToggle = False
        Me.btnMassFriendAdd.Size = New System.Drawing.Size(302, 45)
        Me.btnMassFriendAdd.TabIndex = 10017
        Me.btnMassFriendAdd.Text = "btnMassFriendAdd"
        Me.btnMassFriendAdd.Text1 = "Mass Friend Adder"
        Me.btnMassFriendAdd.Text2 = "add loads of users as friends"
        Me.btnMassFriendAdd.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnMassFriendAdd.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnMassMessage
        '
        Me.btnMassMessage.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnMassMessage.Border2 = System.Drawing.Color.Red
        Me.btnMassMessage.Color1A = System.Drawing.Color.White
        Me.btnMassMessage.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnMassMessage.Color2A = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMassMessage.Color2B = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMassMessage.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMassMessage.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMassMessage.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMassMessage.Image = CType(resources.GetObject("btnMassMessage.Image"), System.Drawing.Image)
        Me.btnMassMessage.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMassMessage.Location = New System.Drawing.Point(329, 299)
        Me.btnMassMessage.Name = "btnMassMessage"
        Me.btnMassMessage.NoGradient = False
        Me.btnMassMessage.NoRounding = False
        Me.btnMassMessage.Selection = True
        Me.btnMassMessage.SelectionToggle = False
        Me.btnMassMessage.Size = New System.Drawing.Size(302, 45)
        Me.btnMassMessage.TabIndex = 10016
        Me.btnMassMessage.Text = "btnMassMessage"
        Me.btnMassMessage.Text1 = "Mass Messenger"
        Me.btnMassMessage.Text2 = "send messages out  (coming soon)"
        Me.btnMassMessage.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnMassMessage.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnMassUploader
        '
        Me.btnMassUploader.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnMassUploader.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnMassUploader.Color1A = System.Drawing.Color.White
        Me.btnMassUploader.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnMassUploader.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMassUploader.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnMassUploader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMassUploader.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMassUploader.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMassUploader.Image = CType(resources.GetObject("btnMassUploader.Image"), System.Drawing.Image)
        Me.btnMassUploader.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMassUploader.Location = New System.Drawing.Point(329, 244)
        Me.btnMassUploader.Name = "btnMassUploader"
        Me.btnMassUploader.NoGradient = False
        Me.btnMassUploader.NoRounding = False
        Me.btnMassUploader.Selection = True
        Me.btnMassUploader.SelectionToggle = False
        Me.btnMassUploader.Size = New System.Drawing.Size(302, 45)
        Me.btnMassUploader.TabIndex = 10015
        Me.btnMassUploader.Text = "btnMassUploader"
        Me.btnMassUploader.Text1 = "Mass Uploader"
        Me.btnMassUploader.Text2 = "upload all your videos to multiple accounts"
        Me.btnMassUploader.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnMassUploader.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnTools
        '
        Me.btnTools.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnTools.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnTools.Color1A = System.Drawing.Color.White
        Me.btnTools.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnTools.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTools.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnTools.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTools.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTools.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTools.Image = CType(resources.GetObject("btnTools.Image"), System.Drawing.Image)
        Me.btnTools.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTools.Location = New System.Drawing.Point(329, 411)
        Me.btnTools.Name = "btnTools"
        Me.btnTools.NoGradient = False
        Me.btnTools.NoRounding = False
        Me.btnTools.Selection = True
        Me.btnTools.SelectionToggle = False
        Me.btnTools.Size = New System.Drawing.Size(302, 45)
        Me.btnTools.TabIndex = 10014
        Me.btnTools.Text = "btnTools"
        Me.btnTools.Text1 = "Tools"
        Me.btnTools.Text2 = "all kinds of tools to help your promoting"
        Me.btnTools.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnTools.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnMassDownloader
        '
        Me.btnMassDownloader.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnMassDownloader.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnMassDownloader.Color1A = System.Drawing.Color.White
        Me.btnMassDownloader.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnMassDownloader.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMassDownloader.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnMassDownloader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMassDownloader.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMassDownloader.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMassDownloader.Image = CType(resources.GetObject("btnMassDownloader.Image"), System.Drawing.Image)
        Me.btnMassDownloader.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMassDownloader.Location = New System.Drawing.Point(329, 188)
        Me.btnMassDownloader.Name = "btnMassDownloader"
        Me.btnMassDownloader.NoGradient = False
        Me.btnMassDownloader.NoRounding = False
        Me.btnMassDownloader.Selection = True
        Me.btnMassDownloader.SelectionToggle = False
        Me.btnMassDownloader.Size = New System.Drawing.Size(302, 45)
        Me.btnMassDownloader.TabIndex = 10013
        Me.btnMassDownloader.Text = "btnMassDownloader"
        Me.btnMassDownloader.Text1 = "Mass Downloader"
        Me.btnMassDownloader.Text2 = "download videos with a single click"
        Me.btnMassDownloader.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnMassDownloader.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'Seperator4
        '
        Me.Seperator4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator4.BackColor = System.Drawing.Color.White
        Me.Seperator4.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator4.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator4.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator4.Image = Nothing
        Me.Seperator4.Location = New System.Drawing.Point(9, 400)
        Me.Seperator4.Name = "Seperator4"
        Me.Seperator4.NoRounding = False
        Me.Seperator4.Size = New System.Drawing.Size(623, 10)
        Me.Seperator4.TabIndex = 13
        Me.Seperator4.Text = "Seperator2"
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
        Me.Seperator1.Location = New System.Drawing.Point(10, 289)
        Me.Seperator1.Name = "Seperator1"
        Me.Seperator1.NoRounding = False
        Me.Seperator1.Size = New System.Drawing.Size(623, 10)
        Me.Seperator1.TabIndex = 8
        Me.Seperator1.Text = "Seperator2"
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
        Me.seperatorA.Location = New System.Drawing.Point(9, 177)
        Me.seperatorA.Name = "seperatorA"
        Me.seperatorA.NoRounding = False
        Me.seperatorA.Size = New System.Drawing.Size(623, 10)
        Me.seperatorA.TabIndex = 7
        '
        'btnFilters
        '
        Me.btnFilters.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnFilters.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnFilters.Color1A = System.Drawing.Color.White
        Me.btnFilters.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnFilters.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFilters.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnFilters.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilters.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilters.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilters.Image = CType(resources.GetObject("btnFilters.Image"), System.Drawing.Image)
        Me.btnFilters.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFilters.Location = New System.Drawing.Point(329, 132)
        Me.btnFilters.Name = "btnFilters"
        Me.btnFilters.NoGradient = False
        Me.btnFilters.NoRounding = False
        Me.btnFilters.Selection = True
        Me.btnFilters.SelectionToggle = False
        Me.btnFilters.Size = New System.Drawing.Size(302, 45)
        Me.btnFilters.TabIndex = 10012
        Me.btnFilters.Text = "btnFilters"
        Me.btnFilters.Text1 = "Filters"
        Me.btnFilters.Text2 = "target videos and users with filters"
        Me.btnFilters.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnFilters.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'Seperator2
        '
        Me.Seperator2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Seperator2.BackColor = System.Drawing.Color.White
        Me.Seperator2.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator2.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator2.Direction = System.Windows.Forms.Orientation.Vertical
        Me.Seperator2.Image = Nothing
        Me.Seperator2.Location = New System.Drawing.Point(317, 130)
        Me.Seperator2.Name = "Seperator2"
        Me.Seperator2.NoRounding = False
        Me.Seperator2.Size = New System.Drawing.Size(10, 330)
        Me.Seperator2.TabIndex = 10011
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(205, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 66)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btnUserScrapers
        '
        Me.btnUserScrapers.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnUserScrapers.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUserScrapers.Color1A = System.Drawing.Color.White
        Me.btnUserScrapers.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnUserScrapers.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserScrapers.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUserScrapers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserScrapers.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserScrapers.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserScrapers.Image = CType(resources.GetObject("btnUserScrapers.Image"), System.Drawing.Image)
        Me.btnUserScrapers.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserScrapers.Location = New System.Drawing.Point(12, 411)
        Me.btnUserScrapers.Name = "btnUserScrapers"
        Me.btnUserScrapers.NoGradient = False
        Me.btnUserScrapers.NoRounding = False
        Me.btnUserScrapers.Selection = True
        Me.btnUserScrapers.SelectionToggle = False
        Me.btnUserScrapers.Size = New System.Drawing.Size(302, 45)
        Me.btnUserScrapers.TabIndex = 12
        Me.btnUserScrapers.Text = "btnUserScrapers"
        Me.btnUserScrapers.Text1 = "User Scrapers"
        Me.btnUserScrapers.Text2 = "scrape users from various places"
        Me.btnUserScrapers.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnUserScrapers.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
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
        Me.Seperator3.Location = New System.Drawing.Point(9, 344)
        Me.Seperator3.Name = "Seperator3"
        Me.Seperator3.NoRounding = False
        Me.Seperator3.Size = New System.Drawing.Size(623, 10)
        Me.Seperator3.TabIndex = 11
        Me.Seperator3.Text = "Seperator2"
        '
        'btnAccountChecker
        '
        Me.btnAccountChecker.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnAccountChecker.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnAccountChecker.Color1A = System.Drawing.Color.White
        Me.btnAccountChecker.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnAccountChecker.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAccountChecker.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnAccountChecker.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountChecker.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountChecker.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountChecker.Image = CType(resources.GetObject("btnAccountChecker.Image"), System.Drawing.Image)
        Me.btnAccountChecker.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAccountChecker.Location = New System.Drawing.Point(12, 355)
        Me.btnAccountChecker.Name = "btnAccountChecker"
        Me.btnAccountChecker.NoGradient = False
        Me.btnAccountChecker.NoRounding = False
        Me.btnAccountChecker.Selection = True
        Me.btnAccountChecker.SelectionToggle = False
        Me.btnAccountChecker.Size = New System.Drawing.Size(302, 45)
        Me.btnAccountChecker.TabIndex = 9
        Me.btnAccountChecker.Text = "btnAccountChecker"
        Me.btnAccountChecker.Text1 = "Account Checker"
        Me.btnAccountChecker.Text2 = "quickly sort your lists"
        Me.btnAccountChecker.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnAccountChecker.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'seperatorB
        '
        Me.seperatorB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.seperatorB.BackColor = System.Drawing.Color.White
        Me.seperatorB.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.seperatorB.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.seperatorB.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.seperatorB.Image = Nothing
        Me.seperatorB.Location = New System.Drawing.Point(10, 233)
        Me.seperatorB.Name = "seperatorB"
        Me.seperatorB.NoRounding = False
        Me.seperatorB.Size = New System.Drawing.Size(623, 10)
        Me.seperatorB.TabIndex = 8
        Me.seperatorB.Text = "Seperator2"
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(593, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 6
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(615, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "X"
        '
        'btnSettings
        '
        Me.btnSettings.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnSettings.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnSettings.Color1A = System.Drawing.Color.White
        Me.btnSettings.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnSettings.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSettings.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnSettings.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSettings.Location = New System.Drawing.Point(12, 299)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.NoGradient = False
        Me.btnSettings.NoRounding = False
        Me.btnSettings.Selection = True
        Me.btnSettings.SelectionToggle = False
        Me.btnSettings.Size = New System.Drawing.Size(302, 45)
        Me.btnSettings.TabIndex = 4
        Me.btnSettings.Text = "btnSettings"
        Me.btnSettings.Text1 = "Settings"
        Me.btnSettings.Text2 = "tweak, configure and optimize"
        Me.btnSettings.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnSettings.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnVideoScraper
        '
        Me.btnVideoScraper.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnVideoScraper.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnVideoScraper.Color1A = System.Drawing.Color.White
        Me.btnVideoScraper.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnVideoScraper.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVideoScraper.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnVideoScraper.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoScraper.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoScraper.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoScraper.Image = CType(resources.GetObject("btnVideoScraper.Image"), System.Drawing.Image)
        Me.btnVideoScraper.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVideoScraper.Location = New System.Drawing.Point(12, 244)
        Me.btnVideoScraper.Name = "btnVideoScraper"
        Me.btnVideoScraper.NoGradient = False
        Me.btnVideoScraper.NoRounding = False
        Me.btnVideoScraper.Selection = True
        Me.btnVideoScraper.SelectionToggle = False
        Me.btnVideoScraper.Size = New System.Drawing.Size(302, 45)
        Me.btnVideoScraper.TabIndex = 4
        Me.btnVideoScraper.Text = "btnVideoScraper"
        Me.btnVideoScraper.Text1 = "Video Scraper"
        Me.btnVideoScraper.Text2 = "channels, top results, keywords, comments"
        Me.btnVideoScraper.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnVideoScraper.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnRankChecker
        '
        Me.btnRankChecker.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnRankChecker.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnRankChecker.Color1A = System.Drawing.Color.White
        Me.btnRankChecker.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnRankChecker.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRankChecker.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnRankChecker.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRankChecker.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRankChecker.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRankChecker.Image = CType(resources.GetObject("btnRankChecker.Image"), System.Drawing.Image)
        Me.btnRankChecker.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRankChecker.Location = New System.Drawing.Point(12, 188)
        Me.btnRankChecker.Name = "btnRankChecker"
        Me.btnRankChecker.NoGradient = False
        Me.btnRankChecker.NoRounding = False
        Me.btnRankChecker.Selection = True
        Me.btnRankChecker.SelectionToggle = False
        Me.btnRankChecker.Size = New System.Drawing.Size(302, 45)
        Me.btnRankChecker.TabIndex = 3
        Me.btnRankChecker.Text = "btnRankChecker"
        Me.btnRankChecker.Text1 = "Rank Checker"
        Me.btnRankChecker.Text2 = "check your videos ranks"
        Me.btnRankChecker.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnRankChecker.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnLogViewer
        '
        Me.btnLogViewer.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnLogViewer.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnLogViewer.Color1A = System.Drawing.Color.White
        Me.btnLogViewer.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnLogViewer.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogViewer.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnLogViewer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogViewer.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogViewer.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogViewer.Image = CType(resources.GetObject("btnLogViewer.Image"), System.Drawing.Image)
        Me.btnLogViewer.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogViewer.Location = New System.Drawing.Point(12, 132)
        Me.btnLogViewer.Name = "btnLogViewer"
        Me.btnLogViewer.NoGradient = False
        Me.btnLogViewer.NoRounding = False
        Me.btnLogViewer.Selection = True
        Me.btnLogViewer.SelectionToggle = False
        Me.btnLogViewer.Size = New System.Drawing.Size(302, 45)
        Me.btnLogViewer.TabIndex = 2
        Me.btnLogViewer.Text = "btnLogViewer"
        Me.btnLogViewer.Text1 = "Log Viewer"
        Me.btnLogViewer.Text2 = "browse through logs"
        Me.btnLogViewer.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnLogViewer.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'LogoBG
        '
        Me.LogoBG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoBG.Border1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LogoBG.Border2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogoBG.FillColor = System.Drawing.Color.White
        Me.LogoBG.Image = Nothing
        Me.LogoBG.Location = New System.Drawing.Point(12, 37)
        Me.LogoBG.Name = "LogoBG"
        Me.LogoBG.NoRounding = False
        Me.LogoBG.Size = New System.Drawing.Size(619, 92)
        Me.LogoBG.TabIndex = 10010
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 468)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Tubenoia — Main Menu"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.ntheme
    Friend WithEvents btnVideoScraper As Tubenoia.ButtonPane
    Friend WithEvents btnRankChecker As Tubenoia.ButtonPane
    Friend WithEvents btnLogViewer As Tubenoia.ButtonPane
    Friend WithEvents btnMinimize As Tubenoia.nbutton
    Friend WithEvents btnExit As Tubenoia.nbutton
    Friend WithEvents seperatorB As Tubenoia.Seperator
    Friend WithEvents seperatorA As Tubenoia.Seperator
    Friend WithEvents Seperator1 As Tubenoia.Seperator
    Friend WithEvents btnSettings As Tubenoia.ButtonPane
    Friend WithEvents btnAccountChecker As Tubenoia.ButtonPane
    Friend WithEvents Seperator3 As Tubenoia.Seperator
    Friend WithEvents Seperator4 As Tubenoia.Seperator
    Friend WithEvents btnUserScrapers As Tubenoia.ButtonPane
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LogoBG As Tubenoia.GPBOX
    Friend WithEvents Seperator2 As Tubenoia.Seperator
    Friend WithEvents btnFilters As Tubenoia.ButtonPane
    Friend WithEvents btnMassDownloader As Tubenoia.ButtonPane
    Friend WithEvents btnTools As Tubenoia.ButtonPane
    Friend WithEvents btnMassFriendAdd As Tubenoia.ButtonPane
    Friend WithEvents btnMassMessage As Tubenoia.ButtonPane
    Friend WithEvents btnMassUploader As Tubenoia.ButtonPane
End Class
