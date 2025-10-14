using Formulario;
using System;
using System.Linq; 
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; 

namespace Formulario
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MostrarMejoresPromedios();
        }

        public void MostrarMejoresPromedios()
        {
            
            chartPromedios.Series.Clear();
            chartPromedios.Titles.Clear();

            
            if (DatosCompartidos.ListaEstudiantes.Count == 0)
            {
                MessageBox.Show("No hay estudiantes registrados para generar el gráfico.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            var topEstudiantes = DatosCompartidos.ListaEstudiantes
                .Where(e => e.Asignaturas.Count > 0) 
                .OrderByDescending(e => e.Promedio)
                .Take(5) 
                .ToList();

            if (topEstudiantes.Count == 0)
            {
                MessageBox.Show("Los estudiantes registrados no tienen notas válidas para calcular el promedio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Series seriePromedios = new Series("Promedio General")
            {
                ChartType = SeriesChartType.Column 
            };

            chartPromedios.Titles.Add("Top 5 Mejores Promedios");

            
            foreach (var est in topEstudiantes)
            {
                DataPoint punto = new DataPoint();
                punto.AxisLabel = est.Nombre; 
                punto.YValues = new double[] { est.Promedio }; 
               
                punto.Label = est.Promedio.ToString("F2");

                seriePromedios.Points.Add(punto);
            }

         
            chartPromedios.Series.Add(seriePromedios);

            ChartArea area = chartPromedios.ChartAreas[0];
            area.AxisY.Maximum = 100; 
            area.AxisY.Minimum = 0;
            area.AxisY.Title = "Promedio";
            area.AxisX.Title = "Estudiante";
            area.AxisX.Interval = 1;
        }
    }
}

