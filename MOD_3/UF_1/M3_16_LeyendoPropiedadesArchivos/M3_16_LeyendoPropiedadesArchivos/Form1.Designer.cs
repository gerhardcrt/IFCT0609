
namespace M3_16_LeyendoPropiedadesArchivos
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFechaAcceso = new System.Windows.Forms.Label();
            this.lblFechaModificacion = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.dtpCreacion = new System.Windows.Forms.DateTimePicker();
            this.dtpModificacion = new System.Windows.Forms.DateTimePicker();
            this.dtpAcceso = new System.Windows.Forms.DateTimePicker();
            this.btnCambiarCreacion = new System.Windows.Forms.Button();
            this.btnCambiarModificacion = new System.Windows.Forms.Button();
            this.btnCambiarAcceso = new System.Windows.Forms.Button();
            this.btnCambiarTodosArchivos = new System.Windows.Forms.Button();
            this.btnCambiarTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFicheros
            // 
            this.lbFicheros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFicheros.FormattingEnabled = true;
            this.lbFicheros.ItemHeight = 32;
            this.lbFicheros.Location = new System.Drawing.Point(48, 31);
            this.lbFicheros.Name = "lbFicheros";
            this.lbFicheros.Size = new System.Drawing.Size(446, 228);
            this.lbFicheros.TabIndex = 0;
            this.lbFicheros.SelectedIndexChanged += new System.EventHandler(this.lbFicheros_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Creación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(529, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modificación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Acceso:";
            // 
            // lblFechaAcceso
            // 
            this.lblFechaAcceso.AutoSize = true;
            this.lblFechaAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAcceso.Location = new System.Drawing.Point(725, 272);
            this.lblFechaAcceso.Name = "lblFechaAcceso";
            this.lblFechaAcceso.Size = new System.Drawing.Size(93, 32);
            this.lblFechaAcceso.TabIndex = 8;
            this.lblFechaAcceso.Text = "label4";
            // 
            // lblFechaModificacion
            // 
            this.lblFechaModificacion.AutoSize = true;
            this.lblFechaModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaModificacion.Location = new System.Drawing.Point(725, 215);
            this.lblFechaModificacion.Name = "lblFechaModificacion";
            this.lblFechaModificacion.Size = new System.Drawing.Size(93, 32);
            this.lblFechaModificacion.TabIndex = 7;
            this.lblFechaModificacion.Text = "label5";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(725, 155);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(93, 32);
            this.lblFechaCreacion.TabIndex = 6;
            this.lblFechaCreacion.Text = "label6";
            // 
            // dtpCreacion
            // 
            this.dtpCreacion.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreacion.Location = new System.Drawing.Point(1010, 155);
            this.dtpCreacion.Name = "dtpCreacion";
            this.dtpCreacion.ShowUpDown = true;
            this.dtpCreacion.Size = new System.Drawing.Size(304, 39);
            this.dtpCreacion.TabIndex = 13;
            // 
            // dtpModificacion
            // 
            this.dtpModificacion.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpModificacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModificacion.Location = new System.Drawing.Point(1010, 208);
            this.dtpModificacion.Name = "dtpModificacion";
            this.dtpModificacion.ShowUpDown = true;
            this.dtpModificacion.Size = new System.Drawing.Size(304, 39);
            this.dtpModificacion.TabIndex = 14;
            // 
            // dtpAcceso
            // 
            this.dtpAcceso.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAcceso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAcceso.Location = new System.Drawing.Point(1010, 265);
            this.dtpAcceso.Name = "dtpAcceso";
            this.dtpAcceso.ShowUpDown = true;
            this.dtpAcceso.Size = new System.Drawing.Size(304, 39);
            this.dtpAcceso.TabIndex = 15;
            // 
            // btnCambiarCreacion
            // 
            this.btnCambiarCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarCreacion.Location = new System.Drawing.Point(1334, 155);
            this.btnCambiarCreacion.Name = "btnCambiarCreacion";
            this.btnCambiarCreacion.Size = new System.Drawing.Size(218, 39);
            this.btnCambiarCreacion.TabIndex = 16;
            this.btnCambiarCreacion.Text = "Cambiar";
            this.btnCambiarCreacion.UseVisualStyleBackColor = true;
            this.btnCambiarCreacion.Click += new System.EventHandler(this.btnCambiarCreacion_Click);
            // 
            // btnCambiarModificacion
            // 
            this.btnCambiarModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarModificacion.Location = new System.Drawing.Point(1334, 208);
            this.btnCambiarModificacion.Name = "btnCambiarModificacion";
            this.btnCambiarModificacion.Size = new System.Drawing.Size(218, 39);
            this.btnCambiarModificacion.TabIndex = 17;
            this.btnCambiarModificacion.Text = "Cambiar";
            this.btnCambiarModificacion.UseVisualStyleBackColor = true;
            this.btnCambiarModificacion.Click += new System.EventHandler(this.btnCambiarModificacion_Click);
            // 
            // btnCambiarAcceso
            // 
            this.btnCambiarAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarAcceso.Location = new System.Drawing.Point(1334, 265);
            this.btnCambiarAcceso.Name = "btnCambiarAcceso";
            this.btnCambiarAcceso.Size = new System.Drawing.Size(218, 39);
            this.btnCambiarAcceso.TabIndex = 18;
            this.btnCambiarAcceso.Text = "Cambiar";
            this.btnCambiarAcceso.UseVisualStyleBackColor = true;
            this.btnCambiarAcceso.Click += new System.EventHandler(this.btnCambiarAcceso_Click);
            // 
            // btnCambiarTodosArchivos
            // 
            this.btnCambiarTodosArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarTodosArchivos.Location = new System.Drawing.Point(1010, 318);
            this.btnCambiarTodosArchivos.Name = "btnCambiarTodosArchivos";
            this.btnCambiarTodosArchivos.Size = new System.Drawing.Size(304, 72);
            this.btnCambiarTodosArchivos.TabIndex = 19;
            this.btnCambiarTodosArchivos.Text = "Cambiar Todos Archivos";
            this.btnCambiarTodosArchivos.UseVisualStyleBackColor = true;
            this.btnCambiarTodosArchivos.Click += new System.EventHandler(this.btnCambiarTodosArchivos_Click);
            // 
            // btnCambiarTodos
            // 
            this.btnCambiarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarTodos.Location = new System.Drawing.Point(1334, 318);
            this.btnCambiarTodos.Name = "btnCambiarTodos";
            this.btnCambiarTodos.Size = new System.Drawing.Size(218, 72);
            this.btnCambiarTodos.TabIndex = 20;
            this.btnCambiarTodos.Text = "Cambiar Todo";
            this.btnCambiarTodos.UseVisualStyleBackColor = true;
            this.btnCambiarTodos.Click += new System.EventHandler(this.btnCambiarTodos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 450);
            this.Controls.Add(this.btnCambiarTodos);
            this.Controls.Add(this.btnCambiarTodosArchivos);
            this.Controls.Add(this.btnCambiarAcceso);
            this.Controls.Add(this.btnCambiarModificacion);
            this.Controls.Add(this.btnCambiarCreacion);
            this.Controls.Add(this.dtpAcceso);
            this.Controls.Add(this.dtpModificacion);
            this.Controls.Add(this.dtpCreacion);
            this.Controls.Add(this.lblFechaAcceso);
            this.Controls.Add(this.lblFechaModificacion);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarSeleccionado);
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
        private System.Windows.Forms.Button btnEliminarSeleccionado;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFechaAcceso;
        private System.Windows.Forms.Label lblFechaModificacion;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.DateTimePicker dtpCreacion;
        private System.Windows.Forms.DateTimePicker dtpModificacion;
        private System.Windows.Forms.DateTimePicker dtpAcceso;
        private System.Windows.Forms.Button btnCambiarCreacion;
        private System.Windows.Forms.Button btnCambiarModificacion;
        private System.Windows.Forms.Button btnCambiarAcceso;
        private System.Windows.Forms.Button btnCambiarTodosArchivos;
        private System.Windows.Forms.Button btnCambiarTodos;
    }
}

