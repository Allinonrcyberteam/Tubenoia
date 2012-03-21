<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommentObfuscator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommentObfuscator))
        Me.Theme = New Tubenoia.NTheme()
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnObfuscate = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.BG = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.txtOutput)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnObfuscate)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.BG)
        Me.Theme.Controls.Add(Me.Label2)
        Me.Theme.Controls.Add(Me.txtInput)
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 22
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(391, 311)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Comment Obfuscator"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'txtOutput
        '
        Me.txtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOutput.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtOutput.Location = New System.Drawing.Point(14, 176)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(364, 93)
        Me.txtOutput.TabIndex = 13
        Me.txtOutput.Text = ""
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(341, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 12
        Me.btnMinimize.Text = "_"
        '
        'btnObfuscate
        '
        Me.btnObfuscate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnObfuscate.Image = Nothing
        Me.btnObfuscate.Location = New System.Drawing.Point(12, 276)
        Me.btnObfuscate.Name = "btnObfuscate"
        Me.btnObfuscate.NoRounding = False
        Me.btnObfuscate.Size = New System.Drawing.Size(367, 23)
        Me.btnObfuscate.TabIndex = 5
        Me.btnObfuscate.Text = "Obfuscate"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(363, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "X"
        '
        'BG
        '
        Me.BG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BG.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BG.Location = New System.Drawing.Point(12, 174)
        Me.BG.Multiline = True
        Me.BG.Name = "BG"
        Me.BG.Size = New System.Drawing.Size(367, 96)
        Me.BG.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Output:"
        '
        'txtInput
        '
        Me.txtInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInput.Location = New System.Drawing.Point(12, 53)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(367, 96)
        Me.txtInput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Input:"
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Copy"
        '
        'frmCommentObfuscator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 311)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCommentObfuscator"
        Me.Text = "Tubenoia — Comment Obfuscator"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents BG As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnObfuscate As Tubenoia.NButton
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents txtOutput As System.Windows.Forms.RichTextBox
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
End Class
