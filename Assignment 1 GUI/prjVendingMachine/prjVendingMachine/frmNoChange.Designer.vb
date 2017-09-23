<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoChange
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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblCancel = New System.Windows.Forms.Label()
        Me.lblContinue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Black
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMessage.Location = New System.Drawing.Point(36, 23)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(272, 58)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Change is not available at the moment. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please select from the following options" &
    ": "
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnContinue
        '
        Me.btnContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(36, 170)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(131, 23)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(216, 170)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblCancel
        '
        Me.lblCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCancel.Location = New System.Drawing.Point(216, 115)
        Me.lblCancel.Name = "lblCancel"
        Me.lblCancel.Size = New System.Drawing.Size(92, 43)
        Me.lblCancel.TabIndex = 3
        Me.lblCancel.Text = "Cancel " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Order"
        Me.lblCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblContinue
        '
        Me.lblContinue.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblContinue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContinue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblContinue.Location = New System.Drawing.Point(36, 115)
        Me.lblContinue.Name = "lblContinue"
        Me.lblContinue.Size = New System.Drawing.Size(131, 43)
        Me.lblContinue.TabIndex = 4
        Me.lblContinue.Text = "Select Drink and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Forfeit Change"
        Me.lblContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmNoChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prjVendingMachine.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(343, 205)
        Me.Controls.Add(Me.lblContinue)
        Me.Controls.Add(Me.lblCancel)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "frmNoChange"
        Me.Text = "Change Unavailable"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblCancel As Label
    Friend WithEvents lblContinue As Label
End Class
