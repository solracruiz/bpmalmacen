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
   
    public partial class catalmacenes : Form
    {
        dbcom obj = new dbcom();
        private static string clickclave;
        private static string clicknombre;
        private static string amodificar;
        public catalmacenes()
        {
            InitializeComponent();
        }

        private void catalmacenes_Load(object sender, EventArgs e)
        {
            foto.Image = Image.FromFile(entrada.fotousuarioruta);
            usuario1.Text = " " + entrada.nombreusario;
            this.Text = entrada.tituloventana;
            try
            {
                this.dataGridView1.DataSource = obj.sql("SELECT clave as 'Clave', Nombre as 'Nombre' FROM catalmacen order by clave;");
                imprimir.Enabled = true;
                amodificar = "no";
            }
            catch (Exception)
            {
                MessageBox.Show("Error en catalogo de Almacenes");
                imprimir.Enabled = false;

            }
        } // load

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clickclave = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                clicknombre = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                clave1.Text = clickclave;
                nombre1.Text = clicknombre;
                Modificar.Enabled = true;
                agregar.Enabled = false;
                cancelar.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Error click Catalogo de Almacenes...");
            }
        } // click grid

        private void agregar_Click(object sender, EventArgs e)
        {
            clave1.Enabled = true;
            nombre1.Enabled = true;
            nombre1.Focus();
            grabar.Enabled = true;
            cancelar.Enabled = true;
            agregar.Enabled = false;
        }
    

        private void cancelar_Click(object sender, EventArgs e)
        {
            clave1.Enabled = false;
            nombre1.Enabled = false;
            grabar.Enabled = false;
            cancelar.Enabled = false;
            agregar.Enabled = true;
            Modificar.Enabled = false;
            amodificar = "no";
        } // cacelar

        private void Modificar_Click(object sender, EventArgs e)
        {

        }

        private void grabar_Click(object sender, EventArgs e)
        {
            dbcom obj = new dbcom();
            clave1.Enabled = false;
            nombre1.Enabled = false;
            grabar.Enabled = false;
            cancelar.Enabled = false;
            agregar.Enabled = true;
            imprimir.Enabled = true;

            if (amodificar == "si")
            {
                try
                {
                    obj.sql("UPDATE catalmacen SET nombre = '" +
                            this.nombre1.Text.ToUpper()
                              + "' WHERE clave = " +
                             this.dataGridView1.CurrentRow.Cells[0].Value.ToString()
                            + ";");
                    this.dataGridView1.DataSource = obj.sql("SELECT clave as 'Clave', Nombre as 'Nombre' FROM catalmacen order by clave;");

                    //this.ClearText();
                    clave1.Text = "";
                    nombre1.Text = "";
                    amodificar = "no";
                    MessageBox.Show("Modificacion de Almacenes terminada...");
                }
                catch (Exception)
                {
                    amodificar = "no";
                    MessageBox.Show("Error de modificación de Almacenes...");
                }

            }
            else
            {
                MySqlDataReader reader = obj.Estructura("SELECT clave FROM catalmacen where clave = '" + this.clave1.Text + "';");
                if (reader.Read() == false)
                {

                    try
                    {
                        obj.sql("INSERT INTO catalmacen (clave,nombre) VALUES('" + this.clave1.Text + "','" + this.nombre1.Text + "');");

                        /*  obj.sql("INSERT INTO area (nombre,clavedepto) VALUES('" +
                         this.nombre1.Text
                         + "','" +
                          this.depto1.Text
                         + "','" +
                          "');");*/

                        this.dataGridView1.DataSource = obj.sql("SELECT clave as 'Clave', Nombre as 'Nombre' FROM catalmacen order by clave;");

                        clave1.Text = "";
                        nombre1.Text = "";
                        amodificar = "no";
                        MessageBox.Show("Almacen se agrego correctamente...");
                    }
                    catch (Exception)
                    {
                        amodificar = "no";
                        MessageBox.Show("Error de agregar Almacen...");
                    }
                }
                else
                {
                    MessageBox.Show(" Almacen ya existe");
                    amodificar = "no";
                    nombre1.Focus();
                }


            } // if amodificar
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            // principal frm = new principal();
            // frm.Show();
            this.Hide();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clave1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nombre1_TextChanged(object sender, EventArgs e)
        {

        }

        private void usuario1_Click(object sender, EventArgs e)
        {

        }

        private void borrar_Click(object sender, EventArgs e)
        {

        }

        private void foto_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
