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
        PictureBox1 = New PictureBox()
        Text_contraseña = New TextBox()
        Text_user = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btn_ingresar = New Button()
        Panel1 = New Panel()
        ComboBox1 = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.users_theuser_6177
        PictureBox1.Location = New Point(75, 83)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(128, 128)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Text_contraseña
        ' 
        Text_contraseña.Location = New Point(41, 299)
        Text_contraseña.Name = "Text_contraseña"
        Text_contraseña.PasswordChar = "*"c
        Text_contraseña.Size = New Size(198, 23)
        Text_contraseña.TabIndex = 6
        ' 
        ' Text_user
        ' 
        Text_user.Location = New Point(41, 245)
        Text_user.Name = "Text_user"
        Text_user.Size = New Size(198, 23)
        Text_user.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(41, 334)
        Label4.Name = "Label4"
        Label4.Size = New Size(27, 15)
        Label4.TabIndex = 4
        Label4.Text = "Rol:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 281)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 3
        Label3.Text = "Contraseña:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 227)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 2
        Label2.Text = "Usuario:"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(67, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 56)
        Label1.TabIndex = 1
        Label1.Text = "Login"' 
        ' btn_ingresar
        ' 
        btn_ingresar.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_ingresar.Location = New Point(99, 419)
        btn_ingresar.Name = "btn_ingresar"
        btn_ingresar.Size = New Size(81, 32)
        btn_ingresar.TabIndex = 0
        btn_ingresar.Text = "Ingresar"
        btn_ingresar.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btn_ingresar)
        Panel1.Controls.Add(Text_contraseña)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Text_user)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(320, 497)
        Panel1.TabIndex = 9
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Administrador", "Usuario General"})
        ComboBox1.Location = New Point(41, 352)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(198, 23)
        ComboBox1.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(320, 497)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Text_contraseña As TextBox
    Friend WithEvents Text_user As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_ingresar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
End Class
