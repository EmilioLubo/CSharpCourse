namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numeros = new MyList<int>(5);
            numeros.Add(2);
            numeros.Add(8);
            numeros.Add(7);
            numeros.Add(1);
            Console.WriteLine(numeros.GetString());
            Console.WriteLine(numeros.GetElement(4));

            MyList<string> cadenas = new MyList<string>(5);
            cadenas.Add("Flavio");
            cadenas.Add("Carla");
            cadenas.Add("Pedrito");
            Console.WriteLine(cadenas.GetString());
            Console.WriteLine(cadenas.GetElement(4));

            MyList<People> peoples = new MyList<People>(5);
            peoples.Add(new People()
            {
                Name = "Juan",
                Country = "España",
            });
            peoples.Add(new People()
            {
                Name = "Renata",
                Country = "Italia"
            });
            Console.WriteLine(peoples.GetString());
            Console.WriteLine(peoples.GetElement(4));
        }
        public class People
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public override string ToString()
            {
                return $"Nombre: {Name}, País: {Country}.";
            }
        }
        public class MyList<T>
        {
            private T[] _elements;
            private int _index = 0;
            public MyList(int n)
            {
                _elements = new T[n];
            }
            public void Add(T item)
            {
                if(_index < _elements.Length)
                {
                    _elements[_index] = item;
                    _index++;
                }
            }
            public T GetElement(int i)
            {
                if(i <= _index && i >= 0)
                {
                    return _elements[i];
                }
                return default(T);
            }
            public string GetString()
            {
                int i = 0;
                string result = "";
                while(i < _index)
                {
                    result += _elements[i].ToString() + " | ";
                    i++;
                }
                return result;
            }
        }
    }
}