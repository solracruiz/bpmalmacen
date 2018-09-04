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
    
    public partial class Combustibles : Form
    {
        conexion conn = new conexion();
        string filtro = "";
        public string sql = "";
        public Combustibles()
        {
            InitializeComponent();
        }

        
        private void grid_comb_DoubleClick(object sender, EventArgs e)
        {
            if (grid_comb.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult result = MessageBox.Show("¡Deseas Borrar el Consumo de combustible?", "Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conn.AbrirBD();
                    conn.Executa("delete from combustibles where id=" + grid_comb.CurrentRow.Cells[0].Value.ToString());
                    carga(sql);
                    conn.cerrarBd();
                }
            }
        }

        private void Combustibles_Load(object sender, EventArgs e)
        {
            
            
            sql =" select c.id, v.unidad as Vehiculo, c.fecha as Fecha, c.kmanterior as Km_Anterior, " +
                " c.km as Kilometraje, c.cantidad as Litros, c.rendimiento as Rendimiento " +
                " from catvehiculos v, combustibles c " +
                " where v.id=c.idvehiculo " + filtro.ToString();
            carga(sql + " limit 20");
        }

        void carga(string sql2)
        {
              conn.AbrirBD();
            grid_comb.DataSource = conn.GetTable(sql2);
            grid_comb.AutoResizeColumns();
            conn.cerrarBd();
        }

        
        private void bteditar_Click(object sender, EventArgs e)
        {
            if (grid_comb.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult result = MessageBox.Show("¡Deseas Editar el Consumo de Combustible?", "Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Det_Combustibles frm = new Det_Combustibles();
                    frm.Tag = grid_comb.CurrentRow.Cells[0].Value.ToString();
                    frm.ShowDialog();
                    
                    carga(sql);
                }
            }
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            filtro = "";
            if (txtfiltro.Text.ToString().Length > 3)
            { filtro = " and (v.unidad like '%" + txtfiltro.Text + "%') limit 40"; }

            carga(sql + filtro);
        }

        private void bt_agregar_Click_1(object sender, EventArgs e)
        {
            Det_Combustibles frm = new Det_Combustibles();
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
            filtro = " and c.fecha>='" + txtfecha.Value.ToString("yyyy-MM-dd") +
                "' and c.fecha<='" + txtfecha2.Value.ToString("yyyy-MM-dd") +"' limit 40" ;
            carga(sql + filtro);
        }

        private void bt_exportar_Click(object sender, EventArgs e)
        {
            conn.AbrirBD();
            string nombre_archivo = "Listado de Consumo de Combustible";
            modulo1.Exportar_Excel(conn.PropertyTable, nombre_archivo);
            conn.cerrarBd();
            MessageBox.Show("Proceso Realizado con Exito");
        }
    }
}
