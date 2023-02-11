namespace ClasesYObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet perro = new Pet("Tobi", 4, DateTime.Now);
            Pet gato = new Pet("Michi", 8, DateTime.Now);

            perro.Alimentarse();
            string message = gato.ShowData();
            Console.WriteLine(message);
            Console.WriteLine(perro.ShowData());

        }

        class Pet
        {
            string nombre;
            int edad;
            DateTime date;

            public Pet(string nombre, int edad, DateTime date)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.date = date;
            }

            public void Alimentarse()
            {
                Console.WriteLine("...comiendo...");
            }

            public string ShowData()
            {
                return "Nombre: " + nombre + ". Edad: " + edad + ". Fecha de ingreso: " + date.ToShortDateString();
            }
        }

    }
}