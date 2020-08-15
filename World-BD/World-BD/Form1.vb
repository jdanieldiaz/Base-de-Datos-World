Imports MySql.Data.MySqlClient
'Martin Calvete 3BF
Public Class Form1


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim conexion As MySqlConnection
        conexion = New MySqlConnection

        Dim cmd As New MySqlCommand
        Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter
        Dim ds As New DataSet


        conexion.ConnectionString = "server=localhost; database=world;Uid=root;Pwd=;"

        Try
            conexion.Open()
            cmd.Connection = conexion

            cmd.CommandText = "SELECT paises.Nombre AS 'Nombre Pais' , ciudad.Nombre AS 'Nombre Ciudad', ciudad.Poblacion, ciudad.Idioma FROM ciudad,paises WHERE ciudad.Nombre=@buscar AND paises.IDPais = ciudad.IDPais"
            cmd.Prepare()

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@buscar", txtBuscar.Text)
            cmd.ExecuteNonQuery()
            txtBuscar.Clear()

            adaptador.SelectCommand = cmd
            adaptador.Fill(ds, "Tabla")
            grdWorld.DataSource = ds
            grdWorld.DataMember = "Tabla"


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        txtBuscar.Clear()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click

        Dim conexion As MySqlConnection
        conexion = New MySqlConnection

        Dim cmd As New MySqlCommand
        Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter
        Dim ds As New DataSet

        conexion.ConnectionString = "server=localhost; database=world;Uid=root;Pwd=;"

        Try
            conexion.Open()
            cmd.Connection = conexion

            cmd.CommandText = "SELECT paises.Nombre AS 'Nombre Pais', ciudad.Nombre AS 'Nombre Ciudad', ciudad.Idioma FROM paises,ciudad WHERE paises.IDPais = ciudad.IDPais"
            adaptador.SelectCommand = cmd
            adaptador.Fill(ds, "Tabla")
            grdWorld.DataSource = ds
            grdWorld.DataMember = "Tabla"


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnMostrar2_Click(sender As Object, e As EventArgs) Handles btnMostrar2.Click

        Dim conexion As MySqlConnection
        conexion = New MySqlConnection

        Dim cmd As New MySqlCommand
        Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter
        Dim ds As New DataSet

        conexion.ConnectionString = "server=localhost; database=world;Uid=root;Pwd=;"

        Try
            conexion.Open()
            cmd.Connection = conexion

            cmd.CommandText = "SELECT paises.Nombre AS 'Nombre del Pais', paises.AñodeIndependencia AS 'Independencia del pais', paises.Poblacion AS 'Poblacion pais' , ciudad.Nombre AS 'Nombre Ciudad', ciudad.Poblacion AS 'Poblacion Ciudad' FROM paises, ciudad WHERE paises.IDPais = ciudad.IDPais"
            adaptador.SelectCommand = cmd
            adaptador.Fill(ds, "Tabla")
            grdWorld.DataSource = ds
            grdWorld.DataMember = "Tabla"


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
