using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltConsoleApp
{
    public class Square : Shape
    {
        public int length;

        public Square(string color, int squareLength)
        {
            Name = "Square";
            Color = color;
            length = squareLength;
        }

        public double Area => length * length;
    }
}