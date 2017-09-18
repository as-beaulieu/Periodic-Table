using System;
using System.Collections.Generic;


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

            Search.SearchByName(elements);

            Search.SearchByFamily(elements);

            Console.ReadLine();
        }
    }
}
