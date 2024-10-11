Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormProductos
    Dim productoService As New ProductoService()

    Private currentPage As Integer = 1
    Private sizePage As Integer = 20
    Private ignoreSelectionChange As Boolean = False
    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductos()
    End Sub

    Private Sub LoadProductos()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ExamenConnection").ConnectionString

        Dim inicio As Integer = (currentPage - 1) * sizePage + 1
        Dim fin As Integer = currentPage * sizePage

        Dim precioMin As Integer = 0
        Dim precioMax As Integer = 99999999

        Dim query As String = "
        WITH CTE AS (
            SELECT *, 
                   ROW_NUMBER() OVER (ORDER BY ID) AS RowNum
            FROM productos
            WHERE 1 = 1
        "

        If Not String.IsNullOrEmpty(TextBoxBuscador.Text) Then
            query &= " AND Nombre LIKE @Nombre"
        End If

        If ComboBoxCategorias.SelectedIndex <> -1 Then
            query &= " AND Categoria = @Categoria"
        End If

        If Not String.IsNullOrEmpty(TextBoxMinPrecio.Text()) Or Not String.IsNullOrEmpty(TextBoxMaxPrecio.Text()) Then
            If Not String.IsNullOrEmpty(TextBoxMinPrecio.Text()) Then
                precioMin = CInt(TextBoxMinPrecio.Text())
            End If
            If Not String.IsNullOrEmpty(TextBoxMaxPrecio.Text()) Then
                precioMax = CInt(TextBoxMaxPrecio.Text())
            End If
            query &= " AND precio BETWEEN @PrecioMin AND @PrecioMax"
        End If

        query &= "
        )
        SELECT ID, Nombre, Precio, Categoria
        FROM CTE
        WHERE RowNum BETWEEN @Inicio AND @Fin;
        "

        Dim queryCategorias As String = "SELECT DISTINCT Categoria FROM productos"

        GridClientes.Rows.Clear()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                If Not String.IsNullOrEmpty(TextBoxBuscador.Text) Then
                    command.Parameters.AddWithValue("@Nombre", "%" & TextBoxBuscador.Text & "%")
                End If

                If ComboBoxCategorias.SelectedIndex <> -1 Then
                    command.Parameters.AddWithValue("@Categoria", ComboBoxCategorias.SelectedItem.ToString())
                End If

                If Not String.IsNullOrEmpty(TextBoxMinPrecio.Text()) Or Not String.IsNullOrEmpty(TextBoxMaxPrecio.Text()) Then
                    command.Parameters.AddWithValue("@PrecioMin", precioMin)
                    command.Parameters.AddWithValue("@PrecioMax", precioMax)
                End If

                command.Parameters.AddWithValue("@Inicio", inicio)
                command.Parameters.AddWithValue("@Fin", fin)

                Try
                    connection.Open()
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()

                    adapter.Fill(dataTable)

                    For Each row As DataRow In dataTable.Rows
                        Dim producto As New Producto(
                            row("Nombre").ToString(),
                            row("Precio").ToString(),
                            row("Categoria").ToString()
                        ) With {
                            .ID = CInt(row("ID"))
                        }
                        GridClientes.Rows.Add(producto.ID, producto.Nombre, producto.Precio, producto.Categoria)
                    Next

                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using

            Dim categoriaSeleccionada As String = If(ComboBoxCategorias.SelectedItem IsNot Nothing, ComboBoxCategorias.SelectedItem.ToString(), String.Empty)

            ignoreSelectionChange = True

            Using commandCategoria As New SqlCommand(queryCategorias, connection)

                Try
                    ComboBoxCategorias.Items.Clear()
                    Dim command As New SqlCommand(query, connection)
                    Dim reader As SqlDataReader = commandCategoria.ExecuteReader()
                    While reader.Read()
                        ComboBoxCategorias.Items.Add(reader("Categoria").ToString())
                    End While
                Catch ex As Exception
                    MessageBox.Show("Error al cargar las categorias: " & ex.Message)
                End Try
            End Using

            If Not String.IsNullOrEmpty(categoriaSeleccionada) Then
                ComboBoxCategorias.SelectedItem = categoriaSeleccionada
            End If
            ignoreSelectionChange = False
        End Using
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
                    LoadProductos()
                End If
            Else
                MessageBox.Show("El ID del producto no está disponible.")
            End If
        End If
    End Sub

    Private Sub GridClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridClientes.CellContentClick
        If e.ColumnIndex = GridClientes.Columns("Seleccionar").Index AndAlso e.RowIndex >= 0 Then
            Dim checkBoxCell As DataGridViewCheckBoxCell = CType(GridClientes.Rows(e.RowIndex).Cells("Seleccionar"), DataGridViewCheckBoxCell)
            checkBoxCell.Value = Not CBool(checkBoxCell.Value)

            Dim cantidadSeleccionadas As Integer = 0
            For Each row As DataGridViewRow In GridClientes.Rows
                If CBool(row.Cells("Seleccionar").Value) Then
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

    Private Sub ButtonEliminarSelec_Click(sender As Object, e As EventArgs) Handles ButtonEliminarSelec.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar los productos seleccionados?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then

            For Each fila As DataGridViewRow In GridClientes.Rows
                Dim checkBoxCell As DataGridViewCheckBoxCell = CType(fila.Cells("Seleccionar"), DataGridViewCheckBoxCell)

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
            LoadProductos()
        End If
    End Sub

    Private Sub ComboBoxCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategorias.SelectedIndexChanged
        If ignoreSelectionChange Then Return

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
        If Not String.IsNullOrEmpty(TextBoxBuscador.Text()) Then
            LoadProductos()
        End If
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

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub GestionarCliente(sender As Object, e As EventArgs) Handles BotonCrearProducto.Click
        Dim formGestion As New FormGestionProducto(Nothing)
        formGestion.ShowDialog()
        LoadProductos()
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TextBoxBuscador.Text = Nothing
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarFiltroPrecio.Click
        TextBoxMaxPrecio.Text() = Nothing
        TextBoxMinPrecio.Text() = Nothing
        LoadProductos()
    End Sub
End Class