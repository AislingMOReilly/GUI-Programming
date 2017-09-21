Public Class frmChange
    Private Sub frmChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl2euro.Text = Convert.ToInt16(Change2euro)
        lbl1euro.Text = Convert.ToInt16(Change1euro)
        lbl50cent.Text = Convert.ToInt16(Change50cent)
        lbl20cent.Text = Convert.ToInt16(Change20cent)
        lbl10cent.Text = Convert.ToInt16(Change10cent)
        lbl5cent.Text = Convert.ToInt16(Change5cent)

        lblTotalChange.Text = FormatCurrency(totalChange)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class