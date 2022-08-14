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
        public decimal initial_ammount { get; set; }


        public static caixa getLastCaixa() {

            return Database.GetLastCaixa();
        }

        public static void CloseCaixa(caixa cx) {

            Database.CloseCaixa(cx);

        }

        public static void OpenCaixa(decimal initialAmmount) { 
            
            Database.OpenCaixa(initialAmmount);
        }




    }
}
