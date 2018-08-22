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
    public partial class almacen : Form
    {
        public almacen()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            principal frm = new principal();
            frm.Show();
            this.Hide();
        }

        private void almacen_Load(object sender, EventArgs e)
        {
            foto.Image = Image.FromFile(entrada.fotousuarioruta);
            usuario1.Text = " " + entrada.nombreusario;
        }

        private void partidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catpartidas frm = new catpartidas();
            frm.Show();
           // this.Hide();
        }
    }
}
