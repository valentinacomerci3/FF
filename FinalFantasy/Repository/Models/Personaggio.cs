using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Models
{
    abstract public class Personaggio 
    {
        public int ID { get; set; }
        public int Livello { get; set; }
        public string Nome { get; set; }
        public int PuntiVita { get; set; }

        //nav property
        public string ArmaNome { get; set; }
        public Arma Arma { get; set; }

        public override string ToString()
        {
            return $"Nome:{Nome}, Vita :{PuntiVita}";
        }
    }
}
