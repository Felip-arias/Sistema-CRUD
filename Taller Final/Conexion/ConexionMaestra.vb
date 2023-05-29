Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Module ConexionMaestra
    Public conexion As New SqlConnection("Host=127.0.0.1; Port=3307; database=final; User =root; password=123456789")

    Sub Abrir_Conexion()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub

    Sub Cerrar_Conexion()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub
End Module
