Operation mySum = Functions.Sum;
//Console.WriteLine(mySum(1, 2));

mySum = Functions.Mul;
//Console.WriteLine(mySum(2, 3));

Show cw = Console.WriteLine;
cw += Functions.ConsoleShow;
//cw("Hola mundo");

//Functions.Some("Juan", "Perez", cw);

#region Action

Action<string> showMessage = Console.WriteLine;
Action<string, string> showMessage1 = (a, b) =>
{
    Console.WriteLine($"{a} {b}.");
    Console.WriteLine("Adios2.");
};
Action<string, string, string> showMessage2 = (a, b, c) => Console.WriteLine($"{a} {b} {c}.");
//showMessage1("Oscar", "Almiron");
//showMessage2("otro", "user", "mas");
//Functions.SomeAction("Carlos", "Gomez", (a) => Console.WriteLine("lambda " + a));
//showMessage("Hola");
//Functions.SomeAction("Hola", "Pepe", showMessage);
#endregion

#region Func

Func<int> randomN = () => new Random().Next(0, 100);
Func<int, int> randomLimit = (limit) => new Random().Next(0, limit);

//Console.WriteLine(randomLimit(5));
//Console.WriteLine(randomN());

#endregion

#region Predicate

Predicate<string> hasSpaceAndI = (word) => word.Contains(" ") && word.ToUpper().Contains("I");

Console.WriteLine(hasSpaceAndI("hola pepe"));

var words = new List<string>()
{
    "Carlos",
    "Lolo",
    "Juan Pedro",
    "María Isabel",
    "Toto"
};
var selectedWords = words.FindAll((w) => !hasSpaceAndI(w));
foreach(var w in selectedWords) Console.WriteLine(w);
#endregion

#region Delegados
delegate int Operation(int n1, int n2);
public delegate void Show(string message);

#endregion

public class Functions
{
    public static int Sum(int n1, int n2) => n1 + n2;
    public static int Mul(int n1, int n2) => (n1 * n2);
    public static void ConsoleShow(string m) => Console.WriteLine(m.ToUpper());
    public static void Some(string name, string lName, Show fn)
    {
        Console.WriteLine("Presentamos a:");
        fn($"{name} {lName}");
        Console.WriteLine("Adios");
    }

    public static void SomeAction(string name, string lName, Action<string> fn)
    {
        Console.WriteLine("Presentamos a:");
        fn($"{name} {lName}");
        Console.WriteLine("Adios");
    }
}