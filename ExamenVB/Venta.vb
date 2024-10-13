Imports System.Configuration
Imports System.Data.SqlClient

Public Class Venta
    Public Property ID As Integer
    Public Property IDCliente As Integer
    Public Property Fecha As DateTime
    Public Property Total As Integer
End Class

Public Class VentaService
    Private connectionString As String = ConfigurationManager.ConnectionStrings("ExamenConnection").ConnectionString

    Public Sub Guardar(venta As Venta)

        Dim query As String = "
            INSERT INTO ventas (IDCliente, Fecha, Total) 
            VALUES (@IDCliente, @Fecha, @Total);
            SELECT SCOPE_IDENTITY();
            "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IDCliente", venta.IDCliente)
                command.Parameters.AddWithValue("@Fecha", venta.Fecha)
                command.Parameters.AddWithValue("@Total", venta.Total)

                Try
                    connection.Open()
                    venta.ID = CInt(command.ExecuteScalar())
                    'MessageBox.Show("Producto guardado exitosamente!")
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub Editar(venta As Venta)

        Dim query As String = "
            UPDATE ventas SET 
            Nombre = @IDCliente,
            Precio = @Fecha,
            Categoria = @Total 
            WHERE ID = @ID
            "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", venta.IDCliente)
                command.Parameters.AddWithValue("@Precio", venta.Fecha)
                command.Parameters.AddWithValue("@Categoria", venta.Total)
                command.Parameters.AddWithValue("@ID", venta.ID)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    'MessageBox.Show("Producto guardado exitosamente!")
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub Eliminar(venta As Venta)

        Dim query As String = "DELETE FROM Productos WHERE ID = @ID;"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", venta.ID)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    'MessageBox.Show("Producto eliminado exitosamente!")
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Function GetClientName(venta As Venta)
        Dim query As String = "SELECT cliente FROM clientes WHERE ID = @ID;"
        Dim nombreProducto As String = String.Empty

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", venta.IDCliente)

                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        nombreProducto = result.ToString()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
        Return nombreProducto
    End Function

    Public Function GetVentas(currentPage As Integer, sizePage As Integer)
        Dim inicio As Integer = (currentPage - 1) * sizePage + 1
        Dim fin As Integer = currentPage * sizePage

        Dim query As String = "
        WITH CTE AS (
            SELECT ventas.ID, clientes.Cliente, ventas.Fecha, ventas.Total, 
                   ROW_NUMBER() OVER (ORDER BY ventas.ID) AS RowNum
            FROM ventas
            JOIN Clientes
            ON ventas.IDCliente = clientes.ID
        "

        query &= "
        )
        SELECT ID, Cliente, Fecha, Total
        FROM CTE
        WHERE RowNum BETWEEN @Inicio AND @Fin
        "
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Inicio", inicio)
                command.Parameters.AddWithValue("@Fin", fin)
                Try
                    connection.Open()
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
        Return dataTable
    End Function
End Class