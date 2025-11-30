using System;

class AnimalBirthCalculator
{
    public void PrintBirthDate(DateTime conceptionDate, int gestationDays, string animalName)
    {
        DateTime birthDate = conceptionDate.AddDays(gestationDays);
        Console.WriteLine($"{animalName}: Geburtstermin ist der {birthDate:dd.MM.yyyy}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        AnimalBirthCalculator calculator = new AnimalBirthCalculator();

        // Beispiel 1: Kuh, Tragezeit ca. 283 Tage
        DateTime cowConception = new DateTime(2025, 2, 15);
        calculator.PrintBirthDate(cowConception, 283, "Kuh");

        // Beispiel 2: Katze, Tragezeit ca. 65 Tage
        DateTime catConception = new DateTime(2025, 5, 10);
        calculator.PrintBirthDate(catConception, 65, "Katze");

        // Beispiel 3: Hund, Tragezeit ca. 63 Tage
        DateTime dogConception = new DateTime(2025, 6, 1);
        calculator.PrintBirthDate(dogConception, 63, "Hund");

       
    }
}
