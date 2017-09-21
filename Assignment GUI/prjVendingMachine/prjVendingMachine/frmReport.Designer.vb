<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblDrinksSold = New System.Windows.Forms.Label()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.lblMoneyRemoved = New System.Windows.Forms.Label()
        Me.lblSalesRev = New System.Windows.Forms.Label()
        Me.lblChangeRev = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.lblNumDrinksSold = New System.Windows.Forms.Label()
        Me.lblCR = New System.Windows.Forms.Label()
        Me.lblSR = New System.Windows.Forms.Label()
        Me.lblAmountRemoved = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtCoke = New System.Windows.Forms.TextBox()
        Me.txtDietCoke = New System.Windows.Forms.TextBox()
        Me.txt7up = New System.Windows.Forms.TextBox()
        Me.txtFanta = New System.Windows.Forms.TextBox()
        Me.txtLilt = New System.Windows.Forms.TextBox()
        Me.txtPepsi = New System.Windows.Forms.TextBox()
        Me.txtPepsiMax = New System.Windows.Forms.TextBox()
        Me.txtTango = New System.Windows.Forms.TextBox()
        Me.txtSanPell = New System.Windows.Forms.TextBox()
        Me.txtSprite = New System.Windows.Forms.TextBox()
        Me.txtDrPepper = New System.Windows.Forms.TextBox()
        Me.txt7upFree = New System.Windows.Forms.TextBox()
        Me.lblTango = New System.Windows.Forms.Label()
        Me.lblSanPell = New System.Windows.Forms.Label()
        Me.lblSprite = New System.Windows.Forms.Label()
        Me.lblDrPepper = New System.Windows.Forms.Label()
        Me.lblPepsiMax = New System.Windows.Forms.Label()
        Me.lblPepsi = New System.Windows.Forms.Label()
        Me.lblLilt = New System.Windows.Forms.Label()
        Me.lblFanta = New System.Windows.Forms.Label()
        Me.lbl7upFree = New System.Windows.Forms.Label()
        Me.lbl7up = New System.Windows.Forms.Label()
        Me.lblDietCoke = New System.Windows.Forms.Label()
        Me.lblCoke = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.MediumBlue
        Me.lblHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblHeading.Location = New System.Drawing.Point(243, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(180, 31)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Latest Report"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDrinksSold
        '
        Me.lblDrinksSold.BackColor = System.Drawing.Color.Black
        Me.lblDrinksSold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDrinksSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinksSold.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDrinksSold.Location = New System.Drawing.Point(22, 61)
        Me.lblDrinksSold.Name = "lblDrinksSold"
        Me.lblDrinksSold.Size = New System.Drawing.Size(225, 18)
        Me.lblDrinksSold.TabIndex = 2
        Me.lblDrinksSold.Text = "Number of Drinks Sold:"
        Me.lblDrinksSold.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRevenue
        '
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.BackColor = System.Drawing.Color.Black
        Me.lblRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRevenue.Location = New System.Drawing.Point(329, 123)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(153, 18)
        Me.lblRevenue.TabIndex = 3
        Me.lblRevenue.Text = "Revenue Generated:"
        Me.lblRevenue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMoneyRemoved
        '
        Me.lblMoneyRemoved.AutoSize = True
        Me.lblMoneyRemoved.BackColor = System.Drawing.Color.Black
        Me.lblMoneyRemoved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMoneyRemoved.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoneyRemoved.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMoneyRemoved.Location = New System.Drawing.Point(329, 264)
        Me.lblMoneyRemoved.Name = "lblMoneyRemoved"
        Me.lblMoneyRemoved.Size = New System.Drawing.Size(232, 18)
        Me.lblMoneyRemoved.TabIndex = 4
        Me.lblMoneyRemoved.Text = "Amount Removed from Machine:"
        Me.lblMoneyRemoved.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSalesRev
        '
        Me.lblSalesRev.AutoSize = True
        Me.lblSalesRev.BackColor = System.Drawing.Color.White
        Me.lblSalesRev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalesRev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesRev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSalesRev.Location = New System.Drawing.Point(329, 166)
        Me.lblSalesRev.Name = "lblSalesRev"
        Me.lblSalesRev.Size = New System.Drawing.Size(120, 18)
        Me.lblSalesRev.TabIndex = 5
        Me.lblSalesRev.Text = "Sales Revenue:"
        Me.lblSalesRev.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblChangeRev
        '
        Me.lblChangeRev.AutoSize = True
        Me.lblChangeRev.BackColor = System.Drawing.Color.White
        Me.lblChangeRev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChangeRev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeRev.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChangeRev.Location = New System.Drawing.Point(329, 203)
        Me.lblChangeRev.Name = "lblChangeRev"
        Me.lblChangeRev.Size = New System.Drawing.Size(162, 18)
        Me.lblChangeRev.TabIndex = 6
        Me.lblChangeRev.Text = "Left Change Revenue:"
        Me.lblChangeRev.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Black
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDate.Location = New System.Drawing.Point(469, 61)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(47, 18)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Date:"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.BackColor = System.Drawing.Color.Black
        Me.lblCurrentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCurrentDate.Location = New System.Drawing.Point(522, 61)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(116, 18)
        Me.lblCurrentDate.TabIndex = 8
        Me.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNumDrinksSold
        '
        Me.lblNumDrinksSold.BackColor = System.Drawing.Color.Black
        Me.lblNumDrinksSold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumDrinksSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumDrinksSold.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNumDrinksSold.Location = New System.Drawing.Point(22, 88)
        Me.lblNumDrinksSold.Name = "lblNumDrinksSold"
        Me.lblNumDrinksSold.Size = New System.Drawing.Size(225, 322)
        Me.lblNumDrinksSold.TabIndex = 9
        Me.lblNumDrinksSold.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCR
        '
        Me.lblCR.BackColor = System.Drawing.Color.Black
        Me.lblCR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCR.Location = New System.Drawing.Point(569, 202)
        Me.lblCR.Name = "lblCR"
        Me.lblCR.Size = New System.Drawing.Size(69, 18)
        Me.lblCR.TabIndex = 10
        Me.lblCR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSR
        '
        Me.lblSR.BackColor = System.Drawing.Color.Black
        Me.lblSR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSR.Location = New System.Drawing.Point(569, 165)
        Me.lblSR.Name = "lblSR"
        Me.lblSR.Size = New System.Drawing.Size(69, 18)
        Me.lblSR.TabIndex = 11
        Me.lblSR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAmountRemoved
        '
        Me.lblAmountRemoved.BackColor = System.Drawing.Color.Black
        Me.lblAmountRemoved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmountRemoved.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountRemoved.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAmountRemoved.Location = New System.Drawing.Point(569, 264)
        Me.lblAmountRemoved.Name = "lblAmountRemoved"
        Me.lblAmountRemoved.Size = New System.Drawing.Size(69, 18)
        Me.lblAmountRemoved.TabIndex = 12
        Me.lblAmountRemoved.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Blue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(570, 379)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(74, 31)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtCoke
        '
        Me.txtCoke.Location = New System.Drawing.Point(173, 103)
        Me.txtCoke.Name = "txtCoke"
        Me.txtCoke.Size = New System.Drawing.Size(64, 20)
        Me.txtCoke.TabIndex = 49
        '
        'txtDietCoke
        '
        Me.txtDietCoke.Location = New System.Drawing.Point(173, 127)
        Me.txtDietCoke.Name = "txtDietCoke"
        Me.txtDietCoke.Size = New System.Drawing.Size(64, 20)
        Me.txtDietCoke.TabIndex = 48
        '
        'txt7up
        '
        Me.txt7up.Location = New System.Drawing.Point(173, 151)
        Me.txt7up.Name = "txt7up"
        Me.txt7up.Size = New System.Drawing.Size(64, 20)
        Me.txt7up.TabIndex = 47
        '
        'txtFanta
        '
        Me.txtFanta.Location = New System.Drawing.Point(173, 200)
        Me.txtFanta.Name = "txtFanta"
        Me.txtFanta.Size = New System.Drawing.Size(64, 20)
        Me.txtFanta.TabIndex = 46
        '
        'txtLilt
        '
        Me.txtLilt.Location = New System.Drawing.Point(173, 225)
        Me.txtLilt.Name = "txtLilt"
        Me.txtLilt.Size = New System.Drawing.Size(64, 20)
        Me.txtLilt.TabIndex = 45
        '
        'txtPepsi
        '
        Me.txtPepsi.Location = New System.Drawing.Point(173, 250)
        Me.txtPepsi.Name = "txtPepsi"
        Me.txtPepsi.Size = New System.Drawing.Size(64, 20)
        Me.txtPepsi.TabIndex = 44
        '
        'txtPepsiMax
        '
        Me.txtPepsiMax.Location = New System.Drawing.Point(173, 274)
        Me.txtPepsiMax.Name = "txtPepsiMax"
        Me.txtPepsiMax.Size = New System.Drawing.Size(64, 20)
        Me.txtPepsiMax.TabIndex = 43
        '
        'txtTango
        '
        Me.txtTango.Location = New System.Drawing.Point(173, 373)
        Me.txtTango.Name = "txtTango"
        Me.txtTango.Size = New System.Drawing.Size(64, 20)
        Me.txtTango.TabIndex = 42
        '
        'txtSanPell
        '
        Me.txtSanPell.Location = New System.Drawing.Point(173, 347)
        Me.txtSanPell.Name = "txtSanPell"
        Me.txtSanPell.Size = New System.Drawing.Size(64, 20)
        Me.txtSanPell.TabIndex = 41
        '
        'txtSprite
        '
        Me.txtSprite.Location = New System.Drawing.Point(173, 322)
        Me.txtSprite.Name = "txtSprite"
        Me.txtSprite.Size = New System.Drawing.Size(64, 20)
        Me.txtSprite.TabIndex = 40
        '
        'txtDrPepper
        '
        Me.txtDrPepper.Location = New System.Drawing.Point(173, 298)
        Me.txtDrPepper.Name = "txtDrPepper"
        Me.txtDrPepper.Size = New System.Drawing.Size(64, 20)
        Me.txtDrPepper.TabIndex = 39
        '
        'txt7upFree
        '
        Me.txt7upFree.Location = New System.Drawing.Point(173, 176)
        Me.txt7upFree.Name = "txt7upFree"
        Me.txt7upFree.Size = New System.Drawing.Size(64, 20)
        Me.txt7upFree.TabIndex = 38
        '
        'lblTango
        '
        Me.lblTango.AutoSize = True
        Me.lblTango.BackColor = System.Drawing.Color.Black
        Me.lblTango.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTango.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTango.Location = New System.Drawing.Point(31, 374)
        Me.lblTango.Name = "lblTango"
        Me.lblTango.Size = New System.Drawing.Size(48, 16)
        Me.lblTango.TabIndex = 37
        Me.lblTango.Text = "Tango"
        '
        'lblSanPell
        '
        Me.lblSanPell.AutoSize = True
        Me.lblSanPell.BackColor = System.Drawing.Color.Black
        Me.lblSanPell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSanPell.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSanPell.Location = New System.Drawing.Point(31, 348)
        Me.lblSanPell.Name = "lblSanPell"
        Me.lblSanPell.Size = New System.Drawing.Size(96, 16)
        Me.lblSanPell.TabIndex = 35
        Me.lblSanPell.Text = "San Pellegrino"
        '
        'lblSprite
        '
        Me.lblSprite.AutoSize = True
        Me.lblSprite.BackColor = System.Drawing.Color.Black
        Me.lblSprite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSprite.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSprite.Location = New System.Drawing.Point(31, 323)
        Me.lblSprite.Name = "lblSprite"
        Me.lblSprite.Size = New System.Drawing.Size(43, 16)
        Me.lblSprite.TabIndex = 34
        Me.lblSprite.Text = "Sprite"
        '
        'lblDrPepper
        '
        Me.lblDrPepper.AutoSize = True
        Me.lblDrPepper.BackColor = System.Drawing.Color.Black
        Me.lblDrPepper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrPepper.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDrPepper.Location = New System.Drawing.Point(31, 299)
        Me.lblDrPepper.Name = "lblDrPepper"
        Me.lblDrPepper.Size = New System.Drawing.Size(70, 16)
        Me.lblDrPepper.TabIndex = 33
        Me.lblDrPepper.Text = "Dr Pepper"
        '
        'lblPepsiMax
        '
        Me.lblPepsiMax.AutoSize = True
        Me.lblPepsiMax.BackColor = System.Drawing.Color.Black
        Me.lblPepsiMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPepsiMax.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPepsiMax.Location = New System.Drawing.Point(31, 275)
        Me.lblPepsiMax.Name = "lblPepsiMax"
        Me.lblPepsiMax.Size = New System.Drawing.Size(71, 16)
        Me.lblPepsiMax.TabIndex = 32
        Me.lblPepsiMax.Text = "Pepsi Max"
        '
        'lblPepsi
        '
        Me.lblPepsi.AutoSize = True
        Me.lblPepsi.BackColor = System.Drawing.Color.Black
        Me.lblPepsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPepsi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPepsi.Location = New System.Drawing.Point(31, 251)
        Me.lblPepsi.Name = "lblPepsi"
        Me.lblPepsi.Size = New System.Drawing.Size(43, 16)
        Me.lblPepsi.TabIndex = 31
        Me.lblPepsi.Text = "Pepsi"
        '
        'lblLilt
        '
        Me.lblLilt.AutoSize = True
        Me.lblLilt.BackColor = System.Drawing.Color.Black
        Me.lblLilt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLilt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLilt.Location = New System.Drawing.Point(31, 226)
        Me.lblLilt.Name = "lblLilt"
        Me.lblLilt.Size = New System.Drawing.Size(24, 16)
        Me.lblLilt.TabIndex = 30
        Me.lblLilt.Text = "Lilt"
        '
        'lblFanta
        '
        Me.lblFanta.AutoSize = True
        Me.lblFanta.BackColor = System.Drawing.Color.Black
        Me.lblFanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFanta.Location = New System.Drawing.Point(31, 201)
        Me.lblFanta.Name = "lblFanta"
        Me.lblFanta.Size = New System.Drawing.Size(42, 16)
        Me.lblFanta.TabIndex = 29
        Me.lblFanta.Text = "Fanta"
        '
        'lbl7upFree
        '
        Me.lbl7upFree.AutoSize = True
        Me.lbl7upFree.BackColor = System.Drawing.Color.Black
        Me.lbl7upFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7upFree.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl7upFree.Location = New System.Drawing.Point(31, 177)
        Me.lbl7upFree.Name = "lbl7upFree"
        Me.lbl7upFree.Size = New System.Drawing.Size(61, 16)
        Me.lbl7upFree.TabIndex = 28
        Me.lbl7upFree.Text = "7up Free"
        '
        'lbl7up
        '
        Me.lbl7up.AutoSize = True
        Me.lbl7up.BackColor = System.Drawing.Color.Black
        Me.lbl7up.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7up.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl7up.Location = New System.Drawing.Point(31, 152)
        Me.lbl7up.Name = "lbl7up"
        Me.lbl7up.Size = New System.Drawing.Size(30, 16)
        Me.lbl7up.TabIndex = 27
        Me.lbl7up.Text = "7up"
        '
        'lblDietCoke
        '
        Me.lblDietCoke.AutoSize = True
        Me.lblDietCoke.BackColor = System.Drawing.Color.Black
        Me.lblDietCoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDietCoke.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDietCoke.Location = New System.Drawing.Point(31, 128)
        Me.lblDietCoke.Name = "lblDietCoke"
        Me.lblDietCoke.Size = New System.Drawing.Size(67, 16)
        Me.lblDietCoke.TabIndex = 26
        Me.lblDietCoke.Text = "Diet Coke"
        '
        'lblCoke
        '
        Me.lblCoke.AutoSize = True
        Me.lblCoke.BackColor = System.Drawing.Color.Black
        Me.lblCoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoke.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCoke.Location = New System.Drawing.Point(31, 104)
        Me.lblCoke.Name = "lblCoke"
        Me.lblCoke.Size = New System.Drawing.Size(40, 16)
        Me.lblCoke.TabIndex = 25
        Me.lblCoke.Text = "Coke"
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prjVendingMachine.My.Resources.Resources.IceCubeBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(656, 421)
        Me.Controls.Add(Me.txtCoke)
        Me.Controls.Add(Me.txtDietCoke)
        Me.Controls.Add(Me.txt7up)
        Me.Controls.Add(Me.txtFanta)
        Me.Controls.Add(Me.txtLilt)
        Me.Controls.Add(Me.txtPepsi)
        Me.Controls.Add(Me.txtPepsiMax)
        Me.Controls.Add(Me.txtTango)
        Me.Controls.Add(Me.txtSanPell)
        Me.Controls.Add(Me.txtSprite)
        Me.Controls.Add(Me.txtDrPepper)
        Me.Controls.Add(Me.txt7upFree)
        Me.Controls.Add(Me.lblTango)
        Me.Controls.Add(Me.lblSanPell)
        Me.Controls.Add(Me.lblSprite)
        Me.Controls.Add(Me.lblDrPepper)
        Me.Controls.Add(Me.lblPepsiMax)
        Me.Controls.Add(Me.lblPepsi)
        Me.Controls.Add(Me.lblLilt)
        Me.Controls.Add(Me.lblFanta)
        Me.Controls.Add(Me.lbl7upFree)
        Me.Controls.Add(Me.lbl7up)
        Me.Controls.Add(Me.lblDietCoke)
        Me.Controls.Add(Me.lblCoke)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblAmountRemoved)
        Me.Controls.Add(Me.lblSR)
        Me.Controls.Add(Me.lblCR)
        Me.Controls.Add(Me.lblNumDrinksSold)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblChangeRev)
        Me.Controls.Add(Me.lblSalesRev)
        Me.Controls.Add(Me.lblMoneyRemoved)
        Me.Controls.Add(Me.lblRevenue)
        Me.Controls.Add(Me.lblDrinksSold)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmReport"
        Me.Text = "frmReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblDrinksSold As Label
    Friend WithEvents lblRevenue As Label
    Friend WithEvents lblMoneyRemoved As Label
    Friend WithEvents lblSalesRev As Label
    Friend WithEvents lblChangeRev As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents lblNumDrinksSold As Label
    Friend WithEvents lblCR As Label
    Friend WithEvents lblSR As Label
    Friend WithEvents lblAmountRemoved As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents txtCoke As TextBox
    Friend WithEvents txtDietCoke As TextBox
    Friend WithEvents txt7up As TextBox
    Friend WithEvents txtFanta As TextBox
    Friend WithEvents txtLilt As TextBox
    Friend WithEvents txtPepsi As TextBox
    Friend WithEvents txtPepsiMax As TextBox
    Friend WithEvents txtTango As TextBox
    Friend WithEvents txtSanPell As TextBox
    Friend WithEvents txtSprite As TextBox
    Friend WithEvents txtDrPepper As TextBox
    Friend WithEvents txt7upFree As TextBox
    Friend WithEvents lblTango As Label
    Friend WithEvents lblSanPell As Label
    Friend WithEvents lblSprite As Label
    Friend WithEvents lblDrPepper As Label
    Friend WithEvents lblPepsiMax As Label
    Friend WithEvents lblPepsi As Label
    Friend WithEvents lblLilt As Label
    Friend WithEvents lblFanta As Label
    Friend WithEvents lbl7upFree As Label
    Friend WithEvents lbl7up As Label
    Friend WithEvents lblDietCoke As Label
    Friend WithEvents lblCoke As Label
End Class
