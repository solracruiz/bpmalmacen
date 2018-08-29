using System;

namespace bpmalmacen
{
    partial class Det_Salidas
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
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrequisicion = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtcaducidad = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.cbalmacen = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbentrego = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbarea = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Grid_Det_Sal = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Det_Sal)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Articulos
            // 
            this.Grid_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Articulos.Location = new System.Drawing.Point(159, 189);
            this.Grid_Articulos.Name = "Grid_Articulos";
            this.Grid_Articulos.Size = new System.Drawing.Size(643, 186);
            this.Grid_Articulos.TabIndex = 14;
            this.Grid_Articulos.Visible = false;
            this.Grid_Articulos.DoubleClick += new System.EventHandler(this.Grid_Articulos_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tipo de Entrada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fecha de Entrada:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 108);
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
            this.bt_grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_grabar.Location = new System.Drawing.Point(672, 384);
            this.bt_grabar.Name = "bt_grabar";
            this.bt_grabar.Size = new System.Drawing.Size(55, 54);
            this.bt_grabar.TabIndex = 13;
            this.bt_grabar.Text = "Aceptar";
            this.bt_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_grabar.UseVisualStyleBackColor = true;
            this.bt_grabar.Click += new System.EventHandler(this.bt_grabar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtprecio);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bt_agregar);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 67);
            this.panel1.TabIndex = 24;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(335, 7);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(73, 20);
            this.txtprecio.TabIndex = 11;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nombre:";
            // 
            // bt_agregar
            // 
            this.bt_agregar.FlatAppearance.BorderSize = 0;
            this.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar.Image = global::bpmalmacen.Properties.Resources.TaskHH;
            this.bt_agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_agregar.Location = new System.Drawing.Point(446, 3);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(54, 59);
            this.bt_agregar.TabIndex = 12;
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
            // txtrequisicion
            // 
            this.txtrequisicion.Location = new System.Drawing.Point(117, 72);
            this.txtrequisicion.Name = "txtrequisicion";
            this.txtrequisicion.Size = new System.Drawing.Size(111, 20);
            this.txtrequisicion.TabIndex = 14;
            this.txtrequisicion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtrequisicion_KeyDown_1);
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(702, 309);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(67, 20);
            this.txtmarca.TabIndex = 12;
            this.txtmarca.Visible = false;
            this.txtmarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmarca_KeyDown_1);
            // 
            // txtcaducidad
            // 
            this.txtcaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtcaducidad.Location = new System.Drawing.Point(702, 238);
            this.txtcaducidad.Name = "txtcaducidad";
            this.txtcaducidad.Size = new System.Drawing.Size(73, 20);
            this.txtcaducidad.TabIndex = 15;
            this.txtcaducidad.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.txtcaducidad.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(635, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Caducidad:";
            this.label10.Visible = false;
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "PEDIDO",
            "BAJA",
            "TRASLADO",
            "AJUSTE",
            "DEVOLUCION"});
            this.cbtipo.Location = new System.Drawing.Point(117, 15);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(111, 21);
            this.cbtipo.TabIndex = 0;
            this.cbtipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbtipo_KeyDown);
            // 
            // txtfecha
            // 
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha.Location = new System.Drawing.Point(117, 43);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(111, 20);
            this.txtfecha.TabIndex = 1;
            this.txtfecha.Value = new System.DateTime(2018, 8, 22, 23, 52, 52, 0);
            this.txtfecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfecha_KeyDown);
            // 
            // cbalmacen
            // 
            this.cbalmacen.FormattingEnabled = true;
            this.cbalmacen.Location = new System.Drawing.Point(311, 100);
            this.cbalmacen.Name = "cbalmacen";
            this.cbalmacen.Size = new System.Drawing.Size(442, 21);
            this.cbalmacen.TabIndex = 5;
            this.cbalmacen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbalmacen_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtrequisicion);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtimporte);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.cbentrego);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.cbarea);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cbtipo);
            this.panel2.Controls.Add(this.txtfecha);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbalmacen);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(31, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 133);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Requisicion:";
            // 
            // txtimporte
            // 
            this.txtimporte.Enabled = false;
            this.txtimporte.Location = new System.Drawing.Point(117, 101);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(111, 20);
            this.txtimporte.TabIndex = 2;
            this.txtimporte.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Importe Total:";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(234, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(350, 40);
            this.label16.TabIndex = 35;
            this.label16.Text = "S A L I D A    #";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Visible = false;
            // 
            // cbentrego
            // 
            this.cbentrego.FormattingEnabled = true;
            this.cbentrego.Location = new System.Drawing.Point(311, 43);
            this.cbentrego.Name = "cbentrego";
            this.cbentrego.Size = new System.Drawing.Size(442, 21);
            this.cbentrego.TabIndex = 3;
            this.cbentrego.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbentrego_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(252, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Entrego:";
            // 
            // cbarea
            // 
            this.cbarea.FormattingEnabled = true;
            this.cbarea.Location = new System.Drawing.Point(311, 71);
            this.cbarea.Name = "cbarea";
            this.cbarea.Size = new System.Drawing.Size(442, 21);
            this.cbarea.TabIndex = 4;
            this.cbarea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbarea_KeyDown);
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
            // Grid_Det_Sal
            // 
            this.Grid_Det_Sal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Det_Sal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo,
            this.Descripcion,
            this.cantidad,
            this.precio_u,
            this.costo_u,
            this.marca,
            this.requisicion,
            this.lote,
            this.caducidad});
            this.Grid_Det_Sal.Location = new System.Drawing.Point(31, 166);
            this.Grid_Det_Sal.Name = "Grid_Det_Sal";
            this.Grid_Det_Sal.ReadOnly = true;
            this.Grid_Det_Sal.Size = new System.Drawing.Size(771, 189);
            this.Grid_Det_Sal.TabIndex = 31;
            this.Grid_Det_Sal.DoubleClick += new System.EventHandler(this.Grid_Det_Sal_DoubleClick);
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
            this.bt_salir.Location = new System.Drawing.Point(751, 380);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(51, 58);
            this.bt_salir.TabIndex = 14;
            this.bt_salir.Text = "Salir";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(702, 284);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(73, 20);
            this.txtcosto.TabIndex = 38;
            this.txtcosto.Visible = false;
            // 
            // txtiva
            // 
            this.txtiva.Location = new System.Drawing.Point(702, 264);
            this.txtiva.Name = "txtiva";
            this.txtiva.Size = new System.Drawing.Size(73, 20);
            this.txtiva.TabIndex = 39;
            this.txtiva.Visible = false;
            // 
            // Det_Salidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 448);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtiva);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtcaducidad);
            this.Controls.Add(this.Grid_Articulos);
            this.Controls.Add(this.bt_grabar);
            this.Controls.Add(this.Grid_Det_Sal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Name = "Det_Salidas";
            this.Text = "Detalles de Salida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Det_Salidas_FormClosing);
            this.Load += new System.EventHandler(this.Det_Salidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Articulos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Det_Sal)).EndInit();
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
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.ComboBox cbalmacen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView Grid_Det_Sal;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.ComboBox cbentrego;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbarea;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker txtcaducidad;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtrequisicion;
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
    }
}