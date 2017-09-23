Imports System.Data.OleDb

Public Class frmAdminRoom

    '*********************** On Administrator Form Load ***************************
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '-----------------Populate RoomCount table in DataSet-------------------------
        Dim RoomNoQuery As String = "SELECT * FROM [Room Count]"
        LBAdapter.SelectCommand = New OleDbCommand(RoomNoQuery, LBConn)

        cmbSelFunc.SelectedIndex = 0

    End Sub


    '*********************** Select Room Function combo box changed ***************************
    Private Sub cmbSelFunc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelFunc.SelectedIndexChanged
        Try
            dsLB.Tables("RoomCount").Rows.Clear()
            cmbSelRoom.Items.Clear()
            txtRoomName.Text = ""
            txtNumComps.Text = ""
        Catch ex As Exception
        End Try

        LBAdapter.Fill(dsLB, "RoomCount")

        '---------------------Populate Room Name Combo Box-------------------------
        Try
            For i = 0 To dsLB.Tables("RoomCount").Rows.Count - 1
                cmbSelRoom.Items.Add(dsLB.Tables("RoomCount").Rows(i).Item(0))
            Next
        Catch ex As Exception
        End Try


        '---------Add-------------
        If cmbSelFunc.SelectedIndex = 0 Then
            cmbSelRoom.Visible = False
            txtRoomName.Visible = True
            txtNumComps.Visible = True
            txtRoomName.Focus()
            '---------Remove-------------
        ElseIf cmbSelFunc.SelectedIndex = 1 Then
            cmbSelRoom.Visible = True
            txtRoomName.Visible = False
            txtNumComps.Visible = False
            '---------Modify-------------
        Else
            cmbSelRoom.Visible = True
            txtRoomName.Visible = True
            txtNumComps.Visible = True
        End If

    End Sub

    '*********************** Select Computer Room ***************************   
    Private Sub cmbSelRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelRoom.SelectedIndexChanged

        '-----Populate Room Details-----
        For i = 1 To dsLB.Tables("RoomCount").Rows.Count - 1
            If cmbSelRoom.Text = dsLB.Tables("RoomCount").Rows(i).Item(0) Then
                txtRoomName.Text = dsLB.Tables("RoomCount").Rows(i).Item(0)
                txtNumComps.Text = dsLB.Tables("RoomCount").Rows(i).Item(1)
            End If
        Next

    End Sub


    '*********************** Update Room Details ***************************
    Private Sub btnUpdateRoom_Click(sender As Object, e As EventArgs) Handles btnUpdateRoom.Click

        '---------------Add---------------
        If cmbSelFunc.SelectedIndex = 0 Then
            MsgBox("Option currently unavailable")

            'Dim insertRoomquery As String = "INSERT INTO [Room Count] VALUES ('" & txtRoomName.Text & "', " & txtNumComps.Text & ")"
            'Dim cmdRoomInsert As OleDbCommand = New OleDbCommand(insertRoomquery, LBConn)

            'Dim answer = MsgBox("Add Room?", vbYesNo + vbQuestion, "Confirm Add?")
            'If answer = vbYes Then
            'Try
            'cmdRoomInsert.ExecuteNonQuery()
            'MsgBox("Room has been added to the database.", , "Room Added Successfully")
            'txtRoomName.Text = ""
            'txtNumComps.Text = ""
            'Catch ex As Exception

            'End Try
            'Else
            'MsgBox("Add Room cancelled")
            'End If

            'Dim iterations As Int16 = txtNumComps.Text

            '----Link to Computer Section----
            'For i = 0 To iterations
            'Try
            'frmAdminComp.Show()
            'Catch ex As Exception
            'End Try
            'Next

            'MsgBox("Computers have been added to the database.", , "Computers Added Successfully")
            'frmAdminComp.Close()
            'Me.Show()


            '------------Remove--------------
        ElseIf cmbSelFunc.SelectedIndex = 1 Then

            '---Remove Room and corresponding computers from Database---
            Dim deleteRoomquery As String = "DELETE FROM [Room Count] WHERE [RoomName] = '" & cmbSelRoom.Text & "'"
            Dim cmdRoomDelete As OleDbCommand = New OleDbCommand(deleteRoomquery, LBConn)

            Dim deletePCsquery As String = "DELETE FROM [Computers] WHERE [Name] LIKE '%" & cmbSelRoom.Text & "%'"
            Dim cmdPCsDelete As OleDbCommand = New OleDbCommand(deletePCsquery, LBConn)

            Dim answer = MsgBox("Delete Room?", vbYesNo + vbQuestion, "Confirm Delete?")
            If answer = vbYes Then
                cmdRoomDelete.ExecuteNonQuery()
                cmdPCsDelete.ExecuteNonQuery()
                MsgBox("Room Successfully Deleted")
                txtRoomName.Text = ""
                txtNumComps.Text = ""
            Else
                MsgBox("Delete cancelled")
            End If


            '----------------Modify------------------
        Else

            'Dim CompNoQuery As String = "SELECT * FROM [Room Count] WHERE [RoomName] = '" & cmbSelRoom.Text & "'"
            'LBAdapter.SelectCommand = New OleDbCommand(CompNoQuery, LBConn)
            'LBAdapter.Fill(dsLB, "CompNum")

            'Dim compNo As Int16 = Convert.ToInt16(dsLB.Tables("CompNum").Rows(0).Item(1))

            Dim updateRoomquery As String = "UPDATE [Room Count] SET [RoomName] = '" & txtRoomName.Text & "', [NumComputers] = " & txtNumComps.Text & " WHERE [RoomName] = '" & cmbSelRoom.Text & "'"
            Dim cmdUpdateRoom As OleDbCommand = New OleDbCommand(updateRoomquery, LBConn)

            Dim answer3 = MsgBox("Update Room Details?", vbYesNo + vbQuestion, "Confirm Update?")
            If answer3 = vbYes Then
                cmdUpdateRoom.ExecuteNonQuery()
                MsgBox("Room Successfully Updated")

                '----Link to Computers Form----            
            Else
                MsgBox("Update cancelled")
            End If

        End If

        '--Update Dataset Tables After Edit--
        Try
            dsLB.Tables("RoomCount").Rows.Clear()
            LBAdapter.Fill(dsLB, "RoomCount")
        Catch ex As Exception
        End Try

    End Sub


    '************************ View Entries ***************************
    Private Sub btnViewEntries_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmViewEntries.Show()
    End Sub

    '************************ Exit ***************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Application.Restart()
    End Sub


End Class