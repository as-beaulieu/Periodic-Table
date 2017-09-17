using System;
using System.Collections.Generic;
using System.Text;

namespace ElementApp
{
    public class Element
    {
        //Properties
        public int AtomicNumber { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public decimal AtomicWeight { get; set; }
        public int GroupNumber { get; set; }
        public string Family { get; set; }
        public string Metallic { get; set; }
        public string State { get; set; }
        public bool IsStable { get; set; }

        //Constructor (Blank)
        public Element() { }

        //Constructor (Basic)
        public Element(
            int atomicNumber,
            string symbol,
            string name, 
            decimal atomicWeight)
        {
            AtomicNumber = atomicNumber;
            Symbol = symbol;
            Name = name;
            AtomicWeight = atomicWeight;
        }

        //Constructor (Full detail)
        public Element(
            int atomicNumber,
            string symbol,
            string name,
            decimal atomicWeight,
            int groupNumber,
            string family,
            string metallic,
            string state,
            bool isStable)
        {
            AtomicNumber = atomicNumber;
            Symbol = symbol;
            Name = name;
            AtomicWeight = atomicWeight;
            GroupNumber = groupNumber;
            Family = family;
            Metallic = metallic;
            State = state;
            IsStable = isStable;
        }
    }
}
