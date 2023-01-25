using System.Diagnostics.Metrics;
using UnitedKingdom;

internal class Program
{
    public static void Main(string[] args)
    {
        var country = new Country("United Kingdom", "London", 65_110_000);
        var display = new ConsoleDisplay();
        var infoService = new CountryInformationService(country, display);
        infoService.DisplayCountryInformation();
    }
}