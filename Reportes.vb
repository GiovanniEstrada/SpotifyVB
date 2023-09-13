Imports MySql.Data.MySqlClient
Imports SpotifyVB.ConsultasReporte
Public Class Reportes
    Private Property reader As MySqlDataReader
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consultas As New ConsultasReporte()
        reader = consultas.ReporteCancionesPorArtistas()
        While reader.Read()
            DataGridView1.Rows.Add(reader("NOMBRE"), reader("CANCIONES"))
        End While

        reader = consultas.ReporteCancionesPorPlaylist()

        While reader.Read()
            DataGridView2.Rows.Add(reader("PLAYLIST"), reader("CANCIONES"))
        End While

        reader = consultas.ReportePlaylistPorUsuarios()
        While reader.Read()
            DataGridView4.Rows.Add(reader("USUARIO"), reader("CANTIDAD"))
        End While

        reader = consultas.ReporteTotalCanciones()
        Dim totalUsuarios As Integer
        Dim totalCanciones As Integer
        While reader.Read()
            totalCanciones = reader("TOTAL")
        End While
        reader = consultas.ReporteTotalUsuarios()
        While reader.Read()
            totalUsuarios = reader("TOTAL")
        End While
        DataGridView3.Rows.Add(totalCanciones, totalUsuarios)


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class