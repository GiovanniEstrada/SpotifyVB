﻿Imports SpotifyVB.GestionarUsuario
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

End Class