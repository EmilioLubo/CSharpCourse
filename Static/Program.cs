namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(People.Count);

            People peter = new People()
            {
                Name = "Peter",
                Age = 38
            };

            Console.WriteLine(People.GetCount());

            People john = new People()
            {
                Name = "John",
                Age = 19
            };

            Console.WriteLine(People.GetCount());

            A.Some();
        }

        public static class A
        {
            public static void Some() 
            {
                Console.WriteLine("Something...");
            }
        }

        public class People
        {
            public static int Count = 0;
            public string Name { get; set; }
            public int Age { get; set; }

            public People()
            {
                Count++;
            }

            public static string GetCount()
            {
                return $"Hay {Count} personas anotadas";
            }
        }
    }
}