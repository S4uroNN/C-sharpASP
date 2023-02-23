namespace Lektion3_Værksted
{
    public abstract class Medarbejder : IHarAdresse
    {
        public string Navn { get; set; }
        public Adresse Adresse { get; set; }
        public CprNr Cpr { get; set; }
        
        public string Medarbejdernummer { get; set; }

        public const int _timerPrUge = 37;

        public Medarbejder(CprNr cpr,string medarbejdernummer, string navn, Adresse adresse)
        {
            Navn = navn;
            Adresse = adresse;
            Cpr = cpr;
            Medarbejdernummer = medarbejdernummer;
        }

        public int TimerPrUge
        {
            get { return _timerPrUge; }
        }

        public override string ToString()
        {
            return Cpr + ": " + Navn + " - " + Medarbejdernummer;
        }

        public abstract double BeregnLoen();
    }
}