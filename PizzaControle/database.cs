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


       

        public static caixa GetLastCaixa() {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();

                string sql = "SELECT * FROM caixas WHERE closed_at IS NULL";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                
                caixa cx = new caixa();
                
                while (rdr.Read())
                {
                     cx.id = Convert.ToInt32(rdr["id"].ToString());                     
                     cx.created_At =     (DateTime) rdr["created_at"];
                    cx.initial_ammount = (decimal)rdr["initial_ammount"];
                }

                if (rdr.HasRows)                {
                    conn.Close();
                    return cx;
                } else
                {
                    conn.Close();
                    return new caixa();
                }




            }
            catch (Exception)
            {
                conn.Close();
                return new caixa();
            }

        }

        public static void OpenCaixa(decimal openValue) 
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO `caixas` (`initial_ammount`) VALUES ('"+openValue.ToString().Replace(',','.')+"')";
                
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                conn.Close();
            }
            conn.Close();

        }

        public static void CloseCaixa(caixa cx)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                
                string sql = "UPDATE `caixas` SET `closed_at`='"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', `closed_ammount`='"+cx.closed_ammount.ToString().Replace(',','.')+"' WHERE (`id`='"+cx.id+"') LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                conn.Close();
            }
            conn.Close();


        }

        public static void CloseDupeCaixa()
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();

                string sql = "SELECT * FROM caixas WHERE closed_at IS NULL";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();


                List<caixa> cxs = new List<caixa>();

                while (rdr.Read())
                {
                    caixa cx = new caixa();
                    cx.id = Convert.ToInt32(rdr["id"].ToString());                    
                    cx.created_At = (DateTime)rdr["created_at"];
                    cxs.Add(cx);
                }


                for (int i = 0; i < cxs.Count; i++)
                {
                    if (GetLastCaixa().id != cxs[i].id)
                    {
                        
                        cxs[i].closed_ammount = 0;

                        CloseCaixa(cxs[i]);
                    }
                }



            }
            catch (Exception)
            {
                conn.Close();
            }
            
            conn.Close();
        }

        public static bool ExistsOpenCaixa()
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();
                
                string sql = "SELECT COUNT(*) FROM caixas WHERE closed_at IS NULL";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    if(count > 1) {
                        _ = MessageBox.Show("múltiplos caixas abertos, Fechando caixas anteriores.");
                        CloseDupeCaixa();
                        
                    }

                    conn.Close();
                    return true;

                } else {
                    conn.Close();
                    return false;
                }



            }
            catch (Exception)
            {
                conn.Close();
                return false;
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


                conn.Close();

                return entregadores;

            }
            catch (Exception)
            {
                conn.Close();
                return new List<entregador>();
            }





        }


        

        public static List<cliente> GetClientesWithSearch(String key, String value)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();

                string sql = "SELECT * FROM clientes WHERE(`"+key+"` LIKE'%" + value + "%')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<cliente> clientes = new List<cliente>();

                while (rdr.Read())
                {
                    cliente c = new cliente();

                    c.id = (int)rdr["id"];
                    c.nome = rdr["nome"].ToString();
                    c.endereço = rdr["endereco"].ToString();
                    c.numero = (int)rdr["numero"];
                    c.referencia = rdr["referencia"].ToString();
                    c.telefone = rdr["telefone"].ToString();



                    clientes.Add(c);

                }


                conn.Close();
                return clientes;

            }
            catch (Exception)
            {
                conn.Close();
                return new List<cliente>();
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


                conn.Close();
                return clientes;

            }
            catch (Exception)
            {
                conn.Close();
                return new List<cliente>();
            }





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
                conn.Close();
            }
            conn.Close();


        }

        public static void alterar_cliente(cliente cliente)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                                
                string sql = "UPDATE `clientes` SET `nome`= '"+cliente.nome+"', `endereco`= '"+cliente.endereço+"', `numero`= '"+cliente.numero+"', `referencia`= '"+cliente.referencia+"', `telefone`= '"+cliente.telefone+"' WHERE(`id`= '"+cliente.id+"') LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                conn.Close();
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
                conn.Close();
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
                conn.Close();
            }
            conn.Close();


        }

        public static string add_entrada(int caixaId, decimal value, string comment)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO `entradas` (`caixaId`, `ammount`, `comment`) VALUES ('" + caixaId + "', '" + value + "', '" + comment + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                return ex.ToString();
            }

            conn.Close();
            return "Despesa Registrada com Sucesso";

        }

        public static string add_despesa(int caixaId, decimal value, string comment)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO `despesas` (`caixaId`, `ammount`, `comment`) VALUES ('"+caixaId+"', '"+value+"', '"+comment+"')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                return ex.ToString();
            }

            conn.Close();
            return "Despesa Registrada com Sucesso";

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
                conn.Close();
                return ex.ToString();
            }

            conn.Close();
            return "Cliente Cadastrado com Sucesso";

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

     




    }
}
