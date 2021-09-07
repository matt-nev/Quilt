﻿namespace QuiltConsoleApp
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

        public int GetArea()
        {
            return length * length;

            // public double Area => length * length;
        }
    }
}