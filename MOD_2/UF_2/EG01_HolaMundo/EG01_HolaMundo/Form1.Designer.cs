
namespace EG01_HolaMundo
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
            this.btnSaludo = new System.Windows.Forms.Button();
            this.lblEtiquetaSaludo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnPulsameNombre = new System.Windows.Forms.Button();
            this.lblSaludoNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaludo
            // 
            this.btnSaludo.ForeColor = System.Drawing.Color.Black;
            this.btnSaludo.Location = new System.Drawing.Point(225, 83);
            this.btnSaludo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(198, 58);
            this.btnSaludo.TabIndex = 0;
            this.btnSaludo.Text = "Pulsame";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // lblEtiquetaSaludo
            // 
            this.lblEtiquetaSaludo.AutoSize = true;
            this.lblEtiquetaSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaSaludo.Location = new System.Drawing.Point(209, 251);
            this.lblEtiquetaSaludo.Name = "lblEtiquetaSaludo";
            this.lblEtiquetaSaludo.Size = new System.Drawing.Size(111, 37);
            this.lblEtiquetaSaludo.TabIndex = 1;
            this.lblEtiquetaSaludo.Text = "Label1";
            this.lblEtiquetaSaludo.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(482, 97);
            this.txtNombre.MaxLength = 11;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(326, 44);
            this.txtNombre.TabIndex = 2;
            // 
            // btnPulsameNombre
            // 
            this.btnPulsameNombre.ForeColor = System.Drawing.Color.Black;
            this.btnPulsameNombre.Location = new System.Drawing.Point(610, 155);
            this.btnPulsameNombre.Margin = new System.Windows.Forms.Padding(2);
            this.btnPulsameNombre.Name = "btnPulsameNombre";
            this.btnPulsameNombre.Size = new System.Drawing.Size(198, 58);
            this.btnPulsameNombre.TabIndex = 3;
            this.btnPulsameNombre.Text = "Pulsame";
            this.btnPulsameNombre.UseVisualStyleBackColor = true;
            this.btnPulsameNombre.Click += new System.EventHandler(this.btnPulsameNombre_Click);
            // 
            // lblSaludoNombre
            // 
            this.lblSaludoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludoNombre.Location = new System.Drawing.Point(482, 251);
            this.lblSaludoNombre.Name = "lblSaludoNombre";
            this.lblSaludoNombre.Size = new System.Drawing.Size(414, 48);
            this.lblSaludoNombre.TabIndex = 4;
            this.lblSaludoNombre.Text = "Label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 452);
            this.Controls.Add(this.lblSaludoNombre);
            this.Controls.Add(this.btnPulsameNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEtiquetaSaludo);
            this.Controls.Add(this.btnSaludo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.Label lblEtiquetaSaludo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnPulsameNombre;
        private System.Windows.Forms.Label lblSaludoNombre;
    }
}

