using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaControle.Models
{
    internal class produto
    {

        public int id { get; set; }

        public string? Nome { get; set; }

        public string? Descrição { get; set; }

        public DateTime? Created { get; set; }

        public int? quantidade { get; set; }

        public decimal preço1 { get; set; }

        public decimal preço2 { get; set; }

        public decimal preço3 { get; set; }

        public bool? Blocked { get; set; }

        public enum Tamanho { Pequena = 0, Media = 1, Grande = 2 }

        public string? tipo { get; set; }






    }
}
