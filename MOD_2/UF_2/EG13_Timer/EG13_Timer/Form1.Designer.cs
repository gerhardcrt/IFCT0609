
namespace EG13_Timer
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnIrFinal = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(81, 114);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1466, 119);
            this.progressBar1.TabIndex = 0;
            // 
            // btnIrFinal
            // 
            this.btnIrFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrFinal.Location = new System.Drawing.Point(81, 279);
            this.btnIrFinal.Name = "btnIrFinal";
            this.btnIrFinal.Size = new System.Drawing.Size(332, 118);
            this.btnIrFinal.TabIndex = 1;
            this.btnIrFinal.Text = "Hasta el Fin";
            this.btnIrFinal.UseVisualStyleBackColor = true;
            this.btnIrFinal.Click += new System.EventHandler(this.btnIrFinal_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTimer
            // 
            this.btnTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.Location = new System.Drawing.Point(81, 421);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(332, 118);
            this.btnTimer.TabIndex = 2;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            this.btnTimer.MouseLeave += new System.EventHandler(this.CambiarColor2);
            this.btnTimer.MouseHover += new System.EventHandler(this.CambiarColor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 626);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnIrFinal);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnIrFinal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTimer;
    }
}

