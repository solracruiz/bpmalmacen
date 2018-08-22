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
using System.Net;
using System.Net.NetworkInformation;



namespace bpmalmacen
{
    public partial class entrada : Form
    {
        dbcom obj = new dbcom();
        public static string numeroempleado;
        public static string fotousuarioruta, fotousuario, rutadefotos;
        public static string nombreusario;
        public static string usuario, tituloventana;
        public string str1;
        public static string passwordusuario, claveusuario;
        public static string clavempleado1;
        public static string fotoempleado1, localIP, pcmerida, pclocal, mostrarfoto;

        public entrada()
        {
            InitializeComponent();
        }

        private void entrada_Load(object sender, EventArgs e)
        {
         // checamos ip
         mostrarfoto = "no";
         string ipmerida = "192.168.157.24"; // ip servidor de merida 192.168.0.150
         string iplocal = "192.168.207.131"; //  ip local 192.168.0.3    
        // string iplocal = "10.18.2.19";
          pcmerida = modulo1.pingdered(ipmerida);
          pclocal = modulo1.pingdered(iplocal);

            conexion conn = new conexion();
            conn.AbrirBD();

            if (entrada.pcmerida == "no" && entrada.pclocal == "no")
          {
              MessageBox.Show("No autorizado para el uso del sistema BPMalmacen");
              Environment.Exit(0);
          }
         dbcom obj3 = new dbcom();

            

            MySqlDataReader R = conn.GetData("SELECT nombre,clave2,dato1,dato2,dato3 FROM configuracion ;");
            string nombre;
            string serial = "";
            string serial1 = "";
            string serial2 = "";
            string serial3 = "";
            if (R.Read())
                {
                nombre = R[0].ToString();
                serial = R[1].ToString();
                serial1 = R[2].ToString().ToUpper();
                serial2 = R[3].ToString().ToUpper();
                serial3 = R[4].ToString().ToUpper();
            }

            R.Close();

         string serie = "tenerife2018-192.168.157.24-atenas2018";
        serial = modulo1.Desencriptar(serial);
        serial = modulo1.Desencriptar(serial);
    
         if (pcmerida == "si" | pclocal == "si")
         {

             if (pclocal == "si")
             {
               fotousuario =  "foto";
                 rutadefotos = "c:/bpmalmacen/fotos/";
                 fotousuarioruta = rutadefotos + fotousuario + ".jpg";
             }
             if (pcmerida == "si")
             {
                 fotousuario = "foto";
                 rutadefotos = "//PROLIANT-C24F1D/bpmalmacen/fotos/";
                 fotousuarioruta = rutadefotos + fotousuario + ".jpg";
             }


             IPHostEntry host;
             localIP = "";
             host = Dns.GetHostEntry(Dns.GetHostName());
             foreach (IPAddress ip in host.AddressList)
             {
                 if (ip.AddressFamily.ToString() == "InterNetwork")
                 {
                     localIP = ip.ToString();
                 }
             }
                
                R = conn.GetData("SELECT nombre,foto FROM usuarios ;");
                while (R.Read())
                 {
                 string nmbreusuario = R[0].ToString().ToUpper(); 
                 string fotousuario = R[1].ToString().ToUpper(); 
                 if (fotousuario == "")
                 {
                     fotousuario = "foto";
                 }
                 fotousuarioruta = rutadefotos + fotousuario + ".jpg";
                 foto.Image = Image.FromFile(fotousuarioruta);
                 Nombre.Text = nmbreusuario;
             }
                R.Close();
                try
             {

                 
                 mostrarfoto = "no";

                    dbcom obj = new dbcom();
                    //  obj.sql("SET GLOBAL max_connections = 300;");
                    // MySqlDataReader reader = obj.Estructura("SELECT nombre, numero, password FROM usuarios where string.trim(numero) = 1150;");
              
                    // String a = this.textBox1.Text.ToUpper();
                    //this.dataGridView1.DataSource = obj.sql("SELECT nombre as 'Nombre', numero as 'Numero' FROM usuarios; ");

                    this.dataGridView1.DataSource = conn.GetTable("SELECT nombre as 'Nombre', numero as 'Numero' FROM usuarios; ");




                    /* MySqlDataReader reader = obj2.Estructura("SELECT nombre FROM configuracion ;");
                     mostrarfoto = "si";
                     while (reader.Read())
                     {
                         tituloventana = reader[0].ToString().ToUpper();
                     }

                     this.Text = tituloventana;
                     reader.Close();*/
                }
             catch (Exception)
             {
                 MessageBox.Show("Error acceso usuarios");
                 mostrarfoto = "no";
             }
         }
         else
         {
             MessageBox.Show("El servidor de BPMasistencia no se encuentra");
             Application.Exit();
         }
         }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                MessageBox.Show("Favor de ingresar su password...");
                password.Focus();
                return;
            }
            else
            {
                IPHostEntry host;
                localIP = "";
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily.ToString() == "InterNetwork")
                    {
                        localIP = ip.ToString();
                    }
                }

              //  MessageBox.Show("Tú IP Local Es: " + localIP);

            }
            
            try
            {
               
                dbcom obj = new dbcom();
              //  obj.sql("SET GLOBAL max_connections = 300;");
               // MySqlDataReader reader = obj.Estructura("SELECT nombre, numero, password FROM usuarios where string.trim(numero) = 1150;");
                MySqlDataReader reader = obj.Estructura("SELECT usuario, password, numero,clave FROM usuarios ;");
                // String a = this.textBox1.Text.ToUpper();
               // String b = this.textBox2.Text.ToUpper();
                while (reader.Read())
                {
                   usuario = reader[0].ToString().ToUpper();
                   passwordusuario = reader[1].ToString().ToUpper();
                   claveusuario = passwordusuario = reader[3].ToString().ToUpper();
                   string fechaingreso = DateTime.Now.ToString();
                    if (numeroempleado == reader[2].ToString().ToUpper() && password.Text == reader[1].ToString().ToUpper())
                    {
                        obj.sql(" UPDATE usuarios SET usuarioip = '" +
                                         localIP
                                          + "', fechaentrada = '" +
                                                  fechaingreso.Trim()
                                          + "' WHERE clave = '" +
                                          claveusuario
                                          + "';");
                           principal frm = new principal();
                            frm.Show();
                            this.Hide();
                            break;
                  //      MainForm.ActiveForm.MainMenuStrip.Visible = true;
                        //MainForm.ActiveForm.MainMenuStrip.Items.RemoveAt(1);
                        //MainForm.indice_usuario = 0;
                 //       MainForm.ActiveForm.Tag = reader[0];
                 //       this.Close();
                   }
                }
                reader.Close();
              //  MessageBox.Show("El password no se encontro...");
            }
            catch (Exception) 
            {
                MessageBox.Show("No existen usuarios...");
            }
            
        }

        private void Salir_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
             //   Nombre.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
             //   nombreusario = Nombre.Text;
             //   numeroempleado = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                 try
                 {

                Nombre.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                nombreusario = Nombre.Text;
                numeroempleado = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                 /*  dbcom obj = new dbcom();
                  MySqlDataReader reader = obj.Estructura("SELECT nombre, numero, password, usuario FROM usuarios where nombre = '" + nombreusario + "';");
                 */
                if (numeroempleado == "")
                {
                    fotousuarioruta = rutadefotos + "foto.jpg";

                }
                else
                {
                    fotousuarioruta = rutadefotos + numeroempleado + ".jpg";


                }

                foto.Image = Image.FromFile(fotousuarioruta);
                foto2.Image = Image.FromFile(fotousuarioruta);

             }
             catch (Exception)
              {
             // MessageBox.Show("Foto de usuario no encontrada...");
              }

                //mostrarlafoto();
              
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        }
    }

