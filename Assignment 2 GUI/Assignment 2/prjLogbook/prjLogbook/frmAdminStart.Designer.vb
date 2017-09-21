<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminStart
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
        Me.btnViewEntries = New System.Windows.Forms.Button()
        Me.btnEditUser = New System.Windows.Forms.Button()
        Me.btnEditComp = New System.Windows.Forms.Button()
        Me.btnEditRoom = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnViewEntries
        '
        Me.btnViewEntries.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnViewEntries.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewEntries.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnViewEntries.Location = New System.Drawing.Point(12, 206)
        Me.btnViewEntries.Name = "btnViewEntries"
        Me.btnViewEntries.Size = New System.Drawing.Size(156, 36)
        Me.btnViewEntries.TabIndex = 126
        Me.btnViewEntries.Text = "View LogBook Entries"
        Me.btnViewEntries.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnViewEntries.UseVisualStyleBackColor = False
        '
        'btnEditUser
        '
        Me.btnEditUser.BackColor = System.Drawing.Color.Black
        Me.btnEditUser.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditUser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditUser.Location = New System.Drawing.Point(99, 134)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(114, 35)
        Me.btnEditUser.TabIndex = 125
        Me.btnEditUser.Text = "Edit User"
        Me.btnEditUser.UseVisualStyleBackColor = False
        '
        'btnEditComp
        '
        Me.btnEditComp.BackColor = System.Drawing.Color.Black
        Me.btnEditComp.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditComp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditComp.Location = New System.Drawing.Point(99, 81)
        Me.btnEditComp.Name = "btnEditComp"
        Me.btnEditComp.Size = New System.Drawing.Size(114, 35)
        Me.btnEditComp.TabIndex = 127
        Me.btnEditComp.Text = "Edit Computer"
        Me.btnEditComp.UseVisualStyleBackColor = False
        '
        'btnEditRoom
        '
        Me.btnEditRoom.BackColor = System.Drawing.Color.Black
        Me.btnEditRoom.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditRoom.Location = New System.Drawing.Point(99, 29)
        Me.btnEditRoom.Name = "btnEditRoom"
        Me.btnEditRoom.Size = New System.Drawing.Size(114, 36)
        Me.btnEditRoom.TabIndex = 128
        Me.btnEditRoom.Text = "Edit Room"
        Me.btnEditRoom.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(212, 206)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 36)
        Me.btnExit.TabIndex = 129
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmAdminStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prjLogbook.My.Resources.Resources.background6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(322, 254)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEditRoom)
        Me.Controls.Add(Me.btnEditComp)
        Me.Controls.Add(Me.btnViewEntries)
        Me.Controls.Add(Me.btnEditUser)
        Me.Name = "frmAdminStart"
        Me.Text = "Administrator Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnViewEntries As Button
    Friend WithEvents btnEditUser As Button
    Friend WithEvents btnEditComp As Button
    Friend WithEvents btnEditRoom As Button
    Friend WithEvents btnExit As Button
End Class
