Imports System.Configuration
Imports System.Runtime.Remoting

Public Class FormProductos
    Dim productoService As New ProductoService()
    Dim ventaService As New VentaService()

    Private currentPage As Integer = 1
    Private sizePage As Integer = 20
    Private ignoreSelectionChange As Boolean = False

    Private esVenta As Boolean
    Private cliente As Cliente
    Dim venta As New Venta()


    Private listaCarrito As List(Of VentaItems)

    Private idVenta As Nullable(Of Integer) = Nothing

    Public Sub New(cliente As Cliente, idVenta As Nullable(Of Integer))
        ' Si me llega un cliente, es para seleccionar productos que quiere comprar
        ' Si me llega un cliente y un id de venta, es para ver los productos que compro el cliente
        ' Si no me llega ningun cliente, es para ver todos los productos que hay, crear, editar o eliminar
        InitializeComponent()
        Me.cliente = cliente
        listaCarrito = New List(Of VentaItems)()
        Subtotal.Visible = False
        If cliente IsNot Nothing Then
            If idVenta Is Nothing Then
                esVenta = True
                LabelTitulo.Text = "Seleccionar Productos para " & cliente.Nombre
                ButtonVolver.Text = "Volver"
                BotonCrearProducto.Hide()
                SeleccionarEliminar.Visible = False
                Accion.Visible = False
                ButtonVerCarrito.Show()
                Cantidad.Visible = True
                Cantidad.ReadOnly = False
                AgregarCarrito.Visible = True

                venta.IDCliente = cliente.ID

            Else
                Me.idVenta = idVenta
                ButtonVolver.Text = "Salir"
                ButtonVolver.Visible = True
                LabelTitulo.Text = "Productos que comrpó " & cliente.Nombre
                BotonCrearProducto.Hide()
                SeleccionarEliminar.Visible = False
                Accion.Visible = False
                ButtonVerCarrito.Hide()
                Cantidad.Visible = True
                Cantidad.ReadOnly = True
                AgregarCarrito.Visible = False
                Subtotal.Visible = True
            End If

        Else
            esVenta = False
            LabelTitulo.Text = "Productos"
            ButtonVolver.Text = "Volver al menu"
            BotonCrearProducto.Show()
            SeleccionarEliminar.Visible = True
            Accion.Visible = True
            ButtonVerCarrito.Hide()
            Cantidad.Visible = False
            AgregarCarrito.Visible = False


        End If
    End Sub
    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategorias()
        LoadProductos()
    End Sub

    Private Sub LoadCategorias()
        ComboBoxCategorias.Items.Clear()

        Dim dataTable As DataTable = productoService.GetCategorias()

        For Each row As DataRow In dataTable.Rows
            ComboBoxCategorias.Items.Add(row("Categoria").ToString())
        Next
    End Sub

    Private Sub LoadProductos()

        GridClientes.Rows.Clear()

        Dim buscador As String = TextBoxBuscador.Text
        Dim categoria As String = If(ComboBoxCategorias.SelectedItem IsNot Nothing, ComboBoxCategorias.SelectedItem.ToString(), Nothing)
        Dim precioMin As Nullable(Of Integer)
        Dim precioMax As Nullable(Of Integer)

        If Not String.IsNullOrEmpty(TextBoxMinPrecio.Text) Then
            precioMin = CInt(TextBoxMinPrecio.Text.ToString())
        Else
            precioMin = Nothing
        End If

        If Not String.IsNullOrEmpty(TextBoxMaxPrecio.Text) Then
            precioMax = CInt(TextBoxMaxPrecio.Text.ToString())
        Else
            precioMax = Nothing
        End If

        Dim dataTable As DataTable = productoService.GetProductos(currentPage, sizePage, buscador, categoria, precioMin, precioMax, idVenta)

        For Each row As DataRow In dataTable.Rows
            Dim idProducto As Integer = CInt(row("IDProducto"))
            Dim nombreProducto As String = row("NombreProducto").ToString()
            Dim precioProducto As String = row("PrecioProducto").ToString()
            Dim categoriaProducto As String = row("CategoriaProducto").ToString()
            Dim cantidad As String
            If row.Table.Columns.Contains("Cantidad") AndAlso Not IsDBNull(row("Cantidad")) Then
                cantidad = row("Cantidad").ToString()
            Else
                cantidad = "0" ' O cualquier valor predeterminado que quieras usar
            End If
            GridClientes.Rows.Add(idProducto, nombreProducto, categoriaProducto, cantidad, precioProducto, precioProducto * cantidad)
        Next
        If idVenta IsNot Nothing Then
            GridClientes.Rows.Add("", "", "", "", "Total:", ventaService.GetTotalVentas(idVenta))
        End If
    End Sub

    Private Sub GridClientes_CellClick(sender As Object, grid As DataGridViewCellEventArgs) Handles GridClientes.CellClick
        If grid.ColumnIndex = GridClientes.Columns("Accion").Index AndAlso grid.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = GridClientes.Rows(grid.RowIndex)

            If fila.Cells("ID").Value IsNot Nothing AndAlso Not IsDBNull(fila.Cells("ID").Value) Then
                Dim id As Integer = CInt(fila.Cells("ID").Value)
                Dim nombre As String = If(fila.Cells("Nombre").Value IsNot Nothing, fila.Cells("Nombre").Value.ToString(), String.Empty)
                Dim precio As Integer = If(fila.Cells("Precio").Value IsNot Nothing, fila.Cells("Precio").Value.ToString(), String.Empty)
                Dim categoria As String = If(fila.Cells("Categoria").Value IsNot Nothing, fila.Cells("Categoria").Value.ToString(), String.Empty)

                Dim producto As New Producto(nombre, precio, categoria) With {
                    .ID = id
                }

                Dim formEditar As New FormGestionProducto(producto)
                If formEditar.ShowDialog() = DialogResult.OK Then
                    LoadCategorias()
                    LoadProductos()
                End If
            Else
                MessageBox.Show("El ID del producto no está disponible.")
            End If
        End If
    End Sub

    Private Sub GridClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridClientes.CellContentClick
        Dim nombreColumna As String = "SeleccionarEliminar"
        If e.ColumnIndex = GridClientes.Columns(nombreColumna).Index AndAlso e.RowIndex >= 0 Then
            Dim checkBoxCell As DataGridViewCheckBoxCell = CType(GridClientes.Rows(e.RowIndex).Cells(nombreColumna), DataGridViewCheckBoxCell)
            checkBoxCell.Value = Not CBool(checkBoxCell.Value)

            Dim cantidadSeleccionadas As Integer = 0
            For Each row As DataGridViewRow In GridClientes.Rows
                If CBool(row.Cells(nombreColumna).Value) Then
                    cantidadSeleccionadas += 1
                End If
            Next

            If cantidadSeleccionadas > 0 Then
                ButtonEliminarSelec.Show()
            Else
                ButtonEliminarSelec.Hide()
            End If
        End If
    End Sub

    Private Sub GridClientes_CellClickCarrito(sender As Object, grid As DataGridViewCellEventArgs) Handles GridClientes.CellClick
        If grid.ColumnIndex = GridClientes.Columns("AgregarCarrito").Index AndAlso grid.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = GridClientes.Rows(grid.RowIndex)

            If fila.Cells("ID").Value IsNot Nothing AndAlso Not IsDBNull(fila.Cells("ID").Value) Then
                Dim idProducto As Integer = CInt(fila.Cells("ID").Value)
                Dim nombreProducto As String = If(fila.Cells("Nombre").Value IsNot Nothing, fila.Cells("Nombre").Value.ToString(), String.Empty)
                Dim cantidadProducto As Integer = If(fila.Cells("Cantidad").Value IsNot Nothing, CInt(fila.Cells("Cantidad").Value), 0)
                Dim precioProducto As Integer = If(fila.Cells("Precio").Value IsNot Nothing, CInt(fila.Cells("Precio").Value), 0)

                If cantidadProducto > 0 Then
                    Dim itemEnCarrito As VentaItems = listaCarrito.Find(Function(item) item.IDProducto = idProducto)
                    If itemEnCarrito Is Nothing Then
                        Dim ventaItems As New VentaItems() With {
                        .IDProducto = idProducto,
                        .PrecioUnitario = precioProducto,
                        .Cantidad = cantidadProducto
                    }

                        listaCarrito.Add(ventaItems)
                    Else
                        itemEnCarrito.Cantidad += cantidadProducto
                    End If
                    MessageBox.Show("Se agregaron al carrito" & vbCrLf & "Producto: " & nombreProducto & vbCrLf & "Cantidad: " & cantidadProducto)
                    fila.Cells("Cantidad").Value = Nothing

                Else
                    MessageBox.Show("Elija una cantida válida")
                End If

            Else
                MessageBox.Show("El ID del producto no está disponible.")
            End If
        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles GridClientes.EditingControlShowing
        If GridClientes.CurrentCell.ColumnIndex = GridClientes.Columns("Cantidad").Index Then
            Dim textBox As TextBox = CType(e.Control, TextBox)
            RemoveHandler textBox.KeyPress, AddressOf TextBox_KeyPress
            AddHandler textBox.KeyPress, AddressOf TextBox_KeyPress
        End If
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Permitir solo dígitos y el control de retroceso
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Evitar la entrada
        End If
    End Sub

    Private Sub ButtonEliminarSelec_Click(sender As Object, e As EventArgs) Handles ButtonEliminarSelec.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar los productos seleccionados?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then

            For Each fila As DataGridViewRow In GridClientes.Rows
                Dim checkBoxCell As DataGridViewCheckBoxCell = CType(fila.Cells("SeleccionarEliminar"), DataGridViewCheckBoxCell)

                If checkBoxCell IsNot Nothing AndAlso CBool(checkBoxCell.Value) Then
                    Dim id As Integer = CInt(fila.Cells("ID").Value)
                    Dim nombre As String = If(fila.Cells("Nombre").Value IsNot Nothing, fila.Cells("Nombre").Value.ToString(), String.Empty)
                    Dim precio As Integer = If(fila.Cells("Precio").Value IsNot Nothing, fila.Cells("Precio").Value, String.Empty)
                    Dim categoria As String = If(fila.Cells("Categoria").Value IsNot Nothing, fila.Cells("Categoria").Value.ToString(), String.Empty)

                    Dim producto As New Producto(nombre, precio, categoria) With {
                        .ID = id
                    }

                    productoService.Eliminar(producto)
                End If
            Next
            ButtonEliminarSelec.Hide()
            LoadCategorias()
            LoadProductos()
        End If
    End Sub

    Private Sub ComboBoxCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategorias.SelectedIndexChanged
        LoadProductos()
    End Sub

    Private Function ObtenerFilaPorID(id As Integer) As DataGridViewRow
        For Each row As DataGridViewRow In GridClientes.Rows
            If row.Cells("ID").Value IsNot Nothing AndAlso CInt(row.Cells("ID").Value) = id Then
                Return row
            End If
        Next
        Return Nothing
    End Function


    Private Sub LoadClients(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        LoadProductos()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        currentPage += 1
        LoadProductos()
    End Sub

    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadProductos()
        End If
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        If esVenta Then
            Dim FormClientes As New FormClientes(True)
            FormClientes.Show()
            Me.Close()
        Else
            If idVenta Is Nothing Then
                Main.Show()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub GestionarCliente(sender As Object, e As EventArgs) Handles BotonCrearProducto.Click
        Dim formGestion As New FormGestionProducto(Nothing)
        formGestion.ShowDialog()
        LoadCategorias()
        LoadProductos()
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        ComboBoxCategorias.SelectedIndex = -1
        TextBoxBuscador.Text = Nothing
        TextBoxMaxPrecio.Text() = Nothing
        TextBoxMinPrecio.Text() = Nothing
        LoadProductos()
    End Sub

    Private Sub ButtonLimpiarFiltro_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarFiltroCategoria.Click
        ComboBoxCategorias.SelectedIndex = -1
    End Sub

    Private Sub TextBoxMinPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMinPrecio.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxMaxPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMaxPrecio.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBoxMinPrecio.Text() IsNot Nothing Or TextBoxMaxPrecio.Text() IsNot Nothing Then
            LoadProductos()
        End If
    End Sub

    Private Sub ButtonLimpiarFiltroPrecio_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarFiltroPrecio.Click
        TextBoxMaxPrecio.Text() = Nothing
        TextBoxMinPrecio.Text() = Nothing
        LoadProductos()
    End Sub

    Private Sub ButtonVerCarrito_Click(sender As Object, e As EventArgs) Handles ButtonVerCarrito.Click
        Dim carrito As New FormCarrito(venta, listaCarrito)
        If carrito.ShowDialog() = DialogResult.OK Then
            Main.Show()
        End If
    End Sub
End Class