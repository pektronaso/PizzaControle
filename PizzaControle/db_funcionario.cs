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



        public static string add_Funcionario(string nome)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO funcionarios (nome, senha, nivel) VALUES ('" + nome + "','123', '1')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                return ex.ToString();
            }

            conn.Close();
            return "Funcionário Cadastrado com Sucesso";

        }


        public static void excluir_Funcionario(string id)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "DELETE FROM `funcionarios` WHERE (`id`='" + id + "') LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                conn.Close();
            }
            conn.Close();


        }



        public static void alterar_Funcionario(string id, string nome)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "UPDATE `funcionarios` SET `nome`='" + nome + "' WHERE(`id`='" + id + "') LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                conn.Close();
            }
            conn.Close();


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

                    f.id = (int)rdr[0];
                    f.nome = rdr[1].ToString();
                    f.senha = rdr[2].ToString();
                    f.nivel = (int)rdr[3];


                    funcionarios.Add(f);

                }


                conn.Close();
                return funcionarios;

            }
            catch (Exception)
            {
                conn.Close();
                return new List<funcionario>();
            }





        }


    }
}
