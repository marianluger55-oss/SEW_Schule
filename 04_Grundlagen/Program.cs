

Console.Write("Bitte eine Zahl eingeben: ");
string number01 = Console.ReadLine();

Console.Write("Bitte eine Zahl eingeben: ");
string number02 = Console.ReadLine();

Console.Write("Bitte eine Zahl eingeben: ");
string number03 = Console.ReadLine();

int number1 = int.Parse(number01);
int number2 = int.Parse(number02);
int number3 = int.Parse(number03);

int max = number1;
int min = number1;

if (number2 > number1)
{
    max = number2;
    
}
else
{
    min = number2;
}

if (number3 > max)
{
    max = number3;
    
} else if (number3 < min)
{
    min = number3;
}

Console.WriteLine("Die größte Zahl ist: "+max);
Console.WriteLine("Die kleinste Zahl ist: "+min);

