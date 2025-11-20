using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace Practica6_PV
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            bool usuarioValido = false;

            // Ocultamos el formulario principal al arrancar para que solo se vea el Login
            this.Hide();

            // Ciclo para permitir reintentos si se equivoca
            while (!usuarioValido)
            {
                FrmLogin loginForm = new FrmLogin();

                // Mostramos el Login. Si el usuario le da a "Aceptar"...
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // 1. Traer datos de la base de datos
                    DataSet ds = Program.FillLoginDataSet();
                    DataTable dtLogin = ds.Tables["tb_login"];

                    // 2. Verificar credenciales con LINQ
                    // Usamos los nombres públicos que configuraste: ct_usuario y ct_clave
                    var query = from row in dtLogin.AsEnumerable()
                                where row.Field<string>("usuario") == loginForm.ct_usuario.Text.Trim() &&
                                      row.Field<string>("clave") == loginForm.ct_clave.Text.Trim()
                                select row;

                    if (query.Any())
                    {
                        // --- CASO: USUARIO EXITOSO ---
                        DataRow userRow = query.First();
                        string loggedInUserName = userRow.Field<string>("nombre");

                        // Mensaje de éxito solicitado
                        MessageBox.Show("Usuario exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Mostrar usuario en la barra de abajo
                        if (toolStripStatusLabel1 != null)
                            toolStripStatusLabel1.Text = "Usuario: " + loggedInUserName;

                        usuarioValido = true; // Rompemos el ciclo
                        this.Show(); // ¡AQUÍ aparece el formulario principal!
                    }
                    else
                    {
                        // --- CASO: USUARIO ERRÓNEO ---
                        // Mensaje de error solicitado
                        MessageBox.Show("Usuario erróneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // El ciclo 'while' continuará y volverá a mostrar la ventana de Login automáticamente
                    }
                }
                else
                {
                    // Si el usuario cierra la ventana de Login con la X o Cancelar, cerramos la app
                    Application.Exit();
                    return;
                }
            }
        }
        

        // --- 2. MÉTODO PARA ABRIR FORMULARIOS (MDI) ---
        // Este método evita que se abran ventanas repetidas
        private void ShowMdiChildForm(Form formInstance)
        {
            
            // Revisar si ya existe una instancia abierta de este tipo
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == formInstance.GetType())
                {
                    form.Activate(); // Traer al frente la existente
                    formInstance.Dispose(); // Borrar la nueva que creamos
                    return;
                }
            }
            // Si no existe, configurarla como hija y mostrarla
            formInstance.MdiParent = this;
            formInstance.Show();
        }
        // Menú Ventan

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(new FrmFacturas());
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(new FrmCatalogo());
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMdiChildForm(new FrmCambiarContra());
        }

        private void cascadaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void acercaDeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog(this);
        }
    }
}