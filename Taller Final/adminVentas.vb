Imports MySql.Data.MySqlClient

Public Class adminVentas

    Private Sub adminVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As MySqlConnection
        con = New MySqlConnection("Host=127.0.0.1; Port=3307; database=final; User =root; password=123456789")
        Try
            con.Open()
            Dim cmd As New MySqlCommand("select id_venta, cantidad, id_cliente, id_producto from venta", con)
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
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        adminCliente.Show()
        Me.Hide()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        adminProducto.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub botoncerrar_Click(sender As Object, e As EventArgs) Handles botoncerrar.Click
        agregarVentas.Show()
    End Sub
End Class