namespace QuiltConsoleApp
{


    public abstract class Shape
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public string GetArea()
        {
            return ($"{Color } {Name } with an area of {GetArea()}");
        }

    }
}
