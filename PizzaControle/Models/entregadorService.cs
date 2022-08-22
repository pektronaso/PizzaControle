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


    }
}
