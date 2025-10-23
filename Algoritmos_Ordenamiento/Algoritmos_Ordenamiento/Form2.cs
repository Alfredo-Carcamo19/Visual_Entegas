using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq; 

namespace Algoritmos_Ordenamiento
{
    public partial class Form2 : Form
    {
        private Dictionary<string, double> resultadosFinales;

        public Form2(Dictionary<string, double> resultados)
        {
            InitializeComponent();
            this.resultadosFinales = resultados;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            if (resultadosFinales == null || resultadosFinales.Count == 0)
            {
                MessageBox.Show("No se recibieron datos para mostrar en el gráfico.", "Datos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

         
            chart1.Series.Clear();
            chart1.Titles.Clear();

            
            chart1.ChartAreas[0].AxisX.Title = "Tiempo (ms)";
           
            chart1.ChartAreas[0].AxisY.Title = "Algoritmo";

            
            var series = chart1.Series.Add("Tiempos de Ejecución (ms)");
            series.ChartType = SeriesChartType.Bar; 

           
            series.IsValueShownAsLabel = true;    
            series.LabelFormat = "F2";          
            series.Font = new System.Drawing.Font("Arial", 8f);

            
            var resultadosOrdenados = resultadosFinales.OrderByDescending(par => par.Value);

            
            foreach (var resultado in resultadosOrdenados)
            {
                
                series.Points.AddXY(resultado.Key, resultado.Value);
            }

            
            chart1.Titles.Add("Comparativa de Algoritmos");
            chart1.Titles[0].Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Bold);
        }
    }
}