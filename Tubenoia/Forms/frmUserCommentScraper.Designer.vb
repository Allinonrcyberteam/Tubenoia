<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserCommentScraper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserCommentScraper))
        Me.Theme = New Tubenoia.NTheme()
        Me.CB = New System.Windows.Forms.ComboBox()
        Me.chkOnly = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pages = New System.Windows.Forms.NumericUpDown()
        Me.btnScrape = New Tubenoia.NButton()
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.txtVideo = New System.Windows.Forms.TextBox()
        Me.lstUsers = New System.Windows.Forms.ListView()
        Me.SUSER = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SCHANNEL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TIME = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.BW = New System.ComponentModel.BackgroundWorker()
        Me.Theme.SuspendLayout()
        CType(Me.Pages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.CB)
        Me.Theme.Controls.Add(Me.chkOnly)
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Controls.Add(Me.Pages)
        Me.Theme.Controls.Add(Me.btnScrape)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.txtVideo)
        Me.Theme.Controls.Add(Me.lstUsers)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.White
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 14
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = True
        Me.Theme.Size = New System.Drawing.Size(528, 609)
        Me.Theme.TabIndex = 2
        Me.Theme.Text = "   Tubenoia — Comment Channel Scraper"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'CB
        '
        Me.CB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB.Enabled = False
        Me.CB.FormattingEnabled = True
        Me.CB.Items.AddRange(New Object() {"Posted less than 10 minutes ago", "Posted less than an hour ago", "Posted less than a day ago"})
        Me.CB.Location = New System.Drawing.Point(105, 90)
        Me.CB.Name = "CB"
        Me.CB.Size = New System.Drawing.Size(411, 21)
        Me.CB.TabIndex = 10039
        '
        'chkOnly
        '
        Me.chkOnly.AutoSize = True
        Me.chkOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.chkOnly.Location = New System.Drawing.Point(15, 92)
        Me.chkOnly.Name = "chkOnly"
        Me.chkOnly.Size = New System.Drawing.Size(82, 17)
        Me.chkOnly.TabIndex = 10038
        Me.chkOnly.Text = "Only add if:"
        Me.chkOnly.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 10037
        Me.Label1.Text = "Maximum users:"
        '
        'Pages
        '
        Me.Pages.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pages.BackColor = System.Drawing.Color.White
        Me.Pages.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Pages.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.Pages.Location = New System.Drawing.Point(105, 64)
        Me.Pages.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Pages.Name = "Pages"
        Me.Pages.Size = New System.Drawing.Size(411, 21)
        Me.Pages.TabIndex = 10036
        Me.Pages.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'btnScrape
        '
        Me.btnScrape.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnScrape.Image = Nothing
        Me.btnScrape.Location = New System.Drawing.Point(12, 575)
        Me.btnScrape.Name = "btnScrape"
        Me.btnScrape.NoRounding = False
        Me.btnScrape.Size = New System.Drawing.Size(504, 23)
        Me.btnScrape.TabIndex = 10035
        Me.btnScrape.Text = "Scrape"
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(478, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 10034
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(500, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 10033
        Me.btnExit.Text = "X"
        '
        'txtVideo
        '
        Me.txtVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVideo.BackColor = System.Drawing.Color.White
        Me.txtVideo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txtVideo.Location = New System.Drawing.Point(12, 37)
        Me.txtVideo.Name = "txtVideo"
        Me.txtVideo.Size = New System.Drawing.Size(504, 21)
        Me.txtVideo.TabIndex = 10021
        '
        'lstUsers
        '
        Me.lstUsers.AllowColumnReorder = True
        Me.lstUsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SUSER, Me.SCHANNEL, Me.TIME})
        Me.lstUsers.FullRowSelect = True
        Me.lstUsers.GridLines = True
        Me.lstUsers.Location = New System.Drawing.Point(12, 117)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(504, 452)
        Me.lstUsers.TabIndex = 0
        Me.lstUsers.UseCompatibleStateImageBehavior = False
        Me.lstUsers.View = System.Windows.Forms.View.Details
        '
        'SUSER
        '
        Me.SUSER.Text = "Username"
        Me.SUSER.Width = 136
        '
        'SCHANNEL
        '
        Me.SCHANNEL.Text = "Channel"
        Me.SCHANNEL.Width = 214
        '
        'TIME
        '
        Me.TIME.Text = "Commented"
        Me.TIME.Width = 129
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5})
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "Delete"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.Text = "Clear List"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "Remove duplicates"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.Text = "Export list"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.Text = "Export as TXT"
        '
        'BW
        '
        Me.BW.WorkerSupportsCancellation = True
        '
        'frmUserCommentScraper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 609)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUserCommentScraper"
        Me.Text = "Tubenoia — Comment Channel Scraper"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        CType(Me.Pages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.ntheme
    Friend WithEvents lstUsers As System.Windows.Forms.ListView
    Friend WithEvents SUSER As System.Windows.Forms.ColumnHeader
    Friend WithEvents SCHANNEL As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtVideo As System.Windows.Forms.TextBox
    Friend WithEvents btnMinimize As Tubenoia.nbutton
    Friend WithEvents btnExit As Tubenoia.nbutton
    Friend WithEvents btnScrape As Tubenoia.nbutton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pages As numericupdown
    Friend WithEvents CB As System.Windows.Forms.ComboBox
    Friend WithEvents chkOnly As System.Windows.Forms.CheckBox
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents TIME As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
End Class
