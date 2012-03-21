<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFriendAdder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFriendAdder))
        Me.Theme = New Tubenoia.NTheme()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnStart = New Tubenoia.NButton()
        Me.btnPause = New Tubenoia.NButton()
        Me.lstFriends = New System.Windows.Forms.ListView()
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Channel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Gpbox2 = New Tubenoia.GPBOX()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Seperator1 = New Tubenoia.Seperator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Gpbox1 = New Tubenoia.GPBOX()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lstLog = New Tubenoia.ListViewEmbeddedControls.ListViewEx()
        Me.lT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lLog = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblFailed = New System.Windows.Forms.Label()
        Me.Seperator5 = New Tubenoia.Seperator()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblSuccess = New System.Windows.Forms.Label()
        Me.Seperator4 = New Tubenoia.Seperator()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNext = New System.Windows.Forms.Label()
        Me.Seperator3 = New Tubenoia.Seperator()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Seperator2 = New Tubenoia.Seperator()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Seperator10 = New Tubenoia.Seperator()
        Me.Seperator9 = New Tubenoia.Seperator()
        Me.Seperator8 = New Tubenoia.Seperator()
        Me.Seperator7 = New Tubenoia.Seperator()
        Me.Seperator6 = New Tubenoia.Seperator()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMaxFail = New System.Windows.Forms.Label()
        Me.lblMinFail = New System.Windows.Forms.Label()
        Me.Maximum = New System.Windows.Forms.TrackBar()
        Me.failedMaximum = New System.Windows.Forms.TrackBar()
        Me.Minimum = New System.Windows.Forms.TrackBar()
        Me.failedMinimum = New System.Windows.Forms.TrackBar()
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.Theme.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Maximum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.failedMaximum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minimum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.failedMinimum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.TabControl1)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 22
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(665, 555)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Mass Friend Adder"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(615, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 16
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(637, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "X"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(641, 504)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnStart)
        Me.TabPage1.Controls.Add(Me.btnPause)
        Me.TabPage1.Controls.Add(Me.lstFriends)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Gpbox2)
        Me.TabPage1.Controls.Add(Me.txtPassword)
        Me.TabPage1.Controls.Add(Me.txtUsername)
        Me.TabPage1.Controls.Add(Me.Seperator1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Gpbox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(633, 478)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sending"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Image = Nothing
        Me.btnStart.Location = New System.Drawing.Point(4, 429)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.NoRounding = False
        Me.btnStart.Size = New System.Drawing.Size(626, 23)
        Me.btnStart.TabIndex = 22
        Me.btnStart.Text = "Start"
        '
        'btnPause
        '
        Me.btnPause.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPause.Image = Nothing
        Me.btnPause.Location = New System.Drawing.Point(4, 451)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.NoRounding = False
        Me.btnPause.Size = New System.Drawing.Size(626, 23)
        Me.btnPause.TabIndex = 23
        Me.btnPause.Text = "Pause"
        '
        'lstFriends
        '
        Me.lstFriends.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstFriends.AllowColumnReorder = True
        Me.lstFriends.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstFriends.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Username, Me.Channel})
        Me.lstFriends.FullRowSelect = True
        Me.lstFriends.GridLines = True
        Me.lstFriends.Location = New System.Drawing.Point(11, 107)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(610, 313)
        Me.lstFriends.TabIndex = 21
        Me.lstFriends.UseCompatibleStateImageBehavior = False
        Me.lstFriends.View = System.Windows.Forms.View.Details
        '
        'Username
        '
        Me.Username.Text = "Username"
        Me.Username.Width = 172
        '
        'Channel
        '
        Me.Channel.Text = "Channel"
        Me.Channel.Width = 370
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Channels"
        '
        'Gpbox2
        '
        Me.Gpbox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gpbox2.Border1 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Gpbox2.Border2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gpbox2.FillColor = System.Drawing.Color.Transparent
        Me.Gpbox2.Image = Nothing
        Me.Gpbox2.Location = New System.Drawing.Point(4, 96)
        Me.Gpbox2.Name = "Gpbox2"
        Me.Gpbox2.NoRounding = False
        Me.Gpbox2.Size = New System.Drawing.Size(626, 330)
        Me.Gpbox2.TabIndex = 19
        Me.Gpbox2.Text = "Gpbox2"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.Location = New System.Drawing.Point(83, 58)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(538, 21)
        Me.txtPassword.TabIndex = 18
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsername.Location = New System.Drawing.Point(83, 23)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(538, 21)
        Me.txtUsername.TabIndex = 17
        '
        'Seperator1
        '
        Me.Seperator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator1.Color1 = System.Drawing.Color.Silver
        Me.Seperator1.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator1.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator1.Image = Nothing
        Me.Seperator1.Location = New System.Drawing.Point(5, 45)
        Me.Seperator1.Name = "Seperator1"
        Me.Seperator1.NoRounding = False
        Me.Seperator1.Size = New System.Drawing.Size(624, 10)
        Me.Seperator1.TabIndex = 16
        Me.Seperator1.Text = "Seperator1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Account Information"
        '
        'Gpbox1
        '
        Me.Gpbox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gpbox1.Border1 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Gpbox1.Border2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gpbox1.FillColor = System.Drawing.Color.Transparent
        Me.Gpbox1.Image = Nothing
        Me.Gpbox1.Location = New System.Drawing.Point(4, 10)
        Me.Gpbox1.Name = "Gpbox1"
        Me.Gpbox1.NoRounding = False
        Me.Gpbox1.Size = New System.Drawing.Size(626, 78)
        Me.Gpbox1.TabIndex = 12
        Me.Gpbox1.Text = "Gpbox1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lstLog)
        Me.TabPage2.Controls.Add(Me.lblFailed)
        Me.TabPage2.Controls.Add(Me.Seperator5)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.lblSuccess)
        Me.TabPage2.Controls.Add(Me.Seperator4)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.lblNext)
        Me.TabPage2.Controls.Add(Me.Seperator3)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.lblTotal)
        Me.TabPage2.Controls.Add(Me.Seperator2)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(633, 478)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Statistics"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lstLog
        '
        Me.lstLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstLog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lT, Me.lLog})
        Me.lstLog.GridLines = True
        Me.lstLog.Location = New System.Drawing.Point(6, 194)
        Me.lstLog.Name = "lstLog"
        Me.lstLog.Size = New System.Drawing.Size(621, 278)
        Me.lstLog.TabIndex = 12
        Me.lstLog.UseCompatibleStateImageBehavior = False
        Me.lstLog.View = System.Windows.Forms.View.Details
        '
        'lT
        '
        Me.lT.Text = "Time"
        Me.lT.Width = 97
        '
        'lLog
        '
        Me.lLog.Text = "Log"
        Me.lLog.Width = 487
        '
        'lblFailed
        '
        Me.lblFailed.AutoSize = True
        Me.lblFailed.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFailed.Location = New System.Drawing.Point(316, 147)
        Me.lblFailed.Name = "lblFailed"
        Me.lblFailed.Size = New System.Drawing.Size(30, 33)
        Me.lblFailed.TabIndex = 11
        Me.lblFailed.Text = "0"
        '
        'Seperator5
        '
        Me.Seperator5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator5.Color1 = System.Drawing.Color.Silver
        Me.Seperator5.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator5.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator5.Image = Nothing
        Me.Seperator5.Location = New System.Drawing.Point(-1, 182)
        Me.Seperator5.Name = "Seperator5"
        Me.Seperator5.NoRounding = False
        Me.Seperator5.Size = New System.Drawing.Size(634, 10)
        Me.Seperator5.TabIndex = 10
        Me.Seperator5.Text = "Seperator5"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 33)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Failed:"
        '
        'lblSuccess
        '
        Me.lblSuccess.AutoSize = True
        Me.lblSuccess.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuccess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSuccess.Location = New System.Drawing.Point(316, 99)
        Me.lblSuccess.Name = "lblSuccess"
        Me.lblSuccess.Size = New System.Drawing.Size(30, 33)
        Me.lblSuccess.TabIndex = 8
        Me.lblSuccess.Text = "0"
        '
        'Seperator4
        '
        Me.Seperator4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator4.Color1 = System.Drawing.Color.Silver
        Me.Seperator4.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator4.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator4.Image = Nothing
        Me.Seperator4.Location = New System.Drawing.Point(-1, 134)
        Me.Seperator4.Name = "Seperator4"
        Me.Seperator4.NoRounding = False
        Me.Seperator4.Size = New System.Drawing.Size(634, 10)
        Me.Seperator4.TabIndex = 7
        Me.Seperator4.Text = "Seperator4"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 33)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Successes:"
        '
        'lblNext
        '
        Me.lblNext.AutoSize = True
        Me.lblNext.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNext.Location = New System.Drawing.Point(316, 51)
        Me.lblNext.Name = "lblNext"
        Me.lblNext.Size = New System.Drawing.Size(59, 33)
        Me.lblNext.TabIndex = 5
        Me.lblNext.Text = "N/A"
        '
        'Seperator3
        '
        Me.Seperator3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator3.Color1 = System.Drawing.Color.Silver
        Me.Seperator3.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator3.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator3.Image = Nothing
        Me.Seperator3.Location = New System.Drawing.Point(-1, 86)
        Me.Seperator3.Name = "Seperator3"
        Me.Seperator3.NoRounding = False
        Me.Seperator3.Size = New System.Drawing.Size(634, 10)
        Me.Seperator3.TabIndex = 4
        Me.Seperator3.Text = "Seperator3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(215, 33)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Recently sent to:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(316, 3)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(30, 33)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "0"
        '
        'Seperator2
        '
        Me.Seperator2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator2.Color1 = System.Drawing.Color.Silver
        Me.Seperator2.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator2.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator2.Image = Nothing
        Me.Seperator2.Location = New System.Drawing.Point(-1, 38)
        Me.Seperator2.Name = "Seperator2"
        Me.Seperator2.NoRounding = False
        Me.Seperator2.Size = New System.Drawing.Size(634, 10)
        Me.Seperator2.TabIndex = 1
        Me.Seperator2.Text = "Seperator2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(304, 33)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Friend requests to send:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Seperator10)
        Me.TabPage3.Controls.Add(Me.Seperator9)
        Me.TabPage3.Controls.Add(Me.Seperator8)
        Me.TabPage3.Controls.Add(Me.Seperator7)
        Me.TabPage3.Controls.Add(Me.Seperator6)
        Me.TabPage3.Controls.Add(Me.lblMax)
        Me.TabPage3.Controls.Add(Me.lblMin)
        Me.TabPage3.Controls.Add(Me.lblMaxFail)
        Me.TabPage3.Controls.Add(Me.lblMinFail)
        Me.TabPage3.Controls.Add(Me.Maximum)
        Me.TabPage3.Controls.Add(Me.failedMaximum)
        Me.TabPage3.Controls.Add(Me.Minimum)
        Me.TabPage3.Controls.Add(Me.failedMinimum)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(633, 478)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Options"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 310)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 19)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Minimum"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 406)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 19)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Maximum"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 275)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(260, 19)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Delay when limit reached (seconds)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 19)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Maximum"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 19)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Minimum"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Delay (seconds)"
        '
        'Seperator10
        '
        Me.Seperator10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator10.Color1 = System.Drawing.Color.DarkGray
        Me.Seperator10.Color2 = System.Drawing.Color.Silver
        Me.Seperator10.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator10.Image = Nothing
        Me.Seperator10.Location = New System.Drawing.Point(-1, 218)
        Me.Seperator10.Name = "Seperator10"
        Me.Seperator10.NoRounding = False
        Me.Seperator10.Size = New System.Drawing.Size(634, 10)
        Me.Seperator10.TabIndex = 18
        Me.Seperator10.Text = "Seperator10"
        '
        'Seperator9
        '
        Me.Seperator9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator9.Color1 = System.Drawing.Color.Silver
        Me.Seperator9.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator9.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator9.Image = Nothing
        Me.Seperator9.Location = New System.Drawing.Point(-1, 297)
        Me.Seperator9.Name = "Seperator9"
        Me.Seperator9.NoRounding = False
        Me.Seperator9.Size = New System.Drawing.Size(634, 10)
        Me.Seperator9.TabIndex = 12
        Me.Seperator9.Text = "Seperator9"
        '
        'Seperator8
        '
        Me.Seperator8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator8.Color1 = System.Drawing.Color.Silver
        Me.Seperator8.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator8.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator8.Image = Nothing
        Me.Seperator8.Location = New System.Drawing.Point(-1, 372)
        Me.Seperator8.Name = "Seperator8"
        Me.Seperator8.NoRounding = False
        Me.Seperator8.Size = New System.Drawing.Size(634, 10)
        Me.Seperator8.TabIndex = 13
        Me.Seperator8.Text = "Seperator8"
        '
        'Seperator7
        '
        Me.Seperator7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator7.Color1 = System.Drawing.Color.Silver
        Me.Seperator7.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator7.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator7.Image = Nothing
        Me.Seperator7.Location = New System.Drawing.Point(-1, 105)
        Me.Seperator7.Name = "Seperator7"
        Me.Seperator7.NoRounding = False
        Me.Seperator7.Size = New System.Drawing.Size(634, 10)
        Me.Seperator7.TabIndex = 8
        Me.Seperator7.Text = "Seperator7"
        '
        'Seperator6
        '
        Me.Seperator6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator6.Color1 = System.Drawing.Color.Silver
        Me.Seperator6.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator6.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator6.Image = Nothing
        Me.Seperator6.Location = New System.Drawing.Point(-1, 30)
        Me.Seperator6.Name = "Seperator6"
        Me.Seperator6.NoRounding = False
        Me.Seperator6.Size = New System.Drawing.Size(634, 10)
        Me.Seperator6.TabIndex = 3
        Me.Seperator6.Text = "Seperator6"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.Location = New System.Drawing.Point(546, 139)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(61, 19)
        Me.lblMax.TabIndex = 7
        Me.lblMax.Text = "10 secs"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.Location = New System.Drawing.Point(546, 43)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(61, 19)
        Me.lblMin.TabIndex = 6
        Me.lblMin.Text = "10 secs"
        '
        'lblMaxFail
        '
        Me.lblMaxFail.AutoSize = True
        Me.lblMaxFail.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxFail.Location = New System.Drawing.Point(546, 406)
        Me.lblMaxFail.Name = "lblMaxFail"
        Me.lblMaxFail.Size = New System.Drawing.Size(70, 19)
        Me.lblMaxFail.TabIndex = 15
        Me.lblMaxFail.Text = "250 secs"
        '
        'lblMinFail
        '
        Me.lblMinFail.AutoSize = True
        Me.lblMinFail.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinFail.Location = New System.Drawing.Point(546, 310)
        Me.lblMinFail.Name = "lblMinFail"
        Me.lblMinFail.Size = New System.Drawing.Size(70, 19)
        Me.lblMinFail.TabIndex = 14
        Me.lblMinFail.Text = "250 secs"
        '
        'Maximum
        '
        Me.Maximum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Maximum.BackColor = System.Drawing.Color.White
        Me.Maximum.Location = New System.Drawing.Point(10, 161)
        Me.Maximum.Maximum = 900
        Me.Maximum.Minimum = 10
        Me.Maximum.Name = "Maximum"
        Me.Maximum.Size = New System.Drawing.Size(611, 45)
        Me.Maximum.TabIndex = 1
        Me.Maximum.TickStyle = System.Windows.Forms.TickStyle.None
        Me.Maximum.Value = 10
        '
        'failedMaximum
        '
        Me.failedMaximum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.failedMaximum.BackColor = System.Drawing.Color.White
        Me.failedMaximum.Location = New System.Drawing.Point(10, 428)
        Me.failedMaximum.Maximum = 900
        Me.failedMaximum.Minimum = 250
        Me.failedMaximum.Name = "failedMaximum"
        Me.failedMaximum.Size = New System.Drawing.Size(611, 45)
        Me.failedMaximum.TabIndex = 10
        Me.failedMaximum.TickStyle = System.Windows.Forms.TickStyle.None
        Me.failedMaximum.Value = 250
        '
        'Minimum
        '
        Me.Minimum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimum.BackColor = System.Drawing.Color.White
        Me.Minimum.Location = New System.Drawing.Point(10, 65)
        Me.Minimum.Maximum = 900
        Me.Minimum.Minimum = 10
        Me.Minimum.Name = "Minimum"
        Me.Minimum.Size = New System.Drawing.Size(611, 45)
        Me.Minimum.TabIndex = 0
        Me.Minimum.TickStyle = System.Windows.Forms.TickStyle.None
        Me.Minimum.Value = 10
        '
        'failedMinimum
        '
        Me.failedMinimum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.failedMinimum.BackColor = System.Drawing.Color.White
        Me.failedMinimum.Location = New System.Drawing.Point(10, 332)
        Me.failedMinimum.Maximum = 900
        Me.failedMinimum.Minimum = 250
        Me.failedMinimum.Name = "failedMinimum"
        Me.failedMinimum.Size = New System.Drawing.Size(611, 45)
        Me.failedMinimum.TabIndex = 9
        Me.failedMinimum.TickStyle = System.Windows.Forms.TickStyle.None
        Me.failedMinimum.Value = 250
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Load list"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Clear list"
        '
        'frmFriendAdder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 555)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFriendAdder"
        Me.Text = "Tubenoia — Mass Friend Adder"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.Maximum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.failedMaximum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minimum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.failedMinimum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents btnPause As Tubenoia.NButton
    Friend WithEvents btnStart As Tubenoia.NButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Gpbox1 As Tubenoia.GPBOX
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Seperator1 As Tubenoia.Seperator
    Friend WithEvents Gpbox2 As Tubenoia.GPBOX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstFriends As System.Windows.Forms.ListView
    Friend WithEvents Username As System.Windows.Forms.ColumnHeader
    Friend WithEvents Channel As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstLog As Tubenoia.ListViewEmbeddedControls.ListViewEx
    Friend WithEvents lT As System.Windows.Forms.ColumnHeader
    Friend WithEvents lLog As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblFailed As System.Windows.Forms.Label
    Friend WithEvents Seperator5 As Tubenoia.Seperator
    Friend WithEvents Seperator4 As Tubenoia.Seperator
    Friend WithEvents Seperator3 As Tubenoia.Seperator
    Friend WithEvents Seperator2 As Tubenoia.Seperator
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblSuccess As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblNext As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Maximum As System.Windows.Forms.TrackBar
    Friend WithEvents failedMaximum As System.Windows.Forms.TrackBar
    Friend WithEvents Minimum As System.Windows.Forms.TrackBar
    Friend WithEvents failedMinimum As System.Windows.Forms.TrackBar
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblMaxFail As System.Windows.Forms.Label
    Friend WithEvents lblMinFail As System.Windows.Forms.Label
    Friend WithEvents Seperator10 As Tubenoia.Seperator
    Friend WithEvents Seperator9 As Tubenoia.Seperator
    Friend WithEvents Seperator8 As Tubenoia.Seperator
    Friend WithEvents Seperator7 As Tubenoia.Seperator
    Friend WithEvents Seperator6 As Tubenoia.Seperator
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
End Class
