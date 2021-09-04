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

        public Square(string color, int length)
        {
            name = "Square";
            Shape.color = color;
            length = length;
        }

        public int GetArea()
        {
            return length * length;
        }
    }
}