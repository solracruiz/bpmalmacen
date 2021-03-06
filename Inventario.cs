﻿using System;
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
    
    public partial class Inventario : Form
    {
        conexion conn = new conexion();
        Boolean resp;
        string  filtro="", filtro2="";
        public string sql = "";
        public Inventario()
        {
            InitializeComponent();
        }

        
        private void grid_inv_DoubleClick(object sender, EventArgs e)
        {
            if (grid_inv.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult result = MessageBox.Show("¡Deseas Borrar el Inventario?", "Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conn.AbrirBD();
                    resp=conn.Executa("delete from inventarios where id=" + grid_inv.CurrentRow.Cells[0].Value.ToString());
                    
                    resp =conn.Executa("delete from det_inventarios where idinventario=" + grid_inv.CurrentRow.Cells[0].Value.ToString());
                    carga(sql);
                    conn.cerrarBd();
                }
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            if (configuracion.ID_ALMACEN != 0)
            { filtro2 = " and i.idalmacen=" + configuracion.ID_ALMACEN.ToString(); }
            sql="select i.id as Identificador, i.tipo as Tipo,i.fecha as Fecha,i.estatus as Estado, " +
                " a.nombre as Almacen, e.nombre as Auditor from inventarios i, catalmacen a, empleados e " +
                "where i.idalmacen=a.id and i.idautorizo=e.id " + filtro2;
            carga(sql);
        }

        void carga(string sql2)
        {
              conn.AbrirBD();
            grid_inv.DataSource = conn.GetTable(sql2);
            grid_inv.AutoResizeColumns();
            conn.cerrarBd();
        }

        
        private void bteditar_Click(object sender, EventArgs e)
        {
            if (grid_inv.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult result = MessageBox.Show("¡Deseas Editar el Inventario?", "Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Det_Inventarios frm = new Det_Inventarios();
                    frm.Tag = grid_inv.CurrentRow.Cells[0].Value.ToString();
                    frm.ShowDialog();
                    carga(sql);
                }
            }
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            filtro = "";
            if (txtfiltro.Text.ToString().Length > 3)
            { filtro = " and (a.nombre like '%" + txtfiltro.Text + "%' or e.nombre  like '%" + txtfiltro.Text + "%') "; }

            carga(sql + filtro);
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            Det_Inventarios frm = new Det_Inventarios();
            frm.ShowDialog();
            carga(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.AbrirBD();
            string nombre_archivo = "Listado de Inventarios";
            modulo1.Exportar_Excel(conn.PropertyTable, nombre_archivo);
            conn.cerrarBd();
            MessageBox.Show("Proceso Realizado con Exito");
        }
    }
}
