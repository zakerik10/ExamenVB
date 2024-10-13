<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridVentas = New System.Windows.Forms.DataGridView()
        Me.ButtonEliminarSelec = New System.Windows.Forms.Button()
        Me.IDVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerProductos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SeleccionarEliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonVolver = New System.Windows.Forms.Button()
        CType(Me.GridVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ventas"
        '
        'GridVentas
        '
        Me.GridVentas.AllowUserToAddRows = False
        Me.GridVentas.AllowUserToDeleteRows = False
        Me.GridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDVenta, Me.Cliente, Me.Fecha, Me.Total, Me.VerProductos, Me.SeleccionarEliminar, Me.IDCliente})
        Me.GridVentas.Location = New System.Drawing.Point(41, 87)
        Me.GridVentas.Name = "GridVentas"
        Me.GridVentas.ReadOnly = True
        Me.GridVentas.Size = New System.Drawing.Size(496, 335)
        Me.GridVentas.TabIndex = 1
        '
        'ButtonEliminarSelec
        '
        Me.ButtonEliminarSelec.Location = New System.Drawing.Point(436, 58)
        Me.ButtonEliminarSelec.Name = "ButtonEliminarSelec"
        Me.ButtonEliminarSelec.Size = New System.Drawing.Size(101, 23)
        Me.ButtonEliminarSelec.TabIndex = 2
        Me.ButtonEliminarSelec.Text = "Eliminar Seleccion"
        Me.ButtonEliminarSelec.UseVisualStyleBackColor = True
        '
        'IDVenta
        '
        Me.IDVenta.HeaderText = "ID Venta"
        Me.IDVenta.Name = "IDVenta"
        Me.IDVenta.ReadOnly = True
        Me.IDVenta.Visible = False
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'VerProductos
        '
        Me.VerProductos.HeaderText = "Ver Productos"
        Me.VerProductos.Name = "VerProductos"
        Me.VerProductos.ReadOnly = True
        Me.VerProductos.Text = "Ver Productos"
        Me.VerProductos.ToolTipText = "Ver Productos"
        Me.VerProductos.UseColumnTextForButtonValue = True
        '
        'SeleccionarEliminar
        '
        Me.SeleccionarEliminar.HeaderText = "Eliminar"
        Me.SeleccionarEliminar.Name = "SeleccionarEliminar"
        Me.SeleccionarEliminar.ReadOnly = True
        Me.SeleccionarEliminar.Width = 50
        '
        'IDCliente
        '
        Me.IDCliente.HeaderText = "IdCliente"
        Me.IDCliente.Name = "IDCliente"
        Me.IDCliente.ReadOnly = True
        Me.IDCliente.Visible = False
        '
        'ButtonVolver
        '
        Me.ButtonVolver.Location = New System.Drawing.Point(452, 29)
        Me.ButtonVolver.Name = "ButtonVolver"
        Me.ButtonVolver.Size = New System.Drawing.Size(85, 23)
        Me.ButtonVolver.TabIndex = 20
        Me.ButtonVolver.Text = "Volver al menu"
        Me.ButtonVolver.UseVisualStyleBackColor = True
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 453)
        Me.Controls.Add(Me.ButtonVolver)
        Me.Controls.Add(Me.ButtonEliminarSelec)
        Me.Controls.Add(Me.GridVentas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormVentas"
        Me.Text = "FormVentas"
        CType(Me.GridVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GridVentas As DataGridView
    Friend WithEvents ButtonEliminarSelec As Button
    Friend WithEvents IDVenta As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents VerProductos As DataGridViewButtonColumn
    Friend WithEvents SeleccionarEliminar As DataGridViewCheckBoxColumn
    Friend WithEvents IDCliente As DataGridViewTextBoxColumn
    Friend WithEvents ButtonVolver As Button
End Class
