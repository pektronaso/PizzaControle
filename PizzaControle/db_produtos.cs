using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaControle
{
    internal static partial class Database
    {

        public static string add_Produto(produto product)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO `produtos` (`id`, `nome`, `descricao`, `preco1`, `preco2`, `preco3`, `tipo`) VALUES ('" + product.id + "', '" + product.Nome + "', '" + product.Descrição + "', '" + product.preço1.ToString().Replace(',', '.') + "', '" + product.preço2.ToString().Replace(',', '.') + "', '" + product.preço3.ToString().Replace(',', '.') + "', '" + product.tipo + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                return ex.ToString();
            }

            conn.Close();
            return "Produto Cadastrado com Sucesso";

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
                conn.Close();
            }
            conn.Close();


        }

        public static string edit_Produto(produto product)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql_pizzas = "UPDATE `produtos` SET `nome`='" + product.Nome + "', `descricao`='" + product.Descrição + "', `preco1`='" + product.preço1 + "', `preco2`='" + product.preço2 + "', `preco3`='" + product.preço3 + "' WHERE (`id`='" + product.id + "') LIMIT 1";

                string sql_bebidas = "UPDATE `produtos` SET `nome`='" + product.Nome + "', `descricao`='" + product.Descrição + "', `preco1`='" + product.preço1 + "' WHERE (`id`='" + product.id + "') LIMIT 1";

                string sql = "";

                if (product.tipo == "pizzas")
                {
                    sql = sql_pizzas;
                }
                else if (product.tipo == "bebidas")
                {
                    sql = sql_bebidas;
                }

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                return ex.ToString();
            }

            conn.Close();
            return "Produto Alterado com Sucesso";

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

                    p.id = (int)rdr["id"];
                    p.Nome = rdr["Nome"].ToString();
                    p.Descrição = rdr["descricao"].ToString();
                    p.preço1 = Convert.ToDecimal(rdr["preco1"].ToString());
                    p.preço2 = Convert.ToDecimal(rdr["preco2"].ToString());
                    p.preço3 = Convert.ToDecimal(rdr["preco3"].ToString());
                    p.tipo = rdr["tipo"].ToString();


                    protudos.Add(p);

                }


                conn.Close();
                return protudos;

            }
            catch (Exception)
            {
                conn.Close();
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
                }
                else
                {
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


                conn.Close();
                return produtos;

            }
            catch (Exception)
            {
                conn.Close();
                return new List<produto>();
            }





        }



        public static bool Product_id_Exists(string id)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();

                string sql = "SELECT * FROM produtos WHERE produtos.id =  '" + id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();


                if (rdr.HasRows)
                {
                    conn.Close();
                    return true;
                }
                else
                {
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

    }
}
