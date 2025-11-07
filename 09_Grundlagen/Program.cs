// See https://aka.ms/new-console-template for more information
Console.WriteLine("Das kleine Einmaleins");
Console.WriteLine("=====================");

for (int i = 1; i < 11; i++)
{
    for (int j = 1; j < 11; j++)
    {
        if (j*i < 10)
        {
            Console.Write(j * i + "  ");
        } else
        {
            Console.Write(j * i+ " ");
        }
        
    }
    Console.WriteLine();
} 