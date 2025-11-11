Imports MySql.Data.MySqlClient
Imports System.Data ' Asegúrate de tener este import para el DataTable

Public Class Productos
    Dim conn As New MySqlConnection

    ' --- 1. Evento Load: Carga todo al abrir ---
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.White
        conn = conectar()

        CargarGrillaProductos() ' Carga la tabla
        CargarComboProveedores() ' Carga el ComboBox de proveedores

        ' --- INICIO DE LÓGICA DE BLOQUEO POR ROL ---
        If CurrentUserRole <> "admin" Then
            btnuevo.Enabled = False
            btguardar.Enabled = False
            btborrar.Enabled = False

            ' Deshabilitamos también los campos de cálculo
            ct_preciocompra.ReadOnly = True
            ct_porcentaje.ReadOnly = True

            ' Hacemos toda la grilla de solo lectura
            dataGridView1.ReadOnly = True

            MessageBox.Show("Tu rol de usuario solo permite la visualización de datos.", "Acceso Restringido")
        End If
        ' --- FIN DE LÓGICA DE BLOQUEO ---

    End Sub

    ' --- 2. Funciones Auxiliares de Carga ---
    Private Sub CargarGrillaProductos()
        Dim SQL As String = "SELECT * FROM productos"
        dataGridView1.DataSource = cargar_grid(SQL, conn)
    End Sub

    Private Sub CargarComboProveedores()
        Dim SQL As String = "SELECT id_proveedor, nombre FROM proveedores ORDER BY nombre"
        Dim dt As DataTable = cargar_grid(SQL, conn)

        cmb_proveedor.DataSource = dt
        cmb_proveedor.DisplayMember = "nombre"
        cmb_proveedor.ValueMember = "id_proveedor"
    End Sub

    ' --- 3. Lógica de Cálculo Automático ---
    Private Sub CalcularPrecioVenta()
        Dim precioCompra As Decimal
        Dim porcentaje As Decimal

        If Decimal.TryParse(ct_preciocompra.Text, precioCompra) AndAlso Decimal.TryParse(ct_porcentaje.Text, porcentaje) Then
            Dim ganancia As Decimal = precioCompra * (porcentaje / 100)
            Dim precioVenta As Decimal = precioCompra + ganancia
            ct_precioventa.Text = precioVenta.ToString("F2")
        Else
            ct_precioventa.Text = "0.00"
        End If
    End Sub

    Private Sub ct_preciocompra_TextChanged(sender As Object, e As EventArgs) Handles ct_preciocompra.TextChanged
        CalcularPrecioVenta()
    End Sub

    Private Sub ct_porcentaje_TextChanged(sender As Object, e As EventArgs) Handles ct_porcentaje.TextChanged
        CalcularPrecioVenta()
    End Sub


    ' --- 4. Lógica de Botones (CRUD) ---
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        ct_idproducto.Text = ""
        ct_nombre.Text = ""
        ct_descripcion.Text = ""
        ct_stock.Text = "0"
        ct_stockminimo.Text = "0"
        ct_preciocompra.Text = "0.00"
        ct_porcentaje.Text = "0"
        ct_precioventa.Text = "0.00"
        cmb_proveedor.SelectedIndex = -1
        ct_nombre.Focus()
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        If ct_nombre.Text = "" Then
            MessageBox.Show("Digite el nombre del producto")
            ct_nombre.Focus()
            Exit Sub
        End If
        If cmb_proveedor.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un proveedor")
            cmb_proveedor.Focus()
            Exit Sub
        End If
        ' (Aquí deberías añadir más validaciones para stock, stock mínimo, etc.)

        If MessageBox.Show("¿Desea guardar el registro?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim SQL As String
        Dim var As String
        Dim cmd As New MySqlCommand()
        cmd.Connection = conn

        If ct_idproducto.Text = "" Then
            var = "Guardado"
            SQL = "INSERT INTO Productos (nombre, descripcion, precio_compra, porcentaje_ganancia, precio_venta, stock, stock_minimo, id_proveedor) " &
                  "VALUES (@nombre, @desc, @p_compra, @porc, @p_venta, @stock, @stock_min, @idprov)"
        Else
            var = "Actualizado"
            SQL = "UPDATE Productos SET nombre = @nombre, descripcion = @desc, precio_compra = @p_compra, " &
                  "porcentaje_ganancia = @porc, precio_venta = @p_venta, stock = @stock, " &
                  "stock_minimo = @stock_min, id_proveedor = @idprov WHERE id_producto = @id"
            cmd.Parameters.AddWithValue("@id", ct_idproducto.Text)
        End If

        cmd.CommandText = SQL
        cmd.Parameters.AddWithValue("@nombre", ct_nombre.Text)
        cmd.Parameters.AddWithValue("@desc", ct_descripcion.Text)
        cmd.Parameters.AddWithValue("@p_compra", ct_preciocompra.Text)
        cmd.Parameters.AddWithValue("@porc", ct_porcentaje.Text)
        cmd.Parameters.AddWithValue("@p_venta", ct_precioventa.Text)
        cmd.Parameters.AddWithValue("@stock", ct_stock.Text)
        cmd.Parameters.AddWithValue("@stock_min", ct_stockminimo.Text)
        cmd.Parameters.AddWithValue("@idprov", cmb_proveedor.SelectedValue)

        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro " & var & " correctamente.")

        btnuevo_Click(Nothing, Nothing)
        CargarGrillaProductos()
    End Sub

    Private Sub btborrar_Click(sender As Object, e As EventArgs) Handles btborrar.Click
        If ct_idproducto.Text = "" Then
            MessageBox.Show("Seleccione un producto de la lista para eliminarlo.")
            Exit Sub
        End If

        If MessageBox.Show("¿Realmente desea eliminar el registro?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If

        Dim SQL As String = "DELETE FROM productos WHERE id_producto = @id"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.Parameters.AddWithValue("@id", ct_idproducto.Text)

        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro borrado exitosamente.")

        btnuevo_Click(Nothing, Nothing)
        CargarGrillaProductos()
    End Sub

    Private Sub btsalir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        Me.Close()
    End Sub

    ' --- 5. Lógica del CellClick (CORREGIDA para manejo de NULL) ---
    Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dataGridView1.Rows(e.RowIndex)

            ' Comprobamos si la fila está vacía
            If fila.Cells("id_producto").Value Is DBNull.Value OrElse fila.Cells("id_producto").Value Is Nothing Then
                btnuevo_Click(Nothing, Nothing)
                Exit Sub
            End If

            ct_idproducto.Text = fila.Cells("id_producto").Value.ToString()
            ct_nombre.Text = fila.Cells("nombre").Value.ToString()
            ct_descripcion.Text = fila.Cells("descripcion").Value.ToString()
            ct_preciocompra.Text = fila.Cells("precio_compra").Value.ToString()
            ct_porcentaje.Text = fila.Cells("porcentaje_ganancia").Value.ToString()
            ct_precioventa.Text = fila.Cells("precio_venta").Value.ToString()
            ct_stock.Text = fila.Cells("stock").Value.ToString()
            ct_stockminimo.Text = fila.Cells("stock_minimo").Value.ToString()

            ' Manejo de Nulos para el ComboBox
            If fila.Cells("id_proveedor").Value IsNot DBNull.Value AndAlso
               fila.Cells("id_proveedor").Value IsNot Nothing Then

                cmb_proveedor.SelectedValue = fila.Cells("id_proveedor").Value
            Else
                cmb_proveedor.SelectedIndex = -1
            End If
        End If
    End Sub

End Class