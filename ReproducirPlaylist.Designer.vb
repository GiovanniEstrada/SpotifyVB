<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReproducirPlaylist
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
        ListBox2 = New ListBox()
        pictureBox1 = New PictureBox()
        Label1 = New Label()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(57, 212)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(336, 184)
        ListBox2.TabIndex = 51
        ' 
        ' pictureBox1
        ' 
        pictureBox1.BackColor = SystemColors.Control
        pictureBox1.BackgroundImageLayout = ImageLayout.None
        pictureBox1.Image = My.Resources.Resources.logoPlaylist
        pictureBox1.Location = New Point(162, 64)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(131, 123)
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox1.TabIndex = 50
        pictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(154, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 21)
        Label1.TabIndex = 49
        Label1.Text = "REPRODUCTOR"
        ' 
        ' ReproducirPlaylist
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(446, 450)
        Controls.Add(ListBox2)
        Controls.Add(pictureBox1)
        Controls.Add(Label1)
        Name = "ReproducirPlaylist"
        Text = "ReproducirPlaylist"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox2 As ListBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents Label1 As Label
End Class
