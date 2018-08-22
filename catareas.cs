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
    public partial class catareas : Form
    {
        dbcom obj = new dbcom();
        private static string clickclave;
        private static string clicknombre;
        private static string amodificar;
        public catareas()
        {
            InitializeComponent();
        }

        private void catareas_Load(object sender, EventArgs e)
        {
            foto.Image = Image.FromFile(entrada.fotousuarioruta);
            usuario1.Text = " " + entrada.nombreusario;
            this.Text = entrada.tituloventana;
            try
            {
                this.dataGridView1.DataSource = obj.sql("SELECT clave as 'Clave', Nombre as 'Nombre' FROM catareas order by clave;");
                imprimir.Enabled = true;
                amodificar = "no";
            }
            catch (Exception)
            {
                MessageBox.Show("Error en catalogo de Areas");
                imprimir.Enabled = false;

            }

        } // load

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
                MessageBox.Show("Error click Catalogo de Areas...");
            }
        }//click grid

        private void agregar_Click(object sender, EventArgs e)
        {
            clave1.Enabled = true;
            nombre1.Enabled = true;
            nombre1.Focus();
            grabar.Enabled = true;
            cancelar.Enabled = true;
            agregar.Enabled = false;
        } // agregar

        private void cancelar_Click(object sender, EventArgs e)
        {
            clave1.Enabled = false;
            nombre1.Enabled = false;
            grabar.Enabled = false;
            cancelar.Enabled = false;
            agregar.Enabled = true;
            Modificar.Enabled = false;
            amodificar = "no";
        }// cancel

        private void Modificar_Click(object sender, EventArgs e)
        {

        }// modificar

        private void borrar_Click(object sender, EventArgs e)
        {

        }// borrar

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
                    obj.sql("UPDATE catareas SET nombre = '" +
                            this.nombre1.Text.ToUpper()
                              + "' WHERE clave = " +
                             this.dataGridView1.CurrentRow.Cells[0].Value.ToString()
                            + ";");
                    this.dataGridView1.DataSource = obj.sql("SELECT clave as 'Clave', Nombre as 'Nombre' FROM catareas order by clave;");

                    //this.ClearText();
                    clave1.Text = "";
                    nombre1.Text = "";
                    amodificar = "no";
                    MessageBox.Show("Modificacion de Areas terminada...");
                }
                catch (Exception)
                {
                    amodificar = "no";
                    MessageBox.Show("Error de modificación de Areas...");
                }

            }
            else
            {
                MySqlDataReader reader = obj.Estructura("SELECT clave FROM catareas where clave = '" + this.clave1.Text + "';");
                if (reader.Read() == false)
                {

                    try
                    {
                        obj.sql("INSERT INTO catareas (clave,nombre) VALUES('" + this.clave1.Text + "','" + this.nombre1.Text + "');");

                        /*  obj.sql("INSERT INTO area (nombre,clavedepto) VALUES('" +
                         this.nombre1.Text
                         + "','" +
                          this.depto1.Text
                         + "','" +
                          "');");*/

                        this.dataGridView1.DataSource = obj.sql("SELECT clave as 'Clave', Nombre as 'Nombre' FROM catareas order by clave;");

                        clave1.Text = "";
                        nombre1.Text = "";
                        amodificar = "no";
                        MessageBox.Show("Area se agrego correctamente...");
                    }
                    catch (Exception)
                    {
                        amodificar = "no";
                        MessageBox.Show("Error de agregar Area...");
                    }
                }
                else
                {
                    MessageBox.Show(" Area ya existe");
                    amodificar = "no";
                    nombre1.Focus();
                }


            } // if amodificar
        }// agregar

        private void imprimir_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
