Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports SpotifyVB.Usuarios
Public Class CrearPlaylist

    Public Property cliente As New Usuarios("", "", "", "", "")
    Dim reader As MySqlDataReader
    Public Sub New(c As Usuarios)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.cliente = c
        Label1.Text = Me.cliente.Nombre

        Dim canciones As New Canciones("", "", "", 0, 0, "", "")
        reader = canciones.ObtenerCanciones()
        While reader.Read()
            Box.Items.Add(reader("titulo"))
        End While

    End Sub
    Private Sub CrearPlaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Canciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Box.SelectedIndexChanged

    End Sub
End Class