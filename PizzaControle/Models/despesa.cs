using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaControle.Models
{
    internal class despesa
    {
        public int Id { get; set; }
        public int caixaId { get; set; }
        public decimal ammount { get; set; }
        public string? comment { get; set; }
        public DateTime? created_at { get; set; }
    }
}
