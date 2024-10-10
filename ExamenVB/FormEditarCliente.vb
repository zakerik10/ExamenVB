

Public Class FormEditarCliente
    Dim cliente As Cliente
    Dim clienteService As New ClienteService()
    Public Sub New(clienteEdit As Cliente)
        InitializeComponent()  ' Inicializa los componentes del formulario
        cliente = clienteEdit

        TextBoxNombre.Text = clienteEdit.Nombre
        TextBoxTelefono.Text = clienteEdit.Telefono
        TextBoxCorreo.Text = clienteEdit.Correo
    End Sub

    Private Sub BotonEliminarCliente_Click(sender As Object, e As EventArgs) Handles BotonEliminarCliente.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar la respuesta del usuario
        If resultado = DialogResult.Yes Then
            ' El usuario hizo clic en Sí, realizar la acción de eliminar
            clienteService.Eliminar(cliente)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub BotonEditarCliente_Click(sender As Object, e As EventArgs) Handles BotonEditarCliente.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas editar este cliente?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar la respuesta del usuario
        If resultado = DialogResult.Yes Then
            ' El usuario hizo clic en Sí, realizar la acción de eliminar
            cliente.Nombre = TextBoxNombre.Text
            cliente.Telefono = TextBoxTelefono.Text
            cliente.Correo = TextBoxCorreo.Text
            clienteService.Editar(cliente)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            ' El usuario hizo clic en No, no realizar la acción
            MessageBox.Show("Eliminación cancelada.")
        End If
    End Sub
End Class