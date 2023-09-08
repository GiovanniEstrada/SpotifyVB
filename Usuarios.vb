Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class Usuarios
    Public Property Nombre As String
    Public Property Nickname As String
    Public Property PWD As String
    Public Property ID As String
    Public Property TipoUser

    Public Sub New(A As String, B As String, C As String, D As String, E As String)
        ID = A
        Nombre = B
        Nickname = C
        PWD = D
        TipoUser = E
    End Sub

    Public Function InsertarUsuario()
        'Se realiza la conexion al servidor
        Dim connection As New MySqlConnection
        connection.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
        Try
            connection.Open()
            Dim command As New MySqlCommand("INSERT INTO USUARIO (NAME, USERNAME, PWD, TIPO_USER) VALUES (@NAME, @USERNAME, @PWD, 'CLI')", connection)
            command.Parameters.AddWithValue("@NAME", Nombre)
            command.Parameters.AddWithValue("@USERNAME", Nickname)
            command.Parameters.AddWithValue("@PWD", PWD)
            Dim result = command.ExecuteNonQuery()
            If (result > 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Fallo en la conexion actual, vuelve a intentarlo " & ex.ToString())
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function ObtenerTodo()

        Dim connection As New MySqlConnection
        connection.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
        Try
            connection.Open()
            Dim command As New MySqlCommand("SELECT * FROM USUARIO", connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            Return reader
        Catch ex As Exception
            MessageBox.Show("Algo fallo en la conexion")
            Return False

        End Try
    End Function

    Public Function BorrarUsuario(id As String)
        Dim connection As New MySqlConnection
        connection.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
        Try
            connection.Open()
            Dim command As New MySqlCommand("DELETE FROM USUARIO WHERE ID = @ID", connection)
            command.Parameters.AddWithValue("@ID", id)
            Dim result = command.ExecuteNonQuery()
            If (result > 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Fallo en la conexion actual, vuelve a intentarlo")
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function ActualizarUsuario(nombre As String, usuario As String, contraseña As String)
        Dim connection As New MySqlConnection
        connection.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
        Try
            connection.Open()
            MessageBox.Show("Sistema conectado")
            Dim command As New MySqlCommand("UPDATE USUARIO SET NAME = @NAME, USERNAME = @USERNAME, PWD = @PWD WHERE ID = @ID", connection)
            command.Parameters.AddWithValue("@NAME", nombre)
            command.Parameters.AddWithValue("@USERNAME", usuario)
            command.Parameters.AddWithValue("@PWD", contraseña)
            command.Parameters.AddWithValue("@ID", ID)
            Dim result = command.ExecuteNonQuery()
            If (result > 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Fallo en la conexion actual, vuelve a intentarlo")
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function ConsultarUsuario()
        Dim connection As New MySqlConnection
        connection.ConnectionString = "server=localhost;user id=root;password=;database=prueba"
        Try
            connection.Open()
            Dim command As New MySqlCommand("SELECT * FROM USUARIO WHERE USERNAME = @USER AND PWD = @PWD", connection)
            command.Parameters.AddWithValue("@USER", Nickname)
            command.Parameters.AddWithValue("@PWD", PWD)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            reader.Read()
            ID = reader("ID").ToString()
            Nombre = reader("NAME").ToString()
            TipoUser = reader("TIPO_USER").ToString()
            Return True
        Catch ex As Exception
            MessageBox.Show("Algo fallo en la conexion")
            Return False

        End Try
    End Function

End Class
