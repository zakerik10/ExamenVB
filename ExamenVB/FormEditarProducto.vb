Public Class FormEditarProducto
    Dim producto As Producto
    Dim productoService As New ProductoService()
    Public Sub New(productoEdit As Producto)
        InitializeComponent()  ' Inicializa los componentes del formulario
        producto = productoEdit

        TextBoxNombre.Text = productoEdit.Nombre
        TextBoxPrecio.Text = productoEdit.Precio
        TextBoxCategoria.Text = productoEdit.Categoria
    End Sub

    Private Sub BotonEliminarCliente_Click(sender As Object, e As EventArgs) Handles BotonEliminarCliente.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar la respuesta del usuario
        If resultado = DialogResult.Yes Then
            ' El usuario hizo clic en Sí, realizar la acción de eliminar
            productoService.Eliminar(producto)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub BotonEditarCliente_Click(sender As Object, e As EventArgs) Handles BotonEditarCliente.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas editar este cliente?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar la respuesta del usuario
        If resultado = DialogResult.Yes Then
            ' El usuario hizo clic en Sí, realizar la acción de eliminar
            producto.Nombre = TextBoxNombre.Text
            producto.Precio = TextBoxPrecio.Text
            producto.Categoria = TextBoxCategoria.Text
            productoService.Editar(producto)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            ' El usuario hizo clic en No, no realizar la acción
            MessageBox.Show("Eliminación cancelada.")
        End If
    End Sub
End Class