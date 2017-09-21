Imports System.IO

Public Class frmHelp

    Private Sub btnEnglish_Click(sender As Object, e As EventArgs) Handles btnEnglish.Click
        Using engHelpReader As StreamReader = New StreamReader("..\..\Resources\EnglishInstructions.txt")
            lblInstructions.Text = engHelpReader.ReadToEnd
            engHelpReader.Close()
        End Using
    End Sub

    Private Sub btnItalian_Click(sender As Object, e As EventArgs) Handles btnItalian.Click
        Using italianHelpReader As StreamReader = New StreamReader("..\..\Resources\ItalianInstructions.txt")
            lblInstructions.Text = italianHelpReader.ReadToEnd
            italianHelpReader.Close()
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class