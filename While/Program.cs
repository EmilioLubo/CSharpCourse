int n = 0;

while(n < 10)
{
    if (n == 7)
        break;
    Console.WriteLine(n);
    n++;
}

int index = 0;

string[] pets = new string[5]
{
    "Tobi",
    "Firulais",
    "Snowball",
    null,
    "Toto"

};

while (index < pets.Length)
{
    Console.WriteLine(pets[index]);
    index++;
}

bool haIngresado = false;

do
{
    Show();
} while (haIngresado);

static void Show()
{
    Console.WriteLine("Ingreso una vez");
}