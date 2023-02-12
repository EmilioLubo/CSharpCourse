using System.Text.Json;
namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer myBeer = new Beer()
            {
                Name = "Stout",
                Brand = "Quilmes"
            };
            //string json = "{\"Name\": \"Stout\", \"Brand\": \"Quilmes\"}";

            string json = JsonSerializer.Serialize(myBeer);
            Beer beer = JsonSerializer.Deserialize<Beer>(json);

            Beer[] beers = new Beer[]
            {
                myBeer,
                new Beer()
                {
                    Name = "Kune",
                    Brand = "Patagonia"
                }
            };
            /*string jsonArray = "[" +
                "{\"Name\": \"Stout\", \"Brand\": \"Quilmes\"}," +
                "{\"Name\": \"Kune\", \"Brand\": \"Patagonia\"}," +
                "]";*/
            string json2 = JsonSerializer.Serialize(beers);
            Beer[] beers2 = JsonSerializer.Deserialize<Beer[]>(json2);

        }
        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }
        }
    }
}