using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3_Værksted
{
    public class Adresse
    {
        public string Vejnavn { get; set; }
        public string Nummer { get; set; }
        public string Postnummer { get; set; }

        public Adresse(string vejnavn, string nummer, string postnummer)
        {
            Vejnavn = vejnavn;
            Nummer = nummer;
            Postnummer = postnummer;
        }

    }
}
