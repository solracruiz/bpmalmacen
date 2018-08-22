namespace bpmalmacen
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuario1 = new System.Windows.Forms.Label();
            this.imagenalmacen = new System.Windows.Forms.PictureBox();
            this.imagenadquisiciones = new System.Windows.Forms.PictureBox();
            this.imagenvehicular = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.Button();
            this.foto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenalmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenadquisiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenvehicular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.foto);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.usuario1);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 28);
            this.panel1.TabIndex = 60;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Menú Principal";
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
            // imagenalmacen
            // 
            this.imagenalmacen.BackColor = System.Drawing.Color.Transparent;
            this.imagenalmacen.Image = global::bpmalmacen.Properties.Resources.almacen;
            this.imagenalmacen.Location = new System.Drawing.Point(10, 90);
            this.imagenalmacen.Name = "imagenalmacen";
            this.imagenalmacen.Size = new System.Drawing.Size(128, 73);
            this.imagenalmacen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenalmacen.TabIndex = 61;
            this.imagenalmacen.TabStop = false;
            this.imagenalmacen.Click += new System.EventHandler(this.imagenalmacen_Click);
            // 
            // imagenadquisiciones
            // 
            this.imagenadquisiciones.Image = global::bpmalmacen.Properties.Resources.adquisiciones;
            this.imagenadquisiciones.Location = new System.Drawing.Point(171, 90);
            this.imagenadquisiciones.Name = "imagenadquisiciones";
            this.imagenadquisiciones.Size = new System.Drawing.Size(128, 73);
            this.imagenadquisiciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenadquisiciones.TabIndex = 62;
            this.imagenadquisiciones.TabStop = false;
            // 
            // imagenvehicular
            // 
            this.imagenvehicular.Image = global::bpmalmacen.Properties.Resources.control_01;
            this.imagenvehicular.Location = new System.Drawing.Point(327, 90);
            this.imagenvehicular.Name = "imagenvehicular";
            this.imagenvehicular.Size = new System.Drawing.Size(128, 73);
            this.imagenvehicular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenvehicular.TabIndex = 63;
            this.imagenvehicular.TabStop = false;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Salir.Location = new System.Drawing.Point(201, 178);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(58, 21);
            this.Salir.TabIndex = 64;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
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
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 211);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.imagenvehicular);
            this.Controls.Add(this.imagenadquisiciones);
            this.Controls.Add(this.imagenalmacen);
            this.Controls.Add(this.panel1);
            this.Name = "principal";
            this.Text = "Sistema de Gestion de Almacen (SIGAL)";
            this.Load += new System.EventHandler(this.principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenalmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenadquisiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenvehicular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usuario1;
        private System.Windows.Forms.PictureBox imagenalmacen;
        private System.Windows.Forms.PictureBox imagenadquisiciones;
        private System.Windows.Forms.PictureBox imagenvehicular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.PictureBox foto;

    }
}