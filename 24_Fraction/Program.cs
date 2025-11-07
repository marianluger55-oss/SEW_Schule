using _24_Fraction;



Fraction test1 = new Fraction(3, 5);
Fraction test2 = new Fraction(34, 100);
Fraction test3 = new Fraction(1, 24); 

Console.WriteLine($"{test1.GetFraction()}: {test1.GetValue()}");

test1.Nominator = 6; //setter 
Console.WriteLine($"{test1.GetFraction()}: {test1.GetValue()}");


//Eine Methode mit dem Namen Shorten (Kürzen) 
//eine private Methode mit dem Namen Gcd(ggt) - Greates common divisor
//Internetrecherche zum euklischen Algorithmus 
//Verstehen wie der euklidische Algorithmus funktioniert (händisch einige Beispiele berechnen)

