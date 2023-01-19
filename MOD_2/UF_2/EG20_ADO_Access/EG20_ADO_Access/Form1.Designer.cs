
namespace EG20_ADO_Access
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idCompanhiaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label actividadPrincipalLabel;
            this.ejercitoV2DataSet = new EG20_ADO_Access.EjercitoV2DataSet();
            this.companhiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companhiasTableAdapter = new EG20_ADO_Access.EjercitoV2DataSetTableAdapters.companhiasTableAdapter();
            this.tableAdapterManager = new EG20_ADO_Access.EjercitoV2DataSetTableAdapters.TableAdapterManager();
            this.companhiasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.companhiasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idCompanhiaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.actividadPrincipalTextBox = new System.Windows.Forms.TextBox();
            idCompanhiaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            actividadPrincipalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ejercitoV2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companhiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companhiasBindingNavigator)).BeginInit();
            this.companhiasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ejercitoV2DataSet
            // 
            this.ejercitoV2DataSet.DataSetName = "EjercitoV2DataSet";
            this.ejercitoV2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companhiasBindingSource
            // 
            this.companhiasBindingSource.DataMember = "companhias";
            this.companhiasBindingSource.DataSource = this.ejercitoV2DataSet;
            // 
            // companhiasTableAdapter
            // 
            this.companhiasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.companhiasTableAdapter = this.companhiasTableAdapter;
            this.tableAdapterManager.cuartelesTableAdapter = null;
            this.tableAdapterManager.cuerposTableAdapter = null;
            this.tableAdapterManager.serviciosRealizadosTableAdapter = null;
            this.tableAdapterManager.serviciosTableAdapter = null;
            this.tableAdapterManager.soldadosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EG20_ADO_Access.EjercitoV2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // companhiasBindingNavigator
            // 
            this.companhiasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.companhiasBindingNavigator.BindingSource = this.companhiasBindingSource;
            this.companhiasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.companhiasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.companhiasBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.companhiasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.companhiasBindingNavigatorSaveItem});
            this.companhiasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.companhiasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.companhiasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.companhiasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.companhiasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.companhiasBindingNavigator.Name = "companhiasBindingNavigator";
            this.companhiasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.companhiasBindingNavigator.Size = new System.Drawing.Size(800, 38);
            this.companhiasBindingNavigator.TabIndex = 0;
            this.companhiasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 33);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // companhiasBindingNavigatorSaveItem
            // 
            this.companhiasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.companhiasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("companhiasBindingNavigatorSaveItem.Image")));
            this.companhiasBindingNavigatorSaveItem.Name = "companhiasBindingNavigatorSaveItem";
            this.companhiasBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.companhiasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.companhiasBindingNavigatorSaveItem.Click += new System.EventHandler(this.companhiasBindingNavigatorSaveItem_Click);
            // 
            // idCompanhiaLabel
            // 
            idCompanhiaLabel.AutoSize = true;
            idCompanhiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idCompanhiaLabel.Location = new System.Drawing.Point(103, 124);
            idCompanhiaLabel.Name = "idCompanhiaLabel";
            idCompanhiaLabel.Size = new System.Drawing.Size(225, 37);
            idCompanhiaLabel.TabIndex = 1;
            idCompanhiaLabel.Text = "id Companhia:";
            // 
            // idCompanhiaTextBox
            // 
            this.idCompanhiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companhiasBindingSource, "idCompanhia", true));
            this.idCompanhiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCompanhiaTextBox.Location = new System.Drawing.Point(348, 124);
            this.idCompanhiaTextBox.Name = "idCompanhiaTextBox";
            this.idCompanhiaTextBox.Size = new System.Drawing.Size(100, 44);
            this.idCompanhiaTextBox.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(193, 182);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(135, 37);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companhiasBindingSource, "nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(348, 182);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(318, 44);
            this.nombreTextBox.TabIndex = 4;
            // 
            // actividadPrincipalLabel
            // 
            actividadPrincipalLabel.AutoSize = true;
            actividadPrincipalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            actividadPrincipalLabel.Location = new System.Drawing.Point(44, 246);
            actividadPrincipalLabel.Name = "actividadPrincipalLabel";
            actividadPrincipalLabel.Size = new System.Drawing.Size(284, 37);
            actividadPrincipalLabel.TabIndex = 5;
            actividadPrincipalLabel.Text = "actividad Principal:";
            // 
            // actividadPrincipalTextBox
            // 
            this.actividadPrincipalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companhiasBindingSource, "actividadPrincipal", true));
            this.actividadPrincipalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actividadPrincipalTextBox.Location = new System.Drawing.Point(348, 246);
            this.actividadPrincipalTextBox.Name = "actividadPrincipalTextBox";
            this.actividadPrincipalTextBox.Size = new System.Drawing.Size(318, 44);
            this.actividadPrincipalTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(actividadPrincipalLabel);
            this.Controls.Add(this.actividadPrincipalTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(idCompanhiaLabel);
            this.Controls.Add(this.idCompanhiaTextBox);
            this.Controls.Add(this.companhiasBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejercitoV2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companhiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companhiasBindingNavigator)).EndInit();
            this.companhiasBindingNavigator.ResumeLayout(false);
            this.companhiasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EjercitoV2DataSet ejercitoV2DataSet;
        private System.Windows.Forms.BindingSource companhiasBindingSource;
        private EjercitoV2DataSetTableAdapters.companhiasTableAdapter companhiasTableAdapter;
        private EjercitoV2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator companhiasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton companhiasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idCompanhiaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox actividadPrincipalTextBox;
    }
}

