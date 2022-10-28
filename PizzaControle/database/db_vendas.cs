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

        public static int GetLastVendaId()
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();

                string sql = "SELECT * FROM vendas";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();


                venda vd = new venda();

                while (rdr.Read())
                {
                    vd.Id = (int)rdr["id"];                    
                    vd.caixaId = Convert.ToInt32(rdr["caixaId"].ToString());
                }

                if (rdr.HasRows)
                {
                    conn.Close();
                    
                    return vd.Id;
                }
                else
                {
                    conn.Close();                    
                    return 0;
                }




            }
            catch (Exception)
            {
                conn.Close();
                return 0;
            }

        }


        public static string Create_Venda(int id, entregador ent)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();                
                
                string sql = "INSERT INTO `vendas` (`id`,`caixaId`, `entregadorId`, `type`) VALUES ('"+id+"', '" + GetLastCaixa().id + "', '"+ent.id+"', 'balcao')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);                

                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                conn.Close();

                MessageBox.Show(ex.Message);

                return ex.ToString();
            }

            conn.Close();
            return "venda registrada com Sucesso";

        }


        public static string InsertItem_Venda(int vendaId, int productId, int pizzaSize)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO `vendingitens` (`vendaId`, `productId`, `pizzaSize`) VALUES ('"+ vendaId + "', '"+productId+"', '"+pizzaSize+"')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                conn.Close();

                MessageBox.Show(ex.Message);

                return ex.ToString();
            }

            conn.Close();
            return "item adicionado com Sucesso";

        }

    }
}
