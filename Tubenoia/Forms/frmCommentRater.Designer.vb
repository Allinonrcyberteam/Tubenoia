<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommentRater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommentRater))
        Me.Theme = New Tubenoia.NTheme()
        Me.Seperator3 = New Tubenoia.Seperator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timeout = New System.Windows.Forms.NumericUpDown()
        Me.Seperator2 = New Tubenoia.Seperator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Delay = New System.Windows.Forms.NumericUpDown()
        Me.rDn = New System.Windows.Forms.RadioButton()
        Me.rUp = New System.Windows.Forms.RadioButton()
        Me.btnStart = New Tubenoia.NButton()
        Me.Userlist = New System.Windows.Forms.ListView()
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PPORT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PU = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtCID = New System.Windows.Forms.TextBox()
        Me.Seperator1 = New Tubenoia.Seperator()
        Me.btnFind = New Tubenoia.NButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.seperatorA = New Tubenoia.Seperator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.Theme.SuspendLayout()
        CType(Me.Timeout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Delay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.Seperator3)
        Me.Theme.Controls.Add(Me.Label3)
        Me.Theme.Controls.Add(Me.Timeout)
        Me.Theme.Controls.Add(Me.Seperator2)
        Me.Theme.Controls.Add(Me.Label2)
        Me.Theme.Controls.Add(Me.Delay)
        Me.Theme.Controls.Add(Me.rDn)
        Me.Theme.Controls.Add(Me.rUp)
        Me.Theme.Controls.Add(Me.btnStart)
        Me.Theme.Controls.Add(Me.Userlist)
        Me.Theme.Controls.Add(Me.txtCID)
        Me.Theme.Controls.Add(Me.Seperator1)
        Me.Theme.Controls.Add(Me.btnFind)
        Me.Theme.Controls.Add(Me.CheckBox1)
        Me.Theme.Controls.Add(Me.seperatorA)
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 22
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(955, 489)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Comment Rater"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
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
        Me.Seperator3.Location = New System.Drawing.Point(8, 198)
        Me.Seperator3.Name = "Seperator3"
        Me.Seperator3.NoRounding = False
        Me.Seperator3.Size = New System.Drawing.Size(939, 10)
        Me.Seperator3.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Proxy Timeout (seconds)"
        '
        'Timeout
        '
        Me.Timeout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Timeout.Location = New System.Drawing.Point(13, 175)
        Me.Timeout.Name = "Timeout"
        Me.Timeout.Size = New System.Drawing.Size(930, 21)
        Me.Timeout.TabIndex = 42
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
        Me.Seperator2.Location = New System.Drawing.Point(8, 147)
        Me.Seperator2.Name = "Seperator2"
        Me.Seperator2.NoRounding = False
        Me.Seperator2.Size = New System.Drawing.Size(939, 10)
        Me.Seperator2.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Delay (seconds)"
        '
        'Delay
        '
        Me.Delay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Delay.Location = New System.Drawing.Point(13, 124)
        Me.Delay.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Delay.Name = "Delay"
        Me.Delay.Size = New System.Drawing.Size(930, 21)
        Me.Delay.TabIndex = 39
        '
        'rDn
        '
        Me.rDn.AutoSize = True
        Me.rDn.Location = New System.Drawing.Point(200, 81)
        Me.rDn.Name = "rDn"
        Me.rDn.Size = New System.Drawing.Size(91, 17)
        Me.rDn.TabIndex = 38
        Me.rDn.Text = "Thumbs down"
        Me.rDn.UseVisualStyleBackColor = True
        '
        'rUp
        '
        Me.rUp.AutoSize = True
        Me.rUp.Checked = True
        Me.rUp.Location = New System.Drawing.Point(117, 82)
        Me.rUp.Name = "rUp"
        Me.rUp.Size = New System.Drawing.Size(77, 17)
        Me.rUp.TabIndex = 37
        Me.rUp.TabStop = True
        Me.rUp.Text = "Thumbs up"
        Me.rUp.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Image = Nothing
        Me.btnStart.Location = New System.Drawing.Point(12, 454)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.NoRounding = False
        Me.btnStart.Size = New System.Drawing.Size(931, 23)
        Me.btnStart.TabIndex = 36
        Me.btnStart.Text = "Start"
        '
        'Userlist
        '
        Me.Userlist.AllowDrop = True
        Me.Userlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Userlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Username, Me.Password, Me.PIP, Me.PPORT, Me.PU, Me.PP, Me.Status})
        Me.Userlist.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Userlist.FullRowSelect = True
        Me.Userlist.GridLines = True
        Me.Userlist.Location = New System.Drawing.Point(12, 208)
        Me.Userlist.Name = "Userlist"
        Me.Userlist.Size = New System.Drawing.Size(931, 240)
        Me.Userlist.TabIndex = 35
        Me.Userlist.UseCompatibleStateImageBehavior = False
        Me.Userlist.View = System.Windows.Forms.View.Details
        '
        'Username
        '
        Me.Username.Text = "Username"
        Me.Username.Width = 136
        '
        'Password
        '
        Me.Password.Text = "Password"
        Me.Password.Width = 138
        '
        'PIP
        '
        Me.PIP.Text = "Proxy IP"
        Me.PIP.Width = 125
        '
        'PPORT
        '
        Me.PPORT.Text = "Proxy Port"
        Me.PPORT.Width = 78
        '
        'PU
        '
        Me.PU.Text = "Proxy Username"
        Me.PU.Width = 118
        '
        'PP
        '
        Me.PP.Text = "Proxy Password"
        Me.PP.Width = 119
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 153
        '
        'txtCID
        '
        Me.txtCID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCID.Enabled = False
        Me.txtCID.Location = New System.Drawing.Point(12, 55)
        Me.txtCID.Name = "txtCID"
        Me.txtCID.Size = New System.Drawing.Size(768, 21)
        Me.txtCID.TabIndex = 13
        '
        'Seperator1
        '
        Me.Seperator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator1.BackColor = System.Drawing.Color.White
        Me.Seperator1.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator1.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator1.Direction = System.Windows.Forms.Orientation.Vertical
        Me.Seperator1.Image = Nothing
        Me.Seperator1.Location = New System.Drawing.Point(778, 35)
        Me.Seperator1.Name = "Seperator1"
        Me.Seperator1.NoRounding = False
        Me.Seperator1.Size = New System.Drawing.Size(10, 68)
        Me.Seperator1.TabIndex = 26
        '
        'btnFind
        '
        Me.btnFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFind.Image = Nothing
        Me.btnFind.Location = New System.Drawing.Point(788, 38)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.NoRounding = False
        Me.btnFind.Size = New System.Drawing.Size(155, 61)
        Me.btnFind.TabIndex = 25
        Me.btnFind.Text = "Find Comment ID from a comment"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(14, 82)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(97, 17)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "Enter manually"
        Me.CheckBox1.UseVisualStyleBackColor = True
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
        Me.seperatorA.Location = New System.Drawing.Point(8, 98)
        Me.seperatorA.Name = "seperatorA"
        Me.seperatorA.NoRounding = False
        Me.seperatorA.Size = New System.Drawing.Size(939, 10)
        Me.seperatorA.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "43 Character Comment ID"
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(905, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 14
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(927, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "X"
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem6, Me.MenuItem4, Me.MenuItem5})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Clear List"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Delete"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Load List"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 3
        Me.MenuItem6.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.Text = "Export List"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.Text = "Remove All Invalid"
        '
        'frmCommentRater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 489)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCommentRater"
        Me.Text = "Tubenoia — Comment Rater"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        CType(Me.Timeout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Delay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents txtCID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents seperatorA As Tubenoia.Seperator
    Friend WithEvents btnFind As Tubenoia.NButton
    Friend WithEvents Seperator1 As Tubenoia.Seperator
    Friend WithEvents Userlist As System.Windows.Forms.ListView
    Friend WithEvents Username As System.Windows.Forms.ColumnHeader
    Friend WithEvents Password As System.Windows.Forms.ColumnHeader
    Friend WithEvents PIP As System.Windows.Forms.ColumnHeader
    Friend WithEvents PPORT As System.Windows.Forms.ColumnHeader
    Friend WithEvents PU As System.Windows.Forms.ColumnHeader
    Friend WithEvents PP As System.Windows.Forms.ColumnHeader
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents btnStart As Tubenoia.NButton
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents rDn As System.Windows.Forms.RadioButton
    Friend WithEvents rUp As System.Windows.Forms.RadioButton
    Friend WithEvents Seperator3 As Tubenoia.Seperator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timeout As System.Windows.Forms.NumericUpDown
    Friend WithEvents Seperator2 As Tubenoia.Seperator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Delay As System.Windows.Forms.NumericUpDown
End Class
