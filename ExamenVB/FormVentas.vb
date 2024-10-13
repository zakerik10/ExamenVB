Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormVentas

    Private currentPage As Integer = 1
    Private sizePage As Integer = 20

    Dim VService As New VentaService

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonEliminarSelec.Hide()
        LoadVentas()
    End Sub
    Private Sub LoadVentas()

        Dim buscador As String = TextBoxBuscador.Text

        GridVentas.Rows.Clear()

        Dim dataTable As DataTable = VService.GetVentas(currentPage, sizePage, buscador)

        For Each row As DataRow In dataTable.Rows
            GridVentas.Rows.Add(CInt(row("VentaID")), row("Cliente").ToString(), row("Fecha").ToString(), row("Total").ToString(), row("ClienteID").ToString())
        Next
    End Sub

    Private Sub GridClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridVentas.CellContentClick
        Dim nombreColumna As String = "SeleccionarEliminar"
        If e.ColumnIndex = GridVentas.Columns(nombreColumna).Index AndAlso e.RowIndex >= 0 Then
            Dim checkBoxCell As DataGridViewCheckBoxCell = CType(GridVentas.Rows(e.RowIndex).Cells(nombreColumna), DataGridViewCheckBoxCell)
            checkBoxCell.Value = Not CBool(checkBoxCell.Value)

            Dim cantidadSeleccionadas As Integer = 0
            For Each row As DataGridViewRow In GridVentas.Rows
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

    Private Sub ButtonEliminarSelec_Click(sender As Object, e As EventArgs) Handles ButtonEliminarSelec.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar las ventas seleccionados?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then

            For Each fila As DataGridViewRow In GridVentas.Rows
                Dim checkBoxCell As DataGridViewCheckBoxCell = CType(fila.Cells("SeleccionarEliminar"), DataGridViewCheckBoxCell)

                If checkBoxCell IsNot Nothing AndAlso CBool(checkBoxCell.Value) Then
                    Dim id As Integer = Convert.ToInt32(fila.Cells("IDVenta").Value)

                    VService.Eliminar(id)
                End If
            Next
            ButtonEliminarSelec.Hide()
            LoadVentas()
        End If
    End Sub

    Private Sub GridClientes_CellClick(sender As Object, grid As DataGridViewCellEventArgs) Handles GridVentas.CellClick
        If grid.ColumnIndex = GridVentas.Columns("VerProductos").Index AndAlso grid.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = GridVentas.Rows(grid.RowIndex)

            If fila.Cells("IDVenta").Value IsNot Nothing AndAlso Not IsDBNull(fila.Cells("IDVenta").Value) Then
                Dim idCliente As Integer = CInt(fila.Cells("IDCliente").Value)
                Dim nombre As String = fila.Cells("Cliente").Value
                Dim idVenta As Integer = CInt(fila.Cells("IDVenta").Value)

                Dim cliente As New Cliente() With {
                    .Nombre = nombre,
                    .ID = idCliente
                }

                Dim formEditar As New FormProductos(cliente, idVenta)
                If formEditar.ShowDialog() = DialogResult.OK Then
                End If
            Else
                MessageBox.Show("El ID del producto no está disponible.")
            End If
        End If
    End Sub

    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        LoadVentas()
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TextBoxBuscador.Text = Nothing
        LoadVentas()
    End Sub
End Class