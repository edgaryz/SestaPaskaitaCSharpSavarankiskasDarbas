namespace SestaPaskaitaCSharpSavarankiskasDarbas.Models
{
    public class Automobilis
    {
        public string Marke { get; set; }
        public int Metai { get; set; }

        public Automobilis() { }

        public Automobilis(string marke, int metai)
        {

            Marke = marke;
            Metai = metai;
        }
    }
}
