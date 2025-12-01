using Hue6;

Traktor t = new Traktor("Fendt", "Vario 700", 2019, 1500);
Console.WriteLine($"Aktuelle Betriebsstunden von {t.Brand}: {t.OperatingHours}");

t.ReadBetriebsstundenUndSetzen();
Console.WriteLine($"Neue Betriebsstunden: {t.OperatingHours}");
