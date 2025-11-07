Console.WriteLine("Gib den ersten Text ein:");
string text1 = Console.ReadLine();

Console.WriteLine("Gib den zweiten Text ein:");
string text2 = Console.ReadLine();

int equal = 0;
int minLaenge = Math.Min(text1.Length, text2.Length);

for (int i = 0; i < minLaenge; i++)
{
    if (text1[i] == text2[i])
    {
        equal++;
    } else
    {
        break;
    }
   
}

Console.WriteLine($"Es sind {equal} Buchstaben von Beginn an gleich");