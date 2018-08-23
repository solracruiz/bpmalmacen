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
        conexion conn = new conexion();
        string sql, filtro;
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

        private void Inventario_Load(object sender, EventArgs e)
        {

            sql="select i.tipo as Tipo,i.fecha as Fecha,i.estatus as Estado, " +
                " a.nombre as Almacen, e.nombre as Auditor from inventarios i, catalmacen a, empleados e " +
                "where i.idalmacen=a.id and i.idautorizo=e.id";
            carga();
        }
        void carga()
        {
              conn.AbrirBD();
            grid_inv.DataSource = conn.GetTable(sql);
            grid_inv.AutoResizeColumns();
            conn.cerrarBd();
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            filtro = "";
            if (txtfiltro.Text.ToString().Length > 3)
            { filtro = " and (a.nombre like '%" + txtfiltro.Text + "%' or e.nombre  like '%" + txtfiltro.Text + "%') "; }
                
            sql ="select i.tipo as Tipo,i.fecha as Fecha,i.estatus as Estado, " +
                " a.nombre as Almacen, e.nombre as Auditor from inventarios i, catalmacen a, empleados e " +
                "where i.idalmacen=a.id and i.idautorizo=e.id " + filtro;
            carga();
        }
    }
}
