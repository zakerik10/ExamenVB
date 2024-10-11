Public Class Main
    Private Sub ButtonClientes_Click(sender As Object, e As EventArgs) Handles ButtonClientes.Click
        Dim FormClientes As New FormClientes()
        FormClientes.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonProductos_Click(sender As Object, e As EventArgs) Handles ButtonProductos.Click
        Dim FormClientes As New FormProductos()
        FormClientes.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub
End Class