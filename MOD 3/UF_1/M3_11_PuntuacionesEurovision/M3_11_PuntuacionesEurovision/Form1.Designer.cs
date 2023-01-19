
namespace M3_11_PuntuacionesEurovision
{
    partial class frmPrincipal
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
            this.btn30 = new System.Windows.Forms.Button();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.lbParticipantes = new System.Windows.Forms.ListBox();
            this.cbSeleccionarParticipante = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn30
            // 
            this.btn30.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30.Location = new System.Drawing.Point(890, 250);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(168, 117);
            this.btn30.TabIndex = 0;
            this.btn30.Text = "30";
            this.btn30.UseVisualStyleBackColor = true;
            this.btn30.Click += new System.EventHandler(this.ClicarEnPuntuacion);
            // 
            // btn25
            // 
            this.btn25.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn25.Location = new System.Drawing.Point(1078, 250);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(168, 117);
            this.btn25.TabIndex = 1;
            this.btn25.Text = "25";
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Click += new System.EventHandler(this.ClicarEnPuntuacion);
            // 
            // btn15
            // 
            this.btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15.Location = new System.Drawing.Point(1078, 387);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(168, 117);
            this.btn15.TabIndex = 3;
            this.btn15.Text = "15";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.ClicarEnPuntuacion);
            // 
            // btn20
            // 
            this.btn20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20.Location = new System.Drawing.Point(890, 387);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(168, 117);
            this.btn20.TabIndex = 2;
            this.btn20.Text = "20";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.ClicarEnPuntuacion);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(1078, 522);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(168, 117);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.ClicarEnPuntuacion);
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(890, 522);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(168, 117);
            this.btn10.TabIndex = 4;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.ClicarEnPuntuacion);
            // 
            // lbParticipantes
            // 
            this.lbParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParticipantes.FormattingEnabled = true;
            this.lbParticipantes.ItemHeight = 69;
            this.lbParticipantes.Location = new System.Drawing.Point(64, 61);
            this.lbParticipantes.Name = "lbParticipantes";
            this.lbParticipantes.Size = new System.Drawing.Size(746, 625);
            this.lbParticipantes.TabIndex = 6;
            // 
            // cbSeleccionarParticipante
            // 
            this.cbSeleccionarParticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeleccionarParticipante.FormattingEnabled = true;
            this.cbSeleccionarParticipante.Location = new System.Drawing.Point(881, 73);
            this.cbSeleccionarParticipante.Name = "cbSeleccionarParticipante";
            this.cbSeleccionarParticipante.Size = new System.Drawing.Size(664, 77);
            this.cbSeleccionarParticipante.TabIndex = 7;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 770);
            this.Controls.Add(this.cbSeleccionarParticipante);
            this.Controls.Add(this.lbParticipantes);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn15);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn25);
            this.Controls.Add(this.btn30);
            this.Name = "frmPrincipal";
            this.Text = "Puntuacion Eurovision v1.0";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.ListBox lbParticipantes;
        private System.Windows.Forms.ComboBox cbSeleccionarParticipante;
    }
}

