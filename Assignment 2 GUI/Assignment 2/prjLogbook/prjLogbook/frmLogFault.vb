Imports System.Data.OleDb

Public Class frmLogFault

    '************************ On Log Fault Form Load ****************************
    Private Sub frmLogFault_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFaultDate.Text = System.DateTime.Now.ToString()
        lblLogged.Text = currentUser

        '-----------Populate RoomCount table in DataSet-------------
        Dim RoomNoQuery As String = "SELECT * FROM [Room Count]"
        LBAdapter.SelectCommand = New OleDbCommand(RoomNoQuery, LBConn)
        LBAdapter.Fill(dsLB, "RoomCount")

        '------------Populate Room Number Combo Box-----------------
        For i = 0 To dsLB.Tables("RoomCount").Rows.Count - 1
            cmbRoomNo.Items.Add(dsLB.Tables("RoomCount").Rows(i).Item(0))
        Next

        cmbRoomNo.SelectedIndex = 0
        cmbCompNo.SelectedIndex = 0
    End Sub


    '************************ Room No combo box changed ****************************
    Private Sub cmbRoomNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoomNo.SelectedIndexChanged
        Try
            dsLB.Tables("Computers").Rows.Clear()
            cmbCompNo.Items.Clear()
        Catch ex As Exception
        End Try

        '----------------Populate Computers table in DataSet-----------------
        Dim CompNameQuery As String = "SELECT * FROM Computers WHERE Name LIKE '%" + cmbRoomNo.Text + "%'"
        LBAdapter.SelectCommand = New OleDbCommand(CompNameQuery, LBConn)
        LBAdapter.Fill(dsLB, "Computers")

        '----------------Populate Computer Number Combo Box------------------
        For i = 0 To dsLB.Tables("Computers").Rows.Count - 1
            cmbCompNo.Items.Add(dsLB.Tables("Computers").Rows(i).Item(1))
        Next

    End Sub


    '************************ Log Fault Button Pressed ****************************
    Private Sub btnLogFault_Click(sender As Object, e As EventArgs) Handles btnLogFault.Click

        If txtFaultDesc.Text <> "" Then

            Dim UnResQuery As String = "SELECT * FROM FaultBook"
            LBAdapter.SelectCommand = New OleDbCommand(UnResQuery, LBConn)
            LBAdapter.Fill(dsLB, "Unresolved")

            Dim rowNumber As Int16 = dsLB.Tables("Unresolved").Rows.Count

            Dim faultRow As DataRow
            faultRow = dsLB.Tables("Unresolved").NewRow()


            '-------------------Insert into DataSet---------------------
            faultRow.Item("FaultNumber") = rowNumber + 1
            faultRow.Item("FaultDate") = lblFaultDate.Text
            faultRow.Item("RoomNumber") = cmbRoomNo.Text
            faultRow.Item("ComputerNumber") = cmbCompNo.Text
            faultRow.Item("Description") = txtFaultDesc.Text
            faultRow.Item("Username") = lblLogged.Text
            faultRow.Item("TechNote") = "N/A"

            dsLB.Tables("Unresolved").Rows.Add(faultRow)

            '------------------Insert into DataSource-------------------
            Dim builder As New OleDb.OleDbCommandBuilder(LBAdapter)
            LBAdapter.Update(dsLB.Tables("Unresolved"))


            '------------------Update Fault Count-------------------
            Dim UpdateRoomQuery As String = "UPDATE [Room Count] SET [TotalFaults] = [TotalFaults] + 1 WHERE [RoomName] = '" & cmbRoomNo.Text & "'"
            Dim cmdUpdateStatus As OleDbCommand = New OleDbCommand(UpdateRoomQuery, LBConn)
            cmdUpdateStatus.ExecuteNonQuery()

            MsgBox(txtFaultDesc.Text + " has been added to the database.", , "Update Confirmation")

            txtFaultDesc.Clear()
            cmbRoomNo.SelectedIndex = 0
            cmbCompNo.SelectedIndex = 0
        Else
            MsgBox("Please enter a fault description")
            txtFaultDesc.Focus()
        End If

    End Sub


    '************************ Exit ****************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            dsLB.Tables("RoomCount").Rows.Clear()
            dsLB.Tables("Unresolved").Rows.Clear()
        Catch ex As Exception
        End Try

        frmViewEntries.Show()
        Me.Close()
    End Sub

End Class