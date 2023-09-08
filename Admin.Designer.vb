<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Admin))
        pictureBox1 = New PictureBox()
        label2 = New Label()
        label1 = New Label()
        button5 = New Button()
        button4 = New Button()
        button3 = New Button()
        button2 = New Button()
        button1 = New Button()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureBox1
        ' 
        pictureBox1.BackgroundImageLayout = ImageLayout.None
        pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Image)
        pictureBox1.Location = New Point(215, 59)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(131, 123)
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox1.TabIndex = 19
        pictureBox1.TabStop = False
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        label2.Location = New Point(197, 28)
        label2.Name = "label2"
        label2.Size = New Size(166, 21)
        label2.TabIndex = 18
        label2.Text = "ADMINISTRADOR"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        label1.Location = New Point(249, 7)
        label1.Name = "label1"
        label1.Size = New Size(58, 21)
        label1.TabIndex = 17
        label1.Text = "MENU"
        ' 
        ' button5
        ' 
        button5.BackColor = Color.Red
        button5.FlatStyle = FlatStyle.Flat
        button5.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point)
        button5.ForeColor = Color.White
        button5.Location = New Point(203, 401)
        button5.Name = "button5"
        button5.Size = New Size(160, 36)
        button5.TabIndex = 24
        button5.Text = "Cerrar sesión"
        button5.UseVisualStyleBackColor = False
        ' 
        ' button4
        ' 
        button4.BackColor = Color.DodgerBlue
        button4.FlatStyle = FlatStyle.Flat
        button4.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point)
        button4.ForeColor = Color.White
        button4.Location = New Point(203, 340)
        button4.Name = "button4"
        button4.Size = New Size(160, 36)
        button4.TabIndex = 23
        button4.Text = "Reportes"
        button4.UseVisualStyleBackColor = False
        ' 
        ' button3
        ' 
        button3.BackColor = Color.DodgerBlue
        button3.FlatStyle = FlatStyle.Flat
        button3.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point)
        button3.ForeColor = Color.White
        button3.Location = New Point(203, 298)
        button3.Name = "button3"
        button3.Size = New Size(160, 36)
        button3.TabIndex = 22
        button3.Text = "Gestionar Artista"
        button3.UseVisualStyleBackColor = False
        ' 
        ' button2
        ' 
        button2.BackColor = Color.DodgerBlue
        button2.FlatStyle = FlatStyle.Flat
        button2.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point)
        button2.ForeColor = Color.White
        button2.Location = New Point(203, 256)
        button2.Name = "button2"
        button2.Size = New Size(160, 36)
        button2.TabIndex = 21
        button2.Text = "Gestionar canciones"
        button2.UseVisualStyleBackColor = False
        ' 
        ' button1
        ' 
        button1.BackColor = Color.DodgerBlue
        button1.FlatStyle = FlatStyle.Flat
        button1.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point)
        button1.ForeColor = Color.White
        button1.Location = New Point(203, 214)
        button1.Name = "button1"
        button1.Size = New Size(160, 36)
        button1.TabIndex = 20
        button1.Text = "Gestionar usuario"
        button1.UseVisualStyleBackColor = False
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(574, 450)
        Controls.Add(button5)
        Controls.Add(button4)
        Controls.Add(button3)
        Controls.Add(button2)
        Controls.Add(button1)
        Controls.Add(pictureBox1)
        Controls.Add(label2)
        Controls.Add(label1)
        Name = "Admin"
        Text = "Admin"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
