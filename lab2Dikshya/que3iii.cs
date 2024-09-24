using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Dikshya
{
    internal class PartialClassDemo
    {
        static void Main(string[] args)
         {
             MyClass myClass = new MyClass("Shruti", 24);
             myClass.Display();
             Console.ReadKey();
         }
    }
}
