using System;
using System.Collections.Generic;
using System.Text;

namespace ElementApp
{
    public static class ConsoleInterface
    {
        
        public static void ConsoleDisplay(List<Element> elements)
        {
            
            while (true)
            {
                Console.Write("Choose Search Criteria: ");
                var criteria = Console.ReadLine();
                switch (criteria)
                {
                    case "AtomicNumber":
                        //
                        return;
                    case "Name":
                        Console.Write("Search by Name: ");
                        var nSearch = Console.ReadLine();
                        Console.WriteLine("Input: " + nSearch);

                        Search.SearchByName(elements, nSearch);
                        return;
                    case "Family":
                        Console.Write("Search by Family: ");
                        var fSearch = Console.ReadLine();
                        Console.WriteLine("Input: " + fSearch);

                        if(fSearch == "Help")
                        {
                            Help.ShowFamilies();
                            break;
                        }

                        Search.SearchByFamily(elements, fSearch);
                        return;
                    case "Help":
                        //Help.PropertyNames();
                        break;
                    case "ShowAll":
                        Help.ShowAll(elements);
                        break;
                    default:
                        Console.WriteLine("Invalid! Valid Search Parameters:");
                        Help.PropertyNames();
                        Console.WriteLine("ShowAll");
                        break;
                }
            }
        }    
    }
}
