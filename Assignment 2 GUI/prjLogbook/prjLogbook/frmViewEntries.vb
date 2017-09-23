Imports System.Data.OleDb

Public Class frmViewEntries

    '********************** Clear DataSet Tables Function ***************************
    Private Sub clearTables()
        Try
            dsLB.Tables("AllFaults").Rows.Clear()
            dsLB.Tables("Resolved").Rows.Clear()
            dsLB.Tables("Unresolved").Rows.Clear()
        Catch ex As Exception
        End Try

    End Sub


    '*********************** On View Entries Form Load ***************************
    Private Sub frmViewEntries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----------------Populate tables in dataset--------------------

        '---View All---
        'Added Redundant TechNote field to Resolved Table
        Dim AllQuery As String = "(SELECT * FROM Resolved) UNION ALL (SELECT * FROM FaultBook)"

        LBAdapter.SelectCommand = New OleDbCommand(AllQuery, LBConn)
        LBAdapter.Fill(dsLB, "AllFaults")


        '---View Unresolved---
        Dim UnResQuery As String = "SELECT * FROM FaultBook"

        LBAdapter.SelectCommand = New OleDbCommand(UnResQuery, LBConn)
        LBAdapter.Fill(dsLB, "Unresolved")


        '---View Resolved---
        Dim ResQuery As String = "SELECT * FROM Resolved"

        LBAdapter.SelectCommand = New OleDbCommand(ResQuery, LBConn)
        LBAdapter.Fill(dsLB, "Resolved")


        cmbView.SelectedIndex = 0
    End Sub



    '************************ View combo box changed ****************************
    Private Sub cmbView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbView.SelectedIndexChanged

        '*** View All **
        If cmbView.SelectedIndex = 0 Then
            grdView.DataSource = dsLB.Tables("AllFaults")
            '** View Unresolved **
        ElseIf cmbView.SelectedIndex = 1 Then
            grdView.DataSource = dsLB.Tables("Unresolved")
            '** View Resolved **
        Else
            grdView.DataSource = dsLB.Tables("Resolved")
        End If

    End Sub


    '********************** Log Fault Button Pressed ***************************         
    Private Sub btnLogFault_Click(sender As Object, e As EventArgs) Handles btnLogFault.Click
        clearTables()
        frmLogFault.Show()
        Me.Close()
    End Sub

    '********************** Exit ***************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        clearTables()
        Application.Restart()
        Me.Close()
    End Sub

End Class