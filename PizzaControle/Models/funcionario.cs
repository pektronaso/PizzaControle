using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaControle.Models
{
    internal class funcionario
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public int nivel { get; set; }
        public string? senha { get; set; }



        public static List<funcionario> GetFuncionarios()
        {
            return Database.GetFuncionarios();
        }

    }
}
