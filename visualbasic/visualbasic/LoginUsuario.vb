Imports MySql.Data.MySqlClient

' "Partial" es la palabra clave que conecta este código al diseñador.
Partial Public Class loginusuario
    Dim conn As New MySqlConnection

    ' --- Evento Load: Solo para la conexión ---
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = conectar() ' Llama a la función de conexión del módulo
        Me.ActiveControl = lbltitulo
    End Sub

    ' --- Evento "Activated" ELIMINADO para que no haya foco automático ---

    ' --- Lógica de Login ---
    Private Sub bt_enviar_Click(sender As Object, e As EventArgs) Handles bt_enviar.Click
        ' --- 1. Validaciones ---
        If ct_usuario.Text = "" OrElse ct_usuario.Text = "Username" Then
            MsgBox("Digite el usuario")
            ct_usuario.Focus()
            Exit Sub
        End If
        If ct_clave.Text = "" OrElse ct_clave.Text = "Password" Then
            MsgBox("Digite la clave")
            ct_clave.Focus()
            Exit Sub
        End If

        Try
            ' --- 2. Preparación del Comando Seguro ---
            Dim SQL As String = "SELECT rol FROM usuarios WHERE username = @user AND password = md5(@pass)"
            Dim cmd As New MySqlCommand(SQL, conn)
            cmd.Parameters.AddWithValue("@user", ct_usuario.Text)
            cmd.Parameters.AddWithValue("@pass", ct_clave.Text)

            ' --- 3. Ejecución y Lectura ---
            Dim lectura As MySqlDataReader = cmd.ExecuteReader()

            If lectura.HasRows Then
                ' LOGIN EXITOSO
                lectura.Read()
                CurrentUserRole = lectura.GetString("rol")
                CurrentUserRole = ct_usuario.Text
                lectura.Close()

                Dim menuPrincipal As New Menu()
                menuPrincipal.Show()
                Me.Close()
            Else
                ' LOGIN FALLIDO
                lectura.Close()
                MsgBox("Usuario o clave invalido")

                ' Restauramos AMBOS placeholders
                ct_usuario_Leave(Nothing, Nothing)
                ct_clave_Leave(Nothing, Nothing)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al autenticar: " & ex.Message, "Error de Sistema")
        End Try
    End Sub

    ' --- Lógica de Placeholders (Borrar y Color Negro) ---

    ' --- Eventos para ct_usuario ---
    Private Sub ct_usuario_Enter(sender As Object, e As EventArgs) Handles ct_usuario.Enter
        ' Si el texto es el de por defecto, lo borra y pone el texto negro
        If ct_usuario.Text = "Username" Then
            ct_usuario.Text = ""
            ct_usuario.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ct_usuario_Leave(sender As Object, e As EventArgs) Handles ct_usuario.Leave
        ' Si el usuario no escribió nada, vuelve a poner el texto por defecto
        If String.IsNullOrWhiteSpace(ct_usuario.Text) Then
            ct_usuario.Text = "Username"
            ct_usuario.ForeColor = Color.Gray
        End If
    End Sub

    ' --- Eventos para ct_clave ---
    Private Sub ct_clave_Enter(sender As Object, e As EventArgs) Handles ct_clave.Enter
        ' Si el texto es "Contraseña", lo borra, pone color negro y activa el asterisco
        If ct_clave.Text = "Password" Then
            ct_clave.Text = ""
            ct_clave.ForeColor = Color.Black
            ct_clave.PasswordChar = "*"c
        End If
    End Sub

    Private Sub ct_clave_Leave(sender As Object, e As EventArgs) Handles ct_clave.Leave
        ' Si el usuario no escribió nada, quita el asterisco y vuelve a poner el texto en gris
        If String.IsNullOrWhiteSpace(ct_clave.Text) Then
            ct_clave.PasswordChar = ChrW(0)
            ct_clave.Text = "Password"
            ct_clave.ForeColor = Color.Gray
        End If
    End Sub

    ' --- Lógica de Atajo de Tecla Enter ---
    Private Sub ct_clave_KeyDown(sender As Object, e As KeyEventArgs) Handles ct_clave.KeyDown
        If e.KeyCode = Keys.Enter Then
            bt_enviar_Click(Nothing, Nothing)
        End If
    End Sub

End Class
