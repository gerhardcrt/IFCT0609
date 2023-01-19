
namespace M3_19_PasoPorReferenciayPorValor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtContingeciasComunes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesempleo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFogasa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFormacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(497, 355);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(213, 83);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salario Bruto";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBruto.Location = new System.Drawing.Point(527, 71);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(183, 39);
            this.txtSalarioBruto.TabIndex = 2;
            this.txtSalarioBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtContingeciasComunes
            // 
            this.txtContingeciasComunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContingeciasComunes.Location = new System.Drawing.Point(527, 123);
            this.txtContingeciasComunes.Name = "txtContingeciasComunes";
            this.txtContingeciasComunes.Size = new System.Drawing.Size(183, 39);
            this.txtContingeciasComunes.TabIndex = 4;
            this.txtContingeciasComunes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contingencias Comunes 23,6%";
            // 
            // txtDesempleo
            // 
            this.txtDesempleo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesempleo.Location = new System.Drawing.Point(527, 172);
            this.txtDesempleo.Name = "txtDesempleo";
            this.txtDesempleo.Size = new System.Drawing.Size(183, 39);
            this.txtDesempleo.TabIndex = 6;
            this.txtDesempleo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desempleo 5,5%";
            // 
            // txtFogasa
            // 
            this.txtFogasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFogasa.Location = new System.Drawing.Point(527, 223);
            this.txtFogasa.Name = "txtFogasa";
            this.txtFogasa.Size = new System.Drawing.Size(183, 39);
            this.txtFogasa.TabIndex = 8;
            this.txtFogasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fogasa 0,2%";
            // 
            // txtFormacion
            // 
            this.txtFormacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormacion.Location = new System.Drawing.Point(527, 282);
            this.txtFormacion.Name = "txtFormacion";
            this.txtFormacion.Size = new System.Drawing.Size(183, 39);
            this.txtFormacion.TabIndex = 10;
            this.txtFormacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Formacion 0,6%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 491);
            this.Controls.Add(this.txtFormacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFogasa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDesempleo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContingeciasComunes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.TextBox txtContingeciasComunes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesempleo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFogasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFormacion;
        private System.Windows.Forms.Label label5;
    }
}

