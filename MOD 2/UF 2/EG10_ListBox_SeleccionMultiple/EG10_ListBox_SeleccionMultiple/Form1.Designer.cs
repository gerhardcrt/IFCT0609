
namespace EG10_ListBox_SeleccionMultiple
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
            this.lbOrigen = new System.Windows.Forms.ListBox();
            this.lbDestino = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOrigen
            // 
            this.lbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrigen.FormattingEnabled = true;
            this.lbOrigen.ItemHeight = 37;
            this.lbOrigen.Items.AddRange(new object[] {
            "Ourense",
            "Lugo",
            "Coruña",
            "Santiago",
            "Pontevedra",
            "Lalín",
            "Vigo",
            "Ferrol",
            "Vilagarcía"});
            this.lbOrigen.Location = new System.Drawing.Point(85, 66);
            this.lbOrigen.Name = "lbOrigen";
            this.lbOrigen.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbOrigen.Size = new System.Drawing.Size(281, 300);
            this.lbOrigen.TabIndex = 0;
            // 
            // lbDestino
            // 
            this.lbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestino.FormattingEnabled = true;
            this.lbDestino.ItemHeight = 37;
            this.lbDestino.Location = new System.Drawing.Point(439, 66);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(281, 300);
            this.lbDestino.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDestino);
            this.Controls.Add(this.lbOrigen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbOrigen;
        private System.Windows.Forms.ListBox lbDestino;
        private System.Windows.Forms.Button button1;
    }
}

