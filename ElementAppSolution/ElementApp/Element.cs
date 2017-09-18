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

        //In C#, can call upon the smaller constructors

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
            bool isStable) : this(atomicNumber, symbol, name, atomicWeight)
        {
            //AtomicNumber = atomicNumber;
            //Symbol = symbol;
            //Name = name;
            //AtomicWeight = atomicWeight;
            GroupNumber = groupNumber;
            Family = family;
            Metallic = metallic;
            State = state;
            IsStable = isStable;
        }

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

        //Constructor (Blank)
        //public Element() { } //In C#, do not need a blank constructor, automatically built

    }
}
