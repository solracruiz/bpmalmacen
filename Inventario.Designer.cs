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
            this.bteditar = new System.Windows.Forms.Button();
            this.btsalir = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
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
            this.grid_inv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_inv_CellContentClick);
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
            // bteditar
            // 
            this.bteditar.Location = new System.Drawing.Point(150, 290);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(82, 25);
            this.bteditar.TabIndex = 5;
            this.bteditar.Text = "Editar";
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btsalir
            // 
            this.btsalir.FlatAppearance.BorderSize = 0;
            this.btsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalir.Image = global::bpmalmacen.Properties.Resources.ClosePreviewHH;
            this.btsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btsalir.Location = new System.Drawing.Point(676, 271);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(51, 58);
            this.btsalir.TabIndex = 33;
            this.btsalir.Text = "Salir";
            this.btsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.FlatAppearance.BorderSize = 0;
            this.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar.Image = global::bpmalmacen.Properties.Resources.TaskHH;
            this.bt_agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_agregar.Location = new System.Drawing.Point(45, 271);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(54, 59);
            this.bt_agregar.TabIndex = 34;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 334);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.bteditar);
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
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.Button bt_agregar;
    }
}