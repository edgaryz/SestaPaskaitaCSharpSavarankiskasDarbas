namespace SestaPaskaitaCSharpSavarankiskasDarbas.Models
{
    public class Studentas
    {
        public string Vardas { get; set; }
        public int Pazymys { get; set; }

        public Studentas() { }
        public Studentas(string vardas, int pazymys)
        {
            Vardas = vardas;
            Pazymys = pazymys;
        }

        public bool ArIslaike()
        {
            if (Pazymys >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
    }
}
