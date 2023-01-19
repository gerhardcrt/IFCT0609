
namespace EG06_ListBox_AplicacionPractica
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
            this.lbAprobados = new System.Windows.Forms.ListBox();
            this.lbSuspensos = new System.Windows.Forms.ListBox();
            this.txtAgregarAprobado = new System.Windows.Forms.TextBox();
            this.txtAgregarSuspenso = new System.Windows.Forms.TextBox();
            this.btnAgregarAprobado = new System.Windows.Forms.Button();
            this.btnAgregarSuspenso = new System.Windows.Forms.Button();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnSuspender = new System.Windows.Forms.Button();
            this.btnSuspenderTodos = new System.Windows.Forms.Button();
            this.btnAprobarTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAprobados
            // 
            this.lbAprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAprobados.FormattingEnabled = true;
            this.lbAprobados.ItemHeight = 32;
            this.lbAprobados.Location = new System.Drawing.Point(112, 125);
            this.lbAprobados.Name = "lbAprobados";
            this.lbAprobados.Size = new System.Drawing.Size(215, 260);
            this.lbAprobados.TabIndex = 0;
            // 
            // lbSuspensos
            // 
            this.lbSuspensos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuspensos.FormattingEnabled = true;
            this.lbSuspensos.ItemHeight = 32;
            this.lbSuspensos.Location = new System.Drawing.Point(701, 125);
            this.lbSuspensos.Name = "lbSuspensos";
            this.lbSuspensos.Size = new System.Drawing.Size(215, 260);
            this.lbSuspensos.TabIndex = 1;
            // 
            // txtAgregarAprobado
            // 
            this.txtAgregarAprobado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgregarAprobado.Location = new System.Drawing.Point(112, 407);
            this.txtAgregarAprobado.Name = "txtAgregarAprobado";
            this.txtAgregarAprobado.Size = new System.Drawing.Size(215, 39);
            this.txtAgregarAprobado.TabIndex = 2;
            // 
            // txtAgregarSuspenso
            // 
            this.txtAgregarSuspenso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgregarSuspenso.Location = new System.Drawing.Point(701, 407);
            this.txtAgregarSuspenso.Name = "txtAgregarSuspenso";
            this.txtAgregarSuspenso.Size = new System.Drawing.Size(215, 39);
            this.txtAgregarSuspenso.TabIndex = 3;
            // 
            // btnAgregarAprobado
            // 
            this.btnAgregarAprobado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAprobado.Location = new System.Drawing.Point(109, 469);
            this.btnAgregarAprobado.Name = "btnAgregarAprobado";
            this.btnAgregarAprobado.Size = new System.Drawing.Size(218, 83);
            this.btnAgregarAprobado.TabIndex = 4;
            this.btnAgregarAprobado.Text = "Agregar";
            this.btnAgregarAprobado.UseVisualStyleBackColor = true;
            this.btnAgregarAprobado.Click += new System.EventHandler(this.btnAgregarAprobado_Click);
            // 
            // btnAgregarSuspenso
            // 
            this.btnAgregarSuspenso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSuspenso.Location = new System.Drawing.Point(701, 469);
            this.btnAgregarSuspenso.Name = "btnAgregarSuspenso";
            this.btnAgregarSuspenso.Size = new System.Drawing.Size(218, 83);
            this.btnAgregarSuspenso.TabIndex = 5;
            this.btnAgregarSuspenso.Text = "Agregar";
            this.btnAgregarSuspenso.UseVisualStyleBackColor = true;
            this.btnAgregarSuspenso.Click += new System.EventHandler(this.btnAgregarSuspenso_Click);
            // 
            // btnAprobar
            // 
            this.btnAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobar.Location = new System.Drawing.Point(527, 134);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(150, 51);
            this.btnAprobar.TabIndex = 8;
            this.btnAprobar.Text = "<";
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnSuspender
            // 
            this.btnSuspender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuspender.Location = new System.Drawing.Point(347, 134);
            this.btnSuspender.Name = "btnSuspender";
            this.btnSuspender.Size = new System.Drawing.Size(150, 51);
            this.btnSuspender.TabIndex = 9;
            this.btnSuspender.Text = ">";
            this.btnSuspender.UseVisualStyleBackColor = true;
            this.btnSuspender.Click += new System.EventHandler(this.btnSuspender_Click);
            // 
            // btnSuspenderTodos
            // 
            this.btnSuspenderTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuspenderTodos.Location = new System.Drawing.Point(347, 334);
            this.btnSuspenderTodos.Name = "btnSuspenderTodos";
            this.btnSuspenderTodos.Size = new System.Drawing.Size(150, 51);
            this.btnSuspenderTodos.TabIndex = 10;
            this.btnSuspenderTodos.Text = ">>";
            this.btnSuspenderTodos.UseVisualStyleBackColor = true;
            this.btnSuspenderTodos.Click += new System.EventHandler(this.btnSuspenderTodos_Click);
            // 
            // btnAprobarTodos
            // 
            this.btnAprobarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobarTodos.Location = new System.Drawing.Point(527, 334);
            this.btnAprobarTodos.Name = "btnAprobarTodos";
            this.btnAprobarTodos.Size = new System.Drawing.Size(150, 51);
            this.btnAprobarTodos.TabIndex = 11;
            this.btnAprobarTodos.Text = "<<";
            this.btnAprobarTodos.UseVisualStyleBackColor = true;
            this.btnAprobarTodos.Click += new System.EventHandler(this.btnAprobarTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Aprobados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(827, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Suspensos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 663);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAprobarTodos);
            this.Controls.Add(this.btnSuspenderTodos);
            this.Controls.Add(this.btnSuspender);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.btnAgregarSuspenso);
            this.Controls.Add(this.btnAgregarAprobado);
            this.Controls.Add(this.txtAgregarSuspenso);
            this.Controls.Add(this.txtAgregarAprobado);
            this.Controls.Add(this.lbSuspensos);
            this.Controls.Add(this.lbAprobados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAprobados;
        private System.Windows.Forms.ListBox lbSuspensos;
        private System.Windows.Forms.TextBox txtAgregarAprobado;
        private System.Windows.Forms.TextBox txtAgregarSuspenso;
        private System.Windows.Forms.Button btnAgregarAprobado;
        private System.Windows.Forms.Button btnAgregarSuspenso;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnSuspender;
        private System.Windows.Forms.Button btnSuspenderTodos;
        private System.Windows.Forms.Button btnAprobarTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

