﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ButtonLoadClientes = New System.Windows.Forms.Button()
        Me.GridClientes = New System.Windows.Forms.DataGridView()
        Me.Accion = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BotonCrearCliente = New System.Windows.Forms.Button()
        Me.ButtonMenu = New System.Windows.Forms.Button()
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonLoadClientes
        '
        Me.ButtonLoadClientes.Location = New System.Drawing.Point(44, 444)
        Me.ButtonLoadClientes.Name = "ButtonLoadClientes"
        Me.ButtonLoadClientes.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLoadClientes.TabIndex = 0
        Me.ButtonLoadClientes.Text = "Cargar Lista"
        Me.ButtonLoadClientes.UseVisualStyleBackColor = True
        '
        'GridClientes
        '
        Me.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Accion})
        Me.GridClientes.Location = New System.Drawing.Point(44, 62)
        Me.GridClientes.Name = "GridClientes"
        Me.GridClientes.Size = New System.Drawing.Size(438, 376)
        Me.GridClientes.TabIndex = 1
        '
        'Accion
        '
        Me.Accion.HeaderText = "Acción"
        Me.Accion.Name = "Accion"
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.Location = New System.Drawing.Point(326, 444)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPrevious.TabIndex = 2
        Me.ButtonPrevious.Text = "Atras"
        Me.ButtonPrevious.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(407, 444)
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
        Me.BotonCrearCliente.Location = New System.Drawing.Point(125, 444)
        Me.BotonCrearCliente.Name = "BotonCrearCliente"
        Me.BotonCrearCliente.Size = New System.Drawing.Size(95, 23)
        Me.BotonCrearCliente.TabIndex = 11
        Me.BotonCrearCliente.Text = "Cliente Nuevo"
        Me.BotonCrearCliente.UseVisualStyleBackColor = True
        '
        'ButtonMenu
        '
        Me.ButtonMenu.Location = New System.Drawing.Point(397, 19)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(85, 23)
        Me.ButtonMenu.TabIndex = 12
        Me.ButtonMenu.Text = "Volver al menu"
        Me.ButtonMenu.UseVisualStyleBackColor = True
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 501)
        Me.Controls.Add(Me.ButtonMenu)
        Me.Controls.Add(Me.BotonCrearCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.GridClientes)
        Me.Controls.Add(Me.ButtonLoadClientes)
        Me.Name = "FormClientes"
        Me.Text = "Form1"
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonLoadClientes As Button
    Friend WithEvents GridClientes As DataGridView
    Friend WithEvents ButtonPrevious As Button
    Friend WithEvents ButtonNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BotonCrearCliente As Button
    Friend WithEvents Accion As DataGridViewButtonColumn
    Friend WithEvents ButtonMenu As Button
End Class
