<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarCliente
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
        panelAdmin_clientes = New Panel()
        label_ciudad = New Label()
        label_telefono = New Label()
        label_direccion = New Label()
        label_nombre = New Label()
        label_id = New Label()
        TextBox_ciudad = New TextBox()
        TextBox_telefono = New TextBox()
        TextBox_direccion = New TextBox()
        TextBox_nombre = New TextBox()
        TextBox_id = New TextBox()
        btn_eliminar = New Button()
        btn_cancelar = New Button()
        btn_modificar = New Button()
        btn_guardar = New Button()
        Panel2 = New Panel()
        botoncerrar = New Button()
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        ProductoToolStripMenuItem = New ToolStripMenuItem()
        VentasToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        panelAdmin_clientes.SuspendLayout()
        Panel2.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelAdmin_clientes
        ' 
        panelAdmin_clientes.Controls.Add(label_ciudad)
        panelAdmin_clientes.Controls.Add(label_telefono)
        panelAdmin_clientes.Controls.Add(label_direccion)
        panelAdmin_clientes.Controls.Add(label_nombre)
        panelAdmin_clientes.Controls.Add(label_id)
        panelAdmin_clientes.Controls.Add(TextBox_ciudad)
        panelAdmin_clientes.Controls.Add(TextBox_telefono)
        panelAdmin_clientes.Controls.Add(TextBox_direccion)
        panelAdmin_clientes.Controls.Add(TextBox_nombre)
        panelAdmin_clientes.Controls.Add(TextBox_id)
        panelAdmin_clientes.Controls.Add(btn_eliminar)
        panelAdmin_clientes.Controls.Add(btn_cancelar)
        panelAdmin_clientes.Controls.Add(btn_modificar)
        panelAdmin_clientes.Controls.Add(btn_guardar)
        panelAdmin_clientes.Controls.Add(Panel2)
        panelAdmin_clientes.Controls.Add(MenuStrip1)
        panelAdmin_clientes.Dock = DockStyle.Fill
        panelAdmin_clientes.Location = New Point(0, 0)
        panelAdmin_clientes.Name = "panelAdmin_clientes"
        panelAdmin_clientes.Size = New Size(528, 496)
        panelAdmin_clientes.TabIndex = 0
        ' 
        ' label_ciudad
        ' 
        label_ciudad.AutoSize = True
        label_ciudad.Font = New Font("Arial Narrow", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        label_ciudad.Location = New Point(38, 264)
        label_ciudad.Name = "label_ciudad"
        label_ciudad.Size = New Size(59, 22)
        label_ciudad.TabIndex = 15
        label_ciudad.Text = "Ciudad:"' 
        ' label_telefono
        ' 
        label_telefono.AutoSize = True
        label_telefono.Font = New Font("Arial Narrow", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        label_telefono.Location = New Point(38, 226)
        label_telefono.Name = "label_telefono"
        label_telefono.Size = New Size(69, 22)
        label_telefono.TabIndex = 14
        label_telefono.Text = "Telefono:"' 
        ' label_direccion
        ' 
        label_direccion.AutoSize = True
        label_direccion.Font = New Font("Arial Narrow", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        label_direccion.Location = New Point(38, 186)
        label_direccion.Name = "label_direccion"
        label_direccion.Size = New Size(73, 22)
        label_direccion.TabIndex = 13
        label_direccion.Text = "Direccion:"' 
        ' label_nombre
        ' 
        label_nombre.AutoSize = True
        label_nombre.Font = New Font("Arial Narrow", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        label_nombre.Location = New Point(38, 143)
        label_nombre.Name = "label_nombre"
        label_nombre.Size = New Size(66, 22)
        label_nombre.TabIndex = 12
        label_nombre.Text = "Nombre:"' 
        ' label_id
        ' 
        label_id.AutoSize = True
        label_id.Font = New Font("Arial Narrow", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        label_id.Location = New Point(38, 108)
        label_id.Name = "label_id"
        label_id.Size = New Size(27, 22)
        label_id.TabIndex = 11
        label_id.Text = "ID:"' 
        ' TextBox_ciudad
        ' 
        TextBox_ciudad.Location = New Point(194, 266)
        TextBox_ciudad.Name = "TextBox_ciudad"
        TextBox_ciudad.Size = New Size(304, 23)
        TextBox_ciudad.TabIndex = 10
        ' 
        ' TextBox_telefono
        ' 
        TextBox_telefono.Location = New Point(194, 225)
        TextBox_telefono.Name = "TextBox_telefono"
        TextBox_telefono.Size = New Size(304, 23)
        TextBox_telefono.TabIndex = 9
        ' 
        ' TextBox_direccion
        ' 
        TextBox_direccion.Location = New Point(194, 185)
        TextBox_direccion.Name = "TextBox_direccion"
        TextBox_direccion.Size = New Size(304, 23)
        TextBox_direccion.TabIndex = 8
        ' 
        ' TextBox_nombre
        ' 
        TextBox_nombre.Location = New Point(194, 142)
        TextBox_nombre.Name = "TextBox_nombre"
        TextBox_nombre.Size = New Size(304, 23)
        TextBox_nombre.TabIndex = 7
        ' 
        ' TextBox_id
        ' 
        TextBox_id.Location = New Point(194, 107)
        TextBox_id.Name = "TextBox_id"
        TextBox_id.Size = New Size(304, 23)
        TextBox_id.TabIndex = 6
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_eliminar.Location = New Point(316, 373)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(89, 29)
        btn_eliminar.TabIndex = 5
        btn_eliminar.Text = "ELIMINAR"
        btn_eliminar.UseVisualStyleBackColor = True
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_cancelar.Location = New Point(194, 373)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(89, 29)
        btn_cancelar.TabIndex = 4
        btn_cancelar.Text = "CANCELAR"
        btn_cancelar.UseVisualStyleBackColor = True
        ' 
        ' btn_modificar
        ' 
        btn_modificar.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_modificar.Location = New Point(316, 330)
        btn_modificar.Name = "btn_modificar"
        btn_modificar.Size = New Size(89, 29)
        btn_modificar.TabIndex = 3
        btn_modificar.Text = "MODIFICAR"
        btn_modificar.UseVisualStyleBackColor = True
        ' 
        ' btn_guardar
        ' 
        btn_guardar.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_guardar.Location = New Point(194, 330)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(89, 29)
        btn_guardar.TabIndex = 2
        btn_guardar.Text = "GUARDAR"
        btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.Controls.Add(botoncerrar)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(0, 27)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(528, 53)
        Panel2.TabIndex = 0
        ' 
        ' botoncerrar
        ' 
        botoncerrar.FlatAppearance.BorderSize = 0
        botoncerrar.FlatStyle = FlatStyle.Flat
        botoncerrar.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point)
        botoncerrar.Image = My.Resources.Resources.add_circle_create_expand_new_plus_icon_123218
        botoncerrar.Location = New Point(449, 4)
        botoncerrar.Margin = New Padding(3, 2, 3, 2)
        botoncerrar.Name = "botoncerrar"
        botoncerrar.Size = New Size(52, 44)
        botoncerrar.TabIndex = 14
        botoncerrar.TextImageRelation = TextImageRelation.ImageBeforeText
        botoncerrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(158, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 44)
        Label1.TabIndex = 0
        Label1.Text = "CLIENTES"' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ClientesToolStripMenuItem, ProductoToolStripMenuItem, VentasToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(528, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(61, 20)
        ClientesToolStripMenuItem.Text = "Clientes"' 
        ' ProductoToolStripMenuItem
        ' 
        ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        ProductoToolStripMenuItem.Size = New Size(68, 20)
        ProductoToolStripMenuItem.Text = "Producto"' 
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
        ' agregarCliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(528, 496)
        Controls.Add(panelAdmin_clientes)
        MainMenuStrip = MenuStrip1
        Name = "agregarCliente"
        Text = "Clientes"
        panelAdmin_clientes.ResumeLayout(False)
        panelAdmin_clientes.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelAdmin_clientes As Panel
    Friend WithEvents label_ciudad As Label
    Friend WithEvents label_telefono As Label
    Friend WithEvents label_direccion As Label
    Friend WithEvents label_nombre As Label
    Friend WithEvents label_id As Label
    Friend WithEvents TextBox_ciudad As TextBox
    Friend WithEvents TextBox_telefono As TextBox
    Friend WithEvents TextBox_direccion As TextBox
    Friend WithEvents TextBox_nombre As TextBox
    Friend WithEvents TextBox_id As TextBox
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents botoncerrar As Button
End Class
