using System;
using System.Collections.Generic;
using System.Linq;

namespace ElementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Periodic Table!");

            var elements = PeriodicTable.Table(); //Making a brand new instance in memory of a Periodic Table
            
            
            foreach(var element in elements)
            {
                Console.Write(element.AtomicNumber + ", ");
                Console.WriteLine(element.Name);
            }
            Console.Write("Search by Name: ");
            var search = Console.ReadLine();
            Console.WriteLine("Input: "+ search);

            var results = elements.Where(x => x.Name == search).FirstOrDefault();
            Console.WriteLine(results.AtomicNumber);

            Console.ReadLine();
        }
    }
}
