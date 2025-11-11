' --- Imports (Arriba de todo) ---
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmReporteGanancias
    Dim conn As New MySqlConnection

    Private Sub frmReporteGanancias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = conectar()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        ' --- ¡CONSULTA SQL ESPECIAL! ---
        ' Esta consulta devuelve UNA SOLA FILA con el total de ventas y compras
        Dim sql As String =
            "SELECT " &
            "IFNULL((SELECT SUM(total) FROM ventas WHERE fecha_venta BETWEEN @fechaInicio AND @fechaFin), 0) AS TotalVentas, " &
            "IFNULL((SELECT SUM(total) FROM compras WHERE fecha_compra BETWEEN @fechaInicio AND @fechaFin), 0) AS TotalCompras"
        ' (Usamos IFNULL por si no hay ventas o compras, para que devuelva 0 en lugar de NULL)

        Dim cmd As New MySqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@fechaInicio", dtpInicio.Value.Date)
        cmd.Parameters.AddWithValue("@fechaFin", dtpFin.Value.Date)

        Dim dtGanancias As New DataTable()
        Try
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dtGanancias)

            ' (El nombre "dsGanancias" debe coincidir con el .rdlc)
            Dim rds As New ReportDataSource("dsGanancias", dtGanancias)

            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(rds)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte: " & ex.Message)
        End Try
    End Sub

End Class