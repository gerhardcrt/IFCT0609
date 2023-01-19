
namespace EG04_CheckBox
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
            this.ckbIngles = new System.Windows.Forms.CheckBox();
            this.ckbEspanhol = new System.Windows.Forms.CheckBox();
            this.ckbGalego = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProcesar2 = new System.Windows.Forms.Button();
            this.btnProcesar3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbIngles
            // 
            this.ckbIngles.AutoSize = true;
            this.ckbIngles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbIngles.Location = new System.Drawing.Point(29, 33);
            this.ckbIngles.Name = "ckbIngles";
            this.ckbIngles.Size = new System.Drawing.Size(127, 41);
            this.ckbIngles.TabIndex = 0;
            this.ckbIngles.Text = "Inglés";
            this.ckbIngles.UseVisualStyleBackColor = true;
            // 
            // ckbEspanhol
            // 
            this.ckbEspanhol.AutoSize = true;
            this.ckbEspanhol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEspanhol.Location = new System.Drawing.Point(29, 77);
            this.ckbEspanhol.Name = "ckbEspanhol";
            this.ckbEspanhol.Size = new System.Drawing.Size(159, 41);
            this.ckbEspanhol.TabIndex = 1;
            this.ckbEspanhol.Text = "Español";
            this.ckbEspanhol.UseVisualStyleBackColor = true;
            // 
            // ckbGalego
            // 
            this.ckbGalego.AutoSize = true;
            this.ckbGalego.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGalego.Location = new System.Drawing.Point(29, 122);
            this.ckbGalego.Name = "ckbGalego";
            this.ckbGalego.Size = new System.Drawing.Size(146, 41);
            this.ckbGalego.TabIndex = 2;
            this.ckbGalego.Text = "Galego";
            this.ckbGalego.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(364, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(344, 44);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(364, 181);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(169, 74);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbEspanhol);
            this.groupBox1.Controls.Add(this.ckbIngles);
            this.groupBox1.Controls.Add(this.ckbGalego);
            this.groupBox1.Location = new System.Drawing.Point(37, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 188);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Idiomas";
            // 
            // btnProcesar2
            // 
            this.btnProcesar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar2.Location = new System.Drawing.Point(539, 181);
            this.btnProcesar2.Name = "btnProcesar2";
            this.btnProcesar2.Size = new System.Drawing.Size(169, 74);
            this.btnProcesar2.TabIndex = 7;
            this.btnProcesar2.Text = "Procesar";
            this.btnProcesar2.UseVisualStyleBackColor = true;
            this.btnProcesar2.Click += new System.EventHandler(this.btnProcesar2_Click);
            // 
            // btnProcesar3
            // 
            this.btnProcesar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar3.Location = new System.Drawing.Point(539, 261);
            this.btnProcesar3.Name = "btnProcesar3";
            this.btnProcesar3.Size = new System.Drawing.Size(169, 74);
            this.btnProcesar3.TabIndex = 8;
            this.btnProcesar3.Text = "Procesar";
            this.btnProcesar3.UseVisualStyleBackColor = true;
            this.btnProcesar3.Click += new System.EventHandler(this.btnProcesar3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 364);
            this.Controls.Add(this.btnProcesar3);
            this.Controls.Add(this.btnProcesar2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbIngles;
        private System.Windows.Forms.CheckBox ckbEspanhol;
        private System.Windows.Forms.CheckBox ckbGalego;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProcesar2;
        private System.Windows.Forms.Button btnProcesar3;
    }
}

