namespace QuiltConsoleApp
{
    public class Rectangle : Shape
    {
        public int length;
        public int width;

        public Rectangle(string color, int rectangleLength, int rectangleWidth)
        {
            Name = "Rectangle";
            length = rectangleLength;
            width = rectangleWidth;
            Color = color;
        }

        public override int GetArea()
        {
            return length * width;
        }
    }

}
