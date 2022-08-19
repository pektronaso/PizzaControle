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


        public static string add_entrada(int caixaId, decimal value, string comment)
        {
            
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO `entradas` (`caixaId`, `ammount`, `created_at` ,`comment`) VALUES ('" + caixaId + "', '" + value.ToString().Replace(',', '.') + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,'" + comment + "')";
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

        public static void excluir_Entrada(string id)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "DELETE FROM `entradas` WHERE (`id`='" + id + "') LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                conn.Close();
            }
            conn.Close();


        }


        public static List<entrada> Get_Entradas(int caixaId)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();

                string sql = "SELECT * FROM entradas WHERE caixaId = '" + caixaId + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                List<entrada> entradas = new List<entrada>();


                while (rdr.Read())
                {
                    entrada entr = new entrada();

                    entr.Id = Convert.ToInt32(rdr["id"].ToString());
                    entr.caixaId = Convert.ToInt32(rdr["caixaId"].ToString());
                    entr.ammount = (decimal)rdr["ammount"];
                    entr.created_at = (DateTime)rdr["created_at"];
                    entr.comment = rdr["comment"].ToString();

                    entradas.Add(entr);

                }

                conn.Close();

                return entradas;



            }
            catch (Exception)
            {
                conn.Close();
                return new List<entrada>();
            }

        }
    }
}
