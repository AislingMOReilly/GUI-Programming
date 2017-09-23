Imports System.IO

Public Class Form1

    '***************************Declare Variables*************************************
    Dim CreditTotal As Single
    Dim moneyAvailable As Single
    Dim changeNeeded As Single

    'Temporary Coins
    Dim Temp5cent, Temp10cent, Temp20cent, Temp50cent, Temp1euro, Temp2euro As Short

    Dim capacityReader As StreamReader = New StreamReader("..\..\Resources\CoinCapacity.txt")
    Dim tempCoinsReader As StreamReader = New StreamReader("..\..\Resources\TempCoins.txt")
    Dim priceReader As StreamReader = New StreamReader("..\..\Resources\DrinksPrices.txt")
    Dim unitsSoldReader As StreamReader = New StreamReader("..\..\Resources\DrinksSold.txt")
    Dim drinksCapacityReader As StreamReader = New StreamReader("..\..\Resources\DrinksCapacity.txt")
    Dim ChangePerCoinReader As StreamReader = New StreamReader("..\..\Resources\ChangePerCoin.txt")


    '*******************************Code Functions*************************************
    Private Sub initialiseCoinCapacity()
        With capacityReader
            Cap2euro = .ReadLine
            Cap1euro = .ReadLine
            Cap50cent = .ReadLine
            Cap20cent = .ReadLine
            Cap10cent = .ReadLine
            Cap5cent = .ReadLine
        End With
    End Sub

    Private Sub initialisePrices()
        With priceReader
            Drink1Price = .ReadLine
            lblCoke.Text = FormatCurrency(Drink1Price)
            Drink2Price = .ReadLine
            lblDietCoke.Text = FormatCurrency(Drink2Price)
            Drink3Price = .ReadLine
            lbl7up.Text = FormatCurrency(Drink3Price)
            Drink4Price = .ReadLine
            lbl7upFree.Text = FormatCurrency(Drink4Price)
            Drink5Price = .ReadLine
            lblFanta.Text = FormatCurrency(Drink5Price)
            Drink6Price = .ReadLine
            lblLilt.Text = FormatCurrency(Drink6Price)
            Drink7Price = .ReadLine
            lblPepsi.Text = FormatCurrency(Drink7Price)
            Drink8Price = .ReadLine
            lblPepsiMax.Text = FormatCurrency(Drink8Price)
            Drink9Price = .ReadLine
            lblDrPep.Text = FormatCurrency(Drink9Price)
            Drink10Price = .ReadLine
            lblSprite.Text = FormatCurrency(Drink10Price)
            Drink11Price = .ReadLine
            lblSanPelOr.Text = FormatCurrency(Drink11Price)
            Drink12Price = .ReadLine
            lblTango.Text = FormatCurrency(Drink12Price)
        End With
    End Sub

    Private Sub initialiseDrinksCapacity()
        With drinksCapacityReader
            CapDrink1 = .ReadLine
            If CapDrink1 < 1 Then
                lblCoke.Text = "Out of Stock"
                btnCoke.Enabled = False
            Else
                btnCoke.Enabled = True
            End If

            CapDrink2 = .ReadLine
            If CapDrink2 < 1 Then
                lblDietCoke.Text = "Out of Stock"
                btnDietCoke.Enabled = False
            Else
                btnDietCoke.Enabled = True
            End If

            CapDrink3 = .ReadLine
            If CapDrink3 < 1 Then
                lbl7up.Text = "Out of Stock"
                btn7up.Enabled = False
            Else
                btn7up.Enabled = True
            End If

            CapDrink4 = .ReadLine
            If CapDrink4 < 1 Then
                lbl7upFree.Text = "Out of Stock"
                btn7upFree.Enabled = False
            Else
                btn7upFree.Enabled = True
            End If

            CapDrink5 = .ReadLine
            If CapDrink5 < 1 Then
                lblFanta.Text = "Out of Stock"
                btnFanta.Enabled = False
            Else
                btnFanta.Enabled = True
            End If

            CapDrink6 = .ReadLine
            If CapDrink6 < 1 Then
                lblLilt.Text = "Out of Stock"
                btnLilt.Enabled = False
            Else
                btnLilt.Enabled = True
            End If

            CapDrink7 = .ReadLine
            If CapDrink7 < 1 Then
                lblPepsi.Text = "Out of Stock"
                btnPepsi.Enabled = False
            Else
                btnPepsi.Enabled = True
            End If

            CapDrink8 = .ReadLine
            If CapDrink8 < 1 Then
                lblPepsiMax.Text = "Out of Stock"
                btnPepsiMax.Enabled = False
            Else
                btnPepsiMax.Enabled = True
            End If

            CapDrink9 = .ReadLine
            If CapDrink9 < 1 Then
                lblDrPep.Text = "Out of Stock"
                btnDrPepper.Enabled = False
            Else
                btnDrPepper.Enabled = True
            End If

            CapDrink10 = .ReadLine
            If CapDrink10 < 1 Then
                lblSprite.Text = "Out of Stock"
                btnSprite.Enabled = False
            Else
                btnSprite.Enabled = True
            End If

            CapDrink11 = .ReadLine
            If CapDrink11 < 1 Then
                lblSanPelOr.Text = "Out of Stock"
                btnSanPelOr.Enabled = False
            Else
                btnSanPelOr.Enabled = True
            End If

            CapDrink12 = .ReadLine
            If CapDrink12 < 1 Then
                lblTango.Text = "Out of Stock"
                btnTango.Enabled = False
            Else
                btnTango.Enabled = True
            End If
        End With
    End Sub

    Private Sub ClearDrinksSold()
        With unitsSoldReader
            Drink1Sold = .ReadLine
            Drink2Sold = .ReadLine
            Drink3Sold = .ReadLine
            Drink4Sold = .ReadLine
            Drink5Sold = .ReadLine
            Drink6Sold = .ReadLine
            Drink7Sold = .ReadLine
            Drink8Sold = .ReadLine
            Drink9Sold = .ReadLine
            Drink10Sold = .ReadLine
            Drink11Sold = .ReadLine
            Drink12Sold = .ReadLine
        End With
    End Sub

    Private Sub ClearTempCoins()
        With tempCoinsReader
            Temp2euro = .ReadLine
            Temp1euro = .ReadLine
            Temp50cent = .ReadLine
            Temp20cent = .ReadLine
            Temp10cent = .ReadLine
            Temp5cent = .ReadLine
        End With
    End Sub

    Private Sub ClearChangePerCoins()
        With ChangePerCoinReader
            Change2euro = .ReadLine
            Change1euro = .ReadLine
            Change50cent = .ReadLine
            Change20cent = .ReadLine
            Change10cent = .ReadLine
            Change5cent = .ReadLine
        End With
    End Sub

    Private Sub UpdateCoinCapacity()
        Cap2euro += Temp2euro
        Cap1euro += Temp1euro
        Cap50cent += Temp50cent
        Cap20cent += Temp20cent
        Cap10cent += Temp10cent
        Cap5cent += Temp5cent
    End Sub


    Private Sub CalcMoneyAvailable()
        moneyAvailable = (2 * Cap2euro + 1 * Cap1euro + 0.5 * Cap50cent + 0.2 * Cap20cent + 0.1 * Cap10cent + 0.05 * Cap5cent)
    End Sub

    '*******************************Break Down of Change**************************************
    Private Sub BreakDownChange()

        totalChange = changeNeeded
        changeNeeded *= 100
        Do
            If Convert.ToInt16(changeNeeded) >= 200 And Cap2euro > 0 Then
                changeNeeded -= 200
                Cap2euro -= 1
                Change2euro += 1
            End If
        Loop Until changeNeeded < 200

        Do
            If Convert.ToInt16(changeNeeded) >= 100 And Cap1euro > 0 Then
                changeNeeded -= 100
                Cap1euro -= 1
                Change1euro += 1
            End If
        Loop Until changeNeeded < 100

        Do
            If Convert.ToInt16(changeNeeded) >= 50 And Cap50cent > 0 Then
                changeNeeded -= 50
                Cap50cent -= 1
                Change50cent += 1
            End If
        Loop Until changeNeeded < 50

        Do
            If Convert.ToInt16(changeNeeded) >= 20 And Cap20cent > 0 Then
                changeNeeded -= 20
                Cap20cent -= 1
                Change20cent += 1
            End If
        Loop Until changeNeeded < 20

        Do
            If Convert.ToInt16(changeNeeded) >= 10 And Cap10cent > 0 Then
                changeNeeded -= 10
                Cap10cent -= 1
                Change10cent += 1
            End If
        Loop Until changeNeeded < 10

        Do
            If Convert.ToInt16(changeNeeded) >= 5 And Cap5cent > 0 Then
                changeNeeded -= 5
                Cap5cent -= 1
                Change5cent += 1
            End If
        Loop Until changeNeeded < 5
    End Sub


    '*******************************When Form is Loaded**************************************
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreditTotal = 0

        initialiseCoinCapacity()
        initialisePrices()
        initialiseDrinksCapacity()

        ClearDrinksSold()
        ClearTempCoins()
        ClearChangePerCoins()

        pbxDisplay.Image = My.Resources.vendingimage
    End Sub


    '********************************When Coins are Entered***********************************

    '5 cent
    Private Sub btn5cent_Click(sender As Object, e As EventArgs) Handles btn5cent.Click
        If Cap5cent = 200 Then
            MsgBox("Unable to accept anymore 5 cent coins. Please enter amount in other coins or try again later.")
        Else
            CreditTotal += 0.05
            lblCreditTotal.Text = FormatCurrency(CreditTotal)
            Temp5cent += 1
        End If
    End Sub

    '10 cent
    Private Sub btn10cent_Click(sender As Object, e As EventArgs) Handles btn10cent.Click
        If Cap10cent = 200 Then
            MsgBox("Unable to accept anymore 10 cent coins. Please enter amount in other coins or try again later.")
        Else
            CreditTotal += 0.1
            lblCreditTotal.Text = FormatCurrency(CreditTotal)
            Temp10cent += 1
        End If
    End Sub

    '20 cent
    Private Sub btn20cent_Click(sender As Object, e As EventArgs) Handles btn20cent.Click
        If Cap20cent = 200 Then
            MsgBox("Unable to accept anymore 20 cent coins. Please enter amount in other coins or try again later.")
        Else
            CreditTotal += 0.2
            lblCreditTotal.Text = FormatCurrency(CreditTotal)
            Temp20cent += 1
        End If

    End Sub

    '50 cent
    Private Sub btn50cent_Click(sender As Object, e As EventArgs) Handles btn50cent.Click
        If Cap50cent = 200 Then
            MsgBox("Unable to accept anymore 50 cent coins. Please enter amount in other coins or try again later.")
        Else
            CreditTotal += 0.5
            lblCreditTotal.Text = FormatCurrency(CreditTotal)
            Temp50cent += 1
        End If
    End Sub

    '1 euro
    Private Sub btn1euro_Click(sender As Object, e As EventArgs) Handles btn1euro.Click
        If Cap1euro = 300 Then
            MsgBox("Unable to accept anymore 1 euro coins. Please enter amount in other coins or try again later.")
        Else
            CreditTotal += 1
            lblCreditTotal.Text = FormatCurrency(CreditTotal)
            Temp1euro += 1
        End If
    End Sub

    '2 euro
    Private Sub btn2euro_Click(sender As Object, e As EventArgs) Handles btn2euro.Click
        If Cap2euro = 500 Then
            MsgBox("Unable to accept anymore 2 euro coins. Please enter amount in other coins or try again later.")
        Else
            CreditTotal += 2
            lblCreditTotal.Text = FormatCurrency(CreditTotal)
            Temp2euro += 1
        End If
    End Sub


    '*******************************When A Drink is Selected*************************************
    'Coke
    Private Sub btnCoke_Click(sender As Object, e As EventArgs) Handles btnCoke.Click

        'Insufficient Funds
        If CreditTotal < Drink1Price Then
            MsgBox("Insufficient Funds")
        End If

        'Exact Change
        If CreditTotal = Drink1Price Then
            MsgBox("Thank you for your order. Please Enjoy")
            pbxDisplay.Image = My.Resources.coke1
            Drink1Sold += 1
            CapDrink1 -= 1
            SalesRevenue += Drink1Price

            UpdateCoinCapacity()
            ClearTempCoins()

            CreditTotal = 0
            lblCreditTotal.Text = FormatCurrency(0.0)

            MsgBox("Please take your drink")
            pbxDisplay.Image = My.Resources.vendingimage
        End If

        'More than Price
        If CreditTotal > Drink1Price Then
            changeNeeded = CreditTotal - Drink1Price
            CalcMoneyAvailable()
            MsgBox("Thank you for your order. We're Calculating your change")

            'No Change
            If changeNeeded > moneyAvailable Then
                frmNoChange.Show()

                If forfeitChange = True Then
                    pbxDisplay.Image = My.Resources.coke1
                    Drink1Sold += 1
                    CapDrink1 -= 1
                    SalesRevenue += Drink1Price
                    ChangeRevenue += changeNeeded

                    UpdateCoinCapacity()
                    ClearTempCoins()

                    MsgBox("Please take your drink")
                    pbxDisplay.Image = My.Resources.vendingimage
                Else
                    ClearTempCoins()
                End If
                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                'Change Available
            Else
                pbxDisplay.Image = My.Resources.coke1
                Drink1Sold += 1
                CapDrink1 -= 1
                SalesRevenue += Drink1Price

                UpdateCoinCapacity()
                ClearTempCoins()

                BreakDownChange()
                frmChange.Show()
                ClearChangePerCoins()

                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                MsgBox("Please take your drink")
                pbxDisplay.Image = My.Resources.vendingimage
            End If
        End If
    End Sub


    'Diet Coke
    Private Sub btnDietCoke_Click(sender As Object, e As EventArgs) Handles btnDietCoke.Click
        'Insufficient Funds
        If CreditTotal < Drink2Price Then
            MsgBox("Insufficient Funds")
        End If

        'Exact Change
        If CreditTotal = Drink2Price Then
            MsgBox("Thank you for your order. Please Enjoy")
            pbxDisplay.Image = My.Resources.DietCoke1
            Drink2Sold += 1
            CapDrink2 -= 1
            SalesRevenue += Drink2Price

            UpdateCoinCapacity()
            ClearTempCoins()

            CreditTotal = 0
            lblCreditTotal.Text = FormatCurrency(0.0)

            MsgBox("Please take your drink")
            pbxDisplay.Image = My.Resources.vendingimage
        End If

        'More than Price
        If CreditTotal > Drink1Price Then
            changeNeeded = CreditTotal - Drink1Price
            CalcMoneyAvailable()
            MsgBox("Thank you for your order. We're Calculating your change")

            'No Change
            If changeNeeded > moneyAvailable Then
                frmNoChange.Show()

                If forfeitChange = True Then
                    pbxDisplay.Image = My.Resources.DietCoke1
                    Drink2Sold += 1
                    CapDrink2 -= 1
                    SalesRevenue += Drink2Price
                    ChangeRevenue += changeNeeded

                    UpdateCoinCapacity()
                    ClearTempCoins()

                    MsgBox("Please take your drink")
                    pbxDisplay.Image = My.Resources.vendingimage
                Else
                    ClearTempCoins()
                End If
                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                'Change Available
            Else
                pbxDisplay.Image = My.Resources.DietCoke1
                Drink2Sold += 1
                CapDrink2 -= 1
                SalesRevenue += Drink2Price

                UpdateCoinCapacity()
                ClearTempCoins()

                BreakDownChange()
                frmChange.Show()
                ClearChangePerCoins()

                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                MsgBox("Please take your drink")
                pbxDisplay.Image = My.Resources.vendingimage
            End If
        End If
    End Sub

    '7up
    Private Sub btn7up_Click(sender As Object, e As EventArgs) Handles btn7up.Click
        'Insufficient Funds
        If CreditTotal < Drink3Price Then
            MsgBox("Insufficient Funds")
        End If

        'Exact Change
        If CreditTotal = Drink3Price Then
            MsgBox("Thank you for your order. Please Enjoy")
            pbxDisplay.Image = My.Resources._7up1
            Drink3Sold += 1
            CapDrink3 -= 1
            SalesRevenue += Drink3Price

            UpdateCoinCapacity()
            ClearTempCoins()

            CreditTotal = 0
            lblCreditTotal.Text = FormatCurrency(0.0)

            MsgBox("Please take your drink")
            pbxDisplay.Image = My.Resources.vendingimage
        End If

        'More than Price
        If CreditTotal > Drink3Price Then
            changeNeeded = CreditTotal - Drink3Price
            CalcMoneyAvailable()
            MsgBox("Thank you for your order. We're Calculating your change")

            'No Change
            If changeNeeded > moneyAvailable Then
                frmNoChange.Show()

                If forfeitChange = True Then
                    pbxDisplay.Image = My.Resources._7up1
                    Drink3Sold += 1
                    CapDrink3 -= 1
                    SalesRevenue += Drink3Price
                    ChangeRevenue += changeNeeded

                    UpdateCoinCapacity()
                    ClearTempCoins()

                    MsgBox("Please take your drink")
                    pbxDisplay.Image = My.Resources.vendingimage
                Else
                    ClearTempCoins()
                End If
                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                'Change Available
            Else
                pbxDisplay.Image = My.Resources._7up1
                Drink3Sold += 1
                CapDrink3 -= 1
                SalesRevenue += Drink3Price

                UpdateCoinCapacity()
                ClearTempCoins()

                BreakDownChange()
                frmChange.Show()
                ClearChangePerCoins()

                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                MsgBox("Please take your drink")
                pbxDisplay.Image = My.Resources.vendingimage
            End If
        End If
    End Sub

    '7upFree
    Private Sub btn7upFree_Click(sender As Object, e As EventArgs) Handles btn7upFree.Click
        'Insufficient Funds
        If CreditTotal < Drink4Price Then
            MsgBox("Insufficient Funds")
        End If

        'Exact Change
        If CreditTotal = Drink4Price Then
            MsgBox("Thank you for your order. Please Enjoy")
            pbxDisplay.Image = My.Resources._7up_free1
            Drink4Sold += 1
            CapDrink4 -= 1
            SalesRevenue += Drink4Price

            UpdateCoinCapacity()
            ClearTempCoins()

            CreditTotal = 0
            lblCreditTotal.Text = FormatCurrency(0.0)

            MsgBox("Please take your drink")
            pbxDisplay.Image = My.Resources.vendingimage
        End If

        'More than Price
        If CreditTotal > Drink1Price Then
            changeNeeded = CreditTotal - Drink4Price
            CalcMoneyAvailable()
            MsgBox("Thank you for your order. We're Calculating your change")

            'No Change
            If changeNeeded > moneyAvailable Then
                frmNoChange.Show()

                If forfeitChange = True Then
                    pbxDisplay.Image = My.Resources._7up_free1
                    Drink4Sold += 1
                    CapDrink4 -= 1
                    SalesRevenue += Drink4Price
                    ChangeRevenue += changeNeeded

                    UpdateCoinCapacity()
                    ClearTempCoins()

                    MsgBox("Please take your drink")
                    pbxDisplay.Image = My.Resources.vendingimage
                Else
                    ClearTempCoins()
                End If
                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                'Change Available
            Else
                pbxDisplay.Image = My.Resources._7up_free1
                Drink4Sold += 1
                CapDrink4 -= 1
                SalesRevenue += Drink4Price

                UpdateCoinCapacity()
                ClearTempCoins()

                BreakDownChange()
                frmChange.Show()
                ClearChangePerCoins()

                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                MsgBox("Please take your drink")
                pbxDisplay.Image = My.Resources.vendingimage
            End If
        End If
    End Sub

    'Fanta
    Private Sub btnFanta_Click(sender As Object, e As EventArgs) Handles btnFanta.Click
        'Insufficient Funds
        If CreditTotal < Drink5Price Then
            MsgBox("Insufficient Funds")
        End If

        'Exact Change
        If CreditTotal = Drink5Price Then
            MsgBox("Thank you for your order. Please Enjoy")
            pbxDisplay.Image = My.Resources.fanta1
            Drink5Sold += 1
            CapDrink5 -= 1
            SalesRevenue += Drink5Price

            UpdateCoinCapacity()
            ClearTempCoins()

            CreditTotal = 0
            lblCreditTotal.Text = FormatCurrency(0.0)

            MsgBox("Please take your drink")
            pbxDisplay.Image = My.Resources.vendingimage
        End If

        'More than Price
        If CreditTotal > Drink5Price Then
            changeNeeded = CreditTotal - Drink5Price
            CalcMoneyAvailable()
            MsgBox("Thank you for your order. We're Calculating your change")

            'No Change
            If changeNeeded > moneyAvailable Then
                frmNoChange.Show()

                If forfeitChange = True Then
                    pbxDisplay.Image = My.Resources.fanta1
                    Drink5Sold += 1
                    CapDrink5 -= 1
                    SalesRevenue += Drink5Price
                    ChangeRevenue += changeNeeded

                    UpdateCoinCapacity()
                    ClearTempCoins()

                    MsgBox("Please take your drink")
                    pbxDisplay.Image = My.Resources.vendingimage
                Else
                    ClearTempCoins()
                End If
                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                'Change Available
            Else
                pbxDisplay.Image = My.Resources.fanta1
                Drink5Sold += 1
                CapDrink5 -= 1
                SalesRevenue += Drink5Price

                UpdateCoinCapacity()
                ClearTempCoins()

                BreakDownChange()
                frmChange.Show()
                ClearChangePerCoins()

                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                MsgBox("Please take your drink")
                pbxDisplay.Image = My.Resources.vendingimage
            End If
        End If
    End Sub

    'Lilt
    Private Sub btnLilt_Click(sender As Object, e As EventArgs) Handles btnLilt.Click
        'Insufficient Funds
        If CreditTotal < Drink6Price Then
            MsgBox("Insufficient Funds")
        End If

        'Exact Change
        If CreditTotal = Drink6Price Then
            MsgBox("Thank you for your order. Please Enjoy")
            pbxDisplay.Image = My.Resources.lilt_can1
            Drink6Sold += 1
            CapDrink6 -= 1
            SalesRevenue += Drink6Price

            UpdateCoinCapacity()
            ClearTempCoins()

            CreditTotal = 0
            lblCreditTotal.Text = FormatCurrency(0.0)

            MsgBox("Please take your drink")
            pbxDisplay.Image = My.Resources.vendingimage
        End If

        'More than Price
        If CreditTotal > Drink6Price Then
            changeNeeded = CreditTotal - Drink6Price
            CalcMoneyAvailable()
            MsgBox("Thank you for your order. We're Calculating your change")

            'No Change
            If changeNeeded > moneyAvailable Then
                frmNoChange.Show()

                If forfeitChange = True Then
                    pbxDisplay.Image = My.Resources.lilt_can1
                    Drink6Sold += 1
                    CapDrink6 -= 1
                    SalesRevenue += Drink6Price
                    ChangeRevenue += changeNeeded

                    UpdateCoinCapacity()
                    ClearTempCoins()

                    MsgBox("Please take your drink")
                    pbxDisplay.Image = My.Resources.vendingimage
                Else
                    ClearTempCoins()
                End If
                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                'Change Available
            Else
                pbxDisplay.Image = My.Resources.lilt_can1
                Drink6Sold += 1
                CapDrink6 -= 1
                SalesRevenue += Drink6Price

                UpdateCoinCapacity()
                ClearTempCoins()

                BreakDownChange()
                frmChange.Show()
                ClearChangePerCoins()

                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                MsgBox("Please take your drink")
                pbxDisplay.Image = My.Resources.vendingimage
            End If
        End If
    End Sub

    'Pepsi
    Private Sub btnPepsi_Click(sender As Object, e As EventArgs) Handles btnPepsi.Click
        'Insufficient Funds
        If CreditTotal < Drink7Price Then
            MsgBox("Insufficient Funds")
        End If

        'Exact Change
        If CreditTotal = Drink7Price Then
            MsgBox("Thank you for your order. Please Enjoy")
            pbxDisplay.Image = My.Resources.Pepsi_can1
            Drink7Sold += 1
            CapDrink7 -= 1
            SalesRevenue += Drink7Price

            UpdateCoinCapacity()
            ClearTempCoins()

            CreditTotal = 0
            lblCreditTotal.Text = FormatCurrency(0.0)

            MsgBox("Please take your drink")
            pbxDisplay.Image = My.Resources.vendingimage
        End If

        'More than Price
        If CreditTotal > Drink7Price Then
            changeNeeded = CreditTotal - Drink7Price
            CalcMoneyAvailable()
            MsgBox("Thank you for your order. We're Calculating your change")

            'No Change
            If changeNeeded > moneyAvailable Then
                frmNoChange.Show()

                If forfeitChange = True Then
                    pbxDisplay.Image = My.Resources.Pepsi_can1
                    Drink7Sold += 1
                    CapDrink7 -= 1
                    SalesRevenue += Drink7Price
                    ChangeRevenue += changeNeeded

                    UpdateCoinCapacity()
                    ClearTempCoins()

                    MsgBox("Please take your drink")
                    pbxDisplay.Image = My.Resources.vendingimage
                Else
                    ClearTempCoins()
                End If
                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                'Change Available
            Else
                pbxDisplay.Image = My.Resources.Pepsi_can1
                Drink7Sold += 1
                CapDrink7 -= 1
                SalesRevenue += Drink7Price

                UpdateCoinCapacity()
                ClearTempCoins()

                BreakDownChange()
                frmChange.Show()
                ClearChangePerCoins()

                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                MsgBox("Please take your drink")
                pbxDisplay.Image = My.Resources.vendingimage
            End If
        End If
    End Sub

    'Pepsi Max
    Private Sub btnPepsiMax_Click(sender As Object, e As EventArgs) Handles btnPepsiMax.Click
        'Insufficient Funds
        If CreditTotal < Drink8Price Then
            MsgBox("Insufficient Funds")
        End If

        'Exact Change
        If CreditTotal = Drink8Price Then
            MsgBox("Thank you for your order. Please Enjoy")
            pbxDisplay.Image = My.Resources.Pepsi_Max_can1
            Drink8Sold += 1
            CapDrink8 -= 1
            SalesRevenue += Drink8Price

            UpdateCoinCapacity()
            ClearTempCoins()

            CreditTotal = 0
            lblCreditTotal.Text = FormatCurrency(0.0)

            MsgBox("Please take your drink")
            pbxDisplay.Image = My.Resources.vendingimage
        End If

        'More than Price
        If CreditTotal > Drink8Price Then
            changeNeeded = CreditTotal - Drink8Price
            CalcMoneyAvailable()
            MsgBox("Thank you for your order. We're Calculating your change")

            'No Change
            If changeNeeded > moneyAvailable Then
                frmNoChange.Show()

                If forfeitChange = True Then
                    pbxDisplay.Image = My.Resources.Pepsi_Max_can1
                    Drink8Sold += 1
                    CapDrink8 -= 1
                    SalesRevenue += Drink8Price
                    ChangeRevenue += changeNeeded

                    UpdateCoinCapacity()
                    ClearTempCoins()

                    MsgBox("Please take your drink")
                    pbxDisplay.Image = My.Resources.vendingimage
                Else
                    ClearTempCoins()
                End If
                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                'Change Available
            Else
                pbxDisplay.Image = My.Resources.Pepsi_Max_can1
                Drink8Sold += 1
                CapDrink8 -= 1
                SalesRevenue += Drink8Price

                UpdateCoinCapacity()
                ClearTempCoins()

                BreakDownChange()
                frmChange.Show()
                ClearChangePerCoins()

                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                MsgBox("Please take your drink")
                pbxDisplay.Image = My.Resources.vendingimage
            End If
        End If
    End Sub

    'Dr Pepper
    Private Sub btnDrPepper_Click(sender As Object, e As EventArgs) Handles btnDrPepper.Click
        'Insufficient Funds
        If CreditTotal < Drink9Price Then
            MsgBox("Insufficient Funds")
        End If

        'Exact Change
        If CreditTotal = Drink9Price Then
            MsgBox("Thank you for your order. Please Enjoy")
            pbxDisplay.Image = My.Resources.dr_pepper1
            Drink9Sold += 1
            CapDrink9 -= 1
            SalesRevenue += Drink9Price

            UpdateCoinCapacity()
            ClearTempCoins()

            CreditTotal = 0
            lblCreditTotal.Text = FormatCurrency(0.0)

            MsgBox("Please take your drink")
            pbxDisplay.Image = My.Resources.vendingimage
        End If

        'More than Price
        If CreditTotal > Drink9Price Then
            changeNeeded = CreditTotal - Drink9Price
            CalcMoneyAvailable()
            MsgBox("Thank you for your order. We're Calculating your change")

            'No Change
            If changeNeeded > moneyAvailable Then
                frmNoChange.Show()

                If forfeitChange = True Then
                    pbxDisplay.Image = My.Resources.dr_pepper1
                    Drink9Sold += 1
                    CapDrink9 -= 1
                    SalesRevenue += Drink9Price
                    ChangeRevenue += changeNeeded

                    UpdateCoinCapacity()
                    ClearTempCoins()

                    MsgBox("Please take your drink")
                    pbxDisplay.Image = My.Resources.vendingimage
                Else
                    ClearTempCoins()
                End If
                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                'Change Available
            Else
                pbxDisplay.Image = My.Resources.dr_pepper1
                Drink9Sold += 1
                CapDrink9 -= 1
                SalesRevenue += Drink9Price

                UpdateCoinCapacity()
                ClearTempCoins()

                BreakDownChange()
                frmChange.Show()
                ClearChangePerCoins()

                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                MsgBox("Please take your drink")
                pbxDisplay.Image = My.Resources.vendingimage
            End If
        End If
    End Sub

    'Sprite
    Private Sub btnSprite_Click(sender As Object, e As EventArgs) Handles btnSprite.Click
        'Insufficient Funds
        If CreditTotal < Drink10Price Then
            MsgBox("Insufficient Funds")
        End If

        'Exact Change
        If CreditTotal = Drink10Price Then
            MsgBox("Thank you for your order. Please Enjoy")
            pbxDisplay.Image = My.Resources.Sprite_can1
            Drink10Sold += 1
            CapDrink10 -= 1
            SalesRevenue += Drink10Price

            UpdateCoinCapacity()
            ClearTempCoins()

            CreditTotal = 0
            lblCreditTotal.Text = FormatCurrency(0.0)

            MsgBox("Please take your drink")
            pbxDisplay.Image = My.Resources.vendingimage
        End If

        'More than Price
        If CreditTotal > Drink10Price Then
            changeNeeded = CreditTotal - Drink10Price
            CalcMoneyAvailable()
            MsgBox("Thank you for your order. We're Calculating your change")

            'No Change
            If changeNeeded > moneyAvailable Then
                frmNoChange.Show()

                If forfeitChange = True Then
                    pbxDisplay.Image = My.Resources.Sprite_can1
                    Drink10Sold += 1
                    CapDrink10 -= 1
                    SalesRevenue += Drink10Price
                    ChangeRevenue += changeNeeded

                    UpdateCoinCapacity()
                    ClearTempCoins()

                    MsgBox("Please take your drink")
                    pbxDisplay.Image = My.Resources.vendingimage
                Else
                    ClearTempCoins()
                End If
                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                'Change Available
            Else
                pbxDisplay.Image = My.Resources.Sprite_can1
                Drink10Sold += 1
                CapDrink10 -= 1
                SalesRevenue += Drink10Price

                UpdateCoinCapacity()
                ClearTempCoins()

                BreakDownChange()
                frmChange.Show()
                ClearChangePerCoins()

                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                MsgBox("Please take your drink")
                pbxDisplay.Image = My.Resources.vendingimage
            End If
        End If
    End Sub


    'San Pelligrino 
    Private Sub btnSanPelOr_Click(sender As Object, e As EventArgs) Handles btnSanPelOr.Click
        'Insufficient Funds
        If CreditTotal < Drink11Price Then
            MsgBox("Insufficient Funds")
        End If

        'Exact Change
        If CreditTotal = Drink11Price Then
            MsgBox("Thank you for your order. Please Enjoy")
            pbxDisplay.Image = My.Resources.San_pell_orange1
            Drink11Sold += 1
            CapDrink11 -= 1
            SalesRevenue += Drink11Price

            UpdateCoinCapacity()
            ClearTempCoins()

            CreditTotal = 0
            lblCreditTotal.Text = FormatCurrency(0.0)

            MsgBox("Please take your drink")
            pbxDisplay.Image = My.Resources.vendingimage
        End If

        'More than Price
        If CreditTotal > Drink11Price Then
            changeNeeded = CreditTotal - Drink11Price
            CalcMoneyAvailable()
            MsgBox("Thank you for your order. We're Calculating your change")

            'No Change
            If changeNeeded > moneyAvailable Then
                frmNoChange.Show()

                If forfeitChange = True Then
                    pbxDisplay.Image = My.Resources.San_pell_orange1
                    Drink11Sold += 1
                    CapDrink11 -= 1
                    SalesRevenue += Drink11Price
                    ChangeRevenue += changeNeeded

                    UpdateCoinCapacity()
                    ClearTempCoins()

                    MsgBox("Please take your drink")
                    pbxDisplay.Image = My.Resources.vendingimage
                Else
                    ClearTempCoins()
                End If
                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                'Change Available
            Else
                pbxDisplay.Image = My.Resources.San_pell_orange1
                Drink11Sold += 1
                CapDrink11 -= 1
                SalesRevenue += Drink11Price

                UpdateCoinCapacity()
                ClearTempCoins()

                BreakDownChange()
                frmChange.Show()
                ClearChangePerCoins()

                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                MsgBox("Please take your drink")
                pbxDisplay.Image = My.Resources.vendingimage
            End If
        End If
    End Sub

    'Tango
    Private Sub btnTango_Click(sender As Object, e As EventArgs) Handles btnTango.Click
        'Insufficient Funds
        If CreditTotal < Drink12Price Then
            MsgBox("Insufficient Funds")
        End If

        'Exact Change
        If CreditTotal = Drink12Price Then
            MsgBox("Thank you for your order. Please Enjoy")
            pbxDisplay.Image = My.Resources.Tango_can1
            Drink12Sold += 1
            CapDrink12 -= 1
            SalesRevenue += Drink12Price

            UpdateCoinCapacity()
            ClearTempCoins()

            CreditTotal = 0
            lblCreditTotal.Text = FormatCurrency(0.0)

            MsgBox("Please take your drink")
            pbxDisplay.Image = My.Resources.vendingimage
        End If

        'More than Price
        If CreditTotal > Drink12Price Then
            changeNeeded = CreditTotal - Drink12Price
            CalcMoneyAvailable()
            MsgBox("Thank you for your order. We're Calculating your change")

            'No Change
            If changeNeeded > moneyAvailable Then
                frmNoChange.Show()

                If forfeitChange = True Then
                    pbxDisplay.Image = My.Resources.Tango_can1
                    Drink12Sold += 1
                    CapDrink12 -= 1
                    SalesRevenue += Drink12Price
                    ChangeRevenue += changeNeeded

                    UpdateCoinCapacity()
                    ClearTempCoins()

                    MsgBox("Please take your drink")
                    pbxDisplay.Image = My.Resources.vendingimage
                Else
                    ClearTempCoins()
                End If
                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                'Change Available
            Else
                pbxDisplay.Image = My.Resources.Tango_can1
                Drink12Sold += 1
                CapDrink12 -= 1
                SalesRevenue += Drink12Price

                UpdateCoinCapacity()
                ClearTempCoins()

                BreakDownChange()
                frmChange.Show()
                ClearChangePerCoins()

                CreditTotal = 0
                lblCreditTotal.Text = FormatCurrency(0.0)

                MsgBox("Please take your drink")
                pbxDisplay.Image = My.Resources.vendingimage
            End If
        End If
    End Sub


    '********************************Help Button***************************************
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        frmHelp.Show()
    End Sub


    '****************************Adminstrator Login Button******************************
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        capacityReader.Close()
        priceReader.Close()
        drinksCapacityReader.Close()
        unitsSoldReader.Close()
        tempCoinsReader.Close()
        ChangePerCoinReader.Close()

        frmLogin.Show()
        Me.Hide()
    End Sub


    '********************************Return Button***************************************
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        MsgBox("Transaction Cancelled. Have a nice day.")
        lblCreditTotal.Text = FormatCurrency(0.0)
        ClearTempCoins()
    End Sub

End Class
