using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Dikshya
{
    class Animal
    {
        // Virtual method
        public virtual void Eat()
        {
            Console.WriteLine("The animal eats.");
        }
    }

    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The dog eats meat.");
        }
    }

    class Goat : Animal
    {
        // Override the virtual method
        public override void Eat()
        {
            Console.WriteLine("The goat eat grass.");
            Console.ReadKey();
        }
    }

    internal class Lab2  // Updated class name (PascalCase)
    {
        /* static void Main()
         {
             // Create objects of derived classes
             Animal myDog = new Dog();
             Animal myGoat = new Goat();

             // Call the eat method
             myDog.eat();  
             myGoat.eat();  
         }*/
    }
}