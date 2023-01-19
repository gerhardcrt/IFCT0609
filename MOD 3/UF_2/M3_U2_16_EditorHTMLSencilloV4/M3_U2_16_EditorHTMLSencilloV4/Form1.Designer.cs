
namespace M3_U2_16_EditorHTMLSencilloV4
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
            this.editorTextoSencillo1 = new M3_U2_15_BibliotecaControlEditorTextoSencillo.EditorTextoSencillo();
            this.SuspendLayout();
            // 
            // editorTextoSencillo1
            // 
            this.editorTextoSencillo1.Location = new System.Drawing.Point(42, 47);
            this.editorTextoSencillo1.Name = "editorTextoSencillo1";
            this.editorTextoSencillo1.Size = new System.Drawing.Size(1372, 597);
            this.editorTextoSencillo1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 680);
            this.Controls.Add(this.editorTextoSencillo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private M3_U2_15_BibliotecaControlEditorTextoSencillo.EditorTextoSencillo editorTextoSencillo1;
    }
}

