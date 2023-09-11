<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarArtista
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
        Fecha = New TextBox()
        Label5 = New Label()
        Nacionalidad = New TextBox()
        Label4 = New Label()
        Button4 = New Button()
        Button3 = New Button()
        ListBox2 = New ListBox()
        Button2 = New Button()
        Nombre = New TextBox()
        Label1 = New Label()
        pictureBox1 = New PictureBox()
        label2 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Fecha
        ' 
        Fecha.Location = New Point(530, 122)
        Fecha.Name = "Fecha"
        Fecha.Size = New Size(150, 23)
        Fecha.TabIndex = 53
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(530, 104)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 15)
        Label5.TabIndex = 52
        Label5.Text = "Fecha inicio"
        ' 
        ' Nacionalidad
        ' 
        Nacionalidad.Location = New Point(344, 122)
        Nacionalidad.Name = "Nacionalidad"
        Nacionalidad.Size = New Size(150, 23)
        Nacionalidad.TabIndex = 51
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(344, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 15)
        Label4.TabIndex = 50
        Label4.Text = "Nacionalidad"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(344, 215)
        Button4.Name = "Button4"
        Button4.Size = New Size(150, 31)
        Button4.TabIndex = 49
        Button4.Text = "Agregar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(344, 348)
        Button3.Name = "Button3"
        Button3.Size = New Size(336, 31)
        Button3.TabIndex = 48
        Button3.Text = "Eliminar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(344, 262)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(336, 79)
        ListBox2.TabIndex = 47
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(530, 215)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 31)
        Button2.TabIndex = 46
        Button2.Text = "Actualizar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Nombre
        ' 
        Nombre.Location = New Point(344, 76)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(336, 23)
        Nombre.TabIndex = 41
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(344, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 40
        Label1.Text = "Nombre"
        ' 
        ' pictureBox1
        ' 
        pictureBox1.BackgroundImageLayout = ImageLayout.None
        pictureBox1.Image = My.Resources.Resources.logoCancion
        pictureBox1.Location = New Point(65, 156)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(131, 123)
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox1.TabIndex = 39
        pictureBox1.TabStop = False
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        label2.Location = New Point(13, 119)
        label2.Name = "label2"
        label2.Size = New Size(226, 21)
        label2.TabIndex = 38
        label2.Text = "GESTIONAR ARTISTAS"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(344, 156)
        Button1.Name = "Button1"
        Button1.Size = New Size(336, 31)
        Button1.TabIndex = 54
        Button1.Text = "Seleccionar Archivo"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(353, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 55
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GestionarArtista
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Fecha)
        Controls.Add(Label5)
        Controls.Add(Nacionalidad)
        Controls.Add(Label4)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(ListBox2)
        Controls.Add(Button2)
        Controls.Add(Nombre)
        Controls.Add(Label1)
        Controls.Add(pictureBox1)
        Controls.Add(label2)
        Name = "GestionarArtista"
        Text = "GestionarArtista"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Fecha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Nacionalidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Label1 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
