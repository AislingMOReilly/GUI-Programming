Imports System.Data.OleDb

Public Class frmAdminComp

    '*********************** On Edit Computers Form Load ***************************
    Private Sub frmAdminComp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '----------------------Populate Computers table in DataSet ----------------------
        Dim CompNameQuery As String = "SELECT * FROM Computers"
        LBAdapter.SelectCommand = New OleDbCommand(CompNameQuery, LBConn)

        cmbSelFunc.SelectedIndex = 0
    End Sub


    '*********************** Select Computer Function ***************************   
    Private Sub cmbSelFunc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelFunc.SelectedIndexChanged
        Try
            dsLB.Tables("ComputerDetails").Rows.Clear()
            cmbSelComp.Items.Clear()
            txtSerial.Text = ""
            txtMan.Text = ""
            txtCompModel.Text = ""
        Catch ex As Exception
        End Try

        LBAdapter.Fill(dsLB, "ComputerDetails")

        '--------------------Populate Computer Name Combo Box----------------------
        Try
            For i = 0 To dsLB.Tables("ComputerDetails").Rows.Count - 1
                cmbSelComp.Items.Add(dsLB.Tables("ComputerDetails").Rows(i).Item(1))
            Next
        Catch ex As Exception
        End Try


        '---------Add-------------
        If cmbSelFunc.SelectedIndex = 0 Then
            cmbSelComp.Visible = False
            txtCompName.Visible = True
            txtSerial.Visible = True
            txtMan.Visible = True
            txtCompModel.Visible = True
            txtCompName.Focus()
            '---------Remove------------
        ElseIf cmbSelFunc.SelectedIndex = 1 Then
            cmbSelComp.Visible = True
            txtCompName.Visible = False
            txtSerial.Visible = False
            txtMan.Visible = False
            txtCompModel.Visible = False
            '---------Modify-------------
        Else
            cmbSelComp.Visible = True
            txtCompName.Visible = True
            txtSerial.Visible = True
            txtMan.Visible = True
            txtCompModel.Visible = True
        End If

    End Sub


    '*********************** Select Computer ***************************   
    Private Sub cmbSelComp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelComp.SelectedIndexChanged
        '-----Populate Computer Details-----
        For i = 1 To dsLB.Tables("ComputerDetails").Rows.Count - 1
            If cmbSelComp.Text = dsLB.Tables("ComputerDetails").Rows(i).Item(1) Then
                txtCompName.Text = dsLB.Tables("ComputerDetails").Rows(i).Item(1)
                txtSerial.Text = dsLB.Tables("ComputerDetails").Rows(i).Item(0)
                txtMan.Text = dsLB.Tables("ComputerDetails").Rows(i).Item(2)
                txtCompModel.Text = dsLB.Tables("ComputerDetails").Rows(i).Item(3)
            End If
        Next
    End Sub


    '*********************** Update Computer Details ***************************
    Private Sub btnUpdateComp_Click(sender As Object, e As EventArgs) Handles btnUpdateComp.Click

        '---------------------Add-------------------------
        If cmbSelFunc.SelectedIndex = 0 Then
            Dim insertCompquery As String = "INSERT INTO [Computers] VALUES ('" & txtSerial.Text & "', '" & txtCompName.Text & "', '" & txtMan.Text & "', '" & txtCompModel.Text & "')"
            Dim cmdCompInsert As OleDbCommand = New OleDbCommand(insertCompquery, LBConn)

            Dim answer = MsgBox("Add Computer?", vbYesNo + vbQuestion, "Confirm Add?")
            If answer = vbYes Then
                cmdCompInsert.ExecuteNonQuery()
                MsgBox("Computer Successfully Added")
                txtSerial.Text = ""
                txtMan.Text = ""
                txtCompModel.Text = ""


                '---Update corresponding room---
                Dim ComputerNumQuery As String = "SELECT [NumComputers] FROM [Room Count] WHERE [RoomName] LIKE '%" & txtCompName.Text & "%'"
                LBAdapter.SelectCommand = New OleDbCommand(ComputerNumQuery, LBConn)
                LBAdapter.Fill(dsLB, "RoomDetails")

                Try
                    Dim compCount = dsLB.Tables("RoomDetails").Rows(0).Item(0)
                    Dim updateRoomquery As String = "UPDATE [Room Count] SET NumComputers = " & compCount + 1 & "WHERE [RoomName] Like '%" & txtCompName.Text & "%'"
                    Dim cmdUpdateRoomInsert As OleDbCommand = New OleDbCommand(updateRoomquery, LBConn)

                    cmdUpdateRoomInsert.ExecuteNonQuery()
                Catch ex As Exception
                End Try

            Else
                MsgBox("Add computer cancelled")
            End If


            '-------------------Remove-----------------------
        ElseIf cmbSelFunc.SelectedIndex = 1 Then

            '---Remove Computer from Database---
            Dim deleteCompquery As String = "DELETE FROM [Computers] WHERE [Name] = '" & cmbSelComp.Text & "'"
            Dim cmdCompDelete As OleDbCommand = New OleDbCommand(deleteCompquery, LBConn)

            Dim answer = MsgBox("Delete Computer?", vbYesNo + vbQuestion, "Confirm Delete?")
            If answer = vbYes Then
                cmdCompDelete.ExecuteNonQuery()
                MsgBox("Computer Successfully Deleted")


                '---Update corresponding room---
                Dim ComputerNumQuery2 As String = "SELECT [NumComputers] FROM [Room Count] WHERE [RoomName] LIKE '%" & cmbSelComp.Text & "%'"
                LBAdapter.SelectCommand = New OleDbCommand(ComputerNumQuery2, LBConn)
                LBAdapter.Fill(dsLB, "RoomDetails")

                Dim updateRoomquery As String = "UPDATE [Room Count] SET NumComputers = NumComputers - 1 WHERE [RoomName] LIKE '%" & cmbSelComp.Text & "%'"
                Dim cmdUpdateRoomInsert As OleDbCommand = New OleDbCommand(updateRoomquery, LBConn)

                cmdUpdateRoomInsert.ExecuteNonQuery()

            Else
                MsgBox("Delete cancelled")
            End If

            '---------------------Modify----------------------
        Else

            Dim ModifyCompquery As String = "UPDATE [Computers] SET [Name] = '" & txtCompName.Text & "', [SerialNo] = '" & txtSerial.Text & "', [Manufacturer] = '" & txtMan.Text & "', [Model] = '" & txtCompModel.Text & "' WHERE [Name] = '" & cmbSelComp.Text & "'"
            Dim cmdModifyComp As OleDbCommand = New OleDbCommand(ModifyCompquery, LBConn)

            Dim answer2 = MsgBox("Update Computer Details?", vbYesNo + vbQuestion, "Confirm Update?")
            If answer2 = vbYes Then
                cmdModifyComp.ExecuteNonQuery()
                MsgBox("Computer Successfully Updated")
                txtSerial.Text = ""
                txtMan.Text = ""
                txtCompModel.Text = ""
            Else
                MsgBox("Update cancelled")
            End If

        End If

        '--Update Dataset Tables After Edit--
        Try
            dsLB.Tables("ComputerDetails").Rows.Clear()
            LBAdapter.Fill(dsLB, "ComputerDetails")
            dsLB.Tables("RoomCount").Rows.Clear()
            LBAdapter.Fill(dsLB, "RoomCount")
        Catch ex As Exception
        End Try
    End Sub


    '************************ Exit ***************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()
        frmAdminStart.Show()
    End Sub

End Class