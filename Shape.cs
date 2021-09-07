namespace QuiltConsoleApp
{


    public abstract class Shape
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public abstract int GetArea();
    }

}
