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

namespace bpmalmacen
{
    public partial class Det_Inventarios : Form
    {
        int r = 0;
        Int64 ID_INV;
        Double PRECIO, TOTAL;
        conexion conn = new conexion();
        conexion conn2 = new conexion();
        conexion conn3 = new conexion();

        MySqlDataReader R;
        public Det_Inventarios()
        {
            InitializeComponent();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if (validar() == 0){ return; }
            data_det_inv.Rows.Insert(r,r+1, txtid.Text, txtnombre.Text, txtcantidad.Text, PRECIO.ToString(), txtlote.Text, cbestatus2.Text.ToUpper() ,txtmarbete.Text, cbreviso.SelectedValue,cbreviso.Text);
            r = r + 1;
            limpiar();
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
            if (null != this.Tag)
            {
                ID_INV = Int64.Parse(this.Tag.ToString());
            }
            cargar();
        }

        void cargar()
        {
            conn.AbrirBD();
            cbreviso.DisplayMember = "nombre";
            cbreviso.ValueMember = "id";
            cbreviso.DataSource = conn.GetTable("select id,nombre from empleados");
            conn.cerrarBd();

            conn2.AbrirBD();
            cbsolicito.DisplayMember = "nombre";
            cbsolicito.ValueMember = "id";
            cbsolicito.DataSource =  conn2.GetTable("select id,nombre from empleados");
            conn2.cerrarBd();

            conn3.AbrirBD();
            txtfecha.Value = DateTime.Now;
            cbalmacen.DisplayMember = "nombre";
            cbalmacen.ValueMember = "id";
            cbalmacen.DataSource = conn3.GetTable("select id,nombre from catalmacen");
            conn3.cerrarBd();

        }
        private void Det_Inventarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.cerrarBd();
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
            else{ e.Handled = true;}
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
                conn.AbrirBD();

                //grid1.DataSource = conn.GetTable("select id,nombre_corto,nombre_largo from catarticulos");
                Grid_Articulos.DataSource = conn.GetTable("select id as Id_Producto,nombre_corto as Nombre,nombre_largo as Descripciion from catarticulos where nombre_corto like '%" + txtnombre.Text + "%' ");
                conn.cerrarBd();
                if (Grid_Articulos.RowCount<2)
                {
                    Grid_Articulos.Visible = false;
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
            if (e.KeyCode == Keys.Enter || e.KeyCode==Keys.Down)
            {
                txtcantidad.Focus();
            }
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
                if (bt_grabar.Text == "Aceptar")
                {
                    conn.AbrirBD();
                    panel1.Visible = true;
                    bt_grabar.Text = "Guardar";
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
                    else
                    {
                        MessageBox.Show("No existe ese numero de articulo¡");
                        txtid.Focus();
                    }
                    R.Close();
                    panel2.Enabled = false;
                    panel1.Visible = true;
                    txtid.Focus();
                }
                else
                {
                    grabar_grid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al guardar en la BD:" + ex.Message, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
