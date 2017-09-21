Imports System.Data.OleDb

Public Class frmRoomFaults

    Dim highestCount As Decimal = 0
    Dim roomNum As String = ""


    '************************ On Room Faults Form Load ****************************
    Private Sub frmRoomFaults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FaultCountQuery As String = "SELECT * FROM [Room Count]"
        LBAdapter.SelectCommand = New OleDbCommand(FaultCountQuery, LBConn)

    End Sub


    '************************ View Fault Count Button Pressed ****************************
    Private Sub btnRoomFaults_Click(sender As Object, e As EventArgs) Handles btnRoomFaults.Click
        Try
            dsLB.Tables("RoomFaults").Rows.Clear()
        Catch ex As Exception
        End Try

        LBAdapter.Fill(dsLB, "RoomFaults")


        '---Find Room No with most faults per PC---
        For i = 0 To dsLB.Tables("RoomFaults").Rows.Count - 1
            Try
                If dsLB.Tables("RoomFaults").Rows(i).Item(2) / dsLB.Tables("RoomFaults").Rows(i).Item(1) > highestCount Then
                    highestCount = dsLB.Tables("RoomFaults").Rows(i).Item(2) / dsLB.Tables("RoomFaults").Rows(i).Item(1)
                    roomNum = dsLB.Tables("RoomFaults").Rows(i).Item(0)
                End If
            Catch ex As Exception
            End Try
        Next

        grdFaults.DataSource = dsLB.Tables("RoomFaults")
        lblMostFaultCount.Text = roomNum

    End Sub


    '************************ Exit ****************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        dsLB.Tables("RoomFaults").Rows.Clear()

        Me.Close()
        frmTechnician.Show()
    End Sub
End Class