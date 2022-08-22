using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaControle.Models
{
    internal class caixa
    {

        public int id { get; set; }        
        public DateTime created_At { get; set; }
        public DateTime closed_At { get; set; }
        public decimal closed_ammount { get; set; }
        public decimal initial_ammount { get; set; }


        public static bool ExistsOpenCaixa()
        {
            return Database.ExistsOpenCaixa();
        }

        public static caixa getLastCaixa()
        {

            return Database.GetLastCaixa();
        }

        public static void CloseCaixa(caixa cx)
        {

            Database.CloseCaixa(cx);

        }

        public static void OpenCaixa(decimal initialAmmount)
        {

            Database.OpenCaixa(initialAmmount);
        }


        public static void add_Entrada(int caixaId, decimal value, string comment)
        {

            Database.add_entrada(caixaId, value, comment);
        }

        public static void remove_Entrada(string id)
        {

            Database.excluir_Entrada(id);
        }

        public static List<entrada> Get_Entradas(int caixaId)
        {

            return Database.Get_Entradas(caixaId);
        }

        public static List<despesa> Get_Despesas(int caixaId) {

            return Database.Get_Despesas(caixaId);
        }

        public static void add_Despesa(int caixaId, decimal value, string comment) {

            Database.add_despesa(caixaId, value, comment);
        }

        public static void remove_Despesa(string id) {

            Database.excluir_Despesa(id);
        }


        public decimal Get_Total_Despesas()
        {
            decimal total = 0;
            foreach (despesa desp in Database.Get_Despesas(getLastCaixa().id))
            {
                total += desp.ammount;
            }
            return total;
        }

        public decimal Get_Total_Entradas()
        {
            decimal total = 0;
            foreach (entrada entr in Database.Get_Entradas(getLastCaixa().id))
            {
                total += entr.ammount;
            }
            return total;
        }

    }
}
