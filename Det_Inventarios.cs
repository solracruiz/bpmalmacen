using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using bpmalmacen.Clases;

namespace bpmalmacen
{
    public partial class Det_Inventarios : Form
    {
        int r = 0;
        Int64 ID_INV;
        Double PRECIO, TOTAL;
        conexion conn = new conexion();
        conexion conn1 = new conexion();
        conexion conn2 = new conexion();
        conexion conn3 = new conexion();
        conexion conn4 = new conexion();


        MySqlDataReader R;
        public Det_Inventarios()
        {
            InitializeComponent();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if (validar() == 0){ return; }
            //data_det_inv.Rows.Insert(r,r+1, txtid.Text, txtnombre.Text, txtcantidad.Text, PRECIO.ToString(), txtlote.Text, cbestatus2.Text.ToUpper() ,txtmarbete.Text, cbreviso.SelectedValue,cbreviso.Text);
            string str = "insert into det_inventarios (idinventario,idarticulo," +
                    "cantidad,precio,totalprecio,lote,estado,marbete,idauditor) " +
                    "values(" + ID_INV + "," + txtid.Text + "," + txtcantidad.Text + "," + 
                    PRECIO.ToString() + "," + TOTAL + ",'" + txtlote.Text + "','" +
                    cbestatus2.Text.ToUpper() + "','" + txtmarbete.Text + "'," +
                    cbreviso.SelectedValue +  ")";
                    
            //MessageBox.Show(str);
            conn.Executa(str);
            limpiar();
            cargar_det();
            txtid.Focus();
        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            if (txtid.Text.ToString() != "")
            {
                R = conn.GetData("SELECT nombre_corto, preciopromedio FROM catarticulos where id=" + txtid.Text + ";");
                if (R.HasRows)
                {
                    R.Read();
                    txtnombre.Text = R[0].ToString().ToUpper();
                    PRECIO = double.Parse(R[1].ToString()); //OBTENER PRECIO PROMEDIO DEL PRODUCTO
                    
                }
                else
                {
                    MessageBox.Show("No existe ese numero de articulo¡");
                    txtid.Focus();
                }
                R.Close();
            }
        }

        private void Det_Inventarios_Load(object sender, EventArgs e)
        { 
            cargar();
            conn.AbrirBD();
            conn1.AbrirBD();
            if (null != this.Tag)
            {
                
                ID_INV = Int64.Parse(this.Tag.ToString());
                panel1.Visible = true;
                panel2.Enabled = false;
                MySqlDataReader R = conn.GetData("SELECT i.fecha,i.tipo,a.nombre as almacen, e.nombre as autorizo" +
                    " FROM inventarios i, catalmacen a, empleados e " +
                    " where i.idalmacen=a.id and i.idautorizo=e.id and i.id='" + ID_INV +"';");
                if (R.HasRows)
                {
                    R.Read();
                    txtfecha.Text = R["fecha"].ToString();
                    cbtipo.Text = R["tipo"].ToString();
                    cbalmacen.Text = R["almacen"].ToString();
                    cbsolicito.Text = R["autorizo"].ToString();
                    label16.Visible = true;
                    label16.Text = "I N V E N T A R I O   #" + ID_INV.ToString(); 
                }
                else
                {
                    this.Close();
                }
                R.Close();
                cargar_det();
            }
        }
        void cargar_det()
        {
            data_det_inv.DataSource = conn.GetTable("select d.id,d.idarticulo as Id_Articulo,a.nombre_corto as Descripcion,cantidad as Cantidad," +
                "d.precio as Precio,totalprecio as Total,estado as Estado,d.marbete as Marbete,e.nombre as Auditor "+
                "from det_inventarios d, empleados e, catarticulos a where d.idauditor=e.id and d.idarticulo=a.id and d.idinventario=" + 
                ID_INV + " order by d.id");
            if ((conn.PropertyDataSet.Tables[0].Rows.Count != 0))
            {
                data_det_inv.Columns["id"].Visible = false;
                data_det_inv.AutoResizeColumns();
            }

        }
            void cargar()
        {
            txtfecha.Value = DateTime.Now;
            conn2.AbrirBD();
            cbreviso.DisplayMember = "nombre";
            cbreviso.ValueMember = "id";
            cbreviso.DataSource = conn2.GetTable("select id,nombre from empleados");
            conn2.cerrarBd();

            conn3.AbrirBD();
            cbsolicito.DisplayMember = "nombre";
            cbsolicito.ValueMember = "id";
            cbsolicito.DataSource =  conn3.GetTable("select id,nombre from empleados");
            conn3.cerrarBd();

            conn4.AbrirBD();
            cbalmacen.DisplayMember = "nombre";
            cbalmacen.ValueMember = "id";
            if (configuracion.ID_ALMACEN != 0)
            {
                cbalmacen.DataSource = conn4.GetTable("select id,nombre from catalmacen where id=" + configuracion.ID_ALMACEN);
                cbalmacen.Enabled = false;
            }
            else { cbalmacen.DataSource = conn4.GetTable("select id,nombre from catalmacen"); }
            conn4.cerrarBd();

        }
        private void Det_Inventarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.cerrarBd();
            conn1.cerrarBd();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            { txtnombre.Enabled = true;}
            else { txtnombre.Enabled = false; }


        }
        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar))
                {e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar))
            { e.Handled = false; }
            else if (e.KeyChar==46)
            { e.Handled = false; }
            else { e.Handled = true;}
        }
        void limpiar()
        {
            txtid.Text = "";
            txtnombre.Text = "";
            txtcantidad.Text = "";
            cbestatus2.Text = "";
            txtlote.Text = "";
            txtmarbete.Text = "";
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (txtnombre.TextLength > 3 && txtid.Text=="")
            {
                Grid_Articulos.Visible = true;

                //grid1.DataSource = conn.GetTable("select id,nombre_corto,nombre_largo from catarticulos");
                
                Grid_Articulos.DataSource = conn1.GetTable("select id as Id_Producto,nombre_corto as Nombre," +
                    " nombre_largo as Descripcion from catarticulos where nombre_corto like '%" + txtnombre.Text + "%' order by nombre_corto limit 20");
                if (Grid_Articulos.RowCount<2)
                {
                    Grid_Articulos.Visible = false;
                    return;
                }
                Grid_Articulos.AutoResizeColumns();
            }
        }

        private void Grid_Articulos_DoubleClick(object sender, EventArgs e)
        {
            txtid.Text = Grid_Articulos.CurrentRow.Cells["Id_Producto"].Value.ToString();
            txtnombre.Text = Grid_Articulos.CurrentRow.Cells["Nombre"].Value.ToString();
            Grid_Articulos.Visible = false;
            txtcantidad.Focus();
            txtnombre.Enabled = false;
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {txtcantidad.Focus();}
            else if (e.KeyCode == Keys.Down){ txtnombre.Focus(); }
        }
        int validar()
        {
            if (txtid.Text!="" && txtcantidad.Text!="" && cbestatus2.Text!="" && txtmarbete.Text != "" && cbreviso.Text != "")
            { return 1; }
            return 0;
        }
        int validar_inv()
        {
            if (txtfecha.Text != "" && cbtipo.Text != "" && cbalmacen.Text != "" && cbsolicito.Text != "")
            { return 1; }
            return 0;
        }

        private void bt_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar_inv() == 0){ return; }
                    conn.AbrirBD();
                    panel1.Visible = true;
                    conn.Executa("insert into inventarios (tipo,fecha,idalmacen,idautorizo,estatus) values('" + 
                    cbtipo.Text.ToUpper() + "','" + txtfecha.Value.ToString("yyyy-MM-dd") + "'," + cbalmacen.SelectedValue +"," + cbsolicito.SelectedValue + ",'A')");
                //OBTENER ID INVENTARIO
                R = conn.GetData("SELECT id FROM inventarios where tipo='" + cbtipo.Text.ToUpper() 
                        + "' and fecha='" + txtfecha.Value.ToString("yyyy-MM-dd")
                        + "' and idalmacen=" + cbalmacen.SelectedValue + ";");
                    if (R.HasRows)
                    {
                        R.Read();
                        ID_INV = Int32.Parse(R[0].ToString());
                     }
                    R.Close();
                    conn.Executa("insert into bitacora (fechasis,usuario,motivo,tabla,idtabla) values('"
                            + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + configuracion.USER + 
                            "','ALTA','INVENTARIOS'," + ID_INV + ")");
                    panel2.Enabled = false;
                    panel1.Visible = true;
                    txtid.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al guardar en la BD:" + ex.Message, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

        }

        private void data_det_inv_DoubleClick(object sender, EventArgs e)
        {
            if (data_det_inv.CurrentRow.Cells[1].Value.ToString() == "") { return; }
            DialogResult res = MessageBox.Show("Deseas eliminar el registro del producto " + 
                data_det_inv.CurrentRow.Cells[2].Value.ToString(), "Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                conn.Executa("delete from det_inventarios where id=" + data_det_inv.CurrentRow.Cells[0].Value.ToString());
                cargar_det();
            }
            
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtlote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtmarbete.Focus();
            }
            else if (e.KeyCode == Keys.Up)
                {
                    txtcantidad.Focus();
                }
            

        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtlote.Focus();
            }
            else if (e.KeyCode == Keys.Up )
            {
                txtid.Focus();
            }
        }

        private void txtmarbete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            { cbestatus2.Focus(); }
            else if (e.KeyCode == Keys.Up) { txtlote.Focus(); }
        }

        private void cbestatus2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            { cbreviso.Focus(); }
            else if (e.KeyCode == Keys.Up) { txtmarbete.Focus(); }
        }

        private void cbreviso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            { bt_agregar.Focus(); }
            else if (e.KeyCode == Keys.Up) { cbestatus2.Focus(); }
        }

        private void bt_agregar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { txtid.Focus(); }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar))
            { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar))
            { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtcantidad_Leave(object sender, EventArgs e)
        {
            if (txtcantidad.Text.ToString() != "")
            {
                txtcantidad.Text = "0";
            }
        }

        void grabar_grid()
        {
            for (int fila = 0; fila < data_det_inv.Rows.Count - 1; fila++)
            {
                TOTAL = double.Parse(data_det_inv.Rows[fila].Cells[3].Value.ToString()) * double.Parse(data_det_inv.Rows[fila].Cells[4].Value.ToString());
                string str="insert into det_inventarios (idinventario,idarticulo," +
                    "cantidad,precio,totalprecio,lote,estado,marbete,idauditor) " + 
                    "values(" + ID_INV + "," +
                    data_det_inv.Rows[fila].Cells[1].Value.ToString() + "," +
                    data_det_inv.Rows[fila].Cells[3].Value.ToString() + "," +
                    data_det_inv.Rows[fila].Cells[4].Value.ToString() + "," +
                    TOTAL + ",'" +
                    data_det_inv.Rows[fila].Cells[5].Value.ToString() + "','" +
                    data_det_inv.Rows[fila].Cells[6].Value.ToString() + "','" +
                    data_det_inv.Rows[fila].Cells[7].Value.ToString() + "'," +
                    data_det_inv.Rows[fila].Cells[8].Value.ToString() + ")";
                //MessageBox.Show(str);
                conn.Executa(str);
                
                
                /*for (int col = 0; col < data_det_inv.Rows[fila].Cells.Count; col++)
                {
                    string valor = data_det_inv.Rows[fila].Cells[col].Value.ToString();
                    MessageBox.Show(valor);
                }*/
            }
            //Inventario.ActiveForm=true;
            this.Close();
        }
   
    }
    
}
