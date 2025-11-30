using System;

namespace _09_Christmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gib ein Jahr ein: ");
            string eingabe = Console.ReadLine();
            int jahr;

            if (int.TryParse(eingabe, out jahr))
            {
                Christmas.PrintHolyNightsOnSunday(jahr, jahr);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
            }
        }
    }
}