<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Multithreading", 1, 1)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Captcha", 2, 2)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("General", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Me.IL = New System.Windows.Forms.ImageList(Me.components)
        Me.Theme = New Tubenoia.NTheme()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Seperator5 = New Tubenoia.Seperator()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.GPBOX1 = New Tubenoia.GPBOX()
        Me.chkManualCaptcha = New System.Windows.Forms.RadioButton()
        Me.chkDismissCaptcha = New System.Windows.Forms.RadioButton()
        Me.chkDBC = New System.Windows.Forms.RadioButton()
        Me.Timeout = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Seperator4 = New Tubenoia.Seperator()
        Me.Seperator3 = New Tubenoia.Seperator()
        Me.lblDBCValid = New System.Windows.Forms.Label()
        Me.lblDBCBalance = New System.Windows.Forms.Label()
        Me.lblDBCUsername = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDBCVerify = New Tubenoia.NButton()
        Me.Seperator2 = New Tubenoia.Seperator()
        Me.txtDBCPass = New System.Windows.Forms.TextBox()
        Me.txtDBCUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Seperator1 = New Tubenoia.Seperator()
        Me.lblCaptchaInfo = New System.Windows.Forms.Label()
        Me.lblNumThreads = New System.Windows.Forms.Label()
        Me.lblThreads = New System.Windows.Forms.Label()
        Me.tbThreads = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New Tubenoia.NButton()
        Me.btnSave = New Tubenoia.NButton()
        Me.Title = New System.Windows.Forms.Label()
        Me.Menu = New System.Windows.Forms.TreeView()
        Me.Page = New Tubenoia.Rotator()
        Me.Theme.SuspendLayout()
        Me.GPBOX1.SuspendLayout()
        CType(Me.Timeout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbThreads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IL
        '
        Me.IL.ImageStream = CType(resources.GetObject("IL.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IL.TransparentColor = System.Drawing.Color.Transparent
        Me.IL.Images.SetKeyName(0, "settings.png")
        Me.IL.Images.SetKeyName(1, "collaboration.png")
        Me.IL.Images.SetKeyName(2, "finished-work.png")
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.tbThreads)
        Me.Theme.Controls.Add(Me.lblThreads)
        Me.Theme.Controls.Add(Me.lblNumThreads)
        Me.Theme.Controls.Add(Me.Seperator5)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.GPBOX1)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.btnSave)
        Me.Theme.Controls.Add(Me.Title)
        Me.Theme.Controls.Add(Me.Menu)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.White
        Me.Page.SetFrame(Me.Theme, CType(255, Byte))
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 14
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = False
        Me.Theme.Size = New System.Drawing.Size(705, 476)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Settings"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.Label8, CType(1, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(474, 33)
        Me.Label8.TabIndex = 10033
        Me.Label8.Text = "*   The number of threads determines how fast Tubenoia should finish the tasks. T" & _
            "he more threads, the more RAM it will use."
        '
        'Seperator5
        '
        Me.Seperator5.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator5.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator5.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Page.SetFrame(Me.Seperator5, CType(1, Byte))
        Me.Seperator5.Image = Nothing
        Me.Seperator5.Location = New System.Drawing.Point(206, 121)
        Me.Seperator5.Name = "Seperator5"
        Me.Seperator5.NoRounding = False
        Me.Seperator5.Size = New System.Drawing.Size(485, 10)
        Me.Seperator5.TabIndex = 10032
        Me.Seperator5.Text = "Seperator5"
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.Page.SetFrame(Me.btnMinimize, CType(255, Byte))
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(655, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 10031
        Me.btnMinimize.Text = "_"
        '
        'GPBOX1
        '
        Me.GPBOX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GPBOX1.Border1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GPBOX1.Border2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GPBOX1.Controls.Add(Me.chkManualCaptcha)
        Me.GPBOX1.Controls.Add(Me.chkDismissCaptcha)
        Me.GPBOX1.Controls.Add(Me.chkDBC)
        Me.GPBOX1.Controls.Add(Me.Timeout)
        Me.GPBOX1.Controls.Add(Me.Label7)
        Me.GPBOX1.Controls.Add(Me.Seperator4)
        Me.GPBOX1.Controls.Add(Me.Seperator3)
        Me.GPBOX1.Controls.Add(Me.lblDBCValid)
        Me.GPBOX1.Controls.Add(Me.lblDBCBalance)
        Me.GPBOX1.Controls.Add(Me.lblDBCUsername)
        Me.GPBOX1.Controls.Add(Me.Label6)
        Me.GPBOX1.Controls.Add(Me.Label5)
        Me.GPBOX1.Controls.Add(Me.Label4)
        Me.GPBOX1.Controls.Add(Me.Label8)
        Me.GPBOX1.Controls.Add(Me.Label3)
        Me.GPBOX1.Controls.Add(Me.btnDBCVerify)
        Me.GPBOX1.Controls.Add(Me.Seperator2)
        Me.GPBOX1.Controls.Add(Me.txtDBCPass)
        Me.GPBOX1.Controls.Add(Me.txtDBCUser)
        Me.GPBOX1.Controls.Add(Me.Label2)
        Me.GPBOX1.Controls.Add(Me.Seperator1)
        Me.GPBOX1.Controls.Add(Me.lblCaptchaInfo)
        Me.GPBOX1.Controls.Add(Me.Label1)
        Me.GPBOX1.FillColor = System.Drawing.Color.White
        Me.Page.SetFrame(Me.GPBOX1, CType(255, Byte))
        Me.GPBOX1.Image = Nothing
        Me.GPBOX1.Location = New System.Drawing.Point(205, 81)
        Me.GPBOX1.Name = "GPBOX1"
        Me.GPBOX1.NoRounding = False
        Me.GPBOX1.Size = New System.Drawing.Size(488, 354)
        Me.GPBOX1.TabIndex = 10009
        '
        'chkManualCaptcha
        '
        Me.chkManualCaptcha.AutoSize = True
        Me.chkManualCaptcha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.chkManualCaptcha, CType(2, Byte))
        Me.chkManualCaptcha.Location = New System.Drawing.Point(187, 276)
        Me.chkManualCaptcha.Name = "chkManualCaptcha"
        Me.chkManualCaptcha.Size = New System.Drawing.Size(109, 17)
        Me.chkManualCaptcha.TabIndex = 10038
        Me.chkManualCaptcha.Text = "Manual CAPTCHA"
        Me.chkManualCaptcha.UseVisualStyleBackColor = True
        '
        'chkDismissCaptcha
        '
        Me.chkDismissCaptcha.AutoSize = True
        Me.chkDismissCaptcha.Checked = True
        Me.chkDismissCaptcha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.chkDismissCaptcha, CType(2, Byte))
        Me.chkDismissCaptcha.Location = New System.Drawing.Point(374, 276)
        Me.chkDismissCaptcha.Name = "chkDismissCaptcha"
        Me.chkDismissCaptcha.Size = New System.Drawing.Size(109, 17)
        Me.chkDismissCaptcha.TabIndex = 10037
        Me.chkDismissCaptcha.TabStop = True
        Me.chkDismissCaptcha.Text = "Dismiss CAPTCHA"
        Me.chkDismissCaptcha.UseVisualStyleBackColor = True
        '
        'chkDBC
        '
        Me.chkDBC.AutoSize = True
        Me.chkDBC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.chkDBC, CType(2, Byte))
        Me.chkDBC.Location = New System.Drawing.Point(10, 276)
        Me.chkDBC.Name = "chkDBC"
        Me.chkDBC.Size = New System.Drawing.Size(103, 17)
        Me.chkDBC.TabIndex = 10036
        Me.chkDBC.Text = "Use DBC Solving"
        Me.chkDBC.UseVisualStyleBackColor = True
        '
        'Timeout
        '
        Me.Timeout.BackColor = System.Drawing.Color.White
        Me.Timeout.Enabled = False
        Me.Timeout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.Timeout, CType(2, Byte))
        Me.Timeout.Location = New System.Drawing.Point(10, 325)
        Me.Timeout.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.Timeout.Minimum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.Timeout.Name = "Timeout"
        Me.Timeout.Size = New System.Drawing.Size(473, 21)
        Me.Timeout.TabIndex = 10034
        Me.Timeout.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.Label7, CType(2, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 308)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 13)
        Me.Label7.TabIndex = 10033
        Me.Label7.Text = "DBC Timeout settings (seconds):"
        '
        'Seperator4
        '
        Me.Seperator4.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator4.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator4.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Page.SetFrame(Me.Seperator4, CType(2, Byte))
        Me.Seperator4.Image = Nothing
        Me.Seperator4.Location = New System.Drawing.Point(1, 295)
        Me.Seperator4.Name = "Seperator4"
        Me.Seperator4.NoRounding = False
        Me.Seperator4.Size = New System.Drawing.Size(485, 10)
        Me.Seperator4.TabIndex = 10030
        Me.Seperator4.Text = "Seperator3"
        '
        'Seperator3
        '
        Me.Seperator3.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator3.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator3.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Page.SetFrame(Me.Seperator3, CType(2, Byte))
        Me.Seperator3.Image = Nothing
        Me.Seperator3.Location = New System.Drawing.Point(1, 262)
        Me.Seperator3.Name = "Seperator3"
        Me.Seperator3.NoRounding = False
        Me.Seperator3.Size = New System.Drawing.Size(485, 10)
        Me.Seperator3.TabIndex = 10030
        Me.Seperator3.Text = "Seperator3"
        '
        'lblDBCValid
        '
        Me.lblDBCValid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBCValid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.lblDBCValid, CType(2, Byte))
        Me.lblDBCValid.Location = New System.Drawing.Point(72, 245)
        Me.lblDBCValid.Name = "lblDBCValid"
        Me.lblDBCValid.Size = New System.Drawing.Size(402, 13)
        Me.lblDBCValid.TabIndex = 10029
        Me.lblDBCValid.Text = "N/A"
        Me.lblDBCValid.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDBCBalance
        '
        Me.lblDBCBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBCBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.lblDBCBalance, CType(2, Byte))
        Me.lblDBCBalance.Location = New System.Drawing.Point(72, 232)
        Me.lblDBCBalance.Name = "lblDBCBalance"
        Me.lblDBCBalance.Size = New System.Drawing.Size(402, 13)
        Me.lblDBCBalance.TabIndex = 10028
        Me.lblDBCBalance.Text = "$0.00"
        Me.lblDBCBalance.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDBCUsername
        '
        Me.lblDBCUsername.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBCUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.lblDBCUsername, CType(2, Byte))
        Me.lblDBCUsername.Location = New System.Drawing.Point(72, 219)
        Me.lblDBCUsername.Name = "lblDBCUsername"
        Me.lblDBCUsername.Size = New System.Drawing.Size(402, 13)
        Me.lblDBCUsername.TabIndex = 10027
        Me.lblDBCUsername.Text = "N/A"
        Me.lblDBCUsername.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.Label6, CType(2, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 10026
        Me.Label6.Text = "Valid:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.Label5, CType(2, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 10025
        Me.Label5.Text = "Balance:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.Label4, CType(2, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 10024
        Me.Label4.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.Label3, CType(2, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 13)
        Me.Label3.TabIndex = 10023
        Me.Label3.Text = "DBC Account Information:"
        '
        'btnDBCVerify
        '
        Me.btnDBCVerify.Enabled = False
        Me.Page.SetFrame(Me.btnDBCVerify, CType(2, Byte))
        Me.btnDBCVerify.Image = Nothing
        Me.btnDBCVerify.Location = New System.Drawing.Point(10, 157)
        Me.btnDBCVerify.Name = "btnDBCVerify"
        Me.btnDBCVerify.NoRounding = False
        Me.btnDBCVerify.Size = New System.Drawing.Size(473, 23)
        Me.btnDBCVerify.TabIndex = 10014
        Me.btnDBCVerify.Text = "Verify account login"
        '
        'Seperator2
        '
        Me.Seperator2.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator2.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator2.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Page.SetFrame(Me.Seperator2, CType(2, Byte))
        Me.Seperator2.Image = Nothing
        Me.Seperator2.Location = New System.Drawing.Point(1, 185)
        Me.Seperator2.Name = "Seperator2"
        Me.Seperator2.NoRounding = False
        Me.Seperator2.Size = New System.Drawing.Size(485, 10)
        Me.Seperator2.TabIndex = 10022
        Me.Seperator2.Text = "Seperator2"
        '
        'txtDBCPass
        '
        Me.txtDBCPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDBCPass.BackColor = System.Drawing.Color.White
        Me.txtDBCPass.Enabled = False
        Me.txtDBCPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.txtDBCPass, CType(2, Byte))
        Me.txtDBCPass.Location = New System.Drawing.Point(10, 129)
        Me.txtDBCPass.Name = "txtDBCPass"
        Me.txtDBCPass.Size = New System.Drawing.Size(473, 21)
        Me.txtDBCPass.TabIndex = 10021
        Me.txtDBCPass.UseSystemPasswordChar = True
        '
        'txtDBCUser
        '
        Me.txtDBCUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDBCUser.BackColor = System.Drawing.Color.White
        Me.txtDBCUser.Enabled = False
        Me.txtDBCUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.txtDBCUser, CType(2, Byte))
        Me.txtDBCUser.Location = New System.Drawing.Point(10, 100)
        Me.txtDBCUser.Name = "txtDBCUser"
        Me.txtDBCUser.Size = New System.Drawing.Size(473, 21)
        Me.txtDBCUser.TabIndex = 10020
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.Label2, CType(2, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 10018
        Me.Label2.Text = "Login information:"
        '
        'Seperator1
        '
        Me.Seperator1.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator1.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator1.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Page.SetFrame(Me.Seperator1, CType(2, Byte))
        Me.Seperator1.Image = Nothing
        Me.Seperator1.Location = New System.Drawing.Point(1, 57)
        Me.Seperator1.Name = "Seperator1"
        Me.Seperator1.NoRounding = False
        Me.Seperator1.Size = New System.Drawing.Size(485, 10)
        Me.Seperator1.TabIndex = 10015
        Me.Seperator1.Text = "Seperator1"
        '
        'lblCaptchaInfo
        '
        Me.lblCaptchaInfo.AutoSize = True
        Me.lblCaptchaInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.lblCaptchaInfo, CType(2, Byte))
        Me.lblCaptchaInfo.Location = New System.Drawing.Point(4, 10)
        Me.lblCaptchaInfo.Name = "lblCaptchaInfo"
        Me.lblCaptchaInfo.Size = New System.Drawing.Size(359, 39)
        Me.lblCaptchaInfo.TabIndex = 10014
        Me.lblCaptchaInfo.Text = "*   Please choose how you want to handle the CAPTCHA, when received." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*   We on" & _
            "ly support DBC (Death by Captcha)"
        '
        'lblNumThreads
        '
        Me.lblNumThreads.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumThreads.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.lblNumThreads, CType(1, Byte))
        Me.lblNumThreads.Location = New System.Drawing.Point(213, 152)
        Me.lblNumThreads.Name = "lblNumThreads"
        Me.lblNumThreads.Size = New System.Drawing.Size(53, 13)
        Me.lblNumThreads.TabIndex = 10017
        Me.lblNumThreads.Text = "1"
        Me.lblNumThreads.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblThreads
        '
        Me.lblThreads.AutoSize = True
        Me.lblThreads.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThreads.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.lblThreads, CType(1, Byte))
        Me.lblThreads.Location = New System.Drawing.Point(211, 136)
        Me.lblThreads.Name = "lblThreads"
        Me.lblThreads.Size = New System.Drawing.Size(101, 13)
        Me.lblThreads.TabIndex = 10016
        Me.lblThreads.Text = "Number of threads:"
        '
        'tbThreads
        '
        Me.Page.SetFrame(Me.tbThreads, CType(1, Byte))
        Me.tbThreads.Location = New System.Drawing.Point(315, 135)
        Me.tbThreads.Maximum = 50
        Me.tbThreads.Minimum = 1
        Me.tbThreads.Name = "tbThreads"
        Me.tbThreads.Size = New System.Drawing.Size(363, 45)
        Me.tbThreads.TabIndex = 10005
        Me.tbThreads.Value = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.Label1, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(479, 335)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.Page.SetFrame(Me.btnExit, CType(255, Byte))
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(677, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 10030
        Me.btnExit.Text = "X"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Page.SetFrame(Me.btnSave, CType(255, Byte))
        Me.btnSave.Image = Nothing
        Me.btnSave.Location = New System.Drawing.Point(205, 441)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.NoRounding = False
        Me.btnSave.Size = New System.Drawing.Size(488, 23)
        Me.btnSave.TabIndex = 10004
        Me.btnSave.Text = "Save Settings"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.Title, CType(255, Byte))
        Me.Title.Location = New System.Drawing.Point(205, 35)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(211, 45)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Information"
        '
        'Menu
        '
        Me.Menu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Menu.BackColor = System.Drawing.Color.White
        Me.Menu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Page.SetFrame(Me.Menu, CType(255, Byte))
        Me.Menu.ImageIndex = 0
        Me.Menu.ImageList = Me.IL
        Me.Menu.Indent = 40
        Me.Menu.ItemHeight = 38
        Me.Menu.LineColor = System.Drawing.Color.Silver
        Me.Menu.Location = New System.Drawing.Point(7, 33)
        Me.Menu.Name = "Menu"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = "Threading"
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "Multithreading"
        TreeNode2.ImageIndex = 2
        TreeNode2.Name = "Captcha"
        TreeNode2.SelectedImageIndex = 2
        TreeNode2.Text = "Captcha"
        TreeNode3.ImageIndex = 0
        TreeNode3.Name = "General"
        TreeNode3.NodeFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode3.SelectedImageIndex = 0
        TreeNode3.Text = "General"
        Me.Menu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.Menu.SelectedImageIndex = 0
        Me.Menu.ShowPlusMinus = False
        Me.Menu.ShowRootLines = False
        Me.Menu.Size = New System.Drawing.Size(191, 436)
        Me.Menu.TabIndex = 10000
        '
        'Page
        '
        Me.Page.CurrentFrame = CType(0, Byte)
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 476)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.Text = "Tubenoia — Settings"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        Me.GPBOX1.ResumeLayout(False)
        Me.GPBOX1.PerformLayout()
        CType(Me.Timeout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbThreads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.ntheme
    Friend Shadows WithEvents Menu As System.Windows.Forms.TreeView
    Friend WithEvents Page As Tubenoia.Rotator
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents GPBOX1 As Tubenoia.GPBOX
    Friend WithEvents btnSave As Tubenoia.nbutton
    Friend WithEvents IL As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Seperator1 As Tubenoia.Seperator
    Friend WithEvents lblCaptchaInfo As System.Windows.Forms.Label
    Friend WithEvents tbThreads As System.Windows.Forms.TrackBar
    Friend WithEvents lblNumThreads As System.Windows.Forms.Label
    Friend WithEvents lblThreads As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDBCVerify As Tubenoia.nbutton
    Friend WithEvents Seperator2 As Tubenoia.Seperator
    Friend WithEvents txtDBCPass As System.Windows.Forms.TextBox
    Friend WithEvents txtDBCUser As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDBCValid As System.Windows.Forms.Label
    Friend WithEvents lblDBCBalance As System.Windows.Forms.Label
    Friend WithEvents lblDBCUsername As System.Windows.Forms.Label
    Friend WithEvents btnMinimize As Tubenoia.nbutton
    Friend WithEvents btnExit As Tubenoia.nbutton
    Friend WithEvents Seperator3 As Tubenoia.Seperator
    Friend WithEvents Timeout As numericupdown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Seperator4 As Tubenoia.Seperator
    Friend WithEvents chkManualCaptcha As System.Windows.Forms.RadioButton
    Friend WithEvents chkDismissCaptcha As System.Windows.Forms.RadioButton
    Friend WithEvents chkDBC As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Seperator5 As Tubenoia.Seperator
End Class
