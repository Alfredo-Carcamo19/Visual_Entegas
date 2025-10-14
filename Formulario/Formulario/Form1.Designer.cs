namespace Formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnForm2 = new System.Windows.Forms.ToolStripButton();
            this.btnForm3 = new System.Windows.Forms.ToolStripButton();
            this.btnForm4 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnForm2,
            this.btnForm3,
            this.btnForm4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnForm2
            // 
            this.btnForm2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForm2.Image = ((System.Drawing.Image)(resources.GetObject("btnForm2.Image")));
            this.btnForm2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(34, 28);
            this.btnForm2.Text = "Ingresar Estudiante";
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForm3.Image = ((System.Drawing.Image)(resources.GetObject("btnForm3.Image")));
            this.btnForm3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(34, 28);
            this.btnForm3.Text = "ver Estudiante";
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // btnForm4
            // 
            this.btnForm4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForm4.Image = ((System.Drawing.Image)(resources.GetObject("btnForm4.Image")));
            this.btnForm4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForm4.Name = "btnForm4";
            this.btnForm4.Size = new System.Drawing.Size(34, 28);
            this.btnForm4.Text = "Grafico Promedios";
            this.btnForm4.Click += new System.EventHandler(this.btnForm4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnForm2;
        private System.Windows.Forms.ToolStripButton btnForm3;
        private System.Windows.Forms.ToolStripButton btnForm4;
    }
}

