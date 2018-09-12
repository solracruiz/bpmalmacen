namespace bpmalmacen
{
    partial class cat_proveedores
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.celular = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.telefonofijo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pais = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.municipio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.localidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numext = new System.Windows.Forms.TextBox();
            this.colonia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rfc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calle = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btregresar = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.bt_grabar = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            this.btsalir = new System.Windows.Forms.Button();
            this.mensajes = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 266);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtfiltro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 101);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(710, 127);
            this.dgv.TabIndex = 141;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_CellClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 140;
            this.label15.Text = "Filtro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 139;
            this.label14.Text = "Nombre:";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(68, 66);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(288, 20);
            this.txtfiltro.TabIndex = 138;
            this.txtfiltro.Click += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.nombre);
            this.tabPage2.Controls.Add(this.email);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.celular);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.telefonofijo);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.pais);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.estado);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.municipio);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.localidad);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cp);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.numint);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.numext);
            this.tabPage2.Controls.Add(this.colonia);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.rfc);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.calle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 100;
            this.label16.Text = "Nombre:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(57, 47);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(288, 20);
            this.nombre.TabIndex = 99;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(293, 152);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(204, 20);
            this.email.TabIndex = 98;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(258, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 97;
            this.label13.Text = "E-mail:";
            // 
            // celular
            // 
            this.celular.Location = new System.Drawing.Point(574, 47);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(172, 20);
            this.celular.TabIndex = 96;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(525, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 95;
            this.label12.Text = "Celular.";
            // 
            // telefonofijo
            // 
            this.telefonofijo.Location = new System.Drawing.Point(75, 152);
            this.telefonofijo.Name = "telefonofijo";
            this.telefonofijo.Size = new System.Drawing.Size(176, 20);
            this.telefonofijo.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 93;
            this.label11.Text = "Telefono Fijo:";
            // 
            // pais
            // 
            this.pais.Location = new System.Drawing.Point(610, 124);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(136, 20);
            this.pais.TabIndex = 92;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(580, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 91;
            this.label10.Text = "Pais:";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(401, 124);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(177, 20);
            this.estado.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Estado:";
            // 
            // municipio
            // 
            this.municipio.Location = new System.Drawing.Point(57, 124);
            this.municipio.Name = "municipio";
            this.municipio.Size = new System.Drawing.Size(297, 20);
            this.municipio.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "Municipio:";
            // 
            // localidad
            // 
            this.localidad.Location = new System.Drawing.Point(379, 97);
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(367, 20);
            this.localidad.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "Localidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Colonia:";
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(675, 72);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(71, 20);
            this.cp.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(645, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "C.P.";
            // 
            // numint
            // 
            this.numint.Location = new System.Drawing.Point(565, 72);
            this.numint.Name = "numint";
            this.numint.Size = new System.Drawing.Size(71, 20);
            this.numint.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Num. Int.";
            // 
            // numext
            // 
            this.numext.Location = new System.Drawing.Point(437, 72);
            this.numext.Name = "numext";
            this.numext.Size = new System.Drawing.Size(71, 20);
            this.numext.TabIndex = 76;
            // 
            // colonia
            // 
            this.colonia.Location = new System.Drawing.Point(57, 97);
            this.colonia.Name = "colonia";
            this.colonia.Size = new System.Drawing.Size(261, 20);
            this.colonia.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Num. Ext.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "R.F.C.";
            // 
            // rfc
            // 
            this.rfc.Location = new System.Drawing.Point(386, 47);
            this.rfc.Name = "rfc";
            this.rfc.Size = new System.Drawing.Size(136, 20);
            this.rfc.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Calle:";
            // 
            // calle
            // 
            this.calle.Location = new System.Drawing.Point(57, 72);
            this.calle.Name = "calle";
            this.calle.Size = new System.Drawing.Size(319, 20);
            this.calle.TabIndex = 75;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btregresar);
            this.panel1.Controls.Add(this.bteditar);
            this.panel1.Controls.Add(this.bt_grabar);
            this.panel1.Controls.Add(this.btnuevo);
            this.panel1.Controls.Add(this.btsalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 66);
            this.panel1.TabIndex = 136;
            // 
            // btregresar
            // 
            this.btregresar.FlatAppearance.BorderSize = 0;
            this.btregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btregresar.Image = global::bpmalmacen.Properties.Resources.Arrow_UndoRevertRestore_16xLG;
            this.btregresar.Location = new System.Drawing.Point(236, 4);
            this.btregresar.Name = "btregresar";
            this.btregresar.Size = new System.Drawing.Size(64, 54);
            this.btregresar.TabIndex = 132;
            this.btregresar.Text = "Regresar";
            this.btregresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btregresar.UseVisualStyleBackColor = true;
            this.btregresar.Click += new System.EventHandler(this.btregresar_Click);
            // 
            // bteditar
            // 
            this.bteditar.Enabled = false;
            this.bteditar.FlatAppearance.BorderSize = 0;
            this.bteditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditar.Image = global::bpmalmacen.Properties.Resources.WebRefreshHH;
            this.bteditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bteditar.Location = new System.Drawing.Point(102, 6);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(53, 54);
            this.bteditar.TabIndex = 127;
            this.bteditar.Text = "Editar";
            this.bteditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // bt_grabar
            // 
            this.bt_grabar.FlatAppearance.BorderSize = 0;
            this.bt_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_grabar.Image = global::bpmalmacen.Properties.Resources.SaveHH;
            this.bt_grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_grabar.Location = new System.Drawing.Point(172, 6);
            this.bt_grabar.Name = "bt_grabar";
            this.bt_grabar.Size = new System.Drawing.Size(55, 54);
            this.bt_grabar.TabIndex = 129;
            this.bt_grabar.Text = "Aceptar";
            this.bt_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_grabar.UseVisualStyleBackColor = true;
            this.bt_grabar.Click += new System.EventHandler(this.bt_grabar_Click);
            // 
            // btnuevo
            // 
            this.btnuevo.FlatAppearance.BorderSize = 0;
            this.btnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuevo.Image = global::bpmalmacen.Properties.Resources.TaskHH;
            this.btnuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnuevo.Location = new System.Drawing.Point(33, 6);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(53, 56);
            this.btnuevo.TabIndex = 131;
            this.btnuevo.Text = "Agregar";
            this.btnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // btsalir
            // 
            this.btsalir.FlatAppearance.BorderSize = 0;
            this.btsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalir.Image = global::bpmalmacen.Properties.Resources.ClosePreviewHH;
            this.btsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btsalir.Location = new System.Drawing.Point(655, 5);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(51, 58);
            this.btsalir.TabIndex = 130;
            this.btsalir.Text = "Salir";
            this.btsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // cat_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 266);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "cat_proveedores";
            this.Text = "Catálogo de Proveedores";
            this.Load += new System.EventHandler(this.cat_proveedores_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btregresar;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button bt_grabar;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox celular;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox telefonofijo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pais;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox municipio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox localidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numext;
        private System.Windows.Forms.TextBox colonia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rfc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox calle;
        private System.Windows.Forms.ToolTip mensajes;
    }
}