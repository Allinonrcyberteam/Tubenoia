<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaptcha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaptcha))
        Me.PB = New System.Windows.Forms.PictureBox()
        Me.btnResolved = New Tubenoia.NButton()
        Me.txtCaptcha = New System.Windows.Forms.TextBox()
        Me.Theme = New Tubenoia.NTheme()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
        '
        'PB
        '
        Me.PB.BackColor = System.Drawing.Color.White
        Me.PB.Location = New System.Drawing.Point(12, 37)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(200, 70)
        Me.PB.TabIndex = 0
        Me.PB.TabStop = False
        '
        'btnResolved
        '
        Me.btnResolved.Image = Nothing
        Me.btnResolved.Location = New System.Drawing.Point(12, 140)
        Me.btnResolved.Name = "btnResolved"
        Me.btnResolved.NoRounding = False
        Me.btnResolved.Size = New System.Drawing.Size(200, 23)
        Me.btnResolved.TabIndex = 3
        Me.btnResolved.Text = "Resolved"
        '
        'txtCaptcha
        '
        Me.txtCaptcha.BackColor = System.Drawing.Color.White
        Me.txtCaptcha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtCaptcha.Location = New System.Drawing.Point(12, 113)
        Me.txtCaptcha.Name = "txtCaptcha"
        Me.txtCaptcha.Size = New System.Drawing.Size(200, 21)
        Me.txtCaptcha.TabIndex = 1001
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.txtCaptcha)
        Me.Theme.Controls.Add(Me.PB)
        Me.Theme.Controls.Add(Me.btnResolved)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.White
        Me.Theme.Image = Nothing
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 14
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = False
        Me.Theme.Size = New System.Drawing.Size(225, 175)
        Me.Theme.TabIndex = 1002
        Me.Theme.Text = "Please enter the captcha"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'frmCaptcha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 175)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCaptcha"
        Me.Text = "Tubenoia — CAPTCHA"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PB As System.Windows.Forms.PictureBox
    Friend WithEvents btnResolved As Tubenoia.nbutton
    Friend WithEvents txtCaptcha As System.Windows.Forms.TextBox
    Friend WithEvents Theme As Tubenoia.ntheme
End Class
