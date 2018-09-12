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
    public partial class cat_proveedores : Form
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
        private string id1 = "0";
        public cat_proveedores()
        {
            InitializeComponent();
        }

        private void cat_proveedores_Load(object sender, EventArgs e)
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
            btnuevo.Enabled = false;
            bteditar.Enabled = false;
            bt_grabar.Enabled = true;
            btregresar.Enabled = true;
            limpiar();
            mt = 0;
            edit = 0;
            tabControl1.SelectedTab = tabPage2;

        }


        void muestradatos()
        {
            int ok = 0;
            conn.AbrirBD();
            R = conn.GetData("SELECT id,nombre,rfc,calle,numext,numint,cp, colonia, localidad, municipio, estado, pais, telefonofijo, celular, email FROM catproveedores where id=" + valorid + ";");
            if (R.HasRows)
            {
                R.Read();
                id1 = R[0].ToString().ToUpper();
                nombre.Text = R[1].ToString();
                rfc.Text = R[2].ToString();
                calle.Text = R[3].ToString();
                numext.Text = R[4].ToString();
                numint.Text = R[5].ToString();
                cp.Text = R[6].ToString();
                colonia.Text = R[7].ToString();
                localidad.Text = R[8].ToString();
                municipio.Text = R[9].ToString();
                estado.Text = R[10].ToString();
                pais.Text = R[10].ToString();
                telefonofijo.Text = R[10].ToString();
                celular.Text = R[10].ToString();
                email.Text = R[10].ToString();
                ok = 1;
            }
            else
            {
                MessageBox.Show("Erro al traer Catalogo de Proveedores");
                txtfiltro.Focus();
            }
            R.Close();

        }

        void llenagripd()
        {
            if (configuracion.ID_ALMACEN != 0)
            { filtro2 = " and e.idalmacen=" + configuracion.ID_ALMACEN.ToString(); }
            sql = "select e.id as Identificador, e.nombre as Nombre, e.calle as Domicilio, e.telefonofijo as Telefono," +
                "e.email as Correo" +
                " from catproveedores e"; //+
            carga(sql + " limit 20");
        }
        void carga(string sql2)
        {
            conn.AbrirBD();
            dgv.DataSource = conn.GetTable(sql2);
            dgv.AutoResizeColumns();
            conn.cerrarBd();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

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
                    filtro = " where (e.nombre like '%" + txtfiltro.Text + "%') limit 20";
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
                    resp = conn.Executa("insert into catproveedores (nombre,rfc,calle,numext,numint,cp," +
                        "colonia,localidad,municipio,estado,pais,telefonofijo,celular,email) values('" +
                    nombre.Text.ToUpper() + "','" + rfc.Text.ToUpper() + "','" + calle.Text.ToUpper() + "','" +
                     numext.Text.ToUpper() + "','" + numint.Text.ToString() + "','" + cp.Text.ToString() + "','" +
                    colonia.Text.ToUpper() + "','" + localidad.Text + "','" + municipio.Text.ToString() + "','" +
                    estado.Text.ToString() + "','" + pais.Text.ToUpper() + "','" + telefonofijo.Text.ToString() + "','" +
                     celular.Text.ToString() + "','" + email.Text.ToUpper() + "')");
                    if (!resp) { conn.fallo(); return; }
                    datmsg = "Alta de Nuevo";
                }
                else
                {
                    resp = conn.Executa("update catproveedores set " +
                     " nombre = '" + nombre.Text.ToString() +
                     "', rfc = '" + rfc.Text.ToUpper() +
                    "', calle = '" + calle.Text.ToString() +
                    "', numint = '" + numint.Text.ToString() +
                    "', numext = '" + numext.Text.ToString() +
                    "', cp = '" + cp.Text.ToString() +
                     "', colonia = '" + colonia.Text.ToString() +
                      "', localidad = '" + localidad.Text.ToString() +
                      "', municipio = '" + municipio.Text.ToString() +
                    "', telefonofijo = '" + telefonofijo.Text.ToString() +
                    "', estado = '" + estado.Text.ToString() +
                    "', pais = '" + pais.Text.ToString() +
                    "', telefonofijo = '" + telefonofijo.Text.ToUpper() +
                    "', celular = '" + celular.Text.ToString() +
                     "', email = '" + email.Text.ToString() +
                    "' where id = " + valorid +
                    ";");
                    if (!resp) { conn.fallo(); return; }
                    datmsg = "Modificación de datos de";
                }

                conn.exito();
                conn.cerrarBd();
                MessageBox.Show(datmsg + " Proveedor " + nombre.Text.ToUpper() + " Realizada con Exito¡");

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
            if (nombre.Text != "" && rfc.Text != "" && calle.Text != "")
            { return 1; }
            return 0;
        }

        private void dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vgpmt = 0;
            valorid = this.dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtfiltro.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            bteditar.Enabled = true;
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
            txtfiltro.Text = "";
            nombre.Text = "";
            rfc.Text = "";
            calle.Text = "";
            numext.Text = "";
            numint.Text = "";
            cp.Text = "";
            colonia.Text = "";
            localidad.Text = "";
            municipio.Text = "";
            estado.Text = "";
            pais.Text = "";
            telefonofijo.Text = "";
            celular.Text = "";
            email.Text = "";
         }

    }
}
