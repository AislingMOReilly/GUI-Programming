<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewEntries
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
        Me.lblView = New System.Windows.Forms.Label()
        Me.cmbView = New System.Windows.Forms.ComboBox()
        Me.grdView = New System.Windows.Forms.DataGridView()
        Me.btnLogFault = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.grdView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblView
        '
        Me.lblView.AutoSize = True
        Me.lblView.BackColor = System.Drawing.Color.Transparent
        Me.lblView.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblView.Location = New System.Drawing.Point(23, 26)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(47, 18)
        Me.lblView.TabIndex = 0
        Me.lblView.Text = "View:"
        '
        'cmbView
        '
        Me.cmbView.FormattingEnabled = True
        Me.cmbView.Items.AddRange(New Object() {"All", "Unresolved", "Resolved"})
        Me.cmbView.Location = New System.Drawing.Point(76, 26)
        Me.cmbView.Name = "cmbView"
        Me.cmbView.Size = New System.Drawing.Size(121, 21)
        Me.cmbView.TabIndex = 1
        '
        'grdView
        '
        Me.grdView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.grdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdView.Location = New System.Drawing.Point(26, 56)
        Me.grdView.Name = "grdView"
        Me.grdView.Size = New System.Drawing.Size(433, 238)
        Me.grdView.TabIndex = 2
        '
        'btnLogFault
        '
        Me.btnLogFault.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnLogFault.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogFault.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogFault.Location = New System.Drawing.Point(26, 309)
        Me.btnLogFault.Name = "btnLogFault"
        Me.btnLogFault.Size = New System.Drawing.Size(93, 31)
        Me.btnLogFault.TabIndex = 7
        Me.btnLogFault.Text = "Log Fault"
        Me.btnLogFault.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(358, 309)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 31)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmViewEntries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prjLogbook.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 353)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogFault)
        Me.Controls.Add(Me.grdView)
        Me.Controls.Add(Me.cmbView)
        Me.Controls.Add(Me.lblView)
        Me.Name = "frmViewEntries"
        Me.Text = "View Logbook Entries Form"
        CType(Me.grdView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblView As Label
    Friend WithEvents cmbView As ComboBox
    Friend WithEvents grdView As DataGridView
    Friend WithEvents btnLogFault As Button
    Friend WithEvents btnExit As Button
End Class
