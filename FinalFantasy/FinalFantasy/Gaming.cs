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
        public static bool MenuIniziale()
        {
            Console.WriteLine("Benvenuto");
            Console.WriteLine("1. Accedi");
            Console.WriteLine("2. Registrati");
            Console.WriteLine("3. Esci");
            int scelta = Helper.VerificaInput(3);
            Helper.PrimaScelta(scelta);
            
            return scelta > 0 && scelta < 3;

        }

        //MENU PRINCIPALE DI INIZIO PARTITA
        public static bool MenuGiocatore(Giocatore giocatore)
        {
            //ALL'INTERNO DI QUESTO MENU VADO A GESTIRE LE OPERAZIONI
            //INIZIALE DI CREAZIONE PARTITA
            //CREAZIONE EROE
            //SCELTA EROE
            //ELIMINARE EROE
            Console.WriteLine("Benvenuto");
            Console.WriteLine("1. Crea un Eroe");
            Console.WriteLine("2. Scegli un eroe");
            Console.WriteLine("3. Elimina Eroe");
            Console.WriteLine("4. Nuova Partita");
            Console.WriteLine("5. Esci");
            int scelta = Helper.VerificaInput(5);
            Helper.GestisciScelta(scelta);
            return scelta > 0 && scelta < 5;
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
        //}
    }
}
