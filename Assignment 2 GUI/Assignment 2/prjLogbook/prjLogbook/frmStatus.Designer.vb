<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatus
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
        Me.txtNewStatus = New System.Windows.Forms.TextBox()
        Me.lblNewStatus = New System.Windows.Forms.Label()
        Me.lblCurStatus = New System.Windows.Forms.Label()
        Me.cmbSelComp = New System.Windows.Forms.ComboBox()
        Me.lblSelComp = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblCurrentStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNewStatus
        '
        Me.txtNewStatus.Location = New System.Drawing.Point(140, 120)
        Me.txtNewStatus.Name = "txtNewStatus"
        Me.txtNewStatus.Size = New System.Drawing.Size(164, 20)
        Me.txtNewStatus.TabIndex = 68
        '
        'lblNewStatus
        '
        Me.lblNewStatus.AutoSize = True
        Me.lblNewStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblNewStatus.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNewStatus.Location = New System.Drawing.Point(19, 123)
        Me.lblNewStatus.Name = "lblNewStatus"
        Me.lblNewStatus.Size = New System.Drawing.Size(77, 17)
        Me.lblNewStatus.TabIndex = 67
        Me.lblNewStatus.Text = "New Status:"
        '
        'lblCurStatus
        '
        Me.lblCurStatus.AutoSize = True
        Me.lblCurStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblCurStatus.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCurStatus.Location = New System.Drawing.Point(19, 86)
        Me.lblCurStatus.Name = "lblCurStatus"
        Me.lblCurStatus.Size = New System.Drawing.Size(97, 17)
        Me.lblCurStatus.TabIndex = 65
        Me.lblCurStatus.Text = "Current Status:"
        '
        'cmbSelComp
        '
        Me.cmbSelComp.FormattingEnabled = True
        Me.cmbSelComp.Location = New System.Drawing.Point(140, 34)
        Me.cmbSelComp.Name = "cmbSelComp"
        Me.cmbSelComp.Size = New System.Drawing.Size(164, 21)
        Me.cmbSelComp.TabIndex = 64
        '
        'lblSelComp
        '
        Me.lblSelComp.AutoSize = True
        Me.lblSelComp.BackColor = System.Drawing.Color.Transparent
        Me.lblSelComp.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelComp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSelComp.Location = New System.Drawing.Point(19, 35)
        Me.lblSelComp.Name = "lblSelComp"
        Me.lblSelComp.Size = New System.Drawing.Size(106, 17)
        Me.lblSelComp.TabIndex = 63
        Me.lblSelComp.Text = "Select Computer:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(224, 179)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 23)
        Me.btnExit.TabIndex = 69
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdate.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(24, 177)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(92, 25)
        Me.btnUpdate.TabIndex = 70
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblCurrentStatus
        '
        Me.lblCurrentStatus.AutoSize = True
        Me.lblCurrentStatus.Location = New System.Drawing.Point(147, 88)
        Me.lblCurrentStatus.Name = "lblCurrentStatus"
        Me.lblCurrentStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrentStatus.TabIndex = 71
        '
        'frmStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prjLogbook.My.Resources.Resources.background4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(330, 214)
        Me.Controls.Add(Me.lblCurrentStatus)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtNewStatus)
        Me.Controls.Add(Me.lblNewStatus)
        Me.Controls.Add(Me.lblCurStatus)
        Me.Controls.Add(Me.cmbSelComp)
        Me.Controls.Add(Me.lblSelComp)
        Me.Name = "frmStatus"
        Me.Text = "Update Status Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNewStatus As TextBox
    Friend WithEvents lblNewStatus As Label
    Friend WithEvents lblCurStatus As Label
    Friend WithEvents cmbSelComp As ComboBox
    Friend WithEvents lblSelComp As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblCurrentStatus As Label
End Class
