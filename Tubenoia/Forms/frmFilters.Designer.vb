<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFilters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFilters))
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.seperatorA = New Tubenoia.Seperator()
        Me.Theme = New Tubenoia.NTheme()
        Me.btnVideoFilter = New Tubenoia.ButtonPane()
        Me.btnUserFilter = New Tubenoia.ButtonPane()
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(276, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 14
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(298, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "X"
        '
        'seperatorA
        '
        Me.seperatorA.BackColor = System.Drawing.Color.White
        Me.seperatorA.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.seperatorA.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.seperatorA.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.seperatorA.Image = Nothing
        Me.seperatorA.Location = New System.Drawing.Point(8, 82)
        Me.seperatorA.Name = "seperatorA"
        Me.seperatorA.NoRounding = False
        Me.seperatorA.Size = New System.Drawing.Size(308, 10)
        Me.seperatorA.TabIndex = 9
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.seperatorA)
        Me.Theme.Controls.Add(Me.btnVideoFilter)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.btnUserFilter)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.White
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 14
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = False
        Me.Theme.Size = New System.Drawing.Size(326, 149)
        Me.Theme.TabIndex = 1
        Me.Theme.Text = "   Tubenoia — Filters"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'btnVideoFilter
        '
        Me.btnVideoFilter.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnVideoFilter.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnVideoFilter.Color1A = System.Drawing.Color.White
        Me.btnVideoFilter.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnVideoFilter.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVideoFilter.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnVideoFilter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoFilter.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoFilter.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVideoFilter.Image = CType(resources.GetObject("btnVideoFilter.Image"), System.Drawing.Image)
        Me.btnVideoFilter.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVideoFilter.Location = New System.Drawing.Point(12, 92)
        Me.btnVideoFilter.Name = "btnVideoFilter"
        Me.btnVideoFilter.NoGradient = False
        Me.btnVideoFilter.NoRounding = False
        Me.btnVideoFilter.Selection = True
        Me.btnVideoFilter.SelectionToggle = False
        Me.btnVideoFilter.Size = New System.Drawing.Size(302, 45)
        Me.btnVideoFilter.TabIndex = 15
        Me.btnVideoFilter.Text = "btnVideoFilter"
        Me.btnVideoFilter.Text1 = "Video Filters"
        Me.btnVideoFilter.Text2 = "filter video lists"
        Me.btnVideoFilter.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnVideoFilter.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'btnUserFilter
        '
        Me.btnUserFilter.Border1 = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnUserFilter.Border2 = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUserFilter.Color1A = System.Drawing.Color.White
        Me.btnUserFilter.Color1B = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnUserFilter.Color2A = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserFilter.Color2B = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUserFilter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserFilter.Font1 = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserFilter.Font2 = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserFilter.Image = CType(resources.GetObject("btnUserFilter.Image"), System.Drawing.Image)
        Me.btnUserFilter.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUserFilter.Location = New System.Drawing.Point(12, 37)
        Me.btnUserFilter.Name = "btnUserFilter"
        Me.btnUserFilter.NoGradient = False
        Me.btnUserFilter.NoRounding = False
        Me.btnUserFilter.Selection = True
        Me.btnUserFilter.SelectionToggle = False
        Me.btnUserFilter.Size = New System.Drawing.Size(302, 45)
        Me.btnUserFilter.TabIndex = 5
        Me.btnUserFilter.Text = "btnUserFilter"
        Me.btnUserFilter.Text1 = "User Filters"
        Me.btnUserFilter.Text2 = "filter user lists"
        Me.btnUserFilter.TextColor1 = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnUserFilter.TextColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(177, Byte), Integer))
        '
        'frmFilters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 149)
        Me.Controls.Add(Me.Theme)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFilters"
        Me.Text = "Tubenoia — Filters"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents seperatorA As Tubenoia.Seperator
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents btnUserFilter As Tubenoia.ButtonPane
    Friend WithEvents btnVideoFilter As Tubenoia.ButtonPane
End Class
