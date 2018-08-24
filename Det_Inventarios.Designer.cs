using System;

namespace bpmalmacen
{
    partial class Det_Inventarios
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
            this.data_det_inv = new System.Windows.Forms.DataGridView();
            this.Renglon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marbete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_aud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Articulos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_grabar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbestatus2 = new System.Windows.Forms.ComboBox();
            this.cbreviso = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmarbete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.cbsolicito = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.data_det_inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Articulos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_det_inv
            // 
            this.data_det_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_det_inv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Renglon,
            this.id_p,
            this.nombre,
            this.cantidad,
            this.valor,
            this.lote,
            this.estado,
            this.marbete,
            this.id_aud,
            this.auditor});
            this.data_det_inv.Location = new System.Drawing.Point(31, 100);
            this.data_det_inv.Name = "data_det_inv";
            this.data_det_inv.Size = new System.Drawing.Size(869, 208);
            this.data_det_inv.TabIndex = 11;
            // 
            // Renglon
            // 
            this.Renglon.HeaderText = "#";
            this.Renglon.Name = "Renglon";
            this.Renglon.ReadOnly = true;
            this.Renglon.Width = 30;
            // 
            // id_p
            // 
            this.id_p.HeaderText = "Id Producto";
            this.id_p.Name = "id_p";
            this.id_p.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Descripcion del Producto";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 75;
            // 
            // valor
            // 
            this.valor.HeaderText = "Precio";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // lote
            // 
            this.lote.HeaderText = "Lote";
            this.lote.Name = "lote";
            this.lote.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // marbete
            // 
            this.marbete.HeaderText = "Marbete";
            this.marbete.Name = "marbete";
            this.marbete.ReadOnly = true;
            // 
            // id_aud
            // 
            this.id_aud.HeaderText = "id_aud";
            this.id_aud.Name = "id_aud";
            this.id_aud.ReadOnly = true;
            this.id_aud.Visible = false;
            // 
            // auditor
            // 
            this.auditor.HeaderText = "Auditor";
            this.auditor.Name = "auditor";
            this.auditor.ReadOnly = true;
            // 
            // Grid_Articulos
            // 
            this.Grid_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Articulos.Location = new System.Drawing.Point(100, 135);
            this.Grid_Articulos.Name = "Grid_Articulos";
            this.Grid_Articulos.Size = new System.Drawing.Size(823, 181);
            this.Grid_Articulos.TabIndex = 14;
            this.Grid_Articulos.Visible = false;
            this.Grid_Articulos.DoubleClick += new System.EventHandler(this.Grid_Articulos_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tipo de Inventario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fecha de Inventario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Almacen:";
            // 
            // bt_grabar
            // 
            this.bt_grabar.Location = new System.Drawing.Point(817, 29);
            this.bt_grabar.Name = "bt_grabar";
            this.bt_grabar.Size = new System.Drawing.Size(83, 46);
            this.bt_grabar.TabIndex = 4;
            this.bt_grabar.Text = "Aceptar";
            this.bt_grabar.UseVisualStyleBackColor = true;
            this.bt_grabar.Click += new System.EventHandler(this.bt_grabar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbestatus2);
            this.panel1.Controls.Add(this.cbreviso);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtmarbete);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtlote);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bt_agregar);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 59);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // cbestatus2
            // 
            this.cbestatus2.FormattingEnabled = true;
            this.cbestatus2.Items.AddRange(new object[] {
            "BUENO",
            "REGULAR",
            "MALO"});
            this.cbestatus2.Location = new System.Drawing.Point(492, 7);
            this.cbestatus2.Name = "cbestatus2";
            this.cbestatus2.Size = new System.Drawing.Size(121, 21);
            this.cbestatus2.TabIndex = 8;
            // 
            // cbreviso
            // 
            this.cbreviso.FormattingEnabled = true;
            this.cbreviso.Location = new System.Drawing.Point(493, 32);
            this.cbreviso.Name = "cbreviso";
            this.cbreviso.Size = new System.Drawing.Size(276, 21);
            this.cbreviso.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(423, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Reviso:";
            // 
            // txtmarbete
            // 
            this.txtmarbete.Location = new System.Drawing.Point(699, 7);
            this.txtmarbete.Name = "txtmarbete";
            this.txtmarbete.Size = new System.Drawing.Size(70, 20);
            this.txtmarbete.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(644, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Marbete:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nombre:";
            // 
            // txtlote
            // 
            this.txtlote.Location = new System.Drawing.Point(344, 7);
            this.txtlote.Name = "txtlote";
            this.txtlote.Size = new System.Drawing.Size(70, 20);
            this.txtlote.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Lote:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Estatus:";
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(781, 10);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(83, 42);
            this.bt_agregar.TabIndex = 11;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(211, 7);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(70, 20);
            this.txtcantidad.TabIndex = 6;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cantidad:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(56, 32);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(358, 20);
            this.txtnombre.TabIndex = 12;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(56, 7);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(85, 20);
            this.txtid.TabIndex = 5;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            this.txtid.Leave += new System.EventHandler(this.txtid_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Producto:";
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "ESPECIFICO",
            "PARCIAL",
            "TOTAL"});
            this.cbtipo.Location = new System.Drawing.Point(117, 16);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(121, 21);
            this.cbtipo.TabIndex = 0;
            // 
            // txtfecha
            // 
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha.Location = new System.Drawing.Point(117, 45);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(121, 20);
            this.txtfecha.TabIndex = 1;
            this.txtfecha.Value = new System.DateTime(2018, 8, 22, 23, 52, 52, 0);
            // 
            // cbalmacen
            // 
            this.cbalmacen.FormattingEnabled = true;
            this.cbalmacen.Location = new System.Drawing.Point(306, 16);
            this.cbalmacen.Name = "cbalmacen";
            this.cbalmacen.Size = new System.Drawing.Size(446, 21);
            this.cbalmacen.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Solicito:";
            // 
            // cbsolicito
            // 
            this.cbsolicito.FormattingEnabled = true;
            this.cbsolicito.Location = new System.Drawing.Point(306, 43);
            this.cbsolicito.Name = "cbsolicito";
            this.cbsolicito.Size = new System.Drawing.Size(446, 21);
            this.cbsolicito.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbtipo);
            this.panel2.Controls.Add(this.cbsolicito);
            this.panel2.Controls.Add(this.txtfecha);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbalmacen);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(31, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 74);
            this.panel2.TabIndex = 30;
            // 
            // Det_Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 387);
            this.Controls.Add(this.Grid_Articulos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_grabar);
            this.Controls.Add(this.data_det_inv);
            this.Name = "Det_Inventarios";
            this.Text = "Det_Inventarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Det_Inventarios_FormClosing);
            this.Load += new System.EventHandler(this.Det_Inventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_det_inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Articulos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView data_det_inv;
        private System.Windows.Forms.DataGridView Grid_Articulos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_grabar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.ComboBox cbsolicito;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbreviso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtmarbete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbestatus2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renglon;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn marbete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_aud;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditor;
    }
}