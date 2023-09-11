Imports MySql.Data.MySqlClient

Public Class Artista
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Nacionalidad As String
    Public Property Año As String
    Public Property Img As String
    Private Property databaseSetup As String = "server=localhost;user id=root;password=;database=prueba"
    Public Sub New(id As Integer, nombre As String, nacionalidad As String, año As String, Img As String)
        Me.ID = id
        Me.Nombre = nombre
        Me.Nacionalidad = nacionalidad
        Me.Año = año
        Me.Img = Img
    End Sub

    Public Function ObtenerArtistas()
        Dim conexion As New MySqlConnection
        conexion.ConnectionString = databaseSetup
        Try
            conexion.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM ARTISTA", conexion)
            Dim Reader As MySqlDataReader
            Reader = cmd.ExecuteReader()
            Return Reader
        Catch ex As Exception
            MessageBox.Show("Fallo en la conexion, vuelva a intentar")
            Return False
        End Try
    End Function

    Public Function buscarPorID()
        Dim conexion As New MySqlConnection
        conexion.ConnectionString = databaseSetup
        Try
            conexion.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM ARTISTA WHERE ID_ARTISTA = @ID", conexion)
            cmd.Parameters.AddWithValue("@ID", Me.ID)
            Dim Reader As MySqlDataReader
            Reader = cmd.ExecuteReader()
            Reader.Read()
            Me.Nombre = Reader("NOMBRE")
            Me.Nacionalidad = Reader("NACIONALIDAD")
            Me.Año = Reader("AÑO_INICIO")
            Me.Img = Reader("IMG")
            Return True
        Catch ex As Exception
            MessageBox.Show("Artista no existe")
            Return False
        End Try
    End Function

    Public Function BorrarArtista()
        Dim conexion As New MySqlConnection
        conexion.ConnectionString = databaseSetup
        Try
            conexion.Open()
            Dim cmd As New MySqlCommand("DELETE FROM ARTISTA WHERE ID_ARTISTA = @ID", conexion)
            cmd.Parameters.AddWithValue("@ID", Me.ID)
            Dim response As New Integer
            response = cmd.ExecuteNonQuery()
            If (response > 0) Then
                MessageBox.Show("Se ha borrado el artista de forma exitosa")
            Else
                MessageBox.Show("No se encontró el artista")
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("Fallo en la conexion, vuelva a intentar")
            Return False
        End Try
    End Function

    Public Function CrearArtista()
        Dim conexion As New MySqlConnection
        conexion.ConnectionString = databaseSetup
        Try
            conexion.Open()
            Dim cmd As New MySqlCommand("INSERT INTO ARTISTA (NOMBRE, NACIONALIDAD, AÑO_INICIO, IMG) VALUES (@NOMBRE, @NACIONALIDAD, @AÑO, @IMG)", conexion)
            cmd.Parameters.AddWithValue("@NOMBRE", Me.Nombre)
            cmd.Parameters.AddWithValue("@NACIONALIDAD", Me.Nacionalidad)
            cmd.Parameters.AddWithValue("@AÑO", Me.Año)
            cmd.Parameters.AddWithValue("@IMG", Me.Img)
            Dim response As New Integer
            response = cmd.ExecuteNonQuery()
            If (response > 0) Then
                MessageBox.Show("Se ha añadido el artista")
                conexion.Close()
            Else
                MessageBox.Show("Error al ingresar el artista, intente de nuevo")
                conexion.Close()
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("Fallo en la conexion, vuelva a intentar")
            Return False
        End Try
    End Function

    Public Function ActualizaArtista()
        Dim conexion As New MySqlConnection
        conexion.ConnectionString = databaseSetup
        Try
            conexion.Open()
            Dim cmd As New MySqlCommand("UPDATE ARTISTA SET NOMBRE = @NOMBRE, NACIONALIDAD = @NACIONALIDAD, AÑO_INICIO = @AÑO, IMG = @IMG WHERE ID_ARTISTA = @ID", conexion)
            cmd.Parameters.AddWithValue("@ID", Me.ID)
            cmd.Parameters.AddWithValue("@NOMBRE", Me.Nombre)
            cmd.Parameters.AddWithValue("@NACIONALIDAD", Me.Nacionalidad)
            cmd.Parameters.AddWithValue("@AÑO", Me.Año)
            cmd.Parameters.AddWithValue("@IMG", Me.Img)
            Dim response As New Integer
            response = cmd.ExecuteNonQuery()
            If (response > 0) Then
                MessageBox.Show("Se ha añadido la cancion al banco de canciones")
                conexion.Close()
            Else
                MessageBox.Show("Error al ingresar la cancion, intente de nuevo")
                conexion.Close()
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("Fallo en la conexion, vuelva a intentar")
            Return False
        End Try
    End Function

End Class
