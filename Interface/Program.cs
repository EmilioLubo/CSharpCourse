namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Shark[] sharks = new Shark[]
            {
                new Shark("Mandibulín", 130),
                new Shark("Billie", 80)
            };
            IFish[] swimmers = new IFish[]
            {
                new Siren(50),
                new Shark("Joaquin", 115)
            };
            ShowAnimals(sharks);
            ShowFishes(sharks);
            ShowFishes(swimmers);
        }
        public class Shark : IAnimal, IFish
        {
            public string Name { get; set; }
            public int Speed { get; set; }
            public Shark(string name, int speed)
            {
                Name = name;
                Speed = speed;
            }

            public string Swim()
            {
                return $"{Name} nada a {Speed} km/h.";
            }
        }
        public static void ShowAnimals(IAnimal[] animals)
        {
            Console.WriteLine("--Listado de Animales--");
            int i = 0;
            while(i < animals.Length)
            {
                Console.WriteLine(animals[i].Name);
                i++;
            }
        }
        public static void ShowFishes(IFish[] fishes)
        {
            Console.WriteLine("--Listado de Peces--");
            int i = 0;
            while(fishes.Length > i)
            {
                Console.WriteLine(fishes[i].Swim());
                i++;
            }
        }
        public class Siren : IFish
        {
            public int Speed { get; set; }
            public Siren(int speed)
            {
                Speed = speed;
            }

            public string Swim()
            {
                return $"La sirena nada a {Speed} km/h";
            }
        }
        public interface IAnimal
        {
            public string Name { get; set; }
        }
        public interface IFish
        {
            public int Speed { get; set; }
            public string Swim();
        }
    }
}