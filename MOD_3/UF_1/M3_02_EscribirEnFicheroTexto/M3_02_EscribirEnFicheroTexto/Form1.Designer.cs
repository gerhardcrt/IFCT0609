
namespace M3_02_EscribirEnFicheroTexto
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
            this.btnEscribirLinea = new System.Windows.Forms.Button();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtTextoHTML = new System.Windows.Forms.TextBox();
            this.btnEscribir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEscribirLinea
            // 
            this.btnEscribirLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscribirLinea.Location = new System.Drawing.Point(436, 66);
            this.btnEscribirLinea.Name = "btnEscribirLinea";
            this.btnEscribirLinea.Size = new System.Drawing.Size(253, 65);
            this.btnEscribirLinea.TabIndex = 0;
            this.btnEscribirLinea.Text = "Escribir";
            this.btnEscribirLinea.UseVisualStyleBackColor = true;
            this.btnEscribirLinea.Click += new System.EventHandler(this.btnEscribirLinea_Click);
            // 
            // txtLinea
            // 
            this.txtLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinea.Location = new System.Drawing.Point(41, 66);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(326, 48);
            this.txtLinea.TabIndex = 1;
            // 
            // txtTextoHTML
            // 
            this.txtTextoHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoHTML.Location = new System.Drawing.Point(41, 220);
            this.txtTextoHTML.Multiline = true;
            this.txtTextoHTML.Name = "txtTextoHTML";
            this.txtTextoHTML.Size = new System.Drawing.Size(326, 239);
            this.txtTextoHTML.TabIndex = 3;
            // 
            // btnEscribir2
            // 
            this.btnEscribir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscribir2.Location = new System.Drawing.Point(436, 220);
            this.btnEscribir2.Name = "btnEscribir2";
            this.btnEscribir2.Size = new System.Drawing.Size(253, 65);
            this.btnEscribir2.TabIndex = 2;
            this.btnEscribir2.Text = "Escribir";
            this.btnEscribir2.UseVisualStyleBackColor = true;
            this.btnEscribir2.Click += new System.EventHandler(this.btnEscribir2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.txtTextoHTML);
            this.Controls.Add(this.btnEscribir2);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.btnEscribirLinea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscribirLinea;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.TextBox txtTextoHTML;
        private System.Windows.Forms.Button btnEscribir2;
    }
}

