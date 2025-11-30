using System;
using _24_Fraction;

class Program
{
    static void Main()
    {
        Fraction f1 = new Fraction(34, 100);  // wird zu 17/50
        Fraction f2 = new Fraction(10, 8);    // wird zu 5/4
        Fraction f3 = new Fraction(1, 24);    // bleibt 1/24

        Console.WriteLine($"{f1.GetFraction()} = {f1.GetValue()}");
        Console.WriteLine($"{f2.GetFraction()} = {f2.GetValue()}");
        Console.WriteLine($"{f3.GetFraction()} = {f3.GetValue()}");

        // Zähler ändern
        f2.Nominator = 6; // von 5/4 zu 3/2
        Console.WriteLine($"{f2.GetFraction()} = {f2.GetValue()}");

        // Nenner ändern
        f1.DeNominator = 25; // von 17/50 zu 17/25
        Console.WriteLine($"{f1.GetFraction()} = {f1.GetValue()}");

        Fraction result = f2.Add(f3); //this = f2 other = f3 
        Console.WriteLine($"{result.GetFraction()}");

        Fraction result = f2.Multiply(f3);
        Console.WriteLine($"{result.GetFraction()}");

        Fraction result = f2.Sub(f3);
        Console.WriteLine($"{result.GetFraction}");

        Fraction result = f2.Divide(f3);
        Console.WriteLine($"{result.GetFraction}"); 

    }
}



//Eine Methode mit dem Namen Shorten (Kürzen) 
//eine private Methode mit dem Namen Gcd(ggt) - Greates common divisor
//Internetrecherche zum euklischen Algorithmus 
//Verstehen wie der euklidische Algorithmus funktioniert (händisch einige Beispiele berechnen)

// Implementiere die Methoden 

// - Multiply 
// - Subtrat 
// - Divide 






