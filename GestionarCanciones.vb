Imports MySql.Data.MySqlClient

Public Class GestionarCanciones
    Private Property reader As MySqlDataReader
    Private Property idCancion As Integer
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
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox2.Text = ListBox1.SelectedItem.Text.ToString()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim cancion As New Canciones("", "", "", 0, 0, "", "")
        Dim artista As New Artista(0, "", "", "", "")
        cancion.IdCancion = CInt(ListBox2.SelectedItem.Value)
        TextBox1.Text = ListBox2.SelectedItem.Text
        cancion.buscarPorID()
        artista.ID = cancion.IdArtista.ToString()
        If (artista.buscarPorID()) Then
            TextBox2.Text = artista.Nombre.ToString()
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
End Class