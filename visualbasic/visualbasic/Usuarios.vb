Imports MySql.Data.MySqlClient

Public Class Usuarios
    Dim conn As New MySqlConnection

    ' --- 1. Evento Load ---
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.White

        ' --- ¡AQUÍ ESTÁ LA MEJORA! ---
        ' Esta línea hace que las columnas se expandan para llenar
        ' automáticamente todo el ancho del DataGridView.
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ' -----------------------------

        conn = conectar()

        CargarGrillaUsuarios()

        ' Llenamos el ComboBox de Roles manualmente
        cmb_rol.Items.Clear()
        cmb_rol.Items.Add("administrador")
        cmb_rol.Items.Add("vendedor")
    End Sub

    ' --- 2. Cargar Grilla ---
    Private Sub CargarGrillaUsuarios()
        ' Ocultamos la contraseña en la consulta
        Dim SQL As String = "SELECT id_usuario, username, rol FROM usuarios"
        dataGridView1.DataSource = cargar_grid(SQL, conn)
    End Sub

    ' --- 3. Botones ---
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        ct_idusuario.Text = ""
        ct_username.Text = ""
        ct_password.Text = ""
        cmb_rol.SelectedIndex = -1 ' Deselecciona el rol
        ct_username.Focus()
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        ' Validaciones
        If ct_username.Text = "" Then
            MessageBox.Show("Digite el nombre de usuario")
            ct_username.Focus()
            Exit Sub
        End If
        If cmb_rol.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un rol")
            cmb_rol.Focus()
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

        ' --- LÓGICA DE CONTRASEÑA ---
        If ct_idusuario.Text = "" Then
            ' --- INSERT (Nuevo Usuario) ---
            var = "Guardado"
            ' Requerimos contraseña para un usuario nuevo
            If ct_password.Text = "" Then
                MessageBox.Show("Debe ingresar una contraseña para un nuevo usuario.")
                ct_password.Focus()
                Exit Sub
            End If

            SQL = "INSERT INTO Usuarios (username, password, rol) VALUES (@user, md5(@pass), @rol)"
            cmd.CommandText = SQL
            cmd.Parameters.AddWithValue("@pass", ct_password.Text) ' MD5 lo hace la consulta

        Else
            ' --- UPDATE (Usuario Existente) ---
            var = "Actualizado"
            If ct_password.Text <> "" Then
                ' Si el usuario escribió una contraseña, la actualizamos
                SQL = "UPDATE Usuarios SET username = @user, password = md5(@pass), rol = @rol WHERE id_usuario = @id"
                cmd.Parameters.AddWithValue("@pass", ct_password.Text)
            Else
                ' Si dejó la caja vacía, NO actualizamos la contraseña
                SQL = "UPDATE Usuarios SET username = @user, rol = @rol WHERE id_usuario = @id"
            End If
            cmd.Parameters.AddWithValue("@id", ct_idusuario.Text)
        End If

        cmd.CommandText = SQL
        cmd.Parameters.AddWithValue("@user", ct_username.Text)
        cmd.Parameters.AddWithValue("@rol", cmb_rol.SelectedItem.ToString())

        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro " & var & " correctamente.")

        btnuevo_Click(Nothing, Nothing)
        CargarGrillaUsuarios()
    End Sub

    Private Sub btborrar_Click(sender As Object, e As EventArgs) Handles btborrar.Click
        If ct_idusuario.Text = "" Then
            MessageBox.Show("Seleccione un usuario de la lista para eliminarlo.")
            Exit Sub
        End If
        ' (Aquí podrías agregar una validación para no auto-borrarte)

        If MessageBox.Show("¿Realmente desea eliminar el usuario?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If

        Dim SQL As String = "DELETE FROM usuarios WHERE id_usuario = @id"
        Dim cmd As New MySqlCommand(SQL, conn)
        cmd.Parameters.AddWithValue("@id", ct_idusuario.Text)

        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro borrado exitosamente.")

        btnuevo_Click(Nothing, Nothing)
        CargarGrillaUsuarios()
    End Sub

    Private Sub btsalir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        Me.Close()
    End Sub

    ' --- 4. CellClick ---
    Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dataGridView1.Rows(e.RowIndex)

            ct_idusuario.Text = fila.Cells("id_usuario").Value.ToString()
            ct_username.Text = fila.Cells("username").Value.ToString()
            cmb_rol.SelectedItem = fila.Cells("rol").Value.ToString()

            ' IMPORTANTE: Dejar la contraseña vacía por seguridad.
            ' Si el admin quiere cambiarla, debe escribir una nueva.
            ct_password.Text = ""
        End If
    End Sub

End Class