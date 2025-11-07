using _3_OOP_Farm;

Farmer paul = new Farmer("Paul", "Farmer", 67);
Dog pluto = new Dog("Pluto");
paul.SetDog(pluto);
string info = paul.GetInfo();
Console.WriteLine(info);

Farmer georg = new Farmer("Georg", "Farmer", 69);
Console.WriteLine(georg.GetInfo());

Farmer jochen = new Farmer("Jochen", "Farmer", 88);
Dog hermann = new Dog("Hermann");
jochen.SetDog(hermann);
Console.WriteLine(jochen.GetInfo());

Cow luisa = new Cow("Luisa", "Fleckvieh", 620);
jochen.AddCow(luisa);

Cow berta = new Cow("Berta", "Braunvieh", 670);
jochen.AddCow(berta);

Cow emma = new Cow("Emma", "Angus", 690);
jochen.AddCow(emma);

Cow maria = new Cow("Maria", "Grauvieh", 642);
jochen.AddCow(maria);

Cow böcki = new Cow("Böcki", "Pinzgauer", 567);
jochen.AddCow(böcki);

Console.WriteLine($"Anzahl der Kühe: {jochen.GetNrOfCows()}");

if(jochen.GetNrOfCows() < jochen.GetMaxNrOfCows())
{
    Cow maja = new Cow("Maja", "Braunvieh", 633);
    jochen.AddCow(maja);
}

jochen.RemoveCow();
Console.WriteLine($"Anzahl der Kühe: {jochen.GetNrOfCows()}");
if (jochen.GetNrOfCows() < jochen.GetMaxNrOfCows())
{
    Cow maja = new Cow("Maja", "Braunvieh", 633);
    jochen.AddCow(maja);
}
Console.WriteLine($"Anzahl der Kühe: {jochen.GetNrOfCows()}");
