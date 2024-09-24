using System;

namespace lab2Dikshya
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

      
        public Employee(string name, string email, decimal salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    class que1
    {
       /* static void Main(string[] args)
        {
            Employee employee = new Employee("Dikshya Neupane", "dikshya@example.com", 10000);

            employee.DisplayInfo();
        Console.ReadKey();
        }*/
    }
}