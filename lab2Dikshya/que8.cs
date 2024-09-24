using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Dikshya
{
    class Numbers
    {
        public int Value { get; set; }

        // Constructor to initialize the value
        public Numbers(int value)
        {
            Value = value;
        }

        // Overload the + operator
        public static Numbers operator +(Numbers n1, Numbers n2)
        {
            return new Numbers(n1.Value + n2.Value);
        }

        // Display method
        public void Display()
        {
            Console.WriteLine("Value: " + Value);
            Console.ReadKey();
        }
    }

    class Program
    {
      /*  static void Main(string[] args)
        {
            // Create two Number objects
            Numbers num1 = new Numbers(6);
            Numbers num2 = new Numbers(12);

            // Add them using the overloaded + operator
            Numbers result = num1 + num2;

            // Display the result
            result.Display();  
        }   */
    }
}