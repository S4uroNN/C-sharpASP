using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3_Værksted
{
    internal class Synsmand : Mekaniker
    {
        public int AntalSyn { get; set; }

        public Synsmand(CprNr cpr, string medarbejdernummer, string navn, Adresse adresse, double timeloen, int svendeprøve, int antalSyn) : base(cpr, medarbejdernummer, navn, adresse, timeloen, svendeprøve)
        {
            AntalSyn = antalSyn;
        }

        public override double BeregnLoen()
        {
            return AntalSyn * 290;
        }
    }
}
