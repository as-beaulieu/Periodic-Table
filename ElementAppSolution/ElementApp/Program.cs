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

            ConsoleInterface.ConsoleDisplay(elements);

            Console.ReadLine();
        }
    }
}
