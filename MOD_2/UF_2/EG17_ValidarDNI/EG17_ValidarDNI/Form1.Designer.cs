
namespace EG17_ValidarDNI
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNumeroDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLetraDNI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(47, 114);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(193, 118);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular Letra";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNumeroDNI
            // 
            this.txtNumeroDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDNI.Location = new System.Drawing.Point(271, 41);
            this.txtNumeroDNI.MaxLength = 8;
            this.txtNumeroDNI.Name = "txtNumeroDNI";
            this.txtNumeroDNI.Size = new System.Drawing.Size(176, 48);
            this.txtNumeroDNI.TabIndex = 1;
            this.txtNumeroDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número DNI:";
            // 
            // lbLetraDNI
            // 
            this.lbLetraDNI.AutoSize = true;
            this.lbLetraDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLetraDNI.Location = new System.Drawing.Point(341, 143);
            this.lbLetraDNI.Name = "lbLetraDNI";
            this.lbLetraDNI.Size = new System.Drawing.Size(41, 40);
            this.lbLetraDNI.TabIndex = 3;
            this.lbLetraDNI.Text = "A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 271);
            this.Controls.Add(this.lbLetraDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroDNI);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNumeroDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLetraDNI;
    }
}

