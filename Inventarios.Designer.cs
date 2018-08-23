using System;

namespace bpmalmacen
{
    partial class Inventarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.data_det_inv = new System.Windows.Forms.DataGridView();
            this.Renglon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.Grid_Articulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_det_inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(102, 282);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(73, 20);
            this.txtid.TabIndex = 1;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            this.txtid.Leave += new System.EventHandler(this.txtid_Leave);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(102, 308);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(539, 20);
            this.txtnombre.TabIndex = 10;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(245, 283);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(82, 20);
            this.txtcantidad.TabIndex = 2;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(652, 305);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(83, 23);
            this.bt_agregar.TabIndex = 5;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(405, 282);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(82, 20);
            this.txtestado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado:";
            // 
            // txtlote
            // 
            this.txtlote.Location = new System.Drawing.Point(559, 282);
            this.txtlote.Name = "txtlote";
            this.txtlote.Size = new System.Drawing.Size(82, 20);
            this.txtlote.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lote:";
            // 
            // data_det_inv
            // 
            this.data_det_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_det_inv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Renglon,
            this.id_p,
            this.nombre,
            this.lote,
            this.cantidad,
            this.estado});
            this.data_det_inv.Location = new System.Drawing.Point(33, 42);
            this.data_det_inv.Name = "data_det_inv";
            this.data_det_inv.Size = new System.Drawing.Size(702, 222);
            this.data_det_inv.TabIndex = 11;
            // 
            // Renglon
            // 
            this.Renglon.HeaderText = "Renglon";
            this.Renglon.Name = "Renglon";
            this.Renglon.ReadOnly = true;
            this.Renglon.Width = 60;
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
            this.nombre.Width = 250;
            // 
            // lote
            // 
            this.lote.HeaderText = "Lote";
            this.lote.Name = "lote";
            this.lote.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Descripcion:";
            // 
            // Grid_Articulos
            // 
            this.Grid_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Articulos.Location = new System.Drawing.Point(102, 91);
            this.Grid_Articulos.Name = "Grid_Articulos";
            this.Grid_Articulos.Size = new System.Drawing.Size(654, 190);
            this.Grid_Articulos.TabIndex = 14;
            this.Grid_Articulos.Visible = false;
            this.Grid_Articulos.DoubleClick += new System.EventHandler(this.Grid_Articulos_DoubleClick);
            // 
            // Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 365);
            this.Controls.Add(this.Grid_Articulos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.data_det_inv);
            this.Controls.Add(this.txtlote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Name = "Inventarios";
            this.Text = "Inventarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inventarios_FormClosing);
            this.Load += new System.EventHandler(this.Inventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_det_inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView data_det_inv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renglon;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridView Grid_Articulos;
    }
}