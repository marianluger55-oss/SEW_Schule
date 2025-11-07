//int array[5];   // C

int[] array = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Bitte eine natürliche Zahl eingeben: ");
    array[i] = int.Parse(Console.ReadLine());
}

foreach(int elem in array)      // bei jedem Schleifendurchlauf wird der Variable elem der Wert des Elements im Array zugewiesen
{
    Console.WriteLine(elem);
}

Array.Sort(array);
Console.WriteLine("---------------");

foreach (int elem in array)      // bei jedem Schleifendurchlauf wird der Variable elem der Wert des Elements im Array zugewiesen
{
    Console.WriteLine(elem);
}

Console.WriteLine($"Min:{ array.Min()}");
Console.WriteLine($"Max:{array.Max()}");
Console.WriteLine($"Mittelwert: {array.Sum() / array.Length}");         // oder Average