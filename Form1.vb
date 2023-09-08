Imports MySql.Data.MySqlClient
Imports SpotifyVB.Usuarios
Imports SpotifyVB.Register
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim reg As New Register
        reg.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim reg As New Register
        reg.Show()
        Me.Hide()
    End Sub

    Private Sub button1_Click_1(sender As Object, e As EventArgs) Handles button1.Click
        Dim login As New Usuarios("", "", UserLogin.Text.ToString(), PwdLogin.Text.ToString(), "")
        If login.ConsultarUsuario() Then
            MessageBox.Show("Bienvenido " & login.Nombre.ToString())
            If login.TipoUser = "ADMIN" Then
                Dim admin As New Admin(login)
                admin.Show()
                Me.Hide()
            Else
                Dim cliente As New Cliente(login)
                cliente.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Usuario y/o Contraseña incorrecto, vuelve a intentarlo")
        End If
    End Sub
End Class
