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
    public partial class menualmacen : Form
    {
        public menualmacen()
        {
            InitializeComponent();
        }

        private void menualmacen_Load(object sender, EventArgs e)
        {
            foto.Image = Image.FromFile(entrada.fotousuarioruta);
            usuario1.Text = " " + entrada.nombreusario;
        }

        private void partidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //catpartidas frm = new catpartidas();
            //frm.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            principal frm = new principal();
            frm.Show();
            this.Hide();
        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario frm = new Inventario();
            frm.Show();
            
        }

        private void menualmacen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
