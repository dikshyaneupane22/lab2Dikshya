using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab2Dikshya
{
    public class MyClassA
    {
        public string message = "Hello from A!";

        public void DisplayMessage()
        {
            Console.WriteLine(message);
        }
    }
}

namespace NamespaceB
{
    public class MyClassB
    {
        public string message = "Hello from B!";

        public void DisplayMessage()
        {
            Console.WriteLine(message);
        }

        public void AccessNamespaceA()
        {
            // Accessing class from NamespaceA
            lab2Dikshya.MyClassA objA = new lab2Dikshya.MyClassA();

            // Accessing fields and methods from MyClassA
            objA.DisplayMessage();
        }
    }
}

class Program1
{
   /*  static void Main(string[] args)
     {
         // Accessing NamespaceB class
         NamespaceB.MyClassB objB = new NamespaceB.MyClassB();

         // Displaying message from NamespaceB
         objB.DisplayMessage();

         // Accessing and displaying message from NamespaceA through NamespaceB
         objB.AccessNamespaceA();
         Console.ReadKey();
     }   */
}
