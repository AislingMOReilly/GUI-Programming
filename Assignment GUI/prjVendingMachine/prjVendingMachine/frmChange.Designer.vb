<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChange
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
        Me.lblChange = New System.Windows.Forms.Label()
        Me.pbx2euro = New System.Windows.Forms.PictureBox()
        Me.pbx1euro = New System.Windows.Forms.PictureBox()
        Me.pbx50cent = New System.Windows.Forms.PictureBox()
        Me.pbx20cent = New System.Windows.Forms.PictureBox()
        Me.pbx10cent = New System.Windows.Forms.PictureBox()
        Me.pbx5cent = New System.Windows.Forms.PictureBox()
        Me.lbl2euro = New System.Windows.Forms.Label()
        Me.lbl1euro = New System.Windows.Forms.Label()
        Me.lbl50cent = New System.Windows.Forms.Label()
        Me.lbl20cent = New System.Windows.Forms.Label()
        Me.lbl10cent = New System.Windows.Forms.Label()
        Me.lbl5cent = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalChange = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.pbx2euro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx1euro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx50cent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx20cent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx10cent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx5cent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.Color.Black
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblChange.Location = New System.Drawing.Point(113, 18)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(233, 60)
        Me.lblChange.TabIndex = 0
        Me.lblChange.Text = "Thank you for your custom. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please take your change:"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbx2euro
        '
        Me.pbx2euro.BackColor = System.Drawing.Color.Black
        Me.pbx2euro.BackgroundImage = Global.prjVendingMachine.My.Resources.Resources._2euro
        Me.pbx2euro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbx2euro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx2euro.Location = New System.Drawing.Point(12, 132)
        Me.pbx2euro.Name = "pbx2euro"
        Me.pbx2euro.Size = New System.Drawing.Size(69, 65)
        Me.pbx2euro.TabIndex = 1
        Me.pbx2euro.TabStop = False
        '
        'pbx1euro
        '
        Me.pbx1euro.BackColor = System.Drawing.Color.Black
        Me.pbx1euro.BackgroundImage = Global.prjVendingMachine.My.Resources.Resources._1euro
        Me.pbx1euro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbx1euro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx1euro.Location = New System.Drawing.Point(87, 132)
        Me.pbx1euro.Name = "pbx1euro"
        Me.pbx1euro.Size = New System.Drawing.Size(69, 65)
        Me.pbx1euro.TabIndex = 2
        Me.pbx1euro.TabStop = False
        '
        'pbx50cent
        '
        Me.pbx50cent.BackColor = System.Drawing.Color.Black
        Me.pbx50cent.BackgroundImage = Global.prjVendingMachine.My.Resources.Resources._50cent
        Me.pbx50cent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbx50cent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx50cent.Location = New System.Drawing.Point(162, 132)
        Me.pbx50cent.Name = "pbx50cent"
        Me.pbx50cent.Size = New System.Drawing.Size(69, 65)
        Me.pbx50cent.TabIndex = 3
        Me.pbx50cent.TabStop = False
        '
        'pbx20cent
        '
        Me.pbx20cent.BackColor = System.Drawing.Color.Black
        Me.pbx20cent.BackgroundImage = Global.prjVendingMachine.My.Resources.Resources._20cent
        Me.pbx20cent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbx20cent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx20cent.Location = New System.Drawing.Point(237, 132)
        Me.pbx20cent.Name = "pbx20cent"
        Me.pbx20cent.Size = New System.Drawing.Size(69, 65)
        Me.pbx20cent.TabIndex = 4
        Me.pbx20cent.TabStop = False
        '
        'pbx10cent
        '
        Me.pbx10cent.BackColor = System.Drawing.Color.Black
        Me.pbx10cent.BackgroundImage = Global.prjVendingMachine.My.Resources.Resources._10cent
        Me.pbx10cent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbx10cent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx10cent.Location = New System.Drawing.Point(312, 132)
        Me.pbx10cent.Name = "pbx10cent"
        Me.pbx10cent.Size = New System.Drawing.Size(69, 65)
        Me.pbx10cent.TabIndex = 5
        Me.pbx10cent.TabStop = False
        '
        'pbx5cent
        '
        Me.pbx5cent.BackColor = System.Drawing.Color.Black
        Me.pbx5cent.BackgroundImage = Global.prjVendingMachine.My.Resources.Resources._5cent
        Me.pbx5cent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbx5cent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbx5cent.Location = New System.Drawing.Point(387, 132)
        Me.pbx5cent.Name = "pbx5cent"
        Me.pbx5cent.Size = New System.Drawing.Size(69, 65)
        Me.pbx5cent.TabIndex = 6
        Me.pbx5cent.TabStop = False
        '
        'lbl2euro
        '
        Me.lbl2euro.BackColor = System.Drawing.Color.White
        Me.lbl2euro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2euro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2euro.Location = New System.Drawing.Point(12, 204)
        Me.lbl2euro.Name = "lbl2euro"
        Me.lbl2euro.Size = New System.Drawing.Size(69, 23)
        Me.lbl2euro.TabIndex = 7
        Me.lbl2euro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl1euro
        '
        Me.lbl1euro.BackColor = System.Drawing.Color.White
        Me.lbl1euro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1euro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1euro.Location = New System.Drawing.Point(87, 204)
        Me.lbl1euro.Name = "lbl1euro"
        Me.lbl1euro.Size = New System.Drawing.Size(69, 23)
        Me.lbl1euro.TabIndex = 8
        Me.lbl1euro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl50cent
        '
        Me.lbl50cent.BackColor = System.Drawing.Color.White
        Me.lbl50cent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl50cent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl50cent.Location = New System.Drawing.Point(162, 204)
        Me.lbl50cent.Name = "lbl50cent"
        Me.lbl50cent.Size = New System.Drawing.Size(69, 23)
        Me.lbl50cent.TabIndex = 9
        Me.lbl50cent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl20cent
        '
        Me.lbl20cent.BackColor = System.Drawing.Color.White
        Me.lbl20cent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl20cent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl20cent.Location = New System.Drawing.Point(237, 204)
        Me.lbl20cent.Name = "lbl20cent"
        Me.lbl20cent.Size = New System.Drawing.Size(69, 23)
        Me.lbl20cent.TabIndex = 10
        Me.lbl20cent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl10cent
        '
        Me.lbl10cent.BackColor = System.Drawing.Color.White
        Me.lbl10cent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl10cent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10cent.Location = New System.Drawing.Point(312, 204)
        Me.lbl10cent.Name = "lbl10cent"
        Me.lbl10cent.Size = New System.Drawing.Size(69, 23)
        Me.lbl10cent.TabIndex = 11
        Me.lbl10cent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl5cent
        '
        Me.lbl5cent.BackColor = System.Drawing.Color.White
        Me.lbl5cent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl5cent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5cent.Location = New System.Drawing.Point(387, 204)
        Me.lbl5cent.Name = "lbl5cent"
        Me.lbl5cent.Size = New System.Drawing.Size(69, 23)
        Me.lbl5cent.TabIndex = 12
        Me.lbl5cent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuantity
        '
        Me.lblQuantity.BackColor = System.Drawing.Color.Black
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblQuantity.Location = New System.Drawing.Point(189, 106)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(87, 23)
        Me.lblQuantity.TabIndex = 13
        Me.lblQuantity.Text = "Quantity:"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Black
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotal.Location = New System.Drawing.Point(262, 243)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(106, 23)
        Me.lblTotal.TabIndex = 14
        Me.lblTotal.Text = "Total Change:"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalChange
        '
        Me.lblTotalChange.BackColor = System.Drawing.Color.White
        Me.lblTotalChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalChange.Location = New System.Drawing.Point(374, 243)
        Me.lblTotalChange.Name = "lblTotalChange"
        Me.lblTotalChange.Size = New System.Drawing.Size(82, 23)
        Me.lblTotalChange.TabIndex = 15
        Me.lblTotalChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(12, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.BackgroundImage = Global.prjVendingMachine.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(470, 275)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotalChange)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lbl5cent)
        Me.Controls.Add(Me.lbl10cent)
        Me.Controls.Add(Me.lbl20cent)
        Me.Controls.Add(Me.lbl50cent)
        Me.Controls.Add(Me.lbl1euro)
        Me.Controls.Add(Me.lbl2euro)
        Me.Controls.Add(Me.pbx5cent)
        Me.Controls.Add(Me.pbx10cent)
        Me.Controls.Add(Me.pbx20cent)
        Me.Controls.Add(Me.pbx50cent)
        Me.Controls.Add(Me.pbx1euro)
        Me.Controls.Add(Me.pbx2euro)
        Me.Controls.Add(Me.lblChange)
        Me.Name = "frmChange"
        Me.Text = "frmChange"
        CType(Me.pbx2euro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx1euro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx50cent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx20cent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx10cent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx5cent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblChange As Label
    Friend WithEvents pbx2euro As PictureBox
    Friend WithEvents pbx1euro As PictureBox
    Friend WithEvents pbx50cent As PictureBox
    Friend WithEvents pbx20cent As PictureBox
    Friend WithEvents pbx10cent As PictureBox
    Friend WithEvents pbx5cent As PictureBox
    Friend WithEvents lbl2euro As Label
    Friend WithEvents lbl1euro As Label
    Friend WithEvents lbl50cent As Label
    Friend WithEvents lbl20cent As Label
    Friend WithEvents lbl10cent As Label
    Friend WithEvents lbl5cent As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalChange As Label
    Friend WithEvents btnExit As Button
End Class
