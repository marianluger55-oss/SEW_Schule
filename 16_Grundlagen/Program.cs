Console.WriteLine("Bitte einen Text eingeben:");
string text = Console.ReadLine();

for (int i = 0; i < text.Length; i++)
{
    char c = text[i];
    Console.Write($"{c} ");
}

// 2. Variante
Console.WriteLine();

foreach (char c in text)
{
    Console.Write($"{c} ");
}

