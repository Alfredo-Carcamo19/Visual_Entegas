using System;
using System.Windows.Forms;

namespace Practica6_PV
{
    public partial class FrmCambiarContra : Form
    {
        // Variable para saber a quién cambiarle la clave.
        // En un caso real, esto vendría del Login. Usaremos 'admin' por defecto para probar.
        public string usuarioActual = "admin";

        public FrmCambiarContra()
        {
            InitializeComponent();
        }

        private void FrmCambiarContra_Load(object sender, EventArgs e)
        {
            // Este método es necesario para que el diseñador no falle
        }

        private void btnCambiar_Click_1(object sender, EventArgs e)
        {
            // 1. Validaciones Básicas
            if (string.IsNullOrEmpty(txtActual.Text) || string.IsNullOrEmpty(txtNueva.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNueva.Text != txtRepetir.Text)
            {
                MessageBox.Show("Las contraseñas nuevas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 2. Construir la consulta UPDATE para MySQL
                // Esta consulta intenta cambiar la clave SOLO SI el usuario y la clave actual coinciden.
                string sql = $"UPDATE tb_login SET clave = '{txtNueva.Text}' WHERE usuario = '{usuarioActual}' AND clave = '{txtActual.Text}'";

                // 3. Ejecutar usando tu clase auxiliar BD_SetGet
                // EjecutarOrden devuelve el número de filas afectadas.
                int filasAfectadas = BD_SetGet.EjecutarOrden(sql);

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("¡Contraseña actualizada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Cerrar el formulario
                }
                else
                {
                    // Si filasAfectadas es 0, significa que la contraseña actual era incorrecta
                    MessageBox.Show("No se pudo actualizar. Verifique que su contraseña ACTUAL sea correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error Crítico");
            }
        }
    }
}