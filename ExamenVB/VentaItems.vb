Imports System.Configuration
Imports System.Data.SqlClient

Public Class VentaItems
    Public Property ID As Integer
    Public Property IDVenta As Integer
    Public Property IDProducto As Integer
    Public Property PrecioUnitario As Integer
    Public Property Cantidad As Integer
    Public Property PrecioTotal As Integer
End Class

Public Class VentaItemsService
    Private connectionString As String = ConfigurationManager.ConnectionStrings("ExamenConnection").ConnectionString

    Public Sub Guardar(ventaItems As VentaItems)
        ventaItems.PrecioTotal = ventaItems.PrecioUnitario * ventaItems.Cantidad

        Dim query As String = "
            INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) 
            VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal);
            "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IDVenta", ventaItems.IDVenta)
                command.Parameters.AddWithValue("@IDProducto", ventaItems.IDProducto)
                command.Parameters.AddWithValue("@PrecioUnitario", ventaItems.PrecioUnitario)
                command.Parameters.AddWithValue("@Cantidad", ventaItems.Cantidad)
                command.Parameters.AddWithValue("@PrecioTotal", ventaItems.PrecioTotal)

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

    Public Sub Editar(ventaItems As VentaItems)

        Dim query As String = "
            UPDATE ventasitems SET 
            IDVenta = @IDVenta,
            IDProducto = @IDProducto,
            PrecioUnitario = @PrecioUnitario 
            Cantidad = @Cantidad 
            PrecioTotal = @PrecioTotal 
            WHERE ID = @ID
            "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IDVenta", ventaItems.IDVenta)
                command.Parameters.AddWithValue("@IDProducto", ventaItems.IDProducto)
                command.Parameters.AddWithValue("@PrecioUnitario", ventaItems.PrecioUnitario)
                command.Parameters.AddWithValue("@Cantidad", ventaItems.Cantidad)
                command.Parameters.AddWithValue("@PrecioTotal", ventaItems.PrecioTotal)

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

    Public Sub Eliminar(ventaItems As VentaItems)

        Dim query As String = "DELETE FROM ventasitems WHERE ID = @ID;"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", ventaItems.ID)

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
End Class