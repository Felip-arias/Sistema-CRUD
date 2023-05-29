Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class agregarCliente

    Private ConnectionString As String = "Host=127.0.0.1; Port=3307; database=final; User =root; password=123456789"

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        adminCliente.Show()
        Me.Hide()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        adminProducto.Show()
        Me.Hide()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        adminVentas.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Hide()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim id = TextBox_id.Text
        Dim nombre = TextBox_nombre.Text
        Dim direccion = TextBox_direccion.Text
        Dim telefono = TextBox_telefono.Text
        Dim ciudad = TextBox_ciudad.Text


        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()

                Dim query = "INSERT INTO cliente (id_cliente, nombre, direccion, telefono, ciudad) VALUES ('" & id & "', '" & nombre & "', '" & direccion & "', '" & telefono & "', '" & ciudad & "')"
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

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()

                Dim query = "UPDATE cliente SET  nombre= '" & TextBox_nombre.Text & "', direccion = '" & TextBox_direccion.Text & "', telefono = '" & TextBox_telefono.Text & "',ciudad = '" & TextBox_ciudad.Text & "' where id_cliente = '" & TextBox_id.Text & "'"
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
        Dim nombre = TextBox_nombre.Text
        Dim direccion = TextBox_direccion.Text
        Dim telefono = TextBox_telefono.Text
        Dim ciudad = TextBox_ciudad.Text

        Using connection As New MySqlConnection(ConnectionString)
            Try
                connection.Open()

                Dim query = "DELETE FROM cliente WHERE id_cliente = '" & id & "' AND nombre = '" & nombre & "' AND direccion = '" & direccion & "' AND telefono = '" & telefono & "' AND ciudad = '" & ciudad & "'"
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