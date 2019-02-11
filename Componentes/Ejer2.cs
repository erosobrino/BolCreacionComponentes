using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    //Validado
    public partial class Ejer2 : UserControl
    {
        private bool funcionando=true;
        [Category("Tiempo")]
        [Description("Indica si esta funcionando")]
        public bool Funcionando
        {
            get => funcionando;
            set
            {
                funcionando = value;
                if (funcionando)
                {
                    btPlay.Text = "Play";
                }
                else
                {
                    btPlay.Text = "Pause";
                }
                this.Refresh();
            }
        }

        private int xx;
        [Category("Tiempo")]
        [Description("Indica los minutos")]
        public int XX
        {
            get => xx;
            set
            {
                if (value > 99)
                    value = 0;
                xx = value;
                lblTime.Text = String.Format("{0:D2}:{1:D2}", xx, yy);
                //this.Refresh();  No porque al cambiar el texto ya se hace refresh
            }
        }

        private int yy;
        [Category("Tiempo")]
        [Description("Indica los segundos")]
        public int YY
        {
            get => yy;
            set
            {
                if (value > 59)
                {
                    value = value % 60;
                    DesbordaTiempo?.Invoke(this, EventArgs.Empty);
                }
                yy = value;
                lblTime.Text = String.Format("{0:D2}:{1:D2}", xx, yy);
                //this.Refresh();     No porque al cambiar el texto ya se hace refresh
            }
        }

        public Ejer2()
        {
            InitializeComponent();
        }


        private void btPlay_Click(object sender, EventArgs e)
        {
            StartPause?.Invoke(this, EventArgs.Empty);
            funcionando = !funcionando;
            if (funcionando)
            {
                btPlay.Text = "Play";
            }
            else
            {
                btPlay.Text = "Pause";
            }
        }

        [Category("Acción")]
        [Description("Se lanza cuando se pasan los 59 segundos")]
        public event System.EventHandler DesbordaTiempo;
        [Category("Acción")]
        [Description("Cambio start pause")]
        public event System.EventHandler StartPause;
    }
}
