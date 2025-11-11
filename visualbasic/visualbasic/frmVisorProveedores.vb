' --- Imports (Arriba de todo) ---
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmVisorProveedores

    Private Sub frmVisorProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection

        ' 1. Conectar y cargar datos
        conn = conectar()
        Dim sql As String = "SELECT id_proveedor AS idproveedor, nombre, direccion, telefono, email FROM proveedores ORDER BY nombre"
        Dim dtProveedoresReales As DataTable = cargar_grid(sql, conn)

        ' 2. Crear el origen de datos
        Dim rds As New ReportDataSource("dsProveedores", dtProveedoresReales)

        ' 3. Limpiar y añadir datos al visor
        ' (Si renombraste el ReportViewer, usa ese nombre aquí)
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(rds)

        ' 4. Mostrar
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class