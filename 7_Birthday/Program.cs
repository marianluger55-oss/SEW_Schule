using System;
using System.Collections.Generic;
using _7_Birthday;

Console.WriteLine("Person demo - Birthday details\n");

var people = new List<Person>
{
    new Person("Max", "Mustermann", new DateTime(1990, 5, 12)),
    new Person("Anna", "Schmidt", new DateTime(2000, 4, 11))
};

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Menu:");
    Console.WriteLine("1) List people");
    Console.WriteLine("2) Add person");
    Console.WriteLine("3) Show person details");
    Console.WriteLine("4) Exit");
    Console.Write("Select option: ");

    var input = Console.ReadLine();
    Console.WriteLine();

    if (input == "1")
    {
        if (people.Count == 0)
        {
            Console.WriteLine("No persons available.");
            continue;
        }

        for (int i = 0; i < people.Count; i++)
        {
            var p = people[i];
            Console.WriteLine($"{i + 1}: {p.FirstName} {p.LastName} ({p.Birthday:yyyy-MM-dd})");
        }
    }
    else if (input == "2")
    {
        Console.Write("First name: ");
        string? first = Console.ReadLine();

        Console.Write("Last name: ");
        string? last = Console.ReadLine();

        DateTime birthday;
        while (true)
        {
            Console.Write("Birthday (yyyy-MM-dd or dd.MM.yyyy): ");
            var bInput = Console.ReadLine()?.Trim() ?? "";

            string[] formats = { "yyyy-MM-dd", "dd.MM.yyyy", "d.M.yyyy", "MM/dd/yyyy" };
            if (DateTime.TryParseExact(bInput, formats, null, System.Globalization.DateTimeStyles.None, out birthday)
                || DateTime.TryParse(bInput, out birthday))
            {
                break;
            }

            Console.WriteLine("Invalid date format. Try again.");
        }

        people.Add(new Person(first, last, birthday));
        Console.WriteLine("Person added.");
    }
    else if (input == "3")
    {
        if (people.Count == 0)
        {
            Console.WriteLine("No persons available.");
            continue;
        }

        Console.Write("Enter person number: ");
        if (!int.TryParse(Console.ReadLine(), out int idx) || idx < 1 || idx > people.Count)
        {
            Console.WriteLine("Invalid selection.");
            continue;
        }

        var person = people[idx - 1];
        Console.WriteLine();
        Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
        Console.WriteLine($"Birthday: {person.Birthday.ToLongDateString()}");
        Console.WriteLine($"Age (years): {person.Age}");
        Console.WriteLine($"Days lived: {person.DaysLived:N0}");
    }
    else if (input == "4" || string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
    else
    {
        Console.WriteLine("Unknown option.");
    }
}

Console.WriteLine("Goodbye.");

