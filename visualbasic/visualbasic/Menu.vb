Imports System.Reflection.Emit

Public Class Menu

    ' --- 1. La función principal para abrir formularios "hijos" ---
    Private Sub AbrirFormularioEnPanel(ByVal formHijo As Form)
        ' Asumiendo que tu panel se llama 'pnlFormularios'
        Me.pnlFormularios.Controls.Clear()

        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.None ' <-- Importante para centrar

        Me.pnlFormularios.Controls.Add(formHijo)
        formHijo.Show()

        CentrarFormularioHijo()
    End Sub

    ' --- 2. La función que calcula el centrado ---
    Private Sub CentrarFormularioHijo()
        If pnlFormularios.Controls.Count > 0 Then
            If TypeOf pnlFormularios.Controls(0) Is Form Then
                Dim formHijo As Form = CType(pnlFormularios.Controls(0), Form)
                formHijo.Left = (pnlFormularios.Width - formHijo.Width) / 2
                formHijo.Top = (pnlFormularios.Height - formHijo.Height) / 2
            End If
        End If
    End Sub

    ' --- 3. El evento que recentra si la ventana cambia de tamaño ---
    Private Sub pnlFormularios_Resize(sender As Object, e As EventArgs) Handles pnlFormularios.Resize
        CentrarFormularioHijo()
    End Sub


    ' --- 4. Evento Load del Formulario (CON LÓGICA DE SEGURIDAD) ---
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' --- INICIO DE LÓGICA DE BLOQUEO POR ROL ---
        ' Comprueba la variable global guardada en el Login
        If CurrentUserRole <> "admin" Then

            ' Un 'vendedor' NO PUEDE gestionar catálogos clave
            ProveedoresToolStripMenuItem.Enabled = False
            ProductosToolStripMenuItem.Enabled = False

            ' Un 'vendedor' NO PUEDE registrar compras
            RegistrarCompraToolStripMenuItem.Enabled = False

            ' Un 'vendedor' NO PUEDE acceder a Sistema (Usuarios)
            SistemaToolStripMenuItem.Enabled = False

            ' (Si también tienes botones de acceso rápido, deshabilítalos)
            ' bt_proveedores.Enabled = False
            ' bt_usuarios.Enabled = False
        End If
        ' --- FIN DE LÓGICA DE BLOQUEO ---
        lblUsuario.Text = CurrentUserRole
        AbrirFormularioEnPanel(New frmInicio())

    End Sub


    ' --- 5. Eventos Click de tu MenuStrip ---

    ' --- CATÁLOGOS ---
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        AbrirFormularioEnPanel(New Cliente())
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        AbrirFormularioEnPanel(New Productos())
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        AbrirFormularioEnPanel(New Proveedores())
    End Sub

    ' --- MOVIMIENTOS ---
    Private Sub RealizarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealizarVentaToolStripMenuItem.Click
        AbrirFormularioEnPanel(New Ventas())
    End Sub

    Private Sub RegistrarCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarCompraToolStripMenuItem.Click
        AbrirFormularioEnPanel(New Compra())
    End Sub

    ' --- SISTEMA (CON LA CORRECCIÓN) ---
    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        AbrirFormularioEnPanel(New Usuarios())
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ' Preguntamos al usuario si está seguro de cerrar TODO
        If MessageBox.Show("¿Está seguro de que desea salir de la aplicación?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            ' Cierra toda la aplicación
            Application.Exit()

        End If
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            ' 1. (MUY IMPORTANTE) Limpiamos la variable de rol
            ' Esto asegura que el próximo login tenga que re-validar el rol.
            CurrentUserRole = ""

            ' 2. Creamos una nueva instancia del formulario de Login
            ' (Asegúrate que tu formulario de login se llame 'login')
            Dim frmLogin As New loginusuario()

            ' 3. Mostramos el formulario de login
            frmLogin.Show()

            ' 4. Cerramos este formulario de Menú
            Me.Close()

        End If
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        AbrirFormularioEnPanel(New frmVisorProveedores())
    End Sub
    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        AbrirFormularioEnPanel(New frmVisorClientes())
    End Sub
    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        AbrirFormularioEnPanel(New frmVisorProductos())
    End Sub
    Private Sub ExistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExistenciaToolStripMenuItem.Click
        AbrirFormularioEnPanel(New frmVisorExistencias())
    End Sub
    Private Sub StockMinimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockMinimoToolStripMenuItem.Click
        AbrirFormularioEnPanel(New frmVisorExistenciasMinimas())
    End Sub
    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        AbrirFormularioEnPanel(New frmReporteVentas())
    End Sub
    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        AbrirFormularioEnPanel(New frmReporteCompras())
    End Sub

    Private Sub GanaciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GanaciaToolStripMenuItem.Click
        AbrirFormularioEnPanel(New frmReporteGanancias())
    End Sub

    Private Sub bt_clientes_Click(sender As Object, e As EventArgs) Handles bt_clientes.Click
        AbrirFormularioEnPanel(New Cliente())
    End Sub

    Private Sub bt_proveedores_Click(sender As Object, e As EventArgs) Handles bt_proveedores.Click
        AbrirFormularioEnPanel(New Productos())
    End Sub

    Private Sub bt_usuarios_Click(sender As Object, e As EventArgs) Handles bt_usuarios.Click
        AbrirFormularioEnPanel(New Usuarios())
    End Sub

    Private Sub bt_ventas_Click(sender As Object, e As EventArgs) Handles bt_ventas.Click
        AbrirFormularioEnPanel(New Ventas())
    End Sub

    Private Sub bt_compras_Click(sender As Object, e As EventArgs) Handles bt_compras.Click
        AbrirFormularioEnPanel(New Compra())
    End Sub

    Private Sub bt_cerrarsesion_Click(sender As Object, e As EventArgs) Handles bt_cerrarsesion.Click
        If MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            ' 1. (MUY IMPORTANTE) Limpiamos la variable de rol
            ' Esto asegura que el próximo login tenga que re-validar el rol.
            CurrentUserRole = ""

            ' 2. Creamos una nueva instancia del formulario de Login
            ' (Asegúrate que tu formulario de login se llame 'login')
            Dim frmLogin As New loginusuario()

            ' 3. Mostramos el formulario de login
            frmLogin.Show()

            ' 4. Cerramos este formulario de Menú
            Me.Close()

        End If
    End Sub

    Private Sub btinicio_Click(sender As Object, e As EventArgs) Handles btinicio.Click
        AbrirFormularioEnPanel(New frmInicio())
    End Sub


End Class