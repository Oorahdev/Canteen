﻿Imports System.Data.SqlClient

Module modCanteen
    'Public actId As Integer
    Public usrId As Integer = 0
    Public usrAdmin As Boolean = False
    'Public preOrderMode As Boolean = True
    Public boolPhotoWarning As Boolean = False
    Public boolTrackInventory As Boolean = False

    Public DV_ITM As DataView
    Public DV_CTG As DataView
    Public DV_INV As DataView

    Dim MyConn As String = My.Settings.CanteenConnectionString

    Public con As SqlConnection

    Public Function LoginSQL() As Boolean
        con = New SqlConnection(MyConn)
        Return (con IsNot Nothing)
    End Function

    Private Sub LoadData(ByVal DV As DataView)
        If DV Is DV_ITM Then DV_ITM = GetDV("SELECT * FROM ITM")
    End Sub

    Public Function GetDV(ByVal sqlstatement As String) As DataView
        If con Is Nothing Then If LoginSQL() = False Then Return Nothing
        Dim cmd As New SqlCommand(sqlstatement, con)
        Dim DT As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(DT)
        Return New DataView(DT)
    End Function

    Public Function UpdateSQL(ByVal UpdateStatement As String) As Integer
        con.Open()
        Dim cmd As New SqlCommand(UpdateStatement, con)
        Dim intRows As Integer = cmd.ExecuteNonQuery
        con.Close()
        Return intRows
    End Function

    Public Sub CancelChanges()

    End Sub

    Public Function preOrderMode() As Boolean
        Return My.Settings.PreOrderMode
    End Function

End Module
