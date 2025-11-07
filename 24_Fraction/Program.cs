using System;
using _24_Fraction;

class Program
{
    static void Main(string[] args)
    {
        Fraction test1 = new Fraction(34, 100);
        Fraction test2 = new Fraction(6, 8);

        Console.WriteLine($"{test1.GetFraction()} = {test1.GetValue()}");
        Console.WriteLine($"{test2.GetFraction()} = {test2.GetValue()}");

        test2.Nominator = 10; // Setter testen
        Console.WriteLine($"{test2.GetFraction()} = {test2.GetValue()}");
    }
}



//Eine Methode mit dem Namen Shorten (Kürzen) 
//eine private Methode mit dem Namen Gcd(ggt) - Greates common divisor
//Internetrecherche zum euklischen Algorithmus 
//Verstehen wie der euklidische Algorithmus funktioniert (händisch einige Beispiele berechnen)





