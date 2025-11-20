using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Practica6_PV
{
    public class BD_SetGet
    {
        // ⚠️ REEMPLAZA ESTA PARTE con tu contraseña real
        private static string connectionString = "Server=localhost;Port=3307;Database=bd_login;Uid=root;Pwd=1234;";

        // Ya no necesitamos constructor ni variables sueltas arriba.

        public static int EjecutarOrden(string orden)
        {
            int filasAfectadas = 0;

            // ESTA ES LA SOLUCIÓN: Creamos la conexión aquí mismo usando 'using'
            // Esto garantiza que 'conn' NUNCA sea null y se cierre sola al terminar.
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Abrimos la conexión nueva

                    using (MySqlCommand comm = new MySqlCommand(orden, conn))
                    {
                        filasAfectadas = comm.ExecuteNonQuery(); // Ejecutamos la orden
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + e.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Al llegar a esta llave, la conexión se cierra automáticamente.

            return filasAfectadas;
        }
    }
}