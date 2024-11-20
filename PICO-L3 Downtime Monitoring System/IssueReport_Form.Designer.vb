<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueReport_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IssueReport_Form))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.cboIssue = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtProcess = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLine = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSend = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GroupBox1.BorderRadius = 10
        Me.Guna2GroupBox1.BorderThickness = 5
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox1.Controls.Add(Me.cboIssue)
        Me.Guna2GroupBox1.Controls.Add(Me.txtProcess)
        Me.Guna2GroupBox1.Controls.Add(Me.txtLine)
        Me.Guna2GroupBox1.Controls.Add(Me.btnSend)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(526, 382)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Line Issue Report"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button1.Location = New System.Drawing.Point(486, 4)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.Size = New System.Drawing.Size(29, 29)
        Me.Guna2Button1.TabIndex = 7
        '
        'cboIssue
        '
        Me.cboIssue.BackColor = System.Drawing.Color.Transparent
        Me.cboIssue.BorderRadius = 15
        Me.cboIssue.BorderThickness = 2
        Me.cboIssue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboIssue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIssue.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboIssue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboIssue.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.cboIssue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboIssue.ItemHeight = 30
        Me.cboIssue.Items.AddRange(New Object() {"Machine", "Quality"})
        Me.cboIssue.Location = New System.Drawing.Point(175, 225)
        Me.cboIssue.Name = "cboIssue"
        Me.cboIssue.ShadowDecoration.BorderRadius = 15
        Me.cboIssue.ShadowDecoration.Depth = 15
        Me.cboIssue.ShadowDecoration.Enabled = True
        Me.cboIssue.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.cboIssue.Size = New System.Drawing.Size(292, 36)
        Me.cboIssue.TabIndex = 6
        '
        'txtProcess
        '
        Me.txtProcess.BackColor = System.Drawing.Color.Transparent
        Me.txtProcess.BorderRadius = 15
        Me.txtProcess.BorderThickness = 2
        Me.txtProcess.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProcess.DefaultText = ""
        Me.txtProcess.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProcess.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProcess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProcess.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProcess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProcess.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtProcess.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProcess.Location = New System.Drawing.Point(175, 160)
        Me.txtProcess.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtProcess.Name = "txtProcess"
        Me.txtProcess.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProcess.PlaceholderText = ""
        Me.txtProcess.ReadOnly = True
        Me.txtProcess.SelectedText = ""
        Me.txtProcess.ShadowDecoration.BorderRadius = 15
        Me.txtProcess.ShadowDecoration.Depth = 15
        Me.txtProcess.ShadowDecoration.Enabled = True
        Me.txtProcess.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtProcess.Size = New System.Drawing.Size(292, 45)
        Me.txtProcess.TabIndex = 5
        '
        'txtLine
        '
        Me.txtLine.BackColor = System.Drawing.Color.Transparent
        Me.txtLine.BorderRadius = 15
        Me.txtLine.BorderThickness = 2
        Me.txtLine.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLine.DefaultText = ""
        Me.txtLine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLine.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLine.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLine.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLine.Location = New System.Drawing.Point(175, 91)
        Me.txtLine.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtLine.Name = "txtLine"
        Me.txtLine.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLine.PlaceholderText = ""
        Me.txtLine.ReadOnly = True
        Me.txtLine.SelectedText = ""
        Me.txtLine.ShadowDecoration.BorderRadius = 15
        Me.txtLine.ShadowDecoration.Depth = 15
        Me.txtLine.ShadowDecoration.Enabled = True
        Me.txtLine.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtLine.Size = New System.Drawing.Size(292, 45)
        Me.txtLine.TabIndex = 4
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Transparent
        Me.btnSend.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSend.BorderRadius = 10
        Me.btnSend.BorderThickness = 2
        Me.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSend.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSend.FillColor = System.Drawing.SystemColors.Control
        Me.btnSend.FillColor2 = System.Drawing.SystemColors.Control
        Me.btnSend.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.Black
        Me.btnSend.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnSend.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnSend.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnSend.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(372, 303)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.ShadowDecoration.BorderRadius = 10
        Me.btnSend.ShadowDecoration.Depth = 17
        Me.btnSend.ShadowDecoration.Enabled = True
        Me.btnSend.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.btnSend.Size = New System.Drawing.Size(113, 41)
        Me.btnSend.TabIndex = 3
        Me.btnSend.Text = "Send"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(73, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Issue:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(36, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Process: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(78, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Line: "
        '
        'IssueReport_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 382)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IssueReport_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "IssueReport_Form"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSend As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtLine As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cboIssue As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtProcess As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
