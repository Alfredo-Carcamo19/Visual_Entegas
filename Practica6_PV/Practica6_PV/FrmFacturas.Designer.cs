namespace Practica6_PV
{
    partial class FrmFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProductosVisualizar = new System.Windows.Forms.DataGridView();
            this.txtDetalleFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCodigoFactura = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvProductosNueva = new System.Windows.Forms.DataGridView();
            this.cmbProductoCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtCantidadCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaNueva = new System.Windows.Forms.DateTimePicker();
            this.txtClienteNueva = new System.Windows.Forms.TextBox();
            this.txtCodigoNueva = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVisualizar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosNueva)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtTotal);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgvProductosVisualizar);
            this.tabPage1.Controls.Add(this.txtDetalleFactura);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbCodigoFactura);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualizar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(198, 315);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(181, 31);
            this.txtTotal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total";
            // 
            // dgvProductosVisualizar
            // 
            this.dgvProductosVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosVisualizar.Location = new System.Drawing.Point(92, 119);
            this.dgvProductosVisualizar.Name = "dgvProductosVisualizar";
            this.dgvProductosVisualizar.RowHeadersWidth = 62;
            this.dgvProductosVisualizar.RowTemplate.Height = 28;
            this.dgvProductosVisualizar.Size = new System.Drawing.Size(530, 157);
            this.dgvProductosVisualizar.TabIndex = 3;
            // 
            // txtDetalleFactura
            // 
            this.txtDetalleFactura.Location = new System.Drawing.Point(500, 25);
            this.txtDetalleFactura.Multiline = true;
            this.txtDetalleFactura.Name = "txtDetalleFactura";
            this.txtDetalleFactura.Size = new System.Drawing.Size(231, 55);
            this.txtDetalleFactura.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione un Codigo";
            // 
            // cmbCodigoFactura
            // 
            this.cmbCodigoFactura.FormattingEnabled = true;
            this.cmbCodigoFactura.Location = new System.Drawing.Point(198, 22);
            this.cmbCodigoFactura.Name = "cmbCodigoFactura";
            this.cmbCodigoFactura.Size = new System.Drawing.Size(181, 28);
            this.cmbCodigoFactura.TabIndex = 0;
            this.cmbCodigoFactura.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoFactura_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.dgvProductosNueva);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dtpFechaNueva);
            this.tabPage2.Controls.Add(this.txtClienteNueva);
            this.tabPage2.Controls.Add(this.txtCodigoNueva);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nueva";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(548, 304);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 40);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // dgvProductosNueva
            // 
            this.dgvProductosNueva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosNueva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbProductoCol,
            this.txtCantidadCol});
            this.dgvProductosNueva.Location = new System.Drawing.Point(86, 6);
            this.dgvProductosNueva.Name = "dgvProductosNueva";
            this.dgvProductosNueva.RowHeadersWidth = 62;
            this.dgvProductosNueva.RowTemplate.Height = 28;
            this.dgvProductosNueva.Size = new System.Drawing.Size(595, 211);
            this.dgvProductosNueva.TabIndex = 6;
            // 
            // cmbProductoCol
            // 
            this.cmbProductoCol.HeaderText = "Producto";
            this.cmbProductoCol.MinimumWidth = 8;
            this.cmbProductoCol.Name = "cmbProductoCol";
            this.cmbProductoCol.Width = 150;
            // 
            // txtCantidadCol
            // 
            this.txtCantidadCol.HeaderText = "Cantidad";
            this.txtCantidadCol.MinimumWidth = 8;
            this.txtCantidadCol.Name = "txtCantidadCol";
            this.txtCantidadCol.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo Factura";
            // 
            // dtpFechaNueva
            // 
            this.dtpFechaNueva.Location = new System.Drawing.Point(285, 354);
            this.dtpFechaNueva.Name = "dtpFechaNueva";
            this.dtpFechaNueva.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaNueva.TabIndex = 2;
            // 
            // txtClienteNueva
            // 
            this.txtClienteNueva.Location = new System.Drawing.Point(285, 309);
            this.txtClienteNueva.Name = "txtClienteNueva";
            this.txtClienteNueva.Size = new System.Drawing.Size(200, 26);
            this.txtClienteNueva.TabIndex = 1;
            // 
            // txtCodigoNueva
            // 
            this.txtCodigoNueva.Location = new System.Drawing.Point(285, 267);
            this.txtCodigoNueva.Name = "txtCodigoNueva";
            this.txtCodigoNueva.Size = new System.Drawing.Size(200, 26);
            this.txtCodigoNueva.TabIndex = 0;
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmFacturas";
            this.Text = "FrmFacturas";
            this.Load += new System.EventHandler(this.FrmFacturas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVisualizar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosNueva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDetalleFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCodigoFactura;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProductosVisualizar;
        private System.Windows.Forms.DateTimePicker dtpFechaNueva;
        private System.Windows.Forms.TextBox txtClienteNueva;
        private System.Windows.Forms.TextBox txtCodigoNueva;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvProductosNueva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbProductoCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn txtCantidadCol;
    }
}