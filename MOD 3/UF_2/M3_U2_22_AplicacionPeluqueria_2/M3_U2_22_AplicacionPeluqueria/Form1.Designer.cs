
namespace M3_U2_22_AplicacionPeluqueria
{
    partial class frmGestionPeluqueria
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpClientes = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBajaCliente = new System.Windows.Forms.Button();
            this.btnModificacionCliente = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.lbClientes = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpProductos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBajaProducto = new System.Windows.Forms.Button();
            this.btnModificacionProducto = new System.Windows.Forms.Button();
            this.btnAltaProducto = new System.Windows.Forms.Button();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtProductoStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductoPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductoNombre = new System.Windows.Forms.TextBox();
            this.txtProductoId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpServicios = new System.Windows.Forms.TabPage();
            this.tpTrabajdores = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTrabajadoresBaja = new System.Windows.Forms.Button();
            this.btnTrabajadoresModificacion = new System.Windows.Forms.Button();
            this.btnTrabajadoresAlta = new System.Windows.Forms.Button();
            this.lbTrabajadores = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTrabajadoresNombre = new System.Windows.Forms.TextBox();
            this.txtTrabajadoresId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tpTicketProductos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTicketProductoNuevo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTicketProductoTotal = new System.Windows.Forms.TextBox();
            this.txtTicketProductoTrabajador = new System.Windows.Forms.TextBox();
            this.txtTicketProductoCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTicketProductoFecha = new System.Windows.Forms.TextBox();
            this.txtTicketProductoNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbDetalleTicketsProductos = new System.Windows.Forms.ListBox();
            this.lbTicketsPRoductos = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tpClientes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpProductos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpTrabajdores.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpTicketProductos.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpClientes);
            this.tabControl1.Controls.Add(this.tpProductos);
            this.tabControl1.Controls.Add(this.tpServicios);
            this.tabControl1.Controls.Add(this.tpTrabajdores);
            this.tabControl1.Controls.Add(this.tpTicketProductos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2436, 1014);
            this.tabControl1.TabIndex = 0;
            // 
            // tpClientes
            // 
            this.tpClientes.Controls.Add(this.tableLayoutPanel1);
            this.tpClientes.Location = new System.Drawing.Point(10, 78);
            this.tpClientes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpClientes.Name = "tpClientes";
            this.tpClientes.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpClientes.Size = new System.Drawing.Size(2416, 926);
            this.tpClientes.TabIndex = 0;
            this.tpClientes.Text = "Clientes";
            this.tpClientes.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.btnBajaCliente, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnModificacionCliente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAltaCliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbClientes, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.2107F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.7893F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2406, 916);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnBajaCliente
            // 
            this.btnBajaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBajaCliente.Location = new System.Drawing.Point(485, 5);
            this.btnBajaCliente.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBajaCliente.Name = "btnBajaCliente";
            this.btnBajaCliente.Size = new System.Drawing.Size(230, 111);
            this.btnBajaCliente.TabIndex = 2;
            this.btnBajaCliente.Text = "Baja";
            this.btnBajaCliente.UseVisualStyleBackColor = true;
            // 
            // btnModificacionCliente
            // 
            this.btnModificacionCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificacionCliente.Location = new System.Drawing.Point(245, 5);
            this.btnModificacionCliente.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnModificacionCliente.Name = "btnModificacionCliente";
            this.btnModificacionCliente.Size = new System.Drawing.Size(230, 111);
            this.btnModificacionCliente.TabIndex = 1;
            this.btnModificacionCliente.Text = "Mod.";
            this.btnModificacionCliente.UseVisualStyleBackColor = true;
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAltaCliente.Location = new System.Drawing.Point(5, 5);
            this.btnAltaCliente.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(230, 111);
            this.btnAltaCliente.TabIndex = 0;
            this.btnAltaCliente.Text = "Alta";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            // 
            // lbClientes
            // 
            this.lbClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.ItemHeight = 61;
            this.lbClientes.Location = new System.Drawing.Point(1686, 126);
            this.lbClientes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(715, 785);
            this.lbClientes.TabIndex = 3;
            this.lbClientes.SelectedIndexChanged += new System.EventHandler(this.lbClientes_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 6);
            this.panel1.Controls.Add(this.txtClienteNombre);
            this.panel1.Controls.Add(this.txtClienteId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1671, 785);
            this.panel1.TabIndex = 4;
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Location = new System.Drawing.Point(350, 161);
            this.txtClienteNombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(623, 68);
            this.txtClienteNombre.TabIndex = 3;
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(350, 73);
            this.txtClienteId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(175, 68);
            this.txtClienteId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id.";
            // 
            // tpProductos
            // 
            this.tpProductos.Controls.Add(this.tableLayoutPanel2);
            this.tpProductos.Location = new System.Drawing.Point(10, 78);
            this.tpProductos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpProductos.Name = "tpProductos";
            this.tpProductos.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpProductos.Size = new System.Drawing.Size(2416, 926);
            this.tpProductos.TabIndex = 1;
            this.tpProductos.Text = "Productos";
            this.tpProductos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.btnBajaProducto, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnModificacionProducto, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAltaProducto, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbProductos, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.2107F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.7893F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(2406, 916);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnBajaProducto
            // 
            this.btnBajaProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBajaProducto.Location = new System.Drawing.Point(485, 5);
            this.btnBajaProducto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBajaProducto.Name = "btnBajaProducto";
            this.btnBajaProducto.Size = new System.Drawing.Size(230, 111);
            this.btnBajaProducto.TabIndex = 2;
            this.btnBajaProducto.Text = "Baja";
            this.btnBajaProducto.UseVisualStyleBackColor = true;
            // 
            // btnModificacionProducto
            // 
            this.btnModificacionProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificacionProducto.Location = new System.Drawing.Point(245, 5);
            this.btnModificacionProducto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnModificacionProducto.Name = "btnModificacionProducto";
            this.btnModificacionProducto.Size = new System.Drawing.Size(230, 111);
            this.btnModificacionProducto.TabIndex = 1;
            this.btnModificacionProducto.Text = "Mod.";
            this.btnModificacionProducto.UseVisualStyleBackColor = true;
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAltaProducto.Location = new System.Drawing.Point(5, 5);
            this.btnAltaProducto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(230, 111);
            this.btnAltaProducto.TabIndex = 0;
            this.btnAltaProducto.Text = "Alta";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            // 
            // lbProductos
            // 
            this.lbProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.ItemHeight = 61;
            this.lbProductos.Location = new System.Drawing.Point(1686, 126);
            this.lbProductos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(715, 785);
            this.lbProductos.TabIndex = 3;
            this.lbProductos.SelectedIndexChanged += new System.EventHandler(this.lbProductos_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel2, 6);
            this.panel2.Controls.Add(this.txtProductoStock);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtProductoPrecio);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtProductoNombre);
            this.panel2.Controls.Add(this.txtProductoId);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 126);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1671, 785);
            this.panel2.TabIndex = 4;
            // 
            // txtProductoStock
            // 
            this.txtProductoStock.Location = new System.Drawing.Point(446, 363);
            this.txtProductoStock.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtProductoStock.Name = "txtProductoStock";
            this.txtProductoStock.Size = new System.Drawing.Size(240, 68);
            this.txtProductoStock.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 363);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 63);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stock";
            // 
            // txtProductoPrecio
            // 
            this.txtProductoPrecio.Location = new System.Drawing.Point(446, 268);
            this.txtProductoPrecio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtProductoPrecio.Name = "txtProductoPrecio";
            this.txtProductoPrecio.Size = new System.Drawing.Size(392, 68);
            this.txtProductoPrecio.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 63);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // txtProductoNombre
            // 
            this.txtProductoNombre.Location = new System.Drawing.Point(446, 166);
            this.txtProductoNombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtProductoNombre.Name = "txtProductoNombre";
            this.txtProductoNombre.Size = new System.Drawing.Size(630, 68);
            this.txtProductoNombre.TabIndex = 3;
            // 
            // txtProductoId
            // 
            this.txtProductoId.Location = new System.Drawing.Point(446, 77);
            this.txtProductoId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtProductoId.Name = "txtProductoId";
            this.txtProductoId.Size = new System.Drawing.Size(182, 68);
            this.txtProductoId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 63);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 63);
            this.label4.TabIndex = 0;
            this.label4.Text = "Id.";
            // 
            // tpServicios
            // 
            this.tpServicios.Location = new System.Drawing.Point(10, 78);
            this.tpServicios.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpServicios.Name = "tpServicios";
            this.tpServicios.Size = new System.Drawing.Size(2416, 926);
            this.tpServicios.TabIndex = 2;
            this.tpServicios.Text = "Servicios";
            this.tpServicios.UseVisualStyleBackColor = true;
            // 
            // tpTrabajdores
            // 
            this.tpTrabajdores.Controls.Add(this.tableLayoutPanel3);
            this.tpTrabajdores.Location = new System.Drawing.Point(10, 78);
            this.tpTrabajdores.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpTrabajdores.Name = "tpTrabajdores";
            this.tpTrabajdores.Size = new System.Drawing.Size(2416, 926);
            this.tpTrabajdores.TabIndex = 3;
            this.tpTrabajdores.Text = "Trabajadores";
            this.tpTrabajdores.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.btnTrabajadoresBaja, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnTrabajadoresModificacion, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnTrabajadoresAlta, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbTrabajadores, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.2107F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.7893F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(2416, 926);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnTrabajadoresBaja
            // 
            this.btnTrabajadoresBaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrabajadoresBaja.Location = new System.Drawing.Point(487, 5);
            this.btnTrabajadoresBaja.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnTrabajadoresBaja.Name = "btnTrabajadoresBaja";
            this.btnTrabajadoresBaja.Size = new System.Drawing.Size(231, 112);
            this.btnTrabajadoresBaja.TabIndex = 2;
            this.btnTrabajadoresBaja.Text = "Baja";
            this.btnTrabajadoresBaja.UseVisualStyleBackColor = true;
            // 
            // btnTrabajadoresModificacion
            // 
            this.btnTrabajadoresModificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrabajadoresModificacion.Location = new System.Drawing.Point(246, 5);
            this.btnTrabajadoresModificacion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnTrabajadoresModificacion.Name = "btnTrabajadoresModificacion";
            this.btnTrabajadoresModificacion.Size = new System.Drawing.Size(231, 112);
            this.btnTrabajadoresModificacion.TabIndex = 1;
            this.btnTrabajadoresModificacion.Text = "Mod.";
            this.btnTrabajadoresModificacion.UseVisualStyleBackColor = true;
            // 
            // btnTrabajadoresAlta
            // 
            this.btnTrabajadoresAlta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrabajadoresAlta.Location = new System.Drawing.Point(5, 5);
            this.btnTrabajadoresAlta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnTrabajadoresAlta.Name = "btnTrabajadoresAlta";
            this.btnTrabajadoresAlta.Size = new System.Drawing.Size(231, 112);
            this.btnTrabajadoresAlta.TabIndex = 0;
            this.btnTrabajadoresAlta.Text = "Alta";
            this.btnTrabajadoresAlta.UseVisualStyleBackColor = true;
            // 
            // lbTrabajadores
            // 
            this.lbTrabajadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTrabajadores.FormattingEnabled = true;
            this.lbTrabajadores.ItemHeight = 61;
            this.lbTrabajadores.Location = new System.Drawing.Point(1693, 127);
            this.lbTrabajadores.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lbTrabajadores.Name = "lbTrabajadores";
            this.lbTrabajadores.Size = new System.Drawing.Size(718, 794);
            this.lbTrabajadores.TabIndex = 3;
            this.lbTrabajadores.SelectedIndexChanged += new System.EventHandler(this.lbTrabajadores_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.panel3, 6);
            this.panel3.Controls.Add(this.txtTrabajadoresNombre);
            this.panel3.Controls.Add(this.txtTrabajadoresId);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 127);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1678, 794);
            this.panel3.TabIndex = 4;
            // 
            // txtTrabajadoresNombre
            // 
            this.txtTrabajadoresNombre.Location = new System.Drawing.Point(446, 166);
            this.txtTrabajadoresNombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTrabajadoresNombre.Name = "txtTrabajadoresNombre";
            this.txtTrabajadoresNombre.Size = new System.Drawing.Size(630, 68);
            this.txtTrabajadoresNombre.TabIndex = 3;
            // 
            // txtTrabajadoresId
            // 
            this.txtTrabajadoresId.Location = new System.Drawing.Point(446, 77);
            this.txtTrabajadoresId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTrabajadoresId.Name = "txtTrabajadoresId";
            this.txtTrabajadoresId.Size = new System.Drawing.Size(182, 68);
            this.txtTrabajadoresId.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 166);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 63);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 77);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 63);
            this.label10.TabIndex = 0;
            this.label10.Text = "Id.";
            // 
            // tpTicketProductos
            // 
            this.tpTicketProductos.Controls.Add(this.tableLayoutPanel4);
            this.tpTicketProductos.Location = new System.Drawing.Point(10, 78);
            this.tpTicketProductos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpTicketProductos.Name = "tpTicketProductos";
            this.tpTicketProductos.Size = new System.Drawing.Size(2416, 926);
            this.tpTicketProductos.TabIndex = 4;
            this.tpTicketProductos.Text = "Ticket Productos";
            this.tpTicketProductos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.btnTicketProductoNuevo, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbDetalleTicketsProductos, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbTicketsPRoductos, 6, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.2107F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.7893F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(2421, 936);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // btnTicketProductoNuevo
            // 
            this.btnTicketProductoNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTicketProductoNuevo.Location = new System.Drawing.Point(5, 5);
            this.btnTicketProductoNuevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnTicketProductoNuevo.Name = "btnTicketProductoNuevo";
            this.btnTicketProductoNuevo.Size = new System.Drawing.Size(232, 113);
            this.btnTicketProductoNuevo.TabIndex = 0;
            this.btnTicketProductoNuevo.Text = "Nuevo";
            this.btnTicketProductoNuevo.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.panel4, 4);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtTicketProductoTotal);
            this.panel4.Controls.Add(this.txtTicketProductoTrabajador);
            this.panel4.Controls.Add(this.txtTicketProductoCliente);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtTicketProductoFecha);
            this.panel4.Controls.Add(this.txtTicketProductoNumero);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(5, 128);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(958, 803);
            this.panel4.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(750, 608);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 63);
            this.label13.TabIndex = 9;
            this.label13.Text = "Total";
            // 
            // txtTicketProductoTotal
            // 
            this.txtTicketProductoTotal.Location = new System.Drawing.Point(537, 693);
            this.txtTicketProductoTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTicketProductoTotal.Name = "txtTicketProductoTotal";
            this.txtTicketProductoTotal.Size = new System.Drawing.Size(361, 68);
            this.txtTicketProductoTotal.TabIndex = 8;
            // 
            // txtTicketProductoTrabajador
            // 
            this.txtTicketProductoTrabajador.Location = new System.Drawing.Point(361, 356);
            this.txtTicketProductoTrabajador.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTicketProductoTrabajador.Name = "txtTicketProductoTrabajador";
            this.txtTicketProductoTrabajador.Size = new System.Drawing.Size(537, 68);
            this.txtTicketProductoTrabajador.TabIndex = 7;
            // 
            // txtTicketProductoCliente
            // 
            this.txtTicketProductoCliente.Location = new System.Drawing.Point(361, 268);
            this.txtTicketProductoCliente.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTicketProductoCliente.Name = "txtTicketProductoCliente";
            this.txtTicketProductoCliente.Size = new System.Drawing.Size(537, 68);
            this.txtTicketProductoCliente.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 356);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(289, 63);
            this.label11.TabIndex = 5;
            this.label11.Text = "Trabajador";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 268);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 63);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cliente";
            // 
            // txtTicketProductoFecha
            // 
            this.txtTicketProductoFecha.Location = new System.Drawing.Point(361, 166);
            this.txtTicketProductoFecha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTicketProductoFecha.Name = "txtTicketProductoFecha";
            this.txtTicketProductoFecha.Size = new System.Drawing.Size(537, 68);
            this.txtTicketProductoFecha.TabIndex = 3;
            // 
            // txtTicketProductoNumero
            // 
            this.txtTicketProductoNumero.Location = new System.Drawing.Point(361, 64);
            this.txtTicketProductoNumero.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTicketProductoNumero.Name = "txtTicketProductoNumero";
            this.txtTicketProductoNumero.Size = new System.Drawing.Size(418, 68);
            this.txtTicketProductoNumero.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 63);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 63);
            this.label8.TabIndex = 0;
            this.label8.Text = "Número";
            // 
            // lbDetalleTicketsProductos
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.lbDetalleTicketsProductos, 2);
            this.lbDetalleTicketsProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDetalleTicketsProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetalleTicketsProductos.FormattingEnabled = true;
            this.lbDetalleTicketsProductos.ItemHeight = 46;
            this.lbDetalleTicketsProductos.Location = new System.Drawing.Point(972, 126);
            this.lbDetalleTicketsProductos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbDetalleTicketsProductos.Name = "lbDetalleTicketsProductos";
            this.lbDetalleTicketsProductos.Size = new System.Drawing.Size(718, 807);
            this.lbDetalleTicketsProductos.TabIndex = 8;
            // 
            // lbTicketsPRoductos
            // 
            this.lbTicketsPRoductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTicketsPRoductos.FormattingEnabled = true;
            this.lbTicketsPRoductos.ItemHeight = 61;
            this.lbTicketsPRoductos.Location = new System.Drawing.Point(1698, 126);
            this.lbTicketsPRoductos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbTicketsPRoductos.Name = "lbTicketsPRoductos";
            this.lbTicketsPRoductos.Size = new System.Drawing.Size(719, 807);
            this.lbTicketsPRoductos.TabIndex = 9;
            this.lbTicketsPRoductos.SelectedIndexChanged += new System.EventHandler(this.lbTicketsPRoductos_SelectedIndexChanged);
            // 
            // frmGestionPeluqueria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2436, 1014);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmGestionPeluqueria";
            this.Text = "Gestion Peluqueria v1.0";
            this.Load += new System.EventHandler(this.frmGestionPeluqueria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpClientes.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpProductos.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpTrabajdores.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpTicketProductos.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpClientes;
        private System.Windows.Forms.TabPage tpProductos;
        private System.Windows.Forms.TabPage tpServicios;
        private System.Windows.Forms.TabPage tpTrabajdores;
        private System.Windows.Forms.TabPage tpTicketProductos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBajaCliente;
        private System.Windows.Forms.Button btnModificacionCliente;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.ListBox lbClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnBajaProducto;
        private System.Windows.Forms.Button btnModificacionProducto;
        private System.Windows.Forms.Button btnAltaProducto;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtProductoStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductoPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductoNombre;
        private System.Windows.Forms.TextBox txtProductoId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnTrabajadoresBaja;
        private System.Windows.Forms.Button btnTrabajadoresModificacion;
        private System.Windows.Forms.Button btnTrabajadoresAlta;
        private System.Windows.Forms.ListBox lbTrabajadores;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTrabajadoresNombre;
        private System.Windows.Forms.TextBox txtTrabajadoresId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnTicketProductoNuevo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTicketProductoTotal;
        private System.Windows.Forms.TextBox txtTicketProductoTrabajador;
        private System.Windows.Forms.TextBox txtTicketProductoCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTicketProductoFecha;
        private System.Windows.Forms.TextBox txtTicketProductoNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbDetalleTicketsProductos;
        private System.Windows.Forms.ListBox lbTicketsPRoductos;
    }
}

