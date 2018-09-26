Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Module Module1
    
    Dim ubicacion As String = "server=localhost; user id= 'root'; password= ; database = juegoutu"

    Public Conexion As MySqlDataAdapter
    Public Tabla As DataTable
    Public Consulta As String
    Public MysqlConexion As MySqlConnection = New MySqlConnection(ubicacion)

    Public nombreJug As String
    Public ceduJug As String

    Public Sub consultar()
        Try
            Conexion = New MySqlDataAdapter(Consulta, ubicacion)
            Tabla = New DataTable
            Conexion.Fill(Tabla)
        Catch ex As Exception
            'MsgBox(ex.ToString)

        End Try

    End Sub

   
End Module


