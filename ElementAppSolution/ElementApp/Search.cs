using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ElementApp
{
    public static class Search
    {
        public static void SearchByName(List<Element> elements)
        {
            Console.Write("Search by Name: ");
            var search = Console.ReadLine();
            Console.WriteLine("Input: " + search);

            var results = elements.Where(x => x.Name == search).FirstOrDefault();
            Console.WriteLine("Atomic Mass: " + results.AtomicWeight);
        }

        public static void SearchByFamily (List<Element> elements)
        {
            Console.Write("Search by Family: ");
            var search = Console.ReadLine();
            Console.WriteLine("Input: " + search);

            List<Element> sublist = elements.FindAll(x => x.Family == search);

            foreach (var list in sublist)
            {
                Console.WriteLine(list.AtomicNumber + ", " + list.Name);
            }

        }
    }
}
