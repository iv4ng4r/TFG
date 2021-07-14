using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FocaPlugin
{
	/*Clase encargada de la interaccion con la base de datos*/
    class DBAccess
    {
        
        
        public string connString;
        public string table;
        public string column;

        public bool connected = false;
        public SqlConnection db_conn;
        

        public DBAccess(string connString, string table, string column)
        {

            
            
            this.connString = @connString;
            this.table = table;
            this.column = column;
            this.db_conn = new SqlConnection(connString);
            this.db_conn.Open();
            this.connected = true;  
        }

        
        public List<String> getMails(){

            SqlCommand cmd = new SqlCommand("SELECT "+column+" FROM "+table, this.db_conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<string> result = new List<string>();


            while (dr.Read())
            {
                string mail = dr.GetString(0);
                result.Add(mail);
                
            }
            dr.Close();
            return result;
        }

        public void Close()
        {
            this.db_conn.Close();
        }
        
    }
}
