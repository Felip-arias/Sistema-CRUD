﻿Imports MySql.Data.MySqlClient
Public Class Clientes

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con As MySqlConnection
        con = New MySqlConnection("Host=127.0.0.1; Port=3307; database=final; User =root; password=123456789")
        Try
            con.Open()
            Dim cmd As New MySqlCommand("select id_cliente, nombre, direccion, telefono, ciudad from cliente", con)
            Dim drd As MySqlDataReader
            drd = cmd.ExecuteReader
            Dim bs As New BindingSource
            bs.DataSource = drd
            DataGridView1.DataSource = bs


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        con.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Ventas.Show()
        Me.Hide()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Productos.Show()
        Me.Hide()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click

    End Sub

End Class