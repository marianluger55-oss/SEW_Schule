
Console.WriteLine("Bitte eine Zahl eingeben: ");
string number1 = Console.ReadLine();
int number = int.Parse(number1);

if(number % 3 == 0)
{
    Console.WriteLine("Diese Zahl ist durch 3 ohne Rest teilbar");
} else
{
    Console.WriteLine("Diese Zahlt ist nicht durch 3 ohne Rest teilbar");
}

if (number % 5 == 0)
{
    Console.WriteLine("Diese Zahl ist durch 5 ohne Rest teilbar");
} else
{
    Console.WriteLine("Diese Zahl ist nicht durch 5 ohne Rest teilbar");
}
