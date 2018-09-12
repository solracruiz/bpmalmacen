using bpmalmacen.Clases;
using MySql.Data.MySqlClient;
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
            conn.AbrirBD();
            txtfecha.Value = DateTime.Now;
            cbvehiculos.DisplayMember = "unidad";
            cbvehiculos.ValueMember = "id";
            cbvehiculos.DataSource = conn.GetTable("select id,unidad from catvehiculos");
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                conn.AbrirBD();
                conn.inicio();
                Boolean resp;
                resp = conn.Executa("insert into combustibles (idvehiculo,fecha,tipo_combustible,km,kmanterior,cantidad,costo,rendimiento)" +
                   " values (" + cbvehiculos.SelectedValue.ToString() + ",'" + txtfecha.Value.ToString("yyyy-MM-dd") + "','" +
                   cbtipo.Text + "'," + txtkm.Text + "," + txtkmanterior.Text + "," +
                   txtcantidad.Text + "," + txtcosto.Text + "," + txtrendimiento.Text + ")");
                if (!resp) { conn.fallo(); return; }
                resp = conn.Executa("update catvehiculos set km=" + txtkm.Text + " where id=" + cbvehiculos.ValueMember);
                if (!resp) { conn.fallo(); return; }
                resp = conn.Executa("insert into bitacora (fechasis,usuario,motivo,tabla,idtabla) values('"
                       + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + configuracion.USER +
                       "','ALTA','COMBUSTIBLES'," + cbvehiculos.SelectedValue + ")");
                if (!resp) { conn.fallo(); return; }
                limpiar();
                conn.exito();
                conn.cerrarBd();
                MessageBox.Show("Proceso Realizado con Exito");
            }
        }

        void limpiar()
        {
            txtcantidad.Text = "";
            txtcosto.Text = "0";
            txtfecha.Value = DateTime.Now;
            txtkm.Text = "";
            txtkmanterior.Text = "";
            txtrendimiento.Text = "";
        }

        private void cbvehiculos_Leave(object sender, EventArgs e)
        {
            
            //MessageBox.Show("sacar el valor de km anterior");
            MySqlDataReader R = conn.GetData("SELECT km FROM catvehiculos where id=" + cbvehiculos.SelectedValue );
            if (R.HasRows)
            {
                //VARIABLES GLOBALES
                R.Read();
                txtkmanterior.Text = R[0].ToString();
                R.Close();
            }
            else
            {
                MessageBox.Show("Favor de elegir una Unidad valida¡");
            }
        }

        private void Det_Combustibles_FormClosed(object sender, FormClosedEventArgs e)
        {
             conn.cerrarBd();
        }
        Boolean validar()
        {
            if (txtrendimiento.Text == "" || txtcantidad.Text == "" || txtcosto.Text == "" || txtkm.Text == "")
            { return false; }
            return true;
        }
        void calcular()
        {
            if (modulo1.IsNumeric(txtcantidad.Text) && modulo1.IsNumeric(txtkm.Text) && modulo1.IsNumeric(txtkmanterior.Text))
            {//SI NO SON NUMEROS O EL KILOMETRAJE ACTUAL ES MENOR QUE EL ANTERIOR NO HACE NADA Y VACIA EL CAMPO RENDIMIENTO
                if ((float.Parse(txtcantidad.Text) <= 0) || (float.Parse(txtkm.Text)<=float.Parse(txtkmanterior.Text))) { return; }
                float rend = (float.Parse(txtkm.Text) - float.Parse(txtkmanterior.Text)) / float.Parse(txtcantidad.Text);
                txtrendimiento.Text = rend.ToString();
            }
            else {
                txtrendimiento.Text = "";
            }
        }
        private void txtkm_Leave(object sender, EventArgs e)
        {
            calcular();
        }

        private void txtcantidad_Leave(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
