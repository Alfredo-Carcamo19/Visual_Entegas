using System;
using System.Data;
using System.Data.SqlClient; // Necesario para conectar a SQL Server
using System.Windows.Forms;

namespace Practica6_PV
{
    public partial class FrmCatalogo : Form
    {
        // 1. Cadena de conexión a SQL Server (bd_ventas)
        // Usamos la misma que configuramos para el DBML
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_ventas;Integrated Security=True";

        // Objetos para manejar los datos
        SqlDataAdapter da;
        DataTable dt;
        SqlCommandBuilder builder;

        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void FrmCatalogo_Load(object sender, EventArgs e)
        {
            try
            {
                // 2. Consultar todos los productos al abrir
                string sql = "SELECT * FROM Catalogo";

                // El DataAdapter es el puente entre la BD y tu aplicación
                da = new SqlDataAdapter(sql, connectionString);

                // El CommandBuilder escribe automáticamente los INSERT, UPDATE y DELETE por ti
                builder = new SqlCommandBuilder(da);

                // 3. Llenar la tabla en memoria
                dt = new DataTable();
                da.Fill(dt);

                // 4. Mostrarla en el DataGridView
                // (Asegúrate de que tu grilla se llame 'dgvCatalogo' en el diseño)
                dgvCatalogo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el catálogo: " + ex.Message);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. ¡ESTA ES LA CLAVE! Forzar al grid a confirmar el último cambio
                // Si estás escribiendo en una celda, esto "da Enter" por ti.
                this.BindingContext[dt].EndCurrentEdit();

                // 2. Ahora sí, enviamos los cambios a la base de datos
                da.Update(dt);

                MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}