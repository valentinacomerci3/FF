using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Models
{
    abstract public class Personaggio 
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int PuntiVita { get; set; }
        public int GiocatoreID { get; set; }
        public int ArmaID { get; set; }

        public override string ToString()
        {
            return $"Nome:{Nome}, Vita :{PuntiVita}";
        }
    }
}
