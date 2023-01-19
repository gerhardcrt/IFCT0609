
namespace EG11_NumericUpDown
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
            this.nudDia = new System.Windows.Forms.NumericUpDown();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.nudAnho = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnho)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDia
            // 
            this.nudDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDia.Location = new System.Drawing.Point(123, 96);
            this.nudDia.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudDia.Name = "nudDia";
            this.nudDia.Size = new System.Drawing.Size(120, 48);
            this.nudDia.TabIndex = 0;
            this.nudDia.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nudMes
            // 
            this.nudMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMes.Location = new System.Drawing.Point(307, 96);
            this.nudMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMes.Name = "nudMes";
            this.nudMes.Size = new System.Drawing.Size(120, 48);
            this.nudMes.TabIndex = 2;
            this.nudMes.ValueChanged += new System.EventHandler(this.nudMes_ValueChanged);
            // 
            // nudAnho
            // 
            this.nudAnho.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAnho.Location = new System.Drawing.Point(473, 96);
            this.nudAnho.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudAnho.Name = "nudAnho";
            this.nudAnho.Size = new System.Drawing.Size(120, 48);
            this.nudAnho.TabIndex = 3;
            this.nudAnho.ValueChanged += new System.EventHandler(this.nudAnho_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "año";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "mes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudAnho);
            this.Controls.Add(this.nudMes);
            this.Controls.Add(this.nudDia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDia;
        private System.Windows.Forms.NumericUpDown nudMes;
        private System.Windows.Forms.NumericUpDown nudAnho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

