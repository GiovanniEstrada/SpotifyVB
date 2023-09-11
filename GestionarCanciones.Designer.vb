<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarCanciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pictureBox1 = New PictureBox()
        label2 = New Label()
        Label1 = New Label()
        Nombre = New TextBox()
        ArtistaID = New TextBox()
        Label3 = New Label()
        ListBox1 = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        ListBox2 = New ListBox()
        Button3 = New Button()
        Button4 = New Button()
        Fecha = New TextBox()
        Label4 = New Label()
        Album = New TextBox()
        Label5 = New Label()
        Genero = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureBox1
        ' 
        pictureBox1.BackgroundImageLayout = ImageLayout.None
        pictureBox1.Image = My.Resources.Resources.logoCancion
        pictureBox1.Location = New Point(64, 171)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(131, 123)
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox1.TabIndex = 21
        pictureBox1.TabStop = False
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        label2.Location = New Point(12, 134)
        label2.Name = "label2"
        label2.Size = New Size(238, 21)
        label2.TabIndex = 20
        label2.Text = "GESTIONAR CANCIONES"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(345, 1)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 22
        Label1.Text = "Nombre"
        ' 
        ' Nombre
        ' 
        Nombre.Location = New Point(345, 19)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(336, 23)
        Nombre.TabIndex = 23
        ' 
        ' ArtistaID
        ' 
        ArtistaID.Location = New Point(345, 154)
        ArtistaID.Name = "ArtistaID"
        ArtistaID.Size = New Size(336, 23)
        ArtistaID.TabIndex = 25
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(345, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 24
        Label3.Text = "Artista"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(345, 177)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(336, 79)
        ListBox1.TabIndex = 26
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(345, 262)
        Button1.Name = "Button1"
        Button1.Size = New Size(336, 31)
        Button1.TabIndex = 27
        Button1.Text = "Seleccionar archivo"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(531, 321)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 31)
        Button2.TabIndex = 28
        Button2.Text = "Actualizar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(345, 368)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(336, 79)
        ListBox2.TabIndex = 29
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(345, 454)
        Button3.Name = "Button3"
        Button3.Size = New Size(336, 31)
        Button3.TabIndex = 30
        Button3.Text = "Eliminar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(345, 321)
        Button4.Name = "Button4"
        Button4.Size = New Size(150, 31)
        Button4.TabIndex = 31
        Button4.Text = "Agregar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Fecha
        ' 
        Fecha.Location = New Point(345, 65)
        Fecha.Name = "Fecha"
        Fecha.Size = New Size(150, 23)
        Fecha.TabIndex = 33
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(345, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 15)
        Label4.TabIndex = 32
        Label4.Text = "Fecha de inicio"
        ' 
        ' Album
        ' 
        Album.Location = New Point(531, 65)
        Album.Name = "Album"
        Album.Size = New Size(150, 23)
        Album.TabIndex = 35
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(531, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 34
        Label5.Text = "Album"
        ' 
        ' Genero
        ' 
        Genero.Location = New Point(531, 115)
        Genero.Name = "Genero"
        Genero.Size = New Size(150, 23)
        Genero.TabIndex = 37
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(531, 97)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 15)
        Label6.TabIndex = 36
        Label6.Text = "Género"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.Control
        Label7.ForeColor = Color.Green
        Label7.Location = New Point(358, 296)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 56
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GestionarCanciones
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 492)
        Controls.Add(Label7)
        Controls.Add(Genero)
        Controls.Add(Label6)
        Controls.Add(Album)
        Controls.Add(Label5)
        Controls.Add(Fecha)
        Controls.Add(Label4)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(ListBox2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(ArtistaID)
        Controls.Add(Label3)
        Controls.Add(Nombre)
        Controls.Add(Label1)
        Controls.Add(pictureBox1)
        Controls.Add(label2)
        Name = "GestionarCanciones"
        Text = "GestionarCancioes"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Nombre As TextBox
    Friend WithEvents ArtistaID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Fecha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Album As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Genero As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
