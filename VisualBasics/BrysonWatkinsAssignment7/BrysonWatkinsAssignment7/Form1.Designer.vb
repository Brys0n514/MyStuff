<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintYachtTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewSummary = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintYachtsControl = New System.Drawing.Printing.PrintDocument()
        Me.PrintSummaryControl = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewYacht = New System.Windows.Forms.PrintPreviewDialog()
        Me.YachtsComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.yachtLabel = New System.Windows.Forms.Label()
        Me.yachtSizeListBox1 = New System.Windows.Forms.ListBox()
        Me.YachtSizeLabel1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.inputHoursLabel1 = New System.Windows.Forms.Label()
        Me.HoursTextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(462, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSummaryToolStripMenuItem, Me.PrintYachtTypesToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ToolStripTextBox1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintSummaryToolStripMenuItem
        '
        Me.PrintSummaryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintPreviewToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.PrintSummaryToolStripMenuItem.Name = "PrintSummaryToolStripMenuItem"
        Me.PrintSummaryToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PrintSummaryToolStripMenuItem.Text = "Print &Summary"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print P&review"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintYachtTypesToolStripMenuItem
        '
        Me.PrintYachtTypesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintPreviewToolStripMenuItem1, Me.PrintToolStripMenuItem1})
        Me.PrintYachtTypesToolStripMenuItem.Name = "PrintYachtTypesToolStripMenuItem"
        Me.PrintYachtTypesToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PrintYachtTypesToolStripMenuItem.Text = "Print &Yacht Types"
        '
        'PrintPreviewToolStripMenuItem1
        '
        Me.PrintPreviewToolStripMenuItem1.Name = "PrintPreviewToolStripMenuItem1"
        Me.PrintPreviewToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.PrintPreviewToolStripMenuItem1.Text = "Print P&review"
        '
        'PrintToolStripMenuItem1
        '
        Me.PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1"
        Me.PrintToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.PrintToolStripMenuItem1.Text = "&Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(163, 6)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "&Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'PrintPreviewSummary
        '
        Me.PrintPreviewSummary.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewSummary.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewSummary.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewSummary.Enabled = True
        Me.PrintPreviewSummary.Icon = CType(resources.GetObject("PrintPreviewSummary.Icon"), System.Drawing.Icon)
        Me.PrintPreviewSummary.Name = "PrintPreviewSummary"
        Me.PrintPreviewSummary.Visible = False
        '
        'PrintSummaryControl
        '
        '
        'PrintPreviewYacht
        '
        Me.PrintPreviewYacht.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewYacht.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewYacht.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewYacht.Enabled = True
        Me.PrintPreviewYacht.Icon = CType(resources.GetObject("PrintPreviewYacht.Icon"), System.Drawing.Icon)
        Me.PrintPreviewYacht.Name = "PrintPreviewYacht"
        Me.PrintPreviewYacht.Visible = False
        '
        'YachtsComboBox1
        '
        Me.YachtsComboBox1.FormattingEnabled = True
        Me.YachtsComboBox1.Items.AddRange(New Object() {"Ranger", "Wavelength", "Catalina ", "Coronado ", "Hobie", "C & C", "Hans Chritian", "Excalibur"})
        Me.YachtsComboBox1.Location = New System.Drawing.Point(53, 69)
        Me.YachtsComboBox1.Name = "YachtsComboBox1"
        Me.YachtsComboBox1.Size = New System.Drawing.Size(163, 21)
        Me.YachtsComboBox1.TabIndex = 2
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(53, 268)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton.TabIndex = 3
        Me.CalcButton.Text = "&Ok"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'yachtLabel
        '
        Me.yachtLabel.AutoSize = True
        Me.yachtLabel.Location = New System.Drawing.Point(50, 53)
        Me.yachtLabel.Name = "yachtLabel"
        Me.yachtLabel.Size = New System.Drawing.Size(65, 13)
        Me.yachtLabel.TabIndex = 4
        Me.yachtLabel.Text = "Yacht Type:"
        '
        'yachtSizeListBox1
        '
        Me.yachtSizeListBox1.FormattingEnabled = True
        Me.yachtSizeListBox1.Items.AddRange(New Object() {"22", "24", "30", "36", "38", "45"})
        Me.yachtSizeListBox1.Location = New System.Drawing.Point(53, 157)
        Me.yachtSizeListBox1.Name = "yachtSizeListBox1"
        Me.yachtSizeListBox1.Size = New System.Drawing.Size(78, 82)
        Me.yachtSizeListBox1.TabIndex = 5
        '
        'YachtSizeLabel1
        '
        Me.YachtSizeLabel1.AutoSize = True
        Me.YachtSizeLabel1.Location = New System.Drawing.Point(50, 141)
        Me.YachtSizeLabel1.Name = "YachtSizeLabel1"
        Me.YachtSizeLabel1.Size = New System.Drawing.Size(58, 13)
        Me.YachtSizeLabel1.TabIndex = 6
        Me.YachtSizeLabel1.Text = "Yacht Size"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(53, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Add Yacht"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'inputHoursLabel1
        '
        Me.inputHoursLabel1.AutoSize = True
        Me.inputHoursLabel1.Location = New System.Drawing.Point(285, 53)
        Me.inputHoursLabel1.Name = "inputHoursLabel1"
        Me.inputHoursLabel1.Size = New System.Drawing.Size(35, 13)
        Me.inputHoursLabel1.TabIndex = 8
        Me.inputHoursLabel1.Text = "Hours"
        '
        'HoursTextBox1
        '
        Me.HoursTextBox1.Location = New System.Drawing.Point(288, 70)
        Me.HoursTextBox1.Name = "HoursTextBox1"
        Me.HoursTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.HoursTextBox1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 381)
        Me.Controls.Add(Me.HoursTextBox1)
        Me.Controls.Add(Me.inputHoursLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.YachtSizeLabel1)
        Me.Controls.Add(Me.yachtSizeListBox1)
        Me.Controls.Add(Me.yachtLabel)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.YachtsComboBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Yacht Report"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintYachtTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewSummary As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintYachtsControl As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintSummaryControl As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewYacht As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents YachtsComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CalcButton As System.Windows.Forms.Button
    Friend WithEvents yachtLabel As System.Windows.Forms.Label
    Friend WithEvents yachtSizeListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents YachtSizeLabel1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents inputHoursLabel1 As System.Windows.Forms.Label
    Friend WithEvents HoursTextBox1 As System.Windows.Forms.TextBox

End Class
