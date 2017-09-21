<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTechnician
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
        Me.grdTech = New System.Windows.Forms.DataGridView()
        Me.btnViewIn = New System.Windows.Forms.Button()
        Me.btnViewCount = New System.Windows.Forms.Button()
        Me.btnUpStat = New System.Windows.Forms.Button()
        Me.btnRep = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCompModel = New System.Windows.Forms.Label()
        Me.lblMan = New System.Windows.Forms.Label()
        Me.lblSerialNo = New System.Windows.Forms.Label()
        Me.cmbSelComp = New System.Windows.Forms.ComboBox()
        Me.lblByComp = New System.Windows.Forms.Label()
        Me.cmbSelRoom = New System.Windows.Forms.ComboBox()
        Me.lblByRoom = New System.Windows.Forms.Label()
        Me.cmbView = New System.Windows.Forms.ComboBox()
        Me.lblView = New System.Windows.Forms.Label()
        Me.lblSerialNum = New System.Windows.Forms.Label()
        Me.lblManu = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        CType(Me.grdTech, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdTech
        '
        Me.grdTech.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.grdTech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTech.Location = New System.Drawing.Point(12, 24)
        Me.grdTech.Name = "grdTech"
        Me.grdTech.Size = New System.Drawing.Size(424, 280)
        Me.grdTech.TabIndex = 0
        '
        'btnViewIn
        '
        Me.btnViewIn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnViewIn.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewIn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnViewIn.Location = New System.Drawing.Point(12, 329)
        Me.btnViewIn.Name = "btnViewIn"
        Me.btnViewIn.Size = New System.Drawing.Size(95, 42)
        Me.btnViewIn.TabIndex = 31
        Me.btnViewIn.Text = "View Inactive Faults"
        Me.btnViewIn.UseVisualStyleBackColor = False
        '
        'btnViewCount
        '
        Me.btnViewCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnViewCount.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnViewCount.Location = New System.Drawing.Point(113, 329)
        Me.btnViewCount.Name = "btnViewCount"
        Me.btnViewCount.Size = New System.Drawing.Size(91, 42)
        Me.btnViewCount.TabIndex = 32
        Me.btnViewCount.Text = "View Fault Count"
        Me.btnViewCount.UseVisualStyleBackColor = False
        '
        'btnUpStat
        '
        Me.btnUpStat.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpStat.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpStat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpStat.Location = New System.Drawing.Point(253, 329)
        Me.btnUpStat.Name = "btnUpStat"
        Me.btnUpStat.Size = New System.Drawing.Size(89, 42)
        Me.btnUpStat.TabIndex = 33
        Me.btnUpStat.Text = "Update Status"
        Me.btnUpStat.UseVisualStyleBackColor = False
        '
        'btnRep
        '
        Me.btnRep.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRep.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRep.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRep.Location = New System.Drawing.Point(348, 329)
        Me.btnRep.Name = "btnRep"
        Me.btnRep.Size = New System.Drawing.Size(88, 42)
        Me.btnRep.TabIndex = 34
        Me.btnRep.Text = "Mark as Repaired"
        Me.btnRep.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(603, 341)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 35
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblCompModel
        '
        Me.lblCompModel.AutoSize = True
        Me.lblCompModel.BackColor = System.Drawing.Color.Black
        Me.lblCompModel.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompModel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCompModel.Location = New System.Drawing.Point(463, 266)
        Me.lblCompModel.Name = "lblCompModel"
        Me.lblCompModel.Size = New System.Drawing.Size(111, 17)
        Me.lblCompModel.TabIndex = 61
        Me.lblCompModel.Text = "Computer Model:"
        '
        'lblMan
        '
        Me.lblMan.AutoSize = True
        Me.lblMan.BackColor = System.Drawing.Color.Black
        Me.lblMan.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMan.Location = New System.Drawing.Point(462, 230)
        Me.lblMan.Name = "lblMan"
        Me.lblMan.Size = New System.Drawing.Size(91, 17)
        Me.lblMan.TabIndex = 59
        Me.lblMan.Text = "Manufacturer:"
        '
        'lblSerialNo
        '
        Me.lblSerialNo.AutoSize = True
        Me.lblSerialNo.BackColor = System.Drawing.Color.Black
        Me.lblSerialNo.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSerialNo.Location = New System.Drawing.Point(462, 191)
        Me.lblSerialNo.Name = "lblSerialNo"
        Me.lblSerialNo.Size = New System.Drawing.Size(94, 17)
        Me.lblSerialNo.TabIndex = 57
        Me.lblSerialNo.Text = "Serial Number:"
        '
        'cmbSelComp
        '
        Me.cmbSelComp.FormattingEnabled = True
        Me.cmbSelComp.Location = New System.Drawing.Point(588, 107)
        Me.cmbSelComp.Name = "cmbSelComp"
        Me.cmbSelComp.Size = New System.Drawing.Size(121, 21)
        Me.cmbSelComp.TabIndex = 56
        '
        'lblByComp
        '
        Me.lblByComp.AutoSize = True
        Me.lblByComp.BackColor = System.Drawing.Color.Black
        Me.lblByComp.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblByComp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblByComp.Location = New System.Drawing.Point(462, 108)
        Me.lblByComp.Name = "lblByComp"
        Me.lblByComp.Size = New System.Drawing.Size(91, 17)
        Me.lblByComp.TabIndex = 55
        Me.lblByComp.Text = "By Computer:"
        '
        'cmbSelRoom
        '
        Me.cmbSelRoom.FormattingEnabled = True
        Me.cmbSelRoom.Location = New System.Drawing.Point(588, 73)
        Me.cmbSelRoom.Name = "cmbSelRoom"
        Me.cmbSelRoom.Size = New System.Drawing.Size(121, 21)
        Me.cmbSelRoom.TabIndex = 54
        '
        'lblByRoom
        '
        Me.lblByRoom.AutoSize = True
        Me.lblByRoom.BackColor = System.Drawing.Color.Black
        Me.lblByRoom.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblByRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblByRoom.Location = New System.Drawing.Point(462, 77)
        Me.lblByRoom.Name = "lblByRoom"
        Me.lblByRoom.Size = New System.Drawing.Size(67, 17)
        Me.lblByRoom.TabIndex = 53
        Me.lblByRoom.Text = "By Room:"
        '
        'cmbView
        '
        Me.cmbView.FormattingEnabled = True
        Me.cmbView.Items.AddRange(New Object() {"All", "Unresolved", "Resolved", "By Room", "By Computer"})
        Me.cmbView.Location = New System.Drawing.Point(588, 37)
        Me.cmbView.Name = "cmbView"
        Me.cmbView.Size = New System.Drawing.Size(121, 21)
        Me.cmbView.TabIndex = 64
        '
        'lblView
        '
        Me.lblView.AutoSize = True
        Me.lblView.BackColor = System.Drawing.Color.Black
        Me.lblView.Font = New System.Drawing.Font("Calisto MT", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblView.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblView.Location = New System.Drawing.Point(462, 39)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(55, 23)
        Me.lblView.TabIndex = 63
        Me.lblView.Text = "View:"
        '
        'lblSerialNum
        '
        Me.lblSerialNum.AutoSize = True
        Me.lblSerialNum.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialNum.Location = New System.Drawing.Point(588, 191)
        Me.lblSerialNum.Name = "lblSerialNum"
        Me.lblSerialNum.Size = New System.Drawing.Size(0, 17)
        Me.lblSerialNum.TabIndex = 65
        '
        'lblManu
        '
        Me.lblManu.AutoSize = True
        Me.lblManu.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManu.Location = New System.Drawing.Point(588, 230)
        Me.lblManu.Name = "lblManu"
        Me.lblManu.Size = New System.Drawing.Size(0, 17)
        Me.lblManu.TabIndex = 66
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(588, 266)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(0, 17)
        Me.lblModel.TabIndex = 67
        '
        'frmTechnician
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prjLogbook.My.Resources.Resources.background5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(727, 387)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblManu)
        Me.Controls.Add(Me.lblSerialNum)
        Me.Controls.Add(Me.cmbView)
        Me.Controls.Add(Me.lblView)
        Me.Controls.Add(Me.lblCompModel)
        Me.Controls.Add(Me.lblMan)
        Me.Controls.Add(Me.lblSerialNo)
        Me.Controls.Add(Me.cmbSelComp)
        Me.Controls.Add(Me.lblByComp)
        Me.Controls.Add(Me.cmbSelRoom)
        Me.Controls.Add(Me.lblByRoom)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRep)
        Me.Controls.Add(Me.btnUpStat)
        Me.Controls.Add(Me.btnViewCount)
        Me.Controls.Add(Me.btnViewIn)
        Me.Controls.Add(Me.grdTech)
        Me.Name = "frmTechnician"
        Me.Text = "Technician Form"
        CType(Me.grdTech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdTech As DataGridView
    Friend WithEvents btnViewIn As Button
    Friend WithEvents btnViewCount As Button
    Friend WithEvents btnUpStat As Button
    Friend WithEvents btnRep As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCompModel As Label
    Friend WithEvents lblMan As Label
    Friend WithEvents lblSerialNo As Label
    Friend WithEvents cmbSelComp As ComboBox
    Friend WithEvents lblByComp As Label
    Friend WithEvents cmbSelRoom As ComboBox
    Friend WithEvents lblByRoom As Label
    Friend WithEvents cmbView As ComboBox
    Friend WithEvents lblView As Label
    Friend WithEvents lblSerialNum As Label
    Friend WithEvents lblManu As Label
    Friend WithEvents lblModel As Label
End Class
