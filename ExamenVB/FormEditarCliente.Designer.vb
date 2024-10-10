<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarCliente
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
        Me.BotonEditarCliente = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.BotonEliminarCliente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BotonEditarCliente
        '
        Me.BotonEditarCliente.Location = New System.Drawing.Point(260, 178)
        Me.BotonEditarCliente.Name = "BotonEditarCliente"
        Me.BotonEditarCliente.Size = New System.Drawing.Size(75, 23)
        Me.BotonEditarCliente.TabIndex = 19
        Me.BotonEditarCliente.Text = "Editar"
        Me.BotonEditarCliente.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Correo"
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Location = New System.Drawing.Point(138, 152)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(197, 20)
        Me.TextBoxCorreo.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Telèfono"
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(138, 126)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(197, 20)
        Me.TextBoxTelefono.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(138, 100)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(197, 20)
        Me.TextBoxNombre.TabIndex = 13
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Location = New System.Drawing.Point(57, 40)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(69, 13)
        Me.LabelTitulo.TabIndex = 12
        Me.LabelTitulo.Text = "Editar Cliente"
        '
        'BotonEliminarCliente
        '
        Me.BotonEliminarCliente.Location = New System.Drawing.Point(260, 40)
        Me.BotonEliminarCliente.Name = "BotonEliminarCliente"
        Me.BotonEliminarCliente.Size = New System.Drawing.Size(75, 23)
        Me.BotonEliminarCliente.TabIndex = 20
        Me.BotonEliminarCliente.Text = "Eliminar"
        Me.BotonEliminarCliente.UseVisualStyleBackColor = True
        '
        'FormEditarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 330)
        Me.Controls.Add(Me.BotonEliminarCliente)
        Me.Controls.Add(Me.BotonEditarCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxCorreo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Name = "FormEditarCliente"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BotonEditarCliente As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents BotonEliminarCliente As Button
End Class
