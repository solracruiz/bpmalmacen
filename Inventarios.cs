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
            data_det_inv.Rows.Insert(r, r, txtid.Text, txtnombre.Text, txtcantidad.Text, txtestado.Text, txtlote.Text);
            r = r + 1;
            limpiar();
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            if (txtid.Text.ToString() != "")
            {
                MySqlDataReader R = conn.GetData("SELECT nombre_corto FROM catarticulos where id=" + txtid.Text + ";");
                if (R.HasRows)
                {
                    R.Read();
                    txtnombre.Text = R[0].ToString().ToUpper();
                }
                else
                {
                    MessageBox.Show("No existe ese numero de articulo¡");
                    txtid.Focus();
                }
                R.Close();
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
        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar))
                {e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar))
            { e.Handled = false; }
            else{ e.Handled = true;}
        }
        void limpiar()
        {
            txtid.Text = "";
            txtnombre.Text = "";
            txtcantidad.Text = "";
            txtestado.Text = "";
            txtlote.Text = "";
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (txtnombre.TextLength > 3)
            {
                Grid_Articulos.Visible = true;
                //grid1.DataSource = conn.GetTable("select id,nombre_corto,nombre_largo from catarticulos");
                Grid_Articulos.DataSource = conn.GetTable("select id as Id_Producto,nombre_corto as Nombre,nombre_largo as Descripciion from catarticulos where nombre_corto like '%" + txtnombre.Text + "%' ");
                Grid_Articulos.AutoResizeColumns();
            }
        }

        private void Grid_Articulos_DoubleClick(object sender, EventArgs e)
        {
            txtid.Text = Grid_Articulos.CurrentRow.Cells["Id_Producto"].Value.ToString();
            txtnombre.Text = Grid_Articulos.CurrentRow.Cells["Nombre"].Value.ToString();
            Grid_Articulos.Visible = false;
        }
    }
}
