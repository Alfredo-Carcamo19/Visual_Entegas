using Formulario;
using System;
using System.Windows.Forms;
using System.Linq; 

namespace Formulario
{
    public partial class Form3 : Form
    {
        private DataGridView dgvListaPrincipal;

        public Form3()
        {
            InitializeComponent();

           
            dgvEstudiantes.ColumnCount = 3;
            dgvEstudiantes.Columns[0].Name = "Carnet";
            dgvEstudiantes.Columns[1].Name = "Nombre";
            dgvEstudiantes.Columns[2].Name = "Promedio";

            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.AllowUserToAddRows = false;

            

            dgvAsignaturas.ColumnCount = 2;
            dgvAsignaturas.Columns[0].Name = "Asignatura";
            dgvAsignaturas.Columns[1].Name = "Nota Final";
            dgvAsignaturas.AllowUserToAddRows = false;

         
            dgvEstudiantes.SelectionChanged += dgvEstudiantes_SelectionChanged;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CargarDatosEstudiantes();
        }

      
        public void CargarDatosEstudiantes()
        {
            dgvEstudiantes.Rows.Clear();
            dgvAsignaturas.Rows.Clear(); 

            if (DatosCompartidos.ListaEstudiantes.Count > 0)
            {
                foreach (var est in DatosCompartidos.ListaEstudiantes)
                {
                    dgvEstudiantes.Rows.Add(est.Carnet, est.Nombre, est.Promedio.ToString("F2"));
                }

                
                if (dgvEstudiantes.Rows.Count > 0)
                {
                    dgvEstudiantes.Rows[0].Selected = true;
                   
                }

            }
            else
            {
                
                txtCarnet.Clear();
                txtNombre.Clear();
                MessageBox.Show("No hay datos de estudiantes cargados.", "Información");
            }
        }

        private void dgvEstudiantes_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvEstudiantes.SelectedRows.Count > 0)
            {
                dgvAsignaturas.Rows.Clear();

               
                string carnetSeleccionado = dgvEstudiantes.SelectedRows[0].Cells[0].Value.ToString();

                Estudiante estudianteSeleccionado = DatosCompartidos.ListaEstudiantes
                    .Find(est => est.Carnet == carnetSeleccionado);

                if (estudianteSeleccionado != null)
                {
                   
                    txtCarnet.Text = estudianteSeleccionado.Carnet;
                    txtNombre.Text = estudianteSeleccionado.Nombre;

                   
                    foreach (var asig in estudianteSeleccionado.Asignaturas)
                    {
                        dgvAsignaturas.Rows.Add(asig.Nombre, asig.Nota.ToString("F2"));
                    }
                }
            }
            else
            {
                dgvAsignaturas.Rows.Clear();
                txtCarnet.Clear();
                txtNombre.Clear();
            }
        }

    }
}