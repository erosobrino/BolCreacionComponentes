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
    public partial class Ejer3 : Control
    {
        int cantMax = 6;

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

        [Category("Accion")]
        [Description("Se lanza cuando se modifica la camtidad de errores")]
        public event System.EventHandler CambiaError;

        [Category("Accion")]
        [Description("Se lanza cuando se alzanza el numero maximo de errores")]
        public event System.EventHandler Ahorcado;

        public Ejer3()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.DrawLine(new Pen(Color.Black), new Point(0, this.Height), new Point(this.Width, this.Height));
        }
    }
}
