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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.ejer41 = new Componentes.Ejer4();
            this.ahorcado = new Componentes.Ejer3();
            this.componente2 = new Componentes.Ejer2();
            this.ejer11 = new Componentes.Ejer1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 464);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(805, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 81);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seleccionar imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(818, 107);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 4;
            // 
            // ejer41
            // 
            this.ejer41.Ajuste = true;
            this.ejer41.EjeX = "Eje X";
            this.ejer41.EjeY = "Eje Y";
            this.ejer41.Location = new System.Drawing.Point(856, 363);
            this.ejer41.Name = "ejer41";
            this.ejer41.Size = new System.Drawing.Size(360, 320);
            this.ejer41.TabIndex = 7;
            this.ejer41.Tamaño = 80;
            this.ejer41.Text = "ejer41";
            this.ejer41.Valores = ((System.Collections.Generic.List<int>)(resources.GetObject("ejer41.Valores")));
            // 
            // ahorcado
            // 
            this.ahorcado.Errores = 4;
            this.ahorcado.Location = new System.Drawing.Point(905, 148);
            this.ahorcado.Name = "ahorcado";
            this.ahorcado.Size = new System.Drawing.Size(217, 193);
            this.ahorcado.TabIndex = 6;
            this.ahorcado.CambiaError += new System.EventHandler(this.ahorcado_CambiaError);
            this.ahorcado.Ahorcado += new System.EventHandler(this.ahorcado_Ahorcado);
            this.ahorcado.Click += new System.EventHandler(this.ejer31_Click);
            // 
            // componente2
            // 
            this.componente2.Funcionando = true;
            this.componente2.Location = new System.Drawing.Point(969, 12);
            this.componente2.Name = "componente2";
            this.componente2.Size = new System.Drawing.Size(201, 89);
            this.componente2.TabIndex = 5;
            this.componente2.XX = 3;
            this.componente2.YY = 57;
            this.componente2.DesbordaTiempo += new System.EventHandler(this.componente2_DesbordaTiempo);
            this.componente2.StartPause += new System.EventHandler(this.ejer21_StartPause);
            // 
            // ejer11
            // 
            this.ejer11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejer11.GradienteColor1 = System.Drawing.Color.Violet;
            this.ejer11.GradienteColor2 = System.Drawing.Color.Peru;
            this.ejer11.GradienteOpc = true;
            this.ejer11.ImagenMarca = global::Componentes.Properties.Resources.MenuPrincipal;
            this.ejer11.Location = new System.Drawing.Point(12, 613);
            this.ejer11.Marca = Componentes.Ejer1.eMarca.Imagen;
            this.ejer11.Name = "ejer11";
            this.ejer11.Size = new System.Drawing.Size(459, 82);
            this.ejer11.TabIndex = 0;
            this.ejer11.Text = "ejer11pppppppppppp";
            this.ejer11.ClickEnMarca += new System.EventHandler(this.ejer11_ClickEnMarca);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 707);
            this.Controls.Add(this.ejer41);
            this.Controls.Add(this.ahorcado);
            this.Controls.Add(this.componente2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ejer11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ejer1 ejer11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblError;
        private Ejer2 componente2;
        private Ejer3 ahorcado;
        private Ejer4 ejer41;
    }
}

