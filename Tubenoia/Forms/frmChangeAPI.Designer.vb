<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeAPI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeAPI))
        Me.txtAPI = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New Tubenoia.NButton()
        Me.Button2 = New Tubenoia.NButton()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.NTheme1 = New Tubenoia.NTheme()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAPI
        '
        Me.txtAPI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPI.Location = New System.Drawing.Point(16, 24)
        Me.txtAPI.Name = "txtAPI"
        Me.txtAPI.Size = New System.Drawing.Size(369, 21)
        Me.txtAPI.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.txtAPI)
        Me.GroupBox5.Location = New System.Drawing.Point(20, 43)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(404, 92)
        Me.GroupBox5.TabIndex = 35
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "[        ]   CHANGE API KEY"
        '
        'Button1
        '
        Me.Button1.Image = Nothing
        Me.Button1.Location = New System.Drawing.Point(16, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.NoRounding = False
        Me.Button1.Size = New System.Drawing.Size(188, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Change"
        '
        'Button2
        '
        Me.Button2.Image = Nothing
        Me.Button2.Location = New System.Drawing.Point(210, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.NoRounding = False
        Me.Button2.Size = New System.Drawing.Size(175, 23)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Restore default"
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(36, 40)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox10.TabIndex = 36
        Me.PictureBox10.TabStop = False
        '
        'NTheme1
        '
        Me.NTheme1.BackColor = System.Drawing.Color.White
        Me.NTheme1.Controls.Add(Me.btnMinimize)
        Me.NTheme1.Controls.Add(Me.PictureBox10)
        Me.NTheme1.Controls.Add(Me.btnExit)
        Me.NTheme1.Controls.Add(Me.GroupBox5)
        Me.NTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NTheme1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.NTheme1.Image = Nothing
        Me.NTheme1.Location = New System.Drawing.Point(0, 0)
        Me.NTheme1.MoveHeight = 22
        Me.NTheme1.Name = "NTheme1"
        Me.NTheme1.Resizable = True
        Me.NTheme1.Size = New System.Drawing.Size(452, 155)
        Me.NTheme1.TabIndex = 37
        Me.NTheme1.Text = "Change API Key"
        Me.NTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(402, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 40
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(424, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 39
        Me.btnExit.Text = "X"
        '
        'frmChangeAPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 155)
        Me.Controls.Add(Me.NTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(452, 155)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(452, 155)
        Me.Name = "frmChangeAPI"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NTheme1.ResumeLayout(False)
        Me.NTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtAPI As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As Tubenoia.NButton
    Friend WithEvents Button2 As Tubenoia.NButton
    Friend WithEvents NTheme1 As Tubenoia.NTheme
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
End Class
