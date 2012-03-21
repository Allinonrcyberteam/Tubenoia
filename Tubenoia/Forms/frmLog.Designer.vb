<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLog
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLog))
        Me.IL = New System.Windows.Forms.ImageList(Me.components)
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.Theme = New Tubenoia.NTheme()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.Log = New System.Windows.Forms.ListView()
        Me.ICO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TIME = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CONTENT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
        '
        'IL
        '
        Me.IL.ImageStream = CType(resources.GetObject("IL.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IL.TransparentColor = System.Drawing.Color.Transparent
        Me.IL.Images.SetKeyName(0, "full-time.png")
        Me.IL.Images.SetKeyName(1, "pen.png")
        Me.IL.Images.SetKeyName(2, "advertisment.png")
        Me.IL.Images.SetKeyName(3, "finished-work.png")
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Delete"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Select All"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Export Log"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Clear Log"
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.Log)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Theme.ForeColor = System.Drawing.Color.White
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 14
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(479, 391)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Log Viewer"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(429, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(451, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "X"
        '
        'Log
        '
        Me.Log.AllowColumnReorder = True
        Me.Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Log.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ICO, Me.TIME, Me.CONTENT})
        Me.Log.FullRowSelect = True
        Me.Log.GridLines = True
        Me.Log.Location = New System.Drawing.Point(12, 38)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(455, 340)
        Me.Log.SmallImageList = Me.IL
        Me.Log.TabIndex = 0
        Me.Log.UseCompatibleStateImageBehavior = False
        Me.Log.View = System.Windows.Forms.View.Details
        '
        'ICO
        '
        Me.ICO.Text = ""
        Me.ICO.Width = 24
        '
        'TIME
        '
        Me.TIME.Text = "Time"
        Me.TIME.Width = 73
        '
        'CONTENT
        '
        Me.CONTENT.Text = "Message"
        Me.CONTENT.Width = 329
        '
        'frmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 391)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLog"
        Me.Text = "Tubenoia — Log Viewer"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.ntheme
    Friend WithEvents Log As System.Windows.Forms.ListView
    Friend WithEvents ICO As System.Windows.Forms.ColumnHeader
    Friend WithEvents TIME As System.Windows.Forms.ColumnHeader
    Friend WithEvents CONTENT As System.Windows.Forms.ColumnHeader
    Friend WithEvents IL As System.Windows.Forms.ImageList
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents btnMinimize As Tubenoia.nbutton
    Friend WithEvents btnExit As Tubenoia.nbutton
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
End Class
