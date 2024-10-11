Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Drawing.Printing

Public Class FormClientes

    Dim clienteService As New ClienteService()

    Private currentPage As Integer = 1
    Private sizePage As Integer = 20

    Private Sub ConfigureGridClientes()
        GridClientes.Rows.Clear()
        GridClientes.Columns.Clear()

        ' Crear las columnas necesarias (sin incluir el ID)
        GridClientes.Columns.Add("Cliente", "Nombre")
        GridClientes.Columns.Add("Telefono", "Teléfono")
        GridClientes.Columns.Add("Correo", "Correo")
        GridClientes.Columns.Add("ID", "ID")
        GridClientes.Columns("ID").Visible = False

        ' Agregar una columna para el botón de "Editar"
        Dim editButton As New DataGridViewButtonColumn()
        editButton.Name = "Editar"
        editButton.HeaderText = "Acciones"
        editButton.Text = "Editar"
        editButton.UseColumnTextForButtonValue = True
        GridClientes.Columns.Add(editButton)
    End Sub

    Private Sub LoadClientes(page As Integer)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ExamenConnection").ConnectionString

        ' Cálculo del offset
        Dim inicio As Integer = (currentPage - 1) * sizePage + 1
        Dim fin As Integer = currentPage * sizePage

        ' Consulta SQL con paginación
        Dim query As String = "
        WITH CTE AS (
            SELECT *, 
                   ROW_NUMBER() OVER (ORDER BY ID) AS RowNum
            FROM clientes
        )
        SELECT ID, Cliente, Telefono, Correo
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
                        Dim cliente As New Cliente(
                            row("Cliente").ToString(),
                            row("Telefono").ToString(),
                            row("Correo").ToString()
                        )
                        cliente.ID = Convert.ToInt32(row("ID"))
                        GridClientes.Rows.Add(cliente.Nombre, cliente.Telefono, cliente.Correo, cliente.ID)
                    Next

                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub GridClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridClientes.CellClick
        ' Verifica si se hizo clic en la columna de botones
        If e.ColumnIndex = GridClientes.Columns("Editar").Index AndAlso e.RowIndex >= 0 Then
            ' Obtener la fila seleccionada
            Dim fila As DataGridViewRow = GridClientes.Rows(e.RowIndex)

            ' Verificar que la celda "ID" no sea Nothing
            If fila.Cells("ID").Value IsNot Nothing AndAlso Not IsDBNull(fila.Cells("ID").Value) Then
                Dim id As Integer = Convert.ToInt32(fila.Cells("ID").Value)
                Dim nombre As String = If(fila.Cells("Cliente").Value IsNot Nothing, fila.Cells("Cliente").Value.ToString(), String.Empty)
                Dim telefono As String = If(fila.Cells("Telefono").Value IsNot Nothing, fila.Cells("Telefono").Value.ToString(), String.Empty)
                Dim correo As String = If(fila.Cells("Correo").Value IsNot Nothing, fila.Cells("Correo").Value.ToString(), String.Empty)

                ' Crear un nuevo objeto Cliente con los datos
                Dim cliente As New Cliente(nombre, telefono, correo) With {
                    .ID = id
                }

                ' Aquí puedes abrir un nuevo formulario o realizar otras acciones con el cliente
                Dim formEditar As New FormGestionCliente(cliente)
                If formEditar.ShowDialog() = DialogResult.OK Then
                    ' Si el usuario guarda los cambios, recarga la lista
                    LoadClientes(currentPage)
                End If
            Else
                MessageBox.Show("El ID del cliente no está disponible.")
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

    ' Evento al hacer clic en el botón para cargar los clientes
    Private Sub LoadClients(sender As Object, e As EventArgs) Handles ButtonLoadClients.Click
        LoadClientes(currentPage)
    End Sub

    ' Evento para el botón "Siguiente" de paginación
    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        currentPage += 1
        LoadClientes(currentPage)
    End Sub

    ' Evento para el botón "Anterior" de paginación
    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadClientes(currentPage)
        End If
    End Sub

    ' Evento que se ejecuta cuando el formulario carga
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar la primera página de clientes al iniciar el formulario
        LoadClientes(currentPage)
    End Sub

    Private Sub GestionarCliente(sender As Object, e As EventArgs) Handles BotonCrearCliente.Click
        Dim formGestion As New FormGestionCliente(Nothing)
        formGestion.ShowDialog()
        LoadClientes(currentPage)
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        Main.Show()
        Me.Close()
    End Sub
End Class
