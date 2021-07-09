using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Models
{
    public class Giocatore
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
        public ICollection<Eroe> Eroi { get; set; } = new List<Eroe>();

        public override string ToString()
        {
            return $"Nome:{Nickname} ";
        }
    }
}