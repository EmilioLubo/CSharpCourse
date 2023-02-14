using System.Linq;
namespace LINQ_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            var beers = new List<Beer>()
            {
                new Beer() {Name = "Quilmes", Country = "Argentina"},
                new Beer() {Name = "Brahma", Country = "Brasil"},
                new Beer() {Name = "Grolsch", Country = "Alemania"}

            };
            var countries = new List<Country>()
            {
                new Country(){Name = "Brasil", Continent = "America"},
                new Country(){Name = "Argentina", Continent = "America"},
                new Country(){Name = "Alemania", Continent = "Europa"}
            };

            var beersContinent = from b in beers
                                 join c in countries
                                 on b.Country equals c.Name
                                 select new
                                 {
                                     Name = b.Name,
                                     Country = b.Country,
                                     Continent = c.Continent
                                 };
            foreach(var beer in beersContinent)
            {
                Console.WriteLine($"{beer.Name} del país {beer.Country} de {beer.Continent}");
            }
        }
    }
    public class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
    }
    public class Beer
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}