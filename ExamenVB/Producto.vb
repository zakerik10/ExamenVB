Imports System.Configuration
Imports System.Data.SqlClient

Public Class Producto
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Precio As Integer
    Public Property Categoria As String

    Public Sub New(nombre As String, precio As String, categoria As String)
        Me.Nombre = nombre
        Me.Precio = precio
        Me.Categoria = categoria
    End Sub
End Class

Public Class ProductoService
    Private connectionString As String = ConfigurationManager.ConnectionStrings("ExamenConnection").ConnectionString

    Public Sub Guardar(producto As Producto)

        Dim query As String = "
            INSERT INTO Productos (Nombre, Precio, Categoria) 
            VALUES (@Nombre, @Precio, @Categoria);
            "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", producto.Nombre)
                command.Parameters.AddWithValue("@Precio", producto.Precio)
                command.Parameters.AddWithValue("@Categoria", producto.Categoria)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()  ' Ejecutar la consulta
                    'MessageBox.Show("Producto guardado exitosamente!")
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub Editar(producto As Producto)

        Dim query As String = "
            UPDATE Productos SET 
            Nombre = @Nombre,
            Precio = @Precio,
            Categoria = @Categoria 
            WHERE ID = @ID
            "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", producto.Nombre)
                command.Parameters.AddWithValue("@Precio", producto.Precio)
                command.Parameters.AddWithValue("@Categoria", producto.Categoria)
                command.Parameters.AddWithValue("@ID", producto.ID)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()  ' Ejecutar la consulta
                    'MessageBox.Show("Producto guardado exitosamente!")
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub Eliminar(producto As Producto)

        Dim query As String = "DELETE FROM Productos WHERE ID = @ID;"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", producto.ID)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()  ' Ejecutar la consulta
                    'MessageBox.Show("Producto eliminado exitosamente!")
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class