using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedKingdom
{
    public class CountryInformationService
    {
        private readonly Country _country;
        private readonly IDisplay _display;

        public CountryInformationService(Country country, IDisplay display)
        {
            _country = country;
            _display = display;
        }

        public void DisplayCountryInformation()
        {
            _display.Show($"Country: {_country.Name}");
            _display.Show($"Capital: {_country.Capital}");
            _display.Show($"Population: {_country.Population}");
        }
    }
}
