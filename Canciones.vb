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

End Class
