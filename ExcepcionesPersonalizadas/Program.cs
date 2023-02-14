namespace ExcepcionesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Beer beer = new Beer()
                {
                    Name = "Stout",
                    //Brand = "Quilmes"
                };

                Console.WriteLine(beer);
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public class MyException : Exception
        {
            public MyException() : base("Ingresar Nombre y Marca por favor...")
            {

            }
        }
        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }

            public override string ToString()
            {
                if (Name == null || Brand == null)
                    throw new MyException();
                return $"Name: {Name}, Marca: {Brand}";
            }
        }
    }
}