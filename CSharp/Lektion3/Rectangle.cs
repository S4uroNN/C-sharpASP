using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3
{
    internal class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle(int length, int width, int x, int y) : base(x, y)
        {
            Length= length;
            Width= width;
        }
    }
}
