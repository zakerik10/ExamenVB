Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormVentas

    Private currentPage As Integer = 1
    Private sizePage As Integer = 20

    Dim VService As New VentaService

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVentas()
    End Sub
    Private Sub LoadVentas()

        GridVentas.Rows.Clear()

        Dim dataTable As DataTable = VService.GetVentas(currentPage, sizePage)

        For Each row As DataRow In dataTable.Rows
            GridVentas.Rows.Add(CInt(row("ID")), row("Cliente").ToString(), row("Fecha").ToString(), row("Total").ToString())
        Next
    End Sub
End Class