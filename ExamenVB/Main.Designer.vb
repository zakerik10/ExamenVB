<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.ButtonClientes = New System.Windows.Forms.Button()
        Me.ButtonProductos = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonVender = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenidos"
        '
        'ButtonClientes
        '
        Me.ButtonClientes.Location = New System.Drawing.Point(129, 101)
        Me.ButtonClientes.Name = "ButtonClientes"
        Me.ButtonClientes.Size = New System.Drawing.Size(130, 42)
        Me.ButtonClientes.TabIndex = 1
        Me.ButtonClientes.Text = "Clientes"
        Me.ButtonClientes.UseVisualStyleBackColor = True
        '
        'ButtonProductos
        '
        Me.ButtonProductos.Location = New System.Drawing.Point(129, 149)
        Me.ButtonProductos.Name = "ButtonProductos"
        Me.ButtonProductos.Size = New System.Drawing.Size(130, 42)
        Me.ButtonProductos.TabIndex = 2
        Me.ButtonProductos.Text = "Productos"
        Me.ButtonProductos.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(129, 334)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(130, 42)
        Me.ButtonSalir.TabIndex = 3
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'ButtonVender
        '
        Me.ButtonVender.Location = New System.Drawing.Point(129, 197)
        Me.ButtonVender.Name = "ButtonVender"
        Me.ButtonVender.Size = New System.Drawing.Size(130, 42)
        Me.ButtonVender.TabIndex = 4
        Me.ButtonVender.Text = "Vender"
        Me.ButtonVender.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 432)
        Me.Controls.Add(Me.ButtonVender)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonProductos)
        Me.Controls.Add(Me.ButtonClientes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonClientes As Button
    Friend WithEvents ButtonProductos As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ButtonVender As Button
End Class
