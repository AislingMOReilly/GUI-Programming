<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInactive
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
        Me.grdInactive = New System.Windows.Forms.DataGridView()
        Me.lblInFCount = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInFaults = New System.Windows.Forms.Label()
        Me.lblInactiveCount = New System.Windows.Forms.Label()
        Me.btnViewInactive = New System.Windows.Forms.Button()
        CType(Me.grdInactive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdInactive
        '
        Me.grdInactive.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.grdInactive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdInactive.Location = New System.Drawing.Point(24, 38)
        Me.grdInactive.Name = "grdInactive"
        Me.grdInactive.Size = New System.Drawing.Size(466, 230)
        Me.grdInactive.TabIndex = 1
        '
        'lblInFCount
        '
        Me.lblInFCount.AutoSize = True
        Me.lblInFCount.BackColor = System.Drawing.Color.Transparent
        Me.lblInFCount.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInFCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblInFCount.Location = New System.Drawing.Point(24, 271)
        Me.lblInFCount.Name = "lblInFCount"
        Me.lblInFCount.Size = New System.Drawing.Size(131, 17)
        Me.lblInFCount.TabIndex = 59
        Me.lblInFCount.Text = "Inactive Fault Count:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(400, 315)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 34)
        Me.btnExit.TabIndex = 61
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblInFaults
        '
        Me.lblInFaults.AutoSize = True
        Me.lblInFaults.BackColor = System.Drawing.Color.Transparent
        Me.lblInFaults.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInFaults.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblInFaults.Location = New System.Drawing.Point(21, 15)
        Me.lblInFaults.Name = "lblInFaults"
        Me.lblInFaults.Size = New System.Drawing.Size(117, 20)
        Me.lblInFaults.TabIndex = 62
        Me.lblInFaults.Text = "Inactive Faults:"
        '
        'lblInactiveCount
        '
        Me.lblInactiveCount.AutoSize = True
        Me.lblInactiveCount.BackColor = System.Drawing.Color.Transparent
        Me.lblInactiveCount.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInactiveCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblInactiveCount.Location = New System.Drawing.Point(174, 271)
        Me.lblInactiveCount.Name = "lblInactiveCount"
        Me.lblInactiveCount.Size = New System.Drawing.Size(0, 17)
        Me.lblInactiveCount.TabIndex = 63
        '
        'btnViewInactive
        '
        Me.btnViewInactive.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnViewInactive.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewInactive.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnViewInactive.Location = New System.Drawing.Point(27, 315)
        Me.btnViewInactive.Name = "btnViewInactive"
        Me.btnViewInactive.Size = New System.Drawing.Size(147, 34)
        Me.btnViewInactive.TabIndex = 64
        Me.btnViewInactive.Text = "View Inactive Faults"
        Me.btnViewInactive.UseVisualStyleBackColor = False
        '
        'frmInactive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prjLogbook.My.Resources.Resources.background4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(518, 362)
        Me.Controls.Add(Me.btnViewInactive)
        Me.Controls.Add(Me.lblInactiveCount)
        Me.Controls.Add(Me.lblInFaults)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblInFCount)
        Me.Controls.Add(Me.grdInactive)
        Me.Name = "frmInactive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inactive Faults Form"
        CType(Me.grdInactive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdInactive As DataGridView
    Friend WithEvents lblInFCount As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblInFaults As Label
    Friend WithEvents lblInactiveCount As Label
    Friend WithEvents btnViewInactive As Button
End Class
