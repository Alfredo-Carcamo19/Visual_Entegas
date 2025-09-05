namespace GestorTareas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnEditar = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            cmbEstado = new ComboBox();
            dtpFecha = new DateTimePicker();
            label1 = new Label();
            txtLugar = new TextBox();
            lblLugar = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnAgregar = new Button();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            tabPage2 = new TabPage();
            btnQuitarFiltro = new Button();
            btnBuscarFecha = new Button();
            dtpFechaFin = new DateTimePicker();
            label3 = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaInicio = new Label();
            cmbBuscarEstado = new ComboBox();
            lblBuscarEstado = new Label();
            btnBuscarEstado = new Button();
            txtBuscarCodigo = new TextBox();
            lblBuscarCodigo = new Label();
            btnBuscarCodigo = new Button();
            dgvTareas = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(33, 46);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(709, 669);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(btnEliminar);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(cmbEstado);
            tabPage1.Controls.Add(dtpFecha);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtLugar);
            tabPage1.Controls.Add(lblLugar);
            tabPage1.Controls.Add(txtDescripcion);
            tabPage1.Controls.Add(lblDescripcion);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(lblNombre);
            tabPage1.Controls.Add(btnAgregar);
            tabPage1.Controls.Add(txtCodigo);
            tabPage1.Controls.Add(lblCodigo);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(701, 631);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Principal";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightSteelBlue;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 8F);
            btnEditar.Location = new Point(285, 425);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 43);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(128, 64, 0);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 8F);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(399, 425);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 43);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 365);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 12;
            label2.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "En Proceso", "Terminada", "Finalizada" });
            cmbEstado.Location = new Point(306, 362);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(133, 33);
            cmbEstado.TabIndex = 11;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(306, 240);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(100, 31);
            dtpFecha.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 240);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 9;
            label1.Text = "Fecha de Realizacion:";
            // 
            // txtLugar
            // 
            txtLugar.Location = new Point(306, 301);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(133, 31);
            txtLugar.TabIndex = 8;
            // 
            // lblLugar
            // 
            lblLugar.AutoSize = true;
            lblLugar.Location = new Point(233, 301);
            lblLugar.Name = "lblLugar";
            lblLugar.Size = new Size(60, 25);
            lblLugar.TabIndex = 7;
            lblLugar.Text = "Lugar:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(306, 158);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(133, 50);
            txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(192, 158);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(108, 25);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(309, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(133, 31);
            txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(218, 106);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Aqua;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 8F);
            btnAgregar.Location = new Point(171, 425);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(88, 43);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(309, 50);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(133, 31);
            txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(218, 49);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(75, 25);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnQuitarFiltro);
            tabPage2.Controls.Add(btnBuscarFecha);
            tabPage2.Controls.Add(dtpFechaFin);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dtpFechaInicio);
            tabPage2.Controls.Add(lblFechaInicio);
            tabPage2.Controls.Add(cmbBuscarEstado);
            tabPage2.Controls.Add(lblBuscarEstado);
            tabPage2.Controls.Add(btnBuscarEstado);
            tabPage2.Controls.Add(txtBuscarCodigo);
            tabPage2.Controls.Add(lblBuscarCodigo);
            tabPage2.Controls.Add(btnBuscarCodigo);
            tabPage2.Controls.Add(dgvTareas);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(701, 631);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Visualizar Tareas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnQuitarFiltro
            // 
            btnQuitarFiltro.BackColor = Color.Silver;
            btnQuitarFiltro.FlatStyle = FlatStyle.Flat;
            btnQuitarFiltro.Location = new Point(271, 525);
            btnQuitarFiltro.Name = "btnQuitarFiltro";
            btnQuitarFiltro.Size = new Size(139, 40);
            btnQuitarFiltro.TabIndex = 12;
            btnQuitarFiltro.Text = "Limpiar Filtros";
            btnQuitarFiltro.UseVisualStyleBackColor = false;
            btnQuitarFiltro.Click += btnQuitarFiltro_Click;
            // 
            // btnBuscarFecha
            // 
            btnBuscarFecha.BackColor = Color.FromArgb(0, 192, 0);
            btnBuscarFecha.FlatStyle = FlatStyle.Flat;
            btnBuscarFecha.Font = new Font("Segoe UI", 8F);
            btnBuscarFecha.Location = new Point(544, 459);
            btnBuscarFecha.Name = "btnBuscarFecha";
            btnBuscarFecha.Size = new Size(112, 34);
            btnBuscarFecha.TabIndex = 11;
            btnBuscarFecha.Text = "Buscar";
            btnBuscarFecha.UseVisualStyleBackColor = false;
            btnBuscarFecha.Click += btnBuscarFecha_Click;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(414, 458);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(93, 31);
            dtpFechaFin.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 458);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 9;
            label3.Text = "Fecha Fin:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(222, 453);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(93, 31);
            dtpFechaInicio.TabIndex = 8;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(118, 453);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(108, 25);
            lblFechaInicio.TabIndex = 7;
            lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // cmbBuscarEstado
            // 
            cmbBuscarEstado.FormattingEnabled = true;
            cmbBuscarEstado.Items.AddRange(new object[] { "En Proceso", "Terminada", "Finalizada" });
            cmbBuscarEstado.Location = new Point(273, 396);
            cmbBuscarEstado.Name = "cmbBuscarEstado";
            cmbBuscarEstado.Size = new Size(150, 33);
            cmbBuscarEstado.TabIndex = 6;
            // 
            // lblBuscarEstado
            // 
            lblBuscarEstado.AutoSize = true;
            lblBuscarEstado.Location = new Point(103, 399);
            lblBuscarEstado.Name = "lblBuscarEstado";
            lblBuscarEstado.Size = new Size(159, 25);
            lblBuscarEstado.TabIndex = 5;
            lblBuscarEstado.Text = "Buscar por Estado:";
            // 
            // btnBuscarEstado
            // 
            btnBuscarEstado.BackColor = Color.FromArgb(0, 192, 0);
            btnBuscarEstado.FlatStyle = FlatStyle.Flat;
            btnBuscarEstado.Font = new Font("Segoe UI", 8F);
            btnBuscarEstado.Location = new Point(442, 399);
            btnBuscarEstado.Name = "btnBuscarEstado";
            btnBuscarEstado.Size = new Size(112, 34);
            btnBuscarEstado.TabIndex = 4;
            btnBuscarEstado.Text = "Buscar";
            btnBuscarEstado.UseVisualStyleBackColor = false;
            btnBuscarEstado.Click += btnBuscarEstado_Click;
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.Location = new Point(273, 347);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(150, 31);
            txtBuscarCodigo.TabIndex = 3;
            // 
            // lblBuscarCodigo
            // 
            lblBuscarCodigo.AutoSize = true;
            lblBuscarCodigo.Location = new Point(103, 347);
            lblBuscarCodigo.Name = "lblBuscarCodigo";
            lblBuscarCodigo.Size = new Size(164, 25);
            lblBuscarCodigo.TabIndex = 2;
            lblBuscarCodigo.Text = "Buscar por Codigo:";
            // 
            // btnBuscarCodigo
            // 
            btnBuscarCodigo.BackColor = Color.FromArgb(0, 192, 0);
            btnBuscarCodigo.FlatStyle = FlatStyle.Flat;
            btnBuscarCodigo.Font = new Font("Segoe UI", 8F);
            btnBuscarCodigo.Location = new Point(442, 347);
            btnBuscarCodigo.Name = "btnBuscarCodigo";
            btnBuscarCodigo.Size = new Size(112, 34);
            btnBuscarCodigo.TabIndex = 1;
            btnBuscarCodigo.Text = "Buscar";
            btnBuscarCodigo.UseVisualStyleBackColor = false;
            btnBuscarCodigo.Click += btnBuscarCodigo_Click;
            // 
            // dgvTareas
            // 
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTareas.BackgroundColor = SystemColors.ButtonFace;
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareas.Location = new Point(75, 27);
            dgvTareas.MultiSelect = false;
            dgvTareas.Name = "dgvTareas";
            dgvTareas.RowHeadersWidth = 62;
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.Size = new Size(550, 290);
            dgvTareas.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 797);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Gestor De Tareas";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnAgregar;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TabPage tabPage2;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label label1;
        private TextBox txtLugar;
        private Label lblLugar;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private Label label2;
        private ComboBox cmbEstado;
        private DateTimePicker dtpFecha;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvTareas;
        private TextBox txtBuscarCodigo;
        private Label lblBuscarCodigo;
        private Button btnBuscarCodigo;
        private Label lblBuscarEstado;
        private Button btnBuscarEstado;
        private ComboBox cmbBuscarEstado;
        private Label lblFechaInicio;
        private DateTimePicker dtpFechaFin;
        private Label label3;
        private DateTimePicker dtpFechaInicio;
        private Button btnBuscarFecha;
        private Button btnQuitarFiltro;
    }
}
