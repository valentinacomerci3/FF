using FinalFantasy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Repositories
{
    public class RepositoryPersonaggio : IRepositoryPersonaggio
    {
        public ICollection<Personaggio> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
