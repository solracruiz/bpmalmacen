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
    
    public partial class Requisiciones : Form
    {
        conexion conn = new conexion();
        string  filtro="",filtro2="";
        public string sql = "";
        public Requisiciones()
        {
            InitializeComponent();
        }

        
        private void grid_inv_DoubleClick(object sender, EventArgs e)
        {
            if (grid.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult result = MessageBox.Show("¡Deseas Borrar la Entrada al Almacen?", "Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conn.AbrirBD();
                    conn.Executa("delete from entradas where id=" + grid.CurrentRow.Cells[0].Value.ToString());
                    conn.Executa("delete from det_entradas where identrada=" + grid.CurrentRow.Cells[0].Value.ToString());
                    carga(sql);
                    conn.cerrarBd();
                }
            }
        }

        private void Requisiciones_Load(object sender, EventArgs e)
        {
            if (configuracion.ID_ALMACEN != 0)
            { filtro2 = " and r.usuario=" + configuracion.USER.ToString(); }
            sql ="select r.id as Identificador, r.folio as Folio,r.fecha as Fecha, " +
                " r.justificacion as Detalles, d.nombre as Area, e.nombre " + 
                " from requisiciones r,  catareas d, empleados e " +
                " where  d.id=r.idarea and e.id=r.idsolicito " + filtro.ToString();
            carga(sql + " limit 20");
        }

        void carga(string sql2)
        {
              conn.AbrirBD();
            grid.DataSource = conn.GetTable(sql2);
            grid.AutoResizeColumns();
            conn.cerrarBd();
        }

        
        private void bteditar_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult result = MessageBox.Show("¿Deseas Editar la Requisicion de Materiales o Servicios?", "Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Det_Requisiciones frm = new Det_Requisiciones();
                    frm.Tag = grid.CurrentRow.Cells[0].Value.ToString();
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
            Det_Requisiciones frm = new Det_Requisiciones();
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
            filtro = " and e.fecha>='" + txtfecha.Value.ToString("yyyy-MM-dd") + 
                "' and e.fecha<='" + txtfecha2.Value.ToString("yyyy-MM-dd") +"'" ;
            carga(sql + filtro);
        }

        private void bt_exportar_Click(object sender, EventArgs e)
        {
            conn.AbrirBD();
            string nombre_archivo = "Listado de Requisiciones";
            modulo1.Exportar_Excel(conn.PropertyTable, nombre_archivo);
            conn.cerrarBd();
            MessageBox.Show("Proceso Realizado con Exito");
        }
    }
}
