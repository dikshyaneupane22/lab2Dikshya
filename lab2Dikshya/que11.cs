using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Dikshya
{
    class DataStore<T>
    {
        public T Data { get; set; }

        public void PrintData()
        {
            Console.WriteLine(Data);
        }
    }
    internal class GenericClassDemo
    {
      /*  static void Main(string[] args)
        {
            DataStore<int> dataStore = new DataStore<int>();
            dataStore.Data = 462;
            dataStore.PrintData();

            DataStore<string> dataStore1 = new DataStore<string>();
            dataStore1.Data = "462";
            dataStore1.PrintData();


            Console.ReadKey();

        }      */
    }
}
