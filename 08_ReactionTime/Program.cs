
Console.WriteLine("Bitte eine Taste drücken.");

//Benutzer eine Taste drücken lassen
Console.ReadKey();
DateTime timeKey1 = DateTime.Now;

Random random = new Random();
int delay = random.Next(1, 5000);
Thread.Sleep(delay);
while (Console.KeyAvailable) { 
    Console.ReadKey(true);
}

Console.WriteLine("Bitte noch eine Taste drücken.");
Console.ReadKey();
DateTime timeKey2 = DateTime.Now;

Console.WriteLine($"Reaktionszeit: {(timeKey2 - timeKey1).TotalMilliseconds} ms");

