Imports MySql.Data.MySqlClient

Public Class agregarProductos

    Private ConnectionString As String = "Host=127.0.0.1; Port=3307; database=final; User =root; password=123456789"


    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim id = TextBox_id.Text
        Dim descripcion = TextBox_descripcion.Text
        Dim precio = TextBox_precio.Text


        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()

                Dim query = "INSERT INTO producto (id_producto, descripcion, precio) VALUES ('" & id & "', '" & descripcion & "', '" & precio & "')"
                Dim command As New MySqlCommand(query, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MessageBox.Show("Datos agregados correctamente", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Me.Close()

            Catch ex As Exception

                MessageBox.Show("Error en la conexion de la base de datos" & ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try
        End Using

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        adminCliente.Show()
        Me.Hide()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        adminProducto.Show()
        Me.Hide()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        adminVentas.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Hide()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()

                Dim query = "UPDATE producto SET descripcion = '" & TextBox_descripcion.Text & "', precio= '" & TextBox_precio.Text & "' where id_producto = '" & TextBox_id.Text & "'"
                Dim command As New MySqlCommand(query, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MessageBox.Show("Datos editados correctamente", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Me.Close()

            Catch ex As Exception

                MessageBox.Show("Error en la conexion de la base de datos" & ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try
        End Using
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        Dim id = TextBox_id.Text
        Dim descripcion = TextBox_descripcion.Text
        Dim precio = TextBox_precio.Text

        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()

                Dim query = "DELETE FROM producto WHERE id_producto = '" & id & "' AND descripcion = '" & descripcion & "' AND precio = '" & precio & "'"
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