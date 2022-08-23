using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaControle.Models
{
    internal class entregador
    {
        public int id { get; set; }
        public string? nome { get; set; }

        public int inServiceID { get; set; }
        
        public decimal aReceber { get; set; }


        public static List<entregador> GetEntregadores()
        {
            return Database.GetEntregadores();
        }
        
    }
}
