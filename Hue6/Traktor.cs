using System;

namespace Hue6
{
    internal class Traktor
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int YearofConstruction { get; set; }

        private int operatingHours;

        public int OperatingHours
        {
            get => operatingHours;
            set
            {
                if (value < operatingHours)
                {
                    Console.WriteLine("Betriebsstunden dürfen nicht kleiner als der aktuelle Wert gesetzt werden!");
                }
                else
                {
                    operatingHours = value;
                }
            }
        }

        public Traktor(string brand, string model, int yearofConstruction, int operatingHours)
        {
            Brand = brand;
            Model = model;
            YearofConstruction = yearofConstruction;
            this.operatingHours = operatingHours; // initialer Wert kann beliebig sein
        }

        public void ReadBetriebsstundenUndSetzen()
        {
            while (true)
            {
                Console.Write("Betriebsstunden eingeben: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    if (value < OperatingHours)
                    {
                        Console.WriteLine("Fehler: Betriebsstunden dürfen nicht kleiner als der aktuelle Wert sein!");
                        continue;
                    }

                    OperatingHours = value;
                    break;
                }

                Console.WriteLine("Ungültige Eingabe! Bitte eine Zahl eingeben.");
            }
        }
    }
}
