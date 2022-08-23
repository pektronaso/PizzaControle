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


        public static string entregadorCheckIn(string entregadorId)
        {

             MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO `entregadorservice` (`caixaId`, `entregadorId`, `inDate`) VALUES ('"+caixa.getLastCaixa().id+"', '"+ entregadorId + "', '"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                return ex.ToString();
            }

            conn.Close();
            return "CheckIn de Entregador Registrado com Sucesso";


        }

        public static string entregadorCheckOut(string entregadorServiceId)
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "UPDATE `entregadorservice` SET `outDate`='"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE (`id`='"+ entregadorServiceId + "') LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                return ex.ToString();
            }

            conn.Close();
            return "CheckIn de Entregador Registrado com Sucesso";


        }


        public static List<entregador> Get_EntregadoresDisponible()
        {


            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                if (!caixa.ExistsOpenCaixa())
                {
                    MessageBox.Show("Caixa Fechado, tente novamente após abertura.");

                    Application.OpenForms["FormEntradaEntregador"].Close();

                    return new List<entregador>();


                }
                else
                {

                    conn.Open();

                    string sql = "SELECT * FROM entregadorservice WHERE caixaId = '" + caixa.getLastCaixa().id + "' AND outDate IS NULL";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    List<entregador> entregadorList = new List<entregador>();
                    List<entregadorService> serviceList = new List<entregadorService>();


                    while (rdr.Read())
                    {

                        // MANUAL SERIALIZE
                        entregadorService es = new entregadorService();
                        es.id = (int)rdr["id"];
                        es.entregadorId = (int)rdr["entregadorId"];
                        //es.inDate = (DateTime)rdr["inDate"];
                        serviceList.Add(es);
                        // MANUAL SERIALIZE
                    }



                    for (int i = 0; i < GetEntregadores().Count; i++)
                    {
                        bool disponible = true;
                        foreach (var srv in serviceList)
                        {
                            if (srv.entregadorId == GetEntregadores()[i].id)
                            {
                                disponible = false;
                            }

                        }

                        if (disponible)

                            entregadorList.Add(GetEntregadores()[i]);

                    }




                    conn.Close();

                    return entregadorList;

                }
            }
            catch (Exception)
            {
                conn.Close();
                return new List<entregador>();
            }



        

        }



        public static List<entregador> Get_EntregadoresIndisponible()
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {

                conn.Open();

                string sql = "SELECT * FROM entregadorservice WHERE caixaId = '" + caixa.getLastCaixa().id + "' AND outDate IS NULL";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<entregador> entregadorList = new List<entregador>();
                List<entregadorService> serviceList = new List<entregadorService>();


                while (rdr.Read())
                {

                    entregadorService es = new entregadorService();

                    es.id = (int)rdr["id"];

                    es.entregadorId = (int)rdr["entregadorId"];

                    //es.inDate = (DateTime)rdr["inDate"];

                    serviceList.Add(es);
                }



                for (int i = 0; i < GetEntregadores().Count; i++)
                {
                    int srvID = 0;
                    bool Disponible = true;
                    foreach (var srv in serviceList)
                    {
                        if (srv.entregadorId == GetEntregadores()[i].id)
                        {
                            Disponible = false;
                            srvID = srv.id;
                            
                        }

                    }

                    if (!Disponible)
                    {
                        entregador entr = GetEntregadores()[i];
                        entr.inServiceID = srvID;
                        entregadorList.Add(entr);
                    }

                }




                conn.Close();

                return entregadorList;

            }
            catch (Exception)
            {
                conn.Close();
                return new List<entregador>();
            }





        }


    }
}
