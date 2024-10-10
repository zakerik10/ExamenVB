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
                    command.ExecuteNonQuery()  ' Ejecutar la consulta
                    MessageBox.Show("Cliente guardado exitosamente!")
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
                    command.ExecuteNonQuery()  ' Ejecutar la consulta
                    MessageBox.Show("Cliente guardado exitosamente!")
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
                    command.ExecuteNonQuery()  ' Ejecutar la consulta
                    MessageBox.Show("Cliente eliminado exitosamente!")
                Catch ex As Exception
                    MessageBox.Show("Error al cargar los datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class