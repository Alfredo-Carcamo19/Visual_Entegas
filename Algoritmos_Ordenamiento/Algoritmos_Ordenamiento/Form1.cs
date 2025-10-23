using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Xceed.Words.NET; 
using System.IO;

namespace Algoritmos_Ordenamiento
{
    public partial class Form1 : Form
    {
        private int hilosTerminados = 0;
        private readonly object _lock = new object();
        private bool guardarLog = false;
        private List<int> listaOriginal;
        private List<int> listaBurbuja;
        private List<int> listaQuick;

        private Thread hiloBurbuja;
        private Stopwatch relojBurbuja = new Stopwatch();
        private Stopwatch relojQuick = new Stopwatch();
        private CancellationTokenSource cts;

        private List<int> listaSelection;
        private List<int> listaMerge;

        private Thread hiloSelection;
        private Thread hiloMerge;
        private Stopwatch relojSelection = new Stopwatch();
        private Stopwatch relojMerge = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            listaOriginal = new List<int>();
            int cantidad = (int)numElementos.Value;

            for (int i = 0; i < cantidad; i++)
            {
                listaOriginal.Add(rnd.Next(0, 1000000));
            }

            if (cantidad <= 20)
            {
                var result = MessageBox.Show(
                    "La lista es pequeña. ¿Deseas guardar un log de las iteraciones en Word? (Puede ser lento)",
                    "Guardar Log", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                guardarLog = (result == DialogResult.Yes);
            }
            else
            {
                guardarLog = false;
            }

            btnIniciar.Enabled = true;
            lblBurbuja.Text = "Burbuja: 0%";
            lblQuickSort.Text = "QuickSort: 0%";
            lblSelection.Text = "Selection: 0%"; 
            lblMerge.Text = "MergeSort: 0%"; 
            progressBurbuja.Value = 0;
            progressQuickSort.Value = 0;
            progressSelection.Value = 0;
            progressMerge.Value = 0;
            MessageBox.Show($"Lista generada correctamente con {cantidad} números.");
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (listaOriginal == null || listaOriginal.Count == 0)
            {
                MessageBox.Show("Primero genera los datos.");
                return;
            }

       
            hilosTerminados = 0;

            btnGenerar.Enabled = false;
            btnIniciar.Enabled = false;
            btnDetener.Enabled = true;

      
            cts = new CancellationTokenSource();

            
            listaBurbuja = new List<int>(listaOriginal);
            listaQuick = new List<int>(listaOriginal);
            listaSelection = new List<int>(listaOriginal);
            listaMerge = new List<int>(listaOriginal);

            
            hiloBurbuja = new Thread(new ParameterizedThreadStart(OrdenarBurbuja));
            hiloBurbuja.Start(cts.Token);

            if (!backgroundWorkerQuickSort.IsBusy)
            {
                backgroundWorkerQuickSort.RunWorkerAsync(listaQuick);
            }

            hiloSelection = new Thread(new ParameterizedThreadStart(OrdenarSelection));
            hiloSelection.Start(cts.Token);

            hiloMerge = new Thread(new ParameterizedThreadStart(OrdenarMerge));
            hiloMerge.Start(cts.Token);

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
           
            if (hiloBurbuja != null && hiloBurbuja.IsAlive)
            {
                cts.Cancel();
            }
            if (backgroundWorkerQuickSort.IsBusy)
            {
                backgroundWorkerQuickSort.CancelAsync();
            }
            btnDetener.Enabled = false;
        }

        #region Algoritmo Burbuja (Thread)

        private void OrdenarBurbuja(object tokenObj)
        {
            var token = (CancellationToken)tokenObj;
            relojBurbuja.Restart();
            int n = listaBurbuja.Count;

            for (int i = 0; i < n - 1; i++)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (listaBurbuja[j] > listaBurbuja[j + 1])
                    {
                        int temp = listaBurbuja[j];
                        listaBurbuja[j] = listaBurbuja[j + 1];
                        listaBurbuja[j + 1] = temp;
                    }
                }

                if (i % 100 == 0) // Reporta progreso para actualizar la UI
                {
                    int progreso = (int)(((double)i / n) * 100);
                    this.Invoke(new Action(() =>
                    {
                        progressBurbuja.Value = Math.Min(progreso, 100);
                        lblBurbuja.Text = $"Burbuja: {progreso}%";
                    }));
                }
            }

            relojBurbuja.Stop();
            this.Invoke(new Action(() =>
            {
                if (token.IsCancellationRequested)
                {
                    lblBurbuja.Text = "Burbuja: Cancelado.";
                }
                else
                {
                    progressBurbuja.Value = 100;
                    lblBurbuja.Text = $"Burbuja: Completado en {relojBurbuja.ElapsedMilliseconds} ms";
                }
                RevisarFinDeEjecucion();
            }));
        }

        #endregion

        #region Algoritmo QuickSort (BackgroundWorker)

        private void backgroundWorkerQuickSort_DoWork(object sender, DoWorkEventArgs e)
        {
            relojQuick.Restart();
            var lista = (List<int>)e.Argument;
            var worker = sender as BackgroundWorker;

            // Llama a la versión recursiva pasándole los argumentos necesarios
            QuickSort(lista, 0, lista.Count - 1, worker, e);
        }

        private void QuickSort(List<int> lista, int izquierda, int derecha, BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            if (izquierda < derecha)
            {
                int pivotIndex = Particionar(lista, izquierda, derecha);
                QuickSort(lista, izquierda, pivotIndex - 1, worker, e);
                QuickSort(lista, pivotIndex + 1, derecha, worker, e);
            }
        }

        private int Particionar(List<int> lista, int izquierda, int derecha)
        {
            int pivote = lista[derecha];
            int i = izquierda - 1;
            for (int j = izquierda; j < derecha; j++)
            {
                if (lista[j] <= pivote)
                {
                    i++;
                    int temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                }
            }
            int temp2 = lista[i + 1];
            lista[i + 1] = lista[derecha];
            lista[derecha] = temp2;
            return i + 1;
        }

        private void backgroundWorkerQuickSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // El progreso de QuickSort es difícil de medir, así que por ahora no lo implementamos.
            // Se podría hacer una aproximación, pero complica el código.
            // progressQuickSort.Value = e.ProgressPercentage;
            // lblQuickSort.Text = $"QuickSort: {e.ProgressPercentage}%";
        }

        private void backgroundWorkerQuickSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            relojQuick.Stop();

            if (e.Cancelled)
            {
                lblQuickSort.Text = "QuickSort: Cancelado.";
            }
            else if (e.Error != null)
            {
                lblQuickSort.Text = "QuickSort: Error.";
            }
            else
            {
                progressQuickSort.Value = 100;
                lblQuickSort.Text = $"QuickSort: Completado en {relojQuick.ElapsedMilliseconds} ms";
            }
            RevisarFinDeEjecucion();
        }

        #endregion

        private void RevisarFinDeEjecucion()
        {
            lock (_lock) 
            {
                hilosTerminados++; 

                
                if (hilosTerminados >= 4)
                {
                    
                    this.Invoke(new Action(() => {
                        btnGenerar.Enabled = true;
                        btnIniciar.Enabled = true;
                        btnDetener.Enabled = false;
                    }));
                }
            }
        }

        private void OrdenarSelection(object tokenObj)
        {
        
            List<string> historialPasos = new List<string>();
            
            if (guardarLog)
            {
                historialPasos.Add($"[{string.Join(", ", listaSelection)}]");
            }
           

            var token = (CancellationToken)tokenObj;
            relojSelection.Restart();
            int n = listaSelection.Count;

            for (int i = 0; i < n - 1; i++)
            {
                if (token.IsCancellationRequested) break;

                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (listaSelection[j] < listaSelection[min_idx])
                    {
                        min_idx = j;
                    }
                }

                int temp = listaSelection[min_idx];
                listaSelection[min_idx] = listaSelection[i];
                listaSelection[i] = temp;

                if (guardarLog)
                {
                    historialPasos.Add($"[{string.Join(", ", listaSelection)}]");
                }
               

                if (i % 100 == 0)
                {
                    int progreso = (int)(((double)i / n) * 100);
                    this.Invoke(new Action(() => {
                        progressSelection.Value = Math.Min(progreso, 100);
                        lblSelection.Text = $"Selection: {progreso}%";
                    }));
                }
            }

            if (guardarLog && !token.IsCancellationRequested)
            {
                GuardarIteracionesEnWord("SelectionSort", historialPasos);
            }
           

            relojSelection.Stop();
            this.Invoke(new Action(() => {
                if (token.IsCancellationRequested)
                {
                    lblSelection.Text = "Selection: Cancelado.";
                }
                else
                {
                    progressSelection.Value = 100;
                    lblSelection.Text = $"Selection: Completado en {relojSelection.ElapsedMilliseconds} ms";
                }
                RevisarFinDeEjecucion();
            }));
        }

        private void OrdenarMerge(object tokenObj)
        {
            var token = (CancellationToken)tokenObj;
            relojMerge.Restart();

            MergeSort(listaMerge, 0, listaMerge.Count - 1, token);

            relojMerge.Stop();
            this.Invoke(new Action(() => {
                if (token.IsCancellationRequested)
                {
                    lblMerge.Text = "MergeSort: Cancelado.";
                }
                else
                {
                    progressMerge.Value = 100;
                    lblMerge.Text = $"MergeSort: Completado en {relojMerge.ElapsedMilliseconds} ms";
                }
                RevisarFinDeEjecucion();
            }));
        }

        private void MergeSort(List<int> lista, int izquierda, int derecha, CancellationToken token)
        {
            if (token.IsCancellationRequested) return;

            if (izquierda < derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;
                MergeSort(lista, izquierda, medio, token);
                MergeSort(lista, medio + 1, derecha, token);
                Merge(lista, izquierda, medio, derecha);
            }
        }
        private void Merge(List<int> lista, int izq, int mid, int der)
        {
            int n1 = mid - izq + 1;
            int n2 = der - mid;

            List<int> L = new List<int>(new int[n1]);
            List<int> R = new List<int>(new int[n2]);

            for (int i = 0; i < n1; ++i) L[i] = lista[izq + i];
            for (int j = 0; j < n2; ++j) R[j] = lista[mid + 1 + j];

            int i_izq = 0, j_der = 0, k = izq;
            while (i_izq < n1 && j_der < n2)
            {
                if (L[i_izq] <= R[j_der])
                    lista[k++] = L[i_izq++];
                else
                    lista[k++] = R[j_der++];
            }
            while (i_izq < n1) lista[k++] = L[i_izq++];
            while (j_der < n2) lista[k++] = R[j_der++];
        }


        private void GuardarIteracionesEnWord(string nombreAlgoritmo, List<string> pasos)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{nombreAlgoritmo}_Log.docx");
            try
            {
                using (var document = DocX.Create(path))
                {
                    document.InsertParagraph($"{nombreAlgoritmo} - Pasos de Ordenamiento").Bold().FontSize(16);

                    for (int i = 0; i < pasos.Count; i++)
                    {
                        string encabezado = (i == 0) ? "Estado Inicial: " : $"Paso {i}: ";
                        document.InsertParagraph(encabezado + pasos[i]);
                    }
                    document.Save();
                }
                this.Invoke(new Action(() => MessageBox.Show($"Log de {nombreAlgoritmo} guardado en el escritorio.")));
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => MessageBox.Show($"Error al guardar el log: {ex.Message}")));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultadosParaGrafico = new Dictionary<string, double>();

            
            resultadosParaGrafico.Add("Burbuja", relojBurbuja.Elapsed.TotalMilliseconds);
            resultadosParaGrafico.Add("QuickSort", relojQuick.Elapsed.TotalMilliseconds);
            resultadosParaGrafico.Add("Selection", relojSelection.Elapsed.TotalMilliseconds);
            resultadosParaGrafico.Add("MergeSort", relojMerge.Elapsed.TotalMilliseconds);

           
            Form2 formGrafico = new Form2(resultadosParaGrafico);

            formGrafico.Show();
        }
    }
}