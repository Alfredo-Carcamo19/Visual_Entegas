Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmInicio
    Dim conn As New MySqlConnection

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = conectar()
        CargarEstadisticas()
    End Sub

    Private Sub CargarEstadisticas()
        Try
            ' --- 1. LA CONSULTA SQL "MÁGICA" ---
            ' Esta consulta trae todos los conteos en una sola fila.
            Dim sql As String = "SELECT " &
                "(SELECT COUNT(*) FROM Clientes) AS TotalClientes, " &
                "(SELECT COUNT(*) FROM Proveedores) AS TotalProveedores, " &
                "(SELECT COUNT(*) FROM Productos) AS TotalProductos, " &
                "(SELECT COUNT(*) FROM Compras) AS TotalCompras, " &
                "(SELECT COUNT(*) FROM Ventas) AS TotalVentas, " &
                "(SELECT COUNT(*) FROM Productos WHERE stock <= stock_minimo) AS TotalReposicion, " &
                "(SELECT COUNT(*) FROM Usuarios) AS TotalUsuarios, " &
                "(SELECT IFNULL(SUM(total), 0) FROM Ventas) AS SumaTotalVentas"

            Dim cmd As New MySqlCommand(sql, conn)

            ' --- 2. USAMOS UN LECTOR (DataReader) ---
            ' Como solo esperamos UNA fila, un DataReader es más eficiente.
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' --- 3. ASIGNAMOS LOS VALORES A LOS LABELS ---
                lblTotalClientes.Text = reader("TotalClientes").ToString()
                lblTotalProveedores.Text = reader("TotalProveedores").ToString()
                lblTotalProductos.Text = reader("TotalProductos").ToString()
                lblTotalCompras.Text = reader("TotalCompras").ToString()
                lblTotalVentas.Text = reader("TotalVentas").ToString()
                lblTotalUsuarios.Text = reader("TotalUsuarios").ToString()

                ' Damos formato de moneda al total de ventas
                lblSumaTotalVentas.Text = Convert.ToDecimal(reader("SumaTotalVentas")).ToString("C2")
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar las estadísticas: " & ex.Message, "Error de Carga")
        End Try
    End Sub

End Class