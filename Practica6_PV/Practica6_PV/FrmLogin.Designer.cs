namespace Practica6_PV
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_enviar = new System.Windows.Forms.Button();
            this.ct_clave = new System.Windows.Forms.TextBox();
            this.ct_usuario = new System.Windows.Forms.TextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.Imagen_Usuario = new System.Windows.Forms.PictureBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.GroupBox1.Controls.Add(this.bt_enviar);
            this.GroupBox1.Controls.Add(this.ct_clave);
            this.GroupBox1.Controls.Add(this.ct_usuario);
            this.GroupBox1.Controls.Add(this.lbltitulo);
            this.GroupBox1.Controls.Add(this.Imagen_Usuario);
            this.GroupBox1.Location = new System.Drawing.Point(87, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(346, 462);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            // 
            // bt_enviar
            // 
            this.bt_enviar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.bt_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_enviar.Location = new System.Drawing.Point(39, 368);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.Size = new System.Drawing.Size(250, 39);
            this.bt_enviar.TabIndex = 3;
            this.bt_enviar.Text = "Login";
            this.bt_enviar.UseVisualStyleBackColor = false;
            this.bt_enviar.Click += new System.EventHandler(this.bt_enviar_Click);
            // 
            // ct_clave
            // 
            this.ct_clave.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ct_clave.Location = new System.Drawing.Point(39, 319);
            this.ct_clave.Name = "ct_clave";
            this.ct_clave.Size = new System.Drawing.Size(250, 26);
            this.ct_clave.TabIndex = 2;
            this.ct_clave.Text = "Password";
            this.ct_clave.Enter += new System.EventHandler(this.ct_clave_Enter_1);
            this.ct_clave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ct_clave_KeyDown);
            this.ct_clave.Leave += new System.EventHandler(this.ct_clave_Leave_1);
            // 
            // ct_usuario
            // 
            this.ct_usuario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ct_usuario.Location = new System.Drawing.Point(39, 272);
            this.ct_usuario.Name = "ct_usuario";
            this.ct_usuario.Size = new System.Drawing.Size(250, 26);
            this.ct_usuario.TabIndex = 1;
            this.ct_usuario.Text = "Username";
            this.ct_usuario.Enter += new System.EventHandler(this.ct_usuario_Enter_1);
            this.ct_usuario.Leave += new System.EventHandler(this.ct_usuario_Leave_1);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(69, 22);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(192, 37);
            this.lbltitulo.TabIndex = 8;
            this.lbltitulo.Text = "USER LOGIN";
            // 
            // Imagen_Usuario
            // 
            this.Imagen_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Imagen_Usuario.Image")));
            this.Imagen_Usuario.InitialImage = ((System.Drawing.Image)(resources.GetObject("Imagen_Usuario.InitialImage")));
            this.Imagen_Usuario.Location = new System.Drawing.Point(39, 62);
            this.Imagen_Usuario.Name = "Imagen_Usuario";
            this.Imagen_Usuario.Size = new System.Drawing.Size(250, 173);
            this.Imagen_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagen_Usuario.TabIndex = 7;
            this.Imagen_Usuario.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(519, 459);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(541, 515);
            this.MinimumSize = new System.Drawing.Size(541, 515);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button bt_enviar;
        internal System.Windows.Forms.Label lbltitulo;
        internal System.Windows.Forms.PictureBox Imagen_Usuario;
        public System.Windows.Forms.TextBox ct_clave;
        public System.Windows.Forms.TextBox ct_usuario;
    }
}