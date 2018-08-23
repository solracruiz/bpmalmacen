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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Det_Inventarios frm = new Det_Inventarios();
            frm.Show();
        }

        private void grid_inv_DoubleClick(object sender, EventArgs e)
        {
            //Det_Inventarios frm = new Det_Inventarios();
            //Det_Inventarios.show();
        }
    }
}
