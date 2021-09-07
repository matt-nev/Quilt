namespace QuiltConsoleApp
{
    public class Rectangle : Shape
    {
        public double length;
        public double width;

        public Rectangle(string color, double rectangleLength, double rectangleWidth)
        {
            Name = "Rectangle";
            length = rectangleLength;
            width = rectangleWidth;
            Color = color;
        }

        public override double GetArea()
        {
            return length * width;
        }
    }
}
