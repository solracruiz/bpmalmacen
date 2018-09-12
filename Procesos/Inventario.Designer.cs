namespace bpmalmacen
{
    partial class Inventario
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
            this.grid_inv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.bt_exportar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_inv)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_inv
            // 
            this.grid_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_inv.Location = new System.Drawing.Point(24, 70);
            this.grid_inv.MultiSelect = false;
            this.grid_inv.Name = "grid_inv";
            this.grid_inv.ReadOnly = true;
            this.grid_inv.Size = new System.Drawing.Size(703, 195);
            this.grid_inv.TabIndex = 0;
            this.grid_inv.DoubleClick += new System.EventHandler(this.grid_inv_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro de Busqueda:";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(24, 34);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(402, 20);
            this.txtfiltro.TabIndex = 2;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // bt_exportar
            // 
            this.bt_exportar.FlatAppearance.BorderSize = 0;
            this.bt_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exportar.Image = global::bpmalmacen.Properties.Resources.Office_Excel_Application_32xMD;
            this.bt_exportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_exportar.Location = new System.Drawing.Point(189, 271);
            this.bt_exportar.Name = "bt_exportar";
            this.bt_exportar.Size = new System.Drawing.Size(59, 58);
            this.bt_exportar.TabIndex = 35;
            this.bt_exportar.Text = "Exportar";
            this.bt_exportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_exportar.UseVisualStyleBackColor = true;
            this.bt_exportar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.FlatAppearance.BorderSize = 0;
            this.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar.Image = global::bpmalmacen.Properties.Resources.TaskHH;
            this.bt_agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_agregar.Location = new System.Drawing.Point(45, 271);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(55, 58);
            this.bt_agregar.TabIndex = 34;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.FlatAppearance.BorderSize = 0;
            this.bt_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salir.Image = global::bpmalmacen.Properties.Resources.ClosePreviewHH;
            this.bt_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_salir.Location = new System.Drawing.Point(676, 271);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(51, 58);
            this.bt_salir.TabIndex = 33;
            this.bt_salir.Text = "Salir";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.FlatAppearance.BorderSize = 0;
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.Image = global::bpmalmacen.Properties.Resources.WebRefreshHH;
            this.bt_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_editar.Location = new System.Drawing.Point(120, 271);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(53, 58);
            this.bt_editar.TabIndex = 5;
            this.bt_editar.Text = "Editar";
            this.bt_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 334);
            this.Controls.Add(this.bt_exportar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_inv);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_inv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_inv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Button bt_exportar;
    }
}