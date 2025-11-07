// See https://aka.ms/new-console-template for more information

bool IsPrim(int number)
{
    if (number < 2)
    {
        return false;
    }

    int factor = 2;
    while (factor <= Math.Sqrt(number))
    {
        if (number % factor == 0)
        {
            return false;
        }
        factor++;
    }

    return true;
}

Console.WriteLine("Bitte eine positive Zahl eingeben");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i <= n; i++)
{
    bool result = IsPrim(i);
    if(IsPrim(i) == true)
    {
        Console.WriteLine($"{i} ist eine Primzahl");
    }
}