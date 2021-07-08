namespace FinalFantasy
{
    public class Giocatore
    {
        public int ID { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"Nome:{Nickname} ";
        }
    }
}