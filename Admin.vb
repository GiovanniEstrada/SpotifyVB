Imports SpotifyVB.GestionarUsuario
Imports SpotifyVB.Usuarios
Imports SpotifyVB.Items
Imports MySql.Data.MySqlClient

Public Class Admin

    Public Property usuario As Usuarios
    Public Sub New(usuario As Usuarios)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Me.usuario = usuario


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim gestionUsuario As New GestionarUsuario(usuario)
        gestionUsuario.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim gestionarCancion As New GestionarCanciones()
        gestionarCancion.Show()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim login As New Form1
        login.Show()
        Me.Hide()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim gestionarArtista As New GestionarArtista()
        gestionarArtista.Show()
    End Sub
End Class