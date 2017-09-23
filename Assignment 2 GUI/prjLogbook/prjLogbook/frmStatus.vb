Imports System.Data.OleDb

Public Class frmStatus

    '************************ On Update Status Form Load ****************************
    Private Sub frmStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '-----------Populate Unresolved table in Dataset--------------
        Dim UnResQuery As String = "SELECT * FROM FaultBook"

        LBAdapter.SelectCommand = New OleDbCommand(UnResQuery, LBConn)
        LBAdapter.Fill(dsLB, "Unresolved")

        '----------------Populate Computers table in DataSet-----------------
        Dim CompNameQuery As String = "SELECT * FROM Computers"
        LBAdapter.SelectCommand = New OleDbCommand(CompNameQuery, LBConn)
        LBAdapter.Fill(dsLB, "Computers")

        '----------------Populate Select Computer Combo Box------------------
        For i = 0 To dsLB.Tables("Unresolved").Rows.Count - 1
            For j = 0 To dsLB.Tables("Computers").Rows.Count - 1
                If dsLB.Tables("Computers").Rows(j).Item(1) = dsLB.Tables("Unresolved").Rows(i).Item(3) Then
                    cmbSelComp.Items.Add(dsLB.Tables("Computers").Rows(j).Item(1))
                End If
            Next
        Next
    End Sub


    '************************ Select Computer combo box changed ****************************
    Private Sub cmbSelComp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelComp.SelectedIndexChanged
        lblCurrentStatus.Text = ""
        txtNewStatus.Clear()

        '---------------Populate Current Status of Computer-------------------
        For i = 0 To dsLB.Tables("Unresolved").Rows.Count - 1
            If cmbSelComp.Text = dsLB.Tables("Unresolved").Rows(i).Item(3) Then
                lblCurrentStatus.Text = dsLB.Tables("Unresolved").Rows(i).Item(6)
            End If
        Next

    End Sub


    '************************ Update Button Pressed ****************************
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        '-------------------- Update Status in DataSource -------------------
        If txtNewStatus.Text <> lblCurrentStatus.Text And txtNewStatus.Text <> "" Then

            Dim UpdateQuery As String = "UPDATE [FaultBook] SET [TechNote] = '" & txtNewStatus.Text & "' WHERE [ComputerNumber] = '" & cmbSelComp.Text & "'"
            Dim cmdUpdateStatus As OleDbCommand = New OleDbCommand(UpdateQuery, LBConn)
            cmdUpdateStatus.ExecuteNonQuery()

            MsgBox("The status has been updated", , "Status Update Success")
            lblCurrentStatus.Text = ""
            txtNewStatus.Clear()
        Else
            MsgBox("Invalid status. Please re-enter", , "Status Update Failure")
            txtNewStatus.Clear()
            txtNewStatus.Focus()
        End If
    End Sub

    '************************ Exit ****************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            dsLB.Tables("Unresolved").Rows.Clear()
            dsLB.Tables("Computers").Rows.Clear()
        Catch ex As Exception
        End Try

        Me.Close()
        frmTechnician.Show()
    End Sub

End Class