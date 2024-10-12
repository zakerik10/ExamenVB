Public Class FormCarrito
    Dim venta As Venta
    Dim listaVentasItems As List(Of VentaItems)
    Dim precioTotal As Integer

    Dim VIService As New VentaItemsService
    Dim VService As New VentaService

    Public Sub New(venta As Venta, listaVentasItems As List(Of VentaItems))
        InitializeComponent()
        Me.venta = venta
        Me.listaVentasItems = listaVentasItems

        LabelTituloCarrito.Text = "Carrito de " & VService.GetClientName(venta)
    End Sub

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCarrito()
    End Sub

    Private Sub LoadCarrito()
        GridCarrito.Rows.Clear()
        precioTotal = 0
        For Each item As VentaItems In listaVentasItems
            precioTotal += item.Cantidad * item.PrecioUnitario
            Dim nombreProducto As String = VIService.GetProductName(item)
            GridCarrito.Rows.Add(nombreProducto, item.PrecioUnitario, item.Cantidad)
        Next
        TextBoxTotal.Text = precioTotal
    End Sub

    Private Sub ButtonConfirmarVenta_Click(sender As Object, e As EventArgs) Handles ButtonConfirmarVenta.Click
        If listaVentasItems.Count() > 0 Then
            venta.Fecha = DateTime.Now()
            venta.Total = precioTotal

            VService.Guardar(venta)

            For Each item As VentaItems In listaVentasItems
                item.IDVenta = venta.ID

                VIService.Guardar(item)
            Next

            MessageBox.Show("Venta Realizada")
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("El carrito esta vacío")
        End If

    End Sub

    Private Sub GridClientes_CellClickCarrito(sender As Object, e As DataGridViewCellEventArgs) Handles GridCarrito.CellClick
        If e.ColumnIndex = GridCarrito.Columns("Quitar").Index AndAlso e.RowIndex >= 0 Then
            listaVentasItems.RemoveAt(e.RowIndex)
            LoadCarrito()
        End If
    End Sub
End Class