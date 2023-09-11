Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports SpotifyVB.Usuarios
Imports SpotifyVB.Items
Public Class CrearPlaylist

    Public Property cliente As New Usuarios("", "", "", "", "")
    Dim reader As MySqlDataReader
    Dim ruta As String = ""
    Public Sub New(c As Usuarios)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.cliente = c
        Dim canciones As New Canciones("", "", "", 0, 0, "", "")
        reader = canciones.ObtenerCanciones()
        While reader.Read()
            Dim item As New Items()
            item.Value = reader("ID_CANCION").ToString()
            item.Text = reader("titulo").ToString()
            Box.Items.Add(item)
        End While

    End Sub
    Private Sub CrearPlaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Canciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Box.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'BOTON QUE CREA LA PLAYLIST
        Dim fecha As New Date
        fecha = Today
        If (ruta.Equals("") Or Nombre.Text.ToString().Equals("")) Then
            MessageBox.Show("Faltan campos")
        Else
            Dim playlist As New Playlist("", cliente.ID, Nombre.Text.ToString(), fecha.ToString(), ruta)
            playlist.CrearPlaylist()
            For Each item In Box.CheckedItems
                Dim idplaylist As Integer = CInt(playlist.id)
                Dim idcancion As Integer = CInt(item.Value)
                Dim detalle As New DetallePlaylist(0, idplaylist, idcancion)
                detalle.CrearDetalle()
            Next
            MessageBox.Show("Playlist creada!!")
        End If

    End Sub

    Private Sub Nombre_TextChanged(sender As Object, e As EventArgs) Handles Nombre.TextChanged

    End Sub

    Private Function AbrirExplorador()
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.InitialDirectory = "C:\\"
        openFileDialog.Filter = "Imagenes|*.jpg;*.png;*.gif;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Return openFileDialog.FileName.ToString()
        End If
        Return ""
    End Function

    Private Sub ImagenUrl_Click(sender As Object, e As EventArgs) Handles ImagenUrl.Click
        ruta = AbrirExplorador()
        Label2.Text = ruta
        pictureBox1.Image = Image.FromFile(ruta)
    End Sub
End Class