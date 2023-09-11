<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarPlaylist
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
        Label3 = New Label()
        Label = New Label()
        pictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        ImagenUrl = New Button()
        Box = New CheckedListBox()
        Nombre = New TextBox()
        Button1 = New Button()
        Label4 = New Label()
        Fecha = New TextBox()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(85, 272)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 15)
        Label3.TabIndex = 42
        Label3.Text = "Agregar canciones"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Location = New Point(85, 174)
        Label.Name = "Label"
        Label.Size = New Size(51, 15)
        Label.TabIndex = 41
        Label.Text = "Nombre"
        ' 
        ' pictureBox1
        ' 
        pictureBox1.BackColor = SystemColors.Control
        pictureBox1.BackgroundImageLayout = ImageLayout.None
        pictureBox1.Image = My.Resources.Resources.logoPlaylist
        pictureBox1.Location = New Point(170, 42)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(131, 123)
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox1.TabIndex = 40
        pictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(149, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 21)
        Label1.TabIndex = 39
        Label1.Text = "CREAR PLAYLIST"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(220, 469)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 38
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ImagenUrl
        ' 
        ImagenUrl.Location = New Point(126, 419)
        ImagenUrl.Name = "ImagenUrl"
        ImagenUrl.Size = New Size(192, 37)
        ImagenUrl.TabIndex = 37
        ImagenUrl.Text = "Seleccionar archivo"
        ImagenUrl.UseVisualStyleBackColor = True
        ' 
        ' Box
        ' 
        Box.BackColor = SystemColors.ButtonFace
        Box.BorderStyle = BorderStyle.FixedSingle
        Box.FormattingEnabled = True
        Box.Location = New Point(85, 301)
        Box.Name = "Box"
        Box.Size = New Size(314, 92)
        Box.TabIndex = 36
        ' 
        ' Nombre
        ' 
        Nombre.Location = New Point(85, 192)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(314, 23)
        Nombre.TabIndex = 35
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(117, 486)
        Button1.Name = "Button1"
        Button1.Size = New Size(225, 36)
        Button1.TabIndex = 34
        Button1.Text = "Editar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(85, 228)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 15)
        Label4.TabIndex = 44
        Label4.Text = "Fecha de creación"
        ' 
        ' Fecha
        ' 
        Fecha.Location = New Point(85, 246)
        Fecha.Name = "Fecha"
        Fecha.ReadOnly = True
        Fecha.Size = New Size(314, 23)
        Fecha.TabIndex = 43
        ' 
        ' EditarPlaylist
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(466, 549)
        Controls.Add(Label4)
        Controls.Add(Fecha)
        Controls.Add(Label3)
        Controls.Add(Label)
        Controls.Add(pictureBox1)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(ImagenUrl)
        Controls.Add(Box)
        Controls.Add(Nombre)
        Controls.Add(Button1)
        Name = "EditarPlaylist"
        Text = "EditarPlaylist"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ImagenUrl As Button
    Friend WithEvents Box As CheckedListBox
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Fecha As TextBox
End Class
