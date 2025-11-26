using Auto;
Car auto = new Car
{
    Marke = "BMW",
    Modell = "M3",
    Baujahr = 2020,
    Geschwindigkeit = 200
};

Console.WriteLine($"Auto: {auto.Marke} {auto.Modell}, Baujahr: {auto.Baujahr}, Geschwindigkeit: {auto.Geschwindigkeit} km/h");