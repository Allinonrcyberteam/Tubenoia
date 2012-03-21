<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetrieveAny
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRetrieveAny))
        Me.Theme = New Tubenoia.NTheme()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.lstChannels = New System.Windows.Forms.ListView()
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Channel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.lstChannels)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 22
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(423, 334)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Custom Scraper"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(373, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 10
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(395, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "X"
        '
        'lstChannels
        '
        Me.lstChannels.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstChannels.AllowColumnReorder = True
        Me.lstChannels.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstChannels.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Username, Me.Channel})
        Me.lstChannels.FullRowSelect = True
        Me.lstChannels.GridLines = True
        Me.lstChannels.Location = New System.Drawing.Point(12, 37)
        Me.lstChannels.Name = "lstChannels"
        Me.lstChannels.Size = New System.Drawing.Size(399, 285)
        Me.lstChannels.TabIndex = 1
        Me.lstChannels.UseCompatibleStateImageBehavior = False
        Me.lstChannels.View = System.Windows.Forms.View.Details
        '
        'Username
        '
        Me.Username.Text = "Username"
        Me.Username.Width = 172
        '
        'Channel
        '
        Me.Channel.Text = "Channel"
        Me.Channel.Width = 219
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem1, Me.MenuItem3, Me.MenuItem2, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.Text = "Clear List"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        Me.MenuItem2.Text = "Export List"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.Text = "Export as TXT"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 6
        Me.MenuItem6.Text = "Remove duplicates"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.Text = "Delete"
        '
        'frmRetrieveAny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 334)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRetrieveAny"
        Me.Text = "Tubenoia — Custom Scraper"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents lstChannels As System.Windows.Forms.ListView
    Friend WithEvents Username As System.Windows.Forms.ColumnHeader
    Friend WithEvents Channel As System.Windows.Forms.ColumnHeader
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
End Class
