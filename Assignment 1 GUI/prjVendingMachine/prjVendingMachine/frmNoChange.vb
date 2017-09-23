Public Class frmNoChange

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        MsgBox("Thank you for your order. Please Enjoy")
        forfeitChange = True
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MsgBox("Thank you. Have a nice day.")
        Me.Hide()
    End Sub
End Class