using System;
using System.Drawing; // ⚠️ IMPORTANTE: Necesario para usar Color.DimGray y Color.Black
using System.Windows.Forms;

namespace Practica6_PV
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            ConfigurarPlaceholders(); // Iniciamos la configuración visual al cargar
        }

        // --- CONFIGURACIÓN INICIAL (Se ejecuta al abrir) ---
        private void ConfigurarPlaceholders()
        {
            // Configurar caja de Usuario
            ct_usuario.Text = "Usuario";
            ct_usuario.ForeColor = Color.DimGray; // Color gris suave

            // Configurar caja de Contraseña
            ct_clave.Text = "Contraseña";
            ct_clave.ForeColor = Color.DimGray;
            ct_clave.PasswordChar = '\0'; // '\0' quita los asteriscos para leer el texto
        }
       
        private void bt_enviar_Click(object sender, EventArgs e)
        {
            // Validamos que no estén vacíos y que NO tengan el texto de relleno
            if (ct_usuario.Text == "Usuario" || string.IsNullOrWhiteSpace(ct_usuario.Text) ||
                ct_clave.Text == "Contraseña" || string.IsNullOrWhiteSpace(ct_clave.Text))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si todo está bien, indicamos OK al formulario principal
            this.DialogResult = DialogResult.OK;
        }

        // Este método vacío es necesario para que el diseñador no de error
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Truco: Quitamos el foco de las cajas al iniciar para que se vean los placeholders
            this.ActiveControl = bt_enviar;// O selecciona el PictureBox o el botón para que tenga el foco inicial
        }

        private void ct_usuario_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ct_usuario.Text))
            {
                ct_usuario.Text = "Usuario";
                ct_usuario.ForeColor = Color.DimGray;
            }
        }

        private void ct_usuario_Enter_1(object sender, EventArgs e)
        {
            if (ct_usuario.Text == "Usuario")
            {
                ct_usuario.Text = "";
                ct_usuario.ForeColor = Color.Black; // Color normal al escribir
            }
        }

        private void ct_clave_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ct_clave.Text))
            {
                ct_clave.Text = "Contraseña";
                ct_clave.ForeColor = Color.DimGray;
                ct_clave.PasswordChar = '\0'; // Desactivar asteriscos para leer el placeholder
            }
        }

        private void ct_clave_Enter_1(object sender, EventArgs e)
        {
            if (ct_clave.Text == "Contraseña")
            {
                ct_clave.Text = "";
                ct_clave.ForeColor = Color.Black;
                ct_clave.PasswordChar = '*'; // Activar asteriscos de seguridad
            }
        }

        private void ct_clave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Simula un clic en el botón de enviar
                bt_enviar.PerformClick();

                // Esto evita que suene el "ding" de Windows al dar Enter
                e.SuppressKeyPress = true;
            }
        }
    }
}