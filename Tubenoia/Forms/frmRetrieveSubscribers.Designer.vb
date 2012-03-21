<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetrieveSubscribers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRetrieveSubscribers))
        Me.BW = New System.ComponentModel.BackgroundWorker()
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.Theme = New Tubenoia.NTheme()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pages = New System.Windows.Forms.NumericUpDown()
        Me.txtChannel = New System.Windows.Forms.TextBox()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.btnScrape = New Tubenoia.NButton()
        Me.lstSubscribers = New System.Windows.Forms.ListView()
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Channel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.Theme.SuspendLayout()
        CType(Me.Pages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BW
        '
        Me.BW.WorkerReportsProgress = True
        Me.BW.WorkerSupportsCancellation = True
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem1, Me.MenuItem3, Me.MenuItem2, Me.MenuItem4})
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
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Controls.Add(Me.Pages)
        Me.Theme.Controls.Add(Me.txtChannel)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.btnScrape)
        Me.Theme.Controls.Add(Me.lstSubscribers)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.White
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 14
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(470, 399)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Tubenoia — Subscriber Scraper"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1006
        Me.Label1.Text = "Maximum users:"
        '
        'Pages
        '
        Me.Pages.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pages.BackColor = System.Drawing.Color.White
        Me.Pages.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Pages.Increment = New Decimal(New Integer() {20, 0, 0, 0})
        Me.Pages.Location = New System.Drawing.Point(105, 64)
        Me.Pages.Maximum = New Decimal(New Integer() {10020, 0, 0, 0})
        Me.Pages.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Pages.Name = "Pages"
        Me.Pages.Size = New System.Drawing.Size(353, 21)
        Me.Pages.TabIndex = 1005
        Me.Pages.Value = New Decimal(New Integer() {40, 0, 0, 0})
        '
        'txtChannel
        '
        Me.txtChannel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChannel.BackColor = System.Drawing.Color.White
        Me.txtChannel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtChannel.Location = New System.Drawing.Point(12, 37)
        Me.txtChannel.Name = "txtChannel"
        Me.txtChannel.Size = New System.Drawing.Size(446, 21)
        Me.txtChannel.TabIndex = 1001
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(420, 4)
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
        Me.btnExit.Location = New System.Drawing.Point(442, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "X"
        '
        'btnScrape
        '
        Me.btnScrape.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnScrape.Image = Nothing
        Me.btnScrape.Location = New System.Drawing.Point(12, 365)
        Me.btnScrape.Name = "btnScrape"
        Me.btnScrape.NoRounding = False
        Me.btnScrape.Size = New System.Drawing.Size(446, 23)
        Me.btnScrape.TabIndex = 1
        Me.btnScrape.Text = "Scrape"
        '
        'lstSubscribers
        '
        Me.lstSubscribers.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstSubscribers.AllowColumnReorder = True
        Me.lstSubscribers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstSubscribers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Username, Me.Channel})
        Me.lstSubscribers.FullRowSelect = True
        Me.lstSubscribers.GridLines = True
        Me.lstSubscribers.Location = New System.Drawing.Point(12, 91)
        Me.lstSubscribers.Name = "lstSubscribers"
        Me.lstSubscribers.Size = New System.Drawing.Size(446, 268)
        Me.lstSubscribers.TabIndex = 0
        Me.lstSubscribers.UseCompatibleStateImageBehavior = False
        Me.lstSubscribers.View = System.Windows.Forms.View.Details
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
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "Delete"
        '
        'frmRetrieveSubscribers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 399)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRetrieveSubscribers"
        Me.Text = "Tubenoia — Subscriber Scraper"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        CType(Me.Pages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.ntheme
    Friend WithEvents btnScrape As Tubenoia.nbutton
    Friend WithEvents lstSubscribers As System.Windows.Forms.ListView
    Friend WithEvents Username As System.Windows.Forms.ColumnHeader
    Friend WithEvents Channel As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnMinimize As Tubenoia.nbutton
    Friend WithEvents btnExit As Tubenoia.nbutton
    Friend WithEvents BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtChannel As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pages As NumericUpDown
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
End Class
