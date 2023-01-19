
namespace M3_U2_09_UsadoMiControlPrimeraPrueba
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
            this.caluladoraBasicaVerde1 = new M3_U2_08_Biblioteca_PrimeraPrueba.CaluladoraBasicaVerde();
            this.SuspendLayout();
            // 
            // caluladoraBasicaVerde1
            // 
            this.caluladoraBasicaVerde1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.caluladoraBasicaVerde1.Location = new System.Drawing.Point(309, 197);
            this.caluladoraBasicaVerde1.Name = "caluladoraBasicaVerde1";
            this.caluladoraBasicaVerde1.Size = new System.Drawing.Size(765, 423);
            this.caluladoraBasicaVerde1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 1014);
            this.Controls.Add(this.caluladoraBasicaVerde1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private M3_U2_08_Biblioteca_PrimeraPrueba.CaluladoraBasicaVerde caluladoraBasicaVerde1;
    }
}

