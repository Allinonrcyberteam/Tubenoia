<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMassUploader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMassUploader))
        Me.CMa = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.CMf = New System.Windows.Forms.ContextMenu()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.Theme = New Tubenoia.NTheme()
        Me.btnAdd = New Tubenoia.NButton()
        Me.chkUnique = New System.Windows.Forms.CheckBox()
        Me.rRand = New System.Windows.Forms.RadioButton()
        Me.rAll = New System.Windows.Forms.RadioButton()
        Me.btnStart = New Tubenoia.NButton()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.lstQueue = New Tubenoia.ListViewEmbeddedControls.ListViewEx()
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Seperator1 = New Tubenoia.Seperator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstFiles = New Tubenoia.ListViewEmbeddedControls.ListViewEx()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.seperatorB = New Tubenoia.Seperator()
        Me.Userlist = New System.Windows.Forms.ListView()
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PPORT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PU = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMq = New System.Windows.Forms.ContextMenu()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
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
        'CMf
        '
        Me.CMf.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem7, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6})
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Add video"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.Text = "Edit video"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "Clear list"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Text = "Delete"
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.btnAdd)
        Me.Theme.Controls.Add(Me.chkUnique)
        Me.Theme.Controls.Add(Me.rRand)
        Me.Theme.Controls.Add(Me.rAll)
        Me.Theme.Controls.Add(Me.btnStart)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.lstQueue)
        Me.Theme.Controls.Add(Me.Label2)
        Me.Theme.Controls.Add(Me.Seperator1)
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Controls.Add(Me.lstFiles)
        Me.Theme.Controls.Add(Me.seperatorB)
        Me.Theme.Controls.Add(Me.Userlist)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 22
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(1077, 610)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Mass Uploader"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Image = Nothing
        Me.btnAdd.Location = New System.Drawing.Point(12, 312)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.NoRounding = False
        Me.btnAdd.Size = New System.Drawing.Size(1053, 23)
        Me.btnAdd.TabIndex = 47
        Me.btnAdd.Text = "Add to queue"
        '
        'chkUnique
        '
        Me.chkUnique.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkUnique.AutoSize = True
        Me.chkUnique.Location = New System.Drawing.Point(12, 551)
        Me.chkUnique.Name = "chkUnique"
        Me.chkUnique.Size = New System.Drawing.Size(135, 17)
        Me.chkUnique.TabIndex = 1
        Me.chkUnique.Text = "Uniquify before upload"
        Me.chkUnique.UseVisualStyleBackColor = True
        '
        'rRand
        '
        Me.rRand.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rRand.AutoSize = True
        Me.rRand.Location = New System.Drawing.Point(939, 551)
        Me.rRand.Name = "rRand"
        Me.rRand.Size = New System.Drawing.Size(126, 17)
        Me.rRand.TabIndex = 2
        Me.rRand.Text = "Upload random video"
        Me.rRand.UseVisualStyleBackColor = True
        '
        'rAll
        '
        Me.rAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rAll.AutoSize = True
        Me.rAll.Checked = True
        Me.rAll.Location = New System.Drawing.Point(828, 551)
        Me.rAll.Name = "rAll"
        Me.rAll.Size = New System.Drawing.Size(105, 17)
        Me.rAll.TabIndex = 3
        Me.rAll.TabStop = True
        Me.rAll.Text = "Upload all videos"
        Me.rAll.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Image = Nothing
        Me.btnStart.Location = New System.Drawing.Point(12, 574)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.NoRounding = False
        Me.btnStart.Size = New System.Drawing.Size(1053, 23)
        Me.btnStart.TabIndex = 46
        Me.btnStart.Text = "Start"
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(1027, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 45
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(1049, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 44
        Me.btnExit.Text = "X"
        '
        'lstQueue
        '
        Me.lstQueue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstQueue.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader20, Me.ColumnHeader15, Me.ColumnHeader14, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.lstQueue.FullRowSelect = True
        Me.lstQueue.GridLines = True
        Me.lstQueue.Location = New System.Drawing.Point(12, 356)
        Me.lstQueue.Name = "lstQueue"
        Me.lstQueue.Size = New System.Drawing.Size(1053, 192)
        Me.lstQueue.TabIndex = 43
        Me.lstQueue.UseCompatibleStateImageBehavior = False
        Me.lstQueue.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "ID"
        Me.ColumnHeader20.Width = 23
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Username"
        Me.ColumnHeader15.Width = 87
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Password"
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Proxy IP"
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Proxy Port"
        Me.ColumnHeader17.Width = 68
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Proxy Username"
        Me.ColumnHeader18.Width = 106
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Proxy Password"
        Me.ColumnHeader19.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Title"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Description"
        Me.ColumnHeader8.Width = 90
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Keywords"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Category"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "File Path"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Privacy"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Status"
        Me.ColumnHeader13.Width = 127
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(519, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Queue"
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
        Me.Seperator1.Location = New System.Drawing.Point(8, 341)
        Me.Seperator1.Name = "Seperator1"
        Me.Seperator1.NoRounding = False
        Me.Seperator1.Size = New System.Drawing.Size(1061, 10)
        Me.Seperator1.TabIndex = 41
        Me.Seperator1.Text = "Seperator2"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(528, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Files"
        '
        'lstFiles
        '
        Me.lstFiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstFiles.FullRowSelect = True
        Me.lstFiles.GridLines = True
        Me.lstFiles.Location = New System.Drawing.Point(12, 187)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.Size = New System.Drawing.Size(1053, 119)
        Me.lstFiles.TabIndex = 39
        Me.lstFiles.UseCompatibleStateImageBehavior = False
        Me.lstFiles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Title"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 179
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Keywords"
        Me.ColumnHeader3.Width = 125
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Category"
        Me.ColumnHeader4.Width = 97
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "File Path"
        Me.ColumnHeader5.Width = 309
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Privacy"
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
        Me.seperatorB.Location = New System.Drawing.Point(8, 171)
        Me.seperatorB.Name = "seperatorB"
        Me.seperatorB.NoRounding = False
        Me.seperatorB.Size = New System.Drawing.Size(1061, 10)
        Me.seperatorB.TabIndex = 38
        Me.seperatorB.Text = "Seperator2"
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
        Me.Userlist.Location = New System.Drawing.Point(12, 39)
        Me.Userlist.Name = "Userlist"
        Me.Userlist.Size = New System.Drawing.Size(1053, 126)
        Me.Userlist.TabIndex = 37
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
        Me.PPORT.Width = 68
        '
        'PU
        '
        Me.PU.Text = "Proxy Username"
        Me.PU.Width = 109
        '
        'PP
        '
        Me.PP.Text = "Proxy Password"
        Me.PP.Width = 102
        '
        'CMq
        '
        Me.CMq.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11, Me.MenuItem12})
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Text = "Clear list"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "-"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Text = "Export video list"
        '
        'frmMassUploader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 610)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMassUploader"
        Me.Text = "Tubenoia — Mass Uploader"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents Userlist As System.Windows.Forms.ListView
    Friend WithEvents Username As System.Windows.Forms.ColumnHeader
    Friend WithEvents Password As System.Windows.Forms.ColumnHeader
    Friend WithEvents PIP As System.Windows.Forms.ColumnHeader
    Friend WithEvents PPORT As System.Windows.Forms.ColumnHeader
    Friend WithEvents PU As System.Windows.Forms.ColumnHeader
    Friend WithEvents PP As System.Windows.Forms.ColumnHeader
    Friend WithEvents seperatorB As Tubenoia.Seperator
    Friend WithEvents CMa As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents lstQueue As Tubenoia.ListViewEmbeddedControls.ListViewEx
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Seperator1 As Tubenoia.Seperator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstFiles As Tubenoia.ListViewEmbeddedControls.ListViewEx
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CMf As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents btnStart As Tubenoia.NButton
    Friend WithEvents chkUnique As System.Windows.Forms.CheckBox
    Friend WithEvents rRand As System.Windows.Forms.RadioButton
    Friend WithEvents rAll As System.Windows.Forms.RadioButton
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAdd As Tubenoia.NButton
    Friend WithEvents CMq As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
End Class
