using FinalFantasy.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Repositories
{
    public interface IRepositoryArma : IRepository<Arma>
    {
        //arma personaggio 
        public Arma GetByName(string nome);
    }
}
