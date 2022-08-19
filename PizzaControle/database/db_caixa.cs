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


        public static caixa GetLastCaixa()
        {

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
                    cx.created_At = (DateTime)rdr["created_at"];
                    cx.initial_ammount = (decimal)rdr["initial_ammount"];
                }

                if (rdr.HasRows)
                {
                    conn.Close();
                    return cx;
                }
                else
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

                string sql = "INSERT INTO `caixas` (`initial_ammount`,`created_at`) VALUES ('" + openValue.ToString().Replace(',', '.') + "','"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";

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

                string sql = "UPDATE `caixas` SET `closed_at`='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', `closed_ammount`='" + cx.closed_ammount.ToString().Replace(',', '.') + "' WHERE (`id`='" + cx.id + "') LIMIT 1";
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
                    if (count > 1)
                    {
                        _ = MessageBox.Show("múltiplos caixas abertos, Fechando caixas anteriores.");
                        CloseDupeCaixa();

                    }

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
