using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3_Værksted
{
    public class CprNr
    {
        public string BirthDate { get; set; }
        public string SequenceNumber { get; set; }
        public CprNr(string bDate, string sNumber)
        {
            BirthDate = bDate;
            SequenceNumber = sNumber;
        }
    }
}
