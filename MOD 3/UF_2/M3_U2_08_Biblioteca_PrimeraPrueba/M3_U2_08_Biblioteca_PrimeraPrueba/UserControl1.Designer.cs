namespace M3_U2_08_Biblioteca_PrimeraPrueba
{
    partial class CaluladoraBasicaVerde
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbSumar = new System.Windows.Forms.RadioButton();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labResultado = new System.Windows.Forms.Label();
            this.rbRestar = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero1.Location = new System.Drawing.Point(252, 47);
            this.txtNumero1.MaxLength = 3;
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(184, 53);
            this.txtNumero1.TabIndex = 0;
            this.txtNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumero1.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(400, 235);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(302, 128);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rbSumar
            // 
            this.rbSumar.AutoSize = true;
            this.rbSumar.Checked = true;
            this.rbSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSumar.Location = new System.Drawing.Point(86, 235);
            this.rbSumar.Name = "rbSumar";
            this.rbSumar.Size = new System.Drawing.Size(80, 50);
            this.rbSumar.TabIndex = 2;
            this.rbSumar.TabStop = true;
            this.rbSumar.Text = "+";
            this.rbSumar.UseVisualStyleBackColor = true;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.Location = new System.Drawing.Point(252, 119);
            this.txtNumero2.MaxLength = 3;
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(184, 53);
            this.txtNumero2.TabIndex = 1;
            this.txtNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumero2.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "número 2";
            // 
            // labResultado
            // 
            this.labResultado.AutoSize = true;
            this.labResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResultado.Location = new System.Drawing.Point(500, 88);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(184, 46);
            this.labResultado.TabIndex = 6;
            this.labResultado.Text = "resultado";
            // 
            // rbRestar
            // 
            this.rbRestar.AutoSize = true;
            this.rbRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRestar.Location = new System.Drawing.Point(86, 304);
            this.rbRestar.Name = "rbRestar";
            this.rbRestar.Size = new System.Drawing.Size(70, 50);
            this.rbRestar.TabIndex = 3;
            this.rbRestar.Text = "-";
            this.rbRestar.UseVisualStyleBackColor = true;
            // 
            // CaluladoraBasicaVerde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.rbRestar);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.rbSumar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumero1);
            this.Name = "CaluladoraBasicaVerde";
            this.Size = new System.Drawing.Size(765, 423);
            this.Load += new System.EventHandler(this.CaluladoraBasica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rbSumar;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labResultado;
        private System.Windows.Forms.RadioButton rbRestar;

       }
}
