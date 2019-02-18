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

namespace Componentes
{
    public partial class Form1 : Form
    {
        Timer timer;
        bool start = false;
        string[] imagenes = new string[] { ".BMP", ".GIF", ".JPG", ".JPEG", ".PNG", ".TIFF", ".ico" };
        List<string> rutas = new List<string>();
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void ejer11_ClickEnMarca(object sender, EventArgs e)
        {
            Console.WriteLine("asfdlkvndfksl<vsfdak");
        }

        private void ejer21_StartPause(object sender, EventArgs e)
        {
            start = !start;
            timer.Enabled = start;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Selecciona una imagen";
            openFile.InitialDirectory = Environment.GetEnvironmentVariable("homedrive") + "\\" + Environment.GetEnvironmentVariable("homepath");
            openFile.Filter = "Todos (*.*)|*.*";
            openFile.ValidateNames = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                rutas.Clear();
                bool valido = false;
                FileInfo f = new FileInfo(openFile.FileName);
                for (int i = 0; i < imagenes.Length; i++)
                {
                    if (!valido)
                    {
                        if (String.Equals(f.Extension, imagenes[i], StringComparison.OrdinalIgnoreCase))
                        {
                            valido = true;
                        }
                    }
                }
                if (valido)
                {
                    DirectoryInfo d = new DirectoryInfo(f.DirectoryName);
                    foreach (FileInfo fileInfo in d.GetFiles())
                    {
                        for (int i = 0; i < imagenes.Length; i++)
                        {
                            if (String.Equals(fileInfo.Extension, imagenes[i], StringComparison.OrdinalIgnoreCase))
                            {
                                rutas.Add(fileInfo.FullName);
                                if (fileInfo.FullName == openFile.FileName)
                                {
                                    index = rutas.Count - 1;
                                }
                            }
                        }
                    }
                    componente2.Enabled = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            componente2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (start)
            {
                lblError.Text = "";
                componente2.YY++;
                Console.WriteLine(rutas[index]);
                try
                {
                    pictureBox1.Image = new Bitmap(rutas[index]);
                }
                catch (ArgumentException)
                {
                    lblError.Text = "Error en la imagen";
                }
                index++;
                if (index > rutas.Count - 1)
                {
                    index = 0;
                }
            }
        }

        private void componente2_DesbordaTiempo(object sender, EventArgs e)
        {
            componente2.XX++;
        }

        private void ejer31_Click(object sender, EventArgs e)
        {
            ahorcado.Errores++;
        }

        private void ahorcado_CambiaError(object sender, EventArgs e)
        {
            Console.WriteLine("error++");
        }

        private void ahorcado_Ahorcado(object sender, EventArgs e)
        {
            Console.WriteLine("ahorcado");
        }
    }
}
