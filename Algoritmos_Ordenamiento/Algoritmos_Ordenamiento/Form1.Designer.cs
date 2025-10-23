namespace Algoritmos_Ordenamiento
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.progressQuickSort = new System.Windows.Forms.ProgressBar();
            this.progressBurbuja = new System.Windows.Forms.ProgressBar();
            this.lblBurbuja = new System.Windows.Forms.Label();
            this.lblQuickSort = new System.Windows.Forms.Label();
            this.backgroundWorkerQuickSort = new System.ComponentModel.BackgroundWorker();
            this.btnDetener = new System.Windows.Forms.Button();
            this.numElementos = new System.Windows.Forms.NumericUpDown();
            this.progressSelection = new System.Windows.Forms.ProgressBar();
            this.progressMerge = new System.Windows.Forms.ProgressBar();
            this.lblSelection = new System.Windows.Forms.Label();
            this.lblMerge = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numElementos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(196, 26);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(150, 39);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Datos";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(496, 26);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(149, 39);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar Ordenamiento";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // progressQuickSort
            // 
            this.progressQuickSort.Location = new System.Drawing.Point(297, 146);
            this.progressQuickSort.Name = "progressQuickSort";
            this.progressQuickSort.Size = new System.Drawing.Size(467, 31);
            this.progressQuickSort.TabIndex = 2;
            // 
            // progressBurbuja
            // 
            this.progressBurbuja.Location = new System.Drawing.Point(297, 97);
            this.progressBurbuja.Name = "progressBurbuja";
            this.progressBurbuja.Size = new System.Drawing.Size(467, 30);
            this.progressBurbuja.TabIndex = 3;
            // 
            // lblBurbuja
            // 
            this.lblBurbuja.AutoSize = true;
            this.lblBurbuja.Location = new System.Drawing.Point(31, 107);
            this.lblBurbuja.Name = "lblBurbuja";
            this.lblBurbuja.Size = new System.Drawing.Size(95, 20);
            this.lblBurbuja.TabIndex = 4;
            this.lblBurbuja.Text = "Burbuja: 0%";
            // 
            // lblQuickSort
            // 
            this.lblQuickSort.AutoSize = true;
            this.lblQuickSort.Location = new System.Drawing.Point(12, 157);
            this.lblQuickSort.Name = "lblQuickSort";
            this.lblQuickSort.Size = new System.Drawing.Size(114, 20);
            this.lblQuickSort.TabIndex = 5;
            this.lblQuickSort.Text = "Quick Sort: 0%";
            // 
            // backgroundWorkerQuickSort
            // 
            this.backgroundWorkerQuickSort.WorkerReportsProgress = true;
            this.backgroundWorkerQuickSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerQuickSort_DoWork);
            this.backgroundWorkerQuickSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerQuickSort_ProgressChanged);
            this.backgroundWorkerQuickSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerQuickSort_RunWorkerCompleted);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(377, 325);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(96, 35);
            this.btnDetener.TabIndex = 6;
            this.btnDetener.Text = "Detener:";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // numElementos
            // 
            this.numElementos.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numElementos.Location = new System.Drawing.Point(353, 33);
            this.numElementos.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numElementos.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numElementos.Name = "numElementos";
            this.numElementos.Size = new System.Drawing.Size(120, 26);
            this.numElementos.TabIndex = 7;
            this.numElementos.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // progressSelection
            // 
            this.progressSelection.Location = new System.Drawing.Point(297, 199);
            this.progressSelection.Name = "progressSelection";
            this.progressSelection.Size = new System.Drawing.Size(467, 30);
            this.progressSelection.TabIndex = 8;
            // 
            // progressMerge
            // 
            this.progressMerge.Location = new System.Drawing.Point(297, 256);
            this.progressMerge.Name = "progressMerge";
            this.progressMerge.Size = new System.Drawing.Size(467, 30);
            this.progressMerge.TabIndex = 9;
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(20, 209);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(106, 20);
            this.lblSelection.TabIndex = 10;
            this.lblSelection.Text = "Selection: 0%";
            // 
            // lblMerge
            // 
            this.lblMerge.AutoSize = true;
            this.lblMerge.Location = new System.Drawing.Point(7, 256);
            this.lblMerge.Name = "lblMerge";
            this.lblMerge.Size = new System.Drawing.Size(119, 20);
            this.lblMerge.TabIndex = 11;
            this.lblMerge.Text = "Merge Sort: 0%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ver Grafico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMerge);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.progressMerge);
            this.Controls.Add(this.progressSelection);
            this.Controls.Add(this.numElementos);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.lblQuickSort);
            this.Controls.Add(this.lblBurbuja);
            this.Controls.Add(this.progressBurbuja);
            this.Controls.Add(this.progressQuickSort);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnGenerar);
            this.Name = "Form1";
            this.Text = "Metodos Ordenamientos";
            ((System.ComponentModel.ISupportInitialize)(this.numElementos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ProgressBar progressQuickSort;
        private System.Windows.Forms.ProgressBar progressBurbuja;
        private System.Windows.Forms.Label lblBurbuja;
        private System.Windows.Forms.Label lblQuickSort;
        private System.ComponentModel.BackgroundWorker backgroundWorkerQuickSort;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.NumericUpDown numElementos;
        private System.Windows.Forms.ProgressBar progressSelection;
        private System.Windows.Forms.ProgressBar progressMerge;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Label lblMerge;
        private System.Windows.Forms.Button button1;
    }
}

