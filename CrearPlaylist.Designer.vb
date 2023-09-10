<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearPlaylist
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
        Button1 = New Button()
        Nombre = New TextBox()
        Box = New CheckedListBox()
        ImagenUrl = New Button()
        Label2 = New Label()
        pictureBox1 = New PictureBox()
        Label1 = New Label()
        Label = New Label()
        Label3 = New Label()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(152, 497)
        Button1.Name = "Button1"
        Button1.Size = New Size(225, 36)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Nombre
        ' 
        Nombre.Location = New Point(120, 224)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(314, 23)
        Nombre.TabIndex = 1
        ' 
        ' Box
        ' 
        Box.BackColor = SystemColors.ButtonFace
        Box.BorderStyle = BorderStyle.FixedSingle
        Box.FormattingEnabled = True
        Box.Location = New Point(120, 292)
        Box.Name = "Box"
        Box.Size = New Size(314, 92)
        Box.TabIndex = 2
        ' 
        ' ImagenUrl
        ' 
        ImagenUrl.Location = New Point(161, 410)
        ImagenUrl.Name = "ImagenUrl"
        ImagenUrl.Size = New Size(192, 37)
        ImagenUrl.TabIndex = 3
        ImagenUrl.Text = "Seleccionar archivo"
        ImagenUrl.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(255, 460)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 5
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pictureBox1
        ' 
        pictureBox1.BackColor = SystemColors.Control
        pictureBox1.BackgroundImageLayout = ImageLayout.None
        pictureBox1.Image = My.Resources.Resources.logoPlaylist
        pictureBox1.Location = New Point(205, 65)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(131, 123)
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox1.TabIndex = 31
        pictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(184, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 21)
        Label1.TabIndex = 30
        Label1.Text = "CREAR PLAYLIST"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Location = New Point(120, 196)
        Label.Name = "Label"
        Label.Size = New Size(51, 15)
        Label.TabIndex = 32
        Label.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(120, 263)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 15)
        Label3.TabIndex = 33
        Label3.Text = "Agregar canciones"
        ' 
        ' CrearPlaylist
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(545, 548)
        Controls.Add(Label3)
        Controls.Add(Label)
        Controls.Add(pictureBox1)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(ImagenUrl)
        Controls.Add(Box)
        Controls.Add(Nombre)
        Controls.Add(Button1)
        Name = "CrearPlaylist"
        Text = "CrearPlaylist"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Box As CheckedListBox
    Friend WithEvents ImagenUrl As Button
    Friend WithEvents Label2 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents Label1 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label3 As Label
End Class
