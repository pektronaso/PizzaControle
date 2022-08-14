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
        public static string add_despesa(int caixaId, decimal value, string comment)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO `despesas` (`caixaId`, `ammount`, `created_at` ,`comment`) VALUES ('" + caixaId + "', '" + value.ToString().Replace(',','.') + "', '"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,'" + comment + "')";
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

        public static void excluir_Despesa(string id)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "DELETE FROM `despesas` WHERE (`id`='" + id + "') LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                conn.Close();
            }
            conn.Close();


        }
        public static List<despesa> Get_Despesas(int caixaId)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();

                string sql = "SELECT * FROM despesas WHERE caixaId = '"+caixaId+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();
                
                List<despesa> despesas = new List<despesa>();

                
                while (rdr.Read())
                {
                    despesa dsp = new despesa();

                    dsp.Id = Convert.ToInt32(rdr["id"].ToString());
                    dsp.caixaId = Convert.ToInt32(rdr["caixaId"].ToString());
                    dsp.ammount = (decimal)rdr["ammount"];
                    dsp.created_at = (DateTime)rdr["created_at"];
                    dsp.comment = rdr["comment"].ToString();

                    despesas.Add(dsp);

                }

                conn.Close();

                return despesas;



            }
            catch (Exception)
            {
                conn.Close();
                return new List<despesa>();
            }

        }


    }
}
