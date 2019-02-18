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
        private List<int> valores;
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


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            SolidBrush p = new SolidBrush(Color.Green);
            SolidBrush pNegro = new SolidBrush(Color.Black);
            Graphics gs = this.CreateGraphics();

            valores = new List<int>() { 30, 20, 10, 60, 50 };
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
                gs.FillRectangle(p, new Rectangle(80 * i+50, this.Height - valores[i], 80, this.Height - 20));
            }
            this.Width = 80 * valores.Count+30;
            this.Height = valores.Max() + 50;

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            gs.DrawString(ejeX, this.Font, pNegro, this.Width / 2, this.Height - 10, sf);
            //Rotar
            gs.TranslateTransform(20,0);
            gs.RotateTransform(90);
            gs.DrawString(ejeY, this.Font, pNegro, this.Height/2, 0,sf);
            gs.ResetTransform();
        }
    }
}
