using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Repositories
{
    public interface IRepositoryGiocatore : IRepository<Giocatore>
    {
        public bool Create(Giocatore giocatore);
    }
}
