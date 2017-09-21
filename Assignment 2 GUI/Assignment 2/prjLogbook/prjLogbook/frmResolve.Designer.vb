<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResolve
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
        Me.cmbSelComp = New System.Windows.Forms.ComboBox()
        Me.lblSelComp = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRepair = New System.Windows.Forms.Button()
        Me.lblTechNote = New System.Windows.Forms.Label()
        Me.lblTN = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblUN = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblComputerNum = New System.Windows.Forms.Label()
        Me.lblCN = New System.Windows.Forms.Label()
        Me.lblRoomNum = New System.Windows.Forms.Label()
        Me.lblRN = New System.Windows.Forms.Label()
        Me.lblFaultDate = New System.Windows.Forms.Label()
        Me.lblFD = New System.Windows.Forms.Label()
        Me.lblFaultNum = New System.Windows.Forms.Label()
        Me.lblFN = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbSelComp
        '
        Me.cmbSelComp.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbSelComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelComp.FormattingEnabled = True
        Me.cmbSelComp.Location = New System.Drawing.Point(175, 29)
        Me.cmbSelComp.Name = "cmbSelComp"
        Me.cmbSelComp.Size = New System.Drawing.Size(149, 21)
        Me.cmbSelComp.TabIndex = 70
        '
        'lblSelComp
        '
        Me.lblSelComp.AutoSize = True
        Me.lblSelComp.BackColor = System.Drawing.Color.Transparent
        Me.lblSelComp.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelComp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSelComp.Location = New System.Drawing.Point(31, 30)
        Me.lblSelComp.Name = "lblSelComp"
        Me.lblSelComp.Size = New System.Drawing.Size(121, 18)
        Me.lblSelComp.TabIndex = 69
        Me.lblSelComp.Text = "Select Computer:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(262, 379)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 29)
        Me.btnExit.TabIndex = 73
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnRepair
        '
        Me.btnRepair.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRepair.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepair.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRepair.Location = New System.Drawing.Point(25, 379)
        Me.btnRepair.Name = "btnRepair"
        Me.btnRepair.Size = New System.Drawing.Size(138, 29)
        Me.btnRepair.TabIndex = 74
        Me.btnRepair.Text = "Mark as Repaired"
        Me.btnRepair.UseVisualStyleBackColor = False
        '
        'lblTechNote
        '
        Me.lblTechNote.AutoSize = True
        Me.lblTechNote.BackColor = System.Drawing.Color.Transparent
        Me.lblTechNote.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTechNote.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTechNote.Location = New System.Drawing.Point(182, 323)
        Me.lblTechNote.Name = "lblTechNote"
        Me.lblTechNote.Size = New System.Drawing.Size(0, 17)
        Me.lblTechNote.TabIndex = 102
        '
        'lblTN
        '
        Me.lblTN.AutoSize = True
        Me.lblTN.BackColor = System.Drawing.Color.Transparent
        Me.lblTN.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTN.Location = New System.Drawing.Point(35, 321)
        Me.lblTN.Name = "lblTN"
        Me.lblTN.Size = New System.Drawing.Size(69, 17)
        Me.lblTN.TabIndex = 101
        Me.lblTN.Text = "Tech Note:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUsername.Location = New System.Drawing.Point(182, 280)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(0, 17)
        Me.lblUsername.TabIndex = 100
        '
        'lblUN
        '
        Me.lblUN.AutoSize = True
        Me.lblUN.BackColor = System.Drawing.Color.Transparent
        Me.lblUN.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUN.Location = New System.Drawing.Point(35, 278)
        Me.lblUN.Name = "lblUN"
        Me.lblUN.Size = New System.Drawing.Size(68, 17)
        Me.lblUN.TabIndex = 99
        Me.lblUN.Text = "Username:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDescription.Location = New System.Drawing.Point(182, 238)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(0, 17)
        Me.lblDescription.TabIndex = 98
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDesc.Location = New System.Drawing.Point(35, 236)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(79, 17)
        Me.lblDesc.TabIndex = 97
        Me.lblDesc.Text = "Description:"
        '
        'lblComputerNum
        '
        Me.lblComputerNum.AutoSize = True
        Me.lblComputerNum.BackColor = System.Drawing.Color.Transparent
        Me.lblComputerNum.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerNum.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblComputerNum.Location = New System.Drawing.Point(182, 196)
        Me.lblComputerNum.Name = "lblComputerNum"
        Me.lblComputerNum.Size = New System.Drawing.Size(0, 17)
        Me.lblComputerNum.TabIndex = 96
        '
        'lblCN
        '
        Me.lblCN.AutoSize = True
        Me.lblCN.BackColor = System.Drawing.Color.Transparent
        Me.lblCN.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCN.Location = New System.Drawing.Point(35, 194)
        Me.lblCN.Name = "lblCN"
        Me.lblCN.Size = New System.Drawing.Size(123, 17)
        Me.lblCN.TabIndex = 95
        Me.lblCN.Text = "Computer Number:"
        '
        'lblRoomNum
        '
        Me.lblRoomNum.AutoSize = True
        Me.lblRoomNum.BackColor = System.Drawing.Color.Transparent
        Me.lblRoomNum.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomNum.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRoomNum.Location = New System.Drawing.Point(182, 159)
        Me.lblRoomNum.Name = "lblRoomNum"
        Me.lblRoomNum.Size = New System.Drawing.Size(0, 17)
        Me.lblRoomNum.TabIndex = 94
        '
        'lblRN
        '
        Me.lblRN.AutoSize = True
        Me.lblRN.BackColor = System.Drawing.Color.Transparent
        Me.lblRN.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRN.Location = New System.Drawing.Point(35, 157)
        Me.lblRN.Name = "lblRN"
        Me.lblRN.Size = New System.Drawing.Size(99, 17)
        Me.lblRN.TabIndex = 93
        Me.lblRN.Text = "Room Number:"
        '
        'lblFaultDate
        '
        Me.lblFaultDate.AutoSize = True
        Me.lblFaultDate.BackColor = System.Drawing.Color.Transparent
        Me.lblFaultDate.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaultDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFaultDate.Location = New System.Drawing.Point(182, 117)
        Me.lblFaultDate.Name = "lblFaultDate"
        Me.lblFaultDate.Size = New System.Drawing.Size(0, 17)
        Me.lblFaultDate.TabIndex = 92
        '
        'lblFD
        '
        Me.lblFD.AutoSize = True
        Me.lblFD.BackColor = System.Drawing.Color.Transparent
        Me.lblFD.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFD.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFD.Location = New System.Drawing.Point(35, 115)
        Me.lblFD.Name = "lblFD"
        Me.lblFD.Size = New System.Drawing.Size(73, 17)
        Me.lblFD.TabIndex = 91
        Me.lblFD.Text = "Fault Date:"
        '
        'lblFaultNum
        '
        Me.lblFaultNum.AutoSize = True
        Me.lblFaultNum.BackColor = System.Drawing.Color.Transparent
        Me.lblFaultNum.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaultNum.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFaultNum.Location = New System.Drawing.Point(182, 76)
        Me.lblFaultNum.Name = "lblFaultNum"
        Me.lblFaultNum.Size = New System.Drawing.Size(0, 17)
        Me.lblFaultNum.TabIndex = 90
        '
        'lblFN
        '
        Me.lblFN.AutoSize = True
        Me.lblFN.BackColor = System.Drawing.Color.Transparent
        Me.lblFN.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFN.Location = New System.Drawing.Point(35, 74)
        Me.lblFN.Name = "lblFN"
        Me.lblFN.Size = New System.Drawing.Size(94, 17)
        Me.lblFN.TabIndex = 89
        Me.lblFN.Text = "Fault Number:"
        '
        'frmResolve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prjLogbook.My.Resources.Resources.background4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(363, 420)
        Me.Controls.Add(Me.lblTechNote)
        Me.Controls.Add(Me.lblTN)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblUN)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblComputerNum)
        Me.Controls.Add(Me.lblCN)
        Me.Controls.Add(Me.lblRoomNum)
        Me.Controls.Add(Me.lblRN)
        Me.Controls.Add(Me.lblFaultDate)
        Me.Controls.Add(Me.lblFD)
        Me.Controls.Add(Me.lblFaultNum)
        Me.Controls.Add(Me.lblFN)
        Me.Controls.Add(Me.btnRepair)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cmbSelComp)
        Me.Controls.Add(Me.lblSelComp)
        Me.Name = "frmResolve"
        Me.Text = "Repair Faults Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbSelComp As ComboBox
    Friend WithEvents lblSelComp As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRepair As Button
    Friend WithEvents lblTechNote As Label
    Friend WithEvents lblTN As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblUN As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblComputerNum As Label
    Friend WithEvents lblCN As Label
    Friend WithEvents lblRoomNum As Label
    Friend WithEvents lblRN As Label
    Friend WithEvents lblFaultDate As Label
    Friend WithEvents lblFD As Label
    Friend WithEvents lblFaultNum As Label
    Friend WithEvents lblFN As Label
End Class
