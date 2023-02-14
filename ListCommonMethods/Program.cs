namespace ListCommonMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                3,6,7,2,3
            };
            Show(numbers);

            numbers.Insert(0, 1);
            Show(numbers);

            if (numbers.Contains(7))
                Console.WriteLine("existe");
            else Console.WriteLine("no existe");

            int pos = numbers.IndexOf(7);
            Console.WriteLine(pos);
            pos = numbers.IndexOf(67);
            Console.WriteLine(pos);

            numbers.Sort();
            Show(numbers);

            numbers.AddRange(new List<int>() 
            {
                45,46,78,23,25
            });
            Show(numbers);
        }

        public static void Show(List<int> numberList)
        {
            Console.WriteLine("--Numeros--");
            foreach(var n in numberList)
            {
                Console.WriteLine(n);
            }
        }
    }
}