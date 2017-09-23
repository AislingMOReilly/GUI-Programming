Imports System.Data.OleDb

Public Class frmResolve
    Dim selected As Boolean

    '********************** On Resolve Form Load ***************************
    Private Sub frmResolve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dsLB.Tables("Computers").Rows.Clear()
            dsLB.Tables("ResolvedFaults").Rows.Clear()
            dsLB.Tables("Unresolved").Rows.Clear()
        Catch ex As Exception
        End Try


        '-----------Populate Unresolved table in Dataset--------------
        Dim UnResQuery As String = "SELECT * FROM FaultBook"
        LBAdapter.SelectCommand = New OleDbCommand(UnResQuery, LBConn)
        LBAdapter.Fill(dsLB, "Unresolved")

        '-----------Populate Resolved table in Dataset--------------
        Dim ResQuery As String = "SELECT * FROM Resolved"

        LBAdapter.SelectCommand = New OleDbCommand(ResQuery, LBConn)
        LBAdapter.Fill(dsLB, "ResolvedFaults")


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


    '******************* Select Computer combo box changed ********************
    Private Sub cmbSelComp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelComp.SelectedIndexChanged
        selected = True

        '---------------Populate Details of Fault-------------------
        For i = 0 To dsLB.Tables("Unresolved").Rows.Count - 1
            If cmbSelComp.Text = dsLB.Tables("Unresolved").Rows(i).Item(3) Then
                With dsLB.Tables("Unresolved").Rows(i)
                    lblFaultDate.Text = .Item(1)
                    lblRoomNum.Text = .Item(2)
                    lblComputerNum.Text = .Item(3)
                    lblDescription.Text = .Item(4)
                    lblUsername.Text = .Item(5)
                    lblTechNote.Text = .Item(6)
                End With
            End If
        Next

    End Sub


    '************************ Repair Button Pressed ***************************
    Private Sub btnRepair_Click(sender As Object, e As EventArgs) Handles btnRepair.Click
        Dim rowNumber As Int16 = dsLB.Tables("ResolvedFaults").Rows.Count - 1
        Dim nextKeyValue As Int16 = dsLB.Tables("ResolvedFaults").Rows(rowNumber).Item(0) + 1

        If selected = True Then
            Dim answer = MsgBox("Are you sure you want to mark " & cmbSelComp.Text & " as repaired?", vbYesNo + vbQuestion, "Are you sure?")
            If answer = vbYes Then

                '----Insert into Resolved Database Table---- 
                Dim InsertQuery As String = "INSERT INTO [Resolved] VALUES (" & nextKeyValue & ", '" & lblFaultDate.Text & "', '" & lblRoomNum.Text & "', '" & lblComputerNum.Text & "', '" & lblDescription.Text & "', '" & lblUsername.Text & "', '" & lblTechNote.Text & "')"
                Dim cmdInsert As OleDbCommand = New OleDbCommand(InsertQuery, LBConn)

                '----Delete from FaultBook Database Table----
                Dim DeleteQuery As String = "DELETE FROM [FaultBook] WHERE [ComputerNumber] = '" & cmbSelComp.Text & "'"
                Dim cmdDelete As OleDbCommand = New OleDbCommand(DeleteQuery, LBConn)

                cmdInsert.ExecuteNonQuery()
                cmdDelete.ExecuteNonQuery()

                '------------------Update Fault Count-------------------
                Dim UpdateRoomQuery As String = "UPDATE [Room Count] SET [TotalFaults] = [TotalFaults]" & -1 & " WHERE [RoomName] LIKE '%" & cmbSelComp.Text & "%'"
                Dim cmdUpdateStatus As OleDbCommand = New OleDbCommand(UpdateRoomQuery, LBConn)
                cmdUpdateStatus.ExecuteNonQuery()


                MsgBox("The Repair has been Successfully Logged", , "Repair Success")
                Try
                    dsLB.Tables("Computers").Rows.Clear()
                    dsLB.Tables("ResolvedFaults").Rows.Clear()
                    dsLB.Tables("Unresolved").Rows.Clear()
                    lblFaultDate.Text = ""
                    lblRoomNum.Text = ""
                    lblComputerNum.Text = ""
                    lblDescription.Text = ""
                    lblUsername.Text = ""
                    lblTechNote.Text = ""
                Catch ex As Exception
                End Try
            Else
                MsgBox("Repair cancelled", , "Cancel Repair")
                Try
                    dsLB.Tables("Computers").Rows.Clear()
                    dsLB.Tables("ResolvedFaults").Rows.Clear()
                    dsLB.Tables("Unresolved").Rows.Clear()
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub


    '********************** Exit ***************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmTechnician.Show()
    End Sub

End Class
