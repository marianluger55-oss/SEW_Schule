using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hue6._2
{



   
    internal class Temperatur
    {   
        
        int celcius { get; set; }

     

        public Temperatur(int celsius)
        {
            this.celcius = celsius;
            return; 
        }

        public void InFahrenheitUmrechnen()
        {
            double fahrenheit = (celcius * 9 / 5) + 32;
            Console.WriteLine($"{celcius}°C sind {fahrenheit}°F");
        }

        public void InCelciusUmrechnen(int fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit}°F sind {celsius}°C");
        }






    }
}
