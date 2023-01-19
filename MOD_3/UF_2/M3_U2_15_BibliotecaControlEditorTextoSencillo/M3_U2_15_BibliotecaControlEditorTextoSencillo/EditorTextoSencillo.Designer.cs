namespace M3_U2_15_BibliotecaControlEditorTextoSencillo
{
    partial class EditorTextoSencillo
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
            this.rtbContenido = new System.Windows.Forms.RichTextBox();
            this.btnColorFuente = new System.Windows.Forms.Button();
            this.btnCursiva = new System.Windows.Forms.Button();
            this.btnSubrayado = new System.Windows.Forms.Button();
            this.btnNegrita = new System.Windows.Forms.Button();
            this.nudTamanhoFuente = new System.Windows.Forms.NumericUpDown();
            this.btnDisminuirFuente = new System.Windows.Forms.Button();
            this.btnAumentarFuente = new System.Windows.Forms.Button();
            this.cdColorFuente = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanhoFuente)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbContenido
            // 
            this.rtbContenido.Location = new System.Drawing.Point(38, 133);
            this.rtbContenido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbContenido.Name = "rtbContenido";
            this.rtbContenido.Size = new System.Drawing.Size(1271, 371);
            this.rtbContenido.TabIndex = 1;
            this.rtbContenido.Text = "";
            // 
            // btnColorFuente
            // 
            this.btnColorFuente.Location = new System.Drawing.Point(733, 22);
            this.btnColorFuente.Margin = new System.Windows.Forms.Padding(5);
            this.btnColorFuente.Name = "btnColorFuente";
            this.btnColorFuente.Size = new System.Drawing.Size(149, 74);
            this.btnColorFuente.TabIndex = 15;
            this.btnColorFuente.UseVisualStyleBackColor = true;
            this.btnColorFuente.Click += new System.EventHandler(this.btnColorFuente_Click);
            // 
            // btnCursiva
            // 
            this.btnCursiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursiva.Location = new System.Drawing.Point(502, 22);
            this.btnCursiva.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCursiva.Name = "btnCursiva";
            this.btnCursiva.Size = new System.Drawing.Size(75, 74);
            this.btnCursiva.TabIndex = 14;
            this.btnCursiva.Text = "k";
            this.btnCursiva.UseVisualStyleBackColor = true;
            this.btnCursiva.Click += new System.EventHandler(this.btnNegrita_Cursiva_Subrayado_Click);
            // 
            // btnSubrayado
            // 
            this.btnSubrayado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubrayado.Location = new System.Drawing.Point(612, 22);
            this.btnSubrayado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubrayado.Name = "btnSubrayado";
            this.btnSubrayado.Size = new System.Drawing.Size(75, 74);
            this.btnSubrayado.TabIndex = 13;
            this.btnSubrayado.Text = "s";
            this.btnSubrayado.UseVisualStyleBackColor = true;
            this.btnSubrayado.Click += new System.EventHandler(this.btnNegrita_Cursiva_Subrayado_Click);
            // 
            // btnNegrita
            // 
            this.btnNegrita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegrita.Location = new System.Drawing.Point(390, 22);
            this.btnNegrita.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNegrita.Name = "btnNegrita";
            this.btnNegrita.Size = new System.Drawing.Size(75, 74);
            this.btnNegrita.TabIndex = 12;
            this.btnNegrita.Text = "n";
            this.btnNegrita.UseVisualStyleBackColor = true;
            this.btnNegrita.Click += new System.EventHandler(this.btnNegrita_Cursiva_Subrayado_Click);
            // 
            // nudTamanhoFuente
            // 
            this.nudTamanhoFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTamanhoFuente.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudTamanhoFuente.Location = new System.Drawing.Point(229, 58);
            this.nudTamanhoFuente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudTamanhoFuente.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudTamanhoFuente.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudTamanhoFuente.Name = "nudTamanhoFuente";
            this.nudTamanhoFuente.Size = new System.Drawing.Size(124, 39);
            this.nudTamanhoFuente.TabIndex = 11;
            this.nudTamanhoFuente.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudTamanhoFuente.ValueChanged += new System.EventHandler(this.nudTamanhoFuente_ValueChanged);
            // 
            // btnDisminuirFuente
            // 
            this.btnDisminuirFuente.AutoSize = true;
            this.btnDisminuirFuente.Location = new System.Drawing.Point(38, 38);
            this.btnDisminuirFuente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDisminuirFuente.Name = "btnDisminuirFuente";
            this.btnDisminuirFuente.Size = new System.Drawing.Size(75, 59);
            this.btnDisminuirFuente.TabIndex = 10;
            this.btnDisminuirFuente.Text = "-";
            this.btnDisminuirFuente.UseVisualStyleBackColor = true;
            this.btnDisminuirFuente.Click += new System.EventHandler(this.btnDisminuirFuente_Click);
            // 
            // btnAumentarFuente
            // 
            this.btnAumentarFuente.Location = new System.Drawing.Point(118, 38);
            this.btnAumentarFuente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAumentarFuente.Name = "btnAumentarFuente";
            this.btnAumentarFuente.Size = new System.Drawing.Size(75, 59);
            this.btnAumentarFuente.TabIndex = 9;
            this.btnAumentarFuente.Text = "+";
            this.btnAumentarFuente.UseVisualStyleBackColor = true;
            this.btnAumentarFuente.Click += new System.EventHandler(this.btnAumentarFuente_Click);
            // 
            // EditorTextoSencillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnColorFuente);
            this.Controls.Add(this.btnCursiva);
            this.Controls.Add(this.btnSubrayado);
            this.Controls.Add(this.btnNegrita);
            this.Controls.Add(this.nudTamanhoFuente);
            this.Controls.Add(this.btnDisminuirFuente);
            this.Controls.Add(this.btnAumentarFuente);
            this.Controls.Add(this.rtbContenido);
            this.Name = "EditorTextoSencillo";
            this.Size = new System.Drawing.Size(1376, 567);
            this.Load += new System.EventHandler(this.EditorTextoSencillo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanhoFuente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbContenido;
        private System.Windows.Forms.Button btnColorFuente;
        private System.Windows.Forms.Button btnCursiva;
        private System.Windows.Forms.Button btnSubrayado;
        private System.Windows.Forms.Button btnNegrita;
        private System.Windows.Forms.NumericUpDown nudTamanhoFuente;
        private System.Windows.Forms.Button btnDisminuirFuente;
        private System.Windows.Forms.Button btnAumentarFuente;
        private System.Windows.Forms.ColorDialog cdColorFuente;
    }
}
