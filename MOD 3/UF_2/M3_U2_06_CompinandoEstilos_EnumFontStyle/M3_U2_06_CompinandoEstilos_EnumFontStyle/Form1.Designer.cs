
namespace M3_U2_06_CompinandoEstilos_EnumFontStyle
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
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.btnNegrita = new System.Windows.Forms.Button();
            this.btnCursiva = new System.Windows.Forms.Button();
            this.btnSubrayado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(56, 125);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(689, 286);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = "";
            // 
            // btnNegrita
            // 
            this.btnNegrita.Location = new System.Drawing.Point(56, 28);
            this.btnNegrita.Name = "btnNegrita";
            this.btnNegrita.Size = new System.Drawing.Size(92, 79);
            this.btnNegrita.TabIndex = 1;
            this.btnNegrita.Text = "button1";
            this.btnNegrita.UseVisualStyleBackColor = true;
            this.btnNegrita.Click += new System.EventHandler(this.CambiarEstilo);
            // 
            // btnCursiva
            // 
            this.btnCursiva.Location = new System.Drawing.Point(167, 28);
            this.btnCursiva.Name = "btnCursiva";
            this.btnCursiva.Size = new System.Drawing.Size(92, 79);
            this.btnCursiva.TabIndex = 2;
            this.btnCursiva.Text = "button2";
            this.btnCursiva.UseVisualStyleBackColor = true;
            this.btnCursiva.Click += new System.EventHandler(this.CambiarEstilo);
            // 
            // btnSubrayado
            // 
            this.btnSubrayado.Location = new System.Drawing.Point(276, 28);
            this.btnSubrayado.Name = "btnSubrayado";
            this.btnSubrayado.Size = new System.Drawing.Size(92, 79);
            this.btnSubrayado.TabIndex = 3;
            this.btnSubrayado.Text = "button3";
            this.btnSubrayado.UseVisualStyleBackColor = true;
            this.btnSubrayado.Click += new System.EventHandler(this.CambiarEstilo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubrayado);
            this.Controls.Add(this.btnCursiva);
            this.Controls.Add(this.btnNegrita);
            this.Controls.Add(this.rtbTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.Button btnNegrita;
        private System.Windows.Forms.Button btnCursiva;
        private System.Windows.Forms.Button btnSubrayado;
    }
}

