using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3_Værksted
{
    internal class Firma : IHarAdresse
    {
        public string Navn { get; set; }
        public Adresse Adresse { get; set; }
        public string TlfNummer { get; set; }

        public Firma(string navn, Adresse adresse, string tlfNummer)
        {
            Navn = navn;
            Adresse = adresse;
            TlfNummer = tlfNummer;
        }
    }
}
