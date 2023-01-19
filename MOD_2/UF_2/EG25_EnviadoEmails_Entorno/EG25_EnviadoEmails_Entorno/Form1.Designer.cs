
namespace EG25_EnviadoEmails_Entorno
{
    partial class btnAgregar
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
            this.txtCuerpo = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lbDestinatarios = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbAdjuntos = new System.Windows.Forms.ListBox();
            this.lTamanhoAdjuntos = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAgregarAdjunto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCuerpo
            // 
            this.txtCuerpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuerpo.Location = new System.Drawing.Point(93, 200);
            this.txtCuerpo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCuerpo.Multiline = true;
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.Size = new System.Drawing.Size(780, 452);
            this.txtCuerpo.TabIndex = 0;
            // 
            // txtPara
            // 
            this.txtPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara.Location = new System.Drawing.Point(185, 63);
            this.txtPara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(533, 48);
            this.txtPara.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(609, 673);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(264, 88);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Para";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(185, 133);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(688, 48);
            this.txtTitulo.TabIndex = 4;
            // 
            // lbDestinatarios
            // 
            this.lbDestinatarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestinatarios.FormattingEnabled = true;
            this.lbDestinatarios.ItemHeight = 32;
            this.lbDestinatarios.Location = new System.Drawing.Point(930, 55);
            this.lbDestinatarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbDestinatarios.Name = "lbDestinatarios";
            this.lbDestinatarios.Size = new System.Drawing.Size(379, 324);
            this.lbDestinatarios.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(743, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbAdjuntos
            // 
            this.lbAdjuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdjuntos.FormattingEnabled = true;
            this.lbAdjuntos.ItemHeight = 32;
            this.lbAdjuntos.Location = new System.Drawing.Point(930, 393);
            this.lbAdjuntos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbAdjuntos.Name = "lbAdjuntos";
            this.lbAdjuntos.Size = new System.Drawing.Size(379, 196);
            this.lbAdjuntos.TabIndex = 8;
            // 
            // lTamanhoAdjuntos
            // 
            this.lTamanhoAdjuntos.AutoSize = true;
            this.lTamanhoAdjuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTamanhoAdjuntos.Location = new System.Drawing.Point(933, 612);
            this.lTamanhoAdjuntos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTamanhoAdjuntos.Name = "lTamanhoAdjuntos";
            this.lTamanhoAdjuntos.Size = new System.Drawing.Size(53, 40);
            this.lTamanhoAdjuntos.TabIndex = 9;
            this.lTamanhoAdjuntos.Text = "---";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAgregarAdjunto
            // 
            this.btnAgregarAdjunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAdjunto.Location = new System.Drawing.Point(1093, 628);
            this.btnAgregarAdjunto.Name = "btnAgregarAdjunto";
            this.btnAgregarAdjunto.Size = new System.Drawing.Size(216, 108);
            this.btnAgregarAdjunto.TabIndex = 10;
            this.btnAgregarAdjunto.Text = "Agregar Adjunto";
            this.btnAgregarAdjunto.UseVisualStyleBackColor = true;
            this.btnAgregarAdjunto.Click += new System.EventHandler(this.btnAgregarAdjunto_Click);
            // 
            // btnAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 841);
            this.Controls.Add(this.btnAgregarAdjunto);
            this.Controls.Add(this.lTamanhoAdjuntos);
            this.Controls.Add(this.lbAdjuntos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDestinatarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.txtCuerpo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "btnAgregar";
            this.Text = "Enviador Emails 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCuerpo;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ListBox lbDestinatarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbAdjuntos;
        private System.Windows.Forms.Label lTamanhoAdjuntos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAgregarAdjunto;
    }
}

