<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarUsuario
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(GestionarUsuario))
        button5 = New Button()
        Listado = New ComboBox()
        label1 = New Label()
        pictureBox1 = New PictureBox()
        label2 = New Label()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' button5
        ' 
        button5.BackColor = Color.Red
        button5.FlatStyle = FlatStyle.Flat
        button5.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point)
        button5.ForeColor = Color.White
        button5.Location = New Point(306, 395)
        button5.Name = "button5"
        button5.Size = New Size(160, 36)
        button5.TabIndex = 32
        button5.Text = "Borrar usuario"
        button5.UseVisualStyleBackColor = False
        ' 
        ' Listado
        ' 
        Listado.FormattingEnabled = True
        Listado.Location = New Point(110, 204)
        Listado.Name = "Listado"
        Listado.Size = New Size(506, 23)
        Listado.TabIndex = 31
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point)
        label1.Location = New Point(110, 182)
        label1.Name = "label1"
        label1.Size = New Size(169, 16)
        label1.TabIndex = 30
        label1.Text = "Seleccione Usuario"
        ' 
        ' pictureBox1
        ' 
        pictureBox1.BackgroundImageLayout = ImageLayout.None
        pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Image)
        pictureBox1.Location = New Point(306, 36)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(131, 123)
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox1.TabIndex = 29
        pictureBox1.TabStop = False
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        label2.Location = New Point(276, 12)
        label2.Name = "label2"
        label2.Size = New Size(202, 21)
        label2.TabIndex = 28
        label2.Text = "ELIMINAR USUARIO"
        ' 
        ' GestionarUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(button5)
        Controls.Add(Listado)
        Controls.Add(label1)
        Controls.Add(pictureBox1)
        Controls.Add(label2)
        Name = "GestionarUsuario"
        Text = "GestionarUsuario"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents button5 As Button
    Private WithEvents Listado As ComboBox
    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label2 As Label
End Class
