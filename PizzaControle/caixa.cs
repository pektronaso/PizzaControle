using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaControle
{
    internal class caixa
    {

        public int id { get; set; }
        public string? code { get; set; }
        public DateTime created_At { get; set; }
        public DateTime closed_At { get; set; }
        public decimal closed_ammount { get; set; }


    }
}
