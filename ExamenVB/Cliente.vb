Imports System.Configuration
Imports System.Data.SqlClient

Public Class Cliente
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Telefono As String
    Public Property Correo As String

    Public Sub New(nombre As String, telefono As String, correo As String)
        Me.Nombre = nombre
        Me.Telefono = telefono
        Me.Correo = correo
    End Sub
End Class

Public Class ClienteService
    Private connectionString As String = ConfigurationManager.ConnectionStrings("ExamenConnection").ConnectionString

    Public Sub Guardar(cliente As Cliente)

        Dim query As String = "
            INSERT INTO Clientes (Cliente, Telefono, Correo) 
            VALUES (@Nombre, @Telefono, @Correo);
            "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre)
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono)
                command.Parameters.AddWithValue("@Correo", cliente.Correo)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    'MessageBox.Show("Cliente guardado exitosamente!")
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub Editar(cliente As Cliente)

        Dim query As String = "
            UPDATE Clientes SET 
            Cliente = @Nombre,
            Telefono = @Telefono,
            Correo = @Correo 
            WHERE ID = @ID
            "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre)
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono)
                command.Parameters.AddWithValue("@Correo", cliente.Correo)
                command.Parameters.AddWithValue("@ID", cliente.ID)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    'MessageBox.Show("Cliente guardado exitosamente!")
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub Eliminar(cliente As Cliente)

        Dim query As String = "DELETE FROM clientes WHERE ID = @ID;"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID", cliente.ID)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    'MessageBox.Show("Cliente eliminado exitosamente!")
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Function GetClientes(currentPage As Integer, sizePage As Integer, filtroBuscador As String)
        Dim inicio As Integer = (currentPage - 1) * sizePage + 1
        Dim fin As Integer = currentPage * sizePage

        Dim query As String = "
        WITH CTE AS (
            SELECT *, 
                   ROW_NUMBER() OVER (ORDER BY ID) AS RowNum
            FROM clientes
            WHERE 1 = 1
        "

        If Not String.IsNullOrEmpty(filtroBuscador) Then
            query &= " AND Cliente LIKE @Nombre"
        End If

        query &= "
        )
        SELECT ID, Cliente, Telefono, Correo
        FROM CTE
        WHERE RowNum BETWEEN @Inicio AND @Fin
        "

        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Inicio", inicio)
                command.Parameters.AddWithValue("@Fin", fin)
                If Not String.IsNullOrEmpty(filtroBuscador) Then
                    command.Parameters.AddWithValue("@Nombre", "%" & filtroBuscador & "%")
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
End Class