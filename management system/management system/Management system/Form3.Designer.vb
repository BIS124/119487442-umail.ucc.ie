<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnHere = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblStyle = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(603, 68)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(171, 32)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to "
        '
        'btnHere
        '
        Me.btnHere.FlatAppearance.BorderSize = 0
        Me.btnHere.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHere.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHere.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHere.Location = New System.Drawing.Point(581, 414)
        Me.btnHere.Name = "btnHere"
        Me.btnHere.Size = New System.Drawing.Size(207, 63)
        Me.btnHere.TabIndex = 1
        Me.btnHere.Text = "Login  Here"
        Me.btnHere.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(554, 648)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblStyle
        '
        Me.lblStyle.AutoSize = True
        Me.lblStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStyle.Location = New System.Drawing.Point(603, 117)
        Me.lblStyle.Name = "lblStyle"
        Me.lblStyle.Size = New System.Drawing.Size(154, 32)
        Me.lblStyle.TabIndex = 3
        Me.lblStyle.Text = "Your Style!"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(825, 605)
        Me.Controls.Add(Me.lblStyle)
        Me.Controls.Add(Me.btnHere)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnHere As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblStyle As Label
End Class
