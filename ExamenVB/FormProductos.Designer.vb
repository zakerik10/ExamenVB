<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductos
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
        Me.ButtonVolver = New System.Windows.Forms.Button()
        Me.BotonCrearProducto = New System.Windows.Forms.Button()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.GridClientes = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accion = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SeleccionarEliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgregarCarrito = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxBuscador = New System.Windows.Forms.TextBox()
        Me.ButtonEliminarSelec = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxCategorias = New System.Windows.Forms.ComboBox()
        Me.ButtonLimpiarFiltroCategoria = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxMinPrecio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxMaxPrecio = New System.Windows.Forms.TextBox()
        Me.ButtonLimpiarFiltroPrecio = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonVerCarrito = New System.Windows.Forms.Button()
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonVolver
        '
        Me.ButtonVolver.Location = New System.Drawing.Point(668, 24)
        Me.ButtonVolver.Name = "ButtonVolver"
        Me.ButtonVolver.Size = New System.Drawing.Size(85, 23)
        Me.ButtonVolver.TabIndex = 19
        Me.ButtonVolver.Text = "Volver al menu"
        Me.ButtonVolver.UseVisualStyleBackColor = True
        '
        'BotonCrearProducto
        '
        Me.BotonCrearProducto.Location = New System.Drawing.Point(237, 477)
        Me.BotonCrearProducto.Name = "BotonCrearProducto"
        Me.BotonCrearProducto.Size = New System.Drawing.Size(95, 23)
        Me.BotonCrearProducto.TabIndex = 18
        Me.BotonCrearProducto.Text = "Producto Nuevo"
        Me.BotonCrearProducto.UseVisualStyleBackColor = True
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Location = New System.Drawing.Point(26, 24)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(55, 13)
        Me.LabelTitulo.TabIndex = 17
        Me.LabelTitulo.Text = "Productos"
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(678, 477)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNext.TabIndex = 16
        Me.ButtonNext.Text = "Siguiente"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.Location = New System.Drawing.Point(597, 477)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPrevious.TabIndex = 15
        Me.ButtonPrevious.Text = "Atras"
        Me.ButtonPrevious.UseVisualStyleBackColor = True
        '
        'GridClientes
        '
        Me.GridClientes.AllowUserToAddRows = False
        Me.GridClientes.AllowUserToDeleteRows = False
        Me.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Precio, Me.Categoria, Me.Accion, Me.SeleccionarEliminar, Me.Cantidad, Me.AgregarCarrito})
        Me.GridClientes.Location = New System.Drawing.Point(237, 95)
        Me.GridClientes.Name = "GridClientes"
        Me.GridClientes.Size = New System.Drawing.Size(516, 376)
        Me.GridClientes.TabIndex = 14
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        '
        'Accion
        '
        Me.Accion.HeaderText = "Acción"
        Me.Accion.Name = "Accion"
        Me.Accion.ReadOnly = True
        Me.Accion.Text = "Editar o Eliminar"
        Me.Accion.ToolTipText = "Editar o Eliminar"
        Me.Accion.UseColumnTextForButtonValue = True
        '
        'SeleccionarEliminar
        '
        Me.SeleccionarEliminar.HeaderText = "Seleccionar"
        Me.SeleccionarEliminar.Name = "SeleccionarEliminar"
        Me.SeleccionarEliminar.ReadOnly = True
        Me.SeleccionarEliminar.Width = 70
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 60
        '
        'AgregarCarrito
        '
        Me.AgregarCarrito.HeaderText = "Agregar al Carrito"
        Me.AgregarCarrito.Name = "AgregarCarrito"
        Me.AgregarCarrito.ReadOnly = True
        Me.AgregarCarrito.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AgregarCarrito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AgregarCarrito.Text = "Agregar"
        Me.AgregarCarrito.ToolTipText = "Agregar"
        Me.AgregarCarrito.UseColumnTextForButtonValue = True
        Me.AgregarCarrito.Width = 80
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(465, 67)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuscar.TabIndex = 13
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Buscar"
        '
        'TextBoxBuscador
        '
        Me.TextBoxBuscador.Location = New System.Drawing.Point(237, 69)
        Me.TextBoxBuscador.Name = "TextBoxBuscador"
        Me.TextBoxBuscador.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxBuscador.TabIndex = 20
        '
        'ButtonEliminarSelec
        '
        Me.ButtonEliminarSelec.Location = New System.Drawing.Point(651, 67)
        Me.ButtonEliminarSelec.Name = "ButtonEliminarSelec"
        Me.ButtonEliminarSelec.Size = New System.Drawing.Size(102, 23)
        Me.ButtonEliminarSelec.TabIndex = 23
        Me.ButtonEliminarSelec.Text = "Eliminar Seleccion"
        Me.ButtonEliminarSelec.UseVisualStyleBackColor = True
        Me.ButtonEliminarSelec.Visible = False
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(546, 67)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLimpiar.TabIndex = 22
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Filtro"
        '
        'ComboBoxCategorias
        '
        Me.ComboBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCategorias.FormattingEnabled = True
        Me.ComboBoxCategorias.Location = New System.Drawing.Point(29, 95)
        Me.ComboBoxCategorias.Name = "ComboBoxCategorias"
        Me.ComboBoxCategorias.Size = New System.Drawing.Size(169, 21)
        Me.ComboBoxCategorias.TabIndex = 25
        '
        'ButtonLimpiarFiltroCategoria
        '
        Me.ButtonLimpiarFiltroCategoria.BackColor = System.Drawing.Color.Red
        Me.ButtonLimpiarFiltroCategoria.ForeColor = System.Drawing.Color.White
        Me.ButtonLimpiarFiltroCategoria.Location = New System.Drawing.Point(204, 94)
        Me.ButtonLimpiarFiltroCategoria.Name = "ButtonLimpiarFiltroCategoria"
        Me.ButtonLimpiarFiltroCategoria.Size = New System.Drawing.Size(24, 23)
        Me.ButtonLimpiarFiltroCategoria.TabIndex = 26
        Me.ButtonLimpiarFiltroCategoria.Text = "X"
        Me.ButtonLimpiarFiltroCategoria.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Categoria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Precio"
        '
        'TextBoxMinPrecio
        '
        Me.TextBoxMinPrecio.Location = New System.Drawing.Point(29, 173)
        Me.TextBoxMinPrecio.Name = "TextBoxMinPrecio"
        Me.TextBoxMinPrecio.Size = New System.Drawing.Size(61, 20)
        Me.TextBoxMinPrecio.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "De"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(93, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "A"
        '
        'TextBoxMaxPrecio
        '
        Me.TextBoxMaxPrecio.Location = New System.Drawing.Point(96, 173)
        Me.TextBoxMaxPrecio.Name = "TextBoxMaxPrecio"
        Me.TextBoxMaxPrecio.Size = New System.Drawing.Size(61, 20)
        Me.TextBoxMaxPrecio.TabIndex = 32
        '
        'ButtonLimpiarFiltroPrecio
        '
        Me.ButtonLimpiarFiltroPrecio.BackColor = System.Drawing.Color.Red
        Me.ButtonLimpiarFiltroPrecio.ForeColor = System.Drawing.Color.White
        Me.ButtonLimpiarFiltroPrecio.Location = New System.Drawing.Point(204, 171)
        Me.ButtonLimpiarFiltroPrecio.Name = "ButtonLimpiarFiltroPrecio"
        Me.ButtonLimpiarFiltroPrecio.Size = New System.Drawing.Size(24, 23)
        Me.ButtonLimpiarFiltroPrecio.TabIndex = 33
        Me.ButtonLimpiarFiltroPrecio.Text = "X"
        Me.ButtonLimpiarFiltroPrecio.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(163, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 23)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonVerCarrito
        '
        Me.ButtonVerCarrito.Location = New System.Drawing.Point(678, 67)
        Me.ButtonVerCarrito.Name = "ButtonVerCarrito"
        Me.ButtonVerCarrito.Size = New System.Drawing.Size(75, 23)
        Me.ButtonVerCarrito.TabIndex = 35
        Me.ButtonVerCarrito.Text = "Ver Carrito"
        Me.ButtonVerCarrito.UseVisualStyleBackColor = True
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 538)
        Me.Controls.Add(Me.ButtonVerCarrito)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonLimpiarFiltroPrecio)
        Me.Controls.Add(Me.TextBoxMaxPrecio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxMinPrecio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonLimpiarFiltroCategoria)
        Me.Controls.Add(Me.ComboBoxCategorias)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonEliminarSelec)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxBuscador)
        Me.Controls.Add(Me.ButtonVolver)
        Me.Controls.Add(Me.BotonCrearProducto)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.GridClientes)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Name = "FormProductos"
        Me.Text = "FormProductos"
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonVolver As Button
    Friend WithEvents BotonCrearProducto As Button
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonPrevious As Button
    Friend WithEvents GridClientes As DataGridView
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxBuscador As TextBox
    Friend WithEvents ButtonEliminarSelec As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxCategorias As ComboBox
    Friend WithEvents ButtonLimpiarFiltroCategoria As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxMinPrecio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxMaxPrecio As TextBox
    Friend WithEvents ButtonLimpiarFiltroPrecio As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ButtonVerCarrito As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Accion As DataGridViewButtonColumn
    Friend WithEvents SeleccionarEliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents AgregarCarrito As DataGridViewButtonColumn
End Class
