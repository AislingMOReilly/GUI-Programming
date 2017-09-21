<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManager
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
        Me.lblAddDrinks = New System.Windows.Forms.Label()
        Me.lblDrink = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.cmbDrink = New System.Windows.Forms.ComboBox()
        Me.btnPrintReport = New System.Windows.Forms.Button()
        Me.txtDrinkQuantity = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAddRemCoin = New System.Windows.Forms.Label()
        Me.lblCoin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCoinQuantity = New System.Windows.Forms.TextBox()
        Me.cmbCoin = New System.Windows.Forms.ComboBox()
        Me.lblFunction = New System.Windows.Forms.Label()
        Me.cmbFunction = New System.Windows.Forms.ComboBox()
        Me.grpDrink = New System.Windows.Forms.GroupBox()
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
        Me.lblDrinkStock = New System.Windows.Forms.Label()
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
        Me.grpCoin = New System.Windows.Forms.GroupBox()
        Me.txt2euro = New System.Windows.Forms.TextBox()
        Me.txt1euro = New System.Windows.Forms.TextBox()
        Me.txt50cent = New System.Windows.Forms.TextBox()
        Me.txt10cent = New System.Windows.Forms.TextBox()
        Me.txt5cent = New System.Windows.Forms.TextBox()
        Me.txt20cent = New System.Windows.Forms.TextBox()
        Me.lblCoinStock = New System.Windows.Forms.Label()
        Me.lbl5cent = New System.Windows.Forms.Label()
        Me.lbl10cent = New System.Windows.Forms.Label()
        Me.lbl20cent = New System.Windows.Forms.Label()
        Me.lbl50cent = New System.Windows.Forms.Label()
        Me.lbl1euro = New System.Windows.Forms.Label()
        Me.lbl2euro = New System.Windows.Forms.Label()
        Me.lblChangeCost = New System.Windows.Forms.Label()
        Me.lblDrink2 = New System.Windows.Forms.Label()
        Me.cmbDrink2 = New System.Windows.Forms.ComboBox()
        Me.lblNewCost = New System.Windows.Forms.Label()
        Me.txtNewCost = New System.Windows.Forms.TextBox()
        Me.btnUpdatePrice = New System.Windows.Forms.Button()
        Me.txtCurrentCost = New System.Windows.Forms.TextBox()
        Me.lblCurrentCost = New System.Windows.Forms.Label()
        Me.btnUpdateDrink = New System.Windows.Forms.Button()
        Me.btnUpdateCoin = New System.Windows.Forms.Button()
        Me.grpDrink.SuspendLayout()
        Me.grpCoin.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddDrinks
        '
        Me.lblAddDrinks.AutoSize = True
        Me.lblAddDrinks.BackColor = System.Drawing.Color.Transparent
        Me.lblAddDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddDrinks.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAddDrinks.Location = New System.Drawing.Point(85, 9)
        Me.lblAddDrinks.Name = "lblAddDrinks"
        Me.lblAddDrinks.Size = New System.Drawing.Size(88, 16)
        Me.lblAddDrinks.TabIndex = 0
        Me.lblAddDrinks.Text = "Add Drinks:"
        '
        'lblDrink
        '
        Me.lblDrink.AutoSize = True
        Me.lblDrink.BackColor = System.Drawing.Color.Blue
        Me.lblDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrink.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDrink.Location = New System.Drawing.Point(30, 38)
        Me.lblDrink.Name = "lblDrink"
        Me.lblDrink.Size = New System.Drawing.Size(85, 18)
        Me.lblDrink.TabIndex = 2
        Me.lblDrink.Text = "Select Drink:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Blue
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblQuantity.Location = New System.Drawing.Point(30, 67)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(61, 18)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "Quantity:"
        '
        'cmbDrink
        '
        Me.cmbDrink.FormattingEnabled = True
        Me.cmbDrink.Items.AddRange(New Object() {"Coke", "Diet Coke", "7up", "7up Free", "Fanta", "Lilt", "Pepsi", "Pepsi Max", "Dr Pepper", "Sprite", "San Pellegrino", "Tango"})
        Me.cmbDrink.Location = New System.Drawing.Point(131, 37)
        Me.cmbDrink.Name = "cmbDrink"
        Me.cmbDrink.Size = New System.Drawing.Size(121, 21)
        Me.cmbDrink.TabIndex = 4
        '
        'btnPrintReport
        '
        Me.btnPrintReport.BackColor = System.Drawing.Color.Blue
        Me.btnPrintReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintReport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrintReport.Location = New System.Drawing.Point(727, 383)
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(128, 38)
        Me.btnPrintReport.TabIndex = 5
        Me.btnPrintReport.Text = "Print Report"
        Me.btnPrintReport.UseVisualStyleBackColor = False
        '
        'txtDrinkQuantity
        '
        Me.txtDrinkQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrinkQuantity.Location = New System.Drawing.Point(117, 64)
        Me.txtDrinkQuantity.Name = "txtDrinkQuantity"
        Me.txtDrinkQuantity.Size = New System.Drawing.Size(77, 22)
        Me.txtDrinkQuantity.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Blue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(752, 437)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 35)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblAddRemCoin
        '
        Me.lblAddRemCoin.AutoSize = True
        Me.lblAddRemCoin.BackColor = System.Drawing.Color.Transparent
        Me.lblAddRemCoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddRemCoin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAddRemCoin.Location = New System.Drawing.Point(357, 9)
        Me.lblAddRemCoin.Name = "lblAddRemCoin"
        Me.lblAddRemCoin.Size = New System.Drawing.Size(146, 16)
        Me.lblAddRemCoin.TabIndex = 8
        Me.lblAddRemCoin.Text = "Add/Remove Coins:"
        '
        'lblCoin
        '
        Me.lblCoin.AutoSize = True
        Me.lblCoin.BackColor = System.Drawing.Color.Blue
        Me.lblCoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCoin.Location = New System.Drawing.Point(317, 77)
        Me.lblCoin.Name = "lblCoin"
        Me.lblCoin.Size = New System.Drawing.Size(81, 18)
        Me.lblCoin.TabIndex = 9
        Me.lblCoin.Text = "Select Coin:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(317, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Quantity:"
        '
        'txtCoinQuantity
        '
        Me.txtCoinQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoinQuantity.Location = New System.Drawing.Point(468, 114)
        Me.txtCoinQuantity.Name = "txtCoinQuantity"
        Me.txtCoinQuantity.Size = New System.Drawing.Size(92, 22)
        Me.txtCoinQuantity.TabIndex = 11
        '
        'cmbCoin
        '
        Me.cmbCoin.FormattingEnabled = True
        Me.cmbCoin.Items.AddRange(New Object() {"2 euro", "1 euro", "50 cent", "20 cent", "10 cent", "5 cent"})
        Me.cmbCoin.Location = New System.Drawing.Point(439, 74)
        Me.cmbCoin.Name = "cmbCoin"
        Me.cmbCoin.Size = New System.Drawing.Size(121, 21)
        Me.cmbCoin.TabIndex = 12
        '
        'lblFunction
        '
        Me.lblFunction.AutoSize = True
        Me.lblFunction.BackColor = System.Drawing.Color.Blue
        Me.lblFunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunction.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFunction.Location = New System.Drawing.Point(317, 40)
        Me.lblFunction.Name = "lblFunction"
        Me.lblFunction.Size = New System.Drawing.Size(104, 18)
        Me.lblFunction.TabIndex = 13
        Me.lblFunction.Text = "Select Function:"
        '
        'cmbFunction
        '
        Me.cmbFunction.FormattingEnabled = True
        Me.cmbFunction.Items.AddRange(New Object() {"Add Coins", "Remove Coins"})
        Me.cmbFunction.Location = New System.Drawing.Point(439, 40)
        Me.cmbFunction.Name = "cmbFunction"
        Me.cmbFunction.Size = New System.Drawing.Size(121, 21)
        Me.cmbFunction.TabIndex = 14
        '
        'grpDrink
        '
        Me.grpDrink.BackColor = System.Drawing.Color.Black
        Me.grpDrink.Controls.Add(Me.txtCoke)
        Me.grpDrink.Controls.Add(Me.txtDietCoke)
        Me.grpDrink.Controls.Add(Me.txt7up)
        Me.grpDrink.Controls.Add(Me.txtFanta)
        Me.grpDrink.Controls.Add(Me.txtLilt)
        Me.grpDrink.Controls.Add(Me.txtPepsi)
        Me.grpDrink.Controls.Add(Me.txtPepsiMax)
        Me.grpDrink.Controls.Add(Me.txtTango)
        Me.grpDrink.Controls.Add(Me.txtSanPell)
        Me.grpDrink.Controls.Add(Me.txtSprite)
        Me.grpDrink.Controls.Add(Me.txtDrPepper)
        Me.grpDrink.Controls.Add(Me.txt7upFree)
        Me.grpDrink.Controls.Add(Me.lblTango)
        Me.grpDrink.Controls.Add(Me.lblDrinkStock)
        Me.grpDrink.Controls.Add(Me.lblSanPell)
        Me.grpDrink.Controls.Add(Me.lblSprite)
        Me.grpDrink.Controls.Add(Me.lblDrPepper)
        Me.grpDrink.Controls.Add(Me.lblPepsiMax)
        Me.grpDrink.Controls.Add(Me.lblPepsi)
        Me.grpDrink.Controls.Add(Me.lblLilt)
        Me.grpDrink.Controls.Add(Me.lblFanta)
        Me.grpDrink.Controls.Add(Me.lbl7upFree)
        Me.grpDrink.Controls.Add(Me.lbl7up)
        Me.grpDrink.Controls.Add(Me.lblDietCoke)
        Me.grpDrink.Controls.Add(Me.lblCoke)
        Me.grpDrink.Location = New System.Drawing.Point(30, 146)
        Me.grpDrink.Name = "grpDrink"
        Me.grpDrink.Size = New System.Drawing.Size(222, 326)
        Me.grpDrink.TabIndex = 15
        Me.grpDrink.TabStop = False
        '
        'txtCoke
        '
        Me.txtCoke.ForeColor = System.Drawing.Color.Black
        Me.txtCoke.Location = New System.Drawing.Point(152, 29)
        Me.txtCoke.Name = "txtCoke"
        Me.txtCoke.Size = New System.Drawing.Size(64, 20)
        Me.txtCoke.TabIndex = 24
        '
        'txtDietCoke
        '
        Me.txtDietCoke.ForeColor = System.Drawing.Color.Black
        Me.txtDietCoke.Location = New System.Drawing.Point(152, 53)
        Me.txtDietCoke.Name = "txtDietCoke"
        Me.txtDietCoke.Size = New System.Drawing.Size(64, 20)
        Me.txtDietCoke.TabIndex = 23
        '
        'txt7up
        '
        Me.txt7up.ForeColor = System.Drawing.Color.Black
        Me.txt7up.Location = New System.Drawing.Point(152, 77)
        Me.txt7up.Name = "txt7up"
        Me.txt7up.Size = New System.Drawing.Size(64, 20)
        Me.txt7up.TabIndex = 22
        '
        'txtFanta
        '
        Me.txtFanta.ForeColor = System.Drawing.Color.Black
        Me.txtFanta.Location = New System.Drawing.Point(152, 126)
        Me.txtFanta.Name = "txtFanta"
        Me.txtFanta.Size = New System.Drawing.Size(64, 20)
        Me.txtFanta.TabIndex = 21
        '
        'txtLilt
        '
        Me.txtLilt.ForeColor = System.Drawing.Color.Black
        Me.txtLilt.Location = New System.Drawing.Point(152, 151)
        Me.txtLilt.Name = "txtLilt"
        Me.txtLilt.Size = New System.Drawing.Size(64, 20)
        Me.txtLilt.TabIndex = 20
        '
        'txtPepsi
        '
        Me.txtPepsi.ForeColor = System.Drawing.Color.Black
        Me.txtPepsi.Location = New System.Drawing.Point(152, 176)
        Me.txtPepsi.Name = "txtPepsi"
        Me.txtPepsi.Size = New System.Drawing.Size(64, 20)
        Me.txtPepsi.TabIndex = 19
        '
        'txtPepsiMax
        '
        Me.txtPepsiMax.ForeColor = System.Drawing.Color.Black
        Me.txtPepsiMax.Location = New System.Drawing.Point(152, 200)
        Me.txtPepsiMax.Name = "txtPepsiMax"
        Me.txtPepsiMax.Size = New System.Drawing.Size(64, 20)
        Me.txtPepsiMax.TabIndex = 18
        '
        'txtTango
        '
        Me.txtTango.ForeColor = System.Drawing.Color.Black
        Me.txtTango.Location = New System.Drawing.Point(152, 299)
        Me.txtTango.Name = "txtTango"
        Me.txtTango.Size = New System.Drawing.Size(64, 20)
        Me.txtTango.TabIndex = 17
        '
        'txtSanPell
        '
        Me.txtSanPell.ForeColor = System.Drawing.Color.Black
        Me.txtSanPell.Location = New System.Drawing.Point(152, 273)
        Me.txtSanPell.Name = "txtSanPell"
        Me.txtSanPell.Size = New System.Drawing.Size(64, 20)
        Me.txtSanPell.TabIndex = 16
        '
        'txtSprite
        '
        Me.txtSprite.ForeColor = System.Drawing.Color.Black
        Me.txtSprite.Location = New System.Drawing.Point(152, 248)
        Me.txtSprite.Name = "txtSprite"
        Me.txtSprite.Size = New System.Drawing.Size(64, 20)
        Me.txtSprite.TabIndex = 15
        '
        'txtDrPepper
        '
        Me.txtDrPepper.ForeColor = System.Drawing.Color.Black
        Me.txtDrPepper.Location = New System.Drawing.Point(152, 224)
        Me.txtDrPepper.Name = "txtDrPepper"
        Me.txtDrPepper.Size = New System.Drawing.Size(64, 20)
        Me.txtDrPepper.TabIndex = 14
        '
        'txt7upFree
        '
        Me.txt7upFree.ForeColor = System.Drawing.Color.Black
        Me.txt7upFree.Location = New System.Drawing.Point(152, 102)
        Me.txt7upFree.Name = "txt7upFree"
        Me.txt7upFree.Size = New System.Drawing.Size(64, 20)
        Me.txt7upFree.TabIndex = 13
        '
        'lblTango
        '
        Me.lblTango.AutoSize = True
        Me.lblTango.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTango.ForeColor = System.Drawing.Color.White
        Me.lblTango.Location = New System.Drawing.Point(10, 300)
        Me.lblTango.Name = "lblTango"
        Me.lblTango.Size = New System.Drawing.Size(48, 16)
        Me.lblTango.TabIndex = 12
        Me.lblTango.Text = "Tango"
        '
        'lblDrinkStock
        '
        Me.lblDrinkStock.AutoSize = True
        Me.lblDrinkStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkStock.ForeColor = System.Drawing.Color.White
        Me.lblDrinkStock.Location = New System.Drawing.Point(64, 0)
        Me.lblDrinkStock.Name = "lblDrinkStock"
        Me.lblDrinkStock.Size = New System.Drawing.Size(100, 16)
        Me.lblDrinkStock.TabIndex = 11
        Me.lblDrinkStock.Text = "Current Stock"
        '
        'lblSanPell
        '
        Me.lblSanPell.AutoSize = True
        Me.lblSanPell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSanPell.ForeColor = System.Drawing.Color.White
        Me.lblSanPell.Location = New System.Drawing.Point(10, 274)
        Me.lblSanPell.Name = "lblSanPell"
        Me.lblSanPell.Size = New System.Drawing.Size(96, 16)
        Me.lblSanPell.TabIndex = 10
        Me.lblSanPell.Text = "San Pellegrino"
        '
        'lblSprite
        '
        Me.lblSprite.AutoSize = True
        Me.lblSprite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSprite.ForeColor = System.Drawing.Color.White
        Me.lblSprite.Location = New System.Drawing.Point(10, 249)
        Me.lblSprite.Name = "lblSprite"
        Me.lblSprite.Size = New System.Drawing.Size(43, 16)
        Me.lblSprite.TabIndex = 9
        Me.lblSprite.Text = "Sprite"
        '
        'lblDrPepper
        '
        Me.lblDrPepper.AutoSize = True
        Me.lblDrPepper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrPepper.ForeColor = System.Drawing.Color.White
        Me.lblDrPepper.Location = New System.Drawing.Point(10, 225)
        Me.lblDrPepper.Name = "lblDrPepper"
        Me.lblDrPepper.Size = New System.Drawing.Size(70, 16)
        Me.lblDrPepper.TabIndex = 8
        Me.lblDrPepper.Text = "Dr Pepper"
        '
        'lblPepsiMax
        '
        Me.lblPepsiMax.AutoSize = True
        Me.lblPepsiMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPepsiMax.ForeColor = System.Drawing.Color.White
        Me.lblPepsiMax.Location = New System.Drawing.Point(10, 201)
        Me.lblPepsiMax.Name = "lblPepsiMax"
        Me.lblPepsiMax.Size = New System.Drawing.Size(71, 16)
        Me.lblPepsiMax.TabIndex = 7
        Me.lblPepsiMax.Text = "Pepsi Max"
        '
        'lblPepsi
        '
        Me.lblPepsi.AutoSize = True
        Me.lblPepsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPepsi.ForeColor = System.Drawing.Color.White
        Me.lblPepsi.Location = New System.Drawing.Point(10, 177)
        Me.lblPepsi.Name = "lblPepsi"
        Me.lblPepsi.Size = New System.Drawing.Size(43, 16)
        Me.lblPepsi.TabIndex = 6
        Me.lblPepsi.Text = "Pepsi"
        '
        'lblLilt
        '
        Me.lblLilt.AutoSize = True
        Me.lblLilt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLilt.ForeColor = System.Drawing.Color.White
        Me.lblLilt.Location = New System.Drawing.Point(10, 152)
        Me.lblLilt.Name = "lblLilt"
        Me.lblLilt.Size = New System.Drawing.Size(24, 16)
        Me.lblLilt.TabIndex = 5
        Me.lblLilt.Text = "Lilt"
        '
        'lblFanta
        '
        Me.lblFanta.AutoSize = True
        Me.lblFanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanta.ForeColor = System.Drawing.Color.White
        Me.lblFanta.Location = New System.Drawing.Point(10, 127)
        Me.lblFanta.Name = "lblFanta"
        Me.lblFanta.Size = New System.Drawing.Size(42, 16)
        Me.lblFanta.TabIndex = 4
        Me.lblFanta.Text = "Fanta"
        '
        'lbl7upFree
        '
        Me.lbl7upFree.AutoSize = True
        Me.lbl7upFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7upFree.ForeColor = System.Drawing.Color.White
        Me.lbl7upFree.Location = New System.Drawing.Point(10, 103)
        Me.lbl7upFree.Name = "lbl7upFree"
        Me.lbl7upFree.Size = New System.Drawing.Size(61, 16)
        Me.lbl7upFree.TabIndex = 3
        Me.lbl7upFree.Text = "7up Free"
        '
        'lbl7up
        '
        Me.lbl7up.AutoSize = True
        Me.lbl7up.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7up.ForeColor = System.Drawing.Color.White
        Me.lbl7up.Location = New System.Drawing.Point(10, 78)
        Me.lbl7up.Name = "lbl7up"
        Me.lbl7up.Size = New System.Drawing.Size(30, 16)
        Me.lbl7up.TabIndex = 2
        Me.lbl7up.Text = "7up"
        '
        'lblDietCoke
        '
        Me.lblDietCoke.AutoSize = True
        Me.lblDietCoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDietCoke.ForeColor = System.Drawing.Color.White
        Me.lblDietCoke.Location = New System.Drawing.Point(10, 54)
        Me.lblDietCoke.Name = "lblDietCoke"
        Me.lblDietCoke.Size = New System.Drawing.Size(67, 16)
        Me.lblDietCoke.TabIndex = 1
        Me.lblDietCoke.Text = "Diet Coke"
        '
        'lblCoke
        '
        Me.lblCoke.AutoSize = True
        Me.lblCoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoke.ForeColor = System.Drawing.Color.White
        Me.lblCoke.Location = New System.Drawing.Point(10, 30)
        Me.lblCoke.Name = "lblCoke"
        Me.lblCoke.Size = New System.Drawing.Size(40, 16)
        Me.lblCoke.TabIndex = 0
        Me.lblCoke.Text = "Coke"
        '
        'grpCoin
        '
        Me.grpCoin.BackColor = System.Drawing.Color.Black
        Me.grpCoin.Controls.Add(Me.txt2euro)
        Me.grpCoin.Controls.Add(Me.txt1euro)
        Me.grpCoin.Controls.Add(Me.txt50cent)
        Me.grpCoin.Controls.Add(Me.txt10cent)
        Me.grpCoin.Controls.Add(Me.txt5cent)
        Me.grpCoin.Controls.Add(Me.txt20cent)
        Me.grpCoin.Controls.Add(Me.lblCoinStock)
        Me.grpCoin.Controls.Add(Me.lbl5cent)
        Me.grpCoin.Controls.Add(Me.lbl10cent)
        Me.grpCoin.Controls.Add(Me.lbl20cent)
        Me.grpCoin.Controls.Add(Me.lbl50cent)
        Me.grpCoin.Controls.Add(Me.lbl1euro)
        Me.grpCoin.Controls.Add(Me.lbl2euro)
        Me.grpCoin.Location = New System.Drawing.Point(319, 199)
        Me.grpCoin.Name = "grpCoin"
        Me.grpCoin.Size = New System.Drawing.Size(241, 210)
        Me.grpCoin.TabIndex = 16
        Me.grpCoin.TabStop = False
        '
        'txt2euro
        '
        Me.txt2euro.ForeColor = System.Drawing.Color.Black
        Me.txt2euro.Location = New System.Drawing.Point(160, 45)
        Me.txt2euro.Name = "txt2euro"
        Me.txt2euro.Size = New System.Drawing.Size(64, 20)
        Me.txt2euro.TabIndex = 37
        '
        'txt1euro
        '
        Me.txt1euro.ForeColor = System.Drawing.Color.Black
        Me.txt1euro.Location = New System.Drawing.Point(160, 69)
        Me.txt1euro.Name = "txt1euro"
        Me.txt1euro.Size = New System.Drawing.Size(64, 20)
        Me.txt1euro.TabIndex = 36
        '
        'txt50cent
        '
        Me.txt50cent.ForeColor = System.Drawing.Color.Black
        Me.txt50cent.Location = New System.Drawing.Point(160, 93)
        Me.txt50cent.Name = "txt50cent"
        Me.txt50cent.Size = New System.Drawing.Size(64, 20)
        Me.txt50cent.TabIndex = 35
        '
        'txt10cent
        '
        Me.txt10cent.ForeColor = System.Drawing.Color.Black
        Me.txt10cent.Location = New System.Drawing.Point(160, 142)
        Me.txt10cent.Name = "txt10cent"
        Me.txt10cent.Size = New System.Drawing.Size(64, 20)
        Me.txt10cent.TabIndex = 34
        '
        'txt5cent
        '
        Me.txt5cent.ForeColor = System.Drawing.Color.Black
        Me.txt5cent.Location = New System.Drawing.Point(160, 167)
        Me.txt5cent.Name = "txt5cent"
        Me.txt5cent.Size = New System.Drawing.Size(64, 20)
        Me.txt5cent.TabIndex = 33
        '
        'txt20cent
        '
        Me.txt20cent.ForeColor = System.Drawing.Color.Black
        Me.txt20cent.Location = New System.Drawing.Point(160, 118)
        Me.txt20cent.Name = "txt20cent"
        Me.txt20cent.Size = New System.Drawing.Size(64, 20)
        Me.txt20cent.TabIndex = 32
        '
        'lblCoinStock
        '
        Me.lblCoinStock.AutoSize = True
        Me.lblCoinStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoinStock.ForeColor = System.Drawing.Color.White
        Me.lblCoinStock.Location = New System.Drawing.Point(67, 0)
        Me.lblCoinStock.Name = "lblCoinStock"
        Me.lblCoinStock.Size = New System.Drawing.Size(100, 16)
        Me.lblCoinStock.TabIndex = 31
        Me.lblCoinStock.Text = "Current Stock"
        '
        'lbl5cent
        '
        Me.lbl5cent.AutoSize = True
        Me.lbl5cent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5cent.ForeColor = System.Drawing.Color.White
        Me.lbl5cent.Location = New System.Drawing.Point(20, 168)
        Me.lbl5cent.Name = "lbl5cent"
        Me.lbl5cent.Size = New System.Drawing.Size(43, 16)
        Me.lbl5cent.TabIndex = 30
        Me.lbl5cent.Text = "5 cent"
        '
        'lbl10cent
        '
        Me.lbl10cent.AutoSize = True
        Me.lbl10cent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10cent.ForeColor = System.Drawing.Color.White
        Me.lbl10cent.Location = New System.Drawing.Point(13, 143)
        Me.lbl10cent.Name = "lbl10cent"
        Me.lbl10cent.Size = New System.Drawing.Size(50, 16)
        Me.lbl10cent.TabIndex = 29
        Me.lbl10cent.Text = "10 cent"
        '
        'lbl20cent
        '
        Me.lbl20cent.AutoSize = True
        Me.lbl20cent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl20cent.ForeColor = System.Drawing.Color.White
        Me.lbl20cent.Location = New System.Drawing.Point(13, 119)
        Me.lbl20cent.Name = "lbl20cent"
        Me.lbl20cent.Size = New System.Drawing.Size(50, 16)
        Me.lbl20cent.TabIndex = 28
        Me.lbl20cent.Text = "20 cent"
        '
        'lbl50cent
        '
        Me.lbl50cent.AutoSize = True
        Me.lbl50cent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl50cent.ForeColor = System.Drawing.Color.White
        Me.lbl50cent.Location = New System.Drawing.Point(13, 94)
        Me.lbl50cent.Name = "lbl50cent"
        Me.lbl50cent.Size = New System.Drawing.Size(50, 16)
        Me.lbl50cent.TabIndex = 27
        Me.lbl50cent.Text = "50 cent"
        '
        'lbl1euro
        '
        Me.lbl1euro.AutoSize = True
        Me.lbl1euro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1euro.ForeColor = System.Drawing.Color.White
        Me.lbl1euro.Location = New System.Drawing.Point(18, 70)
        Me.lbl1euro.Name = "lbl1euro"
        Me.lbl1euro.Size = New System.Drawing.Size(45, 16)
        Me.lbl1euro.TabIndex = 26
        Me.lbl1euro.Text = "1 euro"
        '
        'lbl2euro
        '
        Me.lbl2euro.AutoSize = True
        Me.lbl2euro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2euro.ForeColor = System.Drawing.Color.White
        Me.lbl2euro.Location = New System.Drawing.Point(18, 46)
        Me.lbl2euro.Name = "lbl2euro"
        Me.lbl2euro.Size = New System.Drawing.Size(45, 16)
        Me.lbl2euro.TabIndex = 25
        Me.lbl2euro.Text = "2 euro"
        '
        'lblChangeCost
        '
        Me.lblChangeCost.AutoSize = True
        Me.lblChangeCost.BackColor = System.Drawing.Color.Transparent
        Me.lblChangeCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeCost.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblChangeCost.Location = New System.Drawing.Point(685, 9)
        Me.lblChangeCost.Name = "lblChangeCost"
        Me.lblChangeCost.Size = New System.Drawing.Size(100, 16)
        Me.lblChangeCost.TabIndex = 17
        Me.lblChangeCost.Text = "Change Cost:"
        '
        'lblDrink2
        '
        Me.lblDrink2.AutoSize = True
        Me.lblDrink2.BackColor = System.Drawing.Color.Blue
        Me.lblDrink2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDrink2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrink2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDrink2.Location = New System.Drawing.Point(623, 41)
        Me.lblDrink2.Name = "lblDrink2"
        Me.lblDrink2.Size = New System.Drawing.Size(85, 18)
        Me.lblDrink2.TabIndex = 18
        Me.lblDrink2.Text = "Select Drink:"
        '
        'cmbDrink2
        '
        Me.cmbDrink2.FormattingEnabled = True
        Me.cmbDrink2.Items.AddRange(New Object() {"Coke", "Diet Coke", "7up", "7up Free", "Fanta", "Lilt", "Pepsi", "Pepsi Max", "Dr Pepper", "Sprite", "San Pellegrino", "Tango"})
        Me.cmbDrink2.Location = New System.Drawing.Point(725, 41)
        Me.cmbDrink2.Name = "cmbDrink2"
        Me.cmbDrink2.Size = New System.Drawing.Size(110, 21)
        Me.cmbDrink2.TabIndex = 19
        '
        'lblNewCost
        '
        Me.lblNewCost.AutoSize = True
        Me.lblNewCost.BackColor = System.Drawing.Color.Blue
        Me.lblNewCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNewCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewCost.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNewCost.Location = New System.Drawing.Point(623, 114)
        Me.lblNewCost.Name = "lblNewCost"
        Me.lblNewCost.Size = New System.Drawing.Size(104, 18)
        Me.lblNewCost.TabIndex = 20
        Me.lblNewCost.Text = "Enter New Cost:"
        '
        'txtNewCost
        '
        Me.txtNewCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewCost.Location = New System.Drawing.Point(743, 111)
        Me.txtNewCost.Name = "txtNewCost"
        Me.txtNewCost.Size = New System.Drawing.Size(92, 22)
        Me.txtNewCost.TabIndex = 21
        '
        'btnUpdatePrice
        '
        Me.btnUpdatePrice.BackColor = System.Drawing.Color.Blue
        Me.btnUpdatePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePrice.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdatePrice.Location = New System.Drawing.Point(688, 155)
        Me.btnUpdatePrice.Name = "btnUpdatePrice"
        Me.btnUpdatePrice.Size = New System.Drawing.Size(111, 29)
        Me.btnUpdatePrice.TabIndex = 22
        Me.btnUpdatePrice.Text = "Update Price"
        Me.btnUpdatePrice.UseVisualStyleBackColor = False
        '
        'txtCurrentCost
        '
        Me.txtCurrentCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentCost.Location = New System.Drawing.Point(743, 77)
        Me.txtCurrentCost.Name = "txtCurrentCost"
        Me.txtCurrentCost.Size = New System.Drawing.Size(92, 22)
        Me.txtCurrentCost.TabIndex = 23
        '
        'lblCurrentCost
        '
        Me.lblCurrentCost.AutoSize = True
        Me.lblCurrentCost.BackColor = System.Drawing.Color.Blue
        Me.lblCurrentCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentCost.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCurrentCost.Location = New System.Drawing.Point(623, 77)
        Me.lblCurrentCost.Name = "lblCurrentCost"
        Me.lblCurrentCost.Size = New System.Drawing.Size(85, 18)
        Me.lblCurrentCost.TabIndex = 24
        Me.lblCurrentCost.Text = "Current Cost:"
        '
        'btnUpdateDrink
        '
        Me.btnUpdateDrink.BackColor = System.Drawing.Color.Blue
        Me.btnUpdateDrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateDrink.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdateDrink.Location = New System.Drawing.Point(88, 104)
        Me.btnUpdateDrink.Name = "btnUpdateDrink"
        Me.btnUpdateDrink.Size = New System.Drawing.Size(106, 29)
        Me.btnUpdateDrink.TabIndex = 25
        Me.btnUpdateDrink.Text = "Update Drink"
        Me.btnUpdateDrink.UseVisualStyleBackColor = False
        '
        'btnUpdateCoin
        '
        Me.btnUpdateCoin.BackColor = System.Drawing.Color.Blue
        Me.btnUpdateCoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateCoin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdateCoin.Location = New System.Drawing.Point(389, 155)
        Me.btnUpdateCoin.Name = "btnUpdateCoin"
        Me.btnUpdateCoin.Size = New System.Drawing.Size(111, 29)
        Me.btnUpdateCoin.TabIndex = 26
        Me.btnUpdateCoin.Text = "Update Coins"
        Me.btnUpdateCoin.UseVisualStyleBackColor = False
        '
        'frmManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.prjVendingMachine.My.Resources.Resources.IceCubeBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(867, 487)
        Me.Controls.Add(Me.btnUpdateCoin)
        Me.Controls.Add(Me.btnUpdateDrink)
        Me.Controls.Add(Me.lblCurrentCost)
        Me.Controls.Add(Me.txtCurrentCost)
        Me.Controls.Add(Me.btnUpdatePrice)
        Me.Controls.Add(Me.txtNewCost)
        Me.Controls.Add(Me.lblNewCost)
        Me.Controls.Add(Me.cmbDrink2)
        Me.Controls.Add(Me.lblDrink2)
        Me.Controls.Add(Me.lblChangeCost)
        Me.Controls.Add(Me.grpCoin)
        Me.Controls.Add(Me.grpDrink)
        Me.Controls.Add(Me.cmbFunction)
        Me.Controls.Add(Me.lblFunction)
        Me.Controls.Add(Me.cmbCoin)
        Me.Controls.Add(Me.txtCoinQuantity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCoin)
        Me.Controls.Add(Me.lblAddRemCoin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtDrinkQuantity)
        Me.Controls.Add(Me.btnPrintReport)
        Me.Controls.Add(Me.cmbDrink)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblDrink)
        Me.Controls.Add(Me.lblAddDrinks)
        Me.Name = "frmManager"
        Me.Text = "frmManager"
        Me.grpDrink.ResumeLayout(False)
        Me.grpDrink.PerformLayout()
        Me.grpCoin.ResumeLayout(False)
        Me.grpCoin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddDrinks As Label
    Friend WithEvents lblDrink As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents cmbDrink As ComboBox
    Friend WithEvents btnPrintReport As Button
    Friend WithEvents txtDrinkQuantity As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAddRemCoin As Label
    Friend WithEvents lblCoin As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCoinQuantity As TextBox
    Friend WithEvents cmbCoin As ComboBox
    Friend WithEvents lblFunction As Label
    Friend WithEvents cmbFunction As ComboBox
    Friend WithEvents grpDrink As GroupBox
    Friend WithEvents grpCoin As GroupBox
    Friend WithEvents lblChangeCost As Label
    Friend WithEvents lblDrink2 As Label
    Friend WithEvents cmbDrink2 As ComboBox
    Friend WithEvents lblNewCost As Label
    Friend WithEvents txtNewCost As TextBox
    Friend WithEvents btnUpdatePrice As Button
    Friend WithEvents txtCurrentCost As TextBox
    Friend WithEvents lblCurrentCost As Label
    Friend WithEvents lblTango As Label
    Friend WithEvents lblDrinkStock As Label
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
    Friend WithEvents txt2euro As TextBox
    Friend WithEvents txt1euro As TextBox
    Friend WithEvents txt50cent As TextBox
    Friend WithEvents txt10cent As TextBox
    Friend WithEvents txt5cent As TextBox
    Friend WithEvents txt20cent As TextBox
    Friend WithEvents lblCoinStock As Label
    Friend WithEvents lbl5cent As Label
    Friend WithEvents lbl10cent As Label
    Friend WithEvents lbl20cent As Label
    Friend WithEvents lbl50cent As Label
    Friend WithEvents lbl1euro As Label
    Friend WithEvents lbl2euro As Label
    Friend WithEvents btnUpdateDrink As Button
    Friend WithEvents btnUpdateCoin As Button
End Class
