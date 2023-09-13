Imports MySql.Data.MySqlClient

Public Class ConsultasReporte
    Private Property databaseSetup As String = "server=localhost;user id=root;password=;database=prueba"
    Public Function ReporteCancionesPorArtistas()

        Dim connection As New MySqlConnection
        connection.ConnectionString = databaseSetup
        Try
            connection.Open()
            Dim command As New MySqlCommand("SELECT A.NOMBRE AS NOMBRE, COUNT(B.titulo) AS CANCIONES FROM ARTISTA A LEFT JOIN cancion B ON A.ID_ARTISTA = B.ID_ARTISTA GROUP BY A.NOMBRE", connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            Return reader
        Catch ex As Exception
            MessageBox.Show("Algo fallo en la conexion")
            Return False

        End Try
    End Function


    Public Function ReporteCancionesPorPlaylist()

        Dim connection As New MySqlConnection
        connection.ConnectionString = databaseSetup
        Try
            connection.Open()
            Dim command As New MySqlCommand("SELECT A.nombre_playlist AS PLAYLIST, COUNT(B.ID_CANCION) AS CANCIONES FROM PLAYLIST A LEFT JOIN detalle_playlist B ON A.ID_PLAYLIST = B.ID_PLAYLIST GROUP BY A.nombre_playlist;", connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            Return reader
        Catch ex As Exception
            MessageBox.Show("Algo fallo en la conexion")
            Return False

        End Try
    End Function

    Public Function ReportePlaylistPorUsuarios()

        Dim connection As New MySqlConnection
        connection.ConnectionString = databaseSetup
        Try
            connection.Open()
            Dim command As New MySqlCommand("SELECT A.USERNAME AS USUARIO, COUNT(B.nombre_playlist) AS CANTIDAD FROM USUARIO A LEFT JOIN PLAYLIST B ON A.ID = B.ID_USUARIO GROUP BY A.USERNAME", connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            Return reader
        Catch ex As Exception
            MessageBox.Show("Algo fallo en la conexion")
            Return False

        End Try
    End Function

    Public Function ReporteTotalCanciones()

        Dim connection As New MySqlConnection
        connection.ConnectionString = databaseSetup
        Try
            connection.Open()
            Dim command As New MySqlCommand("SELECT COUNT(*) AS TOTAL FROM CANCION", connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            Return reader
        Catch ex As Exception
            MessageBox.Show("Algo fallo en la conexion")
            Return False

        End Try
    End Function

    Public Function ReporteTotalUsuarios()

        Dim connection As New MySqlConnection
        connection.ConnectionString = databaseSetup
        Try
            connection.Open()
            Dim command As New MySqlCommand("SELECT COUNT(*) AS TOTAL FROM USUARIO", connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            Return reader
        Catch ex As Exception
            MessageBox.Show("Algo fallo en la conexion")
            Return False

        End Try
    End Function


End Class
