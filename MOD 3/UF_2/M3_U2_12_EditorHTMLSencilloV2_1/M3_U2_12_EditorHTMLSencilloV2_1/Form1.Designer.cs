
namespace M3_U2_12_EditorHTMLSencilloV2_1
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
            this.rtbContenido = new System.Windows.Forms.RichTextBox();
            this.btnMostrarHTML = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnNegrita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbContenido
            // 
            this.rtbContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContenido.Location = new System.Drawing.Point(35, 144);
            this.rtbContenido.Margin = new System.Windows.Forms.Padding(5);
            this.rtbContenido.Name = "rtbContenido";
            this.rtbContenido.Size = new System.Drawing.Size(1019, 463);
            this.rtbContenido.TabIndex = 0;
            this.rtbContenido.Text = "";
            this.rtbContenido.SelectionChanged += new System.EventHandler(this.rtbContenido_SelectionChanged);
            // 
            // btnMostrarHTML
            // 
            this.btnMostrarHTML.Location = new System.Drawing.Point(1128, 527);
            this.btnMostrarHTML.Margin = new System.Windows.Forms.Padding(5);
            this.btnMostrarHTML.Name = "btnMostrarHTML";
            this.btnMostrarHTML.Size = new System.Drawing.Size(188, 82);
            this.btnMostrarHTML.TabIndex = 1;
            this.btnMostrarHTML.Text = "HTML";
            this.btnMostrarHTML.UseVisualStyleBackColor = true;
            this.btnMostrarHTML.Click += new System.EventHandler(this.btnMostrarHTML_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(1396, 135);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(36, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(848, 474);
            this.webBrowser1.TabIndex = 2;
            // 
            // btnNegrita
            // 
            this.btnNegrita.Location = new System.Drawing.Point(35, 36);
            this.btnNegrita.Name = "btnNegrita";
            this.btnNegrita.Size = new System.Drawing.Size(90, 86);
            this.btnNegrita.TabIndex = 3;
            this.btnNegrita.Text = "n";
            this.btnNegrita.UseVisualStyleBackColor = true;
            this.btnNegrita.Click += new System.EventHandler(this.btnNegrita_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2492, 697);
            this.Controls.Add(this.btnNegrita);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnMostrarHTML);
            this.Controls.Add(this.rtbContenido);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbContenido;
        private System.Windows.Forms.Button btnMostrarHTML;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnNegrita;
    }
}

