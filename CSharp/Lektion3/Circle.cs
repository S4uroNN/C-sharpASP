using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3
{
    internal class Circle : Shape
    {
        public double R { get; set; }

        public Circle(double r, int x, int y) : base(x, y)
        {
            R = r;
        }
    }
}
