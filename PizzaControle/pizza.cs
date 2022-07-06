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

        public string? Name { get; set; }

        public string? Description { get; set; }

        public DateTime? Created { get; set; }

        public int? Amount { get; set; }

        public decimal? Balance { get; set; }

        public bool? Blocked { get; set; }

        public enum Tamanho { Pequena = 0, Media = 1, Grande = 2 }






    }
}
