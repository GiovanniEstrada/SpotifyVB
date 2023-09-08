Imports MySql.Data.MySqlClient
Public Class Playlist
    Public Property id As String
    Public Property usuarioID As String
    Public Property nombre As String
    Public Property fecha As String
    Public urlImg As String

    Public Sub New(id As String, usuario As String, nombre As String, fecha As String, url As String)
        Me.id = id
        Me.usuarioID = usuario
        Me.nombre = nombre
        Me.fecha = fecha
        Me.urlImg = url
    End Sub

    'Creamos el CRUD
    'CREATE
    Public Function CrearPlaylist()
        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
        Try
            conn.Open()
            Dim command As New MySqlCommand("INSERT INTO PLAYLIST (ID_USUARIO, nombre_playlist, fecha_creacion, img_cover) VALUES (@USERID, @NAME, @DATE, @URL")
            command.Parameters.AddWithValue("@USERID", Me.usuarioID)
            command.Parameters.AddWithValue("@NAME", Me.nombre)
            command.Parameters.AddWithValue("@DATE", Me.fecha)
            command.Parameters.AddWithValue("@URL", Me.urlImg)
            Dim rows As Integer = command.ExecuteNonQuery()
            If (rows > 0) Then
                ObtenerUltimoID()
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

    'READ
    Public Function ObtenerPorUsuario()
        Dim conn As New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM PLAYLIST WHERE ID_USUARIO = @ID_USUARIO")
            cmd.Parameters.AddWithValue("@ID_USUARIO", Me.usuarioID)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Return reader
        Catch ex As Exception
            MessageBox.Show("Hubo un error al conectarse al servidor")
        Finally
            conn.Close()
        End Try

        Return False
    End Function

    Public Function ObtenerUltimoID()
        Dim conn As New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT TOP 1 ID_PLAYLIST FROM PLAYLIST ORDER BY ID_PLAYLIST DESC")
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            reader.Read()
            Me.id = reader("ID_PLAYLIST").ToString()
        Catch ex As Exception
            MessageBox.Show("Hubo un error al conectarse al servidor")
        Finally
            conn.Close()
        End Try

        Return False
    End Function

    'UPDATE
    Public Function actualizarPlaylist(nwNombre As String, nwFecha As String, nwURL As String)
        Dim conn As New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE PLAYLIST SET nombre_playlist = @NOMBRE, fecha_creacion = @FECHA, img_cover = @URL WHERE ID_PLAYLIST = @ID")
            cmd.Parameters.AddWithValue("@NOMBRE", nwNombre)
            cmd.Parameters.AddWithValue("@FECHA", nwFecha)
            cmd.Parameters.AddWithValue("@URL", nwURL)
            cmd.Parameters.AddWithValue("@ID", Me.id)
            Dim response As Integer = cmd.ExecuteNonQuery()
            If response > 0 Then
                conn.Close()
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error al conectarse al servidor")
        Finally
            conn.Close()
        End Try
        Return False
    End Function

    'DELETE
    Public Function borrarPlaylist(nwNombre As String, nwFecha As String, nwURL As String)
        Dim conn As New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM PLAYLIST WHERE ID_PLAYLIST = @ID")
            cmd.Parameters.AddWithValue("@ID", Me.id)
            Dim response As Integer = cmd.ExecuteNonQuery()
            If response > 0 Then
                conn.Close()
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error al conectarse al servidor")
        Finally
            conn.Close()
        End Try
        Return False
    End Function

End Class
