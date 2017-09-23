Public Class frmReport
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrentDate.Text = Date.Today
        lblSR.Text = FormatCurrency(SalesRevenue)
        lblCR.Text = FormatCurrency(ChangeRevenue)
        lblAmountRemoved.Text = FormatCurrency(AmountRemoved)

        txtCoke.Text = Drink1Sold
        txtDietCoke.Text = Drink2Sold
        txt7up.Text = Drink3Sold
        txt7upFree.Text = Drink4Sold
        txtFanta.Text = Drink5Sold
        txtLilt.Text = Drink6Sold
        txtPepsi.Text = Drink7Sold
        txtPepsiMax.Text = Drink8Sold
        txtDrPepper.Text = Drink9Sold
        txtSprite.Text = Drink10Sold
        txtSanPell.Text = Drink11Sold
        txtTango.Text = Drink12Sold

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Clearing Variables
        SalesRevenue = 0
        ChangeRevenue = 0
        AmountRemoved = 0
        frmManager.Show()
        Me.Hide()
    End Sub
End Class