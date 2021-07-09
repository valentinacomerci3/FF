
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Models
{
    public class Arma
    {
        
        public string Nome { get; set; }
        public int PuntiDanno { get; set; }
        public ICollection<Eroe> Eroi { get; set; } = new List<Eroe>();
        public ICollection<Mostro> Mostri { get; set; } = new List<Mostro>();

        public override string ToString()
        {
            return $"Nome:{Nome}, Danno :{PuntiDanno}";
        }

    }
}
