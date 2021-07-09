using FinalFantasy.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Repositories
{
    public class RepositoryPersonaggio : IRepository<Personaggio>
    {
        public ICollection<Personaggio> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
