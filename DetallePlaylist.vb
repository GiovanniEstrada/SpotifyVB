Imports MySql.Data.MySqlClient

Public Class DetallePlaylist

    Public Property ID As Integer
    Public Property Playlist As Integer
    Public Property Cancion As Integer

    Public Sub New(id As Integer, playlist As Integer, Cancion As Integer)
        Me.ID = id
        Me.Playlist = playlist
        Me.Cancion = Cancion
    End Sub

    Public Function CrearDetalle()
        Dim conn As New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
        Try
            conn.Open()
            Dim command As New MySqlCommand("INSERT INTO detalle_playlist (ID_PLAYLIST, ID_CANCION) VALUES (@Playlist, @Cancion)", conn)
            command.Parameters.AddWithValue("@Playlist", Me.Playlist)
            command.Parameters.AddWithValue("@Cancion", Me.Cancion)
            Dim rows As Integer = command.ExecuteNonQuery()
            If (rows > 0) Then
                conn.Close()
                Return True
            Else
                conn.Close()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error al conectarse al servidor")
            conn.Close()
        End Try
        Return False
    End Function

End Class
