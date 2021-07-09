using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Models
{
    public enum Categoria
    {
        Soldier,
        Wizard
    }
    
    public class Eroe : Personaggio
    {
        public Categoria Categoria { get; set; }
        public int PuntiEsperienza { get; set; }

        //nav prop
        public string GiocatoreNickname { get; set; }
        public Giocatore Giocatore { get; set; }

       

        public override string ToString()
        {
            return $"{Nome} - Liv: {Livello} - PV: {PuntiVita} - Arma: {ArmaNome}\n";
        }
    }
}