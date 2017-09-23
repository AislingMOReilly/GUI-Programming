Imports System.Data.OleDb

Module globalVars
    'Public LBConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= E:\Assignment 2\prjLogbook\prjLogbook\Resources\Assignment#2.accdb")
    'Public LBConn As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source= E:\Software Engineering Level 6\GUI Programming\Assignment 2\prjLogbook\prjLogbook\Resources\Assignment#2.accdb")
    Public LBConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = \\svr-studentfile\userdocs\aisling.oreilly\Desktop\Assignment 2\prjLogbook\prjLogbook\Resources\Assignment#2.accdb")
    Public LBAdapter As OleDbDataAdapter = New OleDbDataAdapter
    Public dsLB As DataSet = New DataSet

    Public currentUser As String
    Public passIndex As Int16

End Module
