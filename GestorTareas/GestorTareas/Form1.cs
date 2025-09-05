namespace GestorTareas
{
    public partial class Form1 : Form
    {
        List<Tarea> ListaTareas = new List<Tarea>();
        public Form1()
        {
            InitializeComponent();
        }

        private void ActualizarGrid()
        {
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = ListaTareas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Tarea nueva = new Tarea()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Lugar = txtLugar.Text,
                Estado = cmbEstado.SelectedItem.ToString(),
                Fecha = dtpFecha.Value,
            };

            ListaTareas.Add(nueva);
            ActualizarGrid();
            MessageBox.Show("Datos De la Tarea Ingresados Correctamente!!", "Informacion Ingresa Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgvTareas.SelectedRows.Count > 0)
            {
                int indice = dgvTareas.SelectedRows[0].Index;

                ListaTareas[indice].Codigo = txtCodigo.Text;
                ListaTareas[indice].Nombre = txtNombre.Text;
                ListaTareas[indice].Descripcion = txtDescripcion.Text;
                ListaTareas[indice].Lugar = txtLugar.Text;
                ListaTareas[indice].Fecha = dtpFecha.Value;
                ListaTareas[indice].Estado = cmbEstado.SelectedItem?.ToString() ?? string.Empty;
                ActualizarGrid();
                MessageBox.Show("Tarea Editada Correctamente !", "Edicion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int indice = dgvTareas.SelectedRows[0].Index;
                ListaTareas.RemoveAt(indice);
                ActualizarGrid();
                MessageBox.Show("Tarea Eliminada Con Exito!", "Tarea Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvTareas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvTareas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvTareas.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpFecha.Value = (DateTime)dgvTareas.Rows[e.RowIndex].Cells[3].Value;
                txtLugar.Text = dgvTareas.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbEstado.SelectedItem = dgvTareas.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }


        // Buscar por Estado
        private void btnBuscarEstado_Click(object sender, EventArgs e)
        {
            if (cmbBuscarEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado para buscar.");
                return;
            }

            string estadoSeleccionado = cmbBuscarEstado.SelectedItem.ToString();

            var tareasFiltradas = ListaTareas
                .Where(t => t.Estado.Equals(estadoSeleccionado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgvTareas.DataSource = null;
            dgvTareas.DataSource = tareasFiltradas;

            if (tareasFiltradas.Count > 0)
                MessageBox.Show($"Se encontraron {tareasFiltradas.Count} tarea(s) con el estado '{estadoSeleccionado}'.");
            else
                MessageBox.Show($"No se encontraron tareas con el estado '{estadoSeleccionado}'.");
        }


        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.");
                return;
            }

            var tareasEnRango = ListaTareas.Where(t => t.Fecha.Date >= fechaInicio && t.Fecha.Date <= fechaFin).ToList();

            dgvTareas.DataSource = null;
            dgvTareas.DataSource = tareasEnRango;

            MessageBox.Show($"Se encontraron {tareasEnRango.Count} tarea(s) en el rango de fechas seleccionado.");
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
 
            string codigoBuscado = txtBuscarCodigo.Text?.Trim();

            if (string.IsNullOrEmpty(codigoBuscado))
            {
                MessageBox.Show("Ingrese un código para buscar.");
                return;
            }

            var tareaEncontrada = ListaTareas
                .FirstOrDefault(t => t.Codigo.Equals(codigoBuscado, StringComparison.OrdinalIgnoreCase));

            if (tareaEncontrada != null)
            {
                dgvTareas.ClearSelection();
                int rowIndex = ListaTareas.IndexOf(tareaEncontrada);
                dgvTareas.Rows[rowIndex].Selected = true;
                dgvTareas.FirstDisplayedScrollingRowIndex = rowIndex;
                MessageBox.Show("Tarea encontrada y seleccionada.");
            }
            else
            {
                MessageBox.Show("No se encontró ninguna tarea con ese código.");
            }


        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }

}
    

