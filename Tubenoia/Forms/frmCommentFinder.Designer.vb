<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommentFinder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommentFinder))
        Me.Theme = New Tubenoia.NTheme()
        Me.lstComments = New System.Windows.Forms.ListView()
        Me.Author = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Textc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnMinimize = New Tubenoia.NButton()
        Me.btnExit = New Tubenoia.NButton()
        Me.chkFastStop = New System.Windows.Forms.CheckBox()
        Me.seperatorA = New Tubenoia.Seperator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Max = New System.Windows.Forms.NumericUpDown()
        Me.btnSearch = New Tubenoia.NButton()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtVideo = New System.Windows.Forms.TextBox()
        Me.CM = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.Theme.SuspendLayout()
        CType(Me.Max, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Theme
        '
        Me.Theme.BackColor = System.Drawing.Color.White
        Me.Theme.Controls.Add(Me.lstComments)
        Me.Theme.Controls.Add(Me.btnMinimize)
        Me.Theme.Controls.Add(Me.btnExit)
        Me.Theme.Controls.Add(Me.chkFastStop)
        Me.Theme.Controls.Add(Me.seperatorA)
        Me.Theme.Controls.Add(Me.Label1)
        Me.Theme.Controls.Add(Me.Max)
        Me.Theme.Controls.Add(Me.btnSearch)
        Me.Theme.Controls.Add(Me.txtUsername)
        Me.Theme.Controls.Add(Me.txtVideo)
        Me.Theme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Theme.Image = CType(resources.GetObject("Theme.Image"), System.Drawing.Image)
        Me.Theme.Location = New System.Drawing.Point(0, 0)
        Me.Theme.MoveHeight = 22
        Me.Theme.Name = "Theme"
        Me.Theme.Resizable = False
        Me.Theme.Size = New System.Drawing.Size(407, 484)
        Me.Theme.TabIndex = 0
        Me.Theme.Text = "   Find comment ID"
        Me.Theme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'lstComments
        '
        Me.lstComments.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstComments.AllowColumnReorder = True
        Me.lstComments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstComments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Author, Me.ID, Me.Textc})
        Me.lstComments.FullRowSelect = True
        Me.lstComments.GridLines = True
        Me.lstComments.Location = New System.Drawing.Point(15, 180)
        Me.lstComments.Name = "lstComments"
        Me.lstComments.Size = New System.Drawing.Size(380, 292)
        Me.lstComments.TabIndex = 28
        Me.lstComments.UseCompatibleStateImageBehavior = False
        Me.lstComments.View = System.Windows.Forms.View.Details
        '
        'Author
        '
        Me.Author.Text = "Author"
        Me.Author.Width = 91
        '
        'ID
        '
        Me.ID.Text = "Comment ID"
        Me.ID.Width = 143
        '
        'Textc
        '
        Me.Textc.Text = "Text"
        Me.Textc.Width = 128
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(357, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.NoRounding = False
        Me.btnMinimize.Size = New System.Drawing.Size(23, 20)
        Me.btnMinimize.TabIndex = 27
        Me.btnMinimize.Text = "_"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(379, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoRounding = False
        Me.btnExit.Size = New System.Drawing.Size(23, 20)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "X"
        '
        'chkFastStop
        '
        Me.chkFastStop.AutoSize = True
        Me.chkFastStop.Location = New System.Drawing.Point(15, 157)
        Me.chkFastStop.Name = "chkFastStop"
        Me.chkFastStop.Size = New System.Drawing.Size(228, 17)
        Me.chkFastStop.TabIndex = 25
        Me.chkFastStop.Text = "Stop searching at the first found comment"
        Me.chkFastStop.UseVisualStyleBackColor = True
        '
        'seperatorA
        '
        Me.seperatorA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.seperatorA.BackColor = System.Drawing.Color.White
        Me.seperatorA.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.seperatorA.Color2 = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.seperatorA.Direction = System.Windows.Forms.Orientation.Horizontal
        Me.seperatorA.Image = Nothing
        Me.seperatorA.Location = New System.Drawing.Point(9, 143)
        Me.seperatorA.Name = "seperatorA"
        Me.seperatorA.NoRounding = False
        Me.seperatorA.Size = New System.Drawing.Size(390, 10)
        Me.seperatorA.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Max pages to search"
        '
        'Max
        '
        Me.Max.Location = New System.Drawing.Point(125, 120)
        Me.Max.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Max.Name = "Max"
        Me.Max.Size = New System.Drawing.Size(270, 21)
        Me.Max.TabIndex = 3
        Me.Max.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'btnSearch
        '
        Me.btnSearch.Image = Nothing
        Me.btnSearch.Location = New System.Drawing.Point(12, 91)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.NoRounding = False
        Me.btnSearch.Size = New System.Drawing.Size(383, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(12, 64)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(383, 21)
        Me.txtUsername.TabIndex = 1
        '
        'txtVideo
        '
        Me.txtVideo.Location = New System.Drawing.Point(12, 37)
        Me.txtVideo.Name = "txtVideo"
        Me.txtVideo.Size = New System.Drawing.Size(383, 21)
        Me.txtVideo.TabIndex = 2
        '
        'CM
        '
        Me.CM.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Use selected"
        '
        'frmCommentFinder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 484)
        Me.Controls.Add(Me.Theme)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCommentFinder"
        Me.Text = "Find comment ID"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme.ResumeLayout(False)
        Me.Theme.PerformLayout()
        CType(Me.Max, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme As Tubenoia.NTheme
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtVideo As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As Tubenoia.NButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Max As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkFastStop As System.Windows.Forms.CheckBox
    Friend WithEvents seperatorA As Tubenoia.Seperator
    Friend WithEvents btnMinimize As Tubenoia.NButton
    Friend WithEvents btnExit As Tubenoia.NButton
    Friend WithEvents lstComments As System.Windows.Forms.ListView
    Friend WithEvents Author As System.Windows.Forms.ColumnHeader
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents CM As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Textc As System.Windows.Forms.ColumnHeader
End Class
