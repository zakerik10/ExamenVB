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
                    command.ExecuteNonQuery()
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
                    command.ExecuteNonQuery()
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
                    command.ExecuteNonQuery()
                    'MessageBox.Show("Producto eliminado exitosamente!")
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Function GetProductos(currentPage As Integer, sizePage As Integer, filtroBuscador As String, categoria As String, filtroPrecioMin As Nullable(Of Integer), filtroPrecioMax As Nullable(Of Integer))
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

        If Not String.IsNullOrEmpty(filtroBuscador) Then
            query &= " AND Nombre LIKE @NombreFiltro"
        End If

        If categoria IsNot Nothing Then
            query &= " AND Categoria = @Categoria"
        End If

        If filtroPrecioMin IsNot Nothing Or filtroPrecioMax IsNot Nothing Then
            If filtroPrecioMin IsNot Nothing Then
                precioMin = filtroPrecioMin
            End If
            If filtroPrecioMax IsNot Nothing Then
                precioMax = filtroPrecioMax
            End If
            query &= " AND precio BETWEEN @PrecioMin AND @PrecioMax"
        End If

        query &= "
        )
        SELECT ID, Nombre, Precio, Categoria
        FROM CTE
        WHERE RowNum BETWEEN @Inicio AND @Fin;
        "

        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                If Not String.IsNullOrEmpty(filtroBuscador) Then
                    command.Parameters.AddWithValue("@Nombre", "%" & filtroBuscador & "%")
                End If

                If categoria IsNot Nothing Then
                    command.Parameters.AddWithValue("@Categoria", categoria)
                End If

                If filtroPrecioMin IsNot Nothing Or filtroPrecioMax IsNot Nothing Then
                    command.Parameters.AddWithValue("@PrecioMin", precioMin)
                    command.Parameters.AddWithValue("@PrecioMax", precioMax)
                End If
                command.Parameters.AddWithValue("@Inicio", inicio)
                command.Parameters.AddWithValue("@Fin", fin)
                If Not String.IsNullOrEmpty(filtroBuscador) Then
                    command.Parameters.AddWithValue("@NombreFiltro", "%" & filtroBuscador & "%")
                End If
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

    Public Function GetCategorias()

        Dim query As String = "SELECT DISTINCT Categoria FROM productos"

        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
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