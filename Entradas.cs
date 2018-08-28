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
    
    public partial class Entradas : Form
    {
        conexion conn = new conexion();
        string  filtro="",filtro2="";
        public string sql = "";
        public Entradas()
        {
            InitializeComponent();
        }

        
        private void grid_inv_DoubleClick(object sender, EventArgs e)
        {
            if (grid_ent.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult result = MessageBox.Show("¡Deseas Borrar la Entrada al Almacen?", "Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conn.AbrirBD();
                    conn.Executa("delete from entradas where id=" + grid_ent.CurrentRow.Cells[0].Value.ToString());
                    conn.Executa("delete from det_entradas where identrada=" + grid_ent.CurrentRow.Cells[0].Value.ToString());
                    carga(sql);
                    conn.cerrarBd();
                }
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            if (configuracion.ID_ALMACEN != 0)
            { filtro2 = " and e.idalmacen=" + configuracion.ID_ALMACEN.ToString(); }
            sql ="select e.id as Identificador, e.tipo as Tipo,e.fechaentrada as Fecha, " +
                "e.numfactura as Factura,e.fechafactura as Fecha_Factura, e.costofactura as Costo, " +
                " d.nombre as Area, p.nombre Proveedor, a.nombre as Almacen,r.nombre as Receptor " + 
                " from entradas e, catalmacen a, empleados r, catareas d, catproveedores p " +
                " where e.idalmacen=a.id and e.idrecibio=r.id and d.id=e.idarea and p.id=e.idproveedor " + filtro.ToString();
            carga(sql + " limit 20");
        }

        void carga(string sql2)
        {
              conn.AbrirBD();
            grid_ent.DataSource = conn.GetTable(sql2);
            grid_ent.AutoResizeColumns();
            conn.cerrarBd();
        }

        
        private void bteditar_Click(object sender, EventArgs e)
        {
            if (grid_ent.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult result = MessageBox.Show("¡Deseas Editar la Entrada al Almacen?", "Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Det_Entradas frm = new Det_Entradas();
                    frm.Tag = grid_ent.CurrentRow.Cells[0].Value.ToString();
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
                    "%' or p.nombre like '%" + txtfiltro.Text +
                    "%' or d.nombre like '%" + txtfiltro.Text +
                    "%' or r.nombre  like '%" + txtfiltro.Text + "%') limit 20"; }

            carga(sql + filtro);
        }

        private void bt_agregar_Click_1(object sender, EventArgs e)
        {
            Det_Entradas frm = new Det_Entradas();
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
            filtro = " and e.fechaentrada>='" + txtfecha.Value.ToString("yyyy-MM-dd") + 
                "' and e.fechaentrada<='" + txtfecha2.Value.ToString("yyyy-MM-dd") +"'" ;
            carga(sql + filtro);
        }

        private void bt_exportar_Click(object sender, EventArgs e)
        {
            conn.AbrirBD();
            string nombre_archivo = "Listado de Entradas";
            modulo1.Exportar_Excel(conn.PropertyTable, nombre_archivo);
            conn.cerrarBd();
            MessageBox.Show("Proceso Realizado con Exito");
        }
    }
}
