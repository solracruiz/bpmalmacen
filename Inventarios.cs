using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bpmalmacen
{
    public partial class Inventarios : Form
    {
        int r = 0;
        conexion conn = new conexion();
        public Inventarios()
        {
            InitializeComponent();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            data_det_inv.Rows.Insert(r, r, txtid.Text, " Nombre " + r, txtcantidad.Text, txtestado.Text, txtlote.Text);
            r = r + 1;
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            MySqlDataReader R = conn.GetData("SELECT nombre FROM articulos where id=" + txtid.Text  + ";");
            if (R.HasRows)
            {
                //principal frm = new principal();
                txtnombre.Text = "1";
                
            }
            else
            {
                MessageBox.Show("No existe ese numero de articulo¡");
            }
        }

        private void Inventarios_Load(object sender, EventArgs e)
        {
            conn.AbrirBD();
        }

        private void Inventarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.cerrarBd();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
