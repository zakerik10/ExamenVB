Public Class FormReporteProductos

    Dim productoService As New ProductoService

    Private currentPage As Integer = 1
    Private sizePage As Integer = 20
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxMeses.Items.Add("Enero")
        ComboBoxMeses.Items.Add("Febrero")
        ComboBoxMeses.Items.Add("Marzo")
        ComboBoxMeses.Items.Add("Abril")
        ComboBoxMeses.Items.Add("Mayo")
        ComboBoxMeses.Items.Add("Junio")
        ComboBoxMeses.Items.Add("Julio")
        ComboBoxMeses.Items.Add("Agosto")
        ComboBoxMeses.Items.Add("Septiembre")
        ComboBoxMeses.Items.Add("Octubre")
        ComboBoxMeses.Items.Add("Noviembre")
        ComboBoxMeses.Items.Add("Diciembre")

        Dim mesActual As Integer = DateTime.Now.Month
        Dim añoActual As Integer = DateTime.Now.Year
        ComboBoxMeses.SelectedIndex = mesActual - 1
        TextBoxAño.Text = añoActual
        LoadReporte()
    End Sub

    Private Sub LoadReporte()
        GridReporteProductos.Rows.Clear()

        Dim buscador As String = TextBoxBuscador.Text
        Dim mes As Integer = ComboBoxMeses.SelectedIndex + 1
        Dim año As Integer = CInt(TextBoxAño.Text)

        Dim dataTable As DataTable = productoService.GetReporteProductos(currentPage, sizePage, buscador, mes, año)

        For Each row As DataRow In dataTable.Rows
            GridReporteProductos.Rows.Add(row("NombreProducto"), row("TotalVendido").ToString())
        Next
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        LoadReporte()
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TextBoxBuscador.Text = Nothing
        LoadReporte()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        currentPage += 1
        LoadReporte()
    End Sub

    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadReporte()
        End If
    End Sub

    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonFiltrar.Click
        LoadReporte()
    End Sub
End Class