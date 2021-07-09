using FinalFantasy.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Repositories
{
    public class RepositoryArma : IRepositoryArma
    {
        public ICollection<Arma> GetAll()
        {
            throw new NotImplementedException();
        }

        public Arma GetByName(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
