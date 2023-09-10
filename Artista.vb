Imports MySql.Data.MySqlClient

Public Class Artista
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Nacionalidad As String
    Public Property Año As String
    Public Property Img As String

    Public Sub New(id As Integer, nombre As String, nacionalidad As String, año As String, Img As String)
        Me.ID = id
        Me.Nombre = nombre
        Me.Nacionalidad = nacionalidad
        Me.Año = año
        Me.Img = Img
    End Sub

    Public Function ObtenerArtistas()
        Dim conexion As New MySqlConnection
        conexion.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
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
        conexion.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
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

End Class
