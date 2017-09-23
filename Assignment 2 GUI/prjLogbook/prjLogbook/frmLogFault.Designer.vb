<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogFault
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
        Me.lblRoomNo = New System.Windows.Forms.Label()
        Me.lblLogBy = New System.Windows.Forms.Label()
        Me.btnDate = New System.Windows.Forms.Label()
        Me.txtFaultDesc = New System.Windows.Forms.TextBox()
        Me.lblFaultDesc = New System.Windows.Forms.Label()
        Me.lblCompNo = New System.Windows.Forms.Label()
        Me.btnLogFault = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cmbRoomNo = New System.Windows.Forms.ComboBox()
        Me.cmbCompNo = New System.Windows.Forms.ComboBox()
        Me.lblFaultDate = New System.Windows.Forms.Label()
        Me.lblLogged = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRoomNo
        '
        Me.lblRoomNo.AutoSize = True
        Me.lblRoomNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRoomNo.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomNo.Location = New System.Drawing.Point(57, 116)
        Me.lblRoomNo.Name = "lblRoomNo"
        Me.lblRoomNo.Size = New System.Drawing.Size(99, 17)
        Me.lblRoomNo.TabIndex = 8
        Me.lblRoomNo.Text = "Room Number:"
        '
        'lblLogBy
        '
        Me.lblLogBy.AutoSize = True
        Me.lblLogBy.BackColor = System.Drawing.Color.Transparent
        Me.lblLogBy.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogBy.Location = New System.Drawing.Point(57, 77)
        Me.lblLogBy.Name = "lblLogBy"
        Me.lblLogBy.Size = New System.Drawing.Size(70, 17)
        Me.lblLogBy.TabIndex = 7
        Me.lblLogBy.Text = "Logged by:"
        '
        'btnDate
        '
        Me.btnDate.AutoSize = True
        Me.btnDate.BackColor = System.Drawing.Color.Transparent
        Me.btnDate.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDate.Location = New System.Drawing.Point(57, 38)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(39, 17)
        Me.btnDate.TabIndex = 6
        Me.btnDate.Text = "Date:"
        '
        'txtFaultDesc
        '
        Me.txtFaultDesc.Location = New System.Drawing.Point(201, 187)
        Me.txtFaultDesc.Multiline = True
        Me.txtFaultDesc.Name = "txtFaultDesc"
        Me.txtFaultDesc.Size = New System.Drawing.Size(138, 85)
        Me.txtFaultDesc.TabIndex = 16
        '
        'lblFaultDesc
        '
        Me.lblFaultDesc.AutoSize = True
        Me.lblFaultDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblFaultDesc.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaultDesc.Location = New System.Drawing.Point(57, 190)
        Me.lblFaultDesc.Name = "lblFaultDesc"
        Me.lblFaultDesc.Size = New System.Drawing.Size(113, 17)
        Me.lblFaultDesc.TabIndex = 13
        Me.lblFaultDesc.Text = "Fault Description:"
        '
        'lblCompNo
        '
        Me.lblCompNo.AutoSize = True
        Me.lblCompNo.BackColor = System.Drawing.Color.Transparent
        Me.lblCompNo.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompNo.Location = New System.Drawing.Point(57, 151)
        Me.lblCompNo.Name = "lblCompNo"
        Me.lblCompNo.Size = New System.Drawing.Size(123, 17)
        Me.lblCompNo.TabIndex = 12
        Me.lblCompNo.Text = "Computer Number:"
        '
        'btnLogFault
        '
        Me.btnLogFault.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnLogFault.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogFault.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogFault.Location = New System.Drawing.Point(33, 301)
        Me.btnLogFault.Name = "btnLogFault"
        Me.btnLogFault.Size = New System.Drawing.Size(93, 33)
        Me.btnLogFault.TabIndex = 17
        Me.btnLogFault.Text = "Log Fault"
        Me.btnLogFault.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(254, 301)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 33)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'cmbRoomNo
        '
        Me.cmbRoomNo.FormattingEnabled = True
        Me.cmbRoomNo.Location = New System.Drawing.Point(201, 117)
        Me.cmbRoomNo.Name = "cmbRoomNo"
        Me.cmbRoomNo.Size = New System.Drawing.Size(121, 21)
        Me.cmbRoomNo.TabIndex = 19
        '
        'cmbCompNo
        '
        Me.cmbCompNo.FormattingEnabled = True
        Me.cmbCompNo.Location = New System.Drawing.Point(201, 152)
        Me.cmbCompNo.Name = "cmbCompNo"
        Me.cmbCompNo.Size = New System.Drawing.Size(121, 21)
        Me.cmbCompNo.TabIndex = 20
        '
        'lblFaultDate
        '
        Me.lblFaultDate.AutoSize = True
        Me.lblFaultDate.BackColor = System.Drawing.Color.Transparent
        Me.lblFaultDate.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaultDate.Location = New System.Drawing.Point(198, 38)
        Me.lblFaultDate.Name = "lblFaultDate"
        Me.lblFaultDate.Size = New System.Drawing.Size(0, 17)
        Me.lblFaultDate.TabIndex = 21
        '
        'lblLogged
        '
        Me.lblLogged.AutoSize = True
        Me.lblLogged.BackColor = System.Drawing.Color.Transparent
        Me.lblLogged.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogged.Location = New System.Drawing.Point(198, 77)
        Me.lblLogged.Name = "lblLogged"
        Me.lblLogged.Size = New System.Drawing.Size(0, 17)
        Me.lblLogged.TabIndex = 22
        '
        'frmLogFault
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prjLogbook.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(391, 346)
        Me.Controls.Add(Me.lblLogged)
        Me.Controls.Add(Me.lblFaultDate)
        Me.Controls.Add(Me.cmbCompNo)
        Me.Controls.Add(Me.cmbRoomNo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogFault)
        Me.Controls.Add(Me.txtFaultDesc)
        Me.Controls.Add(Me.lblFaultDesc)
        Me.Controls.Add(Me.lblCompNo)
        Me.Controls.Add(Me.lblRoomNo)
        Me.Controls.Add(Me.lblLogBy)
        Me.Controls.Add(Me.btnDate)
        Me.Name = "frmLogFault"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Log Fault Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRoomNo As Label
    Friend WithEvents lblLogBy As Label
    Friend WithEvents btnDate As Label
    Friend WithEvents txtFaultDesc As TextBox
    Friend WithEvents lblFaultDesc As Label
    Friend WithEvents lblCompNo As Label
    Friend WithEvents btnLogFault As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cmbRoomNo As ComboBox
    Friend WithEvents cmbCompNo As ComboBox
    Friend WithEvents lblFaultDate As Label
    Friend WithEvents lblLogged As Label
End Class
