﻿Imports MySql.Data.MySqlClient

Public Class GestionarCanciones
    Private Property reader As MySqlDataReader
    Private Property idCancion As Integer
    Private Property idArtista As Integer
    Private Property ruta As String
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim artistas As New Artista(0, "", "", "", "")
        reader = artistas.ObtenerArtistas()
        While reader.Read()
            Dim item As New Items
            item.Value = reader("ID_ARTISTA")
            item.Text = reader("NOMBRE")
            ListBox1.Items.Add(item)
        End While

        Dim cancion As New Canciones("", "", "", 0, 0, "", "")
        reader = cancion.ObtenerCanciones()
        While reader.Read()
            Dim item As New Items
            item.Value = reader("ID_CANCION")
            item.Text = reader("titulo")
            ListBox2.Items.Add(item)
        End While

        ArtistaID.Enabled = False
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ArtistaID.Text = ListBox1.SelectedItem.Text.ToString()
        Me.idArtista = CInt(ListBox1.SelectedItem.Value)
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim cancion As New Canciones("", "", "", 0, 0, "", "")
        Dim artista As New Artista(0, "", "", "", "")
        cancion.IdCancion = CInt(ListBox2.SelectedItem.Value)
        Nombre.Text = ListBox2.SelectedItem.Text
        cancion.buscarPorID()
        Genero.Text = cancion.genero.ToString()
        Album.Text = cancion.album.ToString()
        Fecha.Text = cancion.fecha.ToString()
        Label7.Text = cancion.ubicacion.ToString()
        artista.ID = cancion.IdArtista.ToString()
        ruta = cancion.ubicacion()
        If (artista.buscarPorID()) Then
            ArtistaID.Text = artista.Nombre.ToString()
        End If
        Me.idCancion = ListBox2.SelectedItem.Value

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cancion As New Canciones("", "", "", 0, Me.idCancion, "", "")
        cancion.BorrarCancion()

        'ACTUALIZAR LA LISTA DE CANCIONES
        reader = cancion.ObtenerCanciones()
        ListBox2.Items.Clear()
        While reader.Read()
            Dim item As New Items
            item.Value = reader("ID_CANCION")
            item.Text = reader("titulo")
            ListBox2.Items.Add(item)
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cancion As New Canciones(Album.Text.ToString(), Fecha.Text.ToString(), Genero.Text.ToString(), Me.idArtista, 0, Nombre.Text.ToString(), ruta)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.InitialDirectory = "C:\\"
        openFileDialog.Filter = "Audio Files|*.mp3;*.wav;*.wma;*.flac"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ruta = openFileDialog.FileName.ToString()
        End If
        Label7.Text = ruta
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cancion As New Canciones(Album.Text.ToString(), Fecha.Text.ToString(), Genero.Text.ToString(), Me.idArtista, 0, Nombre.Text.ToString(), ruta)
        cancion.CrearCancion()
    End Sub

    Private Sub GestionarCanciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class