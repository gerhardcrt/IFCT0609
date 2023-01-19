
namespace M3_U2_23_ControlHorario
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
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbDiaMas = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "HH:mm";
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(219, 97);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowUpDown = true;
            this.dtpInicio.Size = new System.Drawing.Size(226, 68);
            this.dtpInicio.TabIndex = 0;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtps_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "HH:mm";
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.Location = new System.Drawing.Point(573, 97);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShowUpDown = true;
            this.dtpFin.Size = new System.Drawing.Size(226, 68);
            this.dtpFin.TabIndex = 1;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtps_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1145, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 91);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ckbDiaMas
            // 
            this.ckbDiaMas.AutoSize = true;
            this.ckbDiaMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDiaMas.Location = new System.Drawing.Point(837, 97);
            this.ckbDiaMas.Name = "ckbDiaMas";
            this.ckbDiaMas.Size = new System.Drawing.Size(127, 67);
            this.ckbDiaMas.TabIndex = 3;
            this.ckbDiaMas.Text = "+1";
            this.ckbDiaMas.UseVisualStyleBackColor = true;
            this.ckbDiaMas.CheckedChanged += new System.EventHandler(this.dtps_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 376);
            this.Controls.Add(this.ckbDiaMas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbDiaMas;
    }
}

