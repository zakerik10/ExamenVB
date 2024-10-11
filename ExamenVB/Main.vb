Public Class Main
    Private Sub ButtonClientes_Click(sender As Object, e As EventArgs) Handles ButtonClientes.Click
        Dim FormClientes As New FormClientes()
        FormClientes.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonProductos_Click(sender As Object, e As EventArgs) Handles ButtonProductos.Click

    End Sub
End Class