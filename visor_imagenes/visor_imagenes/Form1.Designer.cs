namespace visor_imagenes
{
    partial class Visor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIsionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGris = new System.Windows.Forms.ToolStripMenuItem();
            this.tamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNormal = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonImagenGris = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAjustar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonZoom = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCentrar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEscalaDeGrises = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbZoom = new System.Windows.Forms.RadioButton();
            this.rbAjustar = new System.Windows.Forms.RadioButton();
            this.rbCentrada = new System.Windows.Forms.RadioButton();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.girar90IzquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girar90ALaDerechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripInferior = new System.Windows.Forms.ToolStrip();
            this.txtRuta = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStripSuperior.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStripInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.vIsionToolStripMenuItem,
            this.tamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click_1);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // vIsionToolStripMenuItem
            // 
            this.vIsionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNormal,
            this.menuItemGris});
            this.vIsionToolStripMenuItem.Name = "vIsionToolStripMenuItem";
            this.vIsionToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.vIsionToolStripMenuItem.Text = "Vision";
            // 
            // menuItemNormal
            // 
            this.menuItemNormal.Name = "menuItemNormal";
            this.menuItemNormal.Size = new System.Drawing.Size(238, 34);
            this.menuItemNormal.Text = "Normal";
            this.menuItemNormal.Click += new System.EventHandler(this.menuItemNormal_Click);
            // 
            // menuItemGris
            // 
            this.menuItemGris.Name = "menuItemGris";
            this.menuItemGris.Size = new System.Drawing.Size(238, 34);
            this.menuItemGris.Text = "Escala de Grises";
            this.menuItemGris.Click += new System.EventHandler(this.menuItemGris_Click);
            // 
            // tamaToolStripMenuItem
            // 
            this.tamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centradaToolStripMenuItem,
            this.ajustadaToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.tamaToolStripMenuItem.Name = "tamaToolStripMenuItem";
            this.tamaToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.tamaToolStripMenuItem.Text = "Tamaño";
            // 
            // centradaToolStripMenuItem
            // 
            this.centradaToolStripMenuItem.Name = "centradaToolStripMenuItem";
            this.centradaToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.centradaToolStripMenuItem.Text = "Centrada";
            this.centradaToolStripMenuItem.Click += new System.EventHandler(this.centradaToolStripMenuItem_Click);
            // 
            // ajustadaToolStripMenuItem
            // 
            this.ajustadaToolStripMenuItem.Name = "ajustadaToolStripMenuItem";
            this.ajustadaToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.ajustadaToolStripMenuItem.Text = "Ajustar";
            this.ajustadaToolStripMenuItem.Click += new System.EventHandler(this.ajustadaToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // statusStripSuperior
            // 
            this.statusStripSuperior.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStripSuperior.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNormal,
            this.toolStripButtonImagenGris,
            this.toolStripButtonAjustar,
            this.toolStripButtonZoom,
            this.toolStripButtonCentrar});
            this.statusStripSuperior.Location = new System.Drawing.Point(0, 33);
            this.statusStripSuperior.Name = "statusStripSuperior";
            this.statusStripSuperior.Size = new System.Drawing.Size(1032, 33);
            this.statusStripSuperior.TabIndex = 2;
            this.statusStripSuperior.Text = "toolStrip1";
            // 
            // toolStripButtonNormal
            // 
            this.toolStripButtonNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNormal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNormal.Image")));
            this.toolStripButtonNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNormal.Name = "toolStripButtonNormal";
            this.toolStripButtonNormal.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonNormal.Text = "Color Normal";
            this.toolStripButtonNormal.Click += new System.EventHandler(this.toolStripButtonNormal_Click);
            // 
            // toolStripButtonImagenGris
            // 
            this.toolStripButtonImagenGris.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonImagenGris.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonImagenGris.Image")));
            this.toolStripButtonImagenGris.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImagenGris.Name = "toolStripButtonImagenGris";
            this.toolStripButtonImagenGris.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonImagenGris.Text = "Imagen Gris";
            this.toolStripButtonImagenGris.Click += new System.EventHandler(this.toolStripButtonGris_Click);
            // 
            // toolStripButtonAjustar
            // 
            this.toolStripButtonAjustar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAjustar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAjustar.Image")));
            this.toolStripButtonAjustar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAjustar.Name = "toolStripButtonAjustar";
            this.toolStripButtonAjustar.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonAjustar.Text = "Ajustar";
            this.toolStripButtonAjustar.Click += new System.EventHandler(this.toolStripButtonAjustar_Click);
            // 
            // toolStripButtonZoom
            // 
            this.toolStripButtonZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZoom.Image")));
            this.toolStripButtonZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoom.Name = "toolStripButtonZoom";
            this.toolStripButtonZoom.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonZoom.Text = "Zoom";
            this.toolStripButtonZoom.Click += new System.EventHandler(this.toolStripButtonZoom_Click);
            // 
            // toolStripButtonCentrar
            // 
            this.toolStripButtonCentrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCentrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCentrar.Image")));
            this.toolStripButtonCentrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCentrar.Name = "toolStripButtonCentrar";
            this.toolStripButtonCentrar.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonCentrar.Text = "Centrar";
            this.toolStripButtonCentrar.Click += new System.EventHandler(this.toolStripButtonCentrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.rbEscalaDeGrises);
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(119, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vision";
            // 
            // rbEscalaDeGrises
            // 
            this.rbEscalaDeGrises.AutoSize = true;
            this.rbEscalaDeGrises.Location = new System.Drawing.Point(372, 45);
            this.rbEscalaDeGrises.Name = "rbEscalaDeGrises";
            this.rbEscalaDeGrises.Size = new System.Drawing.Size(162, 24);
            this.rbEscalaDeGrises.TabIndex = 1;
            this.rbEscalaDeGrises.Text = "Escalas de Grises";
            this.rbEscalaDeGrises.UseVisualStyleBackColor = true;
            this.rbEscalaDeGrises.CheckedChanged += new System.EventHandler(this.rbEscalaDeGrises_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(102, 45);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(84, 24);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.rbZoom);
            this.groupBox2.Controls.Add(this.rbAjustar);
            this.groupBox2.Controls.Add(this.rbCentrada);
            this.groupBox2.Location = new System.Drawing.Point(825, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 285);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamaño";
            // 
            // rbZoom
            // 
            this.rbZoom.AutoSize = true;
            this.rbZoom.Location = new System.Drawing.Point(28, 170);
            this.rbZoom.Name = "rbZoom";
            this.rbZoom.Size = new System.Drawing.Size(75, 24);
            this.rbZoom.TabIndex = 2;
            this.rbZoom.TabStop = true;
            this.rbZoom.Text = "Zoom";
            this.rbZoom.UseVisualStyleBackColor = true;
            this.rbZoom.CheckedChanged += new System.EventHandler(this.rbZoom_CheckedChanged);
            // 
            // rbAjustar
            // 
            this.rbAjustar.AutoSize = true;
            this.rbAjustar.Location = new System.Drawing.Point(28, 110);
            this.rbAjustar.Name = "rbAjustar";
            this.rbAjustar.Size = new System.Drawing.Size(84, 24);
            this.rbAjustar.TabIndex = 1;
            this.rbAjustar.TabStop = true;
            this.rbAjustar.Text = "Ajustar";
            this.rbAjustar.UseVisualStyleBackColor = true;
            this.rbAjustar.CheckedChanged += new System.EventHandler(this.rbAjustar_CheckedChanged);
            // 
            // rbCentrada
            // 
            this.rbCentrada.AutoSize = true;
            this.rbCentrada.Checked = true;
            this.rbCentrada.Location = new System.Drawing.Point(28, 48);
            this.rbCentrada.Name = "rbCentrada";
            this.rbCentrada.Size = new System.Drawing.Size(100, 24);
            this.rbCentrada.TabIndex = 0;
            this.rbCentrada.TabStop = true;
            this.rbCentrada.Text = "Centrada";
            this.rbCentrada.UseVisualStyleBackColor = true;
            this.rbCentrada.CheckedChanged += new System.EventHandler(this.rbCentrada_CheckedChanged);
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.ForeColor = System.Drawing.Color.Black;
            this.btnPrimero.Location = new System.Drawing.Point(203, 561);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(103, 35);
            this.btnPrimero.TabIndex = 5;
            this.btnPrimero.Text = "<<";
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.ForeColor = System.Drawing.Color.Black;
            this.btnUltimo.Location = new System.Drawing.Point(582, 561);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(103, 35);
            this.btnUltimo.TabIndex = 6;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.Black;
            this.btnAnterior.Location = new System.Drawing.Point(334, 561);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(103, 35);
            this.btnAnterior.TabIndex = 7;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.Black;
            this.btnSiguiente.Location = new System.Drawing.Point(454, 561);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(103, 35);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Imagen Actual";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(444, 220);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girar90IzquierdaToolStripMenuItem,
            this.girar90ALaDerechaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.copiarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(269, 106);
            // 
            // girar90IzquierdaToolStripMenuItem
            // 
            this.girar90IzquierdaToolStripMenuItem.Name = "girar90IzquierdaToolStripMenuItem";
            this.girar90IzquierdaToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.girar90IzquierdaToolStripMenuItem.Text = "Girar 90 ° a la Izquierda";
            this.girar90IzquierdaToolStripMenuItem.Click += new System.EventHandler(this.girar90IzquierdaToolStripMenuItem_Click);
            // 
            // girar90ALaDerechaToolStripMenuItem
            // 
            this.girar90ALaDerechaToolStripMenuItem.Name = "girar90ALaDerechaToolStripMenuItem";
            this.girar90ALaDerechaToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.girar90ALaDerechaToolStripMenuItem.Text = "Girar 90 ° a la Derecha";
            this.girar90ALaDerechaToolStripMenuItem.Click += new System.EventHandler(this.girar90ALaDerechaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(265, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Image = global::visor_imagenes.Properties.Resources.do2;
            this.pictureBox1.Location = new System.Drawing.Point(133, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripInferior
            // 
            this.toolStripInferior.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripInferior.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtRuta});
            this.toolStripInferior.Location = new System.Drawing.Point(0, 738);
            this.toolStripInferior.Name = "toolStripInferior";
            this.toolStripInferior.Size = new System.Drawing.Size(1032, 26);
            this.toolStripInferior.Stretch = true;
            this.toolStripInferior.TabIndex = 11;
            this.toolStripInferior.Text = "toolStrip1";
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(500, 26);
            // 
            // Visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 764);
            this.Controls.Add(this.toolStripInferior);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStripSuperior);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Visor";
            this.Text = "Visor De Imagenes";
            this.Load += new System.EventHandler(this.Visor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStripSuperior.ResumeLayout(false);
            this.statusStripSuperior.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStripInferior.ResumeLayout(false);
            this.toolStripInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIsionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNormal;
        private System.Windows.Forms.ToolStripMenuItem menuItemGris;
        private System.Windows.Forms.ToolStripMenuItem centradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStrip statusStripSuperior;
        private System.Windows.Forms.ToolStripButton toolStripButtonNormal;
        private System.Windows.Forms.ToolStripButton toolStripButtonImagenGris;
        private System.Windows.Forms.ToolStripButton toolStripButtonAjustar;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoom;
        private System.Windows.Forms.ToolStripButton toolStripButtonCentrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEscalaDeGrises;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbZoom;
        private System.Windows.Forms.RadioButton rbAjustar;
        private System.Windows.Forms.RadioButton rbCentrada;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem girar90IzquierdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girar90ALaDerechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripInferior;
        private System.Windows.Forms.ToolStripTextBox txtRuta;
    }
}



