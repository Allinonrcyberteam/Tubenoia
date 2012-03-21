<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUpload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddUpload))
        Me.Theme = New Tubenoia.NTheme()
        Me.rbComKinda = New System.Windows.Forms.RadioButton()
        Me.rbComDisable = New System.Windows.Forms.RadioButton()
        Me.rbComAllow = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New Tubenoia.NButton()
        Me.btnSave = New Tubenoia.NButton()
        Me.Seperator7 = New Tubenoia.Seperator()
        Me.Privacy = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Seperator6 = New Tubenoia.Seperator()
        Me.chkRatings = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Seperator5 = New Tubenoia.Seperator()
        Me.btnBrowse = New Tubenoia.NButton()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Seperator4 = New Tubenoia.Seperator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Seperator3 = New Tubenoia.Seperator()
        Me.Category = New System.Windows.Forms.ComboBox()
        Me.txtKeywords = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Seperator2 = New Tubenoia.Seperator()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Seperator1 = New Tubenoia.Seperator()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.seperatorB = New Tubenoia.Seperator()
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.rbComKinda)
        Me.Theme.Controls.Add(Me.rbComDisable)
        Me.Theme.Controls.Add(Me.rbComAllow)
        Me.Theme.Controls.Add(Me.btnCancel)
        Me.Theme.Controls.Add(Me.btnSave)
        Me.Theme.Controls.Add(Me.Seperator7)
        Me.Theme.Controls.Add(Me.Privacy)
        Me.Theme.Controls.Add(Me.Label7)
        Me.Theme.Controls.Add(Me.Seperator6)
        Me.Theme.Controls.Add(Me.chkRatings)
        Me.Theme.Controls.Add(Me.Label6)
        Me.Theme.Controls.Add(Me.Seperator5)
        Me.Theme.Controls.Add(Me.btnBrowse)
        Me.Theme.Controls.Add(Me.txtFile)
        Me.Theme.Controls.Add(Me.Label5)
        Me.Theme.Controls.Add(Me.Seperator4)
        Me.Theme.Controls.Add(Me.Label4)
        Me.Theme.Controls.Add(Me.Seperator3)
        Me.Theme.Controls.Add(Me.Category)
        Me.Theme.Controls.Add(Me.txtKeywords)
        Me.Theme.Controls.Add(Me.Label3)
        Me.Theme.Controls.Add(Me.Seperator2)
        Me.Theme.Controls.Add(Me.txtDescription)
        Me.Theme.Controls.Add(Me.Label2)
        Me.Theme.Controls.Add(Me.Seperator1)
        Me.Theme.Controls.Add(Me.txtTitle)
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Controls.Add(Me.seperatorB)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Theme.Image = Nothing
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 22
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = False
        Me.Theme.Size = New System.Drawing.Size(441, 483)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "Add Video"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'rbComKinda
        '
        Me.rbComKinda.AutoSize = True
        Me.rbComKinda.Location = New System.Drawing.Point(275, 359)
        Me.rbComKinda.Name = "rbComKinda"
        Me.rbComKinda.Size = New System.Drawing.Size(143, 17)
        Me.rbComKinda.TabIndex = 110
        Me.rbComKinda.Text = "Comments with approval"
        Me.rbComKinda.UseVisualStyleBackColor = True
        '
        'rbComDisable
        '
        Me.rbComDisable.AutoSize = True
        Me.rbComDisable.Location = New System.Drawing.Point(152, 358)
        Me.rbComDisable.Name = "rbComDisable"
        Me.rbComDisable.Size = New System.Drawing.Size(112, 17)
        Me.rbComDisable.TabIndex = 109
        Me.rbComDisable.Text = "Disable Comments"
        Me.rbComDisable.UseVisualStyleBackColor = True
        '
        'rbComAllow
        '
        Me.rbComAllow.AutoSize = True
        Me.rbComAllow.Checked = True
        Me.rbComAllow.Location = New System.Drawing.Point(12, 358)
        Me.rbComAllow.Name = "rbComAllow"
        Me.rbComAllow.Size = New System.Drawing.Size(103, 17)
        Me.rbComAllow.TabIndex = 108
        Me.rbComAllow.TabStop = True
        Me.rbComAllow.Text = "Allow Comments"
        Me.rbComAllow.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(228, 446)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.NoRounding = False
        Me.btnCancel.Size = New System.Drawing.Size(201, 23)
        Me.btnCancel.TabIndex = 107
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.Image = Nothing
        Me.btnSave.Location = New System.Drawing.Point(13, 446)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.NoRounding = False
        Me.btnSave.Size = New System.Drawing.Size(209, 23)
        Me.btnSave.TabIndex = 106
        Me.btnSave.Text = "Save"
        '
        'Seperator7
        '
        Me.Seperator7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator7.BackColor = System.Drawing.Color.White
        Me.Seperator7.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator7.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator7.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator7.Image = Nothing
        Me.Seperator7.Location = New System.Drawing.Point(8, 437)
        Me.Seperator7.Name = "Seperator7"
        Me.Seperator7.NoRounding = False
        Me.Seperator7.Size = New System.Drawing.Size(424, 10)
        Me.Seperator7.TabIndex = 105
        Me.Seperator7.Text = "Seperator2"
        '
        'Privacy
        '
        Me.Privacy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Privacy.FormattingEnabled = True
        Me.Privacy.Items.AddRange(New Object() {"Public", "Unlisted", "Private"})
        Me.Privacy.Location = New System.Drawing.Point(12, 413)
        Me.Privacy.Name = "Privacy"
        Me.Privacy.Size = New System.Drawing.Size(417, 21)
        Me.Privacy.TabIndex = 104
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(197, 397)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Privacy"
        '
        'Seperator6
        '
        Me.Seperator6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator6.BackColor = System.Drawing.Color.White
        Me.Seperator6.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator6.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator6.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator6.Image = Nothing
        Me.Seperator6.Location = New System.Drawing.Point(8, 399)
        Me.Seperator6.Name = "Seperator6"
        Me.Seperator6.NoRounding = False
        Me.Seperator6.Size = New System.Drawing.Size(424, 10)
        Me.Seperator6.TabIndex = 102
        Me.Seperator6.Text = "Seperator2"
        '
        'chkRatings
        '
        Me.chkRatings.AutoSize = True
        Me.chkRatings.Location = New System.Drawing.Point(12, 381)
        Me.chkRatings.Name = "chkRatings"
        Me.chkRatings.Size = New System.Drawing.Size(99, 17)
        Me.chkRatings.TabIndex = 101
        Me.chkRatings.Text = "Disable Ratings"
        Me.chkRatings.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(176, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Optional Settings"
        '
        'Seperator5
        '
        Me.Seperator5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator5.BackColor = System.Drawing.Color.White
        Me.Seperator5.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator5.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator5.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator5.Image = Nothing
        Me.Seperator5.Location = New System.Drawing.Point(8, 345)
        Me.Seperator5.Name = "Seperator5"
        Me.Seperator5.NoRounding = False
        Me.Seperator5.Size = New System.Drawing.Size(424, 10)
        Me.Seperator5.TabIndex = 98
        Me.Seperator5.Text = "Seperator2"
        '
        'btnBrowse
        '
        Me.btnBrowse.Image = Nothing
        Me.btnBrowse.Location = New System.Drawing.Point(366, 320)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.NoRounding = False
        Me.btnBrowse.Size = New System.Drawing.Size(63, 21)
        Me.btnBrowse.TabIndex = 97
        Me.btnBrowse.Text = "Browse"
        '
        'txtFile
        '
        Me.txtFile.Enabled = False
        Me.txtFile.Location = New System.Drawing.Point(12, 320)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(348, 21)
        Me.txtFile.TabIndex = 96
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "File Path"
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
        Me.Seperator4.Location = New System.Drawing.Point(8, 304)
        Me.Seperator4.Name = "Seperator4"
        Me.Seperator4.NoRounding = False
        Me.Seperator4.Size = New System.Drawing.Size(424, 10)
        Me.Seperator4.TabIndex = 94
        Me.Seperator4.Text = "Seperator2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(197, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Category"
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
        Me.Seperator3.Location = New System.Drawing.Point(8, 263)
        Me.Seperator3.Name = "Seperator3"
        Me.Seperator3.NoRounding = False
        Me.Seperator3.Size = New System.Drawing.Size(424, 10)
        Me.Seperator3.TabIndex = 92
        Me.Seperator3.Text = "Seperator3"
        '
        'Category
        '
        Me.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Category.FormattingEnabled = True
        Me.Category.Items.AddRange(New Object() {"Film & Animation", "Cars & Vehicles", "Music", "Pets & Animals", "Sport", "Travel & Events", "Gaming", "Comedy", "Entertainment", "Howto & Style", "News & Politics", "Education", "Science & Technology"})
        Me.Category.Location = New System.Drawing.Point(12, 279)
        Me.Category.Name = "Category"
        Me.Category.Size = New System.Drawing.Size(417, 21)
        Me.Category.TabIndex = 91
        '
        'txtKeywords
        '
        Me.txtKeywords.Location = New System.Drawing.Point(12, 238)
        Me.txtKeywords.Name = "txtKeywords"
        Me.txtKeywords.Size = New System.Drawing.Size(417, 21)
        Me.txtKeywords.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Keywords"
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
        Me.Seperator2.Location = New System.Drawing.Point(8, 223)
        Me.Seperator2.Name = "Seperator2"
        Me.Seperator2.NoRounding = False
        Me.Seperator2.Size = New System.Drawing.Size(424, 10)
        Me.Seperator2.TabIndex = 47
        Me.Seperator2.Text = "Seperator2"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(12, 101)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(417, 118)
        Me.txtDescription.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Description"
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
        Me.Seperator1.Location = New System.Drawing.Point(8, 85)
        Me.Seperator1.Name = "Seperator1"
        Me.Seperator1.NoRounding = False
        Me.Seperator1.Size = New System.Drawing.Size(424, 10)
        Me.Seperator1.TabIndex = 44
        Me.Seperator1.Text = "Seperator2"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(12, 60)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(417, 21)
        Me.txtTitle.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(208, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Title"
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
        Me.seperatorB.Location = New System.Drawing.Point(8, 44)
        Me.seperatorB.Name = "seperatorB"
        Me.seperatorB.NoRounding = False
        Me.seperatorB.Size = New System.Drawing.Size(424, 10)
        Me.seperatorB.TabIndex = 41
        Me.seperatorB.Text = "Seperator2"
        '
        'frmAddUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 483)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddUpload"
        Me.Text = "Add Video"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents txtKeywords As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Seperator2 As Tubenoia.Seperator
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Seperator1 As Tubenoia.Seperator
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents seperatorB As Tubenoia.Seperator
    Friend WithEvents btnBrowse As Tubenoia.NButton
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Seperator4 As Tubenoia.Seperator
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Seperator3 As Tubenoia.Seperator
    Friend WithEvents Category As System.Windows.Forms.ComboBox
    Friend WithEvents chkRatings As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Seperator5 As Tubenoia.Seperator
    Friend WithEvents btnCancel As Tubenoia.NButton
    Friend WithEvents btnSave As Tubenoia.NButton
    Friend WithEvents Seperator7 As Tubenoia.Seperator
    Friend WithEvents Privacy As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Seperator6 As Tubenoia.Seperator
    Friend WithEvents rbComKinda As System.Windows.Forms.RadioButton
    Friend WithEvents rbComDisable As System.Windows.Forms.RadioButton
    Friend WithEvents rbComAllow As System.Windows.Forms.RadioButton
End Class
