using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaControle.Models
{
    internal class venda
    {
        public int Id { get; set; }
        public int caixaId { get; set; }
        public int entregadorId { get; set; }
        public string? type { get; set; }
        public DateTime createdAt { get; set; }
    }
}
