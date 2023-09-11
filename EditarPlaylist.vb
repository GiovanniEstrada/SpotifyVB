Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient

Public Class EditarPlaylist
    Public Property cliente As New Usuarios("", "", "", "", "")
    Public Property playlist As New Playlist("", "", "", "", "")
    Dim reader As MySqlDataReader
    Dim ruta As String = ""
    Public Sub New(c As Usuarios, p As Playlist)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cliente = c
        Me.playlist = p
        Dim canciones As New Canciones("", "", "", 0, 0, "", "")
        Dim detalle As New DetallePlaylist(0, p.id, 0)

        playlist.ObtenerPorID()
        Nombre.Text = playlist.nombre.ToString()
        Fecha.Text = playlist.fecha.ToString()
        reader = canciones.ObtenerCanciones()
        While reader.Read()
            Dim item As New Items()
            item.Value = reader("ID_CANCION").ToString()
            item.Text = reader("titulo").ToString()
            Box.Items.Add(item)
        End While

        Nombre.Text = playlist.nombre
        detalle.Playlist = playlist.id
        reader = detalle.BuscarPorPlaylist()
        While reader.Read()
            For i As Integer = 0 To Box.Items.Count - 1
                If Box.Items(i).Value = reader("ID_CANCION") Then
                    Box.SetItemChecked(i, True)
                End If
            Next
        End While

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim plist As New Playlist(Me.playlist.id.ToString(), cliente.ID.ToString(), Nombre.Text.ToString(), Fecha.Text.ToString(), ruta)
        plist.actualizarPlaylist(Nombre.Text.ToString(), ruta)
        'Se limpia la linea de detalles
        Dim detalle As New DetallePlaylist(0, Me.playlist.id, 0)
        detalle.BorrarPorPlaylist()

        For Each item In Box.CheckedItems
            detalle.Playlist = CInt(Me.playlist.id)
            detalle.Cancion = CInt(item.Value)
            detalle.CrearDetalle()
        Next
        Dim canciones As New Canciones("", "", "", 0, 0, "", "")
    End Sub

    Private Sub ImagenUrl_Click(sender As Object, e As EventArgs) Handles ImagenUrl.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.InitialDirectory = "C:\\"
        openFileDialog.Filter = "Imagenes|*.jpg;*.png;*.gif;*.bmp"
        ruta = ""

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ruta = openFileDialog.FileName.ToString()
        End If
    End Sub
End Class