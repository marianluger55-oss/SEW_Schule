int[] numbers = new int[5];

Console.WriteLine("Bitte ein druckbares Zeichen eingeben:");
string text = Console.ReadLine();


for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Bitte eine Zahl eingeben:");
    numbers[i] = int.Parse(Console.ReadLine());
}

int max = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

for (int j = max; j > 0; j--)
{
    for (int a = 0; a < numbers.Length; a++)
    {
        if (numbers[a] >= j)
        {
            Console.Write(text);
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}

