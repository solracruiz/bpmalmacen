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
        public static string fotousuarioruta, fotousuario, rutadefotos;
        public static string nombreusario, tituloventana,clave,clave2;
        public static string usuario,passwordusuario, claveusuario;
        public static string clavempleado1,localIP, mostrarfoto;
        conexion conn = new conexion();
        public entrada()
        {
            InitializeComponent();
        }

        private void entrada_Load(object sender, EventArgs e)
        {
            conn.AbrirBD();
            conn.cerrarBd();
            rutadefotos = "c:/bpmalmacen/fotos/";
            fotousuarioruta = rutadefotos + "foto.jpg";
            //C:\bpmalmacen\fotosd
        }


        private void Entrar_Click(object sender, EventArgs e)
        {
            conn.AbrirBD();
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

               // MessageBox.Show("Tú IP Local Es: " + localIP);

            }

            try
            {

                MySqlDataReader R = conn.GetData("SELECT usuario, nombre, idalmacen,permisos FROM usuarios where usuario='" + Nombre.Text.ToUpper() + "' and password='" + password.Text.ToUpper() + "';");
                if (R.HasRows)
                {
                    //principal frm = new principal();

                    menualmacen frm = new menualmacen();
                    frm.Show();
                    conn.cerrarBd();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Revisar Usuario y Password por favor");
                }

                R.Close();
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

    }
}

