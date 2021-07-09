using FinalFantasy.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Repositories
{
    public interface IRepositoryGiocatore : IRepository<Giocatore>
    {
        public bool Create(Giocatore giocatore);
    }
}
