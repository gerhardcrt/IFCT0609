
namespace M3_13_BackGroundWorker
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
            this.btnTareaPesada = new System.Windows.Forms.Button();
            this.btnSaludo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesadaSegundoPlano = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnTareaPesada
            // 
            this.btnTareaPesada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareaPesada.Location = new System.Drawing.Point(99, 213);
            this.btnTareaPesada.Name = "btnTareaPesada";
            this.btnTareaPesada.Size = new System.Drawing.Size(230, 160);
            this.btnTareaPesada.TabIndex = 0;
            this.btnTareaPesada.Text = "Tarea Pesada";
            this.btnTareaPesada.UseVisualStyleBackColor = true;
            this.btnTareaPesada.Click += new System.EventHandler(this.btnTareaPesada_Click);
            // 
            // btnSaludo
            // 
            this.btnSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaludo.Location = new System.Drawing.Point(432, 213);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(230, 160);
            this.btnSaludo.TabIndex = 1;
            this.btnSaludo.Text = "Saludo";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnPesadaSegundoPlano
            // 
            this.btnPesadaSegundoPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesadaSegundoPlano.Location = new System.Drawing.Point(99, 427);
            this.btnPesadaSegundoPlano.Name = "btnPesadaSegundoPlano";
            this.btnPesadaSegundoPlano.Size = new System.Drawing.Size(230, 196);
            this.btnPesadaSegundoPlano.TabIndex = 3;
            this.btnPesadaSegundoPlano.Text = "Tarea Pesada 2º Plano";
            this.btnPesadaSegundoPlano.UseVisualStyleBackColor = true;
            this.btnPesadaSegundoPlano.Click += new System.EventHandler(this.btnPesadaSegundoPlano_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 718);
            this.Controls.Add(this.btnPesadaSegundoPlano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaludo);
            this.Controls.Add(this.btnTareaPesada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTareaPesada;
        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesadaSegundoPlano;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

