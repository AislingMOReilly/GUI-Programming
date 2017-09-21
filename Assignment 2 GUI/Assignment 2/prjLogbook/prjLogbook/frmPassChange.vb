Imports System.Data.OleDb

Public Class frmPassChange

    '****************** On Password Change Form Load ***********************
    Private Sub frmPassChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = currentUser
    End Sub


    '*************** Change Password Button Pressed **********************
    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click

        If txtOldPass.Text = dsLB.Tables("Logins").Rows(passIndex).Item(1) And txtNewPass.Text = txtConfirm.Text Then

            '-------------------- Update password in DataSource -------------------
            Dim UpdateQuery As String = "UPDATE Users SET [Password] = '" & txtConfirm.Text & "' WHERE [Username] = '" & lblName.Text & "'"
            Dim cmdUpdatePassword As OleDbCommand = New OleDbCommand(UpdateQuery, LBConn)
            cmdUpdatePassword.ExecuteNonQuery()

            MsgBox("Your password is now changed", , "Password Change Success")

        Else
            MsgBox("Invalid password. Please re-enter", , "Password Change Failure")
            txtConfirm.Clear()
            txtOldPass.Focus()
        End If

    End Sub

    '*************** Exit *******************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Restart()
        Me.Close()
    End Sub

End Class