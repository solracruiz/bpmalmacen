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
    public partial class Det_Combustibles : Form
    {
        conexion conn = new conexion();
        public Det_Combustibles()
        {
            InitializeComponent();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Det_Combustibles_Load(object sender, EventArgs e)
        {
            txtfecha.Value = DateTime.Now;
            conn.AbrirBD();
            cbvehiculos.DisplayMember = "unidad";
            cbvehiculos.ValueMember = "id";
            cbvehiculos.DataSource = conn.GetTable("select id,unidad from catvehiculos");
            conn.cerrarBd();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            conn.Executa("insert into combustibles (idvehiculo,fecha,tipo_combustible,km,kmanterior,cantidad,costo)" +
               " values (" + cbvehiculos.SelectedValue + ",'" + txtfecha.Value.ToString("yyyy-MM-dd") + "','" +
               cbtipo.Text + "'," + txtkm.Text + "," + txtkmanterior.Text + "," + 
               txtcantidad.Text + "," + txtcosto.Text + ")");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbvehiculos_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("sacar el valor de km anterior");
        }
    }
}
