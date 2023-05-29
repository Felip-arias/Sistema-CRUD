Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub btn_ingresar_Click_1(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        Dim usuario, password, rol As String

        usuario = Text_user.Text
        password = Text_contraseña.Text
        rol = ComboBox1.SelectedIndex

        If (usuario = "administrador") And (password = "admin123") And (rol = "0") Then
            MessageBox.Show("Usuario correcto", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            adminCliente.Show()
            Me.Hide()
        ElseIf (usuario = "user") And (password = "pass123") And (rol = "1") Then
            MessageBox.Show("Usuario correcto", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Clientes.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario incorrecto", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

        End If
    End Sub


End Class

' CONTINUAR CREANDO LAS TABLAS DE AGREGAR DATOS"