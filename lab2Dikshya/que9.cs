using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Dikshya
{
    class Person1
    {
        private string name;
        private int age;
        private string message;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
        }
        public string Message
        {
            set { message = value; }
        }

        public string Address { get; set; }
        public Person1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void DisplayInfo()
        {

            Console.WriteLine($"updated Name: {Name}");
            Console.WriteLine($" updated Age: {Age}");
            Console.WriteLine($" readonly Address: {Address}");
        }
    }

    class Program1234
    {
       /* static void Main()
        {
            Person1 person = new Person1("sarmila", 22);
            person.Name = "Dikshya Neupane";  // Setting name
            //writeonly
            person.Message = "Hello i am Dikshya Neupane";
            person.Address = "nuwakot";
            person.DisplayInfo();
            Console.ReadKey();
        }  */
    }
}
