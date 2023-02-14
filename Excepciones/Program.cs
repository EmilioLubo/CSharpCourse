using System.IO;
namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            string content = File.ReadAllText(@"C:\\Users\\Usuario\\OneDrive\\Documentos\\csharpexample.txt");
            Console.WriteLine(content);
            //string content2 = File.ReadAllText(@"C:\\Users\\Usuario\\OneDrive\\Documentos\\csharpexample2.txt");
            //Console.WriteLine(content2);
            throw new Exception("Ocurrio algo raro");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("El archivo no existe. \n" + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Fin");
            }
        }
    }
}