Imports MySql.Data.MySqlClient
Imports System.Data ' Asegúrate de tener este import

Public Class Compra
    Dim conn As New MySqlConnection
    ' Dim dtProductos As New DataTable() <-- Ya no necesitamos esta variable global

    ' --- 1. Evento Load: Modificado ---
    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = conectar()

        CargarProveedores()

        ' --- CAMBIO 1: Eliminamos la carga de TODOS los productos ---
        ' CargarProductos() ' <-- Esta línea se va

        ConfigurarCarrito()

        ' --- CAMBIO 2: Deshabilitamos el ComboBox de productos al inicio ---
        cmb_producto.DataSource = Nothing
        cmb_producto.Enabled = False
        ' -------------------------------------------------------------

        dtp_fecha.Value = Date.Now
        dtp_fecha.Enabled = False

        ' --- INICIO DE LÓGICA DE BLOQUEO POR ROL ---
        If CurrentUserRole <> "admin" Then
            btn_agregar.Enabled = False
            bt_guardarcompra.Enabled = False

            ' Deshabilitamos los campos de entrada
            cmb_proveedor.Enabled = False
            cmb_producto.Enabled = False
            txt_cantidad.ReadOnly = True
            txt_preciocompra.ReadOnly = True

            ' Hacemos toda la grilla de solo lectura
            dgv_carrito.ReadOnly = True

            MessageBox.Show("No tienes permisos para registrar compras.", "Acceso Restringido")
        End If
        ' --- FIN DE LÓGICA DE BLOQUEO ---

    End Sub

    ' --- 2. Funciones de Carga ---
    Private Sub CargarProveedores()
        Dim dtProveedores As DataTable = cargar_grid("SELECT id_proveedor, nombre FROM proveedores ORDER BY nombre", conn)
        cmb_proveedor.DataSource = dtProveedores
        cmb_proveedor.DisplayMember = "nombre"
        cmb_proveedor.ValueMember = "id_proveedor"
        cmb_proveedor.SelectedIndex = -1 ' <-- Añadido: Para que no aparezca nada seleccionado
    End Sub

    ' --- CAMBIO 3: Función CargarProductos MODIFICADA para filtrar por ID ---
    Private Sub CargarProductos(ByVal idProveedor As Integer)
        Dim dt As New DataTable()
        ' Usamos una consulta SQL parametrizada para evitar inyección SQL
        Dim sql As String = "SELECT id_producto, nombre FROM productos WHERE id_proveedor = @id_prov ORDER BY nombre"

        Try
            ' Usamos 'Using' para asegurar que la conexión y comandos se cierren solos
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id_prov", idProveedor)

                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using

            cmb_producto.DataSource = dt
            cmb_producto.DisplayMember = "nombre"
            cmb_producto.ValueMember = "id_producto"

            ' Verificamos si el proveedor tiene productos
            If dt.Rows.Count > 0 Then
                cmb_producto.Enabled = True ' Habilitamos el combo
                cmb_producto.SelectedIndex = -1 ' Limpiamos selección
            Else
                cmb_producto.Enabled = False ' Deshabilitamos si no hay productos
                cmb_producto.Text = "No hay productos"
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
            cmb_producto.Enabled = False
            cmb_producto.DataSource = Nothing
        End Try
    End Sub

    ' --- CAMBIO 4: NUEVO Evento para detectar el cambio en Proveedores ---
    ' (Recuerda: Si esto no funciona, ve al diseñador y haz DOBLE CLIC 
    ' en el cmb_proveedor para que se conecte)
    Private Sub cmb_proveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_proveedor.SelectedIndexChanged
        ' Limpiamos el combo de productos cada vez que cambiamos de proveedor
        cmb_producto.DataSource = Nothing
        cmb_producto.Enabled = False

        ' Validamos que haya un proveedor válido seleccionado
        If cmb_proveedor.SelectedIndex > -1 AndAlso cmb_proveedor.SelectedValue IsNot Nothing Then

            Dim idProveedorSeleccionado As Integer

            ' Usamos TryParse para asegurarnos de que el valor es un número
            If Integer.TryParse(cmb_proveedor.SelectedValue.ToString(), idProveedorSeleccionado) Then
                ' Si es un número, cargamos los productos de ESE proveedor
                CargarProductos(idProveedorSeleccionado)
            End If
        End If
    End Sub

    ' --- (El resto de tu código sigue igual) ---

    Private Sub ConfigurarCarrito()
        dgv_carrito.Columns.Clear()
        dgv_carrito.Columns.Add("id_producto", "ID")
        dgv_carrito.Columns.Add("producto", "Producto")
        dgv_carrito.Columns.Add("cantidad", "Cant.")
        dgv_carrito.Columns.Add("precio_compra", "Precio Compra")
        dgv_carrito.Columns.Add("subtotal", "Subtotal")

        Dim btnColumnaQuitar As New DataGridViewButtonColumn()
        btnColumnaQuitar.HeaderText = "Quitar"
        btnColumnaQuitar.Text = "Quitar"
        btnColumnaQuitar.Name = "columna_quitar"
        btnColumnaQuitar.UseColumnTextForButtonValue = True
        dgv_carrito.Columns.Add(btnColumnaQuitar)

        dgv_carrito.Columns("precio_compra").DefaultCellStyle.Format = "F2"
        dgv_carrito.Columns("subtotal").DefaultCellStyle.Format = "F2"
        dgv_carrito.Columns("id_producto").Visible = False
    End Sub

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

    ' --- 3. Lógica del Botón "Agregar" ---
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        ' Validaciones
        If cmb_producto.SelectedIndex = -1 OrElse cmb_producto.Enabled = False Then
            MessageBox.Show("Seleccione un producto válido.")
            Exit Sub
        End If
        Dim cantidad As Integer
        If Not Integer.TryParse(txt_cantidad.Text, cantidad) OrElse cantidad <= 0 Then
            MessageBox.Show("Ingrese una cantidad válida.")
            txt_cantidad.Focus()
            Exit Sub
        End If
        Dim precioCompra As Decimal
        If Not Decimal.TryParse(txt_preciocompra.Text, precioCompra) OrElse precioCompra <= 0 Then
            MessageBox.Show("Ingrese un precio de compra válido.")
            txt_preciocompra.Focus()
            Exit Sub
        End If

        Dim filaProducto As DataRow = CType(cmb_producto.SelectedItem, DataRowView).Row
        Dim idProd As Integer = filaProducto("id_producto")
        Dim nombreProd As String = filaProducto("nombre")
        Dim subtotal As Decimal = cantidad * precioCompra

        dgv_carrito.Rows.Add(idProd, nombreProd, cantidad, precioCompra, subtotal)
        ActualizarTotal()

        cmb_producto.SelectedIndex = -1
        txt_cantidad.Text = ""
        txt_preciocompra.Text = ""
    End Sub

    ' --- 4. Función para recalcular el Total ---
    Private Sub ActualizarTotal()
        Dim totalCompra As Decimal = 0
        For Each fila As DataGridViewRow In dgv_carrito.Rows
            If fila.Cells("subtotal").Value IsNot Nothing Then
                totalCompra += Convert.ToDecimal(fila.Cells("subtotal").Value)
            End If
        Next
        lbl_total.Text = "Total: " & totalCompra.ToString("C2")
    End Sub

    ' --- 5. Lógica de "Registrar Compra" ---
    Private Sub bt_guardarcompra_Click(sender As Object, e As EventArgs) Handles bt_guardarcompra.Click
        ' (Validaciones...)
        If dgv_carrito.Rows.Count = 0 Then
            MessageBox.Show("El carrito está vacío.")
            Exit Sub
        End If
        If cmb_proveedor.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un proveedor.")
            Exit Sub
        End If
        If MessageBox.Show("¿Está seguro de que desea registrar esta compra?", "Confirmar Compra", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        ' (Inicio de la Transacción...)
        Dim trans As MySqlTransaction = Nothing
        Try
            trans = conn.BeginTransaction()

            ' 1. Insertar en 'Compras' (Maestro)
            Dim totalCompra As Decimal = 0
            For Each fila As DataGridViewRow In dgv_carrito.Rows
                If fila.Cells("subtotal").Value IsNot Nothing Then
                    totalCompra += Convert.ToDecimal(fila.Cells("subtotal").Value)
                End If
            Next

            Dim sqlCompra As String = "INSERT INTO Compras (id_proveedor, fecha_compra, total) VALUES (@id_prov, @fecha, @total)"
            Dim cmdCompra As New MySqlCommand(sqlCompra, conn, trans)
            cmdCompra.Parameters.AddWithValue("@id_prov", cmb_proveedor.SelectedValue)
            cmdCompra.Parameters.AddWithValue("@fecha", dtp_fecha.Value) ' <--- Usará el valor bloqueado
            cmdCompra.Parameters.AddWithValue("@total", totalCompra)
            cmdCompra.ExecuteNonQuery()

            ' 2. Obtener el ID
            Dim idCompra As Long = cmdCompra.LastInsertedId

            ' 3. Insertar en 'Detalle_Compras' y Actualizar 'Productos'
            For Each fila As DataGridViewRow In dgv_carrito.Rows
                If fila.IsNewRow Then Continue For ' Omitir la fila nueva si es que existe

                ' 3a. Insertar en Detalle_Compras
                Dim sqlDetalle As String = "INSERT INTO Detalle_Compras (id_compra, id_producto, cantidad, precio_compra) VALUES (@id_c, @id_p, @cant, @precio)"
                Dim cmdDetalle As New MySqlCommand(sqlDetalle, conn, trans)
                cmdDetalle.Parameters.AddWithValue("@id_c", idCompra)
                cmdDetalle.Parameters.AddWithValue("@id_p", fila.Cells("id_producto").Value)
                cmdDetalle.Parameters.AddWithValue("@cant", fila.Cells("cantidad").Value)
                cmdDetalle.Parameters.AddWithValue("@precio", fila.Cells("precio_compra").Value)
                cmdDetalle.ExecuteNonQuery()

                ' 3b. Actualizar (SUMAR) Stock
                Dim sqlStock As String = "UPDATE Productos SET stock = stock + @cant WHERE id_producto = @id_p"
                Dim cmdStock As New MySqlCommand(sqlStock, conn, trans)
                cmdStock.Parameters.AddWithValue("@cant", fila.Cells("cantidad").Value)
                cmdStock.Parameters.AddWithValue("@id_p", fila.Cells("id_producto").Value)
                cmdStock.ExecuteNonQuery()
            Next

            ' 4. Confirmar
            trans.Commit()
            MessageBox.Show("¡Compra registrada con éxito!")
            LimpiarFormularioCompra()

        Catch ex As Exception
            ' 5. Deshacer
            trans.Rollback()
            MessageBox.Show("Error al registrar la compra: " & ex.Message)
        End Try
    End Sub

    ' --- CAMBIO 5: Modificación en LimpiarFormulario ---
    Private Sub LimpiarFormularioCompra()
        dgv_carrito.Rows.Clear()
        ActualizarTotal()
        cmb_proveedor.SelectedIndex = -1
        cmb_producto.SelectedIndex = -1

        ' --- Añadido para que el combo de productos se bloquee al limpiar ---
        cmb_producto.DataSource = Nothing
        cmb_producto.Enabled = False
        ' -------------------------------------------------------------------

        txt_cantidad.Text = ""
        txt_preciocompra.Text = ""
        dtp_fecha.Value = Date.Now ' <-- Reinicia la fecha (aunque sigue bloqueada)
    End Sub

    Private Sub bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click
        LimpiarFormularioCompra()
    End Sub

End Class