using System;
using System.Collections.Generic;

namespace QuiltConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            int side1 = 0;
            int side2 = 0;
            int side3 = 0;
            int length = 0;
            int width = 0;
            string color = " ";
            Boolean next = true;

            try
            {
                Console.WriteLine("Welcome to the quilt shape recorder");

                while (next)
                {
                    Console.WriteLine("Choose from the following list:");
                    Console.WriteLine("S - Square");
                    Console.WriteLine("T - Triangle");
                    Console.WriteLine("R - Rectangle");
                    Console.WriteLine("L - List all shapes");
                    Console.WriteLine("your pick?");

                    switch (Console.ReadLine())
                    {
                        case "S":
                            Console.WriteLine("You chose square");
                            Console.WriteLine("Please select a color");
                            color = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter the length of the sides: ");
                            length = Convert.ToInt32(Console.ReadLine());
                            Square square = new Square(color, length);
                            square.GetArea();
                            shapes.Add(square);
                            Console.WriteLine("You added a square");
                            break;

                        case "R":
                            Console.WriteLine("You chose rectangle");
                            Console.WriteLine("Please select a color");
                            color = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter the length of the sides: ");
                            length = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the width of the sides: ");
                            width = Convert.ToInt32(Console.ReadLine());
                            Rectangle rectangle = new Rectangle(color, length, width);
                            rectangle.GetArea();
                            shapes.Add(rectangle);
                            Console.WriteLine("You added a rectangle");
                            break;


                        case "T":
                            Console.WriteLine("You chose triangle");
                            Console.WriteLine("Please select a color");
                            color = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter the length of the first side: ");
                            side1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the length of the second side: ");
                            side2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the length of the third side: ");
                            side3 = Convert.ToInt32(Console.ReadLine());
                            Triangle triangle = new Triangle(color, side1, side2, side3);
                            triangle.GetArea();
                            shapes.Add(triangle);
                            Console.WriteLine("You added a triangle");
                            break;

                        case "L":
                            Console.WriteLine("Your current shapes are: ");
                            foreach (var shape in shapes)
                            {
                                Console.WriteLine($"{shape.Color} {shape.Name} with area {shape.GetArea()}.");
                            }
                            next = false;
                            break;

                    }

                }
            }


            catch
            {
                Console.WriteLine("an error occured, exiting");
            }
        }

    }

}




// var square = new Square("", 0);
//square.length = 5;
//Console.WriteLine("Area of Square : {0}", square.GetArea());


//static Square CreateSquare()
//{
//    Console.WriteLine("You chose a square");
//    Console.WriteLine("Please choose a color");
//        Console.ReadLine();
//    Console.WriteLine("Please enter the length");
//        Console.ReadLine();

//    return;
//}

//Rectangle R = new Rectangle;
//{
//    return ;
//    int;
//    int;
//    Console.WriteLine("Please enter length and wdith");
//    Console.ReadLine();
//}

//class Triangle {
//    Console.WriteLine("Please enter the length of all 3 sides");
//    Console.ReadLine();
//}

//  this is where i would create the objects 

//  user input, choose shape. based on choice create shape. once object is created you'd do get.area 

//    Shape.Addclass to add 

//    everytime you have user input stuff, create instance of rectangle or square, inpout info and then add to list. list needs to be created. 

//     while loop, if if if else else elseif

//              foreach (var shape in shapes)
//{
//    Console.WriteLine($"{shape.Color} {shape.Name} with area {shape.GetArea()}.");
//}