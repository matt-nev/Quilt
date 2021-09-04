using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the quilt shape recorder");

            Console.WriteLine("Choose from the following list:");
            Console.WriteLine("S - Square");
            Console.WriteLine("T - Triangle");
            Console.WriteLine("R - Rectangle");
            Console.WriteLine("L - List all shapes");

            Console.WriteLine("your pick?");
            Console.ReadLine();

            Console.WriteLine("Please select a color");

            Console.WriteLine("Please enter the length");
            Console.ReadLine();

            Console.WriteLine("Please enter and wdith");
            Console.ReadLine();

            Console.WriteLine("Please enter the lngth of the sides");
            Console.ReadLine();
        }


                private List<Shape> shapes = new List<Shape>();

                foreach(var shape in shapes)
                {
                     Console.WriteLine($"{shape.Color} {shape.Name} with area {shape.GetArea()}.");
                }

            
            
            

            this is where i would create the objects 

            user input, choose shape. based on choice create shape. once object is created you'd do get.area 

        
    }
}
