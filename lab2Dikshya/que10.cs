using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Dikshya
{
    // Base class: Shape
    public class Shape
    {
        // Properties for Length and Breadth
        public double Length { get; set; }
        public double Breadth { get; set; }

        // Default constructor
        public Shape()
        {
            Length = 0;
            Breadth = 0;
        }

        // Parameterized constructor
        public Shape(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
    }

    // Derived class: Rectangle
    public class Rectangle : Shape
    {
        // Parameterized constructor to initialize the Rectangle with length and breadth
        public Rectangle(double length, double breadth) : base(length, breadth)
        {
        }

        // Method to calculate the area of the rectangle
        public double CalculateArea()
        {
            return Length * Breadth;
        }
    }

    class Area
    {
     /*   static void Main(string[] args)
        {
            // Creating a rectangle using the parameterized constructor
            Rectangle rectangle = new Rectangle(52, 5);

            // Calculating and displaying the area of the rectangle
            Console.WriteLine("The area of the rectangle is: " + rectangle.CalculateArea());

            Console.ReadLine();
        }    */
    }
}
