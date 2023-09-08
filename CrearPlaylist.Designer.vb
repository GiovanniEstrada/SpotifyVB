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
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(284, 402)
        Button1.Name = "Button1"
        Button1.Size = New Size(225, 36)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Nombre
        ' 
        Nombre.Location = New Point(284, 129)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(228, 23)
        Nombre.TabIndex = 1
        ' 
        ' Box
        ' 
        Box.FormattingEnabled = True
        Box.Location = New Point(252, 197)
        Box.Name = "Box"
        Box.Size = New Size(314, 94)
        Box.TabIndex = 2
        ' 
        ' ImagenUrl
        ' 
        ImagenUrl.Location = New Point(298, 347)
        ImagenUrl.Name = "ImagenUrl"
        ImagenUrl.Size = New Size(192, 37)
        ImagenUrl.TabIndex = 3
        ImagenUrl.Text = "Button2"
        ImagenUrl.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 4
        Label1.Text = "Label1"
        ' 
        ' CrearPlaylist
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(ImagenUrl)
        Controls.Add(Box)
        Controls.Add(Nombre)
        Controls.Add(Button1)
        Name = "CrearPlaylist"
        Text = "CrearPlaylist"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Box As CheckedListBox
    Friend WithEvents ImagenUrl As Button
    Friend WithEvents Label1 As Label
End Class
