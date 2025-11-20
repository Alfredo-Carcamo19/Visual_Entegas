using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Practica6_PV
{
    public partial class FrmFacturas : Form
    {
        // Instancia del contexto de datos LINQ to SQL
        private DatosVentasDataContext db = new DatosVentasDataContext();

        public FrmFacturas()
        {
            InitializeComponent();
        }

        // ---------------------------------------------------------
        // EVENTO LOAD: Carga inicial y configuración de columnas
        // ---------------------------------------------------------
        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Cargar los códigos de factura en el ComboBox (Visualizar)
                var codigosFactura = from f in db.Factura
                                     select f.Codigo;

                cmbCodigoFactura.DataSource = codigosFactura.ToList();
                // NOTA: No asignamos DisplayMember/ValueMember porque es una lista simple de enteros

                cmbCodigoFactura.SelectedIndex = -1;
                txtDetalleFactura.Text = "";
                txtTotal.Text = "";

                // 2. Configurar DataGridView y Cargar Catálogo (Pestaña Nueva)
                ConfigurarGridNueva();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar: " + ex.Message);
            }
        }

        // Método para configurar las columnas por código (Evita errores de diseñador)
        private void ConfigurarGridNueva()
        {
            dgvProductosNueva.AutoGenerateColumns = false;
            dgvProductosNueva.Columns.Clear();

            // Columna ComboBox (Producto)
            DataGridViewComboBoxColumn colCombo = new DataGridViewComboBoxColumn();
            colCombo.HeaderText = "Producto";
            colCombo.Name = "cmbProductoCol";
            colCombo.DataPropertyName = "Codigo"; // Enlace interno si fuera necesario

            // Cargar datos del catálogo al combo
            var catalogo = from c in db.Catalogo
                           select new { c.Codigo, c.Nombre };

            colCombo.DataSource = catalogo.ToList();
            colCombo.DisplayMember = "Nombre";
            colCombo.ValueMember = "Codigo";

            dgvProductosNueva.Columns.Add(colCombo);

            // Columna TextBox (Cantidad)
            DataGridViewTextBoxColumn colCant = new DataGridViewTextBoxColumn();
            colCant.HeaderText = "Cantidad";
            colCant.Name = "txtCantidadCol";
            dgvProductosNueva.Columns.Add(colCant);
        }

        // ---------------------------------------------------------
        // PESTAÑA VISUALIZAR: Ver facturas existentes
        // ---------------------------------------------------------
        private void cmbCodigoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigoFactura.SelectedValue != null && int.TryParse(cmbCodigoFactura.SelectedValue.ToString(), out int codigoFactura))
            {
                Factura factura = db.Factura.FirstOrDefault(f => f.Codigo == codigoFactura);

                if (factura != null)
                {
                    txtDetalleFactura.Text = $"Cliente: {factura.Cliente}\r\nFecha: {factura.Fecha}";

                    var productos = factura.Producto.Select(p => new
                    {
                        Producto = p.Nombre,
                        Precio = p.Precio,
                        Cantidad = p.Cantidad,
                        Subtotal = p.Precio * p.Cantidad
                    }).ToList();

                    dgvProductosVisualizar.DataSource = productos;

                    double total = productos.Sum(p => p.Subtotal);
                    txtTotal.Text = total.ToString("C2");
                }
            }
        }

        // Manejo de errores de datos en el Grid (Evita crashes por combos)
        private void dgvProductosNueva_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoNueva.Text) || string.IsNullOrEmpty(txtClienteNueva.Text))
            {
                MessageBox.Show("Ingrese Código y Cliente.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Forzar fin de edición en el grid para capturar el último dato
                if (dgvProductosNueva.IsCurrentCellInEditMode)
                {
                    dgvProductosNueva.EndEdit();
                }

                // 2. Crear Factura
                Factura nuevaFactura = new Factura
                {
                    Codigo = int.Parse(txtCodigoNueva.Text),
                    Cliente = txtClienteNueva.Text,
                    Fecha = dtpFechaNueva.Value.ToShortDateString()
                };

                db.Factura.InsertOnSubmit(nuevaFactura);

                // 3. Recorrer Grid y crear Productos
                foreach (DataGridViewRow row in dgvProductosNueva.Rows)
                {
                    if (row.IsNewRow) continue; // Ignorar fila de "nuevo registro"

                    // Obtener valores de las celdas
                    var cellProducto = row.Cells["cmbProductoCol"].Value;
                    var cellCantidad = row.Cells["txtCantidadCol"].Value;

                    if (cellProducto == null || cellCantidad == null) continue;

                    int codigoProd = Convert.ToInt32(cellProducto);
                    int cantidad;

                    // Cambia .toString() por .ToString()
                    if (!int.TryParse(cellCantidad.ToString(), out cantidad)) continue;

                    // Buscar precio original
                    Catalogo item = db.Catalogo.FirstOrDefault(c => c.Codigo == codigoProd);

                    if (item != null)
                    {
                        Producto p = new Producto
                        {
                            Codigo = item.Codigo,
                            Nombre = item.Nombre,
                            Precio = item.Precio,
                            Cantidad = cantidad,
                            Fk_Codigo = nuevaFactura.Codigo
                        };
                        db.Producto.InsertOnSubmit(p);
                    }
                }

                // 4. Guardar en BD
                db.SubmitChanges();

                MessageBox.Show("Factura guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar para actualizar listas
                FrmFacturas_Load(sender, e);

                // Limpiar campos
                txtCodigoNueva.Clear();
                txtClienteNueva.Clear();
                dgvProductosNueva.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}