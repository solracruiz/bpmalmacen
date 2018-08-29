using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bpmalmacen.Clases;

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
            foto.Image = Image.FromFile(acceso.fotousuarioruta);
            usuario1.Text = " " + acceso.nombreusario;
            Barra_Usuario.Text = configuracion.USER;
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
            frm.Show(this);
            
        }

        private void menualmacen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entradas frm = new Entradas();
            frm.Show(this);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void salidasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Salidas frm = new Salidas();
            frm.Show(this);
        }
    }
}
