Public Class EditarUsuario
    Public Property usuario As New Usuarios("", "", "", "", "")
    Public Sub New(u As Usuarios)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        usuario = u
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        If Contraseña1Lbl.Text.Equals(Contraseña2Lbl.Text) Then
            usuario.Nombre = NombreLbl.Text.ToString()
            usuario.PWD = Contraseña1Lbl.Text.ToString()
            usuario.ActualizarUsuario()
        Else
            MessageBox.Show("Contraseña no coincide, vuelva a intentar")
        End If

    End Sub
End Class