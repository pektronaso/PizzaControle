using MySql.Data.MySqlClient;
using PizzaControle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaControle
{
    internal static partial class Database
    {


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
    }
}
