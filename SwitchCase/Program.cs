// See https://aka.ms/new-console-template for more information
int n = 70;

switch(n)
{
    case 1:
        Console.WriteLine("Elegiste 1");
        break;
    case 2:
        Console.WriteLine("Elegiste 2");
        break;
    case < 0 or > 100:
        Console.WriteLine("Fuera de rango");
        break;
    case > 50 and < 100:
        Console.WriteLine("Entre 50 y 100");
        break;
    default:
        Console.WriteLine("Entre 0 y 50");
        break;

}

