<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerPlaylist
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
        Label1 = New Label()
        ListBox2 = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureBox1
        ' 
        pictureBox1.BackColor = SystemColors.Control
        pictureBox1.BackgroundImageLayout = ImageLayout.None
        pictureBox1.Image = My.Resources.Resources.logoPlaylist
        pictureBox1.Location = New Point(177, 42)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(131, 123)
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox1.TabIndex = 33
        pictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(142, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 21)
        Label1.TabIndex = 32
        Label1.Text = "LISTADO PLAYLIST"
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(72, 190)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(336, 184)
        ListBox2.TabIndex = 48
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(72, 395)
        Button1.Name = "Button1"
        Button1.Size = New Size(144, 29)
        Button1.TabIndex = 49
        Button1.Text = "Editar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(264, 395)
        Button2.Name = "Button2"
        Button2.Size = New Size(144, 29)
        Button2.TabIndex = 50
        Button2.Text = "Reproducir"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' VerPlaylist
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListBox2)
        Controls.Add(pictureBox1)
        Controls.Add(Label1)
        Name = "VerPlaylist"
        Text = "VerPlaylist"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents Label1 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
