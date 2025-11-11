Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Cliente
    Dim conn As New MySqlConnection

    ' --- Evento Load: Abre conexión y carga datos ---
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.White
        Me.dataGridView1.AutoSize = False
        Me.dataGridView1.ScrollBars = ScrollBars.Vertical

        Try
            conn = conectar()
            CargarGrillaClientes()

            Me.ct_idcliente.ReadOnly = True
            Me.ct_idcliente.BackColor = SystemColors.Control

            ' --- INICIO DE LÓGICA DE BLOQUEO POR ROL ---
            If CurrentUserRole <> "admin" Then
                btnuevo.Enabled = False
                btguardar.Enabled = False
                btborrar.Enabled = False

                ' Deshabilitamos la fila "nueva" de la grilla
                dataGridView1.AllowUserToAddRows = False

                ' Hacemos toda la grilla de solo lectura
                dataGridView1.ReadOnly = True

                MessageBox.Show("Tu rol de usuario solo permite la visualización de datos.", "Acceso Restringido")
            End If
            ' --- FIN DE LÓGICA DE BLOQUEO ---

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: CargarGrillaClientes - " & ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    ' --- Evento Closing: Cierra la conexión ---
    Private Sub Cliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
                conn.Dispose()
            End If
        Catch ex As Exception
            Console.WriteLine("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub

    ' --- Cargar Grilla (con Try...Catch) ---
    ' --- Cargar Grilla (con lógica de 5 filas corregida) ---
    ' --- Cargar Grilla (con 7 filas y ancho de columnas) ---
    Private Sub CargarGrillaClientes()
        Try
            Dim SQL As String = "SELECT * FROM clientes"
            Dim dtClientes As DataTable = cargar_grid(SQL, conn)

            ' 1. Verificar si cargar_grid devolvió un DataTable válido
            If dtClientes Is Nothing Then
                ' Si es Nothing, creamos uno nuevo CON la estructura de columnas
                dtClientes = New DataTable()
                dtClientes.Columns.Add("id_cliente", GetType(Integer))
                dtClientes.Columns.Add("nombre", GetType(String))
                dtClientes.Columns.Add("direccion", GetType(String))
                dtClientes.Columns.Add("telefono", GetType(String))
                dtClientes.Columns.Add("email", GetType(String))
            End If

            ' --- MEJORA: Total 7 filas ---
            ' 2. Definimos el número mínimo de filas de DATOS/RELLENO
            ' (Cambiado de 4 a 6)
            Dim minimoFilas As Integer = 6 ' (6 + 1 fila nueva = 7 filas en total)
            Dim filasDatos As Integer = dtClientes.Rows.Count
            Dim filasAAgregar As Integer = minimoFilas - filasDatos

            ' 3. Comprobamos si necesitamos agregar filas vacías
            If filasAAgregar > 0 Then
                For i As Integer = 1 To filasAAgregar
                    dtClientes.Rows.Add(dtClientes.NewRow())
                Next
            End If

            ' 4. Permitimos que el usuario siempre pueda añadir una fila nueva
            dataGridView1.AllowUserToAddRows = True

            ' 5. Asignamos el DataTable (con datos + relleno) a la grilla
            dataGridView1.DataSource = dtClientes

            ' 6. Configuramos las columnas (ReadOnly)
            If dataGridView1.Columns.Contains("id_cliente") Then
                dataGridView1.Columns("id_cliente").ReadOnly = True
            End If

            ' --- MEJORA: Ancho de Columnas ---
            ' (Puedes ajustar los números 150 y 200 al tamaño que prefieras)
            If dataGridView1.Columns.Contains("direccion") Then
                dataGridView1.Columns("direccion").Width = 150
            End If
            If dataGridView1.Columns.Contains("email") Then
                dataGridView1.Columns("email").Width = 200
            End If
            ' --- FIN DE LAS MEJORAS ---

        Catch ex As Exception
            MessageBox.Show("Error al llenar la grilla: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' --- Botón Nuevo ---
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        Me.ct_idcliente.Text = ""
        Me.ct_nombre.Text = ""
        Me.ct_direccion.Text = ""
        Me.ct_telefono.Text = "" ' (Corregido a ct_telefono)
        Me.ct_email.Text = ""    ' (Corregido a ct_email)
        Me.ct_nombre.Focus()
    End Sub

    ' --- Botón Guardar (Sin cambios) ---
    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        If ct_nombre.Text = "" Then
            MessageBox.Show("Digite el nombre del cliente")
            ct_nombre.Focus()
            Exit Sub
        End If
        ' ... (tus otras validaciones) ...

        If MessageBox.Show("¿Desea guardar el registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim SQL As String
        Dim var As String

        Try
            Using cmd As New MySqlCommand()
                cmd.Connection = conn

                If ct_idcliente.Text = "" Then
                    ' Al guardar uno nuevo, solo guardará si los campos (ej. nombre) son válidos
                    ' Las filas vacías de la grilla no se podrán guardar gracias a tu validación If ct_nombre.Text = ""
                    var = "Guardado"
                    SQL = "INSERT INTO clientes (nombre, direccion, telefono, email) VALUES (@nombre, @direccion, @telefono, @email)"
                Else
                    var = "Actualizado"
                    SQL = "UPDATE clientes SET nombre = @nombre, direccion = @direccion, telefono = @telefono, email = @email WHERE id_cliente = @id"
                    cmd.Parameters.AddWithValue("@id", ct_idcliente.Text)
                End If

                cmd.CommandText = SQL
                cmd.Parameters.AddWithValue("@nombre", ct_nombre.Text)
                cmd.Parameters.AddWithValue("@direccion", ct_direccion.Text)
                cmd.Parameters.AddWithValue("@telefono", ct_telefono.Text)
                cmd.Parameters.AddWithValue("@email", ct_email.Text)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Registro " & var & " correctamente.")
            btnuevo_Click(Nothing, Nothing)
            CargarGrillaClientes()

        Catch ex As MySqlException
            MessageBox.Show("Error de base de datos: " & ex.Message, "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- Botón Borrar (Sin cambios) ---
    Private Sub btborrar_Click(sender As Object, e As EventArgs) Handles btborrar.Click
        If ct_idcliente.Text = "" Then
            MessageBox.Show("Seleccione un cliente de la lista para eliminarlo.")
            Exit Sub
        End If

        If MessageBox.Show("¿Realmente desea eliminar el registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim SQL As String = "DELETE FROM clientes WHERE id_cliente = @id"
            Using cmd As New MySqlCommand(SQL, conn)
                cmd.Parameters.AddWithValue("@id", ct_idcliente.Text)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Registro borrado exitosamente.")
            btnuevo_Click(Nothing, Nothing)
            CargarGrillaClientes()

        Catch ex As MySqlException
            MessageBox.Show("Error al borrar: " & ex.Message, "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- Botáon Salir ---
    Private Sub btsalir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        Me.Close()
    End Sub

    ' --- CellClick ---
    Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dataGridView1.Rows(e.RowIndex)

            ' --- MEJORA: Comprobar si hay valores nulos (DBNull) ---
            ' Esto evita que el programa "crashee" si haces clic en una de las filas vacías que añadimos
            ct_idcliente.Text = If(fila.Cells("id_cliente").Value Is DBNull.Value, "", fila.Cells("id_cliente").Value.ToString())
            ct_nombre.Text = If(fila.Cells("nombre").Value Is DBNull.Value, "", fila.Cells("nombre").Value.ToString())
            ct_direccion.Text = If(fila.Cells("direccion").Value Is DBNull.Value, "", fila.Cells("direccion").Value.ToString())
            ct_telefono.Text = If(fila.Cells("telefono").Value Is DBNull.Value, "", fila.Cells("telefono").Value.ToString())
            ct_email.Text = If(fila.Cells("email").Value Is DBNull.Value, "", fila.Cells("email").Value.ToString())
        End If
    End Sub

End Class