<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProxyScraper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProxyScraper))
        Me.Theme = New Tubenoia.NTheme()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nPages = New System.Windows.Forms.NumericUpDown()
        Me.lstIPs = New System.Windows.Forms.ListView()
        Me.IP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PORT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timeout = New System.Windows.Forms.NumericUpDown()
        Me.Theme.SuspendLayout()
        CType(Me.nPages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Timeout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.Label2)
        Me.Theme.Controls.Add(Me.Timeout)
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Controls.Add(Me.nPages)
        Me.Theme.Controls.Add(Me.lstIPs)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 22
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(295, 446)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Proxy Scraper"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 1009
        Me.Label1.Text = "Maximum pages to scrape:"
        '
        'nPages
        '
        Me.nPages.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nPages.Location = New System.Drawing.Point(147, 40)
        Me.nPages.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nPages.Name = "nPages"
        Me.nPages.Size = New System.Drawing.Size(136, 21)
        Me.nPages.TabIndex = 1008
        Me.nPages.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lstIPs
        '
        Me.lstIPs.AllowColumnReorder = True
        Me.lstIPs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstIPs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IP, Me.PORT})
        Me.lstIPs.FullRowSelect = True
        Me.lstIPs.GridLines = True
        Me.lstIPs.Location = New System.Drawing.Point(12, 94)
        Me.lstIPs.Name = "lstIPs"
        Me.lstIPs.Size = New System.Drawing.Size(271, 340)
        Me.lstIPs.TabIndex = 1007
        Me.lstIPs.UseCompatibleStateImageBehavior = False
        Me.lstIPs.View = System.Windows.Forms.View.Details
        '
        'IP
        '
        Me.IP.Text = "IP Address"
        Me.IP.Width = 187
        '
        'PORT
        '
        Me.PORT.Text = "Port #"
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(245, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 10
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(267, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "X"
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem5, Me.MenuItem2, Me.MenuItem3, Me.MenuItem9, Me.MenuItem4, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Start Scraping"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Text = "Start Checking"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Text = "Clear List"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 4
        Me.MenuItem9.Text = "Load List"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 5
        Me.MenuItem4.Text = "Export List"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 6
        Me.MenuItem6.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 7
        Me.MenuItem7.Text = "Remove all invalid"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 8
        Me.MenuItem8.Text = "Remove all not checked"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1011
        Me.Label2.Text = "Timeout:"
        '
        'Timeout
        '
        Me.Timeout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Timeout.Location = New System.Drawing.Point(67, 67)
        Me.Timeout.Name = "Timeout"
        Me.Timeout.Size = New System.Drawing.Size(216, 21)
        Me.Timeout.TabIndex = 1010
        '
        'frmProxyScraper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 446)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProxyScraper"
        Me.Text = "Tubenoia — Proxy Scraper"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        CType(Me.nPages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Timeout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents lstIPs As System.Windows.Forms.ListView
    Friend WithEvents IP As System.Windows.Forms.ColumnHeader
    Friend WithEvents PORT As System.Windows.Forms.ColumnHeader
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nPages As System.Windows.Forms.NumericUpDown
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timeout As System.Windows.Forms.NumericUpDown
End Class
