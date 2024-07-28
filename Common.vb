Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Common
    Public Shared myDBconnection As MySqlConnection

    Public Shared Function getDBConnectionX() As MySqlConnection

        myDBconnection = New MySqlConnection(
            "Database=dbexcolo;" &
            "Data Source=localhost;" &
            "User id =root;" &
            "Password=0000;" &
            "Port=3306;Command TimeOut=600;")

        Return myDBconnection

    End Function

End Class