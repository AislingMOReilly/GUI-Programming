Imports System.Data.OleDb

Public Class frmAdminUsers

    '*********************** On Edit Users Form Load ***************************
    Private Sub frmAdminUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '-----------------------Populate Users table in DataSet-------------------------------
        Dim UserNameQuery As String = "SELECT * FROM Users"
        LBAdapter.SelectCommand = New OleDbCommand(UserNameQuery, LBConn)

        cmbSelFunc.SelectedIndex = 0
    End Sub


    '************************ Select User Function ***************************
    Private Sub cmbSelFunc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelFunc.SelectedIndexChanged
        Try
            dsLB.Tables("UserDetails").Rows.Clear()
            cmbSelUser.Items.Clear()
            txtUsername.Text = ""
            txtPass.Text = ""
        Catch ex As Exception
        End Try

        LBAdapter.Fill(dsLB, "UserDetails")

        '--------------------------Populate User Name Combo Box-----------------------------
        Try
            For i = 0 To dsLB.Tables("UserDetails").Rows.Count - 1
                cmbSelUser.Items.Add(dsLB.Tables("UserDetails").Rows(i).Item(0))
            Next
        Catch ex As Exception
        End Try


        '---------Add-------------
        If cmbSelFunc.SelectedIndex = 0 Then
            cmbSelUser.Visible = False
            txtUsername.Visible = True
            txtPass.Visible = True
            cmbUserType.Visible = True
            txtUsername.Focus()
            '---------Remove-------------
        Else
            cmbSelUser.Visible = True
            txtUsername.Visible = False
            txtPass.Visible = False
            cmbUserType.Visible = False
        End If

    End Sub


    '************************ Update User Details ***************************
    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click

        '---------------Add----------------
        If cmbSelFunc.SelectedIndex = 0 Then

            Dim insertUser As String = "INSERT INTO Users VALUES ('" & txtUsername.Text & "', '" & txtPass.Text & "', '" & cmbUserType.Text & "')"

            Dim cmdInsertUser As OleDbCommand = New OleDbCommand(insertUser, LBConn)
            cmdInsertUser.ExecuteNonQuery()
            MsgBox(txtUsername.Text + " has been added to the database.")
            txtUsername.Text = ""
            txtPass.Text = ""

            '---------------Remove---------------
        Else
            '---Remove User from Database---
            Dim deleteUserquery As String = "DELETE FROM [Users] WHERE [Username] = '" & cmbSelUser.Text & "'"
            Dim cmdUserDelete As OleDbCommand = New OleDbCommand(deleteUserquery, LBConn)

            Dim answer = MsgBox("Delete User?", vbYesNo + vbQuestion, "Confirm Delete?")
            If answer = vbYes Then
                cmdUserDelete.ExecuteNonQuery()
                MsgBox("User Successfully Deleted")
            Else
                MsgBox("Delete cancelled")
            End If
        End If


        '---Update Dataset Tables After Delete---
        Try
            dsLB.Tables("UserDetails").Rows.Clear()
            LBAdapter.Fill(dsLB, "UserDetails")
        Catch ex As Exception
        End Try

    End Sub


    '************************ Exit ***************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmAdminStart.Show()
    End Sub

End Class