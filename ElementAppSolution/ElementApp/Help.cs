using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ElementApp
{
    public static class Help
    {
        public static void PropertyNames()
        {
            //Display only property names in model of elements
            var properties = typeof(Element)
                                    .GetProperties()
                                    .Select(prop => prop.Name)
                                    .ToList();

            foreach (var property in properties)
            {
                Console.WriteLine(property);
            }
        }

        public static void ShowAll(List<Element> elements)
        {
            foreach(var element in elements)
            {
                Console.Write(element.AtomicNumber + ", ");
                Console.WriteLine(element.Name);
            }
        }

        public static void ShowFamilies()
        {
            Console.WriteLine("Alkali Metals");
            Console.WriteLine("Alkaline Earth Metals");
            Console.WriteLine("Transition Metals");
            Console.WriteLine("Halogens");
            Console.WriteLine("Noble Gasses");
        }
    }
}
