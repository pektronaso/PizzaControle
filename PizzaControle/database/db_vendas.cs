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


        public static string add_Venda(entregador ent)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                
                string sql = "INSERT INTO `vendas` (`caixaId`, `entregadorId`, `type`) VALUES ('"+ GetLastCaixa().id + "', '"+ent.id+"', 'balcao')";
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

    }
}
