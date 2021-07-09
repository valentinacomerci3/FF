using FinalFantasy.Core.Models;
using FinalFantasy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryMock
{
    
    public class RepositoryGiocatoreMock : IRepositoryGiocatore
    {
        private ICollection<Giocatore> Giocatori = new List<Giocatore>()
    {
        new Giocatore{Nickname = "jj", Password= "try"},
        new Giocatore{Nickname = "dd", Password= "do", Eroi = new List<Eroe>{
            new Eroe {
                Nome="Gentsey",
                Livello=1,
                Categoria = Categoria.Wizard,
                },
            new Eroe
            {
                Nome="Travis",
                Livello =2,
                Categoria = Categoria.Soldier,
            }
            }
        }
    };

        public Giocatore Add(Giocatore item)
        {
            if (item != null)
            {
                foreach (Giocatore giocatore in Giocatori)
                {
                    if (giocatore.Nickname == item.Nickname)
                    {
                        Console.WriteLine("Nickname non disponibile");
                        return null;
                    }
                }
                Giocatori.Add(item);
                Console.WriteLine("Registrazione Completata");
                return item;
            }
            else
            {
                Console.WriteLine("Inserisci un Nickname");
                return null;
            }

        }

        public bool Create(Giocatore giocatore)
        {
            throw new NotImplementedException();
        }

        public ICollection<Giocatore> GetAll()
        {
            throw new NotImplementedException();
        }

        public Giocatore GetByName(string nome)
        {
            if (nome != null)
            {
                foreach (Giocatore item in Giocatori)
                {
                    if (item.Nickname == nome)
                    {
                        return item;
                    }
                }
                Console.WriteLine("Nickname Errato");
                return null;
            }
            else
            {
                return null;
            }
        }

        public ICollection<Eroe> MostraEroi(Giocatore giocatore)
        {
            return giocatore.Eroi;
        }
    }
}
