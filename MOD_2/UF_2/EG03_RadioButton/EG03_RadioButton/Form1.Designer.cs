
namespace EG03_RadioButton
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
            this.rbSumar = new System.Windows.Forms.RadioButton();
            this.rbRestar = new System.Windows.Forms.RadioButton();
            this.rbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbDividir = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbDesactivar = new System.Windows.Forms.RadioButton();
            this.rbActivar = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSumar
            // 
            this.rbSumar.AutoSize = true;
            this.rbSumar.Checked = true;
            this.rbSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSumar.Location = new System.Drawing.Point(68, 22);
            this.rbSumar.Name = "rbSumar";
            this.rbSumar.Size = new System.Drawing.Size(56, 36);
            this.rbSumar.TabIndex = 3;
            this.rbSumar.TabStop = true;
            this.rbSumar.Text = "+";
            this.rbSumar.UseVisualStyleBackColor = true;
            // 
            // rbRestar
            // 
            this.rbRestar.AutoSize = true;
            this.rbRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRestar.Location = new System.Drawing.Point(68, 61);
            this.rbRestar.Name = "rbRestar";
            this.rbRestar.Size = new System.Drawing.Size(49, 36);
            this.rbRestar.TabIndex = 4;
            this.rbRestar.Text = "-";
            this.rbRestar.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicar
            // 
            this.rbMultiplicar.AutoSize = true;
            this.rbMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultiplicar.Location = new System.Drawing.Point(68, 105);
            this.rbMultiplicar.Name = "rbMultiplicar";
            this.rbMultiplicar.Size = new System.Drawing.Size(54, 36);
            this.rbMultiplicar.TabIndex = 5;
            this.rbMultiplicar.Text = "x";
            this.rbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbDividir
            // 
            this.rbDividir.AutoSize = true;
            this.rbDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDividir.Location = new System.Drawing.Point(68, 150);
            this.rbDividir.Name = "rbDividir";
            this.rbDividir.Size = new System.Drawing.Size(48, 36);
            this.rbDividir.TabIndex = 6;
            this.rbDividir.Text = "/";
            this.rbDividir.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(56, 330);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(654, 74);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(529, 52);
            this.txtN1.MaxLength = 3;
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 39);
            this.txtN1.TabIndex = 0;
            this.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(529, 216);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 39);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtN2
            // 
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(529, 128);
            this.txtN2.MaxLength = 3;
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 39);
            this.txtN2.TabIndex = 1;
            this.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Número 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado";
            // 
            // rbDesactivar
            // 
            this.rbDesactivar.AutoSize = true;
            this.rbDesactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDesactivar.Location = new System.Drawing.Point(12, 52);
            this.rbDesactivar.Name = "rbDesactivar";
            this.rbDesactivar.Size = new System.Drawing.Size(170, 36);
            this.rbDesactivar.TabIndex = 1;
            this.rbDesactivar.Text = "desactivar";
            this.rbDesactivar.UseVisualStyleBackColor = true;
            // 
            // rbActivar
            // 
            this.rbActivar.AutoSize = true;
            this.rbActivar.Checked = true;
            this.rbActivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivar.Location = new System.Drawing.Point(12, 10);
            this.rbActivar.Name = "rbActivar";
            this.rbActivar.Size = new System.Drawing.Size(124, 36);
            this.rbActivar.TabIndex = 0;
            this.rbActivar.TabStop = true;
            this.rbActivar.Text = "activar";
            this.rbActivar.UseVisualStyleBackColor = true;
            this.rbActivar.CheckedChanged += new System.EventHandler(this.rbActivar_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.rbDesactivar);
            this.panel1.Controls.Add(this.rbActivar);
            this.panel1.Location = new System.Drawing.Point(56, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rbDividir);
            this.Controls.Add(this.rbMultiplicar);
            this.Controls.Add(this.rbRestar);
            this.Controls.Add(this.rbSumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSumar;
        private System.Windows.Forms.RadioButton rbRestar;
        private System.Windows.Forms.RadioButton rbMultiplicar;
        private System.Windows.Forms.RadioButton rbDividir;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbDesactivar;
        private System.Windows.Forms.RadioButton rbActivar;
        private System.Windows.Forms.Panel panel1;
    }
}

