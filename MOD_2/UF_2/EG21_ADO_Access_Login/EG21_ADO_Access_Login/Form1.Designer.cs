
namespace EG21_ADO_Access_Login
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
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label passwordLabel;
            this.loginDataSet = new EG21_ADO_Access_Login.loginDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new EG21_ADO_Access_Login.loginDataSetTableAdapters.usuariosTableAdapter();
            this.tableAdapterManager = new EG21_ADO_Access_Login.loginDataSetTableAdapters.TableAdapterManager();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.txtTestArray = new System.Windows.Forms.TextBox();
            this.btnAvanzarArray = new System.Windows.Forms.Button();
            this.btnRetrocederArray = new System.Windows.Forms.Button();
            this.btnAvanzar2 = new System.Windows.Forms.Button();
            this.btnRetroceder2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            usuarioLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(75, 81);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(145, 40);
            usuarioLabel.TabIndex = 1;
            usuarioLabel.Text = "usuario:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(64, 133);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(181, 40);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "password:";
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "loginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.loginDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = EG21_ADO_Access_Login.loginDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "usuario", true));
            this.usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(278, 73);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(193, 48);
            this.usuarioTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(278, 130);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(193, 48);
            this.passwordTextBox.TabIndex = 4;
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceder.Location = new System.Drawing.Point(449, 306);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(127, 44);
            this.btnRetroceder.TabIndex = 5;
            this.btnRetroceder.Text = "<";
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvanzar.Location = new System.Drawing.Point(595, 306);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(127, 44);
            this.btnAvanzar.TabIndex = 6;
            this.btnAvanzar.Text = ">";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // txtContenido
            // 
            this.txtContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenido.Location = new System.Drawing.Point(567, 239);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(155, 48);
            this.txtContenido.TabIndex = 7;
            // 
            // txtTestArray
            // 
            this.txtTestArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestArray.Location = new System.Drawing.Point(90, 239);
            this.txtTestArray.Name = "txtTestArray";
            this.txtTestArray.Size = new System.Drawing.Size(155, 48);
            this.txtTestArray.TabIndex = 10;
            // 
            // btnAvanzarArray
            // 
            this.btnAvanzarArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvanzarArray.Location = new System.Drawing.Point(165, 306);
            this.btnAvanzarArray.Name = "btnAvanzarArray";
            this.btnAvanzarArray.Size = new System.Drawing.Size(127, 44);
            this.btnAvanzarArray.TabIndex = 9;
            this.btnAvanzarArray.Text = ">";
            this.btnAvanzarArray.UseVisualStyleBackColor = true;
            this.btnAvanzarArray.Click += new System.EventHandler(this.btnAvanzarArray_Click);
            // 
            // btnRetrocederArray
            // 
            this.btnRetrocederArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrocederArray.Location = new System.Drawing.Point(19, 306);
            this.btnRetrocederArray.Name = "btnRetrocederArray";
            this.btnRetrocederArray.Size = new System.Drawing.Size(127, 44);
            this.btnRetrocederArray.TabIndex = 8;
            this.btnRetrocederArray.Text = "<";
            this.btnRetrocederArray.UseVisualStyleBackColor = true;
            this.btnRetrocederArray.Click += new System.EventHandler(this.btnRetrocederArray_Click);
            // 
            // btnAvanzar2
            // 
            this.btnAvanzar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvanzar2.Location = new System.Drawing.Point(652, 81);
            this.btnAvanzar2.Name = "btnAvanzar2";
            this.btnAvanzar2.Size = new System.Drawing.Size(127, 44);
            this.btnAvanzar2.TabIndex = 12;
            this.btnAvanzar2.Text = ">";
            this.btnAvanzar2.UseVisualStyleBackColor = true;
            this.btnAvanzar2.Click += new System.EventHandler(this.btnAvanzar2_Click);
            // 
            // btnRetroceder2
            // 
            this.btnRetroceder2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetroceder2.Location = new System.Drawing.Point(506, 81);
            this.btnRetroceder2.Name = "btnRetroceder2";
            this.btnRetroceder2.Size = new System.Drawing.Size(127, 44);
            this.btnRetroceder2.TabIndex = 11;
            this.btnRetroceder2.Text = "<";
            this.btnRetroceder2.UseVisualStyleBackColor = true;
            this.btnRetroceder2.Click += new System.EventHandler(this.btnRetroceder2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(910, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 64);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(871, 93);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(189, 48);
            this.txtUser.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(871, 147);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(189, 48);
            this.txtPassword.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(910, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 64);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAvanzar2);
            this.Controls.Add(this.btnRetroceder2);
            this.Controls.Add(this.txtTestArray);
            this.Controls.Add(this.btnAvanzarArray);
            this.Controls.Add(this.btnRetrocederArray);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private loginDataSet loginDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private loginDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private loginDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.TextBox txtTestArray;
        private System.Windows.Forms.Button btnAvanzarArray;
        private System.Windows.Forms.Button btnRetrocederArray;
        private System.Windows.Forms.Button btnAvanzar2;
        private System.Windows.Forms.Button btnRetroceder2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button2;
    }
}

