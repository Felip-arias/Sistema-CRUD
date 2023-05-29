<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarVentas
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
        TextBox_idproducto = New TextBox()
        TextBox_idcliente = New TextBox()
        btn_eliminar = New Button()
        btn_cancelar = New Button()
        btn_modificar = New Button()
        btn_guardar = New Button()
        TextBox_cantidad = New TextBox()
        TextBox_id = New TextBox()
        Label5 = New Label()
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
        MenuStrip1.Size = New Size(482, 24)
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
        Panel1.Controls.Add(TextBox_idproducto)
        Panel1.Controls.Add(TextBox_idcliente)
        Panel1.Controls.Add(btn_eliminar)
        Panel1.Controls.Add(btn_cancelar)
        Panel1.Controls.Add(btn_modificar)
        Panel1.Controls.Add(btn_guardar)
        Panel1.Controls.Add(TextBox_cantidad)
        Panel1.Controls.Add(TextBox_id)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(482, 433)
        Panel1.TabIndex = 1
        ' 
        ' TextBox_idproducto
        ' 
        TextBox_idproducto.Location = New Point(179, 218)
        TextBox_idproducto.Name = "TextBox_idproducto"
        TextBox_idproducto.Size = New Size(271, 23)
        TextBox_idproducto.TabIndex = 14
        ' 
        ' TextBox_idcliente
        ' 
        TextBox_idcliente.Location = New Point(179, 178)
        TextBox_idcliente.Name = "TextBox_idcliente"
        TextBox_idcliente.Size = New Size(271, 23)
        TextBox_idcliente.TabIndex = 13
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_eliminar.Location = New Point(302, 328)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(88, 36)
        btn_eliminar.TabIndex = 12
        btn_eliminar.Text = "ELIMINAR"
        btn_eliminar.UseVisualStyleBackColor = True
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_cancelar.Location = New Point(301, 286)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(89, 36)
        btn_cancelar.TabIndex = 11
        btn_cancelar.Text = "CANCELAR"
        btn_cancelar.UseVisualStyleBackColor = True
        ' 
        ' btn_modificar
        ' 
        btn_modificar.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_modificar.Location = New Point(207, 286)
        btn_modificar.Name = "btn_modificar"
        btn_modificar.Size = New Size(89, 36)
        btn_modificar.TabIndex = 10
        btn_modificar.Text = "MODIFICAR"
        btn_modificar.UseVisualStyleBackColor = True
        ' 
        ' btn_guardar
        ' 
        btn_guardar.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_guardar.Location = New Point(207, 328)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(89, 36)
        btn_guardar.TabIndex = 9
        btn_guardar.Text = "GUARDAR"
        btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' TextBox_cantidad
        ' 
        TextBox_cantidad.Location = New Point(178, 129)
        TextBox_cantidad.Name = "TextBox_cantidad"
        TextBox_cantidad.Size = New Size(272, 23)
        TextBox_cantidad.TabIndex = 6
        ' 
        ' TextBox_id
        ' 
        TextBox_id.Location = New Point(178, 90)
        TextBox_id.Name = "TextBox_id"
        TextBox_id.Size = New Size(272, 23)
        TextBox_id.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(60, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 19)
        Label5.TabIndex = 4
        Label5.Text = "ID Producto:"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(60, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 19)
        Label4.TabIndex = 3
        Label4.Text = "ID Cliente:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(60, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 19)
        Label3.TabIndex = 2
        Label3.Text = "Cantidad:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(60, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 19)
        Label2.TabIndex = 1
        Label2.Text = "ID:"' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.Controls.Add(botoncerrar)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(3, 1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(479, 54)
        Panel2.TabIndex = 0
        ' 
        ' botoncerrar
        ' 
        botoncerrar.FlatAppearance.BorderSize = 0
        botoncerrar.FlatStyle = FlatStyle.Flat
        botoncerrar.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point)
        botoncerrar.Image = My.Resources.Resources.add_circle_create_expand_new_plus_icon_123218
        botoncerrar.Location = New Point(398, 5)
        botoncerrar.Margin = New Padding(3, 2, 3, 2)
        botoncerrar.Name = "botoncerrar"
        botoncerrar.Size = New Size(57, 47)
        botoncerrar.TabIndex = 13
        botoncerrar.TextImageRelation = TextImageRelation.ImageBeforeText
        botoncerrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(154, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 44)
        Label1.TabIndex = 0
        Label1.Text = "VENTAS"' 
        ' agregarVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 457)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "agregarVentas"
        Text = "Ventas"
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
    Friend WithEvents TextBox_cantidad As TextBox
    Friend WithEvents TextBox_id As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents botoncerrar As Button
    Friend WithEvents TextBox_idproducto As TextBox
    Friend WithEvents TextBox_idcliente As TextBox
End Class
