using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PizzaControle
{
    internal static class database
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
                
                return true;
            
            }
            catch (Exception)
            {
                return false;
            }

            

        }


        public static List<funcionario> GetFuncionarios()
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                
                conn.Open();

                string sql = "SELECT * FROM funcionarios";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<funcionario> funcionarios = new List<funcionario>();

                while (rdr.Read())
                {
                    funcionario f = new funcionario();
                    
                    f.id    = (int)rdr[0];
                    f.nome  = rdr[1].ToString();
                    f.senha = rdr[2].ToString();
                    f.nivel = (int)rdr[3];


                    funcionarios.Add(f);                    
                    
                }



                return funcionarios;
                
            }
            catch (Exception)
            {
                return new List<funcionario>();
            }


            


        }


        public static List<entregador> GetEntregadores()
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();

                string sql = "SELECT * FROM entregadores";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<entregador> entregadores = new List<entregador>();

                while (rdr.Read())
                {
                    entregador e = new entregador();

                    e.id = (int)rdr[0];
                    e.nome = rdr[1].ToString();
                    
                    entregadores.Add(e);

                }



                return entregadores;

            }
            catch (Exception)
            {
                return new List<entregador>();
            }





        }

        public static List<cliente> GetClientes()
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();

                string sql = "SELECT * FROM clientes";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<cliente> clientes = new List<cliente>();

                while (rdr.Read())
                {
                    cliente c = new cliente();

                    c.id = (int)rdr["id"];
                    c.nome = rdr["nome"].ToString();
                    c.endereço = rdr["endereco"].ToString();
                    c.numero = (int) rdr["numero"];
                    c.referencia = rdr["referencia"].ToString();
                    c.telefone = rdr["telefone"].ToString();


                    
                    clientes.Add(c);

                }



                return clientes;

            }
            catch (Exception)
            {
                return new List<cliente>();
            }





        }


        public static void alterar_Funcionario(string id, string nome)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "UPDATE `funcionarios` SET `nome`='"+nome+"' WHERE(`id`='"+id+"') LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            conn.Close();


        }

        public static void alterar_Entregador(string id, string nome)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "UPDATE `entregadores` SET `nome`='" + nome + "' WHERE(`id`='" + id + "') LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            conn.Close();


        }

        public static void excluir_Funcionario(string id)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "DELETE FROM `funcionarios` WHERE (`id`='"+id+"') LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) {
                
            }
            conn.Close();
            

        }



        public static void excluir_Entregador(string id)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "DELETE FROM `entregadores` WHERE (`id`='" + id + "') LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            conn.Close();


        }


        public static void excluir_Cliente(string id)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "DELETE FROM `clientes` WHERE (`id`='" + id + "') LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            conn.Close();


        }

        public static string add_Cliente(cliente client)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO clientes (nome, endereco, numero, referencia, telefone) VALUES ('" + client.nome + "','"+client.endereço+"', '"+client.numero+"', '"+client.referencia+"' , '"+client.telefone+"')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            conn.Close();
            return "Cliente Cadastrado com Sucesso";

        }

        public static string add_Funcionario (string nome) {
        
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {             
                conn.Open();

                string sql = "INSERT INTO funcionarios (nome, senha, nivel) VALUES ('"+nome+"','123', '1')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            conn.Close();
            return "Funcionário Cadastrado com Sucesso";

        }

        public static string add_Entregador(string nome)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO entregadores (nome) VALUES ('" + nome + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            conn.Close();
            return "Entregador Cadastrado com Sucesso";

        }

        public static void TestSelect() {
            
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "SELECT * FROM pizza";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");

        }




    }
}
