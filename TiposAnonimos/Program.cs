namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            var emi = new
            {
                Name = "Emilio",
                Country = "Argentina"
            };
            Console.WriteLine($"{emi.Name} es de {emi.Country}");

            var people = new[]
            {
                new{ Name = "Juan", Apellido = "Perez" },
                new{ Name = "Ana", Apellido = "Gomez"}
            };
            foreach( var person in people )
            {
                Console.WriteLine( person.Name + " " + person.Apellido );
            }
        }
    }

}