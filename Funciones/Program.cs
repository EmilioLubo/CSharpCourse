using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Saludar();

            Sumar(20, 33);

            string nombre = Concat("Pedro", "Alonso");

            Console.WriteLine(nombre);
        }

        static void Saludar()
        {
            Console.WriteLine("Buen dia");
        }

        static void Sumar(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }

        static string Concat(string nombre, string apellido)
        {
            return nombre + " " + apellido;
        }
    }
}