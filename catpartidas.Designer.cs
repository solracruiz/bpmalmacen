namespace bpmalmacen
{
    partial class catpartidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catpartidas));
            this.label1 = new System.Windows.Forms.Label();
            this.usuario1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.foto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clave1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.imprimir = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.grabar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.clasifica1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Catálogo de Partidas";
            // 
            // usuario1
            // 
            this.usuario1.AutoSize = true;
            this.usuario1.ForeColor = System.Drawing.Color.White;
            this.usuario1.Location = new System.Drawing.Point(36, 5);
            this.usuario1.Name = "usuario1";
            this.usuario1.Size = new System.Drawing.Size(41, 13);
            this.usuario1.TabIndex = 50;
            this.usuario1.Text = "usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.foto);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.usuario1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 28);
            this.panel1.TabIndex = 61;
            // 
            // foto
            // 
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.foto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("foto.ErrorImage")));
            this.foto.Image = global::bpmalmacen.Properties.Resources.usuario;
            this.foto.Location = new System.Drawing.Point(6, 3);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(25, 22);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 65;
            this.foto.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::bpmalmacen.Properties.Resources.logoempresa;
            this.pictureBox1.Image = global::bpmalmacen.Properties.Resources.logoempresa;
            this.pictureBox1.Location = new System.Drawing.Point(428, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // clave1
            // 
            this.clave1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.clave1.Enabled = false;
            this.clave1.Location = new System.Drawing.Point(47, 34);
            this.clave1.Name = "clave1";
            this.clave1.Size = new System.Drawing.Size(98, 20);
            this.clave1.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(1, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Clave:";
            // 
            // nombre1
            // 
            this.nombre1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombre1.Enabled = false;
            this.nombre1.Location = new System.Drawing.Point(77, 59);
            this.nombre1.Name = "nombre1";
            this.nombre1.Size = new System.Drawing.Size(399, 20);
            this.nombre1.TabIndex = 65;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(464, 215);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Modificar.Enabled = false;
            this.Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Modificar.Location = new System.Drawing.Point(152, 325);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(58, 20);
            this.Modificar.TabIndex = 73;
            this.Modificar.Text = "Cambia";
            this.Modificar.UseVisualStyleBackColor = false;
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancelar.Enabled = false;
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelar.Location = new System.Drawing.Point(92, 325);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(58, 20);
            this.cancelar.TabIndex = 72;
            this.cancelar.Text = "Cancela";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // imprimir
            // 
            this.imprimir.BackColor = System.Drawing.Color.Gray;
            this.imprimir.Enabled = false;
            this.imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imprimir.Location = new System.Drawing.Point(332, 325);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(58, 20);
            this.imprimir.TabIndex = 71;
            this.imprimir.Text = "Imprime";
            this.imprimir.UseVisualStyleBackColor = false;
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.borrar.Enabled = false;
            this.borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borrar.Location = new System.Drawing.Point(212, 325);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(58, 20);
            this.borrar.TabIndex = 70;
            this.borrar.Text = "Borra";
            this.borrar.UseVisualStyleBackColor = false;
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agregar.Location = new System.Drawing.Point(32, 325);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(58, 20);
            this.agregar.TabIndex = 69;
            this.agregar.Text = "Agrega";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salir.Location = new System.Drawing.Point(392, 325);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(55, 21);
            this.salir.TabIndex = 68;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // grabar
            // 
            this.grabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.grabar.Enabled = false;
            this.grabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grabar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grabar.Location = new System.Drawing.Point(272, 325);
            this.grabar.Name = "grabar";
            this.grabar.Size = new System.Drawing.Size(58, 20);
            this.grabar.TabIndex = 67;
            this.grabar.Text = "Graba";
            this.grabar.UseVisualStyleBackColor = false;
            this.grabar.Click += new System.EventHandler(this.grabar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(148, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Clasificación:";
            // 
            // clasifica1
            // 
            this.clasifica1.Enabled = false;
            this.clasifica1.FormattingEnabled = true;
            this.clasifica1.Items.AddRange(new object[] {
            "Partidas Normales (PN)",
            "Partidas Especiales Conducto Dependencia (PCD)",
            "Partidas Conducto de Sría. de Admón (PCA)"});
            this.clasifica1.Location = new System.Drawing.Point(231, 34);
            this.clasifica1.Name = "clasifica1";
            this.clasifica1.Size = new System.Drawing.Size(245, 21);
            this.clasifica1.TabIndex = 75;
            // 
            // catpartidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 356);
            this.Controls.Add(this.clasifica1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.grabar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nombre1);
            this.Controls.Add(this.clave1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "catpartidas";
            this.Text = "v";
            this.Load += new System.EventHandler(this.catpartidas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usuario1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox clave1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button imprimir;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button grabar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox clasifica1;
    }
}