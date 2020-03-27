<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.grpSelect = New System.Windows.Forms.GroupBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.rdoEmployee = New System.Windows.Forms.RadioButton()
        Me.rdoCustomer = New System.Windows.Forms.RadioButton()
        Me.rdoManager = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStyle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.grpSelect.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.Control
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblName.Location = New System.Drawing.Point(79, 218)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(124, 29)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Username"
        Me.lblName.Visible = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblPassword.Location = New System.Drawing.Point(79, 322)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(120, 29)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        Me.lblPassword.Visible = False
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.SystemColors.Control
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(222, 221)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(298, 23)
        Me.txtUser.TabIndex = 2
        Me.txtUser.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Control
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(222, 329)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(298, 23)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Turquoise
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnExit.Location = New System.Drawing.Point(222, 380)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 44)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Turquoise
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLogin.Location = New System.Drawing.Point(350, 380)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(102, 44)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        Me.btnLogin.Visible = False
        '
        'grpSelect
        '
        Me.grpSelect.Controls.Add(Me.btnNext)
        Me.grpSelect.Controls.Add(Me.rdoEmployee)
        Me.grpSelect.Controls.Add(Me.rdoCustomer)
        Me.grpSelect.Controls.Add(Me.rdoManager)
        Me.grpSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelect.Location = New System.Drawing.Point(84, 215)
        Me.grpSelect.Name = "grpSelect"
        Me.grpSelect.Size = New System.Drawing.Size(436, 137)
        Me.grpSelect.TabIndex = 6
        Me.grpSelect.TabStop = False
        Me.grpSelect.Text = "Please select one"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Turquoise
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNext.Location = New System.Drawing.Point(266, 59)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(102, 44)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'rdoEmployee
        '
        Me.rdoEmployee.AutoSize = True
        Me.rdoEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoEmployee.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.rdoEmployee.Location = New System.Drawing.Point(40, 102)
        Me.rdoEmployee.Name = "rdoEmployee"
        Me.rdoEmployee.Size = New System.Drawing.Size(120, 29)
        Me.rdoEmployee.TabIndex = 2
        Me.rdoEmployee.TabStop = True
        Me.rdoEmployee.Text = "Employee"
        Me.rdoEmployee.UseVisualStyleBackColor = True
        '
        'rdoCustomer
        '
        Me.rdoCustomer.AutoSize = True
        Me.rdoCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCustomer.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.rdoCustomer.Location = New System.Drawing.Point(42, 67)
        Me.rdoCustomer.Name = "rdoCustomer"
        Me.rdoCustomer.Size = New System.Drawing.Size(118, 29)
        Me.rdoCustomer.TabIndex = 1
        Me.rdoCustomer.TabStop = True
        Me.rdoCustomer.Text = "Customer"
        Me.rdoCustomer.UseVisualStyleBackColor = True
        '
        'rdoManager
        '
        Me.rdoManager.AutoSize = True
        Me.rdoManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoManager.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.rdoManager.Location = New System.Drawing.Point(42, 32)
        Me.rdoManager.Name = "rdoManager"
        Me.rdoManager.Size = New System.Drawing.Size(111, 29)
        Me.rdoManager.TabIndex = 0
        Me.rdoManager.TabStop = True
        Me.rdoManager.Text = "Manager"
        Me.rdoManager.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.lblStyle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(591, 186)
        Me.Panel1.TabIndex = 7
        '
        'lblStyle
        '
        Me.lblStyle.AutoSize = True
        Me.lblStyle.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStyle.Location = New System.Drawing.Point(215, 76)
        Me.lblStyle.Name = "lblStyle"
        Me.lblStyle.Size = New System.Drawing.Size(161, 37)
        Me.lblStyle.TabIndex = 0
        Me.lblStyle.Text = "Your Style"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Location = New System.Drawing.Point(222, 245)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(298, 1)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel3.Location = New System.Drawing.Point(222, 350)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(298, 1)
        Me.Panel3.TabIndex = 9
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(591, 513)
        Me.Controls.Add(Me.grpSelect)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login "
        Me.grpSelect.ResumeLayout(False)
        Me.grpSelect.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents grpSelect As GroupBox
    Friend WithEvents rdoEmployee As RadioButton
    Friend WithEvents rdoCustomer As RadioButton
    Friend WithEvents rdoManager As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblStyle As Label
End Class
