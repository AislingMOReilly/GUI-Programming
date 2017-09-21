<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminRoom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminRoom))
        Me.txtNumComps = New System.Windows.Forms.TextBox()
        Me.lblNumComps = New System.Windows.Forms.Label()
        Me.txtRoomName = New System.Windows.Forms.TextBox()
        Me.lblRoomName = New System.Windows.Forms.Label()
        Me.cmbSelRoom = New System.Windows.Forms.ComboBox()
        Me.lblSelRoom = New System.Windows.Forms.Label()
        Me.cmbSelFunc = New System.Windows.Forms.ComboBox()
        Me.lblSelFunc = New System.Windows.Forms.Label()
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdateRoom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumComps
        '
        Me.txtNumComps.Location = New System.Drawing.Point(167, 211)
        Me.txtNumComps.Name = "txtNumComps"
        Me.txtNumComps.Size = New System.Drawing.Size(114, 20)
        Me.txtNumComps.TabIndex = 70
        '
        'lblNumComps
        '
        Me.lblNumComps.AutoSize = True
        Me.lblNumComps.BackColor = System.Drawing.Color.Transparent
        Me.lblNumComps.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumComps.ForeColor = System.Drawing.Color.White
        Me.lblNumComps.Location = New System.Drawing.Point(50, 214)
        Me.lblNumComps.Name = "lblNumComps"
        Me.lblNumComps.Size = New System.Drawing.Size(116, 17)
        Me.lblNumComps.TabIndex = 69
        Me.lblNumComps.Text = "No. of Computers:"
        '
        'txtRoomName
        '
        Me.txtRoomName.Location = New System.Drawing.Point(167, 172)
        Me.txtRoomName.Name = "txtRoomName"
        Me.txtRoomName.Size = New System.Drawing.Size(114, 20)
        Me.txtRoomName.TabIndex = 68
        '
        'lblRoomName
        '
        Me.lblRoomName.AutoSize = True
        Me.lblRoomName.BackColor = System.Drawing.Color.Transparent
        Me.lblRoomName.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomName.ForeColor = System.Drawing.Color.White
        Me.lblRoomName.Location = New System.Drawing.Point(68, 175)
        Me.lblRoomName.Name = "lblRoomName"
        Me.lblRoomName.Size = New System.Drawing.Size(84, 17)
        Me.lblRoomName.TabIndex = 67
        Me.lblRoomName.Text = "Room Name:"
        '
        'cmbSelRoom
        '
        Me.cmbSelRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelRoom.FormattingEnabled = True
        Me.cmbSelRoom.Location = New System.Drawing.Point(160, 128)
        Me.cmbSelRoom.Name = "cmbSelRoom"
        Me.cmbSelRoom.Size = New System.Drawing.Size(121, 21)
        Me.cmbSelRoom.TabIndex = 66
        '
        'lblSelRoom
        '
        Me.lblSelRoom.AutoSize = True
        Me.lblSelRoom.BackColor = System.Drawing.Color.Transparent
        Me.lblSelRoom.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelRoom.ForeColor = System.Drawing.Color.White
        Me.lblSelRoom.Location = New System.Drawing.Point(66, 131)
        Me.lblSelRoom.Name = "lblSelRoom"
        Me.lblSelRoom.Size = New System.Drawing.Size(82, 17)
        Me.lblSelRoom.TabIndex = 65
        Me.lblSelRoom.Text = "Select Room:"
        '
        'cmbSelFunc
        '
        Me.cmbSelFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelFunc.FormattingEnabled = True
        Me.cmbSelFunc.Items.AddRange(New Object() {"Add", "Remove", "Modify"})
        Me.cmbSelFunc.Location = New System.Drawing.Point(160, 91)
        Me.cmbSelFunc.Name = "cmbSelFunc"
        Me.cmbSelFunc.Size = New System.Drawing.Size(121, 21)
        Me.cmbSelFunc.TabIndex = 64
        '
        'lblSelFunc
        '
        Me.lblSelFunc.AutoSize = True
        Me.lblSelFunc.BackColor = System.Drawing.Color.Transparent
        Me.lblSelFunc.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelFunc.ForeColor = System.Drawing.Color.White
        Me.lblSelFunc.Location = New System.Drawing.Point(58, 91)
        Me.lblSelFunc.Name = "lblSelFunc"
        Me.lblSelFunc.Size = New System.Drawing.Size(99, 17)
        Me.lblSelFunc.TabIndex = 63
        Me.lblSelFunc.Text = "Select Function:"
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.BackColor = System.Drawing.Color.Black
        Me.lblTitle1.Font = New System.Drawing.Font("Calisto MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.ForeColor = System.Drawing.Color.White
        Me.lblTitle1.Location = New System.Drawing.Point(79, 44)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(202, 22)
        Me.lblTitle1.TabIndex = 95
        Me.lblTitle1.Text = "Edit Computer Rooms"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(247, 280)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 102
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnUpdateRoom
        '
        Me.btnUpdateRoom.BackColor = System.Drawing.Color.Black
        Me.btnUpdateRoom.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdateRoom.Location = New System.Drawing.Point(12, 280)
        Me.btnUpdateRoom.Name = "btnUpdateRoom"
        Me.btnUpdateRoom.Size = New System.Drawing.Size(154, 29)
        Me.btnUpdateRoom.TabIndex = 104
        Me.btnUpdateRoom.Text = "Update Room Details"
        Me.btnUpdateRoom.UseVisualStyleBackColor = False
        '
        'frmAdminRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(349, 318)
        Me.Controls.Add(Me.btnUpdateRoom)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTitle1)
        Me.Controls.Add(Me.txtNumComps)
        Me.Controls.Add(Me.lblNumComps)
        Me.Controls.Add(Me.txtRoomName)
        Me.Controls.Add(Me.lblRoomName)
        Me.Controls.Add(Me.cmbSelRoom)
        Me.Controls.Add(Me.lblSelRoom)
        Me.Controls.Add(Me.cmbSelFunc)
        Me.Controls.Add(Me.lblSelFunc)
        Me.Name = "frmAdminRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumComps As TextBox
    Friend WithEvents lblNumComps As Label
    Friend WithEvents txtRoomName As TextBox
    Friend WithEvents lblRoomName As Label
    Friend WithEvents cmbSelRoom As ComboBox
    Friend WithEvents lblSelRoom As Label
    Friend WithEvents cmbSelFunc As ComboBox
    Friend WithEvents lblSelFunc As Label
    Friend WithEvents lblTitle1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdateRoom As Button
End Class
