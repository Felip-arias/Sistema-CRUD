Imports MySql.Data.MySqlClient

Public Class agregarVentas


    Private ConnectionString As String = "Host=127.0.0.1; Port=3307; database=final; User =root; password=123456789"


    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim id = TextBox_id.Text
        Dim cantidad = TextBox_cantidad.Text
        Dim cliente = TextBox_idcliente.Text
        Dim producto = TextBox_idproducto.Text

        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()

                Dim query = "INSERT INTO venta (id_venta, cantidad, id_cliente, id_producto) VALUES ('" & id & "', '" & cantidad & "', '" & cliente & "', '" & producto & "')"
                Dim command As New MySqlCommand(query, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MessageBox.Show("Datos agregados correctamente", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()

            Catch ex As Exception
                MessageBox.Show("Error en la conexión de la base de datos: " & ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End Using

    End Sub



    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        adminCliente.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        adminProducto.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        adminVentas.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        Dim id = TextBox_id.Text
        Dim cantidad = TextBox_cantidad.Text
        Dim cliente = TextBox_idcliente.Text
        Dim producto = TextBox_idproducto.Text

        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()

                Dim query = "DELETE FROM venta WHERE id_venta = '" & id & "' AND cantidad = '" & cantidad & "' AND id_cliente = '" & cliente & "' AND id_producto = '" & producto & "'"
                Dim command As New MySqlCommand(query, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MessageBox.Show("Datos eliminados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error en la conexión de la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End Using

    End Sub

End Class