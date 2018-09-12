namespace bpmalmacen
{
    partial class Det_Combustibles
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
            this.txtkm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.cbvehiculos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtrendimiento = new System.Windows.Forms.TextBox();
            this.txtkmanterior = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtkm
            // 
            this.txtkm.Location = new System.Drawing.Point(92, 139);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(100, 20);
            this.txtkm.TabIndex = 4;
            this.txtkm.Leave += new System.EventHandler(this.txtkm_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // txtfecha
            // 
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha.Location = new System.Drawing.Point(92, 102);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 2;
            // 
            // cbvehiculos
            // 
            this.cbvehiculos.FormattingEnabled = true;
            this.cbvehiculos.Location = new System.Drawing.Point(92, 27);
            this.cbvehiculos.Name = "cbvehiculos";
            this.cbvehiculos.Size = new System.Drawing.Size(289, 21);
            this.cbvehiculos.TabIndex = 0;
            this.cbvehiculos.Leave += new System.EventHandler(this.cbvehiculos_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vehiculo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kilometraje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Litros";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(92, 176);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 5;
            this.txtcantidad.Leave += new System.EventHandler(this.txtcantidad_Leave);
            // 
            // txtrendimiento
            // 
            this.txtrendimiento.Enabled = false;
            this.txtrendimiento.Location = new System.Drawing.Point(281, 176);
            this.txtrendimiento.Name = "txtrendimiento";
            this.txtrendimiento.Size = new System.Drawing.Size(100, 20);
            this.txtrendimiento.TabIndex = 10;
            // 
            // txtkmanterior
            // 
            this.txtkmanterior.Enabled = false;
            this.txtkmanterior.Location = new System.Drawing.Point(281, 139);
            this.txtkmanterior.Name = "txtkmanterior";
            this.txtkmanterior.Size = new System.Drawing.Size(100, 20);
            this.txtkmanterior.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rendimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Km Anterior:";
            // 
            // bt_agregar
            // 
            this.bt_agregar.FlatAppearance.BorderSize = 0;
            this.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar.Image = global::bpmalmacen.Properties.Resources.TaskHH;
            this.bt_agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_agregar.Location = new System.Drawing.Point(92, 211);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(54, 59);
            this.bt_agregar.TabIndex = 6;
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
            this.bt_salir.Location = new System.Drawing.Point(281, 212);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(51, 58);
            this.bt_salir.TabIndex = 7;
            this.bt_salir.Text = "Salir";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Costo:";
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(281, 102);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(100, 20);
            this.txtcosto.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Combustible:";
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "MAGNA",
            "PREMIUM",
            "DIESEL",
            "GAS L.P."});
            this.cbtipo.Location = new System.Drawing.Point(92, 64);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(289, 21);
            this.cbtipo.TabIndex = 1;
            // 
            // Det_Combustibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 282);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtrendimiento);
            this.Controls.Add(this.txtkmanterior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbvehiculos);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkm);
            this.Location = new System.Drawing.Point(440, 300);
            this.Name = "Det_Combustibles";
            this.Text = "Alta de Consumo de Combustible";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Det_Combustibles_FormClosed);
            this.Load += new System.EventHandler(this.Det_Combustibles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtkm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.ComboBox cbvehiculos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtrendimiento;
        private System.Windows.Forms.TextBox txtkmanterior;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbtipo;
    }
}