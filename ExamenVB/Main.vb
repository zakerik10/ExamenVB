Public Class Main
    Private Sub ButtonClientes_Click(sender As Object, e As EventArgs) Handles ButtonClientes.Click
        Dim FormClientes As New FormClientes(False)
        FormClientes.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonProductos_Click(sender As Object, e As EventArgs) Handles ButtonProductos.Click
        Dim FormProductos As New FormProductos(Nothing)
        FormProductos.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub ButtonVender_Click(sender As Object, e As EventArgs) Handles ButtonVender.Click
        Dim FormClientes As New FormClientes(True)
        FormClientes.Show()
        Me.Hide()
    End Sub
End Class