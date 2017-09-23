<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnItalian = New System.Windows.Forms.Button()
        Me.btnEnglish = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHelp
        '
        Me.lblHelp.BackColor = System.Drawing.Color.Black
        Me.lblHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHelp.Location = New System.Drawing.Point(80, 31)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(233, 60)
        Me.lblHelp.TabIndex = 1
        Me.lblHelp.Text = "For Help please select " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from the following languages"
        Me.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(12, 313)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnItalian
        '
        Me.btnItalian.BackColor = System.Drawing.Color.Black
        Me.btnItalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItalian.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnItalian.Location = New System.Drawing.Point(238, 111)
        Me.btnItalian.Name = "btnItalian"
        Me.btnItalian.Size = New System.Drawing.Size(75, 31)
        Me.btnItalian.TabIndex = 18
        Me.btnItalian.Text = "Italiano"
        Me.btnItalian.UseVisualStyleBackColor = False
        '
        'btnEnglish
        '
        Me.btnEnglish.BackColor = System.Drawing.Color.Black
        Me.btnEnglish.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnglish.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEnglish.Location = New System.Drawing.Point(80, 111)
        Me.btnEnglish.Name = "btnEnglish"
        Me.btnEnglish.Size = New System.Drawing.Size(75, 31)
        Me.btnEnglish.TabIndex = 19
        Me.btnEnglish.Text = "English"
        Me.btnEnglish.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.BackColor = System.Drawing.Color.Black
        Me.lblInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblInstructions.Location = New System.Drawing.Point(80, 162)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(233, 125)
        Me.lblInstructions.TabIndex = 20
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prjVendingMachine.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(387, 348)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnEnglish)
        Me.Controls.Add(Me.btnItalian)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblHelp)
        Me.Name = "frmHelp"
        Me.Text = "frmHelp"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblHelp As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnItalian As Button
    Friend WithEvents btnEnglish As Button
    Friend WithEvents lblInstructions As Label
End Class
