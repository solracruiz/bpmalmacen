using System;

namespace bpmalmacen
{
    partial class Det_Entradas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grid_Articulos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_grabar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtrequisicion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcaducidad = new System.Windows.Forms.DateTimePicker();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.cbalmacen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbrecibio = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbproveedor = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbarea = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtnumero_factura = new System.Windows.Forms.TextBox();
            this.txtfecha_factura = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Grid_Det_Ent = new System.Windows.Forms.DataGridView();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_u = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_u = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_salir = new System.Windows.Forms.Button();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtiva = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Articulos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Det_Ent)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Articulos
            // 
            this.Grid_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Articulos.Location = new System.Drawing.Point(159, 215);
            this.Grid_Articulos.Name = "Grid_Articulos";
            this.Grid_Articulos.Size = new System.Drawing.Size(751, 186);
            this.Grid_Articulos.TabIndex = 14;
            this.Grid_Articulos.Visible = false;
            this.Grid_Articulos.DoubleClick += new System.EventHandler(this.Grid_Articulos_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tipo de Entrada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fecha de Entrada:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Almacen:";
            // 
            // bt_grabar
            // 
            this.bt_grabar.FlatAppearance.BorderSize = 0;
            this.bt_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_grabar.Image = global::bpmalmacen.Properties.Resources.SaveHH;
            this.bt_grabar.Location = new System.Drawing.Point(794, 51);
            this.bt_grabar.Name = "bt_grabar";
            this.bt_grabar.Size = new System.Drawing.Size(55, 66);
            this.bt_grabar.TabIndex = 9;
            this.bt_grabar.Text = "Aceptar";
            this.bt_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_grabar.UseVisualStyleBackColor = true;
            this.bt_grabar.Click += new System.EventHandler(this.bt_grabar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtrequisicion);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtmarca);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtcaducidad);
            this.panel1.Controls.Add(this.txtprecio);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtlote);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bt_agregar);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 67);
            this.panel1.TabIndex = 24;
            // 
            // txtrequisicion
            // 
            this.txtrequisicion.Location = new System.Drawing.Point(488, 33);
            this.txtrequisicion.Name = "txtrequisicion";
            this.txtrequisicion.Size = new System.Drawing.Size(67, 20);
            this.txtrequisicion.TabIndex = 14;
            this.txtrequisicion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtrequisicion_KeyDown_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(426, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Requisicion:";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(488, 9);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(67, 20);
            this.txtmarca.TabIndex = 12;
            this.txtmarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmarca_KeyDown_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Marca:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtcaducidad
            // 
            this.txtcaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtcaducidad.Location = new System.Drawing.Point(634, 33);
            this.txtcaducidad.Name = "txtcaducidad";
            this.txtcaducidad.Size = new System.Drawing.Size(73, 20);
            this.txtcaducidad.TabIndex = 15;
            this.txtcaducidad.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(335, 7);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(73, 20);
            this.txtprecio.TabIndex = 11;
            this.txtprecio.TextChanged += new System.EventHandler(this.txtprecio_TextChanged);
            this.txtprecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprecio_KeyDown);
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            this.txtprecio.Leave += new System.EventHandler(this.txtprecio_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(292, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Precio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(567, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Caducidad:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nombre:";
            // 
            // txtlote
            // 
            this.txtlote.Location = new System.Drawing.Point(634, 7);
            this.txtlote.Name = "txtlote";
            this.txtlote.Size = new System.Drawing.Size(73, 20);
            this.txtlote.TabIndex = 13;
            this.txtlote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtlote_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Lote:";
            // 
            // bt_agregar
            // 
            this.bt_agregar.FlatAppearance.BorderSize = 0;
            this.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar.Image = global::bpmalmacen.Properties.Resources.TaskHH;
            this.bt_agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_agregar.Location = new System.Drawing.Point(730, 3);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(54, 59);
            this.bt_agregar.TabIndex = 16;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            this.bt_agregar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bt_agregar_KeyDown);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(202, 7);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(73, 20);
            this.txtcantidad.TabIndex = 10;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyDown);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            this.txtcantidad.Leave += new System.EventHandler(this.txtcantidad_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cantidad:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(56, 33);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(352, 20);
            this.txtnombre.TabIndex = 12;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(56, 7);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(73, 20);
            this.txtid.TabIndex = 9;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            this.txtid.Leave += new System.EventHandler(this.txtid_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Producto:";
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "COMPRA",
            "DONACION",
            "TRASLADO"});
            this.cbtipo.Location = new System.Drawing.Point(117, 16);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(111, 21);
            this.cbtipo.TabIndex = 0;
            // 
            // txtfecha
            // 
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha.Location = new System.Drawing.Point(117, 44);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(111, 20);
            this.txtfecha.TabIndex = 1;
            this.txtfecha.Value = new System.DateTime(2018, 8, 22, 23, 52, 52, 0);
            // 
            // cbalmacen
            // 
            this.cbalmacen.FormattingEnabled = true;
            this.cbalmacen.Location = new System.Drawing.Point(311, 131);
            this.cbalmacen.Name = "cbalmacen";
            this.cbalmacen.Size = new System.Drawing.Size(442, 21);
            this.cbalmacen.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Recibio:";
            // 
            // cbrecibio
            // 
            this.cbrecibio.FormattingEnabled = true;
            this.cbrecibio.Location = new System.Drawing.Point(311, 99);
            this.cbrecibio.Name = "cbrecibio";
            this.cbrecibio.Size = new System.Drawing.Size(442, 21);
            this.cbrecibio.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtimporte);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.cbproveedor);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.cbarea);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtnumero_factura);
            this.panel2.Controls.Add(this.txtfecha_factura);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cbtipo);
            this.panel2.Controls.Add(this.cbrecibio);
            this.panel2.Controls.Add(this.txtfecha);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.bt_grabar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbalmacen);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(31, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 164);
            this.panel2.TabIndex = 23;
            // 
            // txtimporte
            // 
            this.txtimporte.Location = new System.Drawing.Point(117, 131);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(111, 20);
            this.txtimporte.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 138);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Importe de Factura:";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(308, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(388, 42);
            this.label16.TabIndex = 35;
            this.label16.Text = "E  N T R A D A   #";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Visible = false;
            // 
            // cbproveedor
            // 
            this.cbproveedor.FormattingEnabled = true;
            this.cbproveedor.Location = new System.Drawing.Point(311, 43);
            this.cbproveedor.Name = "cbproveedor";
            this.cbproveedor.Size = new System.Drawing.Size(442, 21);
            this.cbproveedor.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(252, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Proveedor:";
            // 
            // cbarea
            // 
            this.cbarea.FormattingEnabled = true;
            this.cbarea.Location = new System.Drawing.Point(311, 71);
            this.cbarea.Name = "cbarea";
            this.cbarea.Size = new System.Drawing.Size(442, 21);
            this.cbarea.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(252, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Area";
            // 
            // txtnumero_factura
            // 
            this.txtnumero_factura.Location = new System.Drawing.Point(117, 72);
            this.txtnumero_factura.Name = "txtnumero_factura";
            this.txtnumero_factura.Size = new System.Drawing.Size(111, 20);
            this.txtnumero_factura.TabIndex = 2;
            // 
            // txtfecha_factura
            // 
            this.txtfecha_factura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha_factura.Location = new System.Drawing.Point(117, 100);
            this.txtfecha_factura.Name = "txtfecha_factura";
            this.txtfecha_factura.Size = new System.Drawing.Size(111, 20);
            this.txtfecha_factura.TabIndex = 3;
            this.txtfecha_factura.Value = new System.DateTime(2018, 8, 22, 23, 52, 52, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Numero de Factura:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Fecha de Factura:";
            // 
            // Grid_Det_Ent
            // 
            this.Grid_Det_Ent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Det_Ent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo,
            this.Descripcion,
            this.cantidad,
            this.precio_u,
            this.costo_u,
            this.marca,
            this.requisicion,
            this.lote,
            this.caducidad});
            this.Grid_Det_Ent.Location = new System.Drawing.Point(31, 192);
            this.Grid_Det_Ent.Name = "Grid_Det_Ent";
            this.Grid_Det_Ent.ReadOnly = true;
            this.Grid_Det_Ent.Size = new System.Drawing.Size(879, 189);
            this.Grid_Det_Ent.TabIndex = 31;
            this.Grid_Det_Ent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Det_Ent_CellContentClick);
            this.Grid_Det_Ent.DoubleClick += new System.EventHandler(this.data_det_inv_DoubleClick);
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Articulo.Width = 75;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precio_u
            // 
            this.precio_u.HeaderText = "Precio";
            this.precio_u.Name = "precio_u";
            this.precio_u.ReadOnly = true;
            // 
            // costo_u
            // 
            this.costo_u.HeaderText = "Costo";
            this.costo_u.Name = "costo_u";
            this.costo_u.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // requisicion
            // 
            this.requisicion.HeaderText = "Requisicion";
            this.requisicion.Name = "requisicion";
            this.requisicion.ReadOnly = true;
            // 
            // lote
            // 
            this.lote.HeaderText = "Lote";
            this.lote.Name = "lote";
            this.lote.ReadOnly = true;
            // 
            // caducidad
            // 
            this.caducidad.HeaderText = "Caducidad";
            this.caducidad.Name = "caducidad";
            this.caducidad.ReadOnly = true;
            // 
            // bt_salir
            // 
            this.bt_salir.FlatAppearance.BorderSize = 0;
            this.bt_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salir.Image = global::bpmalmacen.Properties.Resources.ClosePreviewHH;
            this.bt_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_salir.Location = new System.Drawing.Point(859, 406);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(51, 58);
            this.bt_salir.TabIndex = 32;
            this.bt_salir.Text = "Salir";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(837, 380);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(73, 20);
            this.txtcosto.TabIndex = 38;
            this.txtcosto.Visible = false;
            // 
            // txtiva
            // 
            this.txtiva.Location = new System.Drawing.Point(859, 361);
            this.txtiva.Name = "txtiva";
            this.txtiva.Size = new System.Drawing.Size(73, 20);
            this.txtiva.TabIndex = 39;
            this.txtiva.Visible = false;
            // 
            // Det_Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 471);
            this.Controls.Add(this.txtiva);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.Grid_Articulos);
            this.Controls.Add(this.Grid_Det_Ent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Det_Entradas";
            this.Text = "Detalles de Entrada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Det_Entradas_FormClosing);
            this.Load += new System.EventHandler(this.Det_Entradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Articulos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Det_Ent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Grid_Articulos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_grabar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.ComboBox cbalmacen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbrecibio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView Grid_Det_Ent;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.TextBox txtnumero_factura;
        private System.Windows.Forms.DateTimePicker txtfecha_factura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbproveedor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbarea;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtcaducidad;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtrequisicion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_u;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_u;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn requisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn caducidad;
    }
}