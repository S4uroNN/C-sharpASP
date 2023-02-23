using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3_Værksted
{
    internal class Mekaniker : Medarbejder
    {
        public double Timeloen { get; set; }
        public int Svendeprøve { get; set; }

        public Mekaniker(CprNr cpr, string medarbejdernummer, string navn, Adresse adresse, double timeloen, int svendeprøve) : base(cpr, medarbejdernummer, navn, adresse)
        {
            Timeloen = timeloen;
            Svendeprøve = svendeprøve;  
        }

        public override double BeregnLoen()
        {
            return Timeloen* TimerPrUge;
        }
    }
}
