<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.GridClientes = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accion = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BotonCrearCliente = New System.Windows.Forms.Button()
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.TextBoxBuscador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonEliminarSelec = New System.Windows.Forms.Button()
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(272, 67)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuscar.TabIndex = 0
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'GridClientes
        '
        Me.GridClientes.AllowUserToAddRows = False
        Me.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Cliente, Me.Telefono, Me.Correo, Me.Accion, Me.Seleccionar})
        Me.GridClientes.Location = New System.Drawing.Point(44, 95)
        Me.GridClientes.Name = "GridClientes"
        Me.GridClientes.Size = New System.Drawing.Size(516, 376)
        Me.GridClientes.TabIndex = 1
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Correo
        '
        Me.Correo.HeaderText = "Correo"
        Me.Correo.Name = "Correo"
        Me.Correo.ReadOnly = True
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
        'ButtonPrevious
        '
        Me.ButtonPrevious.Location = New System.Drawing.Point(404, 477)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPrevious.TabIndex = 2
        Me.ButtonPrevious.Text = "Atras"
        Me.ButtonPrevious.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(485, 477)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNext.TabIndex = 3
        Me.ButtonNext.Text = "Siguiente"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Clientes"
        '
        'BotonCrearCliente
        '
        Me.BotonCrearCliente.Location = New System.Drawing.Point(44, 477)
        Me.BotonCrearCliente.Name = "BotonCrearCliente"
        Me.BotonCrearCliente.Size = New System.Drawing.Size(95, 23)
        Me.BotonCrearCliente.TabIndex = 11
        Me.BotonCrearCliente.Text = "Cliente Nuevo"
        Me.BotonCrearCliente.UseVisualStyleBackColor = True
        '
        'ButtonMenu
        '
        Me.ButtonMenu.Location = New System.Drawing.Point(475, 24)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(85, 23)
        Me.ButtonMenu.TabIndex = 12
        Me.ButtonMenu.Text = "Volver al menu"
        Me.ButtonMenu.UseVisualStyleBackColor = True
        '
        'TextBoxBuscador
        '
        Me.TextBoxBuscador.Location = New System.Drawing.Point(44, 69)
        Me.TextBoxBuscador.Name = "TextBoxBuscador"
        Me.TextBoxBuscador.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxBuscador.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Buscar"
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(353, 67)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLimpiar.TabIndex = 15
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'ButtonEliminarSelec
        '
        Me.ButtonEliminarSelec.Location = New System.Drawing.Point(458, 67)
        Me.ButtonEliminarSelec.Name = "ButtonEliminarSelec"
        Me.ButtonEliminarSelec.Size = New System.Drawing.Size(102, 23)
        Me.ButtonEliminarSelec.TabIndex = 16
        Me.ButtonEliminarSelec.Text = "Eliminar Seleccion"
        Me.ButtonEliminarSelec.UseVisualStyleBackColor = True
        Me.ButtonEliminarSelec.Visible = False
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 538)
        Me.Controls.Add(Me.ButtonEliminarSelec)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxBuscador)
        Me.Controls.Add(Me.ButtonMenu)
        Me.Controls.Add(Me.BotonCrearCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.GridClientes)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Name = "FormClientes"
        Me.Text = "Form1"
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents GridClientes As DataGridView
    Friend WithEvents ButtonPrevious As Button
    Friend WithEvents ButtonNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BotonCrearCliente As Button
    Friend WithEvents ButtonMenu As Button
    Friend WithEvents TextBoxBuscador As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents Accion As DataGridViewButtonColumn
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents ButtonEliminarSelec As Button
End Class
