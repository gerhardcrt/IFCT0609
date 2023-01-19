
namespace EG14_Puteador
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNoNoNo = new System.Windows.Forms.Button();
            this.btnSufrir = new System.Windows.Forms.Button();
            this.btnNideConha = new System.Windows.Forms.Button();
            this.btnNoPorfa = new System.Windows.Forms.Button();
            this.btnNegativo = new System.Windows.Forms.Button();
            this.btnPosicion1 = new System.Windows.Forms.Button();
            this.btnPosicion2 = new System.Windows.Forms.Button();
            this.tmEncoger = new System.Windows.Forms.Timer(this.components);
            this.btnTamanhoNiDeConha = new System.Windows.Forms.Button();
            this.tmCrecer = new System.Windows.Forms.Timer(this.components);
            this.btnLimiteSuperiorIzquierda = new System.Windows.Forms.Button();
            this.btnLimiteInferiorDerecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1006, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Se va a formatear el HDD, seguimos ???";
            // 
            // btnNoNoNo
            // 
            this.btnNoNoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoNoNo.Location = new System.Drawing.Point(53, 592);
            this.btnNoNoNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNoNoNo.Name = "btnNoNoNo";
            this.btnNoNoNo.Size = new System.Drawing.Size(332, 77);
            this.btnNoNoNo.TabIndex = 1;
            this.btnNoNoNo.Text = "No, no, no";
            this.btnNoNoNo.UseVisualStyleBackColor = true;
            this.btnNoNoNo.MouseEnter += new System.EventHandler(this.Desplazar);
            // 
            // btnSufrir
            // 
            this.btnSufrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSufrir.Location = new System.Drawing.Point(414, 592);
            this.btnSufrir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSufrir.Name = "btnSufrir";
            this.btnSufrir.Size = new System.Drawing.Size(332, 77);
            this.btnSufrir.TabIndex = 2;
            this.btnSufrir.Text = "Te gusta sufrir";
            this.btnSufrir.UseVisualStyleBackColor = true;
            this.btnSufrir.Click += new System.EventHandler(this.btnSufrir_Click);
            // 
            // btnNideConha
            // 
            this.btnNideConha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNideConha.Location = new System.Drawing.Point(775, 592);
            this.btnNideConha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNideConha.Name = "btnNideConha";
            this.btnNideConha.Size = new System.Drawing.Size(332, 77);
            this.btnNideConha.TabIndex = 3;
            this.btnNideConha.Text = "Ni de Coña";
            this.btnNideConha.UseVisualStyleBackColor = true;
            this.btnNideConha.MouseEnter += new System.EventHandler(this.Encoger);
            // 
            // btnNoPorfa
            // 
            this.btnNoPorfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoPorfa.Location = new System.Drawing.Point(1136, 592);
            this.btnNoPorfa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNoPorfa.Name = "btnNoPorfa";
            this.btnNoPorfa.Size = new System.Drawing.Size(332, 77);
            this.btnNoPorfa.TabIndex = 4;
            this.btnNoPorfa.Text = "No porfa...";
            this.btnNoPorfa.UseVisualStyleBackColor = true;
            this.btnNoPorfa.MouseEnter += new System.EventHandler(this.Ocultar);
            this.btnNoPorfa.MouseLeave += new System.EventHandler(this.Mostrar);
            // 
            // btnNegativo
            // 
            this.btnNegativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegativo.Location = new System.Drawing.Point(1497, 592);
            this.btnNegativo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNegativo.Name = "btnNegativo";
            this.btnNegativo.Size = new System.Drawing.Size(332, 77);
            this.btnNegativo.TabIndex = 5;
            this.btnNegativo.Text = "NEGATIVO";
            this.btnNegativo.UseVisualStyleBackColor = true;
            this.btnNegativo.MouseEnter += new System.EventHandler(this.Escapar);
            // 
            // btnPosicion1
            // 
            this.btnPosicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosicion1.Location = new System.Drawing.Point(53, 395);
            this.btnPosicion1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnPosicion1.Name = "btnPosicion1";
            this.btnPosicion1.Size = new System.Drawing.Size(332, 77);
            this.btnPosicion1.TabIndex = 6;
            this.btnPosicion1.Text = "1";
            this.btnPosicion1.UseVisualStyleBackColor = true;
            // 
            // btnPosicion2
            // 
            this.btnPosicion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosicion2.Location = new System.Drawing.Point(160, 592);
            this.btnPosicion2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnPosicion2.Name = "btnPosicion2";
            this.btnPosicion2.Size = new System.Drawing.Size(226, 77);
            this.btnPosicion2.TabIndex = 7;
            this.btnPosicion2.Text = "2";
            this.btnPosicion2.UseVisualStyleBackColor = true;
            // 
            // tmEncoger
            // 
            this.tmEncoger.Interval = 5;
            this.tmEncoger.Tick += new System.EventHandler(this.tmEncoger_Tick);
            // 
            // btnTamanhoNiDeConha
            // 
            this.btnTamanhoNiDeConha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamanhoNiDeConha.Location = new System.Drawing.Point(41, 14);
            this.btnTamanhoNiDeConha.Margin = new System.Windows.Forms.Padding(5);
            this.btnTamanhoNiDeConha.Name = "btnTamanhoNiDeConha";
            this.btnTamanhoNiDeConha.Size = new System.Drawing.Size(332, 77);
            this.btnTamanhoNiDeConha.TabIndex = 8;
            this.btnTamanhoNiDeConha.Text = "No porfa...";
            this.btnTamanhoNiDeConha.UseVisualStyleBackColor = true;
            // 
            // tmCrecer
            // 
            this.tmCrecer.Interval = 5;
            this.tmCrecer.Tick += new System.EventHandler(this.tmCrecer_Tick);
            // 
            // btnLimiteSuperiorIzquierda
            // 
            this.btnLimiteSuperiorIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimiteSuperiorIzquierda.Location = new System.Drawing.Point(424, 153);
            this.btnLimiteSuperiorIzquierda.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimiteSuperiorIzquierda.Name = "btnLimiteSuperiorIzquierda";
            this.btnLimiteSuperiorIzquierda.Size = new System.Drawing.Size(332, 77);
            this.btnLimiteSuperiorIzquierda.TabIndex = 9;
            this.btnLimiteSuperiorIzquierda.Text = "3";
            this.btnLimiteSuperiorIzquierda.UseVisualStyleBackColor = true;
            // 
            // btnLimiteInferiorDerecha
            // 
            this.btnLimiteInferiorDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimiteInferiorDerecha.Location = new System.Drawing.Point(1497, 486);
            this.btnLimiteInferiorDerecha.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimiteInferiorDerecha.Name = "btnLimiteInferiorDerecha";
            this.btnLimiteInferiorDerecha.Size = new System.Drawing.Size(332, 77);
            this.btnLimiteInferiorDerecha.TabIndex = 10;
            this.btnLimiteInferiorDerecha.Text = "4";
            this.btnLimiteInferiorDerecha.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 736);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimiteInferiorDerecha);
            this.Controls.Add(this.btnLimiteSuperiorIzquierda);
            this.Controls.Add(this.btnTamanhoNiDeConha);
            this.Controls.Add(this.btnPosicion1);
            this.Controls.Add(this.btnNegativo);
            this.Controls.Add(this.btnNoPorfa);
            this.Controls.Add(this.btnNideConha);
            this.Controls.Add(this.btnSufrir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPosicion2);
            this.Controls.Add(this.btnNoNoNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Formateado Rápido";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNoNoNo;
        private System.Windows.Forms.Button btnSufrir;
        private System.Windows.Forms.Button btnNideConha;
        private System.Windows.Forms.Button btnNoPorfa;
        private System.Windows.Forms.Button btnNegativo;
        private System.Windows.Forms.Button btnPosicion1;
        private System.Windows.Forms.Button btnPosicion2;
        private System.Windows.Forms.Timer tmEncoger;
        private System.Windows.Forms.Button btnTamanhoNiDeConha;
        private System.Windows.Forms.Timer tmCrecer;
        private System.Windows.Forms.Button btnLimiteSuperiorIzquierda;
        private System.Windows.Forms.Button btnLimiteInferiorDerecha;
    }
}

