using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bpmalmacen.Clases;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace bpmalmacen
{
    public partial class cat_partidas : Form
    {
        conexion conn = new conexion();
        string filtro = "", filtro2 = "";
        public string sql = "";
        MySqlDataReader R;
        conexion conn1 = new conexion();
        conexion conn2 = new conexion();
        conexion conn3 = new conexion();
        private static int mt = 0; //control para el fintro
        private static int vgpmt = 0; // control para el gripd
        private static string valorid = "1"; // valor id al dar click al gripd
        private static int edit = 0;  // si oprimio editar
        private string namejefe = "A";
        private string idjefe1 = "0";
        public cat_partidas()
        {
            InitializeComponent();
        }

        private void cat_partidas_Load(object sender, EventArgs e)
        {
            mensajes.SetToolTip(txtfiltro, "Teclea registro a buscar...");
            mensajes.SetToolTip(btnuevo, "Selecciona para agregar una nuevo registro...");
            mensajes.SetToolTip(bteditar, "Mostrar registro a detalle...");
            mensajes.SetToolTip(btregresar, "Regresar a pantalla anterior");
            mensajes.SetToolTip(bt_grabar, "Guardar registro...");
            llenagripd();
            bt_grabar.Enabled = false;
            btregresar.Enabled = false;
            bteditar.Enabled = false;
            this.txtfiltro.Enabled = true;
        }
        private void btnuevo_Click(object sender, EventArgs e)
        {
            edit = 0;
            btnuevo.Enabled = false;
            bteditar.Enabled = false;
            bt_grabar.Enabled = true;
            btregresar.Enabled = true;
            limpiar();
            mt = 0;
            tabControl1.SelectedTab = tabPage2;
        }

        void muestradatos()
        {
            int ok = 0;
            conn.AbrirBD();
            R = conn.GetData("SELECT id,nombre FROM catpartidas where id=" + valorid + ";");
            if (R.HasRows)
            {
                R.Read();
                clave.Text = R[0].ToString().ToUpper();
                nombre.Text = R[1].ToString();
                ok = 1;
            }
            else
            {
                MessageBox.Show("Erro al traer Catalogo de Partidas");
                txtfiltro.Focus();
            }
                       
            R.Close();

        } // 

        void llenagripd()
        {
            if (configuracion.ID_ALMACEN != 0)
            { filtro2 = " and e.idalmacen=" + configuracion.ID_ALMACEN.ToString(); }
            sql = "select a.id as Identificador, a.nombre as Nombre " +
                " from catpartidas a ";
                carga(sql + " limit 20");
        } //

        void carga(string sql2)
        {
            conn.AbrirBD();
            dgv.DataSource = conn.GetTable(sql2);
            dgv.AutoResizeColumns();
            conn.cerrarBd();
        } //

        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        } //

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            if (vgpmt == 0)
            {
                mt = 0;
            }
            else
            {
                mt = 1;
            }
            usafiltro();
            vgpmt = 1;
        }

        void usafiltro()
        {
            if (mt == 1)
            {
                filtro = "";
                if (txtfiltro.Text.ToString().Length > 3)
                {
                    filtro = " and (a.nombre like '%" + txtfiltro.Text + "%') limit 20";

                }
                carga(sql + filtro);

            }
            mt = 0;
        }
        private void bt_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                mt = 0;
                String datmsg = "";
                if (validar_ent() == 0) { return; }
                Boolean resp;
                conn.AbrirBD();
                conn.inicio();
                if (edit == 0)
                {
                    resp = conn.Executa("insert into catpartidas (id,nombre) values('" +
                    clave.Text.ToUpper() + "','" + nombre.Text.ToUpper() + "')");
                    if (!resp) { conn.fallo(); return; }
                    datmsg = "Alta de Nuevo";
                }
                else
                {
                    resp = conn.Executa("update catpartidas set " +
                        "id = '" + clave.Text.ToUpper() +
                    "', nombre = '" + nombre.Text.ToUpper() +
                   "' where id = " + valorid +
                    ";");
                    if (!resp) { conn.fallo(); return; }
                    datmsg = "Modificación de datos de";
                }

                conn.exito();
                conn.cerrarBd();
                MessageBox.Show(datmsg + " Partidas " + nombre.Text.ToUpper() + " Realizada con Exito¡");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al guardar en la BD:" + ex.Message, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            btnuevo.Enabled = true;
            bt_grabar.Enabled = false;
            btregresar.Enabled = false;
            llenagripd();
            tabControl1.SelectedTab = tabPage1;
        }

        int validar_ent()
        {
            if (clave.Text != "" && nombre.Text != "")
            { return 1; }
            return 0;
        }

      
        private void bteditar_Click(object sender, EventArgs e)
        {
            btnuevo.Enabled = false;
            bt_grabar.Enabled = true;
            bteditar.Enabled = false;
            btregresar.Enabled = true;
            mt = 0;
            edit = 1;
            muestradatos();
            tabControl1.SelectedTab = tabPage2;
        }

        private void btregresar_Click(object sender, EventArgs e)
        {
            mt = 0;
            btnuevo.Enabled = true;
            bt_grabar.Enabled = false;
            bteditar.Enabled = false;
            btregresar.Enabled = false;
            tabControl1.SelectedTab = tabPage1;
        }

        void limpiar()
        {
            clave.Text = "";
            txtfiltro.Text = "";
            nombre.Text = "";
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vgpmt = 0;
            valorid = this.dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtfiltro.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
          //  namejefe = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            bteditar.Enabled = true;
        }        
    }
}
