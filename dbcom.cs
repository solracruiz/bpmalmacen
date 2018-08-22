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
    class dbcom
    {
        public dbcom()
        {


        }

        private MySqlConnection conect()
        {

            MySqlConnection conn = new MySqlConnection();

            try
            {
                conn.Close();
                if (entrada.pcmerida == "si")
                {
                    conn.ConnectionString = "Server=192.168.157.24; Database=bpmalmacen; Uid=root;PWD=c1r7g4s;Port=3306;Pooling=false;Connection Lifetime=1; Max Pool Size=1;";

                }
                if (entrada.pclocal == "si")
                {
                    conn.ConnectionString = "Server=localhost; Database=bpmalmacen; Uid=root;PWD=c1r7g4s;Pooling=false;Connection Lifetime=1; Max Pool Size=1;SslMode=none";

                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("Sin conectarse al servidor");
            }
            return conn;
        }

        public MySqlDataReader Estructura(String Sql)
        {
            try
            {

                MySqlConnection conn = this.conect();
                conn.Open();
                MySqlCommand ans = new MySqlCommand(Sql, conn);
                MySqlDataReader reader = ans.ExecuteReader();
                return reader;
            }
            catch (MySqlException) {
                            }

            return null;
        }

        public DataTable sql(String Sql)
        {
            DataTable tab = new DataTable();
            try
            {
                MySqlConnection conn = this.conect();
                conn.Open();
                MySqlDataAdapter addsc = new MySqlDataAdapter(Sql, conn);
                addsc.Fill(tab);
                conn.Close();
                conn.Close();
                conn.GetLifetimeService();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Sin conectarse a DataTAble dbcom");

            }
            return tab;
        }

        public String[] registro(String Sql)
        {
            try
            {

                MySqlConnection conn = this.conect();
                conn.Open();
                MySqlCommand ans = new MySqlCommand(Sql, conn);
                MySqlDataReader reader = ans.ExecuteReader();
                String[] dato = new String[reader.FieldCount];
                int i = 0;
                while (reader.Read())
                {
                    dato[i] = reader[0].ToString();
                    i++;
                }
                conn.Close();

                return dato;
            }
            catch (MySqlException) { }
            return null;
        }


        internal void sql(string p1, string p2)
        {
            throw new NotImplementedException();
        }

    
    }
}
