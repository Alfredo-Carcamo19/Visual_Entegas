' --- Imports (Arriba de todo) ---
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmVisorExistenciasMinimas
    Dim conn As New MySqlConnection

    Private Sub frmVisorExistenciasMinimas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = conectar()

        ' --- ¡AQUÍ ESTÁ LA MAGIA! ---
        ' 1. Esta consulta SQL solo trae los productos
        '    donde el stock es MENOR O IGUAL al stock mínimo.
        '    También incluimos todos los ALIAS 'AS' para que coincidan.
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
            "FROM productos " &
            "WHERE stock <= stock_minimo " &  ' <-- ¡EL FILTRO!
            "ORDER BY stock ASC" ' (Opcional: muestra los más bajos primero)

        Dim dtProductosFiltrados As DataTable = cargar_grid(sql, conn)

        ' 2. Le pasamos los datos al DataSet "dsProductos"
        Dim rds As New ReportDataSource("dsProductos", dtProductosFiltrados)

        ' 3. Limpiar y añadir datos al visor
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(rds)

        ' 4. Mostrar
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class