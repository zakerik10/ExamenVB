
Public Class FormGestionProducto
    Dim producto As Producto
    Dim productoService As New ProductoService()
    Delegate Sub Delegator(producto As Producto)
    Dim Accionar As Delegator
    Dim TextBox As String
    Public Sub New(productoEdit As Producto)
        InitializeComponent()  ' Inicializa los componentes del formulario
        producto = productoEdit

        If (producto Is Nothing) Then
            LabelTitulo.Text = "Nuevo Cliente"
            BotonEliminarCliente.Hide()
            BotonConfirmar.Text = "Crear"
            Accionar = AddressOf productoService.Guardar
            TextBox = "¿Estás seguro de que deseas crear este producto?"
        Else
            LabelTitulo.Text = "Editar Cliente"
            BotonEliminarCliente.Show()
            BotonConfirmar.Text = "Editar"
            TextBoxNombre.Text = productoEdit.Nombre
            TextBoxPrecio.Text = productoEdit.Precio
            TextBoxCategoria.Text = productoEdit.Categoria
            Accionar = AddressOf productoService.Editar
            TextBox = "¿Estás seguro de que deseas editar este producto?"
        End If
    End Sub

    Private Sub BotonEliminarCliente_Click(sender As Object, e As EventArgs) Handles BotonEliminarCliente.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            productoService.Eliminar(producto)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub BotonEditarCliente_Click(sender As Object, e As EventArgs) Handles BotonConfirmar.Click
        Dim resultado As DialogResult = MessageBox.Show(TextBox, "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then

            Try
                Dim nombre As String = TextBoxNombre.Text
                Dim precio As Integer = TextBoxPrecio.Text
                Dim categoria As String = TextBoxCategoria.Text

                If (producto Is Nothing) Then
                    producto = New Producto(nombre, precio, categoria)
                Else
                    producto.Nombre = nombre
                    producto.Precio = precio
                    producto.Categoria = categoria
                End If

                Accionar(producto)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Catch
                MessageBox.Show("Revise los tipos de datos")
            End Try
        End If
    End Sub
End Class