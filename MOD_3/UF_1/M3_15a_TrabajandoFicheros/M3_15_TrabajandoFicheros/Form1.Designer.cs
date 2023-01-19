
namespace M3_15_TrabajandoFicheros
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
            this.btnEliminarSeleccionado = new System.Windows.Forms.Button();
            this.btnEliminarTodos = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lbFicheros
            // 
            this.lbFicheros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFicheros.FormattingEnabled = true;
            this.lbFicheros.ItemHeight = 32;
            this.lbFicheros.Location = new System.Drawing.Point(48, 31);
            this.lbFicheros.Name = "lbFicheros";
            this.lbFicheros.Size = new System.Drawing.Size(446, 260);
            this.lbFicheros.TabIndex = 0;
            // 
            // btnAbrirCarpeta
            // 
            this.btnAbrirCarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCarpeta.Location = new System.Drawing.Point(533, 31);
            this.btnAbrirCarpeta.Name = "btnAbrirCarpeta";
            this.btnAbrirCarpeta.Size = new System.Drawing.Size(218, 86);
            this.btnAbrirCarpeta.TabIndex = 1;
            this.btnAbrirCarpeta.Text = "Abrir Carpeta";
            this.btnAbrirCarpeta.UseVisualStyleBackColor = true;
            this.btnAbrirCarpeta.Click += new System.EventHandler(this.btnAbrirCarpeta_Click);
            // 
            // btnEliminarSeleccionado
            // 
            this.btnEliminarSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSeleccionado.Location = new System.Drawing.Point(48, 318);
            this.btnEliminarSeleccionado.Name = "btnEliminarSeleccionado";
            this.btnEliminarSeleccionado.Size = new System.Drawing.Size(218, 102);
            this.btnEliminarSeleccionado.TabIndex = 2;
            this.btnEliminarSeleccionado.Text = "Eliminar Seleccionado";
            this.btnEliminarSeleccionado.UseVisualStyleBackColor = true;
            this.btnEliminarSeleccionado.Click += new System.EventHandler(this.btnEliminarSeleccionado_Click);
            // 
            // btnEliminarTodos
            // 
            this.btnEliminarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodos.Location = new System.Drawing.Point(276, 318);
            this.btnEliminarTodos.Name = "btnEliminarTodos";
            this.btnEliminarTodos.Size = new System.Drawing.Size(218, 102);
            this.btnEliminarTodos.TabIndex = 3;
            this.btnEliminarTodos.Text = "Eliminar Todos/as/es";
            this.btnEliminarTodos.UseVisualStyleBackColor = true;
            this.btnEliminarTodos.Click += new System.EventHandler(this.btnEliminarTodos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarTodos);
            this.Controls.Add(this.btnEliminarSeleccionado);
            this.Controls.Add(this.btnAbrirCarpeta);
            this.Controls.Add(this.lbFicheros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFicheros;
        private System.Windows.Forms.Button btnAbrirCarpeta;
        private System.Windows.Forms.Button btnEliminarSeleccionado;
        private System.Windows.Forms.Button btnEliminarTodos;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

