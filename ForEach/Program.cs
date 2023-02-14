namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>()
            {
                3,35,83,97,31,73,25
            };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            var personas = new List<People>()
            {
                new People() {Name = "Dario", Country = "Uruguay"},
                new People() {Name = "Maria", Country = "Guatemala"},
                new People() {Name = "Daniela", Country = "Brasil"},
                new People() {Name = "Elio", Country = "Ecuador"},
            };
            ShowPeople(personas);
            personas.RemoveAt(0);
            ShowPeople(personas);
        }
        static void ShowPeople(List<People> people)
        {
            Console.WriteLine("--Listado de personas--");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} es de {person.Country}");
            }
        }
    }
    class People
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}