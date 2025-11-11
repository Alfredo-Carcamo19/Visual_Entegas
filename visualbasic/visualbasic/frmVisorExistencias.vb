' --- Imports (Arriba de todo) ---
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmVisorExistencias
    Dim conn As New MySqlConnection

    Private Sub frmVisorExistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New MySqlConnection
        conn = conectar()

        ' --- ¡ESTA ES LA CONSULTA! ---
        ' Es la misma consulta de productos, pero SIN el filtro WHERE.
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

        Dim dtProductosTodos As DataTable = cargar_grid(sql, conn)

        ' 2. Le pasamos los datos al DataSet "dsProductos"
        Dim rds As New ReportDataSource("dsProductos", dtProductosTodos)

        ' 3. Limpiar y añadir datos al visor
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(rds)

        ' 4. Mostrar
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class