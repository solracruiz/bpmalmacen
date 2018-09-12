namespace bpmalmacen
{
    partial class cat_partidas
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
            this.label7 = new System.Windows.Forms.Label();
            this.clave = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btregresar = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.bt_grabar = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            this.btsalir = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
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
            this.tabControl1.Size = new System.Drawing.Size(748, 275);
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
            this.tabPage1.Size = new System.Drawing.Size(740, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(15, 109);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(710, 127);
            this.dgv.TabIndex = 141;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 140;
            this.label15.Text = "Filtro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 139;
            this.label14.Text = "Nombre:";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(77, 74);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(288, 20);
            this.txtfiltro.TabIndex = 138;
            this.txtfiltro.Click += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.clave);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.nombre);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(740, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 212;
            this.label7.Text = "Clave:";
            // 
            // clave
            // 
            this.clave.Location = new System.Drawing.Point(135, 79);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(112, 20);
            this.clave.TabIndex = 213;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 210;
            this.label9.Text = "Nombre:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(135, 115);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(567, 20);
            this.nombre.TabIndex = 211;
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
            this.panel1.Size = new System.Drawing.Size(748, 66);
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
            // cat_partidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 275);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "cat_partidas";
            this.Text = "Catálogo de Partidas";
            this.Load += new System.EventHandler(this.cat_partidas_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox clave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolTip mensajes;
    }
}