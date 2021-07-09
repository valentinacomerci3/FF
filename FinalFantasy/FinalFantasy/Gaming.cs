using FinalFantasy.Core.Models;
using RepositoryMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy
{
    public class Gaming
    {
        //MENU INIZIALE DI GESTIONE DELL'UTENTE
        public static Giocatore MenuIniziale()
        {
            RepositoryGiocatoreMock repoGiocatore = new RepositoryGiocatoreMock();
            int scelta = 0;

            Console.WriteLine("1. Accedi");
            Console.WriteLine("2. Registrati");
            Console.WriteLine("3. Esci");

            scelta = VerificaScelta(3);

            switch (scelta)
            {
                case 1:
                    Console.WriteLine("Inserisci il tuo Nickname");
                    string nickname = Console.ReadLine();
                    return repoGiocatore.GetByName(nickname);
                case 2:
                    Console.WriteLine("Scegli un nuovo Nickname");
                    string NewNickname = Console.ReadLine();
                    while (NewNickname == "")
                    {
                        Console.WriteLine("Inserisci almeno un carattere");
                        NewNickname = Console.ReadLine();
                    }
                    Giocatore NewGiocatore = new Giocatore() { Nickname = NewNickname };
                    repoGiocatore.Add(NewGiocatore);
                    return NewGiocatore;
                case 3:
                    Console.WriteLine("A presto!");
                    break;
            }
            return null;

        }

        //MENU PRINCIPALE DI INIZIO PARTITA
        public static bool MenuGiocatore(Giocatore giocatore)
        {
            //ALL'INTERNO DI QUESTO MENU VADO A GESTIRE LE OPERAZIONI
            //INIZIALE DI CREAZIONE PARTITA
            //CREAZIONE EROE
            //SCELTA EROE
            //ELIMINARE EROE
            Console.WriteLine("MENU DI GIOCO UTENTI NON ADMIN");
            Console.WriteLine("1. Inizia la partita");
            Console.WriteLine("2. Crea un Eroe");
            Console.WriteLine("3. Elimina un Eroe");
            Console.WriteLine("4. Exit");
            int scelta = VerificaInput(4);
            switch (scelta)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    return false;
                default:
                    return false;
                    
            }
            return false;
        }




        public static void Partita(Eroe eroeScelto)
        {
            //METODO ALL'INTERNO DEL QUALE VADO A GESTIRE 
            //LA LOGICA RELATIVA AD UNA PARTITA
        }

        public static void Battaglia(Eroe eroeScelto, Mostro mostroSorteggiato)
        {
            //ALL'INTERNO DI QUESTO METODO VENGONO GESTITE LE CASISTICHE DI 
            //VITTORIA-PERDITA DELL'EROE
            //LA BATTAGLIA SI RIPETE FINCHE' L'EROE NON UCCIDE IL MOSTRO O VICEVERSA
        }

        //public static bool SceltaTurno(Eroe eroe, Mostro mostro)
        //{
        //    //METODO CHE CHIEDE ALL'UTENTE QUALE MOSSA ESEGUIRE
        //    //LOTTA O FUGA
        //
        //}

        public static int VerificaScelta(int sceltaMax)
        {
            bool check = Int32.TryParse(Console.ReadLine(), out int scelta);
            while (!check || scelta < 1 || scelta > sceltaMax)
            {
                Console.WriteLine("Scegli tra le opzioni");
                check = Int32.TryParse(Console.ReadLine(), out scelta);
            }
            return scelta;
        }

        public static int VerificaInput(int max)
        {
            var conversione = int.TryParse(Console.ReadLine(), out int result);
            while (conversione == false || result < 0 || result > max)
            {
                conversione = int.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }
    }
}
