using System;

class Christmas
{
    // Methode: Prüft, welche Heiligen Abende auf einen Sonntag fallen
    public void PrintHolyNightsOnSunday(int startYear, int endYear)
    {
        Console.WriteLine($"Heilige Abende an einem Sonntag von {startYear} bis {endYear}:");
        for (int year = startYear; year <= endYear; year++)
        {
            DateTime christmasEve = new DateTime(year, 12, 24);

            if (christmasEve.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine(year);
            }
        }
    }
}
