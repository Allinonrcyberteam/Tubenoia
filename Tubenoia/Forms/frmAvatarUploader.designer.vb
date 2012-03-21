<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvatarUploader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAvatarUploader))
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.Theme = New Tubenoia.NTheme()
        Me.lstAvatars = New System.Windows.Forms.ListView()
        Me.Picture_Path = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.CM2 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
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
        Me.Theme.Controls.Add(Me.lstAvatars)
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
        Me.Theme.Size = New System.Drawing.Size(812, 522)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Avatar Uploader"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'lstAvatars
        '
        Me.lstAvatars.AllowDrop = True
        Me.lstAvatars.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAvatars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Picture_Path})
        Me.lstAvatars.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAvatars.FullRowSelect = True
        Me.lstAvatars.GridLines = True
        Me.lstAvatars.Location = New System.Drawing.Point(12, 68)
        Me.lstAvatars.Name = "lstAvatars"
        Me.lstAvatars.Size = New System.Drawing.Size(788, 192)
        Me.lstAvatars.TabIndex = 39
        Me.lstAvatars.UseCompatibleStateImageBehavior = False
        Me.lstAvatars.View = System.Windows.Forms.View.Details
        '
        'Picture_Path
        '
        Me.Picture_Path.Text = "Picture Path"
        Me.Picture_Path.Width = 732
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(762, 4)
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
        Me.btnExit.Location = New System.Drawing.Point(784, 4)
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
        Me.btnStart.Size = New System.Drawing.Size(788, 23)
        Me.btnStart.TabIndex = 36
        Me.btnStart.Text = "Start Uploading"
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
        Me.Usercount.Size = New System.Drawing.Size(788, 23)
        Me.Usercount.TabIndex = 35
        Me.Usercount.Text = "Total Users: 0"
        '
        'Userlist
        '
        Me.Userlist.AllowDrop = True
        Me.Userlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Userlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Username, Me.Password, Me.PIP, Me.PPORT, Me.PU, Me.PP})
        Me.Userlist.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Userlist.FullRowSelect = True
        Me.Userlist.GridLines = True
        Me.Userlist.Location = New System.Drawing.Point(12, 266)
        Me.Userlist.Name = "Userlist"
        Me.Userlist.Size = New System.Drawing.Size(788, 216)
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
        'CM2
        '
        Me.CM2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem10, Me.MenuItem9, Me.MenuItem8})
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.Text = "Clear List"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 1
        Me.MenuItem10.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.Text = "Load File"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 3
        Me.MenuItem8.Text = "Load Folder"
        '
        'frmAvatarUploader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 522)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAvatarUploader"
        Me.Text = "Tubenoia — Avatar Uploader"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
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
    Friend WithEvents lstAvatars As System.Windows.Forms.ListView
    Friend WithEvents Picture_Path As System.Windows.Forms.ColumnHeader
    Friend WithEvents CM2 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
End Class
