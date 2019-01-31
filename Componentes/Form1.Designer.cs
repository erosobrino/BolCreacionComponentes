namespace Componentes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ejer11 = new Componentes.Ejer1();
            this.SuspendLayout();
            // 
            // ejer11
            // 
            this.ejer11.GradienteColor1 = System.Drawing.Color.Blue;
            this.ejer11.GradienteColor2 = System.Drawing.Color.Red;
            this.ejer11.GradienteOpc = true;
            this.ejer11.ImagenMarca = ((System.Drawing.Image)(resources.GetObject("ejer11.ImagenMarca")));
            this.ejer11.Location = new System.Drawing.Point(448, 86);
            this.ejer11.Marca = Componentes.Ejer1.eMarca.Imagen;
            this.ejer11.Name = "ejer11";
            this.ejer11.Size = new System.Drawing.Size(131, 52);
            this.ejer11.TabIndex = 0;
            this.ejer11.Text = "ejer11";
            this.ejer11.ClickEnMarca += new System.EventHandler(this.ejer11_ClickEnMarca);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 707);
            this.Controls.Add(this.ejer11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Ejer1 ejer11;
    }
}

