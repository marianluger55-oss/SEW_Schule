using Hue6._2;

Console.WriteLine("---Temperatur Umrechner---");

Console.WriteLine("Bitte Temperatur in Celcius eingeben:");
int celsius = Convert.ToInt32(Console.ReadLine());

Temperatur temp = new Temperatur(celsius);
temp.InFahrenheitUmrechnen();
Console.WriteLine("Bitte Temperatur in Fahrenheit eingeben:");
int fahrenheit = Convert.ToInt32(Console.ReadLine());
temp.InCelciusUmrechnen(fahrenheit);


