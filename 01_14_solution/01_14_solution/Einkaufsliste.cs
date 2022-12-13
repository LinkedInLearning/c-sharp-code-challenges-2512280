using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_14_solution
{
    internal class Einkaufsliste
    {
        List<String> meineEinkaufsliste = new List<String>();

        public List<string> MeineEinkaufsliste { get => meineEinkaufsliste; set => meineEinkaufsliste = value; }
    }
}
