Imports MySql.Data.MySqlClient
Imports SpotifyVB.Usuarios
Public Class Register
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        If Contraseña1Lbl.Text.ToString() = Contraseña2Lbl.Text.ToString() Then
            Dim registro As New Usuarios("", NombreLbl.Text, UsernameLbl.Text, Contraseña1Lbl.Text, "CLI")
            registro.InsertarUsuario()
        Else
            MessageBox.Show("Contraseñas no coinciden, vuelve a intentar")
        End If

    End Sub
End Class