using _09_StopWatch;
using System.Diagnostics;
using System.Timers;




Console.WriteLine("Bitte eine taste drücken.");

Console.ReadKey();
StopWatch keyOne = new StopWatch();



while (Console.KeyAvailable)

{

    Console.ReadKey(true);

    //oder

    Console.WriteLine("Ungültig. ): ");

    return;

}

Console.Clear();

Console.WriteLine("Bitte noch eine Taste drücken.");

Console.ReadKey();

double elapsed = keyOne.ElapsedSec(); 

Console.WriteLine($"Zeit: {elapsed}s");






