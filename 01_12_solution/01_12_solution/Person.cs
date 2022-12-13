using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_12_solution
{
    internal class Person
    {
        string nname;
        string vname;
        int kdNr;

        public Person(string nname, string vname, int kdNr)
        {
            Nname = nname;
            Vname = vname;
            KdNr = kdNr;
        }

        public string Nname { get; set; }
        public string Vname { get; set; }
        public int KdNr { get; set; }
    }
}
