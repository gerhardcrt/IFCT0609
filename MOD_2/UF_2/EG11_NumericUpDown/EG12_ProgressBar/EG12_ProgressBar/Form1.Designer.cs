
namespace EG12_ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMasStep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(108, 67);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1243, 76);
            this.progressBar1.Step = 20;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnMas
            // 
            this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.Location = new System.Drawing.Point(1131, 166);
            this.btnMas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(220, 102);
            this.btnMas.TabIndex = 1;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(108, 166);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(220, 102);
            this.btnMenos.TabIndex = 2;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMasStep
            // 
            this.btnMasStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasStep.Location = new System.Drawing.Point(1062, 298);
            this.btnMasStep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMasStep.Name = "btnMasStep";
            this.btnMasStep.Size = new System.Drawing.Size(289, 102);
            this.btnMasStep.TabIndex = 4;
            this.btnMasStep.Text = "(+) step";
            this.btnMasStep.UseVisualStyleBackColor = true;
            this.btnMasStep.Click += new System.EventHandler(this.btnMasStep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 449);
            this.Controls.Add(this.btnMasStep);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.progressBar1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMasStep;
    }
}

