<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccProxBinder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccProxBinder))
        Me.Theme = New Tubenoia.NTheme()
        Me.btnBind = New Tubenoia.NButton()
        Me.Exportlist = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PPORT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PU = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Proxylist = New System.Windows.Forms.ListView()
        Me.IP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Port = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PUsername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PPassword = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Userlist = New System.Windows.Forms.ListView()
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.CMa = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.CMp = New System.Windows.Forms.ContextMenu()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.CMe = New System.Windows.Forms.ContextMenu()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.btnBind)
        Me.Theme.Controls.Add(Me.Exportlist)
        Me.Theme.Controls.Add(Me.Proxylist)
        Me.Theme.Controls.Add(Me.Userlist)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 22
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = False
        Me.Theme.Size = New System.Drawing.Size(765, 551)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Account and Proxy Binder"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'btnBind
        '
        Me.btnBind.Image = Nothing
        Me.btnBind.Location = New System.Drawing.Point(12, 307)
        Me.btnBind.Name = "btnBind"
        Me.btnBind.NoRounding = False
        Me.btnBind.Size = New System.Drawing.Size(741, 23)
        Me.btnBind.TabIndex = 38
        Me.btnBind.Text = "Bind accounts with proxies"
        '
        'Exportlist
        '
        Me.Exportlist.AllowDrop = True
        Me.Exportlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Exportlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.PIP, Me.PPORT, Me.PU, Me.PP})
        Me.Exportlist.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exportlist.FullRowSelect = True
        Me.Exportlist.GridLines = True
        Me.Exportlist.Location = New System.Drawing.Point(12, 336)
        Me.Exportlist.Name = "Exportlist"
        Me.Exportlist.Size = New System.Drawing.Size(741, 203)
        Me.Exportlist.TabIndex = 37
        Me.Exportlist.UseCompatibleStateImageBehavior = False
        Me.Exportlist.View = System.Windows.Forms.View.Details
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
        Me.PP.Width = 113
        '
        'Proxylist
        '
        Me.Proxylist.AllowDrop = True
        Me.Proxylist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Proxylist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IP, Me.Port, Me.PUsername, Me.PPassword})
        Me.Proxylist.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proxylist.FullRowSelect = True
        Me.Proxylist.GridLines = True
        Me.Proxylist.Location = New System.Drawing.Point(333, 40)
        Me.Proxylist.Name = "Proxylist"
        Me.Proxylist.Size = New System.Drawing.Size(420, 261)
        Me.Proxylist.TabIndex = 36
        Me.Proxylist.UseCompatibleStateImageBehavior = False
        Me.Proxylist.View = System.Windows.Forms.View.Details
        '
        'IP
        '
        Me.IP.Text = "IP Address"
        Me.IP.Width = 108
        '
        'Port
        '
        Me.Port.Text = "Port"
        '
        'PUsername
        '
        Me.PUsername.Text = "Username"
        Me.PUsername.Width = 101
        '
        'PPassword
        '
        Me.PPassword.Text = "Password"
        Me.PPassword.Width = 92
        '
        'Userlist
        '
        Me.Userlist.AllowDrop = True
        Me.Userlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Userlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Username, Me.Password})
        Me.Userlist.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Userlist.FullRowSelect = True
        Me.Userlist.GridLines = True
        Me.Userlist.Location = New System.Drawing.Point(12, 40)
        Me.Userlist.Name = "Userlist"
        Me.Userlist.Size = New System.Drawing.Size(315, 261)
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
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(715, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 29
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(737, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "X"
        '
        'CMa
        '
        Me.CMa.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
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
        'CMp
        '
        Me.CMp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem4})
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Load list"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "Clear list"
        '
        'CMe
        '
        Me.CMe.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem6})
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "Clear list"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "Export list"
        '
        'frmAccProxBinder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 551)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAccProxBinder"
        Me.Text = "Tubenoia — Account and Proxy Binder"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents Proxylist As System.Windows.Forms.ListView
    Friend WithEvents IP As System.Windows.Forms.ColumnHeader
    Friend WithEvents Port As System.Windows.Forms.ColumnHeader
    Friend WithEvents PUsername As System.Windows.Forms.ColumnHeader
    Friend WithEvents PPassword As System.Windows.Forms.ColumnHeader
    Friend WithEvents Userlist As System.Windows.Forms.ListView
    Friend WithEvents Username As System.Windows.Forms.ColumnHeader
    Friend WithEvents Password As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnBind As Tubenoia.NButton
    Friend WithEvents Exportlist As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PIP As System.Windows.Forms.ColumnHeader
    Friend WithEvents PPORT As System.Windows.Forms.ColumnHeader
    Friend WithEvents PU As System.Windows.Forms.ColumnHeader
    Friend WithEvents PP As System.Windows.Forms.ColumnHeader
    Friend WithEvents CMa As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents CMp As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents CMe As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
End Class
