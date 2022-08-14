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

        public static List<cliente> GetClientesWithSearch(String key, String value)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();

                string sql = "SELECT * FROM clientes WHERE(`" + key + "` LIKE'%" + value + "%')";
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

        public static string add_Cliente(cliente client)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO clientes (nome, endereco, numero, referencia, telefone) VALUES ('" + client.nome + "','" + client.endereço + "', '" + client.numero + "', '" + client.referencia + "' , '" + client.telefone + "')";
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


        public static void alterar_cliente(cliente cliente)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "UPDATE `clientes` SET `nome`= '" + cliente.nome + "', `endereco`= '" + cliente.endereço + "', `numero`= '" + cliente.numero + "', `referencia`= '" + cliente.referencia + "', `telefone`= '" + cliente.telefone + "' WHERE(`id`= '" + cliente.id + "') LIMIT 1";
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

    }
}
