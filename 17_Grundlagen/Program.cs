Console.Write("Gib eine Binärzahl ein: ");
string binaer = Console.ReadLine();

int dezimal = Convert.ToInt32(binaer, 2);
Console.WriteLine("Dezimal: " + dezimal);