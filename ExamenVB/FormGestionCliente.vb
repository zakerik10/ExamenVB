

Public Class FormGestionCliente
    Dim cliente As Cliente
    Dim clienteService As New ClienteService()
    Delegate Sub Delegator(cliente As Cliente)
    Dim Accionar As Delegator
    Dim TextBox As String
    Public Sub New(clienteEdit As Cliente)
        InitializeComponent()  ' Inicializa los componentes del formulario
        cliente = clienteEdit
        If (cliente Is Nothing) Then
            LabelTitulo.Text = "Nuevo Cliente"
            BotonEliminarCliente.Hide()
            BotonConfirmar.Text = "Crear"
            Accionar = AddressOf clienteService.Guardar
            TextBox = "¿Estás seguro de que deseas crear este cliente?"
        Else
            LabelTitulo.Text = "Editar Cliente"
            BotonEliminarCliente.Show()
            BotonConfirmar.Text = "Editar"
            TextBoxNombre.Text = clienteEdit.Nombre
            TextBoxTelefono.Text = clienteEdit.Telefono
            TextBoxCorreo.Text = clienteEdit.Correo
            Accionar = AddressOf clienteService.Editar
            TextBox = "¿Estás seguro de que deseas editar este cliente?"
        End If


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

    Private Sub BotonEditarCliente_Click(sender As Object, e As EventArgs) Handles BotonConfirmar.Click
        Dim resultado As DialogResult = MessageBox.Show(TextBox, "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar la respuesta del usuario
        If resultado = DialogResult.Yes Then
            ' El usuario hizo clic en Sí, realizar la acción de eliminar
            Dim nombre As String = TextBoxNombre.Text
            Dim telefono As String = TextBoxTelefono.Text
            Dim correo As String = TextBoxCorreo.Text

            If (cliente Is Nothing) Then
                cliente = New Cliente(nombre, telefono, correo)
            Else
                cliente.Nombre = nombre
                cliente.Telefono = telefono
                cliente.Correo = correo
            End If

            Accionar(cliente)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class