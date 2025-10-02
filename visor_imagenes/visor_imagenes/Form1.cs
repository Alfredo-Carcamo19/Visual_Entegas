using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visor_imagenes
{
    public partial class Visor : Form
    {
        private string directorio = @"C:\Users\THINKPAD\OneDrive\Documents\Lenguajes De Programacion\C#\InterfacesG\visor_imagenes\Imagenes"; 
        private List<string> rutasDeImagenes = new List<string>();
        private int indiceImagenActual = 0;
        private bool esEscalaDeGrises = false;

        public Visor()
        {
            InitializeComponent();
        }

        private void Visor_Load(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(directorio);
                string[] extensiones = new string[] { ".jpg", ".png", ".bmp", ".gif" };
                List<FileInfo> listaArchivos = new List<FileInfo>();

                foreach (string extension in extensiones)
                {
                    listaArchivos.AddRange(di.GetFiles("*" + extension));
                }

                foreach (FileInfo archivo in listaArchivos)
                {
                    rutasDeImagenes.Add(archivo.FullName);
                    comboBox1.Items.Add(archivo.Name);
                }

                if (rutasDeImagenes.Count > 0)
                {
                    CargarImagen(indiceImagenActual);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al iniciar la aplicación: {ex.Message}");
            }
        }

        private void CargarImagen(int indice)
        {

            if (indice >= 0 && indice < rutasDeImagenes.Count)
            {
                try
                {
                    Image imagenOriginal = Image.FromFile(rutasDeImagenes[indice]);
                    Bitmap imagenParaMostrar = new Bitmap(imagenOriginal);
                    imagenOriginal.Dispose();

                    if (esEscalaDeGrises)
                    {
                        pictureBox1.Image = ConvertirAGris(imagenParaMostrar);
                    }
                    else
                    {
                        pictureBox1.Image = imagenParaMostrar;
                    }

                    comboBox1.SelectedIndex = indice;
                    txtRuta.Text = rutasDeImagenes[indice];
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
                }
            }
        }

        private Bitmap ConvertirAGris(Image imagenOriginal)
        {
            Bitmap imagenGris = new Bitmap(imagenOriginal.Width, imagenOriginal.Height);

            for (int i = 0; i < imagenOriginal.Width; i++)
            {
                for (int j = 0; j < imagenOriginal.Height; j++)
                {
                    Color colorOriginal = ((Bitmap)imagenOriginal).GetPixel(i, j);
                    int valorGris = (int)(colorOriginal.R * 0.299 + colorOriginal.G * 0.587 + colorOriginal.B * 0.114);
                    Color colorGris = Color.FromArgb(valorGris, valorGris, valorGris);
                    imagenGris.SetPixel(i, j, colorGris);
                }
            }
            return imagenGris;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceImagenActual > 0)
            {
                indiceImagenActual--;
                CargarImagen(indiceImagenActual);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceImagenActual < rutasDeImagenes.Count - 1)
            {
                indiceImagenActual++;
                CargarImagen(indiceImagenActual);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            indiceImagenActual = 0;
            CargarImagen(indiceImagenActual);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            indiceImagenActual = rutasDeImagenes.Count - 1;
            CargarImagen(indiceImagenActual);
        }

        
        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked) 
            {
                esEscalaDeGrises = false;
                CargarImagen(indiceImagenActual);
                SincronizarControlesVisión();
            }
        }

        private void rbEscalaDeGrises_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEscalaDeGrises.Checked)
            {
                esEscalaDeGrises = true;
                CargarImagen(indiceImagenActual);
                SincronizarControlesVisión();
            }
        }

        private void rbCentrada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCentrada.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                SincronizarControlesTamaño();
            }
        }

        private void rbAjustar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAjustar.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                SincronizarControlesTamaño();
            }
        }

        private void rbZoom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbZoom.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                SincronizarControlesTamaño();
            }
        }

        private void girarIzquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }

        private void girarDerechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Refresh();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBox1.Image);
        }

        private void SincronizarControlesVisión()
        {
            bool isNormal = !esEscalaDeGrises;

            rbNormal.Checked = isNormal;
            rbEscalaDeGrises.Checked = !isNormal;

            menuItemNormal.Checked = isNormal;
            menuItemGris.Checked = !isNormal;

            toolStripButtonNormal.Checked = isNormal;
            toolStripButtonImagenGris.Checked = !isNormal;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indice = comboBox1.SelectedIndex;
            indiceImagenActual = indice;
            CargarImagen(indiceImagenActual);
        }


        private void SincronizarControlesTamaño()
        {
            bool isCentrada = pictureBox1.SizeMode == PictureBoxSizeMode.CenterImage;
            bool isAjustar = pictureBox1.SizeMode == PictureBoxSizeMode.StretchImage;
            bool isZoom = pictureBox1.SizeMode == PictureBoxSizeMode.Zoom;

            rbCentrada.Checked = isCentrada;
            rbAjustar.Checked = isAjustar;
            rbZoom.Checked = isZoom;

            centradaToolStripMenuItem.Checked = isCentrada;
            ajustadaToolStripMenuItem.Checked = isAjustar;
            zoomToolStripMenuItem.Checked = isZoom;

            toolStripButtonCentrar.Checked = isCentrada;
            toolStripButtonAjustar.Checked = isAjustar;
            toolStripButtonZoom.Checked = isZoom;
        }

        private void centradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            SincronizarControlesTamaño();
        }

        private void ajustadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            SincronizarControlesTamaño();
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            SincronizarControlesTamaño();
        }

        private void menuItemNormal_Click(object sender, EventArgs e)
        {
            esEscalaDeGrises = false;
            CargarImagen(indiceImagenActual);
            SincronizarControlesVisión();
        }

        private void menuItemGris_Click(object sender, EventArgs e)
        {
            esEscalaDeGrises = true;
            CargarImagen(indiceImagenActual);
            SincronizarControlesVisión();
        }

        private void toolStripButtonNormal_Click(object sender, EventArgs e)
        {
            esEscalaDeGrises = false;
            CargarImagen(indiceImagenActual);
            SincronizarControlesVisión();
        }

        private void toolStripButtonGris_Click(object sender, EventArgs e)
        {
            esEscalaDeGrises = true;
            CargarImagen(indiceImagenActual);
            SincronizarControlesVisión();
        }

        private void girar90IzquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void girar90ALaDerechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void copiarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Clipboard.SetImage(pictureBox1.Image);
            }
        }

        private void guardarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Guardar Imagen";
            saveFileDialog1.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonAjustar_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            SincronizarControlesTamaño();
        }

        private void toolStripButtonZoom_Click(object sender, EventArgs e)
        {
          
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            SincronizarControlesTamaño();
        }

        private void toolStripButtonCentrar_Click(object sender, EventArgs e)
        {
            
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            SincronizarControlesTamaño();
        }
    }
}
