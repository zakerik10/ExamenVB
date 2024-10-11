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
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.BotonCrearProducto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.GridClientes = New System.Windows.Forms.DataGridView()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxBuscador = New System.Windows.Forms.TextBox()
        Me.ButtonEliminarSelec = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accion = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonMenu
        '
        Me.ButtonMenu.Location = New System.Drawing.Point(475, 24)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(85, 23)
        Me.ButtonMenu.TabIndex = 19
        Me.ButtonMenu.Text = "Volver al menu"
        Me.ButtonMenu.UseVisualStyleBackColor = True
        '
        'BotonCrearProducto
        '
        Me.BotonCrearProducto.Location = New System.Drawing.Point(44, 477)
        Me.BotonCrearProducto.Name = "BotonCrearProducto"
        Me.BotonCrearProducto.Size = New System.Drawing.Size(95, 23)
        Me.BotonCrearProducto.TabIndex = 18
        Me.BotonCrearProducto.Text = "Producto Nuevo"
        Me.BotonCrearProducto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Productos"
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(485, 477)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNext.TabIndex = 16
        Me.ButtonNext.Text = "Siguiente"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.Location = New System.Drawing.Point(404, 477)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPrevious.TabIndex = 15
        Me.ButtonPrevious.Text = "Atras"
        Me.ButtonPrevious.UseVisualStyleBackColor = True
        '
        'GridClientes
        '
        Me.GridClientes.AllowUserToAddRows = False
        Me.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Precio, Me.Categoria, Me.Accion, Me.Seleccionar})
        Me.GridClientes.Location = New System.Drawing.Point(44, 95)
        Me.GridClientes.Name = "GridClientes"
        Me.GridClientes.Size = New System.Drawing.Size(516, 376)
        Me.GridClientes.TabIndex = 14
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(272, 67)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuscar.TabIndex = 13
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Buscar"
        '
        'TextBoxBuscador
        '
        Me.TextBoxBuscador.Location = New System.Drawing.Point(44, 69)
        Me.TextBoxBuscador.Name = "TextBoxBuscador"
        Me.TextBoxBuscador.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxBuscador.TabIndex = 20
        '
        'ButtonEliminarSelec
        '
        Me.ButtonEliminarSelec.Location = New System.Drawing.Point(458, 67)
        Me.ButtonEliminarSelec.Name = "ButtonEliminarSelec"
        Me.ButtonEliminarSelec.Size = New System.Drawing.Size(102, 23)
        Me.ButtonEliminarSelec.TabIndex = 23
        Me.ButtonEliminarSelec.Text = "Eliminar Seleccion"
        Me.ButtonEliminarSelec.UseVisualStyleBackColor = True
        Me.ButtonEliminarSelec.Visible = False
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(353, 67)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLimpiar.TabIndex = 22
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
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
        Me.Accion.Text = "Editar o Eliminar"
        Me.Accion.ToolTipText = "Editar o Eliminar"
        Me.Accion.UseColumnTextForButtonValue = True
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Width = 70
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 538)
        Me.Controls.Add(Me.ButtonEliminarSelec)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxBuscador)
        Me.Controls.Add(Me.ButtonMenu)
        Me.Controls.Add(Me.BotonCrearProducto)
        Me.Controls.Add(Me.Label1)
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

    Friend WithEvents ButtonMenu As Button
    Friend WithEvents BotonCrearProducto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonPrevious As Button
    Friend WithEvents GridClientes As DataGridView
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxBuscador As TextBox
    Friend WithEvents ButtonEliminarSelec As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Accion As DataGridViewButtonColumn
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
End Class
