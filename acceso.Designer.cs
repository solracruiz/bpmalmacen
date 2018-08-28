namespace bpmalmacen
{
    partial class acceso
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acceso));
            this.label4 = new System.Windows.Forms.Label();
            this.usuario1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.foto2 = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.Entrar = new System.Windows.Forms.Button();
            this.foto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(151, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ingreso al Sistema";
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
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.usuario1);
            this.panel1.Controls.Add(this.foto2);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 28);
            this.panel1.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::bpmalmacen.Properties.Resources.logoempresa;
            this.pictureBox1.Image = global::bpmalmacen.Properties.Resources.logoempresa;
            this.pictureBox1.Location = new System.Drawing.Point(416, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // foto2
            // 
            this.foto2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foto2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("foto2.ErrorImage")));
            this.foto2.Location = new System.Drawing.Point(3, 2);
            this.foto2.Name = "foto2";
            this.foto2.Size = new System.Drawing.Size(29, 24);
            this.foto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto2.TabIndex = 49;
            this.foto2.TabStop = false;
            // 
            // password
            // 
            this.password.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(137, 182);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(163, 20);
            this.password.TabIndex = 55;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.Black;
            this.Nombre.Location = new System.Drawing.Point(137, 143);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(163, 20);
            this.Nombre.TabIndex = 54;
            this.Nombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Nombre_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "PassWord:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(133, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Usuario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Salir.Location = new System.Drawing.Point(242, 203);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(58, 23);
            this.Salir.TabIndex = 58;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Entrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Entrar.Location = new System.Drawing.Point(137, 204);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(61, 22);
            this.Entrar.TabIndex = 57;
            this.Entrar.Text = "Aceptar";
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // foto
            // 
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("foto.ErrorImage")));
            this.foto.Image = global::bpmalmacen.Properties.Resources.usuario;
            this.foto.Location = new System.Drawing.Point(176, 42);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(86, 83);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 51;
            this.foto.TabStop = false;
            // 
            // acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Entrar);
            this.Name = "acceso";
            this.Text = "Sistema de Gestion de Almacen (SIGAL)";
            this.Load += new System.EventHandler(this.entrada_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label usuario1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox foto2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Entrar;
    }
}

