using System;

namespace InheritanceDemo
{
    // Base class for Single Inheritance
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Derived class for Single Inheritance
    public class Employee : Person
    {
        public string EmployeeId { get; set; }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
        }
    }

    // Derived class for Multi-level Inheritance
    public class Manager : Employee
    {
        public string Department { get; set; }

        public void DisplayManagerInfo()
        {
            Console.WriteLine($"Department: {Department}");
        }
    }

    // Base class for Hierarchical Inheritance
    public class Customer : Person
    {
        public string CustomerId { get; set; }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer ID: {CustomerId}");
        }
    }

    class Program
    {
       /* static void Main(string[] args)
        {
            // Demonstrate Single Inheritance
            Console.WriteLine("Single Inheritance:");
            Employee emp = new Employee
            {
                Name = "Alisha",
                Age = 30,
                EmployeeId = "E123"
            };
            emp.DisplayInfo();
            emp.DisplayEmployeeInfo();

            // Demonstrate Multi-level Inheritance
            Console.WriteLine("\nMulti-level Inheritance:");
            Manager mgr = new Manager
            {
                Name = "Rita",
                Age = 40,
                EmployeeId = "E456",
                Department = "HR"
            };
            mgr.DisplayInfo();
            mgr.DisplayEmployeeInfo();
            mgr.DisplayManagerInfo();

            // Demonstrate Hierarchical Inheritance
            Console.WriteLine("\nHierarchical Inheritance:");
            Customer cust = new Customer
            {
                Name = "Sabita",
                Age = 25,
                CustomerId = "C789"
            };
            cust.DisplayInfo();
            cust.DisplayCustomerInfo();
        }*/
    }
}
