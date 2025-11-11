' --- Imports (Arriba de todo) ---
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmReporteVentas
    Dim conn As New MySqlConnection

    ' El Load se usa solo para conectar
    Private Sub frmReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = conectar()
        ' Limpiamos el reporte al inicio
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    ' --- ¡LA LÓGICA ESTÁ AQUÍ! ---
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        ' 1. Definimos la consulta SQL con JOIN y WHERE...BETWEEN
        '    Usamos LEFT JOIN por si un cliente fue borrado (id_cliente = NULL)
        '    Usamos IFNULL para mostrar "Cliente Eliminado" si es NULL
        Dim sql As String = "SELECT " &
            "v.id_venta AS idventa, " &
            "v.fecha_venta AS fechaventa, " &
            "IFNULL(c.nombre, 'Cliente Eliminado') AS nombrecliente, " &
            "v.total " &
            "FROM ventas v " &
            "LEFT JOIN clientes c ON v.id_cliente = c.id_cliente " &
            "WHERE v.fecha_venta BETWEEN @fechaInicio AND @fechaFin " &
            "ORDER BY v.fecha_venta"

        ' 2. Creamos el comando y añadimos los parámetros
        Dim cmd As New MySqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@fechaInicio", dtpInicio.Value.Date)
        cmd.Parameters.AddWithValue("@fechaFin", dtpFin.Value.Date)

        ' 3. Llenamos el DataTable manualmente
        Dim dtVentasReales As New DataTable()
        Try
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dtVentasReales)

            ' 4. Creamos el origen de datos (debe coincidir con el .rdlc)
            Dim rds As New ReportDataSource("dsVentas", dtVentasReales)

            ' 5. Limpiar y añadir datos al visor
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(rds)

            ' 6. Mostrar
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte: " & ex.Message)
        End Try
    End Sub

End Class