using FinalFantasy.Models;
using FinalFantasy.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy
{
    public static class Helper
    {
        public static int VerificaInput(int max)
        {
            bool verifica = Int32.TryParse(Console.ReadLine(), out int scelta);
            while (!verifica || scelta < 0 || scelta > max)
            {
                verifica = Int32.TryParse(Console.ReadLine(), out scelta);
            }
            return scelta;
        }

        public static void VisualizzaDati<T>(ICollection<T> data) where T : class
        {
            if (data.Count == 0)
            {
                Console.WriteLine("Non ci sono dati da visualizzare");
            }
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }

        }
        public static float VerificaInput()
        {
            bool verifica = float.TryParse(Console.ReadLine(), out float prezzo);
            while (!verifica || prezzo < 0)
            {
                Console.WriteLine("Inserisci valore corretto");
                verifica = float.TryParse(Console.ReadLine(), out prezzo);
            }
            return prezzo;
        }

        public static DateTime VerificaData()
        {
            bool verifica = DateTime.TryParse(Console.ReadLine(), out DateTime date);
            while (!verifica)
            {
                Console.WriteLine("Inserisci valore corretto (dd/mm/yyyy)");
                verifica = DateTime.TryParse(Console.ReadLine(), out date);
            }
            return date;
        }

        public static void GestisciScelta(int scelta)
        {
            switch (scelta)
            {
                case 1:
                    CreaEroe();
                    break;
                case 2:
                    ScegliEroe();
                    break;
                case 3:
                    EliminaEroe();
                    break;
                case 4:
                    NuovaPartita();
                    break;
                default:
                    Console.WriteLine("Arrivederci");
                    break;
            }
        }

        private static void NuovaPartita()
        {
            throw new NotImplementedException();
        }

        private static void EliminaEroe()
        {
            throw new NotImplementedException();
        }

        private static void ScegliEroe()
        {
            throw new NotImplementedException();
        }

        private static void CreaEroe()
        {
            throw new NotImplementedException();
        }

        public static void PrimaScelta(int scelta)
        {
            switch (scelta)
            {
                case 1:
                    VerificaGiocatore();
                    break;
                case 2:
                    AggiungiGiocatore();
                    break;
                default:
                    Console.WriteLine("Arrivederci");
                    break;
            }
        }

        private static void AggiungiGiocatore()
        {
            Console.Clear();
            Console.WriteLine("Inserisci i dati del nuovo giocatore");
            Console.Write("Nickname -> ");
            string nickname = Console.ReadLine();
            Console.Write("Password -> ");
            string password = Console.ReadLine();
            
            var giocatore = new Giocatore()
            {
                Nickname = nickname,
                Password = password,
                
            };

            //if (RepositoryGiocatore.Create(giocatore))
            //{
            //    Console.WriteLine("Operazione completata con successo!");
            //}
            //else
            //{
            //    Console.WriteLine("Ops, c'è stato qualche problema");
            //};
        }

        private static void VerificaGiocatore()
        {

            Console.Clear();
            Console.WriteLine("Inserisci i dati ");
            Console.Write("Nickname -> ");
            string nickname = Console.ReadLine();
            Console.Write("Password -> ");
            string password = Console.ReadLine();
            
            //if (nickname)
            //{
            //    Gaming.MenuIniziale();
            //}
            //else {
            //    Console.WriteLine("Ops, le credenziali non corrispondono a nessun giocatore, riprova o registra un Nuovo Giocatore");
            //    //riproponi verifica giocatore
            //    //riproponi registra
            //    Gaming.MenuIniziale();  
            //}
        }
    }
}