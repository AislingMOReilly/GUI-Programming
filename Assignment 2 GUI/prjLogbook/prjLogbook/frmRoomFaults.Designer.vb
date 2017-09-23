<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomFaults
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
        Me.lblFbyRoom = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHighF = New System.Windows.Forms.Label()
        Me.grdFaults = New System.Windows.Forms.DataGridView()
        Me.lblMostFaultCount = New System.Windows.Forms.Label()
        Me.btnRoomFaults = New System.Windows.Forms.Button()
        CType(Me.grdFaults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFbyRoom
        '
        Me.lblFbyRoom.AutoSize = True
        Me.lblFbyRoom.BackColor = System.Drawing.Color.Transparent
        Me.lblFbyRoom.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFbyRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFbyRoom.Location = New System.Drawing.Point(20, 18)
        Me.lblFbyRoom.Name = "lblFbyRoom"
        Me.lblFbyRoom.Size = New System.Drawing.Size(129, 20)
        Me.lblFbyRoom.TabIndex = 67
        Me.lblFbyRoom.Text = "Faults by Room:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(376, 342)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 29)
        Me.btnExit.TabIndex = 66
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblHighF
        '
        Me.lblHighF.AutoSize = True
        Me.lblHighF.BackColor = System.Drawing.Color.Transparent
        Me.lblHighF.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighF.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHighF.Location = New System.Drawing.Point(20, 302)
        Me.lblHighF.Name = "lblHighF"
        Me.lblHighF.Size = New System.Drawing.Size(244, 17)
        Me.lblHighF.TabIndex = 64
        Me.lblHighF.Text = "Room with Highest Fault Count per PC:"
        '
        'grdFaults
        '
        Me.grdFaults.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.grdFaults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFaults.Location = New System.Drawing.Point(23, 41)
        Me.grdFaults.Name = "grdFaults"
        Me.grdFaults.Size = New System.Drawing.Size(443, 247)
        Me.grdFaults.TabIndex = 63
        '
        'lblMostFaultCount
        '
        Me.lblMostFaultCount.AutoSize = True
        Me.lblMostFaultCount.BackColor = System.Drawing.Color.Transparent
        Me.lblMostFaultCount.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostFaultCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMostFaultCount.Location = New System.Drawing.Point(286, 302)
        Me.lblMostFaultCount.Name = "lblMostFaultCount"
        Me.lblMostFaultCount.Size = New System.Drawing.Size(0, 17)
        Me.lblMostFaultCount.TabIndex = 68
        '
        'btnRoomFaults
        '
        Me.btnRoomFaults.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnRoomFaults.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoomFaults.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRoomFaults.Location = New System.Drawing.Point(24, 342)
        Me.btnRoomFaults.Name = "btnRoomFaults"
        Me.btnRoomFaults.Size = New System.Drawing.Size(147, 29)
        Me.btnRoomFaults.TabIndex = 69
        Me.btnRoomFaults.Text = "View Fault Count"
        Me.btnRoomFaults.UseVisualStyleBackColor = False
        '
        'frmRoomFaults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prjLogbook.My.Resources.Resources.background4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(494, 383)
        Me.Controls.Add(Me.btnRoomFaults)
        Me.Controls.Add(Me.lblMostFaultCount)
        Me.Controls.Add(Me.lblFbyRoom)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblHighF)
        Me.Controls.Add(Me.grdFaults)
        Me.Name = "frmRoomFaults"
        Me.Text = "Room Faults Form"
        CType(Me.grdFaults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFbyRoom As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblHighF As Label
    Friend WithEvents grdFaults As DataGridView
    Friend WithEvents lblMostFaultCount As Label
    Friend WithEvents btnRoomFaults As Button
End Class
