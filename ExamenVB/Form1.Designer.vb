<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ButtonLoadClients = New System.Windows.Forms.Button()
        Me.GridClientes = New System.Windows.Forms.DataGridView()
        Me.Accion = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.BotonAltaCliente = New System.Windows.Forms.Button()
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonLoadClients
        '
        Me.ButtonLoadClients.Location = New System.Drawing.Point(409, 419)
        Me.ButtonLoadClients.Name = "ButtonLoadClients"
        Me.ButtonLoadClients.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLoadClients.TabIndex = 0
        Me.ButtonLoadClients.Text = "Clientes"
        Me.ButtonLoadClients.UseVisualStyleBackColor = True
        '
        'GridClientes
        '
        Me.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Accion})
        Me.GridClientes.Location = New System.Drawing.Point(409, 37)
        Me.GridClientes.Name = "GridClientes"
        Me.GridClientes.Size = New System.Drawing.Size(427, 376)
        Me.GridClientes.TabIndex = 1
        '
        'Accion
        '
        Me.Accion.HeaderText = "Acción"
        Me.Accion.Name = "Accion"
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.Location = New System.Drawing.Point(680, 419)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPrevious.TabIndex = 2
        Me.ButtonPrevious.Text = "Atras"
        Me.ButtonPrevious.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(761, 419)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNext.TabIndex = 3
        Me.ButtonNext.Text = "Siguiente"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cargar Cliente"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(91, 80)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(197, 20)
        Me.TextBoxNombre.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Telèfono"
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(91, 106)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(197, 20)
        Me.TextBoxTelefono.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Correo"
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Location = New System.Drawing.Point(91, 132)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(197, 20)
        Me.TextBoxCorreo.TabIndex = 9
        '
        'BotonAltaCliente
        '
        Me.BotonAltaCliente.Location = New System.Drawing.Point(213, 170)
        Me.BotonAltaCliente.Name = "BotonAltaCliente"
        Me.BotonAltaCliente.Size = New System.Drawing.Size(75, 23)
        Me.BotonAltaCliente.TabIndex = 11
        Me.BotonAltaCliente.Text = "Cargar"
        Me.BotonAltaCliente.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 499)
        Me.Controls.Add(Me.BotonAltaCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxCorreo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.GridClientes)
        Me.Controls.Add(Me.ButtonLoadClients)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonLoadClients As Button
    Friend WithEvents GridClientes As DataGridView
    Friend WithEvents ButtonPrevious As Button
    Friend WithEvents ButtonNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents BotonAltaCliente As Button
    Friend WithEvents Accion As DataGridViewButtonColumn
End Class
