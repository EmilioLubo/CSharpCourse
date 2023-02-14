using System.Linq;
namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Beer> beers = new List<Beer>()
            {
                new Beer(){Name = "Kune", Brand = "Patagonia"},
                new Beer(){Name = "Cristal", Brand = "Quilmes"},
                new Beer(){Name = "Noir", Brand = "Stella Artois"}
            };
            foreach (Beer beer in beers)
                Console.WriteLine(beer);

            Console.WriteLine("---------");

            var beersNameAndLetters = from myBeers in beers
                                      select new
                                      {
                                          Name = myBeers.Name + " " + myBeers.Brand,
                                          Letters = myBeers.Name.Length
                                      };
            foreach (var b in beersNameAndLetters) Console.WriteLine(b);

            var beerNames = from myBeers in beersNameAndLetters
                            select new
                            {
                                Name = myBeers.Name
                            };
            foreach (var b in beerNames) Console.WriteLine(b);

            Console.WriteLine("------------");

            var quilmes = from myBeers in beers
                          where myBeers.Brand == "Quilmes"
                          || myBeers.Brand == "Patagonia"
                          select myBeers;
            foreach (var b in quilmes) Console.WriteLine(b);

            Console.WriteLine("-------");

            var orderedBeers = from myBeers in beers
                               orderby myBeers.Name descending
                               select myBeers;
            foreach(var b in orderedBeers) Console.WriteLine(b);
        }
    }
    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            return $"{Name} de {Brand}";
        }
    }
}