namespace bpmalmacen
{
    partial class Salidas
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
            this.grid_sal = new System.Windows.Forms.DataGridView();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.bt_exportar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfecha2 = new System.Windows.Forms.DateTimePicker();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_filtrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sal)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_sal
            // 
            this.grid_sal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sal.Location = new System.Drawing.Point(24, 70);
            this.grid_sal.MultiSelect = false;
            this.grid_sal.Name = "grid_sal";
            this.grid_sal.ReadOnly = true;
            this.grid_sal.Size = new System.Drawing.Size(946, 288);
            this.grid_sal.TabIndex = 0;
            this.grid_sal.DoubleClick += new System.EventHandler(this.grid_inv_DoubleClick);
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
            this.bt_exportar.Location = new System.Drawing.Point(189, 364);
            this.bt_exportar.Name = "bt_exportar";
            this.bt_exportar.Size = new System.Drawing.Size(59, 58);
            this.bt_exportar.TabIndex = 35;
            this.bt_exportar.Text = "Exportar";
            this.bt_exportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_exportar.UseVisualStyleBackColor = true;
            this.bt_exportar.Click += new System.EventHandler(this.bt_exportar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.FlatAppearance.BorderSize = 0;
            this.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar.Image = global::bpmalmacen.Properties.Resources.TaskHH;
            this.bt_agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_agregar.Location = new System.Drawing.Point(45, 364);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(55, 58);
            this.bt_agregar.TabIndex = 34;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click_1);
            // 
            // bt_salir
            // 
            this.bt_salir.FlatAppearance.BorderSize = 0;
            this.bt_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salir.Image = global::bpmalmacen.Properties.Resources.ClosePreviewHH;
            this.bt_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_salir.Location = new System.Drawing.Point(919, 364);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(51, 58);
            this.bt_salir.TabIndex = 33;
            this.bt_salir.Text = "Salir";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.FlatAppearance.BorderSize = 0;
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.Image = global::bpmalmacen.Properties.Resources.WebRefreshHH;
            this.bt_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_editar.Location = new System.Drawing.Point(120, 364);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(53, 58);
            this.bt_editar.TabIndex = 5;
            this.bt_editar.Text = "Editar";
            this.bt_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Visible = false;
            this.bt_editar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Filtro de Busqueda:";
            // 
            // txtfecha2
            // 
            this.txtfecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha2.Location = new System.Drawing.Point(794, 31);
            this.txtfecha2.Name = "txtfecha2";
            this.txtfecha2.Size = new System.Drawing.Size(111, 20);
            this.txtfecha2.TabIndex = 38;
            this.txtfecha2.Value = new System.DateTime(2018, 8, 22, 23, 52, 52, 0);
            // 
            // txtfecha
            // 
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha.Location = new System.Drawing.Point(654, 31);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(111, 20);
            this.txtfecha.TabIndex = 37;
            this.txtfecha.Value = new System.DateTime(2018, 8, 22, 23, 52, 52, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "De:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(791, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Al:";
            // 
            // bt_filtrar
            // 
            this.bt_filtrar.FlatAppearance.BorderSize = 0;
            this.bt_filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_filtrar.Image = global::bpmalmacen.Properties.Resources.FindHH;
            this.bt_filtrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_filtrar.Location = new System.Drawing.Point(911, 12);
            this.bt_filtrar.Name = "bt_filtrar";
            this.bt_filtrar.Size = new System.Drawing.Size(59, 58);
            this.bt_filtrar.TabIndex = 41;
            this.bt_filtrar.Text = "Filtrar";
            this.bt_filtrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_filtrar.UseVisualStyleBackColor = true;
            this.bt_filtrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 431);
            this.Controls.Add(this.bt_filtrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfecha2);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_exportar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.grid_sal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Salidas";
            this.Text = "Salidas de Almacen";
            this.Load += new System.EventHandler(this.Salidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_sal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Button bt_exportar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtfecha2;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_filtrar;
    }
}