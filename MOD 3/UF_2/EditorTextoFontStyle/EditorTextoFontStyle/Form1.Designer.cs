
namespace EditorTextoFontStyle
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
            this.rtbContenido = new System.Windows.Forms.RichTextBox();
            this.btnAumentarFuente = new System.Windows.Forms.Button();
            this.btnDisminuirFuente = new System.Windows.Forms.Button();
            this.nudTamanhoFuente = new System.Windows.Forms.NumericUpDown();
            this.btnNegrita = new System.Windows.Forms.Button();
            this.btnCursiva = new System.Windows.Forms.Button();
            this.btnSubrayado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanhoFuente)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbContenido
            // 
            this.rtbContenido.HideSelection = false;
            this.rtbContenido.Location = new System.Drawing.Point(75, 122);
            this.rtbContenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbContenido.Name = "rtbContenido";
            this.rtbContenido.Size = new System.Drawing.Size(1228, 533);
            this.rtbContenido.TabIndex = 0;
            this.rtbContenido.Text = "";
            this.rtbContenido.SelectionChanged += new System.EventHandler(this.rtbContenido_SelectionChanged);
            // 
            // btnAumentarFuente
            // 
            this.btnAumentarFuente.Location = new System.Drawing.Point(155, 43);
            this.btnAumentarFuente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAumentarFuente.Name = "btnAumentarFuente";
            this.btnAumentarFuente.Size = new System.Drawing.Size(75, 60);
            this.btnAumentarFuente.TabIndex = 1;
            this.btnAumentarFuente.Text = "+";
            this.btnAumentarFuente.UseVisualStyleBackColor = true;
            this.btnAumentarFuente.Click += new System.EventHandler(this.btnAumentarFuente_Click);
            // 
            // btnDisminuirFuente
            // 
            this.btnDisminuirFuente.AutoSize = true;
            this.btnDisminuirFuente.Location = new System.Drawing.Point(75, 43);
            this.btnDisminuirFuente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisminuirFuente.Name = "btnDisminuirFuente";
            this.btnDisminuirFuente.Size = new System.Drawing.Size(75, 60);
            this.btnDisminuirFuente.TabIndex = 2;
            this.btnDisminuirFuente.Text = "-";
            this.btnDisminuirFuente.UseVisualStyleBackColor = true;
            this.btnDisminuirFuente.Click += new System.EventHandler(this.btnDisminuirFuente_Click);
            // 
            // nudTamanhoFuente
            // 
            this.nudTamanhoFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTamanhoFuente.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudTamanhoFuente.Location = new System.Drawing.Point(248, 41);
            this.nudTamanhoFuente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudTamanhoFuente.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudTamanhoFuente.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudTamanhoFuente.Name = "nudTamanhoFuente";
            this.nudTamanhoFuente.Size = new System.Drawing.Size(123, 39);
            this.nudTamanhoFuente.TabIndex = 4;
            this.nudTamanhoFuente.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudTamanhoFuente.ValueChanged += new System.EventHandler(this.nudTamanhoFuente_ValueChanged);
            // 
            // btnNegrita
            // 
            this.btnNegrita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegrita.Location = new System.Drawing.Point(427, 26);
            this.btnNegrita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNegrita.Name = "btnNegrita";
            this.btnNegrita.Size = new System.Drawing.Size(75, 74);
            this.btnNegrita.TabIndex = 5;
            this.btnNegrita.Text = "N";
            this.btnNegrita.UseVisualStyleBackColor = true;
            this.btnNegrita.Click += new System.EventHandler(this.CambiarEstilo);
            // 
            // btnCursiva
            // 
            this.btnCursiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursiva.Location = new System.Drawing.Point(552, 29);
            this.btnCursiva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCursiva.Name = "btnCursiva";
            this.btnCursiva.Size = new System.Drawing.Size(75, 74);
            this.btnCursiva.TabIndex = 6;
            this.btnCursiva.Text = "C";
            this.btnCursiva.UseVisualStyleBackColor = true;
            this.btnCursiva.Click += new System.EventHandler(this.CambiarEstilo);
            // 
            // btnSubrayado
            // 
            this.btnSubrayado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubrayado.Location = new System.Drawing.Point(685, 29);
            this.btnSubrayado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubrayado.Name = "btnSubrayado";
            this.btnSubrayado.Size = new System.Drawing.Size(75, 74);
            this.btnSubrayado.TabIndex = 7;
            this.btnSubrayado.Text = "S";
            this.btnSubrayado.UseVisualStyleBackColor = true;
            this.btnSubrayado.Click += new System.EventHandler(this.CambiarEstilo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 739);
            this.Controls.Add(this.btnSubrayado);
            this.Controls.Add(this.btnCursiva);
            this.Controls.Add(this.btnNegrita);
            this.Controls.Add(this.nudTamanhoFuente);
            this.Controls.Add(this.btnDisminuirFuente);
            this.Controls.Add(this.btnAumentarFuente);
            this.Controls.Add(this.rtbContenido);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanhoFuente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbContenido;
        private System.Windows.Forms.Button btnAumentarFuente;
        private System.Windows.Forms.Button btnDisminuirFuente;
        private System.Windows.Forms.NumericUpDown nudTamanhoFuente;
        private System.Windows.Forms.Button btnNegrita;
        private System.Windows.Forms.Button btnCursiva;
        private System.Windows.Forms.Button btnSubrayado;
    }
}

