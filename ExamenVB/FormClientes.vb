Imports System.Configuration
Imports System.Drawing.Printing
Imports System.Runtime.Remoting

Public Class FormClientes

    Dim clienteService As New ClienteService()

    Private currentPage As Integer = 1
    Private sizePage As Integer = 20

    Public Sub New(esVenta As Boolean)
        InitializeComponent()
        If esVenta Then
            LabelTitulo.Text = "Vender"
            BotonCrearCliente.Hide()
            SeleccionarEliminar.Visible = False
            Accion.Visible = False
            SeleccionVender.Visible = True
        Else
            LabelTitulo.Text = "Clientes"
            BotonCrearCliente.Show()
            SeleccionarEliminar.Visible = True
            Accion.Visible = True
            SeleccionVender.Visible = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClientes()
    End Sub

    Private Sub LoadClientes()
        GridClientes.Rows.Clear()

        Dim dataTable As DataTable = clienteService.GetClientes(currentPage, sizePage, TextBoxBuscador.Text)

        For Each row As DataRow In dataTable.Rows
            GridClientes.Rows.Add(CInt(row("ID")), row("Cliente").ToString(), row("Telefono").ToString(), row("Correo").ToString())
        Next
    End Sub

    Private Sub GridClientes_Accion(sender As Object, e As DataGridViewCellEventArgs) Handles GridClientes.CellClick
        If e.ColumnIndex = GridClientes.Columns("Accion").Index AndAlso e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = GridClientes.Rows(e.RowIndex)

            If fila.Cells("ID").Value IsNot Nothing AndAlso Not IsDBNull(fila.Cells("ID").Value) Then
                Dim id As Integer = Convert.ToInt32(fila.Cells("ID").Value)
                Dim nombre As String = If(fila.Cells("Cliente").Value IsNot Nothing, fila.Cells("Cliente").Value.ToString(), String.Empty)
                Dim telefono As String = If(fila.Cells("Telefono").Value IsNot Nothing, fila.Cells("Telefono").Value.ToString(), String.Empty)
                Dim correo As String = If(fila.Cells("Correo").Value IsNot Nothing, fila.Cells("Correo").Value.ToString(), String.Empty)

                Dim cliente As New Cliente(nombre, telefono, correo) With {
                    .ID = id
                }

                Dim formEditar As New FormGestionCliente(cliente)
                If formEditar.ShowDialog() = DialogResult.OK Then
                    LoadClientes()
                End If
            Else
                MessageBox.Show("El ID del cliente no está disponible.")
            End If
        End If
    End Sub

    Private Sub GridClientes_Vender(sender As Object, e As DataGridViewCellEventArgs) Handles GridClientes.CellClick
        If e.ColumnIndex = GridClientes.Columns("SeleccionVender").Index AndAlso e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = GridClientes.Rows(e.RowIndex)

            If fila.Cells("ID").Value IsNot Nothing AndAlso Not IsDBNull(fila.Cells("ID").Value) Then
                Dim id As Integer = Convert.ToInt32(fila.Cells("ID").Value)
                Dim nombre As String = If(fila.Cells("Cliente").Value IsNot Nothing, fila.Cells("Cliente").Value.ToString(), String.Empty)
                Dim telefono As String = If(fila.Cells("Telefono").Value IsNot Nothing, fila.Cells("Telefono").Value.ToString(), String.Empty)
                Dim correo As String = If(fila.Cells("Correo").Value IsNot Nothing, fila.Cells("Correo").Value.ToString(), String.Empty)

                Dim cliente As New Cliente(nombre, telefono, correo) With {
                    .ID = id
                }

                Dim FormProductos As New FormProductos(cliente)
                FormProductos.Show()
                Me.Close()
            Else
                MessageBox.Show("El ID del cliente no está disponible.")
            End If
        End If
    End Sub

    Private Sub GridClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridClientes.CellContentClick
        Dim nombreColumna As String = "SeleccionarEliminar"
        If e.ColumnIndex = GridClientes.Columns(nombreColumna).Index AndAlso e.RowIndex >= 0 Then
            Dim checkBoxCell As DataGridViewCheckBoxCell = CType(GridClientes.Rows(e.RowIndex).Cells(nombreColumna), DataGridViewCheckBoxCell)
            checkBoxCell.Value = Not CBool(checkBoxCell.Value)

            Dim cantidadSeleccionadas As Integer = 0
            For Each row As DataGridViewRow In GridClientes.Rows
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
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar los clientes seleccionados?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then

            For Each fila As DataGridViewRow In GridClientes.Rows
                Dim checkBoxCell As DataGridViewCheckBoxCell = CType(fila.Cells("SeleccionarEliminar"), DataGridViewCheckBoxCell)

                If checkBoxCell IsNot Nothing AndAlso CBool(checkBoxCell.Value) Then
                    Dim id As Integer = Convert.ToInt32(fila.Cells("ID").Value)
                    Dim nombre As String = If(fila.Cells("Cliente").Value IsNot Nothing, fila.Cells("Cliente").Value.ToString(), String.Empty)
                    Dim telefono As String = If(fila.Cells("Telefono").Value IsNot Nothing, fila.Cells("Telefono").Value.ToString(), String.Empty)
                    Dim correo As String = If(fila.Cells("Correo").Value IsNot Nothing, fila.Cells("Correo").Value.ToString(), String.Empty)

                    Dim cliente As New Cliente(nombre, telefono, correo) With {
                        .ID = id
                    }

                    clienteService.Eliminar(cliente)
                End If
            Next
            ButtonEliminarSelec.Hide()
            LoadClientes()
        End If
    End Sub

    Private Function ObtenerFilaPorID(id As Integer) As DataGridViewRow
        For Each row As DataGridViewRow In GridClientes.Rows
            If row.Cells("ID").Value IsNot Nothing AndAlso CInt(row.Cells("ID").Value) = id Then
                Return row
            End If
        Next
        Return Nothing
    End Function

    Private Sub LoadClients(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        LoadClientes()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        currentPage += 1
        LoadClientes()
    End Sub

    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadClientes()
        End If
    End Sub

    Private Sub GestionarCliente(sender As Object, e As EventArgs) Handles BotonCrearCliente.Click
        Dim formGestion As New FormGestionCliente(Nothing)
        formGestion.ShowDialog()
        LoadClientes()
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TextBoxBuscador.Text = Nothing
        LoadClientes()
    End Sub

End Class
