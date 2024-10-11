Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormProductos
    Dim clienteService As New ClienteService()

    Private currentPage As Integer = 1
    Private sizePage As Integer = 20

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductos(currentPage)
    End Sub

    Private Sub ConfigureGridClientes()
        GridClientes.Rows.Clear()
        GridClientes.Columns.Clear()

        ' Crear las columnas necesarias (sin incluir el ID)
        GridClientes.Columns.Add("Nombre", "Nombre")
        GridClientes.Columns.Add("Precio", "Precio")
        GridClientes.Columns.Add("Categoria", "Categoria")
        GridClientes.Columns.Add("ID", "ID")
        GridClientes.Columns("ID").Visible = False

        ' Agregar una columna para el botón de "Editar"
        Dim editButton As New DataGridViewButtonColumn()
        editButton.Name = "Editar O Eliminar"
        editButton.HeaderText = "Acciones"
        editButton.Text = "Editar O Eliminar"
        editButton.UseColumnTextForButtonValue = True
        GridClientes.Columns.Add(editButton)
    End Sub

    Private Sub LoadProductos(page As Integer)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ExamenConnection").ConnectionString

        ' Cálculo del offset
        Dim inicio As Integer = (currentPage - 1) * sizePage + 1
        Dim fin As Integer = currentPage * sizePage

        ' Consulta SQL con paginación
        Dim query As String = "
        WITH CTE AS (
            SELECT *, 
                   ROW_NUMBER() OVER (ORDER BY ID) AS RowNum
            FROM productos
        )
        SELECT ID, Nombre, Precio, Categoria
        FROM CTE
        WHERE RowNum BETWEEN @Inicio AND @Fin;
        "

        ConfigureGridClientes()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Parámetros de la consulta
                command.Parameters.AddWithValue("@Inicio", inicio)
                command.Parameters.AddWithValue("@Fin", fin)

                Try
                    connection.Open()
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()

                    ' Llenar el DataTable con los resultados
                    adapter.Fill(dataTable)

                    For Each row As DataRow In dataTable.Rows
                        ' Crear un nuevo objeto Cliente
                        Dim producto As New Producto(
                            row("Nombre").ToString(),
                            row("Precio").ToString(),
                            row("Categoria").ToString()
                        ) With {
                            .ID = Convert.ToInt32(row("ID"))
                        }
                        GridClientes.Rows.Add(producto.Nombre, producto.Precio, producto.Categoria, producto.ID)
                    Next

                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub GridClientes_CellClick(sender As Object, grid As DataGridViewCellEventArgs) Handles GridClientes.CellClick
        If grid.ColumnIndex = GridClientes.Columns("Editar").Index AndAlso grid.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = GridClientes.Rows(grid.RowIndex)

            If fila.Cells("ID").Value IsNot Nothing AndAlso Not IsDBNull(fila.Cells("ID").Value) Then
                Dim id As Integer = Convert.ToInt32(fila.Cells("ID").Value)
                Dim nombre As String = If(fila.Cells("Nombre").Value IsNot Nothing, fila.Cells("Nombre").Value.ToString(), String.Empty)
                Dim precio As String = If(fila.Cells("Precio").Value IsNot Nothing, fila.Cells("Precio").Value.ToString(), String.Empty)
                Dim categoria As String = If(fila.Cells("Categoria").Value IsNot Nothing, fila.Cells("Categoria").Value.ToString(), String.Empty)

                Dim producto As New Producto(nombre, precio, categoria) With {
                    .ID = id
                }

                Dim formEditar As New FormGestionProducto(producto)
                If formEditar.ShowDialog() = DialogResult.OK Then
                    LoadProductos(currentPage)
                End If
            Else
                MessageBox.Show("El ID del producto no está disponible.")
            End If
        End If
    End Sub

    Private Function ObtenerFilaPorID(id As Integer) As DataGridViewRow
        For Each row As DataGridViewRow In GridClientes.Rows
            If row.Cells("ID").Value IsNot Nothing AndAlso CInt(row.Cells("ID").Value) = id Then
                Return row
            End If
        Next
        Return Nothing
    End Function


    Private Sub LoadClients(sender As Object, e As EventArgs) Handles ButtonLoadProductos.Click
        LoadProductos(currentPage)
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        currentPage += 1
        LoadProductos(currentPage)
    End Sub

    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadProductos(currentPage)
        End If
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub GestionarCliente(sender As Object, e As EventArgs) Handles BotonCrearProducto.Click
        Dim formGestion As New FormGestionProducto(Nothing)
        formGestion.ShowDialog()
        LoadProductos(currentPage)
    End Sub
End Class