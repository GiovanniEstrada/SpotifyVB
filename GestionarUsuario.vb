Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports SpotifyVB.Usuarios
Imports SpotifyVB.Items

Public Class GestionarUsuario

    Public Property usuario As Usuarios
    Dim reader As MySqlDataReader

    Public Sub New(usuario As Usuarios)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.usuario = usuario
        reader = Me.usuario.ObtenerTodo()
        While reader.Read()
            Dim item As New Items()
            item.Value = reader("ID").ToString()
            item.Text = reader("USERNAME").ToString()
            Listado.Items.Add(item)
        End While

    End Sub
    Private Sub GestionarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim id As Items
        Try
            id = Listado.SelectedItem
            If usuario.BorrarUsuario(id.Value) Then
                MessageBox.Show("Usuario " & Listado.SelectedText.ToString() & " eliminado")
                reader = usuario.ObtenerTodo()
                Listado.Items.Clear()
                While reader.Read()
                    Dim item As New Items()
                    item.Value = reader("ID").ToString()
                    item.Text = reader("USERNAME").ToString()
                    Listado.Items.Add(item)
                End While
            Else
                MessageBox.Show("No se encontró usuario especificado")
            End If
        Catch ex As Exception
            MessageBox.Show("Usuario no existe")
        End Try

    End Sub
End Class