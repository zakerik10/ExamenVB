<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCarrito
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
        Me.LabelTituloCarrito = New System.Windows.Forms.Label()
        Me.GridCarrito = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quitar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.ButtonConfirmarVenta = New System.Windows.Forms.Button()
        CType(Me.GridCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTituloCarrito
        '
        Me.LabelTituloCarrito.AutoSize = True
        Me.LabelTituloCarrito.Location = New System.Drawing.Point(37, 37)
        Me.LabelTituloCarrito.Name = "LabelTituloCarrito"
        Me.LabelTituloCarrito.Size = New System.Drawing.Size(37, 13)
        Me.LabelTituloCarrito.TabIndex = 0
        Me.LabelTituloCarrito.Text = "Carrito"
        '
        'GridCarrito
        '
        Me.GridCarrito.AllowUserToAddRows = False
        Me.GridCarrito.AllowUserToDeleteRows = False
        Me.GridCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridCarrito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.PrecioUnitario, Me.Cantidad, Me.Quitar})
        Me.GridCarrito.Location = New System.Drawing.Point(40, 86)
        Me.GridCarrito.Name = "GridCarrito"
        Me.GridCarrito.ReadOnly = True
        Me.GridCarrito.Size = New System.Drawing.Size(448, 352)
        Me.GridCarrito.TabIndex = 1
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.HeaderText = "Precio Unitario"
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Quitar
        '
        Me.Quitar.HeaderText = "Quitar"
        Me.Quitar.Name = "Quitar"
        Me.Quitar.ReadOnly = True
        Me.Quitar.Text = "Quitar"
        Me.Quitar.ToolTipText = "Quitar"
        Me.Quitar.UseColumnTextForButtonValue = True
        Me.Quitar.Width = 70
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Location = New System.Drawing.Point(388, 444)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotal.TabIndex = 2
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(351, 447)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(31, 13)
        Me.LabelTotal.TabIndex = 3
        Me.LabelTotal.Text = "Total"
        '
        'ButtonConfirmarVenta
        '
        Me.ButtonConfirmarVenta.Location = New System.Drawing.Point(354, 470)
        Me.ButtonConfirmarVenta.Name = "ButtonConfirmarVenta"
        Me.ButtonConfirmarVenta.Size = New System.Drawing.Size(134, 38)
        Me.ButtonConfirmarVenta.TabIndex = 4
        Me.ButtonConfirmarVenta.Text = "Confirmar Venta"
        Me.ButtonConfirmarVenta.UseVisualStyleBackColor = True
        '
        'FormCarrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 594)
        Me.Controls.Add(Me.ButtonConfirmarVenta)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.GridCarrito)
        Me.Controls.Add(Me.LabelTituloCarrito)
        Me.Name = "FormCarrito"
        Me.Text = "FormCarrito"
        CType(Me.GridCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTituloCarrito As Label
    Friend WithEvents GridCarrito As DataGridView
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Quitar As DataGridViewButtonColumn
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents LabelTotal As Label
    Friend WithEvents ButtonConfirmarVenta As Button
End Class
