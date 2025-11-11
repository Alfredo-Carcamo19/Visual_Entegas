' --- Imports (Arriba de todo) ---
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmReporteCompras
    Dim conn As New MySqlConnection

    Private Sub frmReporteCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = conectar()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        ' --- ¡CONSULTA SQL MODIFICADA! ---
        Dim sql As String = "SELECT " &
            "c.id_compra AS idcompra, " &
            "c.fecha_compra AS fechacompra, " &
            "IFNULL(p.nombre, 'Proveedor Eliminado') AS nombreproveedor, " &
            "c.total " &
            "FROM compras c " &
            "LEFT JOIN proveedores p ON c.id_proveedor = p.id_proveedor " &
            "WHERE c.fecha_compra BETWEEN @fechaInicio AND @fechaFin " &
            "ORDER BY c.fecha_compra"

        Dim cmd As New MySqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@fechaInicio", dtpInicio.Value.Date)
        cmd.Parameters.AddWithValue("@fechaFin", dtpFin.Value.Date)

        Dim dtComprasReales As New DataTable()
        Try
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dtComprasReales)

            ' (El nombre "dsCompras" debe coincidir con el .rdlc)
            Dim rds As New ReportDataSource("dsCompras", dtComprasReales)

            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(rds)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte: " & ex.Message)
        End Try
    End Sub

End Class