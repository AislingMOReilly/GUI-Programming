Imports System.Data.OleDb

Public Class frmTechnician

    '********************** Clear Tables in DataSet ***************************
    Private Sub clearDatasetTables()
        Try
            dsLB.Tables("AllFaults").Rows.Clear()
            dsLB.Tables("Resolved").Rows.Clear()
            dsLB.Tables("Unresolved").Rows.Clear()
            dsLB.Tables("RoomCount").Rows.Clear()
            dsLB.Tables("Computers").Rows.Clear()
            dsLB.Tables("RoomFaults").Rows.Clear()
            dsLB.Tables("ComputerFaults").Rows.Clear()
        Catch ex As Exception
        End Try
    End Sub


    '************************ On Technician Form Load ****************************
    Private Sub frmTechnician_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbView.SelectedIndex = 0

        '--------------Populate All Faults table in Dataset------------
        Dim AllQuery As String = "(SELECT * FROM Resolved) UNION ALL (SELECT * FROM FaultBook)"

        LBAdapter.SelectCommand = New OleDbCommand(AllQuery, LBConn)
        LBAdapter.Fill(dsLB, "AllFaults")


        '-----------Populate Unresolved table in Dataset--------------
        Dim UnResQuery As String = "SELECT * FROM FaultBook"

        LBAdapter.SelectCommand = New OleDbCommand(UnResQuery, LBConn)
        LBAdapter.Fill(dsLB, "Unresolved")


        '--------------Populate Resolved table in Dataset-------------
        Dim ResQuery As String = "SELECT * FROM Resolved"

        LBAdapter.SelectCommand = New OleDbCommand(ResQuery, LBConn)
        LBAdapter.Fill(dsLB, "Resolved")


        '-----------Populate RoomCount table in Dataset----------------
        Dim RoomNoQuery As String = "SELECT * FROM [Room Count]"
        LBAdapter.SelectCommand = New OleDbCommand(RoomNoQuery, LBConn)
        LBAdapter.Fill(dsLB, "RoomCount")


        '------------Populate Computers table in Dataset----------------
        Dim CompNameQuery As String = "SELECT * FROM Computers"
        LBAdapter.SelectCommand = New OleDbCommand(CompNameQuery, LBConn)
        LBAdapter.Fill(dsLB, "Computers")

    End Sub


    '************************ View combo box changed ****************************
    Private Sub cmbView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbView.SelectedIndexChanged
        Try
            dsLB.Tables("RoomFaults").Rows.Clear()
            dsLB.Tables("ComputerFaults").Rows.Clear()
            cmbSelRoom.Items.Clear()
            cmbSelComp.Items.Clear()
        Catch ex As Exception
        End Try

        lblSerialNum.Text = ""
        lblManu.Text = ""
        lblModel.Text = ""

        '----View All----
        If cmbView.SelectedIndex = 0 Then
            cmbSelRoom.Visible = False
            cmbSelComp.Visible = False

            grdTech.DataSource = dsLB.Tables("AllFaults")


            '----View Unresolved----
        ElseIf cmbView.SelectedIndex = 1 Then
            cmbSelRoom.Visible = False
            cmbSelComp.Visible = False

            grdTech.DataSource = dsLB.Tables("Unresolved")


            '----View Resolved----
        ElseIf cmbView.SelectedIndex = 2 Then
            cmbSelRoom.Visible = False
            cmbSelComp.Visible = False

            grdTech.DataSource = dsLB.Tables("Resolved")


            '----View By Room----
        ElseIf cmbView.SelectedIndex = 3 Then
            cmbSelRoom.Visible = True
            cmbSelComp.Visible = False


            For i = 0 To dsLB.Tables("Unresolved").Rows.Count - 1

                '*** Populate Room Name Combo Box ***
                For j = 0 To dsLB.Tables("RoomCount").Rows.Count - 1
                    If dsLB.Tables("RoomCount").Rows(j).Item(0) = dsLB.Tables("Unresolved").Rows(i).Item(2) Then
                        cmbSelRoom.Items.Add(dsLB.Tables("RoomCount").Rows(j).Item(0))
                    End If
                Next
            Next


            '----View By Computer----
        Else
            cmbSelRoom.Visible = False
            cmbSelComp.Visible = True

            For i = 0 To dsLB.Tables("Unresolved").Rows.Count - 1
                '*** Populate Computer Name Combo Box ***
                For j = 0 To dsLB.Tables("Computers").Rows.Count - 1
                    If dsLB.Tables("Computers").Rows(j).Item(1) = dsLB.Tables("Unresolved").Rows(i).Item(3) Then
                        cmbSelComp.Items.Add(dsLB.Tables("Computers").Rows(j).Item(1))
                    End If
                Next
            Next
        End If

    End Sub


    '************************ By Room combo box changed ****************************
    Private Sub cmbSelRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelRoom.SelectedIndexChanged
        Try
            dsLB.Tables("RoomFaults").Rows.Clear()
            grdTech.Refresh()
        Catch ex As Exception
        End Try

        Dim RoomFaultQuery As String = "SELECT * FROM FaultBook WHERE RoomNumber = '" & cmbSelRoom.Text & "'"
        LBAdapter.SelectCommand = New OleDbCommand(RoomFaultQuery, LBConn)
        LBAdapter.Fill(dsLB, "RoomFaults")

        grdTech.DataSource = dsLB.Tables("RoomFaults")

    End Sub


    '************************ By Computer combo box changed ****************************
    Private Sub cmbSelComp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelComp.SelectedIndexChanged
        Try
            dsLB.Tables("ComputerFaults").Rows.Clear()
            grdTech.Refresh()
        Catch ex As Exception
        End Try

        Dim PCFaultQuery As String = "SELECT * FROM FaultBook WHERE ComputerNumber = '" & cmbSelComp.Text & "'"
        LBAdapter.SelectCommand = New OleDbCommand(PCFaultQuery, LBConn)
        LBAdapter.Fill(dsLB, "ComputerFaults")

        grdTech.DataSource = dsLB.Tables("ComputerFaults")

        '-----Populate Computer Details-----
        For i = 1 To dsLB.Tables("Computers").Rows.Count - 1
            If cmbSelComp.Text = dsLB.Tables("Computers").Rows(i).Item(1) Then
                lblSerialNum.Text = dsLB.Tables("Computers").Rows(i).Item(0)
                lblManu.Text = dsLB.Tables("Computers").Rows(i).Item(2)
                lblModel.Text = dsLB.Tables("Computers").Rows(i).Item(3)
            End If
        Next
    End Sub


    '************************ View Inactive Faults Button Pressed ****************************
    Private Sub btnViewIn_Click(sender As Object, e As EventArgs) Handles btnViewIn.Click
        clearDatasetTables()
        frmInactive.Show()
        Me.Close()
    End Sub

    '************************ View Fault Count Button Pressed ****************************
    Private Sub btnViewCount_Click(sender As Object, e As EventArgs) Handles btnViewCount.Click
        clearDatasetTables()
        frmRoomFaults.Show()
        Me.Close()
    End Sub

    '************************ Update Status Button Pressed ****************************
    Private Sub btnUpStat_Click(sender As Object, e As EventArgs) Handles btnUpStat.Click
        clearDatasetTables()
        frmStatus.Show()
        Me.Close()
    End Sub

    '************************ Mark as Repaired Button Pressed ****************************
    Private Sub btnRep_Click(sender As Object, e As EventArgs) Handles btnRep.Click
        clearDatasetTables()
        frmResolve.Show()
        Me.Close()
    End Sub

    '************************ Exit ****************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        clearDatasetTables()
        Me.Close()
        Application.Restart()
    End Sub

End Class
