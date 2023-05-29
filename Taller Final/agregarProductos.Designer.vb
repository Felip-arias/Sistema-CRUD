<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarProductos
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
        MenuStrip1 = New MenuStrip()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        VentasToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        btn_eliminar = New Button()
        btn_cancelar = New Button()
        btn_modificar = New Button()
        btn_guardar = New Button()
        TextBox_precio = New TextBox()
        TextBox_descripcion = New TextBox()
        TextBox_id = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        botoncerrar = New Button()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ClientesToolStripMenuItem, ProductosToolStripMenuItem, VentasToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(577, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(61, 20)
        ClientesToolStripMenuItem.Text = "Clientes"' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(73, 20)
        ProductosToolStripMenuItem.Text = "Productos"' 
        ' VentasToolStripMenuItem
        ' 
        VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        VentasToolStripMenuItem.Size = New Size(53, 20)
        VentasToolStripMenuItem.Text = "Ventas"' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(41, 20)
        SalirToolStripMenuItem.Text = "Salir"' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btn_eliminar)
        Panel1.Controls.Add(btn_cancelar)
        Panel1.Controls.Add(btn_modificar)
        Panel1.Controls.Add(btn_guardar)
        Panel1.Controls.Add(TextBox_precio)
        Panel1.Controls.Add(TextBox_descripcion)
        Panel1.Controls.Add(TextBox_id)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(577, 388)
        Panel1.TabIndex = 1
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_eliminar.Location = New Point(369, 312)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(85, 30)
        btn_eliminar.TabIndex = 10
        btn_eliminar.Text = "ELIMINAR"
        btn_eliminar.UseVisualStyleBackColor = True
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_cancelar.Location = New Point(369, 276)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(85, 30)
        btn_cancelar.TabIndex = 9
        btn_cancelar.Text = "CANCELAR"
        btn_cancelar.UseVisualStyleBackColor = True
        ' 
        ' btn_modificar
        ' 
        btn_modificar.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_modificar.Location = New Point(263, 276)
        btn_modificar.Name = "btn_modificar"
        btn_modificar.Size = New Size(85, 30)
        btn_modificar.TabIndex = 8
        btn_modificar.Text = "MODIFICAR"
        btn_modificar.UseVisualStyleBackColor = True
        ' 
        ' btn_guardar
        ' 
        btn_guardar.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_guardar.Location = New Point(263, 312)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(85, 30)
        btn_guardar.TabIndex = 7
        btn_guardar.Text = "GUARDAR"
        btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' TextBox_precio
        ' 
        TextBox_precio.Location = New Point(267, 201)
        TextBox_precio.Name = "TextBox_precio"
        TextBox_precio.Size = New Size(257, 23)
        TextBox_precio.TabIndex = 6
        ' 
        ' TextBox_descripcion
        ' 
        TextBox_descripcion.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_descripcion.Location = New Point(267, 130)
        TextBox_descripcion.Name = "TextBox_descripcion"
        TextBox_descripcion.Size = New Size(257, 61)
        TextBox_descripcion.TabIndex = 5
        ' 
        ' TextBox_id
        ' 
        TextBox_id.Location = New Point(267, 95)
        TextBox_id.Name = "TextBox_id"
        TextBox_id.Size = New Size(257, 23)
        TextBox_id.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(89, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 19)
        Label4.TabIndex = 3
        Label4.Text = "Precio:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(89, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 19)
        Label3.TabIndex = 2
        Label3.Text = "Descripcion:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(89, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 19)
        Label2.TabIndex = 1
        Label2.Text = "ID:"' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.Controls.Add(botoncerrar)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(573, 57)
        Panel2.TabIndex = 0
        ' 
        ' botoncerrar
        ' 
        botoncerrar.FlatAppearance.BorderSize = 0
        botoncerrar.FlatStyle = FlatStyle.Flat
        botoncerrar.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point)
        botoncerrar.Image = My.Resources.Resources.add_circle_create_expand_new_plus_icon_123218
        botoncerrar.Location = New Point(512, 5)
        botoncerrar.Margin = New Padding(3, 2, 3, 2)
        botoncerrar.Name = "botoncerrar"
        botoncerrar.Size = New Size(57, 47)
        botoncerrar.TabIndex = 14
        botoncerrar.TextImageRelation = TextImageRelation.ImageBeforeText
        botoncerrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(163, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 44)
        Label1.TabIndex = 0
        Label1.Text = "PRODUCTOS "' 
        ' agregarProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(577, 412)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "agregarProductos"
        Text = "Productos"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents TextBox_precio As TextBox
    Friend WithEvents TextBox_descripcion As TextBox
    Friend WithEvents TextBox_id As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents botoncerrar As Button
End Class
