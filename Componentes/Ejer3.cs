using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    //Validado
    public partial class Ejer3 : Control
    {
        int cantMax = 6;
        Linea[] lineas = new Linea[5];

        private int errores;
        [Category("Ahorcado")]
        [Description("Cantidad de errores, modifica su aspecto")]
        public int Errores
        {
            get => errores;
            set
            {
                if (value < 0 || value > cantMax)
                    value = 0;
                errores = value;
                if (errores == cantMax)
                {
                    Ahorcado?.Invoke(this, EventArgs.Empty);
                }
                CambiaError?.Invoke(this, EventArgs.Empty);
                this.Refresh();
            }
        }

        [Category("Acción")]
        [Description("Se lanza cuando se modifica la camtidad de errores")]
        public event System.EventHandler CambiaError;

        [Category("Acción")]
        [Description("Se lanza cuando se alzanza el numero maximo de errores")]
        public event System.EventHandler Ahorcado;

        public Ejer3()
        {
            InitializeComponent();

        }

        Pen p = new Pen(Color.Black);

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            lineas[0] = new Linea(new Point(this.Width / 3 * 2, this.Height / 4 + this.Width / 8), new Point(this.Width / 3 * 2, this.Height / 6 * 4));
            lineas[1] = new Linea(new Point(this.Width / 3 * 2, this.Height / 2 - 15), new Point(this.Width / 3 * 2 - this.Width / 10, this.Height / 2));
            lineas[2] = new Linea(new Point(this.Width / 3 * 2, this.Height / 2 - 15), new Point(this.Width / 3 * 2 + this.Width / 10, this.Height / 2));
            lineas[3] = new Linea(new Point(this.Width / 3 * 2, this.Height / 6 * 4), new Point(this.Width / 3 * 2 - this.Width / 10, this.Height - this.Height / 8));
            lineas[4] = new Linea(new Point(this.Width / 3 * 2, this.Height / 6 * 4), new Point(this.Width / 3 * 2 + this.Width / 10, this.Height - this.Height / 8));

            pe.Graphics.DrawLine(p, new Point(0, this.Height - 5), new Point(this.Width, this.Height - 5));
            pe.Graphics.DrawLine(p, new Point(this.Width / 3, this.Height - 5), new Point(this.Width / 3, 0));
            pe.Graphics.DrawLine(p, new Point(this.Width / 3, 0), new Point(this.Width / 3 * 2, 0));
            pe.Graphics.DrawLine(p, new Point(this.Width / 3 * 2, 0), new Point(this.Width / 3 * 2, this.Height / 4));

            if (errores >= 1)
            {
                pe.Graphics.DrawEllipse(p, new RectangleF(this.Width / 3 * 2 - this.Width / 16, this.Height / 4, this.Width / 8, this.Width / 8));
            }
            for (int i = 0; i < errores - 1; i++)
            {
                pe.Graphics.DrawLine(p, lineas[i].p1, lineas[i].p2);
            }
        }
        class Linea
        {
            public Point p1, p2;
            public Linea(Point p1, Point p2)
            {
                this.p1 = p1;
                this.p2 = p2;
            }
        }
    }
}
