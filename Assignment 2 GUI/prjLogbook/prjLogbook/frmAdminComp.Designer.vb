<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminComp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminComp))
        Me.txtCompName = New System.Windows.Forms.TextBox()
        Me.lblCompName = New System.Windows.Forms.Label()
        Me.btnUpdateComp = New System.Windows.Forms.Button()
        Me.cmbSelFunc = New System.Windows.Forms.ComboBox()
        Me.lblSelFunc2 = New System.Windows.Forms.Label()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.txtCompModel = New System.Windows.Forms.TextBox()
        Me.lblCompModel = New System.Windows.Forms.Label()
        Me.txtMan = New System.Windows.Forms.TextBox()
        Me.lblMan = New System.Windows.Forms.Label()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.lblSerial = New System.Windows.Forms.Label()
        Me.cmbSelComp = New System.Windows.Forms.ComboBox()
        Me.lblSelComp = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCompName
        '
        Me.txtCompName.ForeColor = System.Drawing.Color.Black
        Me.txtCompName.Location = New System.Drawing.Point(204, 162)
        Me.txtCompName.Name = "txtCompName"
        Me.txtCompName.Size = New System.Drawing.Size(114, 20)
        Me.txtCompName.TabIndex = 121
        '
        'lblCompName
        '
        Me.lblCompName.AutoSize = True
        Me.lblCompName.BackColor = System.Drawing.Color.Transparent
        Me.lblCompName.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCompName.Location = New System.Drawing.Point(73, 165)
        Me.lblCompName.Name = "lblCompName"
        Me.lblCompName.Size = New System.Drawing.Size(108, 17)
        Me.lblCompName.TabIndex = 120
        Me.lblCompName.Text = "Computer Name:"
        '
        'btnUpdateComp
        '
        Me.btnUpdateComp.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdateComp.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateComp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdateComp.Location = New System.Drawing.Point(12, 344)
        Me.btnUpdateComp.Name = "btnUpdateComp"
        Me.btnUpdateComp.Size = New System.Drawing.Size(203, 35)
        Me.btnUpdateComp.TabIndex = 119
        Me.btnUpdateComp.Text = "Update Computer Details"
        Me.btnUpdateComp.UseVisualStyleBackColor = False
        '
        'cmbSelFunc
        '
        Me.cmbSelFunc.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbSelFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelFunc.FormattingEnabled = True
        Me.cmbSelFunc.Items.AddRange(New Object() {"Add", "Remove", "Modify"})
        Me.cmbSelFunc.Location = New System.Drawing.Point(197, 82)
        Me.cmbSelFunc.Name = "cmbSelFunc"
        Me.cmbSelFunc.Size = New System.Drawing.Size(121, 21)
        Me.cmbSelFunc.TabIndex = 117
        '
        'lblSelFunc2
        '
        Me.lblSelFunc2.AutoSize = True
        Me.lblSelFunc2.BackColor = System.Drawing.Color.Transparent
        Me.lblSelFunc2.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelFunc2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSelFunc2.Location = New System.Drawing.Point(79, 86)
        Me.lblSelFunc2.Name = "lblSelFunc2"
        Me.lblSelFunc2.Size = New System.Drawing.Size(99, 17)
        Me.lblSelFunc2.TabIndex = 116
        Me.lblSelFunc2.Text = "Select Function:"
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.BackColor = System.Drawing.Color.Black
        Me.lblTitle2.Font = New System.Drawing.Font("Calisto MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.ForeColor = System.Drawing.Color.White
        Me.lblTitle2.Location = New System.Drawing.Point(137, 39)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(145, 22)
        Me.lblTitle2.TabIndex = 115
        Me.lblTitle2.Text = "Edit Computers"
        '
        'txtCompModel
        '
        Me.txtCompModel.ForeColor = System.Drawing.Color.Black
        Me.txtCompModel.Location = New System.Drawing.Point(204, 277)
        Me.txtCompModel.Name = "txtCompModel"
        Me.txtCompModel.Size = New System.Drawing.Size(114, 20)
        Me.txtCompModel.TabIndex = 114
        '
        'lblCompModel
        '
        Me.lblCompModel.AutoSize = True
        Me.lblCompModel.BackColor = System.Drawing.Color.Transparent
        Me.lblCompModel.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompModel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCompModel.Location = New System.Drawing.Point(70, 280)
        Me.lblCompModel.Name = "lblCompModel"
        Me.lblCompModel.Size = New System.Drawing.Size(111, 17)
        Me.lblCompModel.TabIndex = 113
        Me.lblCompModel.Text = "Computer Model:"
        '
        'txtMan
        '
        Me.txtMan.ForeColor = System.Drawing.Color.Black
        Me.txtMan.Location = New System.Drawing.Point(204, 240)
        Me.txtMan.Name = "txtMan"
        Me.txtMan.Size = New System.Drawing.Size(114, 20)
        Me.txtMan.TabIndex = 112
        '
        'lblMan
        '
        Me.lblMan.AutoSize = True
        Me.lblMan.BackColor = System.Drawing.Color.Transparent
        Me.lblMan.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMan.Location = New System.Drawing.Point(90, 241)
        Me.lblMan.Name = "lblMan"
        Me.lblMan.Size = New System.Drawing.Size(91, 17)
        Me.lblMan.TabIndex = 111
        Me.lblMan.Text = "Manufacturer:"
        '
        'txtSerial
        '
        Me.txtSerial.ForeColor = System.Drawing.Color.Black
        Me.txtSerial.Location = New System.Drawing.Point(204, 201)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(114, 20)
        Me.txtSerial.TabIndex = 110
        '
        'lblSerial
        '
        Me.lblSerial.AutoSize = True
        Me.lblSerial.BackColor = System.Drawing.Color.Transparent
        Me.lblSerial.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerial.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSerial.Location = New System.Drawing.Point(87, 201)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(94, 17)
        Me.lblSerial.TabIndex = 109
        Me.lblSerial.Text = "Serial Number:"
        '
        'cmbSelComp
        '
        Me.cmbSelComp.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbSelComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelComp.FormattingEnabled = True
        Me.cmbSelComp.Location = New System.Drawing.Point(198, 119)
        Me.cmbSelComp.Name = "cmbSelComp"
        Me.cmbSelComp.Size = New System.Drawing.Size(121, 21)
        Me.cmbSelComp.TabIndex = 108
        '
        'lblSelComp
        '
        Me.lblSelComp.AutoSize = True
        Me.lblSelComp.BackColor = System.Drawing.Color.Transparent
        Me.lblSelComp.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelComp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSelComp.Location = New System.Drawing.Point(75, 123)
        Me.lblSelComp.Name = "lblSelComp"
        Me.lblSelComp.Size = New System.Drawing.Size(106, 17)
        Me.lblSelComp.TabIndex = 107
        Me.lblSelComp.Text = "Select Computer:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(320, 345)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 34)
        Me.btnExit.TabIndex = 127
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmAdminComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(422, 396)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtCompName)
        Me.Controls.Add(Me.lblCompName)
        Me.Controls.Add(Me.btnUpdateComp)
        Me.Controls.Add(Me.cmbSelFunc)
        Me.Controls.Add(Me.lblSelFunc2)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.txtCompModel)
        Me.Controls.Add(Me.lblCompModel)
        Me.Controls.Add(Me.txtMan)
        Me.Controls.Add(Me.lblMan)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.lblSerial)
        Me.Controls.Add(Me.cmbSelComp)
        Me.Controls.Add(Me.lblSelComp)
        Me.Name = "frmAdminComp"
        Me.Text = "Edit Computers Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCompName As TextBox
    Friend WithEvents lblCompName As Label
    Friend WithEvents btnUpdateComp As Button
    Friend WithEvents cmbSelFunc As ComboBox
    Friend WithEvents lblSelFunc2 As Label
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents txtCompModel As TextBox
    Friend WithEvents lblCompModel As Label
    Friend WithEvents txtMan As TextBox
    Friend WithEvents lblMan As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents lblSerial As Label
    Friend WithEvents cmbSelComp As ComboBox
    Friend WithEvents lblSelComp As Label
    Friend WithEvents btnExit As Button
End Class
