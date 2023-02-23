using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lektion4
{
    internal static class ExtensionMethod
    {
        public static bool Lang(this string str, int n)
        {
            bool erLang = false;
            if(str.Length > n)
            {
                erLang= true;
            }
            return erLang;
        }
    }
}
