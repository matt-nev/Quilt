using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltConsoleApp
{
    public class Triangle : Shape
    {
        public int side1;
        public int side2;
        public int side3;

        public Triangle(string color, int side)
        {
            name = "Triangle";
            Shape.color = color;
            side1 = side;
            side2 = side;
            side3 = side;
        }

        public int GetArea()
        {
            int s = (side1 + side2 + side3) / 2;
            int x = s - side1;
            int y = s - side2;
            int z = s - side3;
            int answer = Convert.ToInt32(Math.Sqrt(s * x * y * z));

            return answer;
        }
    }
}
