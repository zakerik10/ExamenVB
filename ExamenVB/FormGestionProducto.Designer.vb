<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionProducto
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
        Me.BotonEliminarCliente = New System.Windows.Forms.Button()
        Me.BotonConfirmar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCategoria = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BotonEliminarCliente
        '
        Me.BotonEliminarCliente.Location = New System.Drawing.Point(251, 48)
        Me.BotonEliminarCliente.Name = "BotonEliminarCliente"
        Me.BotonEliminarCliente.Size = New System.Drawing.Size(75, 23)
        Me.BotonEliminarCliente.TabIndex = 29
        Me.BotonEliminarCliente.Text = "Eliminar"
        Me.BotonEliminarCliente.UseVisualStyleBackColor = True
        '
        'BotonConfirmar
        '
        Me.BotonConfirmar.Location = New System.Drawing.Point(251, 186)
        Me.BotonConfirmar.Name = "BotonConfirmar"
        Me.BotonConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.BotonConfirmar.TabIndex = 28
        Me.BotonConfirmar.Text = "Editar"
        Me.BotonConfirmar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Categoria"
        '
        'TextBoxCategoria
        '
        Me.TextBoxCategoria.Location = New System.Drawing.Point(129, 160)
        Me.TextBoxCategoria.Name = "TextBoxCategoria"
        Me.TextBoxCategoria.Size = New System.Drawing.Size(197, 20)
        Me.TextBoxCategoria.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Precio"
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(129, 134)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(197, 20)
        Me.TextBoxPrecio.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nombre"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(129, 108)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(197, 20)
        Me.TextBoxNombre.TabIndex = 22
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Location = New System.Drawing.Point(48, 48)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(80, 13)
        Me.LabelTitulo.TabIndex = 21
        Me.LabelTitulo.Text = "Editar Producto"
        '
        'FormGestionProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 294)
        Me.Controls.Add(Me.BotonEliminarCliente)
        Me.Controls.Add(Me.BotonConfirmar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxCategoria)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Name = "FormGestionProducto"
        Me.Text = "FormEditarProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BotonEliminarCliente As Button
    Friend WithEvents BotonConfirmar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCategoria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents LabelTitulo As Label
End Class
