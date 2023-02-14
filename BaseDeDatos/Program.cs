using System.Data.SqlClient;
namespace BaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BeerDB db = new BeerDB("DESKTOP-FQOBUCM","CSharpDB", "sa", "123456");
                bool again = true;
                int op = 0;

                do
                {
                    ShowMenu();
                    Console.WriteLine("Elija una opción: ");
                    op = int.Parse(Console.ReadLine());

                    switch(op)
                    {
                        case 1:
                            Show(db);
                            break;
                        case 2:
                            Add(db);
                            break;
                        case 3:
                            Edit(db);
                            break;
                        case 4:
                            Delete(db);
                            break;
                        case 5:
                            again = false;
                            break;
                    }
                } while (again);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void ShowMenu()
        {
            Console.WriteLine("\n----------Menu----------");
            Console.WriteLine("1-Mostrar");
            Console.WriteLine("2-Agregar");
            Console.WriteLine("3-Editar");
            Console.WriteLine("4-Eliminar");
            Console.WriteLine("5-Salir");
        }
        public static void Show(BeerDB db)
        {
            Console.Clear();
            Console.WriteLine("Cervezas de la base de datos: ");
            List<Beer> beers = db.GetAll();
            foreach (Beer beer in beers)
            {
                Console.WriteLine($"ID: {beer.Id}, Name: {beer.Name}");
            }
        }

        public static void Add(BeerDB db)
        {
            Console.Clear();
            Console.WriteLine("Agregar nueva cerveza");
            Console.WriteLine("Escribe el nombre:");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el id de la Marca:");
            int brandId = int.Parse(Console.ReadLine());
            Beer beer = new Beer(name, brandId);
            db.Add(beer);
        }

        public static void Edit(BeerDB db)
        {
            Console.Clear();
            Show(db);
            Console.WriteLine("Editar cerveza");
            Console.WriteLine("Escribe el Id de la cervea a editar:");
            int id = int.Parse(Console.ReadLine());
            Beer beer = db.Get(id);
            if(beer != null)
            {
                Console.WriteLine("Escribe el nombre:");
                string name = Console.ReadLine();
                Console.WriteLine("Ingresa el id de la marca:");
                int brandId = int.Parse(Console.ReadLine());

                beer.Name = name;
                beer.BrandId = brandId;
                db.Edit(beer);
            }
            else
            {
                Console.WriteLine("No se ha encontrado una cerveza con el Id ingresado.");
            }
        }

        public static void Delete(BeerDB db)
        {
            Console.Clear();
            Show(db);
            Console.WriteLine("Eliminar cerveza");
            Console.WriteLine("Escribe el Id de la cervea a eliminar:");
            int id = int.Parse(Console.ReadLine());

            Beer beer = db.Get(id);
            if (beer != null)
            {
                db.Delete(id);
            }
            else
            {
                Console.WriteLine("No se ha encontrado una cerveza con el Id ingresado.");
            }
        }
    }
}