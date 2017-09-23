Imports System.IO

Public Class frmManager

    Private Sub frmManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDrink.SelectedIndex = 0
        cmbFunction.SelectedIndex = 0
        cmbDrink2.SelectedIndex = 0
        cmbCoin.SelectedIndex = 0

        'Current Drink Stock Values
        txtCoke.Text = CapDrink1
        txtDietCoke.Text = CapDrink2
        txt7up.Text = CapDrink3
        txt7upFree.Text = CapDrink4
        txtFanta.Text = CapDrink5
        txtLilt.Text = CapDrink6
        txtPepsi.Text = CapDrink7
        txtPepsiMax.Text = CapDrink8
        txtDrPepper.Text = CapDrink9
        txtSprite.Text = CapDrink10
        txtSanPell.Text = CapDrink11
        txtTango.Text = CapDrink12

        'Current Coin Stock Values
        txt2euro.Text = Cap2euro
        txt1euro.Text = Cap1euro
        txt50cent.Text = Cap50cent
        txt20cent.Text = Cap20cent
        txt10cent.Text = CapDrink10
        txt5cent.Text = Cap5cent

    End Sub

    'Entering Drink Quantity
    Private Sub txtDrinkQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDrinkQuantity.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Convert.ToInt16(e.KeyChar)) Then
            e.Handled = True
            MsgBox("Invalid Input")
            txtDrinkQuantity.Clear()
            txtDrinkQuantity.Focus()
        End If
    End Sub


    'Add Drinks
    Private Sub btnUpdateDrink_Click(sender As Object, e As EventArgs) Handles btnUpdateDrink.Click
        'Coke
        If cmbDrink.SelectedIndex = 0 Then
            If CapDrink1 + Convert.ToInt16(txtDrinkQuantity.Text) > 20 Then
                MsgBox("Cannot Stock over 20 Units of 1 Drink")
                txtDrinkQuantity.Clear()
                txtDrinkQuantity.Focus()
            Else
                CapDrink1 += Convert.ToInt16(txtDrinkQuantity.Text)
                txtCoke.Text = CapDrink1
                txtDrinkQuantity.Clear()
            End If
            'Diet Coke
        ElseIf cmbDrink.SelectedIndex = 1 Then
            If CapDrink2 + Convert.ToInt16(txtDrinkQuantity.Text) > 20 Then
                MsgBox("Cannot Stock over 20 Units of 1 Drink")
                txtDrinkQuantity.Clear()
                txtDrinkQuantity.Focus()
            Else
                CapDrink2 += Convert.ToInt16(txtDrinkQuantity.Text)
                txtDietCoke.Text = CapDrink2
                txtDrinkQuantity.Clear()
            End If
            '7up
        ElseIf cmbDrink.SelectedIndex = 2 Then
            If CapDrink3 + Convert.ToInt16(txtDrinkQuantity.Text) > 20 Then
                MsgBox("Cannot Stock over 20 Units of 1 Drink")
                txtDrinkQuantity.Clear()
                txtDrinkQuantity.Focus()
            Else
                CapDrink3 += Convert.ToInt16(txtDrinkQuantity.Text)
                txt7up.Text = CapDrink3
                txtDrinkQuantity.Clear()
            End If
            '7up Free
        ElseIf cmbDrink.SelectedIndex = 3 Then
            If CapDrink4 + txtDrinkQuantity.Text > 20 Then
                MsgBox("Cannot Stock over 20 Units of 1 Drink")
                txtDrinkQuantity.Clear()
                txtDrinkQuantity.Focus()
            Else
                CapDrink4 += Convert.ToInt16(txtDrinkQuantity.Text)
                txt7upFree.Text = CapDrink4
                txtDrinkQuantity.Clear()
            End If
            'Fanta
        ElseIf cmbDrink.SelectedIndex = 4 Then
            If CapDrink5 + Convert.ToInt16(txtDrinkQuantity.Text) > 20 Then
                MsgBox("Cannot Stock over 20 Units of 1 Drink")
                txtDrinkQuantity.Clear()
                txtDrinkQuantity.Focus()
            Else
                CapDrink5 += Convert.ToInt16(txtDrinkQuantity.Text)
                txtFanta.Text = CapDrink5
                txtDrinkQuantity.Clear()
            End If
            'Lilt
        ElseIf cmbDrink.SelectedIndex = 5 Then
            If CapDrink6 + Convert.ToInt16(txtDrinkQuantity.Text) > 20 Then
                MsgBox("Cannot Stock over 20 Units of 1 Drink")
                txtDrinkQuantity.Clear()
                txtDrinkQuantity.Focus()
            Else
                CapDrink6 += Convert.ToInt16(txtDrinkQuantity.Text)
                txtLilt.Text = CapDrink6
                txtDrinkQuantity.Clear()
            End If
            'Pepsi
        ElseIf cmbDrink.SelectedIndex = 6 Then
            If CapDrink7 + Convert.ToInt16(txtDrinkQuantity.Text) > 20 Then
                MsgBox("Cannot Stock over 20 Units of 1 Drink")
                txtDrinkQuantity.Clear()
                txtDrinkQuantity.Focus()
            Else
                CapDrink7 += Convert.ToInt16(txtDrinkQuantity.Text)
                txtPepsi.Text = CapDrink7
                txtDrinkQuantity.Clear()
            End If
            'Pepsi Max
        ElseIf cmbDrink.SelectedIndex = 7 Then
            If CapDrink8 + Convert.ToInt16(txtDrinkQuantity.Text) > 20 Then
                MsgBox("Cannot Stock over 20 Units of 1 Drink")
                txtDrinkQuantity.Clear()
                txtDrinkQuantity.Focus()
            Else
                CapDrink8 += Convert.ToInt16(txtDrinkQuantity.Text)
                txtPepsiMax.Text = CapDrink8
                txtDrinkQuantity.Clear()
            End If
            'Dr Pepper
        ElseIf cmbDrink.SelectedIndex = 8 Then
            If CapDrink9 + Convert.ToInt16(txtDrinkQuantity.Text) > 20 Then
                MsgBox("Cannot Stock over 20 Units of 1 Drink")
                txtDrinkQuantity.Clear()
                txtDrinkQuantity.Focus()
            Else
                CapDrink9 += Convert.ToInt16(txtDrinkQuantity.Text)
                txtDrPepper.Text = CapDrink9
                txtDrinkQuantity.Clear()
            End If
            'Sprite
        ElseIf cmbDrink.SelectedIndex = 9 Then
            If CapDrink10 + Convert.ToInt16(txtDrinkQuantity.Text) > 20 Then
                MsgBox("Cannot Stock over 20 Units of 1 Drink")
                txtDrinkQuantity.Clear()
                txtDrinkQuantity.Focus()
            Else
                CapDrink10 += Convert.ToInt16(txtDrinkQuantity.Text)
                txtSprite.Text = CapDrink10
                txtDrinkQuantity.Clear()
            End If
            'San Pellegrino
        ElseIf cmbDrink.SelectedIndex = 10 Then
            If CapDrink11 + Convert.ToInt16(txtDrinkQuantity.Text) > 20 Then
                MsgBox("Cannot Stock over 20 Units of 1 Drink")
                txtDrinkQuantity.Clear()
                txtDrinkQuantity.Focus()
            Else
                CapDrink11 += Convert.ToInt16(txtDrinkQuantity.Text)
                txtSanPell.Text = CapDrink11
                txtDrinkQuantity.Clear()
            End If
            'Tango
        ElseIf cmbDrink.SelectedIndex = 11 Then
            If CapDrink12 + Convert.ToInt16(txtDrinkQuantity.Text) > 20 Then
                MsgBox("Cannot Stock over 20 Units of 1 Drink")
                txtDrinkQuantity.Clear()
                txtDrinkQuantity.Focus()
            Else
                CapDrink12 += Convert.ToInt16(txtDrinkQuantity.Text)
                txtTango.Text = CapDrink12
                txtDrinkQuantity.Clear()
            End If
        End If

        'Update Drinks Capacity File
        Using DrinksCapWriter As StreamWriter = New StreamWriter("..\..\Resources\DrinksCapacity.txt")
            DrinksCapWriter.WriteLine(CapDrink1)
            DrinksCapWriter.WriteLine(CapDrink2)
            DrinksCapWriter.WriteLine(CapDrink3)
            DrinksCapWriter.WriteLine(CapDrink4)
            DrinksCapWriter.WriteLine(CapDrink5)
            DrinksCapWriter.WriteLine(CapDrink6)
            DrinksCapWriter.WriteLine(CapDrink7)
            DrinksCapWriter.WriteLine(CapDrink8)
            DrinksCapWriter.WriteLine(CapDrink9)
            DrinksCapWriter.WriteLine(CapDrink10)
            DrinksCapWriter.WriteLine(CapDrink11)
            DrinksCapWriter.WriteLine(CapDrink12)

            DrinksCapWriter.Close()
        End Using
    End Sub


    'Coin Quantity 
    Private Sub txtCoinQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCoinQuantity.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Convert.ToInt16(e.KeyChar)) Then
            e.Handled = True
            MsgBox("Invalid Input")
            txtCoinQuantity.Clear()
            txtCoinQuantity.Focus()
        End If
    End Sub

    'Updating Coin Stock
    Private Sub btnUpdateCoin_Click(sender As Object, e As EventArgs) Handles btnUpdateCoin.Click
        'Add Coins
        If cmbFunction.SelectedIndex = 0 Then
            '2 euro
            If cmbCoin.SelectedIndex = 0 Then
                If Cap2euro + Convert.ToInt16(txtCoinQuantity.Text) > 450 Then
                    MsgBox("Additional Space Needed for Transactions")
                    txtCoinQuantity.Clear()
                    txtCoinQuantity.Focus()
                Else
                    Cap2euro += Convert.ToInt16(txtCoinQuantity.Text)
                    txt2euro.Text = Cap2euro
                    txtCoinQuantity.Clear()
                End If
                '1 euro
            ElseIf cmbCoin.SelectedIndex = 1 Then
                If Cap1euro + Convert.ToInt16(txtCoinQuantity.Text) > 250 Then
                    MsgBox("Additional Space Needed for Transactions")
                    txtCoinQuantity.Clear()
                    txtCoinQuantity.Focus()
                Else
                    Cap1euro += Convert.ToInt16(txtCoinQuantity.Text)
                    txt1euro.Text = Cap1euro
                    txtCoinQuantity.Clear()
                End If
                '50 cent
            ElseIf cmbCoin.SelectedIndex = 2 Then
                If Cap50cent + Convert.ToInt16(txtCoinQuantity.Text) > 150 Then
                    MsgBox("Additional Space Needed for Transactions")
                    txtCoinQuantity.Clear()
                    txtCoinQuantity.Focus()
                Else
                    Cap50cent += Convert.ToInt16(txtCoinQuantity.Text)
                    txt50cent.Text = Cap50cent
                    txtCoinQuantity.Clear()
                End If
                '20 cent
            ElseIf cmbCoin.SelectedIndex = 3 Then
                If Cap20cent + Convert.ToInt16(txtCoinQuantity.Text) > 150 Then
                    MsgBox("Additional Space Needed for Transactions")
                    txtCoinQuantity.Clear()
                    txtCoinQuantity.Focus()
                Else
                    Cap20cent += Convert.ToInt16(txtCoinQuantity.Text)
                    txt20cent.Text = Cap20cent
                    txtCoinQuantity.Clear()
                End If
                '10 cent
            ElseIf cmbCoin.SelectedIndex = 4 Then
                If Cap10cent + Convert.ToInt16(txtCoinQuantity.Text) > 150 Then
                    MsgBox("Additional Space Needed for Transactions")
                    txtCoinQuantity.Clear()
                    txtCoinQuantity.Focus()
                Else
                    Cap10cent += Convert.ToInt16(txtCoinQuantity.Text)
                    txt10cent.Text = Cap10cent
                    txtCoinQuantity.Clear()
                End If
                '5 cent
            ElseIf cmbCoin.SelectedIndex = 5
                If Cap5cent + Convert.ToInt16(txtCoinQuantity.Text) > 150 Then
                    MsgBox("Additional Space Needed for Transactions")
                    txtCoinQuantity.Clear()
                    txtCoinQuantity.Focus()
                Else
                    Cap5cent += Convert.ToInt16(txtCoinQuantity.Text)
                    txt5cent.Text = Cap5cent
                    txtCoinQuantity.Clear()
                End If
            End If

            'Remove Coins
        ElseIf cmbFunction.SelectedIndex = 1 Then
            '2 euro
            If cmbCoin.SelectedIndex = 0 Then
                If Cap2euro - Convert.ToInt16(txtCoinQuantity.Text) < 50 Then
                    MsgBox("Additional Coins Needed for Transactions")
                    txtCoinQuantity.Clear()
                    txtCoinQuantity.Focus()
                Else
                    Cap2euro -= Convert.ToInt16(txtCoinQuantity.Text)
                    txt2euro.Text = Cap2euro
                    AmountRemoved += (Convert.ToInt16(txtCoinQuantity.Text) * 2)
                    txtCoinQuantity.Clear()
                End If
                '1 euro
            ElseIf cmbCoin.SelectedIndex = 1 Then
                If Cap1euro - Convert.ToInt16(txtCoinQuantity.Text) < 50 Then
                    MsgBox("Additional Coins Needed for Transactions")
                    txtCoinQuantity.Clear()
                    txtCoinQuantity.Focus()
                Else
                    Cap1euro -= Convert.ToInt16(txtCoinQuantity.Text)
                    txt1euro.Text = Cap1euro
                    AmountRemoved += (Convert.ToInt16(txtCoinQuantity.Text) * 1)
                    txtCoinQuantity.Clear()
                End If
                '50 cent
            ElseIf cmbCoin.SelectedIndex = 2 Then
                If Cap50cent - Convert.ToInt16(txtCoinQuantity.Text) < 50 Then
                    MsgBox("Additional Coins Needed for Transactions")
                    txtCoinQuantity.Clear()
                    txtCoinQuantity.Focus()
                Else
                    Cap50cent -= Convert.ToInt16(txtCoinQuantity.Text)
                    txt50cent.Text = Cap50cent
                    AmountRemoved += (Convert.ToInt16(txtCoinQuantity.Text) * 0.5)
                    txtCoinQuantity.Clear()
                End If
                '20 cent
            ElseIf cmbCoin.SelectedIndex = 3 Then
                If Cap20cent - Convert.ToInt16(txtCoinQuantity.Text) < 50 Then
                    MsgBox("Additional Coins Needed for Transactions")
                    txtCoinQuantity.Clear()
                    txtCoinQuantity.Focus()
                Else
                    Cap20cent -= Convert.ToInt16(txtCoinQuantity.Text)
                    txt20cent.Text = Cap20cent
                    AmountRemoved += (Convert.ToInt16(txtCoinQuantity.Text) * 0.2)
                    txtCoinQuantity.Clear()
                End If
                '10 cent
            ElseIf cmbCoin.SelectedIndex = 4 Then
                If Cap10cent - Convert.ToInt16(txtCoinQuantity.Text) < 50 Then
                    MsgBox("Additional Coins Needed for Transactions")
                    txtCoinQuantity.Clear()
                    txtCoinQuantity.Focus()
                Else
                    Cap10cent -= Convert.ToInt16(txtCoinQuantity.Text)
                    txt10cent.Text = Cap10cent
                    AmountRemoved += (Convert.ToInt16(txtCoinQuantity.Text) * 0.1)
                    txtCoinQuantity.Clear()
                End If
                '5 cent
            ElseIf cmbCoin.SelectedIndex = 5
                If Cap5cent - Convert.ToInt16(txtCoinQuantity.Text) < 50 Then
                    MsgBox("Additional Coins Needed for Transactions")
                    txtCoinQuantity.Clear()
                    txtCoinQuantity.Focus()
                Else
                    Cap5cent -= Convert.ToInt16(txtCoinQuantity.Text)
                    txt5cent.Text = Cap5cent
                    AmountRemoved += (Convert.ToInt16(txtCoinQuantity.Text) * 0.05)
                    txtCoinQuantity.Clear()
                End If

            End If
        End If

        'Update Coin Capacity File
        Using CoinCapWriter As StreamWriter = New StreamWriter("..\..\Resources\CoinCapacity.txt")
            CoinCapWriter.WriteLine(Cap2euro)
            CoinCapWriter.WriteLine(Cap1euro)
            CoinCapWriter.WriteLine(Cap50cent)
            CoinCapWriter.WriteLine(Cap20cent)
            CoinCapWriter.WriteLine(Cap10cent)
            CoinCapWriter.WriteLine(Cap5cent)

            CoinCapWriter.Close()
        End Using
    End Sub

    'Select Drink for re-pricing
    Private Sub cmbDrink2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDrink2.SelectedIndexChanged
        'Coke
        If cmbDrink2.SelectedIndex = 0 Then
            txtCurrentCost.Text = FormatCurrency(Drink1Price)
            'Diet Coke
        ElseIf cmbDrink2.SelectedIndex = 1 Then
            txtCurrentCost.Text = FormatCurrency(Drink2Price)
            '7up
        ElseIf cmbDrink2.SelectedIndex = 2 Then
            txtCurrentCost.Text = FormatCurrency(Drink3Price)
            '7up Free
        ElseIf cmbDrink2.SelectedIndex = 3 Then
            txtCurrentCost.Text = FormatCurrency(Drink4Price)
            'Fanta
        ElseIf cmbDrink2.SelectedIndex = 4 Then
            txtCurrentCost.Text = FormatCurrency(Drink5Price)
            'Lilt
        ElseIf cmbDrink2.SelectedIndex = 5 Then
            txtCurrentCost.Text = FormatCurrency(Drink6Price)
            'Pepsi
        ElseIf cmbDrink2.SelectedIndex = 6 Then
            txtCurrentCost.Text = FormatCurrency(Drink7Price)
            'Pepsi Max
        ElseIf cmbDrink2.SelectedIndex = 7 Then
            txtCurrentCost.Text = FormatCurrency(Drink8Price)
            'Dr Pepper
        ElseIf cmbDrink2.SelectedIndex = 8 Then
            txtCurrentCost.Text = FormatCurrency(Drink9Price)
            'Sprite
        ElseIf cmbDrink2.SelectedIndex = 9 Then
            txtCurrentCost.Text = FormatCurrency(Drink10Price)
            'San Pellegrino
        ElseIf cmbDrink2.SelectedIndex = 10 Then
            txtCurrentCost.Text = FormatCurrency(Drink11Price)
            'Tango
        ElseIf cmbDrink2.SelectedIndex = 11 Then
            txtCurrentCost.Text = FormatCurrency(Drink12Price)

        End If
    End Sub

    'Entering New Price of Drink
    Private Sub txtNewCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewCost.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Convert.ToInt16(e.KeyChar)) Then
            e.Handled = True
            MsgBox("Invalid Input")
            txtNewCost.Clear()
            txtNewCost.Focus()
        End If
    End Sub

    'Update Drink Price
    Private Sub btnUpdatePrice_Click(sender As Object, e As EventArgs) Handles btnUpdatePrice.Click
        'Coke
        If cmbDrink2.SelectedIndex = 0 Then
            Drink1Price = Convert.ToSingle(txtNewCost.Text)
            txtNewCost.Clear()
            'Diet Coke
        ElseIf cmbDrink2.SelectedIndex = 1 Then
            Drink2Price = Convert.ToSingle(txtNewCost.Text)
            txtNewCost.Clear()
            '7up
        ElseIf cmbDrink2.SelectedIndex = 2 Then
            Drink3Price = Convert.ToSingle(txtNewCost.Text)
            txtNewCost.Clear()
            '7up Free
        ElseIf cmbDrink2.SelectedIndex = 3 Then
            Drink4Price = Convert.ToSingle(txtNewCost.Text)
            txtNewCost.Clear()
            'Fanta
        ElseIf cmbDrink2.SelectedIndex = 4 Then
            Drink5Price = Convert.ToSingle(txtNewCost.Text)
            txtNewCost.Clear()
            'Lilt
        ElseIf cmbDrink2.SelectedIndex = 5 Then
            Drink6Price = Convert.ToSingle(txtNewCost.Text)
            txtNewCost.Clear()
            'Pepsi
        ElseIf cmbDrink2.SelectedIndex = 6 Then
            Drink7Price = Convert.ToSingle(txtNewCost.Text)
            txtNewCost.Clear()
            'Pepsi Max
        ElseIf cmbDrink2.SelectedIndex = 7 Then
            Drink8Price = Convert.ToSingle(txtNewCost.Text)
            txtNewCost.Clear()
            'Dr Pepper
        ElseIf cmbDrink2.SelectedIndex = 8 Then
            Drink9Price = Convert.ToSingle(txtNewCost.Text)
            txtNewCost.Clear()
            'Sprite
        ElseIf cmbDrink2.SelectedIndex = 9 Then
            Drink10Price = Convert.ToSingle(txtNewCost.Text)
            txtNewCost.Clear()
            'San Pellegrino
        ElseIf cmbDrink2.SelectedIndex = 10 Then
            Drink11Price = Convert.ToSingle(txtNewCost.Text)
            txtNewCost.Clear()
            'Tango
        ElseIf cmbDrink2.SelectedIndex = 11 Then
            Drink12Price = Convert.ToSingle(txtNewCost.Text)
            txtNewCost.Clear()
        End If

        'Update Drinks Capacity File
        Using DrinksPriceWriter As StreamWriter = New StreamWriter("..\..\Resources\DrinksPrices.txt")
            DrinksPriceWriter.WriteLine(Drink1Price)
            DrinksPriceWriter.WriteLine(Drink2Price)
            DrinksPriceWriter.WriteLine(Drink3Price)
            DrinksPriceWriter.WriteLine(Drink4Price)
            DrinksPriceWriter.WriteLine(Drink5Price)
            DrinksPriceWriter.WriteLine(Drink6Price)
            DrinksPriceWriter.WriteLine(Drink7Price)
            DrinksPriceWriter.WriteLine(Drink8Price)
            DrinksPriceWriter.WriteLine(Drink9Price)
            DrinksPriceWriter.WriteLine(Drink10Price)
            DrinksPriceWriter.WriteLine(Drink11Price)
            DrinksPriceWriter.WriteLine(Drink12Price)

            DrinksPriceWriter.Close()
        End Using
    End Sub

    'Print Report
    Private Sub btnPrintReport_Click(sender As Object, e As EventArgs) Handles btnPrintReport.Click
        frmReport.Show()
        Me.Hide()
    End Sub

    'Exit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

End Class