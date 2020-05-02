Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim conexion As MySqlConnection
        conexion = New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim ds As DataSet = New DataSet
        Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter

        conexion.ConnectionString = "server=localhost; database=encuesta;Uid=root;Pwd=;"

        If txtnombre.Text = "" Or txtapellido.Text = "" Or cbserie.Text = "" Then

            MessageBox.Show("Error, ingrese los datos correctos", "Datos no correctos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                conexion.Open()
                MsgBox("Conectado con la base de datos.")

                cmd.Connection = conexion
                cmd.CommandText = "INSERT INTO encuesta_series(nombre, apellido, serie_favorita) VALUES (@nombre, @apellido, @serie_favorita)"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
                cmd.Parameters.AddWithValue("@apellido", txtapellido.Text)
                cmd.Parameters.AddWithValue("@serie_favorita", cbserie.Text)
                cmd.ExecuteNonQuery()

                cmd.CommandText = "SELECT * FROM encuesta_series ORDER BY nombre ASC"
                adaptador.SelectCommand = cmd
                adaptador.Fill(ds, "Tabla")
                grdnombre.DataSource = ds
                grdnombre.DataMember = "Tabla"


                conexion.Close()
                txtnombre.Clear()
                txtapellido.Clear()
                cbserie.Text = ""
                MsgBox("Datos ingresados correctamente.")

            Catch ex As Exception
                MsgBox("No se a podido conectar con la base de datos.")
            End Try
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub grdnombre_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdnombre.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
