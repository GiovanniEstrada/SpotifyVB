Imports SpotifyVB.Usuarios
Public Class Cliente

    Public Property cliente As New Usuarios("", "", "", "", "")

    Public Sub New(cliente As Usuarios)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Me.cliente = cliente

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim playlist As New CrearPlaylist(Me.cliente)
        playlist.Show()
    End Sub
End Class