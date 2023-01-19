
namespace M3_18_RenombradoPorGrupos
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
            this.lbFicheros = new System.Windows.Forms.ListBox();
            this.btnAbrirCarpeta = new System.Windows.Forms.Button();
            this.btnRenombrar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbNuevoNombre = new System.Windows.Forms.ListBox();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbFicheros
            // 
            this.lbFicheros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFicheros.FormattingEnabled = true;
            this.lbFicheros.ItemHeight = 32;
            this.lbFicheros.Location = new System.Drawing.Point(48, 31);
            this.lbFicheros.Name = "lbFicheros";
            this.lbFicheros.Size = new System.Drawing.Size(446, 196);
            this.lbFicheros.TabIndex = 0;
            // 
            // btnAbrirCarpeta
            // 
            this.btnAbrirCarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCarpeta.Location = new System.Drawing.Point(48, 314);
            this.btnAbrirCarpeta.Name = "btnAbrirCarpeta";
            this.btnAbrirCarpeta.Size = new System.Drawing.Size(218, 86);
            this.btnAbrirCarpeta.TabIndex = 1;
            this.btnAbrirCarpeta.Text = "Abrir Carpeta";
            this.btnAbrirCarpeta.UseVisualStyleBackColor = true;
            this.btnAbrirCarpeta.Click += new System.EventHandler(this.btnAbrirCarpeta_Click);
            // 
            // btnRenombrar
            // 
            this.btnRenombrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenombrar.Location = new System.Drawing.Point(780, 297);
            this.btnRenombrar.Name = "btnRenombrar";
            this.btnRenombrar.Size = new System.Drawing.Size(218, 102);
            this.btnRenombrar.TabIndex = 2;
            this.btnRenombrar.Text = "Renombrar Ficheros";
            this.btnRenombrar.UseVisualStyleBackColor = true;
            this.btnRenombrar.Click += new System.EventHandler(this.btnRenombrar_Click);
            // 
            // lbNuevoNombre
            // 
            this.lbNuevoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuevoNombre.FormattingEnabled = true;
            this.lbNuevoNombre.ItemHeight = 32;
            this.lbNuevoNombre.Location = new System.Drawing.Point(554, 31);
            this.lbNuevoNombre.Name = "lbNuevoNombre";
            this.lbNuevoNombre.Size = new System.Drawing.Size(446, 196);
            this.lbNuevoNombre.TabIndex = 3;
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoNombre.Location = new System.Drawing.Point(328, 346);
            this.txtNuevoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(389, 44);
            this.txtNuevoNombre.TabIndex = 4;
            this.txtNuevoNombre.Leave += new System.EventHandler(this.txtNuevoNombre_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 450);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.lbNuevoNombre);
            this.Controls.Add(this.btnRenombrar);
            this.Controls.Add(this.btnAbrirCarpeta);
            this.Controls.Add(this.lbFicheros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFicheros;
        private System.Windows.Forms.Button btnAbrirCarpeta;
        private System.Windows.Forms.Button btnRenombrar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox lbNuevoNombre;
        private System.Windows.Forms.TextBox txtNuevoNombre;
    }
}

