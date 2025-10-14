namespace Formulario
{
    partial class Form2
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
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.ColAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNota_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(163, 27);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(200, 26);
            this.txtCarnet.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Carnet :";
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColAsignatura,
            this.ColNota_Final});
            this.dgvAsignaturas.Location = new System.Drawing.Point(200, 146);
            this.dgvAsignaturas.Name = "dgvAsignaturas";
            this.dgvAsignaturas.RowHeadersWidth = 62;
            this.dgvAsignaturas.RowTemplate.Height = 28;
            this.dgvAsignaturas.Size = new System.Drawing.Size(440, 195);
            this.dgvAsignaturas.TabIndex = 4;
            // 
            // ColAsignatura
            // 
            this.ColAsignatura.HeaderText = "Asignatura";
            this.ColAsignatura.MinimumWidth = 8;
            this.ColAsignatura.Name = "ColAsignatura";
            this.ColAsignatura.Width = 150;
            // 
            // ColNota_Final
            // 
            this.ColNota_Final.HeaderText = "Nota Final";
            this.ColNota_Final.MinimumWidth = 8;
            this.ColNota_Final.Name = "ColNota_Final";
            this.ColNota_Final.Width = 150;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(358, 358);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 32);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvAsignaturas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCarnet);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAsignaturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNota_Final;
        private System.Windows.Forms.Button btnGuardar;
    }
}