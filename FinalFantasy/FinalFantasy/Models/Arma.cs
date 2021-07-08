using FinalFantasy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy
{
    public class Arma
    {
        
        public string Nome { get; set; }
        public int PuntiDanno { get; set; }
        public ICollection<Personaggio> Personaggi { get; set; } = new List<Personaggio>();

        public override string ToString()
        {
            return $"Nome:{Nome}, Danno :{PuntiDanno}";
        }

    }
}
