
namespace M3_U2_21_PruebaControlEditorTextoRedim
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
            this.editorTextoSencillo1 = new Auxiliares.EditorTextoSencillo();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editorTextoSencillo1
            // 
            this.editorTextoSencillo1.Location = new System.Drawing.Point(92, 133);
            this.editorTextoSencillo1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editorTextoSencillo1.MaximumSize = new System.Drawing.Size(1200, 600);
            this.editorTextoSencillo1.MinimumSize = new System.Drawing.Size(600, 300);
            this.editorTextoSencillo1.Name = "editorTextoSencillo1";
            this.editorTextoSencillo1.Size = new System.Drawing.Size(1111, 551);
            this.editorTextoSencillo1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1512, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1410, 294);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(852, 356);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2358, 841);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editorTextoSencillo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Auxiliares.EditorTextoSencillo editorTextoSencillo1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

