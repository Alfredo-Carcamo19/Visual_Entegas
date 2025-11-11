' --- Imports (Arriba de todo) ---
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmVisorProductos
    Dim conn As New MySqlConnection

    Private Sub frmVisorProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection

        ' 1. Conectar y cargar datos
        conn = conectar()

        ' 2. ¡LA CONSULTA SQL CON TODOS LOS ALIAS 'AS'!
        Dim sql As String = "SELECT " &
            "id_producto AS idproducto, " &
            "nombre, " &
            "descripcion, " &
            "precio_compra AS preciocompra, " &
            "porcentaje_ganancia AS porcentajeganancia, " &
            "precio_venta AS precioventa, " &
            "stock, " &
            "stock_minimo AS stockminimo, " &
            "id_proveedor AS idproveedor " &
            "FROM productos ORDER BY nombre"

        Dim dtProductosReales As DataTable = cargar_grid(sql, conn)

        ' 3. Crear el origen de datos (debe coincidir con el .rdlc)
        Dim rds As New ReportDataSource("dsProductos", dtProductosReales)

        ' 4. Limpiar y añadir datos al visor
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(rds)

        ' 5. Mostrar
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class