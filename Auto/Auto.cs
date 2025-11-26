using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Car
    {

        public string Marke { get; set; }
        public string Modell { get; set; }
        public int Baujahr { get; set; }
        public int Geschwindigkeit { get; set; }

        public void Beschleunigen(int erhöhung)
        {
            Geschwindigkeit += erhöhung;
            Console.WriteLine($"{Marke} {Modell} beschleunigt auf {Geschwindigkeit} km/h.");
        }

        public void Bremsen(int verringerung)
        {
            Geschwindigkeit -= verringerung;
            if (Geschwindigkeit < 0)
            {
                Geschwindigkeit = 0;
            }
            Console.WriteLine($"{Marke} {Modell} bremst auf {Geschwindigkeit} km/h.");
        }

    }
}
