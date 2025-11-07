int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Bitte eine Zahl eingeben:");
    numbers[i] = int.Parse(Console.ReadLine());
}

int numbers1 = numbers.Min();
if (numbers1 <= 0)
{

    Console.Write($"Minimum: {numbers.Min()},");
}
else
{
    Console.Write("Minimum: 0,");
}

int numbers2 = numbers.Max();
if (numbers2 >= 0)
{
    Console.Write($" Maximum: {numbers.Max()}");
}
else
{
    Console.Write(" Maximum: 0");
}
