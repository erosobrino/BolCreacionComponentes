using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    //Validado
    public partial class Ejer1 : Control
    {
        [RefreshProperties(RefreshProperties.Repaint)]
        public enum eMarca
        {
            Nada,
            Cruz,
            Circulo,
            Imagen
        }

        private bool gradienteOpc = false;
        [Category("Gradiente")]
        [Description("Indica si aparece un gradiente de fondo")]
        public bool GradienteOpc
        {
            get => gradienteOpc;
            set
            {
                gradienteOpc = value;
                this.Refresh();
            }
        }

        private Color gradientecolor1 = Color.Blue;
        [Category("Gradiente")]
        [Description("Indica el primer color del gradiente")]
        public Color GradienteColor1
        {
            get => gradientecolor1;
            set
            {
                gradientecolor1 = value;
                this.Refresh();
            }
        }

        private Color gradientecolor2 = Color.Red;
        [Category("Gradiente")]
        [Description("Indica el segundo color del gradiente")]
        public Color GradienteColor2
        {
            get => gradientecolor2;
            set
            {
                gradientecolor2 = value;
                this.Refresh();
            }
        }

        private Image imagenMarca;
        [Category("Varios")]
        [Description("Indica la ruta de la imagen de marca")]
        public Image ImagenMarca
        {
            get => imagenMarca;
            set
            {
                imagenMarca = value;
                this.Refresh();
            }
        }

        private eMarca marca = eMarca.Nada;
        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get
            {
                return marca;
            }
        }


        int grosor; //Grosor de las líneas de dibujo
        int offsetX; //Desplazamiento a la derecha del texto

        public Ejer1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int offsetY = 0; //Desplazamiento hacia abajo del texto
            offsetX = 0;
            grosor = 0;
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
            // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo


            if (gradientecolor1 != null && gradientecolor2 != null && GradienteOpc)
            {
                LinearGradientBrush gradiente = new LinearGradientBrush(new PointF(0, 0),
                    new PointF(this.Width, this.Height), gradientecolor1, gradientecolor2);
                g.FillRectangle(gradiente, 0, 0, this.Width, this.Height);
            }

            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                    this.Font.Height, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 5;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, this.Font.Height, this.Font.Height);
                    g.DrawLine(lapiz, this.Font.Height, grosor, grosor, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
                case eMarca.Imagen:
                    if (imagenMarca != null)
                    {
                        grosor = 5;
                        g.DrawImage(imagenMarca, 0, 0, this.Height, this.Height);
                        offsetX = this.Height;
                        offsetY = 18;
                    }
                    break;
            }
            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            b.Dispose();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        private void Ejer1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X < offsetX + grosor && Marca != eMarca.Nada)
            {
                ClickEnMarca?.Invoke(this, EventArgs.Empty);
            }
        }

        [Category("Acción")]
        [Description("Se lanza cuando se hace click en la marca")]
        public event System.EventHandler ClickEnMarca;
    }
}
