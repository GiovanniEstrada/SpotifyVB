﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarUsuario
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
        Contraseña2Lbl = New TextBox()
        Contraseña1Lbl = New TextBox()
        button2 = New Button()
        NombreLbl = New TextBox()
        label1 = New Label()
        pictureBox1 = New PictureBox()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Contraseña2Lbl
        ' 
        Contraseña2Lbl.Location = New Point(116, 275)
        Contraseña2Lbl.Name = "Contraseña2Lbl"
        Contraseña2Lbl.PlaceholderText = "Confirma su contraseña"
        Contraseña2Lbl.Size = New Size(249, 23)
        Contraseña2Lbl.TabIndex = 26
        ' 
        ' Contraseña1Lbl
        ' 
        Contraseña1Lbl.Location = New Point(116, 232)
        Contraseña1Lbl.Name = "Contraseña1Lbl"
        Contraseña1Lbl.PlaceholderText = "Ingresa su contraseña"
        Contraseña1Lbl.Size = New Size(249, 23)
        Contraseña1Lbl.TabIndex = 25
        ' 
        ' button2
        ' 
        button2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        button2.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point)
        button2.ForeColor = Color.White
        button2.Location = New Point(159, 320)
        button2.Name = "button2"
        button2.Size = New Size(160, 36)
        button2.TabIndex = 24
        button2.Text = "Actualizar"
        button2.UseVisualStyleBackColor = False
        ' 
        ' NombreLbl
        ' 
        NombreLbl.Location = New Point(116, 193)
        NombreLbl.Name = "NombreLbl"
        NombreLbl.PlaceholderText = "Ingresa su nombre"
        NombreLbl.Size = New Size(249, 23)
        NombreLbl.TabIndex = 22
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        label1.Location = New Point(116, 141)
        label1.Name = "label1"
        label1.Size = New Size(250, 21)
        label1.TabIndex = 21
        label1.Text = "REGISTRO DE USUARIOS"
        ' 
        ' pictureBox1
        ' 
        pictureBox1.BackgroundImageLayout = ImageLayout.None
        pictureBox1.Image = My.Resources.Resources.Spotify_Logo
        pictureBox1.Location = New Point(173, 15)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(131, 123)
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox1.TabIndex = 27
        pictureBox1.TabStop = False
        ' 
        ' EditarUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(497, 450)
        Controls.Add(pictureBox1)
        Controls.Add(Contraseña2Lbl)
        Controls.Add(Contraseña1Lbl)
        Controls.Add(button2)
        Controls.Add(NombreLbl)
        Controls.Add(label1)
        Name = "EditarUsuario"
        Text = "EditarUsuario"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents Contraseña2Lbl As TextBox
    Private WithEvents Contraseña1Lbl As TextBox
    Private WithEvents button2 As Button
    Private WithEvents NombreLbl As TextBox
    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
End Class
