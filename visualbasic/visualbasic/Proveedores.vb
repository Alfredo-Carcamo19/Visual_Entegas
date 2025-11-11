Imports MySql.Data.MySqlClient

Public Class Proveedores
    Dim conn As New MySqlConnection

    ' --- Evento Load: Se ejecuta cuando el formulario se carga ---
    Private Sub frmproveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.White
        conn = conectar()
        CargarGrillaProveedores()

        ' --- NUEVA LÓGICA DE BLOQUEO POR ROL ---
        If CurrentUserRole <> "admin" Then
            btnuevo.Enabled = False
            btguardar.Enabled = False
            btborrar.Enabled = False

            ' También puedes deshabilitar la edición directa en la grilla
            dataGridView1.ReadOnly = True

            MessageBox.Show("Tu rol de usuario solo permite la visualización de datos.", "Acceso Restringido")
        End If
        ' --- FIN DE LÓGICA DE BLOQUEO ---

    End Sub


    ' --- Función para cargar o recargar la grilla ---
    Private Sub CargarGrillaProveedores()
        Dim SQL As String
        SQL = "SELECT * FROM proveedores ORDER BY nombre"
        dataGridView1.DataSource = cargar_grid(SQL, conn)
    End Sub

    ' --- Botón Nuevo ---
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        Me.ct_idproveedor.Text = ""
        Me.ct_nombre.Text = ""
        Me.ct_direccion.Text = ""
        Me.ct_telefono.Text = ""
        Me.ct_correo.Text = ""
        Me.ct_nombre.Focus() ' Pone el cursor en el campo "Nombre"
    End Sub

    ' --- Botón Guardar (con validaciones y seguridad) ---
    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click

        ' --- VALIDACIONES ---
        If ct_nombre.Text = "" Then
            MessageBox.Show("Digite el nombre del proveedor")
            ct_nombre.Focus()
            Exit Sub
        End If
        If ct_direccion.Text = "" Then
            MessageBox.Show("Digite la dirección")
            ct_direccion.Focus()
            Exit Sub
        End If
        If ct_telefono.Text = "" Then
            MessageBox.Show("Digite el teléfono")
            ct_telefono.Focus()
            Exit Sub
        End If
        If ct_correo.Text = "" Then
            MessageBox.Show("Digite el correo")
            ct_correo.Focus()
            Exit Sub
        End If

        ' --- Confirmación ---
        If MessageBox.Show("¿Desea guardar el registro?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then
            Exit Sub
        End If

        Dim SQL As String
        Dim var As String
        Dim cmd As New MySqlCommand()
        cmd.Connection = conn

        ' --- Lógica de Guardado (INSERT/UPDATE) con Parámetros ---
        If ct_idproveedor.Text = "" Then
            var = "Guardado"
            SQL = "INSERT INTO proveedores (nombre, direccion, telefono, email) VALUES (@nombre, @direccion, @telefono, @email)"
        Else
            var = "Actualizado"
            SQL = "UPDATE proveedores SET nombre = @nombre, direccion = @direccion, telefono = @telefono, email = @email WHERE id_proveedor = @id"
            cmd.Parameters.AddWithValue("@id", ct_idproveedor.Text)
        End If

        cmd.CommandText = SQL
        cmd.Parameters.AddWithValue("@nombre", ct_nombre.Text)
        cmd.Parameters.AddWithValue("@direccion", ct_direccion.Text)
        cmd.Parameters.AddWithValue("@telefono", ct_telefono.Text)
        cmd.Parameters.AddWithValue("@email", ct_correo.Text)

        ' --- Ejecución ---
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro " & var & " correctamente.")

        btnuevo_Click(Nothing, Nothing)
        CargarGrillaProveedores()
    End Sub

    ' --- Botón Borrar (con Parámetros) ---
    Private Sub btborrar_Click(sender As Object, e As EventArgs) Handles btborrar.Click
        If ct_idproveedor.Text = "" Then
            MessageBox.Show("Seleccione un proveedor de la lista para eliminarlo.")
            Exit Sub
        End If

        If MessageBox.Show("¿Realmente desea eliminar el registro?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If

        Dim SQL As String = "DELETE FROM proveedores WHERE id_proveedor = @id"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.Parameters.AddWithValue("@id", ct_idproveedor.Text)

        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro borrado exitosamente.")

        btnuevo_Click(Nothing, Nothing)
        CargarGrillaProveedores()
    End Sub

    ' --- Botón Salir ---
    Private Sub btsalir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        Me.Close()
    End Sub

    ' --- Evento Clic en la Grilla (¡CORREGIDO!) ---
    Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dataGridView1.Rows(e.RowIndex)

            ct_idproveedor.Text = fila.Cells("id_proveedor").Value.ToString()
            ct_nombre.Text = fila.Cells("nombre").Value.ToString()

            ' *** LÍNEA CORREGIDA (Se eliminó el error 'fila.Text =') ***
            ct_direccion.Text = fila.Cells("direccion").Value.ToString()

            ct_telefono.Text = fila.Cells("telefono").Value.ToString()
            ct_correo.Text = fila.Cells("email").Value.ToString()
        End If
    End Sub

End Class