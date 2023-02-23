using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3_Værksted
{
    internal class Værkfører : Mekaniker
    {
        public int VaerkførerSiden { get; set; }
        public int TillaegPrUge { get; set; }
        public Værkfører(CprNr cpr, string medarbejdernummer, string navn, Adresse adresse, double timeloen, int svendeprøve, int vaerkførerSiden, int tillaegPrUge) : base(cpr, medarbejdernummer, navn, adresse, timeloen, svendeprøve)
        {
            VaerkførerSiden = vaerkførerSiden;
            TillaegPrUge = tillaegPrUge;
        }

        public override double BeregnLoen()
        {
            return base.BeregnLoen() + TillaegPrUge;
        }
    }
}
