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
    public partial class Ejer4 : Control
    {
        private List<int> valores = new List<int>();
        [Category("Valores")]
        [Description("Valores de las barras del grafico")]
        public List<int> Valores
        {
            get => valores;
            set
            {
                valores = value;
                this.Refresh();
            }
        }

        private bool ajuste = true;
        [Category("Valores")]
        [Description("Tamaño de las barras automatico")]
        public bool Ajuste
        {
            get => ajuste;
            set
            {
                ajuste = value;
                this.Refresh();
            }
        }

        private int tamaño;
        [Category("Valores")]
        [Description("Tamaño de las barras")]
        public int Tamaño
        {
            get => tamaño;
            set
            {
                tamaño = value;
                this.Refresh();
            }
        }


        private string ejeX = "Eje X";
        [Category("Valores")]
        [Description("Nombre del eje X")]
        public string EjeX
        {
            get => ejeX;
            set
            {
                ejeX = value;
                this.Refresh();
            }
        }

        private string ejeY = "Eje Y";
        [Category("Valores")]
        [Description("Nombre del eje Y")]
        public string EjeY
        {
            get => ejeY;
            set
            {
                ejeY = value;
                this.Refresh();
            }
        }


        public Ejer4()
        {
            InitializeComponent();
        }

        SolidBrush p = new SolidBrush(Color.Green);
        SolidBrush pNegro = new SolidBrush(Color.Black);
        SolidBrush pRojo = new SolidBrush(Color.Red);

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics gs = this.CreateGraphics();

            //valores = new List<int>() { 30, 20, 10, 80, 50 };
            p.Color = Color.Yellow;
            try
            {
                if (!ajuste && tamaño > 20)
                    this.Height = tamaño;
                else
                    this.Height = valores.Max()+20;
                this.Width = 80 * valores.Count + 40;
            }
            catch (InvalidOperationException)
            {
                this.Width = 100;
                this.Height = 40;
            }
            for (int i = 0; i < valores.Count; i++)
            {
                switch (p.Color.Name)
                {
                    case "Green":
                        p.Color = Color.Blue;
                        break;
                    case "Blue":
                        p.Color = Color.Yellow;
                        break;
                    case "Yellow":
                        p.Color = Color.Green;
                        break;
                }
                if (!ajuste && tamaño > 20)
                    if (valores[i] >= tamaño)
                        gs.FillRectangle(pRojo, new Rectangle(80 * i + 35, this.Height - valores[i] - 20, 75, valores[i]));
                    else
                        gs.FillRectangle(p, new Rectangle(80 * i + 35, this.Height - valores[i] - 20, 75, valores[i]));
                else
                    gs.FillRectangle(p, new Rectangle(80 * i + 35, this.Height - valores[i] - 20, 75, valores[i]));
            }

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            gs.DrawString(ejeX, this.Font, pNegro, this.Width / 2, this.Height - 10, sf);
            //Rotar
            gs.TranslateTransform(20, 0);
            gs.RotateTransform(90);
            gs.DrawString(ejeY, this.Font, pNegro, this.Height / 2, 0, sf);
            gs.ResetTransform();
        }
    }
}
