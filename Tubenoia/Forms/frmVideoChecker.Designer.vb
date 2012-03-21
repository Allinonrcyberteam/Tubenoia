<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVideoChecker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVideoChecker))
        Me.Theme = New Tubenoia.NTheme()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lstVideos = New System.Windows.Forms.ListView()
        Me.Video = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnStart = New Tubenoia.NButton()
        Me.lstChecker = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.CM1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.Theme.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.TabControl1)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 22
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(482, 461)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Video Checker"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(459, 412)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lstVideos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(451, 386)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Video List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lstVideos
        '
        Me.lstVideos.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstVideos.AllowColumnReorder = True
        Me.lstVideos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstVideos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Video})
        Me.lstVideos.FullRowSelect = True
        Me.lstVideos.GridLines = True
        Me.lstVideos.Location = New System.Drawing.Point(4, 5)
        Me.lstVideos.Name = "lstVideos"
        Me.lstVideos.Size = New System.Drawing.Size(442, 377)
        Me.lstVideos.TabIndex = 20
        Me.lstVideos.UseCompatibleStateImageBehavior = False
        Me.lstVideos.View = System.Windows.Forms.View.Details
        '
        'Video
        '
        Me.Video.Text = "Video"
        Me.Video.Width = 384
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnStart)
        Me.TabPage2.Controls.Add(Me.lstChecker)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(451, 386)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Checker"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Image = Nothing
        Me.btnStart.Location = New System.Drawing.Point(4, 358)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.NoRounding = False
        Me.btnStart.Size = New System.Drawing.Size(442, 23)
        Me.btnStart.TabIndex = 22
        Me.btnStart.Text = "Start"
        '
        'lstChecker
        '
        Me.lstChecker.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstChecker.AllowColumnReorder = True
        Me.lstChecker.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstChecker.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstChecker.FullRowSelect = True
        Me.lstChecker.GridLines = True
        Me.lstChecker.Location = New System.Drawing.Point(4, 5)
        Me.lstChecker.Name = "lstChecker"
        Me.lstChecker.Size = New System.Drawing.Size(442, 349)
        Me.lstChecker.TabIndex = 21
        Me.lstChecker.UseCompatibleStateImageBehavior = False
        Me.lstChecker.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Video"
        Me.ColumnHeader1.Width = 266
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Alive"
        Me.ColumnHeader2.Width = 56
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Views"
        Me.ColumnHeader3.Width = 66
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(432, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 18
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(454, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "X"
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Load list"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Add video"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Clear list"
        '
        'CM1
        '
        Me.CM1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem5, Me.MenuItem6})
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "Remove all dead"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Text = "Export list"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.Text = "Clear list"
        '
        'frmVideoChecker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 461)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVideoChecker"
        Me.Text = "Tubenoia — Video Checker"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lstVideos As System.Windows.Forms.ListView
    Friend WithEvents Video As System.Windows.Forms.ColumnHeader
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents btnStart As Tubenoia.NButton
    Friend WithEvents lstChecker As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CM1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
End Class
