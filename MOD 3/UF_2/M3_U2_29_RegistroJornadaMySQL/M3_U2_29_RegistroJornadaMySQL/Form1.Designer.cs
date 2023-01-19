
namespace M3_U2_29_RegistroJornadaMySQL
{
    partial class FrmRegistroJornada
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.cbTrabajadores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAhoraEntrada = new System.Windows.Forms.Button();
            this.btnAhoraSalida = new System.Windows.Forms.Button();
            this.btnHoy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(73, 297);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(656, 85);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(73, 117);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(557, 44);
            this.dtpFecha.TabIndex = 1;
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.CustomFormat = "HH:mm";
            this.dtpHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(73, 175);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.ShowUpDown = true;
            this.dtpHoraEntrada.Size = new System.Drawing.Size(133, 44);
            this.dtpHoraEntrada.TabIndex = 2;
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.CustomFormat = "HH:mm";
            this.dtpHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraSalida.Location = new System.Drawing.Point(601, 175);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.ShowUpDown = true;
            this.dtpHoraSalida.Size = new System.Drawing.Size(128, 44);
            this.dtpHoraSalida.TabIndex = 3;
            // 
            // cbTrabajadores
            // 
            this.cbTrabajadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrabajadores.FormattingEnabled = true;
            this.cbTrabajadores.Location = new System.Drawing.Point(73, 55);
            this.cbTrabajadores.Name = "cbTrabajadores";
            this.cbTrabajadores.Size = new System.Drawing.Size(656, 45);
            this.cbTrabajadores.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(678, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "salida";
            // 
            // btnAhoraEntrada
            // 
            this.btnAhoraEntrada.Location = new System.Drawing.Point(222, 175);
            this.btnAhoraEntrada.Name = "btnAhoraEntrada";
            this.btnAhoraEntrada.Size = new System.Drawing.Size(75, 44);
            this.btnAhoraEntrada.TabIndex = 7;
            this.btnAhoraEntrada.Text = "Ahora";
            this.btnAhoraEntrada.UseVisualStyleBackColor = true;
            this.btnAhoraEntrada.Click += new System.EventHandler(this.btnAhoraEntrada_Click);
            // 
            // btnAhoraSalida
            // 
            this.btnAhoraSalida.Location = new System.Drawing.Point(509, 175);
            this.btnAhoraSalida.Name = "btnAhoraSalida";
            this.btnAhoraSalida.Size = new System.Drawing.Size(75, 44);
            this.btnAhoraSalida.TabIndex = 8;
            this.btnAhoraSalida.Text = "Ahora";
            this.btnAhoraSalida.UseVisualStyleBackColor = true;
            this.btnAhoraSalida.Click += new System.EventHandler(this.btnAhoraSalida_Click);
            // 
            // btnHoy
            // 
            this.btnHoy.Location = new System.Drawing.Point(654, 117);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(75, 44);
            this.btnHoy.TabIndex = 9;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.UseVisualStyleBackColor = true;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // FrmRegistroJornada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.btnHoy);
            this.Controls.Add(this.btnAhoraSalida);
            this.Controls.Add(this.btnAhoraEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTrabajadores);
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "FrmRegistroJornada";
            this.Text = "Registro Jornada v1.0";
            this.Load += new System.EventHandler(this.FrmRegistroJornada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.ComboBox cbTrabajadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAhoraEntrada;
        private System.Windows.Forms.Button btnAhoraSalida;
        private System.Windows.Forms.Button btnHoy;
    }
}

