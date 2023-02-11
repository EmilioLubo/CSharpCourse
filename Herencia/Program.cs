using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro("Tobi", 4, DateTime.Now, true);
            Pez pez = new Pez("Dorado", 8, DateTime.Now, "grande");

            Console.WriteLine(perro.GetData());
            Console.WriteLine(perro.GetInfo());
            Console.WriteLine(pez.GetData());

        }

        class Pet
        {
            private string _nombre;
            private int _edad;
            private DateTime _date;

            public Pet(string nombre, int edad, DateTime date)
            {
                _nombre = nombre;
                _edad = edad;
                _date = date;
            }
            public string GetInfo()
            {
                return "Nombre: " + _nombre + ". Edad: " + _edad + ". Fecha de ingreso: " + _date.ToShortDateString();
            }
        }

        class Perro : Pet
        {
            private bool _pasea;

            public Perro(string nombre, int edad, DateTime date, bool pasea) : base(nombre, edad, date)
            {
                _pasea = pasea;
            }

            public string GetData()
            {
                return GetInfo() + ". ¿Pasea?: " + _pasea;
            }
        }

        class Pez : Pet
        {
            private string _tamanio;

            public Pez(string nombre, int edad, DateTime date, string tamanio) : base(nombre, edad, date)
            {
                _tamanio = tamanio;
            }

            public string GetData()
            {
                return GetInfo() + ". Tamaño: " + _tamanio;
            }

        }

    }
}