Imports System.Data.OleDb

Public Class frmLogin
    Dim match As Boolean = False
    Dim UserType As String


    '******************** Populate Logins Table in DataSet Function *************************
    Private Sub populateLogins()
        Dim LogQuery As String = "SELECT * FROM Users"
        LBAdapter.SelectCommand = New OleDbCommand(LogQuery, LBConn)
        LBAdapter.Fill(dsLB, "Logins")

    End Sub

    '**********************Validate Login Function***************************
    Private Sub validateLogin()
        Try
            For i = 0 To dsLB.Tables("Logins").Rows.Count - 1
                If txtUsername.Text = dsLB.Tables("Logins").Rows(i).Item(0) And txtPassword.Text = dsLB.Tables("Logins").Rows(i).Item(1) And UserType.ToUpper() = dsLB.Tables("Logins").Rows(i).Item(2) Then
                    match = True
                    passIndex = i
                End If
            Next
        Catch ex As Exception
        End Try

        If match = True Then
                MsgBox("Welcome to the Digital Logbook", , "Login Success")
                currentUser = txtUsername.Text
                txtUsername.Clear()
                txtPassword.Clear()
            Else
                MsgBox("Invalid Credentials, Please re-enter", , "Login Fail")
                txtUsername.Focus()
            End If



    End Sub


    '********************** On Login Form Load ***************************
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBConn.Open()
        cmbUser.SelectedIndex = 0
    End Sub


    '********************** Login Button Pressed ***************************
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        populateLogins()

        '------------------Teacher Selected------------------
        If cmbUser.SelectedIndex = 0 Then
            UserType = "TR"
            validateLogin()
            If match = True Then
                frmViewEntries.Show()
                Me.Hide()
            End If

            '--------------Technician Selected----------------
        ElseIf cmbUser.SelectedIndex = 1 Then
            UserType = "TN"
            validateLogin()
            If match = True Then
                frmTechnician.Show()
                Me.Hide()
            End If

            '--------------Administrator Selected--------------
        Else
            UserType = "AR"
            validateLogin()
            If match = True Then
                frmAdminStart.Show()
                Me.Hide()
            End If
        End If

    End Sub


    '********************** Password Change Selected ***************************
    Private Sub btnPassChange_Click(sender As Object, e As EventArgs) Handles btnPassChange.Click
        populateLogins()

        For i = 0 To dsLB.Tables("Logins").Rows.Count - 1
            Try
                If txtUsername.Text = dsLB.Tables("Logins").Rows(i).Item(0) And txtPassword.Text = dsLB.Tables("Logins").Rows(i).Item(1) Then
                    match = True
                    passIndex = i
                End If
            Catch ex As Exception
            End Try
        Next

        If match = True Then
            MsgBox("Welcome to the Digital Logbook", , "Login Success")
            currentUser = txtUsername.Text
            frmPassChange.Show()
            txtUsername.Clear()
            txtPassword.Clear()
            Me.Hide()
        Else
            MsgBox("Invalid Credentials, Please re-enter", , "Login Fail")
            txtUsername.Focus()
        End If
    End Sub




    '********************** Exit ***************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            dsLB.Tables("Logins").Rows.Clear()
        Catch ex As Exception
        End Try

        LBConn.Close()
        Me.Close()
    End Sub

End Class
