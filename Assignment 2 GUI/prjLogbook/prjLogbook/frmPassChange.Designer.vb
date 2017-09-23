<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassChange
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
        Me.lblOldPass = New System.Windows.Forms.Label()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblOldPass
        '
        Me.lblOldPass.AutoSize = True
        Me.lblOldPass.BackColor = System.Drawing.Color.Transparent
        Me.lblOldPass.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldPass.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblOldPass.Location = New System.Drawing.Point(58, 67)
        Me.lblOldPass.Name = "lblOldPass"
        Me.lblOldPass.Size = New System.Drawing.Size(91, 17)
        Me.lblOldPass.TabIndex = 0
        Me.lblOldPass.Text = "Old Password:"
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPass.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPass.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNewPass.Location = New System.Drawing.Point(58, 106)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(95, 17)
        Me.lblNewPass.TabIndex = 1
        Me.lblNewPass.Text = "New Password:"
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirm.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblConfirm.Location = New System.Drawing.Point(58, 145)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(120, 17)
        Me.lblConfirm.TabIndex = 2
        Me.lblConfirm.Text = "Confirm Password:"
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(193, 101)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(109, 20)
        Me.txtNewPass.TabIndex = 4
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(193, 140)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(109, 20)
        Me.txtConfirm.TabIndex = 5
        '
        'btnChangePass
        '
        Me.btnChangePass.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnChangePass.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePass.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnChangePass.Location = New System.Drawing.Point(43, 209)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(144, 30)
        Me.btnChangePass.TabIndex = 6
        Me.btnChangePass.Text = "Change Password"
        Me.btnChangePass.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(227, 209)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWelcome.Location = New System.Drawing.Point(90, 18)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(77, 20)
        Me.lblWelcome.TabIndex = 8
        Me.lblWelcome.Text = "Welcome"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblName.Location = New System.Drawing.Point(187, 18)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 20)
        Me.lblName.TabIndex = 9
        '
        'txtOldPass
        '
        Me.txtOldPass.Location = New System.Drawing.Point(193, 66)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.Size = New System.Drawing.Size(109, 20)
        Me.txtOldPass.TabIndex = 3
        '
        'frmPassChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prjLogbook.My.Resources.Resources.background6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(367, 262)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnChangePass)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtOldPass)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.lblNewPass)
        Me.Controls.Add(Me.lblOldPass)
        Me.Name = "frmPassChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Change Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOldPass As Label
    Friend WithEvents lblNewPass As Label
    Friend WithEvents lblConfirm As Label
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents btnChangePass As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtOldPass As TextBox
End Class
