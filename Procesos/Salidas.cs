using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using bpmalmacen.Clases;

namespace bpmalmacen
{
    
    public partial class Salidas : Form
    {
        conexion conn = new conexion();
        string  filtro="",filtro2="";
        public string sql = "";
        public Salidas()
        {
            InitializeComponent();
        }

        
        private void grid_inv_DoubleClick(object sender, EventArgs e)
        {
            return;
            if (grid_sal.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult result = MessageBox.Show("¡Deseas Borrar la Entrada al Almacen?", "Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conn.AbrirBD();
                    conn.Executa("delete from entradas where id=" + grid_sal.CurrentRow.Cells[0].Value.ToString());
                    conn.Executa("delete from det_entradas where identrada=" + grid_sal.CurrentRow.Cells[0].Value.ToString());
                    carga(sql);
                    conn.cerrarBd();
                }
            }
        }

        private void Salidas_Load(object sender, EventArgs e)
        {
            if (configuracion.ID_ALMACEN != 0)
            { filtro2 = " and s.idalmacen=" + configuracion.ID_ALMACEN.ToString(); }
            sql ="select s.id as Identificador, s.tipo as Tipo,s.fechasalida as Fecha, " +
                "s.importe as Importe, d.nombre as Area, a.nombre as Almacen," +
                "r.nombre as Entrego " +
                " from salidas s, catalmacen a, empleados r, catareas d " +
                " where s.idalmacen=a.id and s.identrego=r.id and d.id=s.idarea  " + filtro.ToString();
            carga(sql + " limit 20");
        }

        void carga(string sql2)
        {
              conn.AbrirBD();
            grid_sal.DataSource = conn.GetTable(sql2);
            grid_sal.AutoResizeColumns();
            conn.cerrarBd();
        }

        
        private void bteditar_Click(object sender, EventArgs e)
        {
            if (grid_sal.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult result = MessageBox.Show("¡Deseas Editar la Entrada al Almacen?", "Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Det_Entradas frm = new Det_Entradas();
                    frm.Tag = grid_sal.CurrentRow.Cells[0].Value.ToString();
                    frm.ShowDialog();
                    
                    carga(sql);
                }
            }
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            filtro = "";
            if (txtfiltro.Text.ToString().Length > 3)
            { filtro = " and (a.nombre like '%" + txtfiltro.Text +
                    "%' or d.nombre like '%" + txtfiltro.Text +
                    "%' or r.nombre  like '%" + txtfiltro.Text + "%') limit 20"; }

            carga(sql + filtro);
        }

        private void bt_agregar_Click_1(object sender, EventArgs e)
        {
            Det_Salidas frm = new Det_Salidas();
            frm.ShowDialog();
            carga(sql);
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtfecha.Value>txtfecha2.Value)
            { return; }
            filtro = " and s.fechasalida>='" + txtfecha.Value.ToString("yyyy-MM-dd") + 
                "' and s.fechasalida<='" + txtfecha2.Value.ToString("yyyy-MM-dd") +"'" ;
            carga(sql + filtro);
        }

        private void bt_exportar_Click(object sender, EventArgs e)
        {
            conn.AbrirBD();
            string nombre_archivo = "Listado de Salidas";
            modulo1.Exportar_Excel(conn.PropertyTable, nombre_archivo);
            conn.cerrarBd();
            MessageBox.Show("Proceso Realizado con Exito");
        }
    }
}
