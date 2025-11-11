Imports MySql.Data.MySqlClient
Imports System.Data ' Asegúrate de tener este import

Public Class Ventas
    Dim conn As New MySqlConnection
    Dim dtProductos As New DataTable()

    ' --- 1. Evento Load: Prepara todo ---
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = conectar()
        CargarClientes()
        CargarProductos()
        ConfigurarCarrito()

        ' --- MODIFICACIÓN: Fecha automática y bloqueada ---
        dtp_fecha.Value = Date.Now
        dtp_fecha.Enabled = False
        ' --- FIN DE LA MODIFICACIÓN ---
    End Sub

    ' --- 2. Funciones de Carga ---
    Private Sub CargarClientes()
        Dim dtClientes As DataTable = cargar_grid("SELECT id_cliente, nombre FROM clientes ORDER BY nombre", conn)
        ' Asegúrate de que tu ComboBox se llame 'cmb_cliente'
        cmb_cliente.DataSource = dtClientes
        cmb_cliente.DisplayMember = "nombre"
        cmb_cliente.ValueMember = "id_cliente"
    End Sub

    Private Sub CargarProductos()
        dtProductos = cargar_grid("SELECT id_producto, nombre, precio_venta, stock FROM productos", conn)
        cmb_producto.DataSource = dtProductos
        cmb_producto.DisplayMember = "nombre"
        cmb_producto.ValueMember = "id_producto"
    End Sub

    Private Sub ConfigurarCarrito()
        dgv_carrito.Columns.Clear()
        dgv_carrito.Columns.Add("id_producto", "ID")
        dgv_carrito.Columns.Add("producto", "Producto")
        dgv_carrito.Columns.Add("cantidad", "Cant.")
        dgv_carrito.Columns.Add("precio", "Precio")
        dgv_carrito.Columns.Add("subtotal", "Subtotal")

        Dim btnColumnaQuitar As New DataGridViewButtonColumn()
        btnColumnaQuitar.HeaderText = "Quitar"
        btnColumnaQuitar.Text = "Quitar"
        btnColumnaQuitar.Name = "columna_quitar"
        btnColumnaQuitar.UseColumnTextForButtonValue = True
        dgv_carrito.Columns.Add(btnColumnaQuitar)

        dgv_carrito.Columns("precio").DefaultCellStyle.Format = "F2"
        dgv_carrito.Columns("subtotal").DefaultCellStyle.Format = "F2"
        dgv_carrito.Columns("id_producto").Visible = False
    End Sub

    ' --- EVENTO NUEVO: Para manejar el clic en el botón "Quitar" ---
    Private Sub dgv_carrito_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_carrito.CellContentClick
        If e.ColumnIndex = dgv_carrito.Columns("columna_quitar").Index AndAlso e.RowIndex >= 0 Then
            If Not dgv_carrito.Rows(e.RowIndex).IsNewRow Then
                If MessageBox.Show("¿Desea quitar este producto del carrito?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    dgv_carrito.Rows.RemoveAt(e.RowIndex)
                    ActualizarTotal()
                End If
            End If
        End If
    End Sub

    ' --- 3. Lógica del Botón "Agregar" (Sin cambios) ---
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        ' (Validaciones...)
        If cmb_producto.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un producto.")
            Exit Sub
        End If
        Dim cantidad As Integer
        If Not Integer.TryParse(txt_cantidad.Text, cantidad) OrElse cantidad <= 0 Then
            MessageBox.Show("Ingrese una cantidad válida.")
            txt_cantidad.Focus()
            Exit Sub
        End If

        Dim filaProducto As DataRow = CType(cmb_producto.SelectedItem, DataRowView).Row
        Dim idProd As Integer = filaProducto("id_producto")
        Dim nombreProd As String = filaProducto("nombre")
        Dim precioVenta As Decimal = filaProducto("precio_venta")
        Dim stockActual As Integer = filaProducto("stock")

        If cantidad > stockActual Then
            MessageBox.Show("No hay stock suficiente. Stock actual: " & stockActual)
            Exit Sub
        End If

        Dim subtotal As Decimal = cantidad * precioVenta
        dgv_carrito.Rows.Add(idProd, nombreProd, cantidad, precioVenta, subtotal)

        ActualizarTotal()
        cmb_producto.SelectedIndex = -1
        txt_cantidad.Text = ""
    End Sub

    ' --- 4. Función para recalcular el Total (Sin cambios) ---
    Private Sub ActualizarTotal()
        Dim totalVenta As Decimal = 0
        For Each fila As DataGridViewRow In dgv_carrito.Rows
            If fila.Cells("subtotal").Value IsNot Nothing AndAlso Not fila.IsNewRow Then
                totalVenta += Convert.ToDecimal(fila.Cells("subtotal").Value)
            End If
        Next
        lbl_total.Text = "Total: " & totalVenta.ToString("C2")
    End Sub

    ' --- 5. Lógica de "Realizar Venta" (Sin cambios) ---
    Private Sub bt_guardarventa_Click(sender As Object, e As EventArgs) Handles bt_guardarventa.Click
        ' (Validaciones...)
        If dgv_carrito.Rows.Count = 0 Or (dgv_carrito.Rows.Count = 1 AndAlso dgv_carrito.Rows(0).IsNewRow) Then
            MessageBox.Show("El carrito está vacío.")
            Exit Sub
        End If
        If cmb_cliente.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un cliente.")
            Exit Sub
        End If
        If MessageBox.Show("¿Está seguro de que desea finalizar esta venta?", "Confirmar Venta", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        ' (Transacción...)
        Dim trans As MySqlTransaction = Nothing
        Try
            trans = conn.BeginTransaction()
            Dim totalVenta As Decimal = 0
            For Each fila As DataGridViewRow In dgv_carrito.Rows
                If fila.Cells("subtotal").Value IsNot Nothing AndAlso Not fila.IsNewRow Then
                    totalVenta += Convert.ToDecimal(fila.Cells("subtotal").Value)
                End If
            Next

            Dim sqlVenta As String = "INSERT INTO Ventas (fecha_venta, id_cliente, total) VALUES (@fecha, @id_cli, @total)"
            Dim cmdVenta As New MySqlCommand(sqlVenta, conn, trans)
            cmdVenta.Parameters.AddWithValue("@fecha", dtp_fecha.Value) ' <-- Usará la fecha bloqueada
            cmdVenta.Parameters.AddWithValue("@id_cli", cmb_cliente.SelectedValue)
            cmdVenta.Parameters.AddWithValue("@total", totalVenta)
            cmdVenta.ExecuteNonQuery()

            Dim idVenta As Long = cmdVenta.LastInsertedId

            For Each fila As DataGridViewRow In dgv_carrito.Rows
                If fila.IsNewRow Then Continue For ' Omitir la fila "nueva" vacía

                ' 3a. Insertar en Detalle_Ventas
                Dim sqlDetalle As String = "INSERT INTO Detalle_Ventas (id_venta, id_producto, cantidad, precio_unitario) VALUES (@id_v, @id_p, @cant, @precio)"
                Dim cmdDetalle As New MySqlCommand(sqlDetalle, conn, trans)
                cmdDetalle.Parameters.AddWithValue("@id_v", idVenta)
                cmdDetalle.Parameters.AddWithValue("@id_p", fila.Cells("id_producto").Value)
                cmdDetalle.Parameters.AddWithValue("@cant", fila.Cells("cantidad").Value)
                cmdDetalle.Parameters.AddWithValue("@precio", fila.Cells("precio").Value)
                cmdDetalle.ExecuteNonQuery()

                ' 3b. Actualizar (RESTAR) Stock
                Dim sqlStock As String = "UPDATE Productos SET stock = stock - @cant WHERE id_producto = @id_p"
                Dim cmdStock As New MySqlCommand(sqlStock, conn, trans)
                cmdStock.Parameters.AddWithValue("@cant", fila.Cells("cantidad").Value)
                cmdStock.Parameters.AddWithValue("@id_p", fila.Cells("id_producto").Value)
                cmdStock.ExecuteNonQuery()
            Next

            trans.Commit()
            MessageBox.Show("¡Venta realizada con éxito!")
            LimpiarFormularioVenta()

        Catch ex As Exception
            trans.Rollback()
            MessageBox.Show("Error al guardar la venta: " & ex.Message)
        End Try
    End Sub

    Private Sub LimpiarFormularioVenta()
        dgv_carrito.Rows.Clear()
        ActualizarTotal()
        cmb_cliente.SelectedIndex = -1
        cmb_producto.SelectedIndex = -1
        txt_cantidad.Text = ""
        dtp_fecha.Value = Date.Now ' <-- Reinicia la fecha (pero sigue bloqueada)
        CargarProductos() ' <-- Recarga los productos para actualizar el stock
    End Sub

    ' --- BOTÓN CANCELAR (Sin cambios) ---
    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        If dgv_carrito.Rows.Count > 0 Then
            If MessageBox.Show("¿Está seguro de cancelar la venta? Se perderán los datos del carrito.", "Cancelar Venta", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                LimpiarFormularioVenta()
            End If
        Else
            LimpiarFormularioVenta()
        End If
    End Sub

End Class