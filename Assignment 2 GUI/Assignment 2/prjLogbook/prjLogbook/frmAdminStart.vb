Public Class frmAdminStart

    '************************ Edit Room ***************************
    Private Sub btnEditRoom_Click(sender As Object, e As EventArgs) Handles btnEditRoom.Click
        Me.Close()
        frmAdminRoom.Show()
    End Sub


    '************************ Edit Computer ***************************
    Private Sub btnEditComp_Click(sender As Object, e As EventArgs) Handles btnEditComp.Click
        Me.Close()
        frmAdminComp.Show()
    End Sub


    '************************ Edit User ***************************
    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        Me.Close()
        frmAdminUsers.Show()
    End Sub


    '************************ View Entries ***************************
    Private Sub btnViewEntries_Click(sender As Object, e As EventArgs) Handles btnViewEntries.Click
        Me.Close()
        frmViewEntries.Show()
    End Sub


    '************************ Exit ***************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Application.Restart()
    End Sub

End Class