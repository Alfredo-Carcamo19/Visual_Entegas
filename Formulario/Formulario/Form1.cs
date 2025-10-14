using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        private Form2 formulario2;
        private Form3 formulario3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {

            if (formulario2 == null || formulario2.IsDisposed)
            {
                
                formulario2 = new Form2();

                formulario2.MdiParent = this;

                formulario2.Show();
            }
            else
            {

                formulario2.BringToFront();
            }
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            if (formulario3 == null || formulario3.IsDisposed)
            {
                formulario3 = new Form3();

                formulario3.WindowState = FormWindowState.Maximized;

               
                formulario3.MdiParent = this;

                
                formulario3.Show();
            }
            else
            {
                
                formulario3.BringToFront();
            }
        }

        private void MostrarFormularioHijo<T>() where T : Form, new()
        {
            
            Form formHijo = this.MdiChildren.OfType<T>().FirstOrDefault();

            if (formHijo == null)
            {
                formHijo = new T
                {
                    MdiParent = this
                };
                formHijo.WindowState = FormWindowState.Maximized; 
                formHijo.Show();
            }
            else
            {
                
                formHijo.BringToFront();

                
                if (formHijo is Form3 form3)
                {
                    
                    form3.CargarDatosEstudiantes();
                }
                else if (formHijo is Form4 form4)
                {
                   
                    form4.MostrarMejoresPromedios();
                }
            }
        }
       

        private void btnForm4_Click(object sender, EventArgs e)
        {

            MostrarFormularioHijo<Form4>();
        }
    }
}
