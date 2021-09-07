using System;

namespace QuiltConsoleApp
{
    public class Triangle : Shape
    {
        public int side1;
        public int side2;
        public int side3;

        public Triangle(string color, int Tside1, int Tside2, int Tside3)
        {
            Name = "Triangle";
            Color = color;
            side1 = Tside1;
            side2 = Tside2;
            side3 = Tside3;
        }

        public double GetArea()
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
