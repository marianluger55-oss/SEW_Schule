
string name = "John"; //Referenztyp ohne ? -> diese Variable darf niemals null sein.
Console.Write(name);
Console.WriteLine("Bitte deinen Nachnamen eingeben:");
string? lastName = Console.ReadLine(); //Referenztyp mit ? -> diese Variabel kan auch null sein.