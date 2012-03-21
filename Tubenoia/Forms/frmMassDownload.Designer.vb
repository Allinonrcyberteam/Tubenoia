<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMassDownload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMassDownload))
        Me.IL = New System.Windows.Forms.ImageList(Me.components)
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.Theme = New Tubenoia.NTheme()
        Me.cRes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NButton1 = New Tubenoia.NButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.lstVideos = New Tubenoia.ListViewEmbeddedControls.ListViewEx()
        Me.Ico = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Video = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Resolution = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.Gpbox1 = New Tubenoia.GPBOX()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.Theme.SuspendLayout()
        Me.SuspendLayout()
        '
        'IL
        '
        Me.IL.ImageStream = CType(resources.GetObject("IL.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IL.TransparentColor = System.Drawing.Color.Transparent
        Me.IL.Images.SetKeyName(0, "busy.png")
        Me.IL.Images.SetKeyName(1, "issue.png")
        Me.IL.Images.SetKeyName(2, "premium.png")
        Me.IL.Images.SetKeyName(3, "flag.png")
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem18, Me.MenuItem10, Me.MenuItem11})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Start"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Requeue Selected"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Requeue All"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.Text = "Watch"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 7
        Me.MenuItem8.Text = "Add video to list"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 8
        Me.MenuItem9.Text = "Load list"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 10
        Me.MenuItem10.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 11
        Me.MenuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem12, Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17})
        Me.MenuItem11.Text = "Change resolution"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 0
        Me.MenuItem12.Text = "240"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 1
        Me.MenuItem13.Text = "360"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 2
        Me.MenuItem14.Text = "480"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 3
        Me.MenuItem15.Text = "720"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 4
        Me.MenuItem16.Text = "1080"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 5
        Me.MenuItem17.Text = "Highest available"
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.cRes)
        Me.Theme.Controls.Add(Me.Label2)
        Me.Theme.Controls.Add(Me.NButton1)
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Controls.Add(Me.txtPath)
        Me.Theme.Controls.Add(Me.lstVideos)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.Gpbox1)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 22
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(634, 313)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Mass Downloader"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'cRes
        '
        Me.cRes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cRes.FormattingEnabled = True
        Me.cRes.Items.AddRange(New Object() {"240", "360", "480", "720", "1080", "Highest available"})
        Me.cRes.Location = New System.Drawing.Point(131, 71)
        Me.cRes.Name = "cRes"
        Me.cRes.Size = New System.Drawing.Size(487, 21)
        Me.cRes.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Default resolution:"
        '
        'NButton1
        '
        Me.NButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NButton1.Image = Nothing
        Me.NButton1.Location = New System.Drawing.Point(543, 42)
        Me.NButton1.Name = "NButton1"
        Me.NButton1.NoRounding = False
        Me.NButton1.Size = New System.Drawing.Size(75, 21)
        Me.NButton1.TabIndex = 12
        Me.NButton1.Text = "Change"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Save videos in:"
        '
        'txtPath
        '
        Me.txtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.Enabled = False
        Me.txtPath.Location = New System.Drawing.Point(111, 42)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(436, 21)
        Me.txtPath.TabIndex = 10
        '
        'lstVideos
        '
        Me.lstVideos.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstVideos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstVideos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Ico, Me.Video, Me.Status, Me.Resolution})
        Me.lstVideos.FullRowSelect = True
        Me.lstVideos.GridLines = True
        Me.lstVideos.LargeImageList = Me.IL
        Me.lstVideos.Location = New System.Drawing.Point(12, 103)
        Me.lstVideos.Name = "lstVideos"
        Me.lstVideos.Size = New System.Drawing.Size(610, 198)
        Me.lstVideos.SmallImageList = Me.IL
        Me.lstVideos.TabIndex = 9
        Me.lstVideos.UseCompatibleStateImageBehavior = False
        Me.lstVideos.View = System.Windows.Forms.View.Details
        '
        'Ico
        '
        Me.Ico.Text = ""
        Me.Ico.Width = 25
        '
        'Video
        '
        Me.Video.Text = "Video"
        Me.Video.Width = 282
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 176
        '
        'Resolution
        '
        Me.Resolution.Text = "Resolution"
        Me.Resolution.Width = 107
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(584, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 8
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(606, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "X"
        '
        'Gpbox1
        '
        Me.Gpbox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gpbox1.Border1 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Gpbox1.Border2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gpbox1.FillColor = System.Drawing.Color.Transparent
        Me.Gpbox1.Image = Nothing
        Me.Gpbox1.Location = New System.Drawing.Point(12, 38)
        Me.Gpbox1.Name = "Gpbox1"
        Me.Gpbox1.NoRounding = False
        Me.Gpbox1.Size = New System.Drawing.Size(610, 59)
        Me.Gpbox1.TabIndex = 15
        Me.Gpbox1.Text = "Gpbox1"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 9
        Me.MenuItem18.Text = "Clear list"
        '
        'frmMassDownload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 313)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMassDownload"
        Me.Text = "Tubenoia — Mass Downloader"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents lstVideos As Tubenoia.ListViewEmbeddedControls.ListViewEx
    Friend WithEvents Video As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents IL As System.Windows.Forms.ImageList
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NButton1 As Tubenoia.NButton
    Friend WithEvents Ico As System.Windows.Forms.ColumnHeader
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents Resolution As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cRes As System.Windows.Forms.ComboBox
    Friend WithEvents Gpbox1 As Tubenoia.GPBOX
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
End Class
