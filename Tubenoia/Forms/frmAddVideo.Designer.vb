<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddVideo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddVideo))
        Me.Theme = New Tubenoia.NTheme()
        Me.btnCancel = New Tubenoia.NButton()
        Me.btnAdd = New Tubenoia.NButton()
        Me.txtVideo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Gpbox1 = New Tubenoia.GPBOX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Resolution = New System.Windows.Forms.ComboBox()
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.Resolution)
        Me.Theme.Controls.Add(Me.Label2)
        Me.Theme.Controls.Add(Me.btnCancel)
        Me.Theme.Controls.Add(Me.btnAdd)
        Me.Theme.Controls.Add(Me.txtVideo)
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Controls.Add(Me.Gpbox1)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Theme.Image = Nothing
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 22
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = False
        Me.Theme.Size = New System.Drawing.Size(317, 171)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Add video"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'btnCancel
        '
        Me.btnCancel.Image = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(161, 135)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.NoRounding = False
        Me.btnCancel.Size = New System.Drawing.Size(144, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'btnAdd
        '
        Me.btnAdd.Image = Nothing
        Me.btnAdd.Location = New System.Drawing.Point(12, 135)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.NoRounding = False
        Me.btnAdd.Size = New System.Drawing.Size(155, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add to list"
        '
        'txtVideo
        '
        Me.txtVideo.Location = New System.Drawing.Point(17, 58)
        Me.txtVideo.Name = "txtVideo"
        Me.txtVideo.Size = New System.Drawing.Size(282, 21)
        Me.txtVideo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Link:"
        '
        'Gpbox1
        '
        Me.Gpbox1.Border1 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Gpbox1.Border2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gpbox1.FillColor = System.Drawing.Color.Transparent
        Me.Gpbox1.Image = Nothing
        Me.Gpbox1.Location = New System.Drawing.Point(12, 38)
        Me.Gpbox1.Name = "Gpbox1"
        Me.Gpbox1.NoRounding = False
        Me.Gpbox1.Size = New System.Drawing.Size(293, 91)
        Me.Gpbox1.TabIndex = 1
        Me.Gpbox1.Text = "Link"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Resolution:"
        '
        'Resolution
        '
        Me.Resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Resolution.FormattingEnabled = True
        Me.Resolution.Items.AddRange(New Object() {"240", "360", "480", "720", "1080", "Highest available"})
        Me.Resolution.Location = New System.Drawing.Point(17, 99)
        Me.Resolution.Name = "Resolution"
        Me.Resolution.Size = New System.Drawing.Size(282, 21)
        Me.Resolution.TabIndex = 6
        '
        'frmAddVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 171)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddVideo"
        Me.Text = "Add video"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents btnCancel As Tubenoia.NButton
    Friend WithEvents btnAdd As Tubenoia.NButton
    Friend WithEvents txtVideo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Gpbox1 As Tubenoia.GPBOX
    Friend WithEvents Resolution As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
