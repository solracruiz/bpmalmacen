using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace bpmalmacen
{
    public class conexion
    {
        MySqlConnection MysqlConexion = new MySqlConnection();
        MySqlDataAdapter Adapter = new MySqlDataAdapter();
        MySqlCommand Command = new MySqlCommand();
        DataSet Data = new DataSet();
        DataTable Table = new DataTable();
        MySqlDataReader Reader;
        public String servidor = "";
        String nombreBD = "";
        String usuario = "";
        String password = "";
        String puerto = "3306";
        public void Nuevo()
        {
            servidor = "localhost";
            usuario = "root";
            password = "c1r7g4s";
            nombreBD = "bpmalmacen";
        }
        public MySqlConnection AbrirBD()
        {
            try
            {
                Nuevo();
                MysqlConexion = new MySqlConnection("server=" + servidor + "; database=" + nombreBD + "; Uid=" + usuario + "; pwd=" + password + ";SSLMode=None");
                MysqlConexion.Open();
                return MysqlConexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo en la conexion: " + ex.Message, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return null;
            }
        }

        public void cerrarBd()
        {
            try
            {
                MysqlConexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al desconectar con la BD:" + ex.Message, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }
        public Boolean Executa(string consulta)
        {
            try
            {
                //PropertyConexion.Open(); //'Se abre la base de datos
                //MySqlCommand PropertyCommand = new MySqlCommand();// 'Se crea instancia la propiedad MysqlCommand del objeto
                Command.Connection = MysqlConexion; //'indica conexion
                Command.CommandText = consulta; //'consulta sql
                Command.ExecuteNonQuery(); //'Ejecuta el query
                                           //MysqlConexion.Close();// 'Cierra Base de datos
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message);
                return false;
            }
        }

        public DataTable GetTable(string consulta)
        {
            try
            {
                //MysqlConexion.AbrirBD();
                Command.Connection = MysqlConexion;
                Command.CommandText = consulta;
                Data.Clear();
                Adapter = new MySqlDataAdapter(Command); //'se crea instancia del adaptador del objeto                           //'se crea instancia del dataset del objeto
                Adapter.Fill(Data);                  //'se llena el adaptador del objeto
                Table.Clear();
                if (Data.Tables[0].Rows.Count != 0)
                { //'valida registros                 
                    MySqlDataReader Reader = Command.ExecuteReader();  //      'se inicializa el MysqlDataReader del objeto
                    Table.Load(Reader);//
                                       //      MysqlConexion.Close();//                 'cierra base de datos   
                    return Table;//
                }// 'Retorna DataTable del Objeto    
                else
                {
                    //    MysqlConexion.Close();  //                               'Cierra base de datos en caso de que no cumpla con la validacion
                    return null;         //                                  'Retorna Nulo    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message);
                return null;
            }
        }

        public MySqlDataReader GetData(string consulta)
        {
            try
            {
                //MysqlConexion.AbrirBD();
                Command.Connection = MysqlConexion;
                Command.CommandText = consulta;
                Data.Clear();
                Adapter = new MySqlDataAdapter(Command); //'se crea instancia del adaptador del objeto                           //'se crea instancia del dataset del objeto
                Adapter.Fill(Data);                  //'se llena el adaptador del objeto
                Table.Clear();
                if (Data.Tables[0].Rows.Count != 0)
                { //'valida registros                 
                    return Command.ExecuteReader();  //      'se inicializa el MysqlDataReader del objeto
                   
                }// 'Retorna DataTable del Objeto    
                else
                {
                    //    MysqlConexion.Close();  //                               'Cierra base de datos en caso de que no cumpla con la validacion
                    return null;         //                                  'Retorna Nulo    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message);
                return null;
            }
        }


        public String PropertyServidor
        {
            get { return servidor; }
            set { servidor = value; }
        }
        public String PropertyNombreBD
        {
            get { return nombreBD; }
            set { nombreBD = value; }
        }
        public String PropertyUsuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public String PropertyPassword
        {
            get { return password; }
            set { password = value; }
        }
        public MySqlConnection PropertyConexion
        {
            get { return MysqlConexion; }
            set { MysqlConexion = value; }
        }

        public MySqlDataAdapter PropertyAdaptador
        {
            get { return Adapter; }
            set { Adapter = value; }
        }

        public DataSet PropertyDataSet
        {
            get
            {
                return Data;
            }
            set
            {
                Data = value;
            }
        }
        public MySqlCommand PropertyCommand
        {
            get
            {
                return Command;
            }
            set
            {
                Command = value;
            }
        }
        public MySqlDataReader PropertyReader
        {
            get
            {
                return Reader;
            }
            set
            {
                Reader = value;
            }
        }
        public DataTable PropertyTable
        {
            get
            {
                return Table;
            }
            set
            {
                Table = value;
            }
        }


    }
}
