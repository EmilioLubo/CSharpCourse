using System.Security.Cryptography.X509Certificates;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            (int id, string name) producto = (1, "Quilmes");
            Console.WriteLine($"{producto.id} {producto.name}");
            producto.name = "Patagonia";
            Console.WriteLine($"{producto.id} {producto.name}");

            var integrante = (1, "Carlos");
            Console.WriteLine($"{integrante.Item1} {integrante.Item2}");

            var equipo = new[]
            {
                (1, "Rosa"),
                (2, "Diego"),
                (3, "Juana")
            };
            foreach(var p in equipo)
            {
                Console.WriteLine($"{p.Item1} {p.Item2}");
            }

            (int id, string name)[] equipo2 = new[]
            {
                (1, "Rosa"),
                (2, "Diego"),
                (3, "Juana")
            };
            foreach (var p in equipo2)
            {
                Console.WriteLine($"{p.id} {p.name}");
            }

            var locationInfo = GetLocation();
            Console.WriteLine($"Lat: {locationInfo.lat}, Lng: {locationInfo.lng}, name: {locationInfo.name}");
            var (_,lng,_) = GetLocation();
            Console.WriteLine(lng);

        }
        public static (float lat, float lng, string name) GetLocation()
        {
            float lat = 10.1234f;
            float lng = -78.2342f;
            string name = "somewhere";

            return (lat, lng, name);
        }
    }
}