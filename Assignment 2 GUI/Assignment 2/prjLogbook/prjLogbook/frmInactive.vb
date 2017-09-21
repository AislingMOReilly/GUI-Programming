Imports System.Data.OleDb

Public Class frmInactive

    Dim InactiveFaultCount As Int16

    '************************ On Inactive Faults Form Load ****************************
    Private Sub frmInactive_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim AllQuery As String = "SELECT * FROM FaultBook"
        LBAdapter.SelectCommand = New OleDbCommand(AllQuery, LBConn)
        LBAdapter.Fill(dsLB, "Unresolved")

        Dim InactiveQuery As String = "SELECT * FROM FaultBook"
        LBAdapter.SelectCommand = New OleDbCommand(InactiveQuery, LBConn)
        LBAdapter.Fill(dsLB, "InactiveFaults")

    End Sub


    '************************ View Inactive Button Pressed ***************************
    Private Sub btnViewInactive_Click(sender As Object, e As EventArgs) Handles btnViewInactive.Click
        dsLB.Tables("InactiveFaults").Rows.Clear()
        InactiveFaultCount = 0

        Dim currentDate As Date = System.DateTime.Now.ToString()

        For i = 0 To dsLB.Tables("Unresolved").Rows.Count - 1

            Dim inactiveRow As DataRow
            inactiveRow = dsLB.Tables("InactiveFaults").NewRow()

            '---Calculate Date Difference---
            Dim faultDate As Date = dsLB.Tables("Unresolved").Rows(i).Item(1)
            Dim daysInactive As Long = DateDiff(DateInterval.Day, faultDate, currentDate)

            If daysInactive >= 5 Then

                With dsLB.Tables("Unresolved").Rows(i)
                    inactiveRow.Item("FaultNumber") = .Item(0)
                    inactiveRow.Item("FaultDate") = .Item(1)
                    inactiveRow.Item("RoomNumber") = .Item(2)
                    inactiveRow.Item("ComputerNumber") = .Item(3)
                    inactiveRow.Item("Description") = .Item(4)
                    inactiveRow.Item("Username") = .Item(5)
                    inactiveRow.Item("TechNote") = .Item(6)
                End With

                dsLB.Tables("InactiveFaults").Rows.Add(inactiveRow)

                InactiveFaultCount += 1
            End If
        Next

        grdInactive.DataSource = dsLB.Tables("InactiveFaults")
        lblInactiveCount.Text = InactiveFaultCount
    End Sub



    '************************ Exit ****************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            dsLB.Tables("Unresolved").Rows.Clear()
            dsLB.Tables("InactiveFaults").Rows.Clear()
        Catch ex As Exception
        End Try

        Me.Close()
        frmTechnician.Show()
    End Sub

End Class