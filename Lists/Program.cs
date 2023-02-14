namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.Add(7);
            numeros.Add(5);
            numeros.Add(3);
            Console.WriteLine(numeros.Count);

            List<int> numeros2 = new List<int>()
            {
                3,15,45,23
            };
            Console.WriteLine(numeros2.Count);
            numeros2.Add(5);
            Console.WriteLine(numeros2.Count);
            numeros2.Clear();
            Console.WriteLine(numeros2.Count);

            List<string> paises = new List<string>()
            {
                "Canadá","Peru","Nueva Zelanda","Etiopia"
            };
            Console.WriteLine(paises.Count);
        }
    }
}