<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pictureBox1 = New PictureBox()
        button2 = New Button()
        button1 = New Button()
        PwdLogin = New TextBox()
        UserLogin = New TextBox()
        label1 = New Label()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureBox1
        ' 
        pictureBox1.BackgroundImageLayout = ImageLayout.None
        pictureBox1.Image = My.Resources.Resources.Spotify_Logo
        pictureBox1.Location = New Point(331, 50)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(131, 123)
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox1.TabIndex = 11
        pictureBox1.TabStop = False
        ' 
        ' button2
        ' 
        button2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        button2.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point)
        button2.ForeColor = Color.White
        button2.Location = New Point(315, 365)
        button2.Name = "button2"
        button2.Size = New Size(160, 36)
        button2.TabIndex = 10
        button2.Text = "Register"
        button2.UseVisualStyleBackColor = False
        ' 
        ' button1
        ' 
        button1.BackColor = Color.Blue
        button1.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point)
        button1.ForeColor = Color.White
        button1.Location = New Point(315, 314)
        button1.Name = "button1"
        button1.Size = New Size(160, 36)
        button1.TabIndex = 9
        button1.Text = "Login"
        button1.UseVisualStyleBackColor = False
        ' 
        ' PwdLogin
        ' 
        PwdLogin.Location = New Point(276, 267)
        PwdLogin.Name = "PwdLogin"
        PwdLogin.PlaceholderText = "Ingresa su contraseña"
        PwdLogin.Size = New Size(249, 23)
        PwdLogin.TabIndex = 8
        ' 
        ' UserLogin
        ' 
        UserLogin.Location = New Point(276, 226)
        UserLogin.Name = "UserLogin"
        UserLogin.PlaceholderText = "Ingresa su username"
        UserLogin.Size = New Size(249, 23)
        UserLogin.TabIndex = 7
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        label1.Location = New Point(297, 176)
        label1.Name = "label1"
        label1.Size = New Size(202, 21)
        label1.TabIndex = 6
        label1.Text = "Inicio de Sesion"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pictureBox1)
        Controls.Add(button2)
        Controls.Add(button1)
        Controls.Add(PwdLogin)
        Controls.Add(UserLogin)
        Controls.Add(label1)
        Name = "Form1"
        Text = "Form1"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents PwdLogin As TextBox
    Private WithEvents UserLogin As TextBox
    Private WithEvents label1 As Label
End Class
