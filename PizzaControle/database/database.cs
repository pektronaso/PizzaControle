using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PizzaControle
{
    internal  static partial class Database
    {
        
        // MYSQL PARAMETERS CONFIG
        private static string _host = "localhost";
        private static int    _port = 3306;
        private static string _username = "root";
        private static string _password = "";
        private static string _databaseName = "pizzadb";

        static string connStr = "server="+_host+";user="+_username+";database="+_databaseName+";port="+_port+";password="+_password;



        public static  bool isConnected() {

            MySqlConnection conn = new MySqlConnection(connStr);
            
            try {
                
                conn.Open();
                conn.Close();
                return true;
            
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }

            

        }


    }
}
