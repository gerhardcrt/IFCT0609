namespace M3_U2_20_ControlEditorTextoRedim
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnColorFuente = new System.Windows.Forms.Button();
            this.btnSubrayado = new System.Windows.Forms.Button();
            this.btnCursiva = new System.Windows.Forms.Button();
            this.btnNegrita = new System.Windows.Forms.Button();
            this.btnAumentarFuente = new System.Windows.Forms.Button();
            this.btnDisminuirFuente = new System.Windows.Forms.Button();
            this.nudTamanhoFuente = new System.Windows.Forms.NumericUpDown();
            this.rtbContenido = new System.Windows.Forms.RichTextBox();
            this.cdColorFuente = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanhoFuente)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel1.Controls.Add(this.btnColorFuente, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSubrayado, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCursiva, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNegrita, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAumentarFuente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDisminuirFuente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudTamanhoFuente, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbContenido, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.82033F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.17967F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(741, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnColorFuente
            // 
            this.btnColorFuente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnColorFuente.Location = new System.Drawing.Point(416, 3);
            this.btnColorFuente.Name = "btnColorFuente";
            this.btnColorFuente.Size = new System.Drawing.Size(49, 49);
            this.btnColorFuente.TabIndex = 15;
            this.btnColorFuente.UseVisualStyleBackColor = true;
            this.btnColorFuente.Click += new System.EventHandler(this.btnColorFuente_Click);
            // 
            // btnSubrayado
            // 
            this.btnSubrayado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubrayado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubrayado.Location = new System.Drawing.Point(334, 3);
            this.btnSubrayado.Name = "btnSubrayado";
            this.btnSubrayado.Size = new System.Drawing.Size(49, 49);
            this.btnSubrayado.TabIndex = 13;
            this.btnSubrayado.Text = "s";
            this.btnSubrayado.UseVisualStyleBackColor = true;
            this.btnSubrayado.Click += new System.EventHandler(this.btnNegrita_Cursiva_Subrayado_Click);
            // 
            // btnCursiva
            // 
            this.btnCursiva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCursiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursiva.Location = new System.Drawing.Point(279, 3);
            this.btnCursiva.Name = "btnCursiva";
            this.btnCursiva.Size = new System.Drawing.Size(49, 49);
            this.btnCursiva.TabIndex = 12;
            this.btnCursiva.Text = "k";
            this.btnCursiva.UseVisualStyleBackColor = true;
            this.btnCursiva.Click += new System.EventHandler(this.btnNegrita_Cursiva_Subrayado_Click);
            // 
            // btnNegrita
            // 
            this.btnNegrita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNegrita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegrita.Location = new System.Drawing.Point(224, 3);
            this.btnNegrita.Name = "btnNegrita";
            this.btnNegrita.Size = new System.Drawing.Size(49, 49);
            this.btnNegrita.TabIndex = 11;
            this.btnNegrita.Text = "n";
            this.btnNegrita.UseVisualStyleBackColor = true;
            this.btnNegrita.Click += new System.EventHandler(this.btnNegrita_Cursiva_Subrayado_Click);
            // 
            // btnAumentarFuente
            // 
            this.btnAumentarFuente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAumentarFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentarFuente.Location = new System.Drawing.Point(58, 3);
            this.btnAumentarFuente.Name = "btnAumentarFuente";
            this.btnAumentarFuente.Size = new System.Drawing.Size(49, 49);
            this.btnAumentarFuente.TabIndex = 1;
            this.btnAumentarFuente.Text = "+";
            this.btnAumentarFuente.UseVisualStyleBackColor = true;
            this.btnAumentarFuente.Click += new System.EventHandler(this.btnAumentarFuente_Click);
            // 
            // btnDisminuirFuente
            // 
            this.btnDisminuirFuente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisminuirFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisminuirFuente.Location = new System.Drawing.Point(3, 3);
            this.btnDisminuirFuente.Name = "btnDisminuirFuente";
            this.btnDisminuirFuente.Size = new System.Drawing.Size(49, 49);
            this.btnDisminuirFuente.TabIndex = 0;
            this.btnDisminuirFuente.Text = "-";
            this.btnDisminuirFuente.UseVisualStyleBackColor = true;
            this.btnDisminuirFuente.Click += new System.EventHandler(this.btnDisminuirFuente_Click);
            // 
            // nudTamanhoFuente
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.nudTamanhoFuente, 2);
            this.nudTamanhoFuente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nudTamanhoFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTamanhoFuente.Location = new System.Drawing.Point(113, 8);
            this.nudTamanhoFuente.Name = "nudTamanhoFuente";
            this.nudTamanhoFuente.Size = new System.Drawing.Size(76, 44);
            this.nudTamanhoFuente.TabIndex = 9;
            this.nudTamanhoFuente.ValueChanged += new System.EventHandler(this.nudTamanhoFuente_ValueChanged);
            // 
            // rtbContenido
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtbContenido, 11);
            this.rtbContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbContenido.Location = new System.Drawing.Point(2, 57);
            this.rtbContenido.Margin = new System.Windows.Forms.Padding(2);
            this.rtbContenido.Name = "rtbContenido";
            this.rtbContenido.Size = new System.Drawing.Size(737, 413);
            this.rtbContenido.TabIndex = 16;
            this.rtbContenido.Text = "";
            this.rtbContenido.SelectionChanged += new System.EventHandler(this.rtbContenido_SelectionChanged);
            // 
            // EditorTextoSencillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.Name = "EditorTextoSencillo";
            this.Size = new System.Drawing.Size(741, 472);
            this.Load += new System.EventHandler(this.EditorTextoSencillo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanhoFuente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAumentarFuente;
        private System.Windows.Forms.Button btnDisminuirFuente;
        private System.Windows.Forms.NumericUpDown nudTamanhoFuente;
        private System.Windows.Forms.Button btnColorFuente;
        private System.Windows.Forms.Button btnSubrayado;
        private System.Windows.Forms.Button btnCursiva;
        private System.Windows.Forms.Button btnNegrita;
        private System.Windows.Forms.RichTextBox rtbContenido;
        private System.Windows.Forms.ColorDialog cdColorFuente;
    }
}
