using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Models
{
    public enum Category
    {
        Ghost,
        Lucifer
    }
    public class Mostro : Personaggio
    {
        
        public Category Category { get; set; }

    }
}