Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient

Public Class VerPlaylist

    Public Property Reader As MySqlDataReader
    Public Property usuario As New Usuarios("", "", "", "", "")
    Public Sub New(usuario As Usuarios)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim playlist As New Playlist(0, usuario.ID, "", "", "")
        Me.usuario = usuario
        Reader = playlist.ObtenerPorUsuario()
        While Reader.Read()
            Dim item As New Items
            item.Value = Reader("ID_PLAYLIST")
            item.Text = Reader("nombre_playlist")
            ListBox2.Items.Add(item)
        End While

    End Sub
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim playlist As New Playlist(ListBox2.SelectedItem.Value.ToString(), "", "", "", "")
        Dim editar As New EditarPlaylist(Me.usuario, playlist)
        editar.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim playlist As New Playlist(ListBox2.SelectedItem.Value.ToString(), "", "", "", "")
        Dim reproducir As New ReproducirPlaylist(Playlist)
        reproducir.Show()
    End Sub
End Class