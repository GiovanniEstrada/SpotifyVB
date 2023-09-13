Imports SpotifyVB.Usuarios
Imports WMPLib

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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim playlist As New CrearPlaylist(Me.cliente)
        playlist.Show()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim login As New Form1
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim verPlaylist As New VerPlaylist(Me.cliente)
        verPlaylist.Show()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim editar As New EditarUsuario(Me.cliente)
        editar.Show()
    End Sub
End Class