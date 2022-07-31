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


        public static bool Product_id_Exists(string id)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();

                string sql = "SELECT * FROM produtos WHERE produtos.id =  '"+id+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                
                if(rdr.HasRows)
                {
                    return true;
                } else
                {
                    return false;
                }

                

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


        public static List<produto> GetProdutos()
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();

                string sql = "SELECT * FROM produtos";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<produto> protudos = new List<produto>();

                while (rdr.Read())
                {
                    produto p = new produto();

                    p.id        =              (int)rdr["id"];
                    p.Nome      =                   rdr["Nome"].ToString();
                    p.Descrição =                   rdr["descricao"].ToString();
                    p.preço1    = Convert.ToDecimal(rdr["preco1"].ToString());
                    p.preço2    = Convert.ToDecimal(rdr["preco2"].ToString());
                    p.preço3    = Convert.ToDecimal(rdr["preco3"].ToString());
                    p.tipo      =                   rdr["tipo"].ToString();
                   

                    protudos.Add(p);

                }



                return protudos;

            }
            catch (Exception)
            {
                return new List<produto>();
            }





        }


        public static List<produto> GetProductsWithSearch(String key, String value)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();

                string sql = "";

                if (key == "id")
                {
                  sql = "SELECT * FROM produtos WHERE(`id` ='" + value + "')";
                } else { 
                 sql = "SELECT * FROM produtos WHERE(`" + key + "` LIKE'%" + value + "%')";                    
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<produto> produtos = new List<produto>();

                while (rdr.Read())
                {
                    produto p = new produto();

                    p.id = (int)rdr["id"];
                    p.Nome = rdr["nome"].ToString();                    
                    p.Descrição = rdr["descricao"].ToString();
                    
                    p.preço1 = (decimal)rdr["preco1"];
                    p.preço2 = (decimal)rdr["preco2"];
                    p.preço3 = (decimal)rdr["preco3"];
                    
                    p.tipo = rdr["tipo"].ToString();


                    produtos.Add(p);

                }



                return produtos;

            }
            catch (Exception)
            {
                return new List<produto>();
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



                return clientes;

            }
            catch (Exception)
            {
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


        public static void excluir_Produto(string id)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "DELETE FROM `produtos` WHERE (`id`='" + id + "') LIMIT 1";
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

        public static string add_Produto(produto product)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO `produtos` (`id`, `nome`, `descricao`, `preco1`, `preco2`, `preco3`, `tipo`) VALUES ('" + product.id + "', '" + product.Nome + "', '" + product.Descrição + "', '" + product.preço1.ToString().Replace(',','.') +"', '"+product.preço2.ToString().Replace(',', '.') + "', '"+product.preço3.ToString().Replace(',', '.') + "', '"+product.tipo+"')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            conn.Close();
            return "Produto Cadastrado com Sucesso";

        }

        public static string edit_Produto(produto product)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql_pizzas = "UPDATE `produtos` SET `nome`='"+product.Nome+"', `descricao`='"+product.Descrição+"', `preco1`='"+product.preço1+"', `preco2`='"+product.preço2+"', `preco3`='"+product.preço3+"' WHERE (`id`='"+product.id+"') LIMIT 1";
                
                string sql_bebidas = "UPDATE `produtos` SET `nome`='" + product.Nome + "', `descricao`='" + product.Descrição + "', `preco1`='" + product.preço1 + "' WHERE (`id`='" + product.id + "') LIMIT 1";

                string sql = "";

                if(product.tipo == "pizzas")
                {
                    sql = sql_pizzas;
                } else if (product.tipo == "bebidas"){
                    sql = sql_bebidas;
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            conn.Close();
            return "Produto Alterado com Sucesso";

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

     




    }
}
