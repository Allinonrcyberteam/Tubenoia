<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvatarScraper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAvatarScraper))
        Me.NTheme1 = New Tubenoia.NTheme()
        Me.btnStart = New Tubenoia.NButton()
        Me.lstDownload = New System.Windows.Forms.ListView()
        Me.downloadURLS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnChange = New Tubenoia.NButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.lstURLs = New System.Windows.Forms.ListView()
        Me.PURL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.P = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.CM1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.NTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NTheme1
        '
        Me.NTheme1.BackColor = System.Drawing.Color.White
        Me.NTheme1.Controls.Add(Me.btnStart)
        Me.NTheme1.Controls.Add(Me.lstDownload)
        Me.NTheme1.Controls.Add(Me.btnChange)
        Me.NTheme1.Controls.Add(Me.Label1)
        Me.NTheme1.Controls.Add(Me.txtPath)
        Me.NTheme1.Controls.Add(Me.lstURLs)
        Me.NTheme1.Controls.Add(Me.btnMinimize)
        Me.NTheme1.Controls.Add(Me.btnExit)
        Me.NTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NTheme1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.NTheme1.Image = CType(resources.GetObject("NTheme1.Image"), System.Drawing.Image)
        Me.NTheme1.Location = New System.Drawing.Point(0, 0)
        Me.NTheme1.MoveHeight = 22
        Me.NTheme1.Name = "NTheme1"
        Me.NTheme1.Resizable = True
        Me.NTheme1.Size = New System.Drawing.Size(934, 416)
        Me.NTheme1.TabIndex = 0
        Me.NTheme1.Text = "   Tubenoia — Avatar Scraper"
        Me.NTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Image = Nothing
        Me.btnStart.Location = New System.Drawing.Point(12, 381)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.NoRounding = False
        Me.btnStart.Size = New System.Drawing.Size(910, 23)
        Me.btnStart.TabIndex = 46
        Me.btnStart.Text = "Start"
        '
        'lstDownload
        '
        Me.lstDownload.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstDownload.AllowColumnReorder = True
        Me.lstDownload.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstDownload.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.downloadURLS})
        Me.lstDownload.FullRowSelect = True
        Me.lstDownload.GridLines = True
        Me.lstDownload.Location = New System.Drawing.Point(12, 41)
        Me.lstDownload.Name = "lstDownload"
        Me.lstDownload.Size = New System.Drawing.Size(910, 138)
        Me.lstDownload.TabIndex = 45
        Me.lstDownload.UseCompatibleStateImageBehavior = False
        Me.lstDownload.View = System.Windows.Forms.View.Details
        '
        'downloadURLS
        '
        Me.downloadURLS.Text = "URLs to download from"
        Me.downloadURLS.Width = 803
        '
        'btnChange
        '
        Me.btnChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChange.Image = Nothing
        Me.btnChange.Location = New System.Drawing.Point(847, 185)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.NoRounding = False
        Me.btnChange.Size = New System.Drawing.Size(75, 21)
        Me.btnChange.TabIndex = 44
        Me.btnChange.Text = "Change"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Save avatars in:"
        '
        'txtPath
        '
        Me.txtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.Enabled = False
        Me.txtPath.Location = New System.Drawing.Point(106, 185)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(743, 21)
        Me.txtPath.TabIndex = 42
        '
        'lstURLs
        '
        Me.lstURLs.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstURLs.AllowColumnReorder = True
        Me.lstURLs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstURLs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PURL, Me.P})
        Me.lstURLs.FullRowSelect = True
        Me.lstURLs.GridLines = True
        Me.lstURLs.Location = New System.Drawing.Point(12, 212)
        Me.lstURLs.Name = "lstURLs"
        Me.lstURLs.Size = New System.Drawing.Size(910, 163)
        Me.lstURLs.TabIndex = 41
        Me.lstURLs.UseCompatibleStateImageBehavior = False
        Me.lstURLs.View = System.Windows.Forms.View.Details
        '
        'PURL
        '
        Me.PURL.Text = "Picture URL"
        Me.PURL.Width = 597
        '
        'P
        '
        Me.P.Text = "Status"
        Me.P.Width = 207
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(884, 4)
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
        Me.btnExit.Location = New System.Drawing.Point(906, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 39
        Me.btnExit.Text = "X"
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem4, Me.MenuItem3, Me.MenuItem6, Me.MenuItem7})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Load links"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Add link"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Text = "Clear"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 5
        Me.MenuItem7.Text = "Scrape avatar URLs"
        '
        'CM1
        '
        Me.CM1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem8})
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "Clear"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Text = "Remove duplicates"
        '
        'frmAvatarScraper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 416)
        Me.Controls.Add(Me.NTheme1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAvatarScraper"
        Me.Text = "Tubenoia — Avatar Scraper"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.NTheme1.ResumeLayout(False)
        Me.NTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NTheme1 As Tubenoia.NTheme
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents lstURLs As System.Windows.Forms.ListView
    Friend WithEvents PURL As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnChange As Tubenoia.NButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents P As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstDownload As System.Windows.Forms.ListView
    Friend WithEvents downloadURLS As System.Windows.Forms.ColumnHeader
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents CM1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents btnStart As Tubenoia.NButton
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
End Class
