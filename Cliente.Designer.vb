<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Cliente))
        button5 = New Button()
        button3 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        pictureBox1 = New PictureBox()
        label2 = New Label()
        label1 = New Label()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' button5
        ' 
        button5.BackColor = Color.Red
        button5.FlatStyle = FlatStyle.Flat
        button5.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point)
        button5.ForeColor = Color.White
        button5.Location = New Point(150, 366)
        button5.Name = "button5"
        button5.Size = New Size(160, 36)
        button5.TabIndex = 32
        button5.Text = "Cerrar sesión"
        button5.UseVisualStyleBackColor = False
        ' 
        ' button3
        ' 
        button3.BackColor = Color.DodgerBlue
        button3.FlatStyle = FlatStyle.Flat
        button3.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point)
        button3.ForeColor = Color.White
        button3.Location = New Point(150, 298)
        button3.Name = "button3"
        button3.Size = New Size(160, 36)
        button3.TabIndex = 30
        button3.Text = "Editar usuario"
        button3.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.DodgerBlue
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.White
        Button6.Location = New Point(150, 256)
        Button6.Name = "Button6"
        Button6.Size = New Size(160, 36)
        Button6.TabIndex = 29
        Button6.Text = "Crear playlist"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.DodgerBlue
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.ForeColor = Color.White
        Button7.Location = New Point(150, 214)
        Button7.Name = "Button7"
        Button7.Size = New Size(160, 36)
        Button7.TabIndex = 28
        Button7.Text = "Ver Playlist"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' pictureBox1
        ' 
        pictureBox1.BackgroundImageLayout = ImageLayout.None
        pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Image)
        pictureBox1.Location = New Point(162, 59)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(131, 123)
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox1.TabIndex = 27
        pictureBox1.TabStop = False
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        label2.Location = New Point(183, 30)
        label2.Name = "label2"
        label2.Size = New Size(94, 21)
        label2.TabIndex = 26
        label2.Text = "CLIENTE"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        label1.Location = New Point(203, 9)
        label1.Name = "label1"
        label1.Size = New Size(58, 21)
        label1.TabIndex = 25
        label1.Text = "MENU"
        ' 
        ' Cliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(496, 450)
        Controls.Add(button5)
        Controls.Add(button3)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(pictureBox1)
        Controls.Add(label2)
        Controls.Add(label1)
        Name = "Cliente"
        Text = "Cliente"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private WithEvents button5 As Button
    Private WithEvents button3 As Button
    Private WithEvents Button6 As Button
    Private WithEvents Button7 As Button
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
