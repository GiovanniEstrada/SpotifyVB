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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        ListBox1 = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        ListBox2 = New ListBox()
        Button3 = New Button()
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
        Label1.Location = New Point(345, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 22
        Label1.Text = "Nombre"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(345, 61)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(336, 23)
        TextBox1.TabIndex = 23
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(345, 111)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(336, 23)
        TextBox2.TabIndex = 25
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(345, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 24
        Label3.Text = "Artista"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(345, 134)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(336, 79)
        ListBox1.TabIndex = 26
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(345, 219)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 31)
        Button1.TabIndex = 27
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(531, 219)
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
        ListBox2.Location = New Point(345, 271)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(336, 79)
        ListBox2.TabIndex = 29
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(345, 367)
        Button3.Name = "Button3"
        Button3.Size = New Size(336, 31)
        Button3.TabIndex = 30
        Button3.Text = "Eliminar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' GestionarCanciones
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(ListBox2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button3 As Button
End Class
