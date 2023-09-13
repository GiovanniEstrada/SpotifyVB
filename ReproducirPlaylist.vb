Imports MySql.Data.MySqlClient

Public Class ReproducirPlaylist
    Public Property playlist As New Playlist("", "", "", "", "")
    Public Property reader As MySqlDataReader
    Private Property player As New WMPLib.WindowsMediaPlayer
    Public Sub New(p As Playlist)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        playlist = p
        Dim detalle As New DetallePlaylist(0, playlist.id, 0)
        Dim canciones As New Canciones("", "", "", 0, 0, "", "")
        reader = detalle.BuscarPorPlaylist()
        While reader.Read()
            Dim item As New Items

            canciones.IdCancion = reader("ID_CANCION")
            canciones.buscarPorID()
            item.Value = reader("ID_CANCION")
            item.Text = canciones.titulo
            ListBox2.Items.Add(item)
        End While

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

        player.controls.stop()
        Dim cancion As New Canciones("", "", "", 0, CInt(ListBox2.SelectedItem.Value), "", "")
        cancion.buscarPorID()
        player.URL = cancion.ubicacion
        player.controls.play()
    End Sub

    Private Sub ReproducirPlaylist_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        player.controls.stop()
    End Sub
End Class