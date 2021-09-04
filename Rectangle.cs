using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltConsoleApp
{
    public class Rectangle : Shape
    {
        public int length;
        public int width;
       

        public Rectangle(string color, int length, int width)
        {
            name = "Rectangle";
            color = color;
            length = length;
            width = width;
        }

        public int GetArea()
        {
            return length * width;
        }
    }
}
