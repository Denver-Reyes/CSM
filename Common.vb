﻿Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Common
    Public Shared myDBconnection As MySqlConnection

    Public Shared Function getDBConnectionX() As MySqlConnection

        myDBconnection = New MySqlConnection(
            "Database=dbExcolo;" &
            "Data Source=localhost;" &
            "User id =root;" &
            "Password=Krentpogi@234;" &
            "Port=3306;Command TimeOut=600;")

        Return myDBconnection

    End Function

End Class