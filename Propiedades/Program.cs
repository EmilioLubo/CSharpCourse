namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet perro = new Pet("Tobi", 4, DateTime.Now);
            Pet gato = new Pet("Michi", 8, DateTime.Now);

            perro.Edad = 1000;
            gato.Nombre = "Pepe";
            gato.Date = "08/09/1995";

            string nombreGato = gato.Nombre;
            Console.WriteLine(nombreGato);
            Console.WriteLine(perro.Edad);
            Console.WriteLine(gato.Date);

        }

        class Pet
        {
            private string nombre;
            private int edad;
            private DateTime date;

            public Pet(string nombre, int edad, DateTime date)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.date = date;
            }

            public string Nombre
            {
                get => nombre;

                set
                {
                    if (value.Length > 1)
                        nombre = value;
                    else
                        Console.WriteLine("El nombre debe tener más de una letra.");
                }
            }

            public int Edad
            {
                get => edad;

                set
                {
                    if (value < 1)
                        value = 1;
                    edad = value;
                }
            }

            public string Date
            {
                get => date.ToLongDateString();

                set => date = DateTime.Parse(value);
            }


        }

    }
}