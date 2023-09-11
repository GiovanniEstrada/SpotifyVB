Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient

Public Class GestionarArtista
    Private Property Reader As MySqlDataReader
    Private Property idArtista As Integer
    Private Property ruta As String

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Dim artistas As New Artista(0, "", "", "", "")
        Reader = artistas.ObtenerArtistas()
        While Reader.Read()
            Dim item As New Items
            item.Value = Reader("ID_ARTISTA")
            item.Text = Reader("NOMBRE")
            ListBox2.Items.Add(item)
        End While

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

        Me.idArtista = CInt(ListBox2.SelectedItem.Value)
        Dim artista As New Artista(idArtista, "", "", "", "")
        artista.buscarPorID()
        Nombre.Text = artista.Nombre
        Nacionalidad.Text = artista.Nacionalidad
        Fecha.Text = artista.Año
        Label3.Text = artista.Img
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim artista As New Artista(Me.idArtista, "", "", "", "")
        artista.BorrarArtista()
        Reader = artista.ObtenerArtistas()
        ListBox2.Items.Clear()
        While Reader.Read()
            Dim item As New Items
            item.Value = Reader("ID_ARTISTA")
            item.Text = Reader("NOMBRE")
            ListBox2.Items.Add(item)
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.InitialDirectory = "C:\\"
        openFileDialog.Filter = "Imagenes|*.jpg;*.png;*.gif;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ruta = openFileDialog.FileName.ToString()
        End If
        Label3.Text = ruta
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim artista As New Artista(0, Nombre.Text.ToString(), Nacionalidad.Text.ToString(), Fecha.Text.ToString(), ruta)
        artista.CrearArtista()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim artista As New Artista(Me.idArtista, Nombre.Text.ToString(), Nacionalidad.Text.ToString(), Fecha.Text.ToString(), ruta)
        artista.ActualizaArtista()
    End Sub

    Private Sub GestionarArtista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class