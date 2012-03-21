<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeLog))
        Me.Theme = New Tubenoia.NTheme()
        Me.lblVer = New System.Windows.Forms.Label()
        Me.lblVerText = New System.Windows.Forms.Label()
        Me.Changes = New System.Windows.Forms.RichTextBox()
        Me.Seperator1 = New Tubenoia.Seperator()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.lblVer)
        Me.Theme.Controls.Add(Me.lblVerText)
        Me.Theme.Controls.Add(Me.Changes)
        Me.Theme.Controls.Add(Me.Seperator1)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 22
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(541, 498)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Changelog"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'lblVer
        '
        Me.lblVer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVer.AutoSize = True
        Me.lblVer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVer.ForeColor = System.Drawing.Color.Black
        Me.lblVer.Location = New System.Drawing.Point(461, 48)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(51, 13)
        Me.lblVer.TabIndex = 20
        Me.lblVer.Text = "v1.0.0.0"
        '
        'lblVerText
        '
        Me.lblVerText.AutoSize = True
        Me.lblVerText.Location = New System.Drawing.Point(25, 48)
        Me.lblVerText.Name = "lblVerText"
        Me.lblVerText.Size = New System.Drawing.Size(46, 13)
        Me.lblVerText.TabIndex = 19
        Me.lblVerText.Text = "Version:"
        '
        'Changes
        '
        Me.Changes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Changes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Changes.Enabled = False
        Me.Changes.Location = New System.Drawing.Point(8, 76)
        Me.Changes.Name = "Changes"
        Me.Changes.ReadOnly = True
        Me.Changes.Size = New System.Drawing.Size(525, 414)
        Me.Changes.TabIndex = 17
        Me.Changes.Text = "Loading..."
        '
        'Seperator1
        '
        Me.Seperator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator1.Color1 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Seperator1.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seperator1.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.Seperator1.Image = Nothing
        Me.Seperator1.Location = New System.Drawing.Point(8, 70)
        Me.Seperator1.Name = "Seperator1"
        Me.Seperator1.NoRounding = False
        Me.Seperator1.Size = New System.Drawing.Size(525, 10)
        Me.Seperator1.TabIndex = 18
        Me.Seperator1.Text = "Seperator1"
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(491, 4)
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
        Me.btnExit.Location = New System.Drawing.Point(513, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "X"
        '
        'frmChangeLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 498)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChangeLog"
        Me.Text = "Changelog"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents Changes As System.Windows.Forms.RichTextBox
    Friend WithEvents lblVer As System.Windows.Forms.Label
    Friend WithEvents lblVerText As System.Windows.Forms.Label
    Friend WithEvents Seperator1 As Tubenoia.Seperator
End Class
