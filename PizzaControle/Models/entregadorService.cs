using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaControle.Models
{
    internal class entregadorService
    {
        public int id { get; set; }
        public int caixaId { get; set; }
        public int entregadorId { get; set; }
        public DateTime inDate { get; set; }
        public DateTime outDate { get; set; }



        public static string entregadorCheckIn(string entregadorId)
        {
            return Database.entregadorCheckIn(entregadorId);
        }

        
            public static string entregadorCheckOut(string entregadorServiceId)
        {
            return Database.entregadorCheckOut(entregadorServiceId);
        }


        public static List<entregador> Get_EntregadoresDisponible()
        {
            return Database.Get_EntregadoresDisponible();
        }

        public static List<entregador> Get_EntregadoresIndisponible()
        {
            return Database.Get_EntregadoresIndisponible();
        }


        }
}
