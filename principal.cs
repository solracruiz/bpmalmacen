using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bpmalmacen
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imagenalmacen_Click(object sender, EventArgs e)
        {
            menualmacen frm = new menualmacen();
            frm.Show();
            this.Hide();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            foto.Image = Image.FromFile(acceso.rutadefotos + "foto.jpg");
            usuario1.Text = " " + acceso.nombreusario;
        }

    }
}
