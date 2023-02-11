namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "comedor";

            bool isHungry = true;

            bool haveMoney = true;

            if(isHungry && haveMoney && IsOpen(nombre, 0))
            {
                Console.WriteLine("Buen provecho");
            }
            else
            {
                Console.WriteLine("No podras comer aqui");
            }

        }

        static bool IsOpen(string name, int hour)
        {
            if(name == "parrilla" && hour > 8 && hour < 22)
            {
                return true;
            }
            else if((name == "comedor" && hour > 8 && hour < 16) || name == "open24")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

