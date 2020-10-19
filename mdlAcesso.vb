Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Module mdlAcesso
    Public Function GetConnectionMySQL() As MySqlConnection
        Dim sql As String = "SERVER=127.0.0.1;DATABASE=Estoque;Uid=root;Pwd=root"
        Return New MySqlConnection(sql)
    End Function

    Public Function GetConnectionSQLServer() As SqlConnection
        Dim disco = System.Environment.SystemDirectory
        Dim letra = disco.Substring(0, 1)
        Dim sql As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + letra + ":\TESTE_VB\ClinicaVeterinaria\dados.mdf;Integrated Security=True"
        Return New SqlConnection(sql)
    End Function
End Module
