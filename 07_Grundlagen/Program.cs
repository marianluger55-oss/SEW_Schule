// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bitte eine Zahl eingeben:");
string number1 = Console.ReadLine();
double number = double.Parse(number1);

double squareRoot = Math.Sqrt(number);

for (int i = 2; i < squareRoot; i++)
{
    if (number % i == 0) {
        Console.WriteLine("Diese Zahl ist keine Primzahl");
        return;
    } 
    
}

Console.WriteLine("Diese Zahl ist eine Primzahl");
