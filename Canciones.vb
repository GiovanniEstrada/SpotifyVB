Imports MySql.Data.MySqlClient
Public Class Canciones

    Public Property album As String
    Public Property fecha As String
    Public Property genero As String
    Public Property IdArtista As Integer
    Public Property IdCancion As Integer
    Public Property titulo As String
    Public Property ubicacion As String
    Public Sub New(album As String, fecha As String, genero As String, IdArtista As Integer, IdCancion As Integer, titulo As String, Ubicacion As String)
        Me.album = album
        Me.fecha = fecha
        Me.genero = genero
        Me.IdArtista = IdArtista
        Me.IdCancion = IdCancion
        Me.titulo = titulo
        Me.ubicacion = Ubicacion
    End Sub

    Public Function ObtenerCanciones()
        Dim conexion As New MySqlConnection
        conexion.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
        Try
            conexion.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM CANCION", conexion)
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
        conexion.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
        Try
            conexion.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM CANCION WHERE ID_CANCION = @ID", conexion)
            cmd.Parameters.AddWithValue("@ID", Me.IdCancion)
            Dim Reader As MySqlDataReader
            Reader = cmd.ExecuteReader()
            Reader.Read()
            Me.album = Reader("album")
            Me.fecha = Reader("fecha_lanzamiento")
            Me.genero = Reader("genero")
            Me.IdArtista = Reader("ID_ARTISTA")
            Me.IdCancion = Reader("ID_CANCION")
            Me.titulo = Reader("titulo")
            Me.ubicacion = Reader("ubicacion")
            Return True
        Catch ex As Exception
            MessageBox.Show("Fallo en la conexion, vuelva a intentar")
            Return False
        End Try
    End Function

    Public Function BorrarCancion()
        Dim conexion As New MySqlConnection
        conexion.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
        Try
            conexion.Open()
            Dim cmd As New MySqlCommand("DELETE FROM CANCION WHERE ID_CANCION = @ID", conexion)
            cmd.Parameters.AddWithValue("@ID", Me.IdCancion)
            Dim response As New Integer
            response = cmd.ExecuteNonQuery()
            If (response > 0) Then
                MessageBox.Show("Se ha borrado la cancion de forma exitosa")
            Else
                MessageBox.Show("No se encontró registro de la cancion seleccionada")
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("Fallo en la conexion, vuelva a intentar")
            Return False
        End Try
    End Function

End Class
