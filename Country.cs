using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedKingdom
{
    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }

        public Country(string name, string capital, int population)
        {
            Name = name;
            Capital = capital;
            Population = population;
        }
    }
}
