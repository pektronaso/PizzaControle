using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaControle
{
    internal class pizza
    {

        public int id { get; set; }

        public string? Nome { get; set; }

        public string? Descrição  { get; set; }

        public DateTime? Created { get; set; }

        public int? quantidade { get; set; }

        public decimal? preço { get; set; }

        public bool? Blocked { get; set; }

        public enum Tamanho { Pequena = 0, Media = 1, Grande = 2 }






    }
}
