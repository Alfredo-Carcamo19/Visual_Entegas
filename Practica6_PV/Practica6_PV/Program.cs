using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Practica6_PV
{
    internal static class Program
    {
        // ⚠️ REEMPLAZA 'TU_CONTRASEÑA' con tu clave root de MySQL (y verifica el puerto 3307)
        private static string connectionString =
            "Server=localhost;Port=3307;Database=bd_login;Uid=root;Pwd=1234;";

        /// <summary>
        /// Método para llenar el DataSet con la tabla tb_login (Usado para Login)
        /// </summary>
        public static System.Data.DataSet FillLoginDataSet()
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                var ds = new System.Data.DataSet();
                ds.Locale = System.Globalization.CultureInfo.InvariantCulture;

                string query = "SELECT nombre, usuario, clave FROM tb_login";
                var da = new MySqlDataAdapter(query, conn);

                try
                {
                    conn.Open();
                    da.Fill(ds, "tb_login");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos de Login: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return ds;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
        }
    }
}