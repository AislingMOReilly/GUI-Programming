<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminUsers))
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.cmbSelUser = New System.Windows.Forms.ComboBox()
        Me.lblSelUser = New System.Windows.Forms.Label()
        Me.btnUpdateUser = New System.Windows.Forms.Button()
        Me.cmbSelFunc = New System.Windows.Forms.ComboBox()
        Me.lblSelFunc3 = New System.Windows.Forms.Label()
        Me.lblTitle3 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.BackColor = System.Drawing.Color.Transparent
        Me.lblUserType.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUserType.Location = New System.Drawing.Point(87, 232)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(68, 17)
        Me.lblUserType.TabIndex = 122
        Me.lblUserType.Text = "User Type:"
        '
        'cmbSelUser
        '
        Me.cmbSelUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbSelUser.FormattingEnabled = True
        Me.cmbSelUser.Location = New System.Drawing.Point(165, 119)
        Me.cmbSelUser.Name = "cmbSelUser"
        Me.cmbSelUser.Size = New System.Drawing.Size(121, 21)
        Me.cmbSelUser.TabIndex = 121
        '
        'lblSelUser
        '
        Me.lblSelUser.AutoSize = True
        Me.lblSelUser.BackColor = System.Drawing.Color.Transparent
        Me.lblSelUser.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelUser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSelUser.Location = New System.Drawing.Point(79, 123)
        Me.lblSelUser.Name = "lblSelUser"
        Me.lblSelUser.Size = New System.Drawing.Size(71, 17)
        Me.lblSelUser.TabIndex = 120
        Me.lblSelUser.Text = "Select User:"
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.BackColor = System.Drawing.Color.Black
        Me.btnUpdateUser.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateUser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdateUser.Location = New System.Drawing.Point(10, 299)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(98, 38)
        Me.btnUpdateUser.TabIndex = 119
        Me.btnUpdateUser.Text = "Update User"
        Me.btnUpdateUser.UseVisualStyleBackColor = False
        '
        'cmbSelFunc
        '
        Me.cmbSelFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelFunc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbSelFunc.FormattingEnabled = True
        Me.cmbSelFunc.Items.AddRange(New Object() {"Add", "Remove"})
        Me.cmbSelFunc.Location = New System.Drawing.Point(165, 82)
        Me.cmbSelFunc.Name = "cmbSelFunc"
        Me.cmbSelFunc.Size = New System.Drawing.Size(121, 21)
        Me.cmbSelFunc.TabIndex = 118
        '
        'lblSelFunc3
        '
        Me.lblSelFunc3.AutoSize = True
        Me.lblSelFunc3.BackColor = System.Drawing.Color.Transparent
        Me.lblSelFunc3.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelFunc3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSelFunc3.Location = New System.Drawing.Point(61, 86)
        Me.lblSelFunc3.Name = "lblSelFunc3"
        Me.lblSelFunc3.Size = New System.Drawing.Size(99, 17)
        Me.lblSelFunc3.TabIndex = 117
        Me.lblSelFunc3.Text = "Select Function:"
        '
        'lblTitle3
        '
        Me.lblTitle3.AutoSize = True
        Me.lblTitle3.BackColor = System.Drawing.Color.Black
        Me.lblTitle3.Font = New System.Drawing.Font("Calisto MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle3.ForeColor = System.Drawing.Color.White
        Me.lblTitle3.Location = New System.Drawing.Point(144, 35)
        Me.lblTitle3.Name = "lblTitle3"
        Me.lblTitle3.Size = New System.Drawing.Size(99, 22)
        Me.lblTitle3.TabIndex = 116
        Me.lblTitle3.Text = "Edit Users"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(172, 195)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(114, 20)
        Me.txtPass.TabIndex = 115
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        Me.lblPass.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPass.Location = New System.Drawing.Point(87, 198)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(66, 17)
        Me.lblPass.TabIndex = 114
        Me.lblPass.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(172, 162)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(114, 20)
        Me.txtUsername.TabIndex = 113
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUsername.Location = New System.Drawing.Point(87, 164)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(68, 17)
        Me.lblUsername.TabIndex = 112
        Me.lblUsername.Text = "Username:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(272, 299)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 38)
        Me.btnExit.TabIndex = 125
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'cmbUserType
        '
        Me.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"TR", "AR", "TN"})
        Me.cmbUserType.Location = New System.Drawing.Point(172, 231)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(114, 21)
        Me.cmbUserType.TabIndex = 126
        '
        'frmAdminUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(376, 345)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.cmbSelUser)
        Me.Controls.Add(Me.lblSelUser)
        Me.Controls.Add(Me.btnUpdateUser)
        Me.Controls.Add(Me.cmbSelFunc)
        Me.Controls.Add(Me.lblSelFunc3)
        Me.Controls.Add(Me.lblTitle3)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "frmAdminUsers"
        Me.Text = "Edit Users Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserType As Label
    Friend WithEvents cmbSelUser As ComboBox
    Friend WithEvents lblSelUser As Label
    Friend WithEvents btnUpdateUser As Button
    Friend WithEvents cmbSelFunc As ComboBox
    Friend WithEvents lblSelFunc3 As Label
    Friend WithEvents lblTitle3 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents cmbUserType As ComboBox
End Class
