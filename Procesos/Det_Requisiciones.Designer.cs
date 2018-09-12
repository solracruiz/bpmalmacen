using System;

namespace bpmalmacen
{
    partial class Det_Requisiciones
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
            this.txtespecificaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.cbproyecto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbsolicito = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtjustificacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbentregar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbfuente = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbarea = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especificaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_salir = new System.Windows.Forms.Button();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtiva = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Articulos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
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
            this.label7.Location = new System.Drawing.Point(6, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tipo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fecha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Proyecto:";
            // 
            // bt_grabar
            // 
            this.bt_grabar.FlatAppearance.BorderSize = 0;
            this.bt_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_grabar.Image = global::bpmalmacen.Properties.Resources.SaveHH;
            this.bt_grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_grabar.Location = new System.Drawing.Point(799, 406);
            this.bt_grabar.Name = "bt_grabar";
            this.bt_grabar.Size = new System.Drawing.Size(55, 57);
            this.bt_grabar.TabIndex = 13;
            this.bt_grabar.Text = "Aceptar";
            this.bt_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_grabar.UseVisualStyleBackColor = true;
            this.bt_grabar.Click += new System.EventHandler(this.bt_grabar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtespecificaciones);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bt_agregar);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 67);
            this.panel1.TabIndex = 24;
            // 
            // txtespecificaciones
            // 
            this.txtespecificaciones.Location = new System.Drawing.Point(343, 9);
            this.txtespecificaciones.Multiline = true;
            this.txtespecificaciones.Name = "txtespecificaciones";
            this.txtespecificaciones.Size = new System.Drawing.Size(353, 44);
            this.txtespecificaciones.TabIndex = 11;
            this.txtespecificaciones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtespecificaciones_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Especificaciones:";
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
            this.bt_agregar.Location = new System.Drawing.Point(702, 6);
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
            this.txtcantidad.Location = new System.Drawing.Point(193, 8);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(47, 20);
            this.txtcantidad.TabIndex = 10;
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyDown);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            this.txtcantidad.Leave += new System.EventHandler(this.txtcantidad_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 14);
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
            this.txtnombre.Size = new System.Drawing.Size(281, 20);
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
            "ALMACEN"});
            this.cbtipo.Location = new System.Drawing.Point(83, 37);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(113, 21);
            this.cbtipo.TabIndex = 0;
            // 
            // txtfecha
            // 
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha.Location = new System.Drawing.Point(311, 37);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(109, 20);
            this.txtfecha.TabIndex = 1;
            this.txtfecha.Value = new System.DateTime(2018, 8, 22, 23, 52, 52, 0);
            // 
            // cbproyecto
            // 
            this.cbproyecto.FormattingEnabled = true;
            this.cbproyecto.Location = new System.Drawing.Point(515, 99);
            this.cbproyecto.Name = "cbproyecto";
            this.cbproyecto.Size = new System.Drawing.Size(336, 21);
            this.cbproyecto.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Solicita:";
            // 
            // cbsolicito
            // 
            this.cbsolicito.FormattingEnabled = true;
            this.cbsolicito.Location = new System.Drawing.Point(83, 68);
            this.cbsolicito.Name = "cbsolicito";
            this.cbsolicito.Size = new System.Drawing.Size(337, 21);
            this.cbsolicito.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtjustificacion);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbentregar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.cbfuente);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.cbarea);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cbtipo);
            this.panel2.Controls.Add(this.cbsolicito);
            this.panel2.Controls.Add(this.txtfecha);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbproyecto);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(31, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 170);
            this.panel2.TabIndex = 0;
            // 
            // txtjustificacion
            // 
            this.txtjustificacion.Location = new System.Drawing.Point(515, 131);
            this.txtjustificacion.Multiline = true;
            this.txtjustificacion.Name = "txtjustificacion";
            this.txtjustificacion.Size = new System.Drawing.Size(336, 32);
            this.txtjustificacion.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(444, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Justificacion:";
            // 
            // cbentregar
            // 
            this.cbentregar.FormattingEnabled = true;
            this.cbentregar.Items.AddRange(new object[] {
            "ALMACEN",
            "AREA SOLICITANTE"});
            this.cbentregar.Location = new System.Drawing.Point(83, 131);
            this.cbentregar.Name = "cbentregar";
            this.cbentregar.Size = new System.Drawing.Size(337, 21);
            this.cbentregar.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Entregar en:";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(308, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(388, 35);
            this.label16.TabIndex = 35;
            this.label16.Text = "R E Q U I S I C I O N   #";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Visible = false;
            // 
            // cbfuente
            // 
            this.cbfuente.FormattingEnabled = true;
            this.cbfuente.Location = new System.Drawing.Point(515, 68);
            this.cbfuente.Name = "cbfuente";
            this.cbfuente.Size = new System.Drawing.Size(337, 21);
            this.cbfuente.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(444, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Fuente:";
            // 
            // cbarea
            // 
            this.cbarea.FormattingEnabled = true;
            this.cbarea.Location = new System.Drawing.Point(83, 99);
            this.cbarea.Name = "cbarea";
            this.cbarea.Size = new System.Drawing.Size(337, 21);
            this.cbarea.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Area:";
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo,
            this.Descripcion,
            this.cantidad,
            this.especificaciones});
            this.Grid.Location = new System.Drawing.Point(31, 192);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(879, 189);
            this.Grid.TabIndex = 31;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_Det_Ent_DoubleClick);
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
            this.Descripcion.Width = 250;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // especificaciones
            // 
            this.especificaciones.HeaderText = "Especificaciones";
            this.especificaciones.Name = "especificaciones";
            this.especificaciones.ReadOnly = true;
            this.especificaciones.Width = 350;
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
            this.bt_salir.TabIndex = 14;
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
            // Det_Requisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 471);
            this.Controls.Add(this.txtiva);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.Grid_Articulos);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_grabar);
            this.Name = "Det_Requisiciones";
            this.Text = "Detalle de Requisicion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Det_Entradas_FormClosing);
            this.Load += new System.EventHandler(this.Det_Requisiciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Articulos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
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
        private System.Windows.Forms.ComboBox cbproyecto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbsolicito;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.ComboBox cbfuente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbarea;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtiva;
        private System.Windows.Forms.TextBox txtespecificaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbentregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtjustificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn especificaciones;
    }
}