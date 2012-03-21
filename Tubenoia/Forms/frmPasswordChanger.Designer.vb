<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPasswordChanger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPasswordChanger))
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.Theme = New Tubenoia.NTheme()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Seperator2 = New Tubenoia.Seperator()
        Me.lstPasswords = New System.Windows.Forms.ListView()
        Me.Passwords = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstNew = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.btnStart = New Tubenoia.NButton()
        Me.Usercount = New Tubenoia.NButton()
        Me.Userlist = New System.Windows.Forms.ListView()
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PPORT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PU = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMn = New System.Windows.Forms.ContextMenu()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.CMp = New System.Windows.Forms.ContextMenu()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
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
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Controls.Add(Me.Seperator2)
        Me.Theme.Controls.Add(Me.lstPasswords)
        Me.Theme.Controls.Add(Me.lstNew)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.btnStart)
        Me.Theme.Controls.Add(Me.Usercount)
        Me.Theme.Controls.Add(Me.Userlist)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.White
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 14
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(1085, 522)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Password Changer"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(342, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Changed"
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
        Me.Seperator2.Location = New System.Drawing.Point(8, 271)
        Me.Seperator2.Name = "Seperator2"
        Me.Seperator2.NoRounding = False
        Me.Seperator2.Size = New System.Drawing.Size(775, 10)
        Me.Seperator2.TabIndex = 49
        Me.Seperator2.Text = "Seperator2"
        '
        'lstPasswords
        '
        Me.lstPasswords.AllowDrop = True
        Me.lstPasswords.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPasswords.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Passwords})
        Me.lstPasswords.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPasswords.FullRowSelect = True
        Me.lstPasswords.GridLines = True
        Me.lstPasswords.Location = New System.Drawing.Point(783, 68)
        Me.lstPasswords.Name = "lstPasswords"
        Me.lstPasswords.Size = New System.Drawing.Size(290, 412)
        Me.lstPasswords.TabIndex = 40
        Me.lstPasswords.UseCompatibleStateImageBehavior = False
        Me.lstPasswords.View = System.Windows.Forms.View.Details
        '
        'Passwords
        '
        Me.Passwords.Text = "Password"
        Me.Passwords.Width = 265
        '
        'lstNew
        '
        Me.lstNew.AllowDrop = True
        Me.lstNew.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstNew.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstNew.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNew.FullRowSelect = True
        Me.lstNew.GridLines = True
        Me.lstNew.Location = New System.Drawing.Point(12, 285)
        Me.lstNew.Name = "lstNew"
        Me.lstNew.Size = New System.Drawing.Size(765, 195)
        Me.lstNew.TabIndex = 39
        Me.lstNew.UseCompatibleStateImageBehavior = False
        Me.lstNew.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Username"
        Me.ColumnHeader1.Width = 136
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Password"
        Me.ColumnHeader2.Width = 138
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Proxy IP"
        Me.ColumnHeader3.Width = 125
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Proxy Port"
        Me.ColumnHeader4.Width = 78
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Proxy Username"
        Me.ColumnHeader5.Width = 118
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Proxy Password"
        Me.ColumnHeader6.Width = 128
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(1035, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 38
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(1057, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 37
        Me.btnExit.Text = "X"
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Image = Nothing
        Me.btnStart.Location = New System.Drawing.Point(12, 486)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.NoRounding = False
        Me.btnStart.Size = New System.Drawing.Size(1061, 23)
        Me.btnStart.TabIndex = 36
        Me.btnStart.Text = "Start Changing"
        '
        'Usercount
        '
        Me.Usercount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Usercount.Enabled = False
        Me.Usercount.Image = Nothing
        Me.Usercount.Location = New System.Drawing.Point(12, 39)
        Me.Usercount.Name = "Usercount"
        Me.Usercount.NoRounding = False
        Me.Usercount.Size = New System.Drawing.Size(1061, 23)
        Me.Usercount.TabIndex = 35
        Me.Usercount.Text = "Total Users: 0"
        '
        'Userlist
        '
        Me.Userlist.AllowDrop = True
        Me.Userlist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Userlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Username, Me.Password, Me.PIP, Me.PPORT, Me.PU, Me.PP})
        Me.Userlist.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Userlist.FullRowSelect = True
        Me.Userlist.GridLines = True
        Me.Userlist.Location = New System.Drawing.Point(12, 68)
        Me.Userlist.Name = "Userlist"
        Me.Userlist.Size = New System.Drawing.Size(765, 199)
        Me.Userlist.TabIndex = 34
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
        Me.PP.Width = 128
        '
        'CMn
        '
        Me.CMn.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11, Me.MenuItem13, Me.MenuItem14})
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Text = "Clear List"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "Delete"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 2
        Me.MenuItem13.Text = "-"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.Text = "Export List"
        '
        'CMp
        '
        Me.CMp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem12, Me.MenuItem15, Me.MenuItem16})
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 0
        Me.MenuItem12.Text = "Load list"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 1
        Me.MenuItem15.Text = "Add password"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 2
        Me.MenuItem16.Text = "Clear list"
        '
        'frmPasswordChanger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 522)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPasswordChanger"
        Me.Text = "Tubenoia — Password Changer"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents Userlist As System.Windows.Forms.ListView
    Friend WithEvents Username As System.Windows.Forms.ColumnHeader
    Friend WithEvents Password As System.Windows.Forms.ColumnHeader
    Friend WithEvents Usercount As Tubenoia.nbutton
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents btnStart As Tubenoia.nbutton
    Friend WithEvents btnMinimize As Tubenoia.nbutton
    Friend WithEvents btnExit As Tubenoia.nbutton
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents PIP As System.Windows.Forms.ColumnHeader
    Friend WithEvents PPORT As System.Windows.Forms.ColumnHeader
    Friend WithEvents PU As System.Windows.Forms.ColumnHeader
    Friend WithEvents PP As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstNew As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstPasswords As System.Windows.Forms.ListView
    Friend WithEvents Passwords As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Seperator2 As Tubenoia.Seperator
    Friend WithEvents CMn As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents CMp As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
End Class
