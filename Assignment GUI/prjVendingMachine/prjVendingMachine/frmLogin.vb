Imports System.IO

Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = "John"
        txtPassword.Text = "Admin1"
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Using loginReader As StreamReader = New StreamReader("..\..\Resources\AdminLogins.txt")
            Dim match As Boolean = False
            Do
                Dim userName As String = loginReader.ReadLine, password As String = loginReader.ReadLine

                If txtUsername.Text = userName And txtPassword.Text = password Then
                    match = True
                Else
                    match = False
                End If
            Loop Until match Or loginReader.EndOfStream

            If match Then
                MsgBox("Access granted")
                frmManager.Show()
                Me.Close()
            Else
                MsgBox("Incorrect Credentials")
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()
            End If
            loginReader.Close()
        End Using
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Form1.Show()
        Me.Close()
    End Sub

End Class
