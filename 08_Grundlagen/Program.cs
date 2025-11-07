// See https://aka.ms/new-console-template for more information


using System.Numerics;

bool IsPrim(int number)
{
    if(number < 2)
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

    return true; // Wenn keine dieser Zahlen die Zahl ohne Rest teilt --> Primzahl
}

//geht mit for auch --> for(int factor = 2; factor <= Math.Sqrt(number); factor++)

Console.WriteLine("Bitte eine natürliche positive Zahl eingeben:");
//string input = Console.ReadLine();
//int n = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine()); //Ist Zeile 24 und 25 in einem

bool isP = IsPrim(n);
if (isP)
{
    Console.WriteLine($"{n} is eine Primzahl");
}
else
{
    Console.WriteLine($"{n} ist kein Primzahl");
}
