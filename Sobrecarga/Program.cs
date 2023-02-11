namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
        }

        class Math
        {
            public int Sum(int n1, int n2)
            {
                return n1 + n2;
            }

            public int Sum(string n1, string n2)
            {
                return int.Parse(n1) + int.Parse(n2);
            }

            public int Sum(int[] numeros)
            {

            }
        }

    }
}