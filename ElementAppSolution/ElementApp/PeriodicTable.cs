using System;
using System.Collections.Generic;
using System.Text;

namespace ElementApp
{
    public class PeriodicTable
    {
        public static List<Element> Table()
        {
            List<Element> elements = new List<Element>
            {
                new Element
                {
                    AtomicNumber = 1,
                    Symbol = "H",
                    Name = "Hydrogen",
                    AtomicWeight = 1.007825M,
                    GroupNumber = 1,
                    Family = "null",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 2,
                    Symbol = "He",
                    Name = "Helium",
                    AtomicWeight = 4.00260M,
                    GroupNumber = 18,
                    Family = "Noble Gas",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 3,
                    Symbol = "Li",
                    Name = "Lithium",
                    AtomicWeight = 6.941M,
                    GroupNumber = 1,
                    Family = "Alkali Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 4,
                    Symbol = "Be",
                    Name = "Beryllium",
                    AtomicWeight = 9.012182M,
                    GroupNumber = 2,
                    Family = "Alkaline Earth Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 5,
                    Symbol = "B",
                    Name = "Boron",
                    AtomicWeight = 10.811M,
                    GroupNumber = 13,
                    Family = "Null",
                    Metallic = "Metalloid",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 6,
                    Symbol = "C",
                    Name = "Carbon",
                    AtomicWeight = 12.0107M,
                    GroupNumber = 14,
                    Family = "Null",
                    Metallic = "Metalloid",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 7,
                    Symbol = "N",
                    Name = "Nitrogen",
                    AtomicWeight = 14.0067M,
                    GroupNumber = 15,
                    Family = "Null",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 8,
                    Symbol = "O",
                    Name = "Oxygen",
                    AtomicWeight = 15.9994M,
                    GroupNumber = 16,
                    Family = "Null",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 9,
                    Symbol = "F",
                    Name = "Flourine",
                    AtomicWeight = 18.9984032M,
                    GroupNumber = 17,
                    Family = "Halogens",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 10,
                    Symbol = "Ne",
                    Name = "Neon",
                    AtomicWeight = 20.1797M,
                    GroupNumber = 18,
                    Family = "Noble Gasses",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 11,
                    Symbol = "Na",
                    Name = "Sodium",
                    AtomicWeight = 22.98976928M,
                    GroupNumber = 1,
                    Family = "Alkali Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 12,
                    Symbol = "Mg",
                    Name = "Magnesium",
                    AtomicWeight = 24.3050M,
                    GroupNumber = 2,
                    Family = "Alkaline Earth Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 13,
                    Symbol = "Al",
                    Name = "Aluminium",
                    AtomicWeight = 26.9815386M,
                    GroupNumber = 13,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 14,
                    Symbol = "Si",
                    Name = "Silicon",
                    AtomicWeight = 28.0855M,
                    GroupNumber = 14,
                    Family = "Null",
                    Metallic = "Metalloid",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 15,
                    Symbol = "P",
                    Name = "Phosphorus",
                    AtomicWeight = 30.973762M,
                    GroupNumber = 15,
                    Family = "Null",
                    Metallic = "Nonmetal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 16,
                    Symbol = "S",
                    Name = "Sulphur",
                    AtomicWeight = 32.065M,
                    GroupNumber = 16,
                    Family = "Null",
                    Metallic = "Nonmetal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 17,
                    Symbol = "Cl",
                    Name = "Chlorine",
                    AtomicWeight = 35.453M,
                    GroupNumber = 17,
                    Family = "Halogens",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 18,
                    Symbol = "Ar",
                    Name = "Argon",
                    AtomicWeight = 39.948M,
                    GroupNumber = 18,
                    Family = "Noble Gasses",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 19,
                    Symbol = "K",
                    Name = "Potassium",
                    AtomicWeight = 39.0983M,
                    GroupNumber = 1,
                    Family = "Alkali Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 20,
                    Symbol = "Ca",
                    Name = "Calcium",
                    AtomicWeight = 40.078M,
                    GroupNumber = 2,
                    Family = "Alkaline Earth Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 21,
                    Symbol = "Sc",
                    Name = "Scandium",
                    AtomicWeight = 44.955912M,
                    GroupNumber = 3,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 22,
                    Symbol = "Ti",
                    Name = "Titanium",
                    AtomicWeight = 47.867M,
                    GroupNumber = 4,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 23,
                    Symbol = "V",
                    Name = "Vanadium",
                    AtomicWeight = 50.9415M,
                    GroupNumber = 5,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 24,
                    Symbol = "Cr",
                    Name = "Chromium",
                    AtomicWeight = 51.9961M,
                    GroupNumber = 6,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 25,
                    Symbol = "Mn",
                    Name = "Manganese",
                    AtomicWeight = 54.938045M,
                    GroupNumber = 7,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 26,
                    Symbol = "Fe",
                    Name = "Iron",
                    AtomicWeight = 55.845M,
                    GroupNumber = 8,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 27,
                    Symbol = "Co",
                    Name = "Cobalt",
                    AtomicWeight = 58.933195M,
                    GroupNumber = 9,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 28,
                    Symbol = "Ni",
                    Name = "Nickel",
                    AtomicWeight = 68.6934M,
                    GroupNumber = 10,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 29,
                    Symbol = "Cu",
                    Name = "Copper",
                    AtomicWeight = 63.546M,
                    GroupNumber = 11,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 30,
                    Symbol = "Zn",
                    Name = "Zinc",
                    AtomicWeight = 65.38M,
                    GroupNumber = 12,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 31,
                    Symbol = "Ga",
                    Name = "Gallium",
                    AtomicWeight = 69.723M,
                    GroupNumber = 13,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 32,
                    Symbol = "Ge",
                    Name = "Germanium",
                    AtomicWeight = 72.64M,
                    GroupNumber = 14,
                    Family = "Poor Metals",
                    Metallic = "Metalloid",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 33,
                    Symbol = "As",
                    Name = "Arsenic",
                    AtomicWeight = 74.92160M,
                    GroupNumber = 15,
                    Family = "Null",
                    Metallic = "Metalloid",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 34,
                    Symbol = "Se",
                    Name = "Selenium",
                    AtomicWeight = 78.96M,
                    GroupNumber = 16,
                    Family = "Null",
                    Metallic = "Nonmetal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 35,
                    Symbol = "Br",
                    Name = "Bromine",
                    AtomicWeight = 79.904M,
                    GroupNumber = 17,
                    Family = "Halogens",
                    Metallic = "Nonmetal",
                    State = "Liquid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 36,
                    Symbol = "Kr",
                    Name = "Krypton",
                    AtomicWeight = 83.798M,
                    GroupNumber = 18,
                    Family = "Noble Gasses",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 37,
                    Symbol = "Rb",
                    Name = "Rubidium",
                    AtomicWeight = 85.4678M,
                    GroupNumber = 1,
                    Family = "Alkali Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 38,
                    Symbol = "Sr",
                    Name = "Strontium",
                    AtomicWeight = 87.62M,
                    GroupNumber = 2,
                    Family = "Alkaline Earth Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 39,
                    Symbol = "Y",
                    Name = "Yttrium",
                    AtomicWeight = 88.90585M,
                    GroupNumber = 3,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 40,
                    Symbol = "Zr",
                    Name = "Zirconium",
                    AtomicWeight = 91.224M,
                    GroupNumber = 4,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 41,
                    Symbol = "Nb",
                    Name = "Niobium",
                    AtomicWeight = 92.90638M,
                    GroupNumber = 5,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 42,
                    Symbol = "Mo",
                    Name = "Molybdenum",
                    AtomicWeight = 95.96M,
                    GroupNumber = 6,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 43,
                    Symbol = "Tc",
                    Name = "Technetium",
                    AtomicWeight = 97.9072M,
                    GroupNumber = 7,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new Element
                {
                    AtomicNumber = 44,
                    Symbol = "Ru",
                    Name = "Ruthenium",
                    AtomicWeight = 101.07M,
                    GroupNumber = 8,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 45,
                    Symbol = "Rh",
                    Name = "Rhodium",
                    AtomicWeight = 102.90550M,
                    GroupNumber = 9,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 46,
                    Symbol = "Pd",
                    Name = "Palladium",
                    AtomicWeight = 106.42M,
                    GroupNumber = 10,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 47,
                    Symbol = "Ag",
                    Name = "Silver",
                    AtomicWeight = 107.8682M,
                    GroupNumber = 11,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 48,
                    Symbol = "Cd",
                    Name = "Cadmium",
                    AtomicWeight = 112.411M,
                    GroupNumber = 12,
                    Family = "Null",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 49,
                    Symbol = "In",
                    Name = "Indium",
                    AtomicWeight = 114.818M,
                    GroupNumber = 13,
                    Family = "Null",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 50,
                    Symbol = "Sn",
                    Name = "Tin",
                    AtomicWeight = 118.710M,
                    GroupNumber = 14,
                    Family = "Null",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 51,
                    Symbol = "Sb",
                    Name = "Antimony",
                    AtomicWeight = 121.760M,
                    GroupNumber = 15,
                    Family = "Null",
                    Metallic = "Metalloid",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 52,
                    Symbol = "Te",
                    Name = "Tellurium",
                    AtomicWeight = 127.60M,
                    GroupNumber = 16,
                    Family = "Null",
                    Metallic = "Nonmetal",
                    State = "Solid",
                    IsStable = true
                },
                new Element
                {
                    AtomicNumber = 53,
                    Symbol = "I",
                    Name = "Iodine",
                    AtomicWeight = 126.90447M,
                    GroupNumber = 17,
                    Family = "Halogens",
                    Metallic = "Nonmetal",
                    State = "Solid",
                    IsStable = true
                },
            };
            //End of data
            return elements;
        }
    }
}
