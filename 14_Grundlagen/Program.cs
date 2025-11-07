using System.Globalization;

double[] numbers = new double[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Bitte eine Zahl eingeben:");
    numbers[i] = double.Parse(Console.ReadLine());
}

Console.Write("[");

for (int i = 0; i < 9; i++)
{
    Console.Write($"{numbers[i]};");
}
Console.Write(numbers[9]);
Console.Write("]");

Console.WriteLine(" ");


for (int i = 0; i < numbers.Length / 2; i++)
{
    double space = numbers[i];
    numbers[i] = numbers[numbers.Length - 1 - i];                   
    numbers[numbers.Length - 1 - i] = space;                  
                                   
}
Console.Write("[");
for (int i = 0; i < 9; i++)
{
    Console.Write($"{numbers[i]};");
}
Console.Write(numbers[9]);
Console.Write("]");