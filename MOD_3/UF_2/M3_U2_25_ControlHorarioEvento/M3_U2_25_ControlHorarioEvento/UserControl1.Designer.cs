namespace M3_U2_25_ControlHorarioEvento
{
    partial class ControlHorario
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
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.ckbDiaMas = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.Controls.Add(this.dtpInicio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpFin, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ckbDiaMas, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 80);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "HH:mm";
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(14, 18);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowUpDown = true;
            this.dtpInicio.Size = new System.Drawing.Size(129, 39);
            this.dtpInicio.TabIndex = 1;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtps_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "HH:mm";
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.Location = new System.Drawing.Point(154, 18);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShowUpDown = true;
            this.dtpFin.Size = new System.Drawing.Size(129, 39);
            this.dtpFin.TabIndex = 2;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtps_ValueChanged);
            // 
            // ckbDiaMas
            // 
            this.ckbDiaMas.AutoSize = true;
            this.ckbDiaMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDiaMas.Location = new System.Drawing.Point(314, 18);
            this.ckbDiaMas.Margin = new System.Windows.Forms.Padding(2);
            this.ckbDiaMas.Name = "ckbDiaMas";
            this.ckbDiaMas.Size = new System.Drawing.Size(78, 41);
            this.ckbDiaMas.TabIndex = 4;
            this.ckbDiaMas.Text = "+1";
            this.ckbDiaMas.UseVisualStyleBackColor = true;
            this.ckbDiaMas.CheckedChanged += new System.EventHandler(this.dtps_ValueChanged);
            // 
            // ControlHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(400, 80);
            this.MinimumSize = new System.Drawing.Size(400, 80);
            this.Name = "ControlHorario";
            this.Size = new System.Drawing.Size(400, 80);
            this.Load += new System.EventHandler(this.ControlHorario_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.CheckBox ckbDiaMas;
    }
}
